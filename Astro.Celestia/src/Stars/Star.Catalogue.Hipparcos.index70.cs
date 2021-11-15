using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_70() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259431"},
        {"Hipparcos Number", "HIP 31235"},
        {"Geneva Identification System", "GEN# +1.00259431"},
        {"Smithsonian Astrophysical Observation", "SAO 95823"},
        {"Wilson Evans Batten Catalogue", "WEB 6243"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.27163308),
        dec: Angle.Degrees(+10.32222563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119784"},
        {"Hipparcos Number", "HIP 67104"},
        {"Smithsonian Astrophysical Observation", "SAO 100689"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.30611605),
        dec: Angle.Degrees(+10.32541423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255045"},
        {"Hipparcos Number", "HIP 30010"},
        {"Geneva Identification System", "GEN# +1.00255045"},
        {"Smithsonian Astrophysical Observation", "SAO 95522"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.74551991),
        dec: Angle.Degrees(+10.32604642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126957"},
        {"Hipparcos Number", "HIP 70785"},
        {"Smithsonian Astrophysical Observation", "SAO 101040"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.13426198),
        dec: Angle.Degrees(+10.32612027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14906"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.09460110),
        dec: Angle.Degrees(+10.32640858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122548"},
        {"Hipparcos Number", "HIP 68583"},
        {"Smithsonian Astrophysical Observation", "SAO 100823"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.59944297),
        dec: Angle.Degrees(+10.32698056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34957"},
        {"Hipparcos Number", "HIP 25033"},
        {"Smithsonian Astrophysical Observation", "SAO 94491"},
        {"Wilson Evans Batten Catalogue", "WEB 4848"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.41212660),
        dec: Angle.Degrees(+10.32713652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214057"},
        {"Hipparcos Number", "HIP 111518"},
        {"Smithsonian Astrophysical Observation", "SAO 108021"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.91167862),
        dec: Angle.Degrees(+10.32733587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61090"},
        {"Geneva Identification System", "GEN# +0.01102469"},
        {"Smithsonian Astrophysical Observation", "SAO 100136"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.81058840),
        dec: Angle.Degrees(+10.32789077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 727"},
        {"Hipparcos Number", "HIP 943"},
        {"Smithsonian Astrophysical Observation", "SAO 91768"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.90614540),
        dec: Angle.Degrees(+10.32845614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13556"},
        {"Hipparcos Number", "HIP 10288"},
        {"Geneva Identification System", "GEN# +1.00013556"},
        {"Smithsonian Astrophysical Observation", "SAO 92835"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.12491010),
        dec: Angle.Degrees(+10.32885307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93902"},
        {"Hipparcos Number", "HIP 52999"},
        {"Smithsonian Astrophysical Observation", "SAO 99314"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.62815222),
        dec: Angle.Degrees(+10.33027042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92339"},
        {"Hipparcos Number", "HIP 52198"},
        {"Smithsonian Astrophysical Observation", "SAO 99240"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.96620819),
        dec: Angle.Degrees(+10.33033479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25102"},
        {"Hipparcos Number", "HIP 18658"},
        {"Geneva Identification System", "GEN# +5.20250008"},
        {"Smithsonian Astrophysical Observation", "SAO 93710"},
        {"Wilson Evans Batten Catalogue", "WEB 3594"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.91839435),
        dec: Angle.Degrees(+10.33041083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195103"},
        {"Hipparcos Number", "HIP 101034"},
        {"Smithsonian Astrophysical Observation", "SAO 106149"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.24084312),
        dec: Angle.Degrees(+10.33127142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222764"},
        {"Hipparcos Number", "HIP 117020"},
        {"Fundamental Katalog 5th Edition", "FK5 3902"},
        {"Geneva Identification System", "GEN# +1.00222764"},
        {"Smithsonian Astrophysical Observation", "SAO 108789"},
        {"Wilson Evans Batten Catalogue", "WEB 20634"},
    },
    visualMagnitude: 5.09,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.84315202),
        dec: Angle.Degrees(+10.33150851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48210"},
        {"Hipparcos Number", "HIP 32139"},
        {"Smithsonian Astrophysical Observation", "SAO 96026"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.67297105),
        dec: Angle.Degrees(+10.33166094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107591"},
    },
    visualMagnitude: 12.17,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.87040628),
        dec: Angle.Degrees(+10.33172987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105431",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14893 AB"},
        {"Aitken 2", "ADS 14893"},
        {"Henry Draper", "HD 203345"},
        {"Hipparcos Number", "HIP 105431"},
        {"Geneva Identification System", "GEN# +1.00203345J"},
        {"Smithsonian Astrophysical Observation", "SAO 107061"},
        {"Wilson Evans Batten Catalogue", "WEB 19149"},
        {"Wilson Evans Batten Catalogue 2", "WEB 19148"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.33983356),
        dec: Angle.Degrees(+10.33237822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42655"},
        {"Hipparcos Number", "HIP 29446"},
        {"Celescope Catalog", "CEL 1119"},
        {"Geneva Identification System", "GEN# +1.00042655"},
        {"Smithsonian Astrophysical Observation", "SAO 95375"},
        {"Wilson Evans Batten Catalogue", "WEB 5791"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.06639878),
        dec: Angle.Degrees(+10.33342808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101955"},
        {"Hipparcos Number", "HIP 57228"},
        {"Smithsonian Astrophysical Observation", "SAO 99761"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.01345573),
        dec: Angle.Degrees(+10.33698517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215809"},
        {"Hipparcos Number", "HIP 112547"},
        {"Smithsonian Astrophysical Observation", "SAO 108178"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.93131981),
        dec: Angle.Degrees(+10.33812998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37561"},
        {"Hipparcos Number", "HIP 26646"},
        {"Smithsonian Astrophysical Observation", "SAO 94736"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.94657400),
        dec: Angle.Degrees(+10.33924128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220092"},
        {"Hipparcos Number", "HIP 115285"},
        {"Smithsonian Astrophysical Observation", "SAO 108558"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.23560652),
        dec: Angle.Degrees(+10.33939612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142299"},
        {"Hipparcos Number", "HIP 77825"},
        {"Smithsonian Astrophysical Observation", "SAO 101795"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.37238121),
        dec: Angle.Degrees(+10.34471710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179100"},
        {"Hipparcos Number", "HIP 94220"},
        {"Geneva Identification System", "GEN# +1.00179100"},
        {"Smithsonian Astrophysical Observation", "SAO 104560"},
        {"Wilson Evans Batten Catalogue", "WEB 16410"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.70720643),
        dec: Angle.Degrees(+10.34581940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58646"},
        {"Smithsonian Astrophysical Observation", "SAO 99913"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.38602721),
        dec: Angle.Degrees(+10.35068834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16686"},
        {"Hipparcos Number", "HIP 12497"},
        {"Smithsonian Astrophysical Observation", "SAO 93050"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.19730321),
        dec: Angle.Degrees(+10.35069591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97787",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13041 A"},
        {"Henry Draper", "HD 187961"},
        {"Hipparcos Number", "HIP 97787"},
        {"Geneva Identification System", "GEN# +1.00187961A"},
        {"Smithsonian Astrophysical Observation", "SAO 105355"},
        {"Wilson Evans Batten Catalogue", "WEB 17202"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.06492787),
        dec: Angle.Degrees(+10.35162148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180812"},
        {"Hipparcos Number", "HIP 94826"},
        {"Smithsonian Astrophysical Observation", "SAO 104686"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.42193186),
        dec: Angle.Degrees(+10.35208067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58162"},
        {"Smithsonian Astrophysical Observation", "SAO 99870"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.92447821),
        dec: Angle.Degrees(+10.35469496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132447"},
        {"Hipparcos Number", "HIP 73311"},
        {"Fundamental Katalog 5th Edition", "FK5 5328"},
        {"Smithsonian Astrophysical Observation", "SAO 101310"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.72386271),
        dec: Angle.Degrees(+10.35488323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211683"},
        {"Hipparcos Number", "HIP 110141"},
        {"Smithsonian Astrophysical Observation", "SAO 107815"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.65672082),
        dec: Angle.Degrees(+10.35520223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92686"},
        {"Hipparcos Number", "HIP 52373"},
        {"Smithsonian Astrophysical Observation", "SAO 99257"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.56957362),
        dec: Angle.Degrees(+10.35556050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 356938"},
        {"Hipparcos Number", "HIP 99215"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.12065201),
        dec: Angle.Degrees(+10.35788508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11638"},
        {"Hipparcos Number", "HIP 8887"},
        {"Smithsonian Astrophysical Observation", "SAO 92690"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.60211198),
        dec: Angle.Degrees(+10.36138441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221280"},
        {"Hipparcos Number", "HIP 116037"},
        {"Smithsonian Astrophysical Observation", "SAO 108652"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.67484177),
        dec: Angle.Degrees(+10.36185478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161076"},
        {"Hipparcos Number", "HIP 86717"},
        {"Smithsonian Astrophysical Observation", "SAO 103047"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.77912194),
        dec: Angle.Degrees(+10.36229051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132913"},
        {"Hipparcos Number", "HIP 73503"},
        {"Geneva Identification System", "GEN# +1.00132913"},
        {"Smithsonian Astrophysical Observation", "SAO 101330"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.35354191),
        dec: Angle.Degrees(+10.36264638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194116"},
        {"Hipparcos Number", "HIP 100559"},
        {"Smithsonian Astrophysical Observation", "SAO 106054"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.86247205),
        dec: Angle.Degrees(+10.36313299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3960"},
        {"Geneva Identification System", "GEN# +9.80001028"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.71356104),
        dec: Angle.Degrees(+10.36412573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 278.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158575"},
        {"Hipparcos Number", "HIP 85611"},
        {"Smithsonian Astrophysical Observation", "SAO 102856"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.42183108),
        dec: Angle.Degrees(+10.36458797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75909"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.57818942),
        dec: Angle.Degrees(+10.36624206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207758"},
        {"Hipparcos Number", "HIP 107858"},
        {"Geneva Identification System", "GEN# +1.00207758"},
        {"Smithsonian Astrophysical Observation", "SAO 107437"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.78101672),
        dec: Angle.Degrees(+10.36799103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149305"},
        {"Hipparcos Number", "HIP 81073"},
        {"Smithsonian Astrophysical Observation", "SAO 102242"},
        {"Wilson Evans Batten Catalogue", "WEB 13710"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.39179389),
        dec: Angle.Degrees(+10.36907382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8331"},
        {"Hipparcos Number", "HIP 6442"},
        {"Geneva Identification System", "GEN# +1.00008331"},
        {"Smithsonian Astrophysical Observation", "SAO 92406"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.68129863),
        dec: Angle.Degrees(+10.36977468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213192"},
        {"Hipparcos Number", "HIP 111031"},
        {"Smithsonian Astrophysical Observation", "SAO 107953"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.39881577),
        dec: Angle.Degrees(+10.37040269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146229"},
        {"Hipparcos Number", "HIP 79626"},
        {"Smithsonian Astrophysical Observation", "SAO 102032"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.72971212),
        dec: Angle.Degrees(+10.37277313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220289"},
        {"Hipparcos Number", "HIP 115398"},
        {"Smithsonian Astrophysical Observation", "SAO 108571"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.64178187),
        dec: Angle.Degrees(+10.37360281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79682"},
        {"Hipparcos Number", "HIP 45453"},
        {"Smithsonian Astrophysical Observation", "SAO 98462"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.95650818),
        dec: Angle.Degrees(+10.37395709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184131"},
        {"Hipparcos Number", "HIP 96123"},
        {"Smithsonian Astrophysical Observation", "SAO 104952"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.16630605),
        dec: Angle.Degrees(+10.37409679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92992"},
        {"Hipparcos Number", "HIP 52532"},
        {"Smithsonian Astrophysical Observation", "SAO 99272"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.10839307),
        dec: Angle.Degrees(+10.37489613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185019"},
        {"Hipparcos Number", "HIP 96482"},
        {"Smithsonian Astrophysical Observation", "SAO 105044"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.21851029),
        dec: Angle.Degrees(+10.37754279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65859"},
        {"Cincinnati Publication", "Ci 20 782"},
        {"Geneva Identification System", "GEN# +0.01102576"},
        {"Wilson Evans Batten Catalogue", "WEB 11651"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.49632115),
        dec: Angle.Degrees(+10.37977331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1128.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1074.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6665 AB"},
        {"Henry Draper", "HD 68643"},
        {"Hipparcos Number", "HIP 40284"},
        {"Smithsonian Astrophysical Observation", "SAO 97664"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.39987713),
        dec: Angle.Degrees(+10.38067646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137986"},
        {"Hipparcos Number", "HIP 75784"},
        {"Smithsonian Astrophysical Observation", "SAO 101574"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.22052843),
        dec: Angle.Degrees(+10.38317532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64603"},
        {"Hipparcos Number", "HIP 38672"},
        {"Smithsonian Astrophysical Observation", "SAO 97367"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.76566747),
        dec: Angle.Degrees(+10.38469522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84764"},
        {"Hipparcos Number", "HIP 48049"},
        {"Geneva Identification System", "GEN# +1.00084764"},
        {"Smithsonian Astrophysical Observation", "SAO 98771"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.92213586),
        dec: Angle.Degrees(+10.38493073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174003"},
        {"Hipparcos Number", "HIP 92252"},
        {"Smithsonian Astrophysical Observation", "SAO 104113"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.01049113),
        dec: Angle.Degrees(+10.38611500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113715"},
        {"Hipparcos Number", "HIP 63875"},
        {"Smithsonian Astrophysical Observation", "SAO 100404"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.36384317),
        dec: Angle.Degrees(+10.38689139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2592"},
        {"Hipparcos Number", "HIP 2315"},
        {"Smithsonian Astrophysical Observation", "SAO 91923"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.38348370),
        dec: Angle.Degrees(+10.38718283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185548"},
        {"Hipparcos Number", "HIP 96682"},
        {"Smithsonian Astrophysical Observation", "SAO 105097"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.83612631),
        dec: Angle.Degrees(+10.38790114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31918"},
        {"Hipparcos Number", "HIP 23239"},
        {"Celescope Catalog", "CEL 502"},
        {"Geneva Identification System", "GEN# +1.00031918"},
        {"Smithsonian Astrophysical Observation", "SAO 94249"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.00651423),
        dec: Angle.Degrees(+10.39079294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47754"},
        {"Hipparcos Number", "HIP 31951"},
        {"Smithsonian Astrophysical Observation", "SAO 95986"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.15220396),
        dec: Angle.Degrees(+10.39196474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104937"},
        {"Smithsonian Astrophysical Observation", "SAO 106964"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.84750668),
        dec: Angle.Degrees(+10.39446666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287163"},
        {"Hipparcos Number", "HIP 22351"},
        {"Smithsonian Astrophysical Observation", "SAO 94140"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.18045234),
        dec: Angle.Degrees(+10.39517456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62723"},
        {"Hipparcos Number", "HIP 37871"},
        {"Geneva Identification System", "GEN# +1.00062723"},
        {"Smithsonian Astrophysical Observation", "SAO 97219"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.44298637),
        dec: Angle.Degrees(+10.39623296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21663",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3363 AB"},
        {"Henry Draper", "HD 286948"},
        {"Hipparcos Number", "HIP 21663"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.76659082),
        dec: Angle.Degrees(+10.39894481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56965"},
        {"Hipparcos Number", "HIP 35500"},
        {"Smithsonian Astrophysical Observation", "SAO 96775"},
        {"Wilson Evans Batten Catalogue", "WEB 7080"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.89488012),
        dec: Angle.Degrees(+10.39927947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222441"},
        {"Hipparcos Number", "HIP 116817"},
        {"Geneva Identification System", "GEN# +1.00222441"},
        {"Smithsonian Astrophysical Observation", "SAO 108763"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.13285519),
        dec: Angle.Degrees(+10.40033075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40711"},
        {"Hipparcos Number", "HIP 28501"},
        {"Geneva Identification System", "GEN# +1.00040711"},
        {"Renson", "Renson 10880"},
        {"Smithsonian Astrophysical Observation", "SAO 95120"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.25539947),
        dec: Angle.Degrees(+10.40150671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165571"},
        {"Hipparcos Number", "HIP 88682"},
        {"Smithsonian Astrophysical Observation", "SAO 103382"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.55600443),
        dec: Angle.Degrees(+10.40293693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213646"},
        {"Hipparcos Number", "HIP 111300"},
        {"Geneva Identification System", "GEN# +1.00213646"},
        {"Smithsonian Astrophysical Observation", "SAO 107990"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.20308336),
        dec: Angle.Degrees(+10.40542134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -252.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51720"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.51414125),
        dec: Angle.Degrees(+10.40547896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6695",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1139 AB"},
        {"Henry Draper", "HD 8703"},
        {"Hipparcos Number", "HIP 6695"},
        {"Fundamental Katalog 5th Edition", "FK5 4133"},
        {"Geneva Identification System", "GEN# +1.00008703"},
        {"Smithsonian Astrophysical Observation", "SAO 92434"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.49255949),
        dec: Angle.Degrees(+10.40696098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33720"},
        {"Hipparcos Number", "HIP 24273"},
        {"Geneva Identification System", "GEN# +1.00033720"},
        {"Smithsonian Astrophysical Observation", "SAO 94392"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.14452971),
        dec: Angle.Degrees(+10.40830378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180125"},
        {"Hipparcos Number", "HIP 94588"},
        {"Smithsonian Astrophysical Observation", "SAO 104642"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.74210045),
        dec: Angle.Degrees(+10.40940739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4835"},
        {"Hipparcos Number", "HIP 3938"},
        {"Fundamental Katalog 5th Edition", "FK5 4074"},
        {"Smithsonian Astrophysical Observation", "SAO 92112"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.63903487),
        dec: Angle.Degrees(+10.41158658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156315"},
        {"Hipparcos Number", "HIP 84503"},
        {"Smithsonian Astrophysical Observation", "SAO 102703"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.13670379),
        dec: Angle.Degrees(+10.41315610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216384"},
        {"Hipparcos Number", "HIP 112932"},
        {"Geneva Identification System", "GEN# +1.00216384"},
        {"Smithsonian Astrophysical Observation", "SAO 108222"},
        {"Wilson Evans Batten Catalogue", "WEB 20110"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.08604423),
        dec: Angle.Degrees(+10.41442538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81285"},
        {"Hipparcos Number", "HIP 46189"},
        {"Smithsonian Astrophysical Observation", "SAO 98558"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.25942090),
        dec: Angle.Degrees(+10.41521348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241082"},
        {"Hipparcos Number", "HIP 23960"},
        {"Smithsonian Astrophysical Observation", "SAO 94349"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.24785991),
        dec: Angle.Degrees(+10.41580696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97675",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13012 A"},
        {"Henry Draper", "HD 187691"},
        {"Hipparcos Number", "HIP 97675"},
        {"Geneva Identification System", "GEN# +1.00187691A"},
        {"Smithsonian Astrophysical Observation", "SAO 105338"},
        {"Wilson Evans Batten Catalogue", "WEB 17176"},
    },
    visualMagnitude: 5.12,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.75625098),
        dec: Angle.Degrees(+10.41605390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156498"},
        {"Hipparcos Number", "HIP 84595"},
        {"Geneva Identification System", "GEN# +1.00156498"},
        {"Smithsonian Astrophysical Observation", "SAO 102718"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.39447026),
        dec: Angle.Degrees(+10.41646268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177623"},
        {"Hipparcos Number", "HIP 93737"},
        {"Geneva Identification System", "GEN# +1.00177623"},
        {"Smithsonian Astrophysical Observation", "SAO 104457"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.29886363),
        dec: Angle.Degrees(+10.41682731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99404"},
        {"Hipparcos Number", "HIP 55820"},
        {"Cincinnati Publication", "Ci 18 1403"},
        {"Geneva Identification System", "GEN# +1.00099404"},
        {"Smithsonian Astrophysical Observation", "SAO 99605"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.60510745),
        dec: Angle.Degrees(+10.42292927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -380.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2157"},
        {"Hipparcos Number", "HIP 2035"},
        {"Smithsonian Astrophysical Observation", "SAO 91889"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.45743387),
        dec: Angle.Degrees(+10.42336384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101843"},
        {"Hipparcos Number", "HIP 57159"},
        {"Smithsonian Astrophysical Observation", "SAO 99753"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.83637388),
        dec: Angle.Degrees(+10.42355092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74931",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9580 B"},
        {"Henry Draper", "HD 136160B"},
        {"Hipparcos Number", "HIP 74931"},
        {"Geneva Identification System", "GEN# +1.00136160B"},
        {"Smithsonian Astrophysical Observation", "SAO 101481"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.67576044),
        dec: Angle.Degrees(+10.42407653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110377"},
        {"Hipparcos Number", "HIP 61937"},
        {"Geneva Identification System", "GEN# +1.00110377"},
        {"Smithsonian Astrophysical Observation", "SAO 100207"},
        {"Wilson Evans Batten Catalogue", "WEB 11011"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.39356290),
        dec: Angle.Degrees(+10.42626827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74930",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9580 A"},
        {"Henry Draper", "HD 136160"},
        {"Henry Draper 2", "HD 136160A"},
        {"Hipparcos Number", "HIP 74930"},
        {"Fundamental Katalog 5th Edition", "FK5 1401"},
        {"Smithsonian Astrophysical Observation", "SAO 101480"},
        {"Wilson Evans Batten Catalogue", "WEB 12781"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.67493696),
        dec: Angle.Degrees(+10.42768238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9035"},
        {"Hipparcos Number", "HIP 6919"},
        {"Smithsonian Astrophysical Observation", "SAO 92457"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.27269477),
        dec: Angle.Degrees(+10.43220709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75315"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.80869189),
        dec: Angle.Degrees(+10.43280846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75157"},
        {"Hipparcos Number", "HIP 43245"},
        {"Smithsonian Astrophysical Observation", "SAO 98142"},
        {"Wilson Evans Batten Catalogue", "WEB 8338"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.15431548),
        dec: Angle.Degrees(+10.43301492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128186"},
        {"Hipparcos Number", "HIP 71330"},
        {"Smithsonian Astrophysical Observation", "SAO 101091"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.80685699),
        dec: Angle.Degrees(+10.43346469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205355"},
        {"Hipparcos Number", "HIP 106516"},
        {"Geneva Identification System", "GEN# +1.00205355"},
        {"Smithsonian Astrophysical Observation", "SAO 107242"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.60910493),
        dec: Angle.Degrees(+10.43470438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224088"},
        {"Hipparcos Number", "HIP 117909"},
        {"Smithsonian Astrophysical Observation", "SAO 108906"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.74054741),
        dec: Angle.Degrees(+10.43733185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258523"},
        {"Hipparcos Number", "HIP 30994"},
        {"Smithsonian Astrophysical Observation", "SAO 95761"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.57711142),
        dec: Angle.Degrees(+10.43759154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74092"},
        {"Hipparcos Number", "HIP 42704"},
        {"Smithsonian Astrophysical Observation", "SAO 98056"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.54371405),
        dec: Angle.Degrees(+10.43845361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72770"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.13368847),
        dec: Angle.Degrees(+10.43864624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208669"},
        {"Hipparcos Number", "HIP 108408"},
        {"Geneva Identification System", "GEN# +1.00208669"},
        {"Smithsonian Astrophysical Observation", "SAO 107543"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.42407463),
        dec: Angle.Degrees(+10.44056043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47662"},
        {"Hipparcos Number", "HIP 31917"},
        {"Smithsonian Astrophysical Observation", "SAO 95981"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.05570930),
        dec: Angle.Degrees(+10.44131708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102834"},
        {"Smithsonian Astrophysical Observation", "SAO 106545"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.50101961),
        dec: Angle.Degrees(+10.44134643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171315"},
        {"Hipparcos Number", "HIP 91000"},
        {"Smithsonian Astrophysical Observation", "SAO 103850"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.45486567),
        dec: Angle.Degrees(+10.44239674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165509"},
        {"Hipparcos Number", "HIP 88647"},
        {"Smithsonian Astrophysical Observation", "SAO 103377"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.47928140),
        dec: Angle.Degrees(+10.44272552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167786"},
        {"Hipparcos Number", "HIP 89555"},
        {"Smithsonian Astrophysical Observation", "SAO 103549"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.11573615),
        dec: Angle.Degrees(+10.44299068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64745"},
        {"Hipparcos Number", "HIP 38734"},
        {"Geneva Identification System", "GEN# +1.00064745"},
        {"Smithsonian Astrophysical Observation", "SAO 97378"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.94856165),
        dec: Angle.Degrees(+10.44346899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93509"},
        {"Hipparcos Number", "HIP 52809"},
        {"Smithsonian Astrophysical Observation", "SAO 99296"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.94369583),
        dec: Angle.Degrees(+10.44348595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56916"},
        {"Hipparcos Number", "HIP 35484"},
        {"Smithsonian Astrophysical Observation", "SAO 96772"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.86330324),
        dec: Angle.Degrees(+10.44370449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152362"},
        {"Hipparcos Number", "HIP 82563"},
        {"Smithsonian Astrophysical Observation", "SAO 102441"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.14357571),
        dec: Angle.Degrees(+10.44413659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19510"},
        {"Hipparcos Number", "HIP 14601"},
        {"Geneva Identification System", "GEN# +1.00019510"},
        {"Smithsonian Astrophysical Observation", "SAO 93297"},
        {"Wilson Evans Batten Catalogue", "WEB 2839"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.12852164),
        dec: Angle.Degrees(+10.44611095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51168"},
        {"Smithsonian Astrophysical Observation", "SAO 99131"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.77387643),
        dec: Angle.Degrees(+10.44614149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97502"},
        {"Hipparcos Number", "HIP 54817"},
        {"Smithsonian Astrophysical Observation", "SAO 99505"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.32518754),
        dec: Angle.Degrees(+10.44734713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218142"},
        {"Hipparcos Number", "HIP 114018"},
        {"Geneva Identification System", "GEN# +1.00218142"},
        {"Smithsonian Astrophysical Observation", "SAO 108388"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.35756787),
        dec: Angle.Degrees(+10.44776573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82213"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.93869176),
        dec: Angle.Degrees(+10.44948720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8033"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.79468845),
        dec: Angle.Degrees(+10.44949763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181831"},
        {"Hipparcos Number", "HIP 95161"},
        {"Smithsonian Astrophysical Observation", "SAO 104760"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.40770126),
        dec: Angle.Degrees(+10.44990465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287008"},
        {"Hipparcos Number", "HIP 21890"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.58462716),
        dec: Angle.Degrees(+10.45103840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20079"},
        {"Hipparcos Number", "HIP 15054"},
        {"Smithsonian Astrophysical Observation", "SAO 93348"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.50182581),
        dec: Angle.Degrees(+10.45350904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154619"},
        {"Hipparcos Number", "HIP 83688"},
        {"Fundamental Katalog 5th Edition", "FK5 5507"},
        {"Geneva Identification System", "GEN# +1.00154619"},
        {"Smithsonian Astrophysical Observation", "SAO 102592"},
        {"Wilson Evans Batten Catalogue", "WEB 14151"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.55427907),
        dec: Angle.Degrees(+10.45386241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111620"},
    },
    visualMagnitude: 11.66,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.18797157),
        dec: Angle.Degrees(+10.45482679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41790"},
        {"Hipparcos Number", "HIP 29040"},
        {"Smithsonian Astrophysical Observation", "SAO 95260"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.89954961),
        dec: Angle.Degrees(+10.45632193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211246"},
        {"Hipparcos Number", "HIP 109909"},
        {"Geneva Identification System", "GEN# +1.00211246"},
        {"Smithsonian Astrophysical Observation", "SAO 107772"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.90566412),
        dec: Angle.Degrees(+10.45685236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102419"},
        {"Hipparcos Number", "HIP 57516"},
        {"Smithsonian Astrophysical Observation", "SAO 99792"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.83359766),
        dec: Angle.Degrees(+10.45732856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18173"},
        {"Hipparcos Number", "HIP 13611"},
        {"Geneva Identification System", "GEN# +1.00018173"},
        {"Smithsonian Astrophysical Observation", "SAO 93186"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.84672708),
        dec: Angle.Degrees(+10.45736473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86435"},
        {"Hipparcos Number", "HIP 48921"},
        {"Smithsonian Astrophysical Observation", "SAO 98881"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.69038464),
        dec: Angle.Degrees(+10.45856696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21687"},
        {"Hipparcos Number", "HIP 16325"},
        {"Smithsonian Astrophysical Observation", "SAO 93464"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.60987673),
        dec: Angle.Degrees(+10.45881814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186864"},
        {"Hipparcos Number", "HIP 97306"},
        {"Smithsonian Astrophysical Observation", "SAO 105233"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.64330574),
        dec: Angle.Degrees(+10.46018669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179938"},
        {"Hipparcos Number", "HIP 94511"},
        {"Smithsonian Astrophysical Observation", "SAO 104628"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.53808509),
        dec: Angle.Degrees(+10.46126548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15837",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15837"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.99836956),
        dec: Angle.Degrees(+10.46169287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26172"},
        {"Hipparcos Number", "HIP 19359"},
        {"Smithsonian Astrophysical Observation", "SAO 93783"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.20667901),
        dec: Angle.Degrees(+10.46371472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184011"},
        {"Hipparcos Number", "HIP 96068"},
        {"Smithsonian Astrophysical Observation", "SAO 104940"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.99806454),
        dec: Angle.Degrees(+10.46482056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173191"},
        {"Hipparcos Number", "HIP 91872"},
        {"Smithsonian Astrophysical Observation", "SAO 104031"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.94016478),
        dec: Angle.Degrees(+10.46518708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198110"},
        {"Hipparcos Number", "HIP 102627"},
        {"Geneva Identification System", "GEN# +1.00198110"},
        {"Renson", "Renson 55140"},
        {"Smithsonian Astrophysical Observation", "SAO 106498"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.93848064),
        dec: Angle.Degrees(+10.46534255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4644"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.90864749),
        dec: Angle.Degrees(+10.46698501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117140"},
        {"Hipparcos Number", "HIP 65711"},
        {"Smithsonian Astrophysical Observation", "SAO 100578"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.08202706),
        dec: Angle.Degrees(+10.46871882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192501"},
        {"Hipparcos Number", "HIP 99796"},
        {"Smithsonian Astrophysical Observation", "SAO 105887"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.71548352),
        dec: Angle.Degrees(+10.47233974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212960"},
        {"Hipparcos Number", "HIP 110878"},
        {"Smithsonian Astrophysical Observation", "SAO 107931"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.95909103),
        dec: Angle.Degrees(+10.47298447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197277"},
        {"Hipparcos Number", "HIP 102194"},
        {"Smithsonian Astrophysical Observation", "SAO 106403"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.59127361),
        dec: Angle.Degrees(+10.47323361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12907"},
        {"Hipparcos Number", "HIP 9842"},
        {"Geneva Identification System", "GEN# +1.00012907"},
        {"Smithsonian Astrophysical Observation", "SAO 92798"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.66499139),
        dec: Angle.Degrees(+10.47756302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196424"},
        {"Hipparcos Number", "HIP 101708"},
        {"Geneva Identification System", "GEN# +1.00196424"},
        {"Smithsonian Astrophysical Observation", "SAO 106304"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.24034412),
        dec: Angle.Degrees(+10.47838430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216048"},
        {"Hipparcos Number", "HIP 112714"},
        {"Geneva Identification System", "GEN# +1.00216048"},
        {"Smithsonian Astrophysical Observation", "SAO 108204"},
        {"Wilson Evans Batten Catalogue", "WEB 20085"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.38375866),
        dec: Angle.Degrees(+10.47870157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28135"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.20105281),
        dec: Angle.Degrees(+10.47976578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42252"},
        {"Hipparcos Number", "HIP 29254"},
        {"Geneva Identification System", "GEN# +1.00042252"},
        {"Smithsonian Astrophysical Observation", "SAO 95320"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.52999575),
        dec: Angle.Degrees(+10.47999466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13748"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.24429555),
        dec: Angle.Degrees(+10.48130653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222696"},
        {"Hipparcos Number", "HIP 116979"},
        {"Smithsonian Astrophysical Observation", "SAO 108785"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.71146090),
        dec: Angle.Degrees(+10.48190792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105104"},
        {"Hipparcos Number", "HIP 59025"},
        {"Smithsonian Astrophysical Observation", "SAO 99939"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.52534766),
        dec: Angle.Degrees(+10.48221760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170598"},
        {"Hipparcos Number", "HIP 90665"},
        {"Geneva Identification System", "GEN# +1.00170598"},
        {"Smithsonian Astrophysical Observation", "SAO 103782"},
        {"Wilson Evans Batten Catalogue", "WEB 15528"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.48806890),
        dec: Angle.Degrees(+10.48288389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143330"},
        {"Hipparcos Number", "HIP 78321"},
        {"Smithsonian Astrophysical Observation", "SAO 101854"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.87530778),
        dec: Angle.Degrees(+10.48334456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107257"},
        {"Hipparcos Number", "HIP 60130"},
        {"Geneva Identification System", "GEN# +1.00107257"},
        {"Smithsonian Astrophysical Observation", "SAO 100046"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.97778497),
        dec: Angle.Degrees(+10.48441775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2912"},
        {"Hipparcos Number", "HIP 2559"},
        {"Geneva Identification System", "GEN# +1.00002912"},
        {"Smithsonian Astrophysical Observation", "SAO 91954"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.13046195),
        dec: Angle.Degrees(+10.48666945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109305"},
        {"Smithsonian Astrophysical Observation", "SAO 107688"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.17659944),
        dec: Angle.Degrees(+10.48729964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80521"},
        {"Smithsonian Astrophysical Observation", "SAO 102167"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.57211787),
        dec: Angle.Degrees(+10.48730535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141159"},
        {"Hipparcos Number", "HIP 77340"},
        {"Smithsonian Astrophysical Observation", "SAO 101738"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.83503255),
        dec: Angle.Degrees(+10.48827334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78662"},
        {"Hipparcos Number", "HIP 44991"},
        {"Smithsonian Astrophysical Observation", "SAO 98404"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.45699987),
        dec: Angle.Degrees(+10.49061129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182492"},
        {"Hipparcos Number", "HIP 95419"},
        {"Smithsonian Astrophysical Observation", "SAO 104799"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.14812738),
        dec: Angle.Degrees(+10.49179890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130788"},
        {"Hipparcos Number", "HIP 72534"},
        {"Smithsonian Astrophysical Observation", "SAO 101237"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.45031507),
        dec: Angle.Degrees(+10.49291672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171409"},
        {"Hipparcos Number", "HIP 91047"},
        {"Smithsonian Astrophysical Observation", "SAO 103860"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.59127205),
        dec: Angle.Degrees(+10.49926661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84125"},
        {"Hipparcos Number", "HIP 47665"},
        {"Geneva Identification System", "GEN# +1.00084125"},
        {"Smithsonian Astrophysical Observation", "SAO 98727"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.78899218),
        dec: Angle.Degrees(+10.49986456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66686"},
        {"Hipparcos Number", "HIP 39558"},
        {"Geneva Identification System", "GEN# +1.00066686"},
        {"Smithsonian Astrophysical Observation", "SAO 97541"},
        {"Wilson Evans Batten Catalogue", "WEB 7732"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.25380132),
        dec: Angle.Degrees(+10.50002234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65254"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.60448091),
        dec: Angle.Degrees(+10.50055268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17722"},
        {"Smithsonian Astrophysical Observation", "SAO 93606"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.92903887),
        dec: Angle.Degrees(+10.50079299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1364"},
        {"Smithsonian Astrophysical Observation", "SAO 91817"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.27129186),
        dec: Angle.Degrees(+10.50216280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90420"},
        {"Hipparcos Number", "HIP 51105"},
        {"Smithsonian Astrophysical Observation", "SAO 99120"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.61055536),
        dec: Angle.Degrees(+10.50299944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136732"},
        {"Hipparcos Number", "HIP 75194"},
        {"Geneva Identification System", "GEN# +1.00136732"},
        {"Smithsonian Astrophysical Observation", "SAO 101505"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.48958912),
        dec: Angle.Degrees(+10.50417737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15042"},
        {"Hipparcos Number", "HIP 11319"},
        {"Geneva Identification System", "GEN# +1.00015042"},
        {"Smithsonian Astrophysical Observation", "SAO 92942"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.42250452),
        dec: Angle.Degrees(+10.50604015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63649"},
        {"Hipparcos Number", "HIP 38263"},
        {"Geneva Identification System", "GEN# +1.00063649"},
        {"Smithsonian Astrophysical Observation", "SAO 97297"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.59028110),
        dec: Angle.Degrees(+10.50610257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88724"},
        {"Hipparcos Number", "HIP 50146"},
        {"Smithsonian Astrophysical Observation", "SAO 99018"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.55129762),
        dec: Angle.Degrees(+10.50786799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112476"},
        {"Hipparcos Number", "HIP 63193"},
        {"Geneva Identification System", "GEN# +1.00112476"},
        {"Smithsonian Astrophysical Observation", "SAO 100341"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.19117448),
        dec: Angle.Degrees(+10.50925601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118840"},
        {"Hipparcos Number", "HIP 66610"},
        {"Geneva Identification System", "GEN# +1.00118840"},
        {"Smithsonian Astrophysical Observation", "SAO 100651"},
        {"Wilson Evans Batten Catalogue", "WEB 11748"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.80787829),
        dec: Angle.Degrees(+10.50978145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67588"},
        {"Hipparcos Number", "HIP 39910"},
        {"Fundamental Katalog 5th Edition", "FK5 4734"},
        {"Geneva Identification System", "GEN# +1.00067588"},
        {"Smithsonian Astrophysical Observation", "SAO 97604"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.26945010),
        dec: Angle.Degrees(+10.50979134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41306"},
        {"Hipparcos Number", "HIP 28789"},
        {"Smithsonian Astrophysical Observation", "SAO 95197"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.16700404),
        dec: Angle.Degrees(+10.50984117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125335"},
        {"Hipparcos Number", "HIP 69923"},
        {"Geneva Identification System", "GEN# +1.00125335"},
        {"Renson", "Renson 35790"},
        {"Smithsonian Astrophysical Observation", "SAO 100968"},
        {"Wilson Evans Batten Catalogue", "WEB 12163"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.64889590),
        dec: Angle.Degrees(+10.51050663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100904"},
        {"Hipparcos Number", "HIP 56646"},
        {"Smithsonian Astrophysical Observation", "SAO 99697"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.23680098),
        dec: Angle.Degrees(+10.51051925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55054"},
        {"Hipparcos Number", "HIP 34767"},
        {"Geneva Identification System", "GEN# +1.00055054"},
        {"Smithsonian Astrophysical Observation", "SAO 96616"},
        {"Wilson Evans Batten Catalogue", "WEB 6949"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.96301234),
        dec: Angle.Degrees(+10.51217970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130026"},
        {"Hipparcos Number", "HIP 72167"},
        {"Smithsonian Astrophysical Observation", "SAO 101190"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.41069233),
        dec: Angle.Degrees(+10.51394841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164332"},
        {"Hipparcos Number", "HIP 88143"},
        {"Smithsonian Astrophysical Observation", "SAO 103286"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.05091512),
        dec: Angle.Degrees(+10.51632439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30529",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5035 A"},
        {"Henry Draper", "HD 44944"},
        {"Hipparcos Number", "HIP 30529"},
        {"Renson", "Renson 11900"},
        {"Smithsonian Astrophysical Observation", "SAO 95649"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.25407016),
        dec: Angle.Degrees(+10.51757356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36913"},
        {"Hipparcos Number", "HIP 26239"},
        {"Geneva Identification System", "GEN# +1.00036913"},
        {"Smithsonian Astrophysical Observation", "SAO 94674"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.85557804),
        dec: Angle.Degrees(+10.51764896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28922"},
        {"Hipparcos Number", "HIP 21266"},
        {"Celescope Catalog", "CEL 432"},
        {"Geneva Identification System", "GEN# +1.00028922"},
        {"Smithsonian Astrophysical Observation", "SAO 94008"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.44354923),
        dec: Angle.Degrees(+10.51772173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214949"},
        {"Hipparcos Number", "HIP 112056"},
        {"Smithsonian Astrophysical Observation", "SAO 108108"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.45081289),
        dec: Angle.Degrees(+10.51839516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84183"},
        {"Hipparcos Number", "HIP 47704"},
        {"Geneva Identification System", "GEN# +1.00084183"},
        {"Smithsonian Astrophysical Observation", "SAO 98731"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.89693795),
        dec: Angle.Degrees(+10.51917424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28475"},
        {"Hipparcos Number", "HIP 20963"},
        {"Celescope Catalog", "CEL 414"},
        {"Geneva Identification System", "GEN# +1.00028475"},
        {"Smithsonian Astrophysical Observation", "SAO 93968"},
        {"Wilson Evans Batten Catalogue", "WEB 4031"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.42856575),
        dec: Angle.Degrees(+10.52185458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127987"},
        {"Hipparcos Number", "HIP 71237"},
        {"Fundamental Katalog 5th Edition", "FK5 5291"},
        {"Smithsonian Astrophysical Observation", "SAO 101082"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.52667405),
        dec: Angle.Degrees(+10.52245875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131668"},
        {"Hipparcos Number", "HIP 72969"},
        {"Smithsonian Astrophysical Observation", "SAO 101280"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.68238434),
        dec: Angle.Degrees(+10.52375083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50525"},
        {"Hipparcos Number", "HIP 33148"},
        {"Smithsonian Astrophysical Observation", "SAO 96252"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.52580675),
        dec: Angle.Degrees(+10.52489734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103751"},
        {"Hipparcos Number", "HIP 58260"},
        {"Smithsonian Astrophysical Observation", "SAO 99879"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.22209016),
        dec: Angle.Degrees(+10.52589570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51351"},
        {"Smithsonian Astrophysical Observation", "SAO 99156"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.33443541),
        dec: Angle.Degrees(+10.52642858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153132"},
        {"Hipparcos Number", "HIP 82965"},
        {"Smithsonian Astrophysical Observation", "SAO 102493"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.30766409),
        dec: Angle.Degrees(+10.52730652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134027"},
        {"Hipparcos Number", "HIP 74001"},
        {"Smithsonian Astrophysical Observation", "SAO 101377"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.83890329),
        dec: Angle.Degrees(+10.52939605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55642",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8148 AB"},
        {"Henry Draper", "HD 99028"},
        {"Hipparcos Number", "HIP 55642"},
        {"Geneva Identification System", "GEN# +1.00099028J"},
        {"Smithsonian Astrophysical Observation", "SAO 99587"},
        {"Wilson Evans Batten Catalogue", "WEB 9999"},
    },
    visualMagnitude: 4.00,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.98070334),
        dec: Angle.Degrees(+10.52969772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74180"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.35385857),
        dec: Angle.Degrees(+10.53050408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105279"},
        {"Hipparcos Number", "HIP 59110"},
        {"Geneva Identification System", "GEN# +1.00105279"},
        {"Smithsonian Astrophysical Observation", "SAO 99946"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.81675686),
        dec: Angle.Degrees(+10.53155862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195545"},
        {"Hipparcos Number", "HIP 101272"},
        {"Geneva Identification System", "GEN# +1.00195545"},
        {"Smithsonian Astrophysical Observation", "SAO 106202"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.91701322),
        dec: Angle.Degrees(+10.53184192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215975"},
        {"Hipparcos Number", "HIP 112649"},
        {"Geneva Identification System", "GEN# +1.00215975"},
        {"Smithsonian Astrophysical Observation", "SAO 108194"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.22370672),
        dec: Angle.Degrees(+10.53244984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177254"},
        {"Hipparcos Number", "HIP 93582"},
        {"Geneva Identification System", "GEN# +1.00177254"},
        {"Smithsonian Astrophysical Observation", "SAO 104417"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.88868195),
        dec: Angle.Degrees(+10.53264868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34603"},
        {"Hipparcos Number", "HIP 24807"},
        {"Smithsonian Astrophysical Observation", "SAO 94459"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.77541762),
        dec: Angle.Degrees(+10.53357567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158418"},
        {"Hipparcos Number", "HIP 85534"},
        {"Smithsonian Astrophysical Observation", "SAO 102846"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.19900529),
        dec: Angle.Degrees(+10.53404737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100493"},
    },
    visualMagnitude: 11.73,
    bvColour: 1.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.67431808),
        dec: Angle.Degrees(+10.53707247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27535"},
        {"Hipparcos Number", "HIP 20318"},
        {"Smithsonian Astrophysical Observation", "SAO 93879"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.28702567),
        dec: Angle.Degrees(+10.53774587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37943"},
        {"Hipparcos Number", "HIP 26887"},
        {"Geneva Identification System", "GEN# +1.00037943"},
        {"Smithsonian Astrophysical Observation", "SAO 94789"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.62529607),
        dec: Angle.Degrees(+10.53849892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76276",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9701 AB"},
        {"Henry Draper", "HD 138917J"},
        {"Hipparcos Number", "HIP 76276"},
    },
    visualMagnitude: 3.80,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.70079260),
        dec: Angle.Degrees(+10.53885916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141934"},
        {"Hipparcos Number", "HIP 77667"},
        {"Smithsonian Astrophysical Observation", "SAO 101776"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.85302333),
        dec: Angle.Degrees(+10.53986593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154031"},
        {"Hipparcos Number", "HIP 83392"},
        {"Smithsonian Astrophysical Observation", "SAO 102547"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.65801161),
        dec: Angle.Degrees(+10.54029334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40558"},
        {"Smithsonian Astrophysical Observation", "SAO 97701"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.22167381),
        dec: Angle.Degrees(+10.54041350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130653"},
        {"Hipparcos Number", "HIP 72472"},
        {"Smithsonian Astrophysical Observation", "SAO 101227"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.28526165),
        dec: Angle.Degrees(+10.54054090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111783"},
        {"Geneva Identification System", "GEN# +0.00905076"},
        {"Smithsonian Astrophysical Observation", "SAO 108061"},
        {"Wilson Evans Batten Catalogue", "WEB 19967"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.62946624),
        dec: Angle.Degrees(+10.54064503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -277.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -535.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39079"},
        {"Hipparcos Number", "HIP 27597"},
        {"Smithsonian Astrophysical Observation", "SAO 94912"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.64948290),
        dec: Angle.Degrees(+10.54239454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218292"},
        {"Hipparcos Number", "HIP 114114"},
        {"Geneva Identification System", "GEN# +1.00218292"},
        {"Smithsonian Astrophysical Observation", "SAO 108403"},
        {"Wilson Evans Batten Catalogue", "WEB 20265"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.66316474),
        dec: Angle.Degrees(+10.54338173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182402"},
        {"Hipparcos Number", "HIP 95371"},
        {"Smithsonian Astrophysical Observation", "SAO 104792"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.02803673),
        dec: Angle.Degrees(+10.54456814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16802"},
        {"Hipparcos Number", "HIP 12599"},
        {"Smithsonian Astrophysical Observation", "SAO 93059"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.50045307),
        dec: Angle.Degrees(+10.54487593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93702"},
        {"Hipparcos Number", "HIP 52911"},
        {"Fundamental Katalog 5th Edition", "FK5 409"},
        {"Geneva Identification System", "GEN# +1.00093702"},
        {"Smithsonian Astrophysical Observation", "SAO 99305"},
        {"Wilson Evans Batten Catalogue", "WEB 9631"},
    },
    visualMagnitude: 5.32,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.31430258),
        dec: Angle.Degrees(+10.54526139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28121",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)56, 36.7700),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)32, 44.000)
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
    primaryId: "HIP 83634",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10336 AB"},
        {"Henry Draper", "HD 154517"},
        {"Hipparcos Number", "HIP 83634"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.38349872),
        dec: Angle.Degrees(+10.54646845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81123"},
        {"Hipparcos Number", "HIP 46106"},
        {"Smithsonian Astrophysical Observation", "SAO 98549"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.03895542),
        dec: Angle.Degrees(+10.54688643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23502"},
        {"Hipparcos Number", "HIP 17591"},
        {"Geneva Identification System", "GEN# +1.00023502"},
        {"Smithsonian Astrophysical Observation", "SAO 93588"},
        {"Wilson Evans Batten Catalogue", "WEB 3347"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.52615663),
        dec: Angle.Degrees(+10.54880548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169389"},
        {"Hipparcos Number", "HIP 90168"},
        {"Smithsonian Astrophysical Observation", "SAO 103673"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.99747600),
        dec: Angle.Degrees(+10.55068533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40007"},
        {"Hipparcos Number", "HIP 28122"},
        {"Smithsonian Astrophysical Observation", "SAO 95019"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.15466417),
        dec: Angle.Degrees(+10.55171876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178695"},
        {"Hipparcos Number", "HIP 94094"},
        {"Geneva Identification System", "GEN# +1.00178695"},
        {"Smithsonian Astrophysical Observation", "SAO 104533"},
        {"Wilson Evans Batten Catalogue", "WEB 16383"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.31662456),
        dec: Angle.Degrees(+10.55250272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286459"},
        {"Hipparcos Number", "HIP 18736"},
        {"Smithsonian Astrophysical Observation", "SAO 93722"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.20569610),
        dec: Angle.Degrees(+10.55277414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188775"},
        {"Hipparcos Number", "HIP 98119"},
        {"Smithsonian Astrophysical Observation", "SAO 105441"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.12029995),
        dec: Angle.Degrees(+10.55402108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137182"},
        {"Hipparcos Number", "HIP 75382"},
        {"Geneva Identification System", "GEN# +1.00137182"},
        {"Smithsonian Astrophysical Observation", "SAO 101527"},
        {"Wilson Evans Batten Catalogue", "WEB 12861"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.06078349),
        dec: Angle.Degrees(+10.55490744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287317"},
        {"Hipparcos Number", "HIP 23155"},
    },
    visualMagnitude: 10.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.72359711),
        dec: Angle.Degrees(+10.55507138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94543",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12203 AB"},
        {"Henry Draper", "HD 180026"},
        {"Hipparcos Number", "HIP 94543"},
        {"Fundamental Katalog 5th Edition", "FK5 5693"},
        {"Smithsonian Astrophysical Observation", "SAO 104637"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.63559768),
        dec: Angle.Degrees(+10.55527940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110556"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.94123766),
        dec: Angle.Degrees(+10.55887936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23988"},
        {"Hipparcos Number", "HIP 17899"},
        {"Geneva Identification System", "GEN# +1.00023988"},
        {"Smithsonian Astrophysical Observation", "SAO 93625"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.42872042),
        dec: Angle.Degrees(+10.55921785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56785"},
        {"Wilson Evans Batten Catalogue", "WEB 10222"},
    },
    visualMagnitude: 11.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.63618398),
        dec: Angle.Degrees(+10.56168214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9751"},
        {"Hipparcos Number", "HIP 7411"},
        {"Smithsonian Astrophysical Observation", "SAO 92528"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.88900457),
        dec: Angle.Degrees(+10.56175465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86594"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.44806286),
        dec: Angle.Degrees(+10.56478409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83831"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.99748690),
        dec: Angle.Degrees(+10.56510732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15165"},
        {"Hipparcos Number", "HIP 11390"},
        {"Smithsonian Astrophysical Observation", "SAO 92952"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.69010897),
        dec: Angle.Degrees(+10.56532958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62306"},
        {"Geneva Identification System", "GEN# +0.01102490"},
        {"Smithsonian Astrophysical Observation", "SAO 100245"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.50591233),
        dec: Angle.Degrees(+10.56565840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83099"},
        {"Hipparcos Number", "HIP 47142"},
        {"Smithsonian Astrophysical Observation", "SAO 98670"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.09046434),
        dec: Angle.Degrees(+10.56713125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11506"},
    },
    visualMagnitude: 11.72,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.09125186),
        dec: Angle.Degrees(+10.56763359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105958"},
        {"Smithsonian Astrophysical Observation", "SAO 107150"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.87758091),
        dec: Angle.Degrees(+10.56788380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60275"},
        {"Hipparcos Number", "HIP 36796"},
        {"Geneva Identification System", "GEN# +1.00060275"},
        {"Smithsonian Astrophysical Observation", "SAO 97021"},
        {"Wilson Evans Batten Catalogue", "WEB 7311"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.52075734),
        dec: Angle.Degrees(+10.56811357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140187"},
        {"Hipparcos Number", "HIP 76885"},
        {"Smithsonian Astrophysical Observation", "SAO 101685"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.49675661),
        dec: Angle.Degrees(+10.57023618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52241"},
        {"Geneva Identification System", "GEN# +9.80044030"},
    },
    visualMagnitude: 11.29,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.08945966),
        dec: Angle.Degrees(+11.19197543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -290.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81993"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.25239888),
        dec: Angle.Degrees(+10.57213588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196941"},
        {"Hipparcos Number", "HIP 101993"},
        {"Smithsonian Astrophysical Observation", "SAO 106364"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.04213661),
        dec: Angle.Degrees(+10.57243170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215850"},
        {"Hipparcos Number", "HIP 112574"},
        {"Smithsonian Astrophysical Observation", "SAO 108181"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.01670176),
        dec: Angle.Degrees(+10.57261858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159909"},
        {"Hipparcos Number", "HIP 86193"},
        {"Geneva Identification System", "GEN# +1.00159909"},
        {"Smithsonian Astrophysical Observation", "SAO 102962"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.20954137),
        dec: Angle.Degrees(+10.57455382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208942"},
        {"Hipparcos Number", "HIP 108566"},
        {"Smithsonian Astrophysical Observation", "SAO 107567"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.88219181),
        dec: Angle.Degrees(+10.57647009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218500"},
        {"Hipparcos Number", "HIP 114250"},
        {"Smithsonian Astrophysical Observation", "SAO 108421"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.07803504),
        dec: Angle.Degrees(+10.57787973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69820"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.33971059),
        dec: Angle.Degrees(+10.58197124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5662"},
    },
    visualMagnitude: 11.95,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.19040336),
        dec: Angle.Degrees(+10.58225113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109815"},
        {"Hipparcos Number", "HIP 61618"},
        {"Geneva Identification System", "GEN# +1.00109815"},
        {"Smithsonian Astrophysical Observation", "SAO 100181"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.40967552),
        dec: Angle.Degrees(+10.58412127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69814"},
        {"Smithsonian Astrophysical Observation", "SAO 100955"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.32779649),
        dec: Angle.Degrees(+10.58434975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139246"},
        {"Hipparcos Number", "HIP 76441"},
        {"Smithsonian Astrophysical Observation", "SAO 101645"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.18297219),
        dec: Angle.Degrees(+10.58479454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155644"},
        {"Hipparcos Number", "HIP 84177"},
        {"Fundamental Katalog 5th Edition", "FK5 3369"},
        {"Geneva Identification System", "GEN# +1.00155644"},
        {"Smithsonian Astrophysical Observation", "SAO 102646"},
        {"Wilson Evans Batten Catalogue", "WEB 14216"},
    },
    visualMagnitude: 5.32,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.11585728),
        dec: Angle.Degrees(+10.58522897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42023",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6873 AB"},
        {"Henry Draper", "HD 72583"},
        {"Hipparcos Number", "HIP 42023"},
        {"Smithsonian Astrophysical Observation", "SAO 97915"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.49201690),
        dec: Angle.Degrees(+10.58623289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39632"},
        {"Hipparcos Number", "HIP 27900"},
        {"Geneva Identification System", "GEN# +1.00039632"},
        {"Smithsonian Astrophysical Observation", "SAO 94977"},
        {"Wilson Evans Batten Catalogue", "WEB 5461"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.55562596),
        dec: Angle.Degrees(+10.58642145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90123"},
        {"Hipparcos Number", "HIP 50950"},
        {"Smithsonian Astrophysical Observation", "SAO 99098"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.08143820),
        dec: Angle.Degrees(+10.58777960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50343"},
        {"Hipparcos Number", "HIP 33068"},
        {"Smithsonian Astrophysical Observation", "SAO 96238"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.30899549),
        dec: Angle.Degrees(+10.59054325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120447"},
        {"Hipparcos Number", "HIP 67449"},
        {"Geneva Identification System", "GEN# +1.00120447"},
        {"Smithsonian Astrophysical Observation", "SAO 100722"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.34485129),
        dec: Angle.Degrees(+10.59079276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10077 A"},
        {"Henry Draper", "HD 148683"},
        {"Hipparcos Number", "HIP 80765"},
        {"Geneva Identification System", "GEN# +1.00148683A"},
        {"Smithsonian Astrophysical Observation", "SAO 102204"},
        {"Wilson Evans Batten Catalogue", "WEB 13660"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.35443485),
        dec: Angle.Degrees(+10.59207177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74793"},
        {"Hipparcos Number", "HIP 43074"},
        {"Geneva Identification System", "GEN# +1.00074793"},
        {"Smithsonian Astrophysical Observation", "SAO 98113"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.60211785),
        dec: Angle.Degrees(+10.59211516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87715"},
        {"Smithsonian Astrophysical Observation", "SAO 103210"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.76382049),
        dec: Angle.Degrees(+10.59219412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 201.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107134"},
        {"Hipparcos Number", "HIP 60075"},
        {"Geneva Identification System", "GEN# +1.00107134"},
        {"Smithsonian Astrophysical Observation", "SAO 100037"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.77803257),
        dec: Angle.Degrees(+10.59333892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75672"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.90946189),
        dec: Angle.Degrees(+10.59483137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -424.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -262.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80767",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10077 B"},
        {"Hipparcos Number", "HIP 80767"},
        {"Geneva Identification System", "GEN# +1.00148683B"},
        {"Wilson Evans Batten Catalogue", "WEB 13661"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.35569163),
        dec: Angle.Degrees(+10.59571871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98345"},
        {"Hipparcos Number", "HIP 55246"},
        {"Geneva Identification System", "GEN# +1.00098345"},
        {"Smithsonian Astrophysical Observation", "SAO 99548"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.71471891),
        dec: Angle.Degrees(+10.59654228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6003",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1035 A"},
        {"Henry Draper", "HD 7735"},
        {"Hipparcos Number", "HIP 6003"},
        {"Smithsonian Astrophysical Observation", "SAO 92347"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.30695055),
        dec: Angle.Degrees(+10.59667439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129974"},
        {"Hipparcos Number", "HIP 72142"},
        {"Geneva Identification System", "GEN# +1.00129974"},
        {"Smithsonian Astrophysical Observation", "SAO 101185"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.33981961),
        dec: Angle.Degrees(+10.59898418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219590"},
        {"Hipparcos Number", "HIP 114930"},
        {"Smithsonian Astrophysical Observation", "SAO 108506"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.19949458),
        dec: Angle.Degrees(+10.59908343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46634",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7406 B"},
        {"Hipparcos Number", "HIP 46634"},
        {"Smithsonian Astrophysical Observation", "SAO 98614"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.64631177),
        dec: Angle.Degrees(+10.59997928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4065",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 709"},
        {"Henry Draper", "HD 4936"},
        {"Hipparcos Number", "HIP 4065"},
        {"Smithsonian Astrophysical Observation", "SAO 92126"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.03155585),
        dec: Angle.Degrees(+10.60094271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46637",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7406 AB"},
        {"Aitken 2", "ADS 7406 A"},
        {"Henry Draper", "HD 82159"},
        {"Hipparcos Number", "HIP 46637"},
        {"Smithsonian Astrophysical Observation", "SAO 98615"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.64980457),
        dec: Angle.Degrees(+10.60176537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30687"},
        {"Hipparcos Number", "HIP 22475"},
        {"Celescope Catalog", "CEL 471"},
        {"Geneva Identification System", "GEN# +1.00030687"},
        {"Smithsonian Astrophysical Observation", "SAO 94156"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.53945152),
        dec: Angle.Degrees(+10.60502313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112678"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.26863458),
        dec: Angle.Degrees(+10.60560447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286622"},
        {"Hipparcos Number", "HIP 19664"},
        {"Smithsonian Astrophysical Observation", "SAO 93816"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.19759094),
        dec: Angle.Degrees(+10.60715111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58552"},
        {"Hipparcos Number", "HIP 36123"},
        {"Geneva Identification System", "GEN# +1.00058552"},
        {"Renson", "Renson 15990"},
        {"Smithsonian Astrophysical Observation", "SAO 96899"},
        {"Wilson Evans Batten Catalogue", "WEB 7193"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.61586607),
        dec: Angle.Degrees(+10.60806626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159242"},
        {"Hipparcos Number", "HIP 85901"},
        {"Geneva Identification System", "GEN# +1.00159242"},
        {"Smithsonian Astrophysical Observation", "SAO 102907"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.30652308),
        dec: Angle.Degrees(+10.60976377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204417"},
        {"Hipparcos Number", "HIP 106005"},
        {"Cincinnati Publication", "Ci 18 2788"},
        {"Geneva Identification System", "GEN# +1.00204417"},
        {"Smithsonian Astrophysical Observation", "SAO 107159"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.04847162),
        dec: Angle.Degrees(+10.61052776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14951"},
        {"Hipparcos Number", "HIP 11249"},
        {"Fundamental Katalog 5th Edition", "FK5 2164"},
        {"Geneva Identification System", "GEN# +1.00014951"},
        {"Smithsonian Astrophysical Observation", "SAO 92932"},
        {"Wilson Evans Batten Catalogue", "WEB 2355"},
    },
    visualMagnitude: 5.48,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.20435282),
        dec: Angle.Degrees(+10.61059804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14513"},
        {"Hipparcos Number", "HIP 10939"},
        {"Geneva Identification System", "GEN# +1.00014513"},
        {"Smithsonian Astrophysical Observation", "SAO 92895"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.22446332),
        dec: Angle.Degrees(+10.61199209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58249"},
        {"Smithsonian Astrophysical Observation", "SAO 99878"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.19163358),
        dec: Angle.Degrees(+10.61222074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206228"},
        {"Hipparcos Number", "HIP 107028"},
        {"Smithsonian Astrophysical Observation", "SAO 107316"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.13947652),
        dec: Angle.Degrees(+10.61224945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97278",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tarazed"},
        {"Henry Draper", "HD 186791"},
        {"Hipparcos Number", "HIP 97278"},
        {"Fundamental Katalog 5th Edition", "FK5 741"},
        {"Geneva Identification System", "GEN# +1.00186791"},
        {"Smithsonian Astrophysical Observation", "SAO 105223"},
        {"Wilson Evans Batten Catalogue", "WEB 17087"},
    },
    visualMagnitude: 2.72,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.56487567),
        dec: Angle.Degrees(+10.61326869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11592"},
        {"Hipparcos Number", "HIP 8859"},
        {"Geneva Identification System", "GEN# +1.00011592"},
        {"Smithsonian Astrophysical Observation", "SAO 92688"},
        {"Wilson Evans Batten Catalogue", "WEB 1866"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.49080201),
        dec: Angle.Degrees(+10.61472078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139610"},
        {"Hipparcos Number", "HIP 76619"},
        {"Geneva Identification System", "GEN# +1.00139610"},
        {"Smithsonian Astrophysical Observation", "SAO 101664"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.70639013),
        dec: Angle.Degrees(+10.61576496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214490"},
        {"Hipparcos Number", "HIP 111759"},
        {"Smithsonian Astrophysical Observation", "SAO 108060"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.59097630),
        dec: Angle.Degrees(+10.61596082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91672"},
        {"Smithsonian Astrophysical Observation", "SAO 103992"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.41865837),
        dec: Angle.Degrees(+10.61674082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166210"},
        {"Hipparcos Number", "HIP 88936"},
        {"Smithsonian Astrophysical Observation", "SAO 103427"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.31172063),
        dec: Angle.Degrees(+10.61741695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286724"},
        {"Hipparcos Number", "HIP 20216"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.97857163),
        dec: Angle.Degrees(+10.61903551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87391"},
        {"Hipparcos Number", "HIP 49379"},
        {"Smithsonian Astrophysical Observation", "SAO 98935"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.22261394),
        dec: Angle.Degrees(+10.62171380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175904"},
        {"Hipparcos Number", "HIP 93050"},
        {"Geneva Identification System", "GEN# +1.00175904"},
        {"Smithsonian Astrophysical Observation", "SAO 104282"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.31881027),
        dec: Angle.Degrees(+10.62363640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52287"},
        {"Hipparcos Number", "HIP 33789"},
        {"Smithsonian Astrophysical Observation", "SAO 96381"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.24427607),
        dec: Angle.Degrees(+10.62509155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126290"},
        {"Hipparcos Number", "HIP 70424"},
        {"Smithsonian Astrophysical Observation", "SAO 101013"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.10676350),
        dec: Angle.Degrees(+10.62518404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42807"},
        {"Hipparcos Number", "HIP 29525"},
        {"Cincinnati Publication", "Ci 18 773"},
        {"Geneva Identification System", "GEN# +1.00042807"},
        {"Smithsonian Astrophysical Observation", "SAO 95394"},
        {"Wilson Evans Batten Catalogue", "WEB 5802"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.30190191),
        dec: Angle.Degrees(+10.62786588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20779"},
        {"Hipparcos Number", "HIP 15633"},
        {"Smithsonian Astrophysical Observation", "SAO 93402"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.32540835),
        dec: Angle.Degrees(+10.62983810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12249"},
        {"Hipparcos Number", "HIP 9369"},
        {"Geneva Identification System", "GEN# +1.00012249"},
        {"Smithsonian Astrophysical Observation", "SAO 92746"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.09471688),
        dec: Angle.Degrees(+10.62994024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220602"},
        {"Hipparcos Number", "HIP 115592"},
        {"Smithsonian Astrophysical Observation", "SAO 108598"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.21669264),
        dec: Angle.Degrees(+10.63154086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41163",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6787 A"},
        {"Henry Draper", "HD 70734"},
        {"Hipparcos Number", "HIP 41163"},
        {"Geneva Identification System", "GEN# +1.00070734"},
        {"Smithsonian Astrophysical Observation", "SAO 97788"},
        {"Wilson Evans Batten Catalogue", "WEB 7967"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.98003581),
        dec: Angle.Degrees(+10.63211638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175309"},
        {"Hipparcos Number", "HIP 92787"},
        {"Geneva Identification System", "GEN# +1.00175309"},
        {"Smithsonian Astrophysical Observation", "SAO 104242"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62066984),
        dec: Angle.Degrees(+10.63254812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160884"},
        {"Hipparcos Number", "HIP 86625"},
        {"Smithsonian Astrophysical Observation", "SAO 103032"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.49821218),
        dec: Angle.Degrees(+10.63313478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158193"},
        {"Hipparcos Number", "HIP 85431"},
        {"Smithsonian Astrophysical Observation", "SAO 102828"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.86934262),
        dec: Angle.Degrees(+10.63529111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 684"},
        {"Hipparcos Number", "HIP 908"},
        {"Geneva Identification System", "GEN# +1.00000684"},
        {"Smithsonian Astrophysical Observation", "SAO 91764"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.81146720),
        dec: Angle.Degrees(+10.63603546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16499"},
        {"Hipparcos Number", "HIP 12354"},
        {"Smithsonian Astrophysical Observation", "SAO 93034"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.76426532),
        dec: Angle.Degrees(+10.63718970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201876"},
        {"Hipparcos Number", "HIP 104672"},
        {"Geneva Identification System", "GEN# +1.00201876"},
        {"Smithsonian Astrophysical Observation", "SAO 106909"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.03114960),
        dec: Angle.Degrees(+10.63798839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286859"},
        {"Hipparcos Number", "HIP 21176"},
        {"Smithsonian Astrophysical Observation", "SAO 93995"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.09987870),
        dec: Angle.Degrees(+10.63993705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15453"},
    },
    visualMagnitude: 11.22,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.82459910),
        dec: Angle.Degrees(+11.45579918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92267",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11693 A"},
        {"Henry Draper", "HD 174043"},
        {"Hipparcos Number", "HIP 92267"},
        {"Fundamental Katalog 5th Edition", "FK5 5651"},
        {"Smithsonian Astrophysical Observation", "SAO 104115"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.05758807),
        dec: Angle.Degrees(+10.64274734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137372"},
        {"Hipparcos Number", "HIP 75496"},
        {"Smithsonian Astrophysical Observation", "SAO 101537"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.33005651),
        dec: Angle.Degrees(+10.64315516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32853"},
        {"Hipparcos Number", "HIP 23770"},
        {"Celescope Catalog", "CEL 534"},
        {"Geneva Identification System", "GEN# +1.00032853"},
        {"Smithsonian Astrophysical Observation", "SAO 94320"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.63345930),
        dec: Angle.Degrees(+10.64372657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13342"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.92886981),
        dec: Angle.Degrees(+10.64534718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179913"},
        {"Hipparcos Number", "HIP 94502"},
        {"Smithsonian Astrophysical Observation", "SAO 104626"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.51091674),
        dec: Angle.Degrees(+10.64576041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47397"},
        {"Hipparcos Number", "HIP 31795"},
        {"Smithsonian Astrophysical Observation", "SAO 95942"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.71599762),
        dec: Angle.Degrees(+10.65111488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181604"},
        {"Hipparcos Number", "HIP 95088"},
        {"Geneva Identification System", "GEN# +1.00181604"},
        {"Smithsonian Astrophysical Observation", "SAO 104742"},
        {"Wilson Evans Batten Catalogue", "WEB 16607"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.17927448),
        dec: Angle.Degrees(+10.65275044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3121"},
        {"Cincinnati Publication", "Ci 20 43"},
        {"Geneva Identification System", "GEN# +0.00900073"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.92439887),
        dec: Angle.Degrees(+10.65428197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 525.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53585"},
        {"Smithsonian Astrophysical Observation", "SAO 99372"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.44083038),
        dec: Angle.Degrees(+10.65439941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18627"},
        {"Hipparcos Number", "HIP 13982"},
        {"Geneva Identification System", "GEN# +1.00018627"},
        {"Smithsonian Astrophysical Observation", "SAO 93228"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.02110409),
        dec: Angle.Degrees(+10.65620094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17215"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.31035741),
        dec: Angle.Degrees(+10.65729109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113480"},
    },
    visualMagnitude: 12.44,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.72576759),
        dec: Angle.Degrees(+10.65949316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138595"},
        {"Hipparcos Number", "HIP 76123"},
        {"Smithsonian Astrophysical Observation", "SAO 101604"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.20976091),
        dec: Angle.Degrees(+10.66056623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70456"},
        {"Hipparcos Number", "HIP 41027"},
        {"Smithsonian Astrophysical Observation", "SAO 97770"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.59795506),
        dec: Angle.Degrees(+10.66178423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48731",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7585 AB"},
        {"Henry Draper", "HD 86059"},
        {"Hipparcos Number", "HIP 48731"},
        {"Smithsonian Astrophysical Observation", "SAO 98852"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.09254939),
        dec: Angle.Degrees(+10.66542180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112828"},
        {"Hipparcos Number", "HIP 63390"},
        {"Geneva Identification System", "GEN# +1.00112828"},
        {"Smithsonian Astrophysical Observation", "SAO 100360"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.84451127),
        dec: Angle.Degrees(+10.66554910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133191"},
        {"Hipparcos Number", "HIP 73619"},
        {"Smithsonian Astrophysical Observation", "SAO 101348"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.72087695),
        dec: Angle.Degrees(+10.66737602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94029"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.15536131),
        dec: Angle.Degrees(+10.66738913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204234"},
        {"Hipparcos Number", "HIP 105902"},
        {"Geneva Identification System", "GEN# +1.00204234"},
        {"Smithsonian Astrophysical Observation", "SAO 107140"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.72794552),
        dec: Angle.Degrees(+10.66786405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78316"},
        {"Hipparcos Number", "HIP 44798"},
        {"Fundamental Katalog 5th Edition", "FK5 1238"},
        {"Geneva Identification System", "GEN# +1.00078316"},
        {"Renson", "Renson 22170"},
        {"Smithsonian Astrophysical Observation", "SAO 98378"},
        {"Wilson Evans Batten Catalogue", "WEB 8561"},
    },
    visualMagnitude: 5.23,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.93676819),
        dec: Angle.Degrees(+10.66821521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45221",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7242 AB"},
        {"Henry Draper", "HD 79191"},
        {"Hipparcos Number", "HIP 45221"},
        {"Smithsonian Astrophysical Observation", "SAO 98437"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.23539624),
        dec: Angle.Degrees(+10.66943170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99664"},
        {"Hipparcos Number", "HIP 55962"},
        {"Smithsonian Astrophysical Observation", "SAO 99618"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.02023870),
        dec: Angle.Degrees(+10.67170361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144781"},
        {"Hipparcos Number", "HIP 78980"},
        {"Smithsonian Astrophysical Observation", "SAO 101936"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.83391875),
        dec: Angle.Degrees(+10.67275844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5870"},
    },
    visualMagnitude: 11.66,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.83852907),
        dec: Angle.Degrees(+10.67320425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213316"},
        {"Hipparcos Number", "HIP 111097"},
        {"Smithsonian Astrophysical Observation", "SAO 107959"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.60785089),
        dec: Angle.Degrees(+10.67738428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185898"},
        {"Hipparcos Number", "HIP 96842"},
        {"Geneva Identification System", "GEN# +1.00185898"},
        {"Smithsonian Astrophysical Observation", "SAO 105131"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.27776715),
        dec: Angle.Degrees(+10.68018984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190296"},
        {"Hipparcos Number", "HIP 98805"},
        {"Geneva Identification System", "GEN# +9.00051011"},
        {"Smithsonian Astrophysical Observation", "SAO 105625"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.00107471),
        dec: Angle.Degrees(+10.68105259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205255"},
        {"Hipparcos Number", "HIP 106471"},
        {"Smithsonian Astrophysical Observation", "SAO 107233"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.47180600),
        dec: Angle.Degrees(+10.68239597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49744",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49744"},
        {"Smithsonian Astrophysical Observation", "SAO 98970"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.32581681),
        dec: Angle.Degrees(+10.68305551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102619"},
        {"Hipparcos Number", "HIP 57618"},
        {"Geneva Identification System", "GEN# +1.00102619"},
        {"Smithsonian Astrophysical Observation", "SAO 99803"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.21602473),
        dec: Angle.Degrees(+10.68389051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144515"},
        {"Henry Draper 2", "HD 144515A"},
        {"Hipparcos Number", "HIP 78864"},
        {"Cincinnati Publication", "Ci 20 966"},
        {"Geneva Identification System", "GEN# +1.00144515"},
        {"Smithsonian Astrophysical Observation", "SAO 101919"},
        {"Wilson Evans Batten Catalogue", "WEB 13331"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.47382489),
        dec: Angle.Degrees(+10.68511113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -523.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202508"},
        {"Hipparcos Number", "HIP 105005"},
        {"Smithsonian Astrophysical Observation", "SAO 106979"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.00743536),
        dec: Angle.Degrees(+10.68561438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101932"},
        {"Hipparcos Number", "HIP 57219"},
        {"Smithsonian Astrophysical Observation", "SAO 99760"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.99928772),
        dec: Angle.Degrees(+10.68589762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64291"},
        {"Hipparcos Number", "HIP 38547"},
        {"Geneva Identification System", "GEN# +1.00064291"},
        {"Smithsonian Astrophysical Observation", "SAO 97344"},
        {"Wilson Evans Batten Catalogue", "WEB 7574"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.40421986),
        dec: Angle.Degrees(+10.68711862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115151"},
        {"Hipparcos Number", "HIP 64657"},
        {"Geneva Identification System", "GEN# +1.00115151"},
        {"Smithsonian Astrophysical Observation", "SAO 100477"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.80600787),
        dec: Angle.Degrees(+10.68866911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55557"},
        {"Hipparcos Number", "HIP 34942"},
        {"Smithsonian Astrophysical Observation", "SAO 96654"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.45719052),
        dec: Angle.Degrees(+10.69080427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37518"},
        {"Smithsonian Astrophysical Observation", "SAO 97159"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.50486472),
        dec: Angle.Degrees(+10.69189458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131848"},
        {"Hipparcos Number", "HIP 73040"},
        {"Smithsonian Astrophysical Observation", "SAO 101287"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.90812382),
        dec: Angle.Degrees(+10.69251353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187203"},
        {"Hipparcos Number", "HIP 97454"},
        {"Geneva Identification System", "GEN# +1.00187203"},
        {"Smithsonian Astrophysical Observation", "SAO 105278"},
        {"Wilson Evans Batten Catalogue", "WEB 17127"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.12714544),
        dec: Angle.Degrees(+10.69411398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108674"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.23036308),
        dec: Angle.Degrees(+10.69416020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57183",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8278 AB"},
        {"Henry Draper", "HD 101872"},
        {"Hipparcos Number", "HIP 57183"},
        {"Smithsonian Astrophysical Observation", "SAO 99756"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.89643310),
        dec: Angle.Degrees(+10.69458637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35876",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6035 A"},
        {"Henry Draper", "HD 57930"},
        {"Hipparcos Number", "HIP 35876"},
        {"Smithsonian Astrophysical Observation", "SAO 96855"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.95167704),
        dec: Angle.Degrees(+10.70138801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26784"},
        {"Hipparcos Number", "HIP 19796"},
        {"Geneva Identification System", "GEN# +5.20250019"},
        {"Smithsonian Astrophysical Observation", "SAO 93831"},
        {"Wilson Evans Batten Catalogue", "WEB 3779"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.64279178),
        dec: Angle.Degrees(+10.70140049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265072"},
        {"Hipparcos Number", "HIP 32895"},
    },
    visualMagnitude: 9.33,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.81021801),
        dec: Angle.Degrees(+10.70217895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135061"},
        {"Hipparcos Number", "HIP 74441"},
        {"Smithsonian Astrophysical Observation", "SAO 101435"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.19664484),
        dec: Angle.Degrees(+10.70246828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35873",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6035 B"},
        {"Hipparcos Number", "HIP 35873"},
        {"Smithsonian Astrophysical Observation", "SAO 96854"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.94856150),
        dec: Angle.Degrees(+10.70606006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90149"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.95574632),
        dec: Angle.Degrees(+10.70820414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99663"},
        {"Hipparcos Number", "HIP 55967"},
        {"Geneva Identification System", "GEN# +1.00099663"},
        {"Smithsonian Astrophysical Observation", "SAO 99619"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.03726829),
        dec: Angle.Degrees(+10.70989647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184503"},
        {"Hipparcos Number", "HIP 96266"},
        {"Smithsonian Astrophysical Observation", "SAO 104980"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.61186074),
        dec: Angle.Degrees(+10.71274143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80237"},
        {"Hipparcos Number", "HIP 45691"},
        {"Smithsonian Astrophysical Observation", "SAO 98487"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.71968661),
        dec: Angle.Degrees(+10.71751408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149804"},
        {"Hipparcos Number", "HIP 81341"},
        {"Geneva Identification System", "GEN# +1.00149804"},
        {"Smithsonian Astrophysical Observation", "SAO 102270"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.18995018),
        dec: Angle.Degrees(+10.72038754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7620"},
        {"Smithsonian Astrophysical Observation", "SAO 92545"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.53802506),
        dec: Angle.Degrees(+10.72215820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146311"},
        {"Hipparcos Number", "HIP 79662"},
        {"Smithsonian Astrophysical Observation", "SAO 102037"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.85385901),
        dec: Angle.Degrees(+10.72232234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38926"},
        {"Hipparcos Number", "HIP 27513"},
        {"Geneva Identification System", "GEN# +1.00038926"},
        {"Smithsonian Astrophysical Observation", "SAO 94891"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.39755293),
        dec: Angle.Degrees(+10.72402413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191263"},
        {"Hipparcos Number", "HIP 99234"},
        {"Fundamental Katalog 5th Edition", "FK5 3616"},
        {"Geneva Identification System", "GEN# +9.00060015"},
        {"Geneva Identification System 2", "GEN# +9.05101570"},
        {"Smithsonian Astrophysical Observation", "SAO 105743"},
        {"Wilson Evans Batten Catalogue", "WEB 17678"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.15948837),
        dec: Angle.Degrees(+10.72587120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189132"},
        {"Hipparcos Number", "HIP 98292"},
        {"Geneva Identification System", "GEN# +1.00189132"},
        {"Smithsonian Astrophysical Observation", "SAO 105479"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.56032639),
        dec: Angle.Degrees(+10.72795161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108929"},
        {"Smithsonian Astrophysical Observation", "SAO 107630"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.99879496),
        dec: Angle.Degrees(+10.72986319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109684"},
        {"Hipparcos Number", "HIP 61539"},
        {"Geneva Identification System", "GEN# +1.00109684"},
        {"Smithsonian Astrophysical Observation", "SAO 100169"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.11846095),
        dec: Angle.Degrees(+10.72989491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198771"},
        {"Hipparcos Number", "HIP 103022"},
        {"Smithsonian Astrophysical Observation", "SAO 106594"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.08402495),
        dec: Angle.Degrees(+10.73231340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77191"},
        {"Hipparcos Number", "HIP 44303"},
        {"Smithsonian Astrophysical Observation", "SAO 98298"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.34493191),
        dec: Angle.Degrees(+10.73291276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49014"},
        {"Hipparcos Number", "HIP 32487"},
        {"Smithsonian Astrophysical Observation", "SAO 96099"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.69681091),
        dec: Angle.Degrees(+10.73462358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133432"},
        {"Hipparcos Number", "HIP 73713"},
        {"Smithsonian Astrophysical Observation", "SAO 101359"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.01606979),
        dec: Angle.Degrees(+10.73511407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103756"},
        {"Smithsonian Astrophysical Observation", "SAO 106762"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.37082346),
        dec: Angle.Degrees(+10.73595127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21916"},
        {"Hipparcos Number", "HIP 16504"},
        {"Smithsonian Astrophysical Observation", "SAO 93482"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.11296547),
        dec: Angle.Degrees(+10.73801974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201585"},
        {"Hipparcos Number", "HIP 104513"},
        {"Geneva Identification System", "GEN# +1.00201585"},
        {"Smithsonian Astrophysical Observation", "SAO 106887"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.55156584),
        dec: Angle.Degrees(+10.73886262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189921"},
        {"Hipparcos Number", "HIP 98641"},
        {"Geneva Identification System", "GEN# +9.00051010"},
        {"Smithsonian Astrophysical Observation", "SAO 105572"},
        {"Wilson Evans Batten Catalogue", "WEB 17452"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.54301660),
        dec: Angle.Degrees(+10.73897362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17301"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.55278584),
        dec: Angle.Degrees(+10.73989124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188510"},
        {"Hipparcos Number", "HIP 98020"},
        {"Geneva Identification System", "GEN# +1.00188510"},
        {"Smithsonian Astrophysical Observation", "SAO 105417"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.79042053),
        dec: Angle.Degrees(+10.74023756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 289.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16861"},
        {"Hipparcos Number", "HIP 12647"},
        {"Geneva Identification System", "GEN# +1.00016861"},
        {"Smithsonian Astrophysical Observation", "SAO 93067"},
        {"Wilson Evans Batten Catalogue", "WEB 2574"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.62062504),
        dec: Angle.Degrees(+10.74178145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47748"},
        {"Smithsonian Astrophysical Observation", "SAO 98739"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.01196512),
        dec: Angle.Degrees(+10.74363393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54725"},
        {"Hipparcos Number", "HIP 34627"},
        {"Smithsonian Astrophysical Observation", "SAO 96587"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.59036651),
        dec: Angle.Degrees(+10.74426196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139706"},
        {"Hipparcos Number", "HIP 76672"},
        {"Smithsonian Astrophysical Observation", "SAO 101668"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.84830403),
        dec: Angle.Degrees(+10.74566791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72893"},
        {"Smithsonian Astrophysical Observation", "SAO 101277"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.46712129),
        dec: Angle.Degrees(+10.74571074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66640",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8987 AB"},
        {"Henry Draper", "HD 118889"},
        {"Hipparcos Number", "HIP 66640"},
        {"Geneva Identification System", "GEN# +1.00118889J"},
        {"Smithsonian Astrophysical Observation", "SAO 100654"},
        {"Wilson Evans Batten Catalogue", "WEB 11755"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.89451792),
        dec: Angle.Degrees(+10.74630126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11696 A"},
        {"Henry Draper", "HD 174080"},
        {"Hipparcos Number", "HIP 92283"},
        {"Cincinnati Publication", "Ci 20 1107"},
        {"Geneva Identification System", "GEN# +1.00174080"},
        {"Smithsonian Astrophysical Observation", "SAO 104119"},
        {"Wilson Evans Batten Catalogue", "WEB 15923"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.12145481),
        dec: Angle.Degrees(+10.74651186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -436.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26843"},
        {"Hipparcos Number", "HIP 19821"},
        {"Smithsonian Astrophysical Observation", "SAO 93832"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.75389666),
        dec: Angle.Degrees(+10.74816557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28936",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4687 BC"},
        {"Hipparcos Number", "HIP 28936"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.61127019),
        dec: Angle.Degrees(+10.74847890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98578",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13256"},
        {"Henry Draper", "HD 189783"},
        {"Hipparcos Number", "HIP 98578"},
        {"Geneva Identification System", "GEN# +1.00189783"},
        {"Smithsonian Astrophysical Observation", "SAO 105560"},
        {"Wilson Evans Batten Catalogue", "WEB 17424"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.36106306),
        dec: Angle.Degrees(+10.74855792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10752"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.57701378),
        dec: Angle.Degrees(+10.74891166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28937",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4687 A"},
        {"Henry Draper", "HD 41580"},
        {"Hipparcos Number", "HIP 28937"},
        {"Celescope Catalog", "CEL 1078"},
        {"Geneva Identification System", "GEN# +1.00041580"},
        {"Smithsonian Astrophysical Observation", "SAO 95234"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.61683780),
        dec: Angle.Degrees(+10.75033652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28608"},
        {"Hipparcos Number", "HIP 21066"},
        {"Celescope Catalog", "CEL 422"},
        {"Geneva Identification System", "GEN# +5.20250086"},
        {"Smithsonian Astrophysical Observation", "SAO 93982"},
        {"Wilson Evans Batten Catalogue", "WEB 4055"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.73796015),
        dec: Angle.Degrees(+10.75179367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32337",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5407 AB"},
        {"Henry Draper", "HD 48688"},
        {"Hipparcos Number", "HIP 32337"},
        {"Smithsonian Astrophysical Observation", "SAO 96068"},
        {"Wilson Evans Batten Catalogue", "WEB 6523"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.24643063),
        dec: Angle.Degrees(+10.75267367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210075"},
        {"Hipparcos Number", "HIP 109226"},
        {"Smithsonian Astrophysical Observation", "SAO 107677"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.91421456),
        dec: Angle.Degrees(+10.75364338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193597"},
        {"Hipparcos Number", "HIP 100306"},
        {"Smithsonian Astrophysical Observation", "SAO 105995"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.16093666),
        dec: Angle.Degrees(+10.75405724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49265"},
        {"Smithsonian Astrophysical Observation", "SAO 98923"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.84885785),
        dec: Angle.Degrees(+10.75424934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116725"},
        {"Hipparcos Number", "HIP 65494"},
        {"Geneva Identification System", "GEN# +1.00116725"},
        {"Smithsonian Astrophysical Observation", "SAO 100559"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.34743890),
        dec: Angle.Degrees(+10.75592283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47234"},
        {"Smithsonian Astrophysical Observation", "SAO 98679"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.41307271),
        dec: Angle.Degrees(+10.75615193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212735"},
        {"Hipparcos Number", "HIP 110761"},
        {"Smithsonian Astrophysical Observation", "SAO 107912"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.58986303),
        dec: Angle.Degrees(+10.75770880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176897"},
        {"Hipparcos Number", "HIP 93459"},
        {"Smithsonian Astrophysical Observation", "SAO 104381"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.51182864),
        dec: Angle.Degrees(+10.75809612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7102 AB"},
        {"Henry Draper", "HD 76544"},
        {"Hipparcos Number", "HIP 43951"},
        {"Smithsonian Astrophysical Observation", "SAO 98246"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.27592004),
        dec: Angle.Degrees(+10.75824391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196181"},
        {"Hipparcos Number", "HIP 101592"},
        {"Smithsonian Astrophysical Observation", "SAO 106273"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.83564059),
        dec: Angle.Degrees(+10.75843712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133859"},
        {"Hipparcos Number", "HIP 73922"},
        {"Smithsonian Astrophysical Observation", "SAO 101371"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.60108534),
        dec: Angle.Degrees(+10.75985180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95166",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 45"},
        {"Hipparcos Number", "HIP 95166"},
        {"Geneva Identification System", "GEN# +0.01003872"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.41475310),
        dec: Angle.Degrees(+10.76079193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213508"},
        {"Hipparcos Number", "HIP 111205"},
        {"Smithsonian Astrophysical Observation", "SAO 107977"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.93580520),
        dec: Angle.Degrees(+10.76318910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173847"},
        {"Hipparcos Number", "HIP 92177"},
        {"Smithsonian Astrophysical Observation", "SAO 104094"},
        {"Wilson Evans Batten Catalogue", "WEB 15895"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.79474342),
        dec: Angle.Degrees(+10.76371049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129847"},
        {"Hipparcos Number", "HIP 72074"},
        {"Geneva Identification System", "GEN# +1.00129847"},
        {"Smithsonian Astrophysical Observation", "SAO 101179"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.14392408),
        dec: Angle.Degrees(+10.76384183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11985",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11985"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.64838873),
        dec: Angle.Degrees(+10.76485970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19384",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3026 AB"},
        {"Henry Draper", "HD 26213"},
        {"Hipparcos Number", "HIP 19384"},
        {"Smithsonian Astrophysical Observation", "SAO 93787"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.28247091),
        dec: Angle.Degrees(+10.76517648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264103"},
        {"Hipparcos Number", "HIP 32606"},
        {"Smithsonian Astrophysical Observation", "SAO 96126"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.04425866),
        dec: Angle.Degrees(+10.76523843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62832"},
        {"Hipparcos Number", "HIP 37921"},
        {"Fundamental Katalog 5th Edition", "FK5 1201"},
        {"Geneva Identification System", "GEN# +1.00062832"},
        {"Smithsonian Astrophysical Observation", "SAO 97224"},
        {"Wilson Evans Batten Catalogue", "WEB 7484"},
    },
    visualMagnitude: 5.25,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.56757952),
        dec: Angle.Degrees(+10.76831128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158717"},
        {"Hipparcos Number", "HIP 85664"},
        {"Smithsonian Astrophysical Observation", "SAO 102868"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.59257407),
        dec: Angle.Degrees(+10.76857304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10530",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1727 B"},
        {"Hipparcos Number", "HIP 10530"},
        {"Smithsonian Astrophysical Observation", "SAO 92860"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.92262258),
        dec: Angle.Degrees(+10.76899533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52961"},
        {"Hipparcos Number", "HIP 34038"},
        {"Smithsonian Astrophysical Observation", "SAO 96430"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.91513240),
        dec: Angle.Degrees(+10.77030334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1727 A"},
        {"Henry Draper", "HD 13904"},
        {"Hipparcos Number", "HIP 10533"},
        {"Smithsonian Astrophysical Observation", "SAO 92861"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.92608792),
        dec: Angle.Degrees(+10.77117940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286719"},
        {"Hipparcos Number", "HIP 20366"},
        {"Smithsonian Astrophysical Observation", "SAO 93888"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.42369436),
        dec: Angle.Degrees(+10.77170013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286381"},
        {"Hipparcos Number", "HIP 18341"},
        {"Smithsonian Astrophysical Observation", "SAO 93675"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.82601977),
        dec: Angle.Degrees(+10.77176410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166331"},
        {"Hipparcos Number", "HIP 88993"},
        {"Geneva Identification System", "GEN# +1.00166331"},
        {"Smithsonian Astrophysical Observation", "SAO 103439"},
        {"Wilson Evans Batten Catalogue", "WEB 15099"},
    },
    visualMagnitude: 9.44,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.46005902),
        dec: Angle.Degrees(+10.77401528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186587"},
        {"Hipparcos Number", "HIP 97162"},
        {"Wilson Evans Batten Catalogue", "WEB 17057"},
    },
    visualMagnitude: 7.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.23658929),
        dec: Angle.Degrees(+10.77515779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82444"},
        {"Hipparcos Number", "HIP 46812"},
        {"Geneva Identification System", "GEN# +1.00082444"},
        {"Smithsonian Astrophysical Observation", "SAO 98629"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.08466682),
        dec: Angle.Degrees(+10.77645926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17180 B"},
        {"Henry Draper", "HD 224994"},
        {"Hipparcos Number", "HIP 190"},
        {"Smithsonian Astrophysical Observation", "SAO 108976"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.60555642),
        dec: Angle.Degrees(+10.77665206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7471 A"},
        {"Henry Draper", "HD 83452"},
        {"Hipparcos Number", "HIP 47336"},
        {"Smithsonian Astrophysical Observation", "SAO 98690"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.69056670),
        dec: Angle.Degrees(+10.77787342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243912"},
        {"Hipparcos Number", "HIP 25554"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.93801960),
        dec: Angle.Degrees(+10.77844383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104178"},
        {"Smithsonian Astrophysical Observation", "SAO 106835"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.60688002),
        dec: Angle.Degrees(+10.77953757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11766 AB"},
        {"Henry Draper", "HD 174792"},
        {"Hipparcos Number", "HIP 92587"},
        {"Smithsonian Astrophysical Observation", "SAO 104193"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.99189104),
        dec: Angle.Degrees(+10.78023535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242249"},
        {"Hipparcos Number", "HIP 24606"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.16703418),
        dec: Angle.Degrees(+10.78532002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 185",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17180 A"},
        {"Henry Draper", "HD 224984"},
        {"Hipparcos Number", "HIP 185"},
        {"Geneva Identification System", "GEN# +1.00224984"},
        {"Smithsonian Astrophysical Observation", "SAO 108974"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.59015020),
        dec: Angle.Degrees(+10.78564387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191401"},
        {"Hipparcos Number", "HIP 99295"},
        {"Geneva Identification System", "GEN# +9.00051016"},
        {"Smithsonian Astrophysical Observation", "SAO 105761"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.34453228),
        dec: Angle.Degrees(+10.78609779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53872"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.32181772),
        dec: Angle.Degrees(+10.78704963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53625"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.56656497),
        dec: Angle.Degrees(+10.78715067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99644",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13533 AB"},
        {"Henry Draper", "HD 192185"},
        {"Hipparcos Number", "HIP 99644"},
        {"Smithsonian Astrophysical Observation", "SAO 105846"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.33259488),
        dec: Angle.Degrees(+10.78724649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122742"},
        {"Hipparcos Number", "HIP 68682"},
        {"Geneva Identification System", "GEN# +1.00122742"},
        {"Smithsonian Astrophysical Observation", "SAO 100832"},
        {"Wilson Evans Batten Catalogue", "WEB 12022"},
    },
    visualMagnitude: 6.27,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.88458683),
        dec: Angle.Degrees(+10.78751797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286457"},
        {"Hipparcos Number", "HIP 18700"},
        {"Smithsonian Astrophysical Observation", "SAO 93715"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.09332961),
        dec: Angle.Degrees(+10.78801728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66198"},
        {"Hipparcos Number", "HIP 39359"},
        {"Smithsonian Astrophysical Observation", "SAO 97505"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.68088662),
        dec: Angle.Degrees(+10.78823727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192789"},
        {"Hipparcos Number", "HIP 99912"},
        {"Geneva Identification System", "GEN# +1.00192789"},
        {"Smithsonian Astrophysical Observation", "SAO 105913"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.07411516),
        dec: Angle.Degrees(+10.79104515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12054"},
        {"Hipparcos Number", "HIP 9210"},
        {"Geneva Identification System", "GEN# +1.00012054"},
        {"Smithsonian Astrophysical Observation", "SAO 92729"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.61976111),
        dec: Angle.Degrees(+10.79309329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23825"},
        {"Hipparcos Number", "HIP 17778"},
        {"Geneva Identification System", "GEN# +1.00023825"},
        {"Smithsonian Astrophysical Observation", "SAO 93612"},
        {"Wilson Evans Batten Catalogue", "WEB 3408"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.09145707),
        dec: Angle.Degrees(+10.79334861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19504"},
        {"Hipparcos Number", "HIP 14591"},
        {"Geneva Identification System", "GEN# +1.00019504"},
        {"Smithsonian Astrophysical Observation", "SAO 93296"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.10497370),
        dec: Angle.Degrees(+10.79595160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25979"},
        {"Hipparcos Number", "HIP 19217"},
        {"Geneva Identification System", "GEN# +1.00025979"},
        {"Smithsonian Astrophysical Observation", "SAO 93770"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.78631307),
        dec: Angle.Degrees(+10.79988518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50060"},
        {"Hipparcos Number", "HIP 32962"},
        {"Geneva Identification System", "GEN# +1.00050060"},
        {"Smithsonian Astrophysical Observation", "SAO 96210"},
        {"Wilson Evans Batten Catalogue", "WEB 6635"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.98278650),
        dec: Angle.Degrees(+10.80050071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26287"},
        {"Hipparcos Number", "HIP 19443"},
        {"Geneva Identification System", "GEN# +1.00026287"},
        {"Smithsonian Astrophysical Observation", "SAO 93793"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.45953080),
        dec: Angle.Degrees(+10.80051785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13759"},
        {"Smithsonian Astrophysical Observation", "SAO 93200"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.28190185),
        dec: Angle.Degrees(+10.80379038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51997"},
        {"Smithsonian Astrophysical Observation", "SAO 99214"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.34463322),
        dec: Angle.Degrees(+10.80493665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14436"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.58818395),
        dec: Angle.Degrees(+10.80570499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63389"},
        {"Hipparcos Number", "HIP 38153"},
        {"Geneva Identification System", "GEN# +1.00063389"},
        {"Smithsonian Astrophysical Observation", "SAO 97276"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.27881246),
        dec: Angle.Degrees(+10.80591965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43743",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7078 AB"},
        {"Henry Draper", "HD 76133"},
        {"Hipparcos Number", "HIP 43743"},
        {"Smithsonian Astrophysical Observation", "SAO 98222"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.63903153),
        dec: Angle.Degrees(+10.80637207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207626"},
        {"Hipparcos Number", "HIP 107780"},
        {"Geneva Identification System", "GEN# +1.00207626"},
        {"Smithsonian Astrophysical Observation", "SAO 107423"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.52064791),
        dec: Angle.Degrees(+10.80701512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175293"},
        {"Hipparcos Number", "HIP 92779"},
        {"Fundamental Katalog 5th Edition", "FK5 3507"},
        {"Geneva Identification System", "GEN# +1.00175293"},
        {"Smithsonian Astrophysical Observation", "SAO 104239"},
        {"Wilson Evans Batten Catalogue", "WEB 16053"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.59133845),
        dec: Angle.Degrees(+10.80831328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135385"},
        {"Hipparcos Number", "HIP 74589"},
        {"Smithsonian Astrophysical Observation", "SAO 101454"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.61033178),
        dec: Angle.Degrees(+10.80871174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17162"},
        {"Hipparcos Number", "HIP 12877"},
        {"Smithsonian Astrophysical Observation", "SAO 93088"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.38576324),
        dec: Angle.Degrees(+10.80890435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101534"},
        {"Hipparcos Number", "HIP 56999"},
        {"Smithsonian Astrophysical Observation", "SAO 99733"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.27433863),
        dec: Angle.Degrees(+10.80900721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31554"},
        {"Hipparcos Number", "HIP 23035"},
        {"Celescope Catalog", "CEL 497"},
        {"Geneva Identification System", "GEN# +1.00031554"},
        {"Smithsonian Astrophysical Observation", "SAO 94225"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.30470325),
        dec: Angle.Degrees(+10.80987999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8708",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1487 AB"},
        {"Henry Draper", "HD 11386"},
        {"Hipparcos Number", "HIP 8708"},
        {"Smithsonian Astrophysical Observation", "SAO 92669"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.01059473),
        dec: Angle.Degrees(+10.81058806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193557"},
        {"Hipparcos Number", "HIP 100282"},
        {"Smithsonian Astrophysical Observation", "SAO 105990"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.10861227),
        dec: Angle.Degrees(+10.81090916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76660"},
        {"Hipparcos Number", "HIP 44018"},
        {"Smithsonian Astrophysical Observation", "SAO 98260"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.46355377),
        dec: Angle.Degrees(+10.81430758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167785"},
        {"Hipparcos Number", "HIP 89551"},
        {"Smithsonian Astrophysical Observation", "SAO 103546"},
        {"Wilson Evans Batten Catalogue", "WEB 15249"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.09251669),
        dec: Angle.Degrees(+10.81482916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218768"},
        {"Hipparcos Number", "HIP 114431"},
        {"Smithsonian Astrophysical Observation", "SAO 108442"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.61997919),
        dec: Angle.Degrees(+10.81631618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113894"},
    },
    visualMagnitude: 12.27,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.98206804),
        dec: Angle.Degrees(+10.81712344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 195.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117304"},
        {"Hipparcos Number", "HIP 65790"},
        {"Fundamental Katalog 5th Edition", "FK5 3076"},
        {"Geneva Identification System", "GEN# +1.00117304"},
        {"Smithsonian Astrophysical Observation", "SAO 100592"},
        {"Wilson Evans Batten Catalogue", "WEB 11643"},
    },
    visualMagnitude: 5.65,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.30431766),
        dec: Angle.Degrees(+10.81839609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3314"},
        {"Smithsonian Astrophysical Observation", "SAO 92038"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.54841971),
        dec: Angle.Degrees(+10.81886473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286771"},
        {"Hipparcos Number", "HIP 20481"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.84429235),
        dec: Angle.Degrees(+10.82017465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78534"},
        {"Hipparcos Number", "HIP 44935"},
        {"Smithsonian Astrophysical Observation", "SAO 98390"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.29274793),
        dec: Angle.Degrees(+10.82209539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153627"},
        {"Hipparcos Number", "HIP 83204"},
        {"Geneva Identification System", "GEN# +1.00153627"},
        {"Smithsonian Astrophysical Observation", "SAO 102522"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.06797927),
        dec: Angle.Degrees(+10.82305681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106210"},
        {"Hipparcos Number", "HIP 59589"},
        {"Cincinnati Publication", "Ci 20 690"},
        {"Cincinnati Publication 2", "Ci 18 1524"},
        {"Geneva Identification System", "GEN# +1.00106210"},
        {"Smithsonian Astrophysical Observation", "SAO 99995"},
        {"Wilson Evans Batten Catalogue", "WEB 10590"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.30463912),
        dec: Angle.Degrees(+10.82308982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -590.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140647"},
        {"Hipparcos Number", "HIP 77095"},
        {"Geneva Identification System", "GEN# +1.00140647"},
        {"Smithsonian Astrophysical Observation", "SAO 101708"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.12757153),
        dec: Angle.Degrees(+10.82406966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60304"},
        {"Hipparcos Number", "HIP 36810"},
        {"Smithsonian Astrophysical Observation", "SAO 97023"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.55698597),
        dec: Angle.Degrees(+10.82433160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206540"},
        {"Hipparcos Number", "HIP 107173"},
        {"Geneva Identification System", "GEN# +1.00206540"},
        {"Smithsonian Astrophysical Observation", "SAO 107340"},
        {"Wilson Evans Batten Catalogue", "WEB 19359"},
    },
    visualMagnitude: 6.06,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.63728108),
        dec: Angle.Degrees(+10.82434451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135698"},
        {"Hipparcos Number", "HIP 74718"},
        {"Smithsonian Astrophysical Observation", "SAO 101465"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.04678821),
        dec: Angle.Degrees(+10.82578546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167160"},
        {"Hipparcos Number", "HIP 89331"},
        {"Smithsonian Astrophysical Observation", "SAO 103500"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.40918396),
        dec: Angle.Degrees(+10.82607159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123232"},
        {"Hipparcos Number", "HIP 68879"},
        {"Smithsonian Astrophysical Observation", "SAO 100849"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.55389781),
        dec: Angle.Degrees(+10.82611669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6862"},
        {"Hipparcos Number", "HIP 5422"},
        {"Smithsonian Astrophysical Observation", "SAO 92280"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.31989836),
        dec: Angle.Degrees(+10.82701472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71695"},
        {"Smithsonian Astrophysical Observation", "SAO 101131"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.99367639),
        dec: Angle.Degrees(+10.82862233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72543"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.46739205),
        dec: Angle.Degrees(+10.82906619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15661"},
        {"Smithsonian Astrophysical Observation", "SAO 93403"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.42438232),
        dec: Angle.Degrees(+10.82994457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131784"},
        {"Hipparcos Number", "HIP 73008"},
        {"Smithsonian Astrophysical Observation", "SAO 101285"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.81029067),
        dec: Angle.Degrees(+10.83031536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175827"},
        {"Hipparcos Number", "HIP 93008"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.21371760),
        dec: Angle.Degrees(+10.83083255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112029",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Homam"},
        {"Aitken", "ADS 16182 A"},
        {"Henry Draper", "HD 214923"},
        {"Hipparcos Number", "HIP 112029"},
        {"Fundamental Katalog 5th Edition", "FK5 855"},
        {"Geneva Identification System", "GEN# +1.00214923"},
        {"Smithsonian Astrophysical Observation", "SAO 108103"},
        {"Wilson Evans Batten Catalogue", "WEB 19999"},
    },
    visualMagnitude: 3.41,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.36531181),
        dec: Angle.Degrees(+10.83139111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41585"},
        {"Smithsonian Astrophysical Observation", "SAO 97845"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.17890324),
        dec: Angle.Degrees(+10.83535961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109486"},
        {"Hipparcos Number", "HIP 61397"},
        {"Geneva Identification System", "GEN# +1.00109486"},
        {"Smithsonian Astrophysical Observation", "SAO 100156"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.71654964),
        dec: Angle.Degrees(+10.83635661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14787"},
        {"Hipparcos Number", "HIP 11130"},
        {"Geneva Identification System", "GEN# +1.00014787"},
        {"Smithsonian Astrophysical Observation", "SAO 92914"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.80858533),
        dec: Angle.Degrees(+10.83671675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125752"},
        {"Hipparcos Number", "HIP 70159"},
        {"Geneva Identification System", "GEN# +1.00125752"},
        {"Smithsonian Astrophysical Observation", "SAO 100987"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.32652863),
        dec: Angle.Degrees(+10.83749112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100802"},
    },
    visualMagnitude: 11.08,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.58480455),
        dec: Angle.Degrees(+10.83827238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103527",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Musica"},
        {"Henry Draper", "HD 199665"},
        {"Hipparcos Number", "HIP 103527"},
        {"Geneva Identification System", "GEN# +1.00199665"},
        {"Smithsonian Astrophysical Observation", "SAO 106712"},
        {"Wilson Evans Batten Catalogue", "WEB 18832"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.60817904),
        dec: Angle.Degrees(+10.83936950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67233",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9022 AB"},
        {"Henry Draper", "HD 120010"},
        {"Hipparcos Number", "HIP 67233"},
        {"Smithsonian Astrophysical Observation", "SAO 100702"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.65680662),
        dec: Angle.Degrees(+10.84059949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29286"},
        {"Hipparcos Number", "HIP 21506"},
        {"Celescope Catalog", "CEL 445"},
        {"Geneva Identification System", "GEN# +1.00029286"},
        {"Smithsonian Astrophysical Observation", "SAO 94037"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.28423610),
        dec: Angle.Degrees(+10.84186919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88680"},
        {"Hipparcos Number", "HIP 50110"},
        {"Geneva Identification System", "GEN# +1.00088680"},
        {"Smithsonian Astrophysical Observation", "SAO 99012"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.45991101),
        dec: Angle.Degrees(+10.84201989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46735"},
        {"Hipparcos Number", "HIP 31465"},
        {"Smithsonian Astrophysical Observation", "SAO 95874"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.86466008),
        dec: Angle.Degrees(+10.84261809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8402"},
        {"Hipparcos Number", "HIP 6484"},
        {"Geneva Identification System", "GEN# +1.00008402"},
        {"Smithsonian Astrophysical Observation", "SAO 92410"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.82966296),
        dec: Angle.Degrees(+10.84279496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24215"},
        {"Hipparcos Number", "HIP 18063"},
        {"Smithsonian Astrophysical Observation", "SAO 93641"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.91076249),
        dec: Angle.Degrees(+10.84344821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84740"},
        {"Hipparcos Number", "HIP 48033"},
        {"Smithsonian Astrophysical Observation", "SAO 98768"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.87200985),
        dec: Angle.Degrees(+10.84420445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10894"},
        {"Hipparcos Number", "HIP 8306"},
        {"Fundamental Katalog 5th Edition", "FK5 4163"},
        {"Geneva Identification System", "GEN# +1.00010894"},
        {"Smithsonian Astrophysical Observation", "SAO 92628"},
        {"Wilson Evans Batten Catalogue", "WEB 1770"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.78792558),
        dec: Angle.Degrees(+10.84426479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76734"},
        {"Hipparcos Number", "HIP 44050"},
        {"Geneva Identification System", "GEN# +1.00076734"},
        {"Smithsonian Astrophysical Observation", "SAO 98266"},
        {"Wilson Evans Batten Catalogue", "WEB 8465"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.56670693),
        dec: Angle.Degrees(+10.84526513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26312"},
        {"Hipparcos Number", "HIP 19460"},
        {"Geneva Identification System", "GEN# +1.00026312"},
        {"Smithsonian Astrophysical Observation", "SAO 93795"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.51001855),
        dec: Angle.Degrees(+10.84628145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83118"},
        {"Hipparcos Number", "HIP 47151"},
        {"Smithsonian Astrophysical Observation", "SAO 98671"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.12144468),
        dec: Angle.Degrees(+10.84630877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256384"},
        {"Hipparcos Number", "HIP 30402"},
        {"Smithsonian Astrophysical Observation", "SAO 95619"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.89054301),
        dec: Angle.Degrees(+10.84648295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6663 AB"},
        {"Henry Draper", "HD 68615"},
        {"Hipparcos Number", "HIP 40280"},
        {"Smithsonian Astrophysical Observation", "SAO 97662"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.39246222),
        dec: Angle.Degrees(+10.84732590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8904"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.66130002),
        dec: Angle.Degrees(+10.84768727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210891"},
        {"Hipparcos Number", "HIP 109703"},
        {"Geneva Identification System", "GEN# +1.00210891"},
        {"Smithsonian Astrophysical Observation", "SAO 107741"},
        {"Wilson Evans Batten Catalogue", "WEB 19709"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.32129187),
        dec: Angle.Degrees(+10.84850363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77710"},
        {"Hipparcos Number", "HIP 44548"},
        {"Smithsonian Astrophysical Observation", "SAO 98338"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.14941979),
        dec: Angle.Degrees(+10.85021181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126845"},
        {"Hipparcos Number", "HIP 70721"},
        {"Smithsonian Astrophysical Observation", "SAO 101033"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.94809923),
        dec: Angle.Degrees(+10.85102396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47156"},
        {"Hipparcos Number", "HIP 31662"},
        {"Smithsonian Astrophysical Observation", "SAO 95914"},
        {"Wilson Evans Batten Catalogue", "WEB 6343"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.40382259),
        dec: Angle.Degrees(+10.85337292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3577"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.42407918),
        dec: Angle.Degrees(+10.85353602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240514"},
        {"Hipparcos Number", "HIP 23544"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.94658509),
        dec: Angle.Degrees(+10.85525852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66510"},
        {"Hipparcos Number", "HIP 39488"},
        {"Geneva Identification System", "GEN# +1.00066510"},
        {"Smithsonian Astrophysical Observation", "SAO 97527"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.06832985),
        dec: Angle.Degrees(+10.85676360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6760"},
        {"Hipparcos Number", "HIP 5350"},
        {"Smithsonian Astrophysical Observation", "SAO 92270"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.10079824),
        dec: Angle.Degrees(+10.85831660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156146"},
        {"Hipparcos Number", "HIP 84417"},
        {"Cincinnati Publication", "Ci 18 2300"},
        {"Geneva Identification System", "GEN# +1.00156146"},
        {"Smithsonian Astrophysical Observation", "SAO 102690"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.87057067),
        dec: Angle.Degrees(+10.86055875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102582"},
        {"Geneva Identification System", "GEN# +0.01004379"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.81994577),
        dec: Angle.Degrees(+10.86156911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -592.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145274"},
        {"Hipparcos Number", "HIP 79191"},
        {"Smithsonian Astrophysical Observation", "SAO 101974"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.43999435),
        dec: Angle.Degrees(+10.86445219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156681"},
        {"Hipparcos Number", "HIP 84671"},
        {"Fundamental Katalog 5th Edition", "FK5 3372"},
        {"Geneva Identification System", "GEN# +1.00156681"},
        {"Smithsonian Astrophysical Observation", "SAO 102725"},
        {"Wilson Evans Batten Catalogue", "WEB 14297"},
    },
    visualMagnitude: 5.03,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.65410656),
        dec: Angle.Degrees(+10.86471277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38786",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6473 AB"},
        {"Henry Draper", "HD 64852"},
        {"Hipparcos Number", "HIP 38786"},
        {"Smithsonian Astrophysical Observation", "SAO 97386"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.08345652),
        dec: Angle.Degrees(+10.86487626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73315"},
        {"Hipparcos Number", "HIP 42355"},
        {"Smithsonian Astrophysical Observation", "SAO 97986"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.53323024),
        dec: Angle.Degrees(+10.86637988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287150"},
        {"Hipparcos Number", "HIP 22348"},
        {"Geneva Identification System", "GEN# +2.16620006"},
        {"Renson", "Renson 7880"},
        {"New General Catalogue", "NGC 1662 6"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.17246409),
        dec: Angle.Degrees(+10.86731464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106607"},
        {"Hipparcos Number", "HIP 59797"},
        {"Geneva Identification System", "GEN# +1.00106607"},
        {"Smithsonian Astrophysical Observation", "SAO 100010"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.92503101),
        dec: Angle.Degrees(+10.86763432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89559"},
        {"Hipparcos Number", "HIP 50611"},
        {"Smithsonian Astrophysical Observation", "SAO 99071"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.07483980),
        dec: Angle.Degrees(+10.86879876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18700"},
        {"Hipparcos Number", "HIP 14036"},
        {"Fundamental Katalog 5th Edition", "FK5 2213"},
        {"Geneva Identification System", "GEN# +1.00018700"},
        {"Smithsonian Astrophysical Observation", "SAO 93232"},
        {"Wilson Evans Batten Catalogue", "WEB 2764"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.18372171),
        dec: Angle.Degrees(+10.87047197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286820"},
        {"Hipparcos Number", "HIP 20751"},
        {"Geneva Identification System", "GEN# +5.20252059"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.70080047),
        dec: Angle.Degrees(+10.87110965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261656"},
        {"Hipparcos Number", "HIP 31912"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.03834077),
        dec: Angle.Degrees(+10.87146513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105533"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.61097633),
        dec: Angle.Degrees(+10.87368321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152482"},
        {"Hipparcos Number", "HIP 82604"},
        {"Smithsonian Astrophysical Observation", "SAO 102450"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.30581753),
        dec: Angle.Degrees(+10.87450126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54050"},
        {"Hipparcos Number", "HIP 34384"},
        {"Smithsonian Astrophysical Observation", "SAO 96520"},
    },
    visualMagnitude: 9.18,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.94412708),
        dec: Angle.Degrees(+10.87456017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77725"},
        {"Geneva Identification System", "GEN# +0.01102874"},
        {"Smithsonian Astrophysical Observation", "SAO 101784"},
        {"Wilson Evans Batten Catalogue", "WEB 13152"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.03497734),
        dec: Angle.Degrees(+10.87505320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -267.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65120"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.18319279),
        dec: Angle.Degrees(+10.87636434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199278"},
        {"Hipparcos Number", "HIP 103316"},
        {"Smithsonian Astrophysical Observation", "SAO 106668"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.98035205),
        dec: Angle.Degrees(+10.87657896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108228",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15447 AB"},
        {"Henry Draper", "HD 208348"},
        {"Hipparcos Number", "HIP 108228"},
        {"Geneva Identification System", "GEN# +1.00208348"},
        {"Smithsonian Astrophysical Observation", "SAO 107510"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.88092338),
        dec: Angle.Degrees(+10.88041945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85087"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.85449268),
        dec: Angle.Degrees(+10.88058956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87252"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.42697577),
        dec: Angle.Degrees(+10.88140106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51304"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.19115532),
        dec: Angle.Degrees(+10.88146609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85269"},
        {"Hipparcos Number", "HIP 48312"},
        {"Smithsonian Astrophysical Observation", "SAO 98808"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.73678513),
        dec: Angle.Degrees(+10.88248493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185458"},
        {"Hipparcos Number", "HIP 96632"},
        {"Geneva Identification System", "GEN# +1.00185458"},
        {"Smithsonian Astrophysical Observation", "SAO 105091"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.71026966),
        dec: Angle.Degrees(+10.88272138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61860"},
        {"Hipparcos Number", "HIP 37492"},
        {"Smithsonian Astrophysical Observation", "SAO 97151"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.43823097),
        dec: Angle.Degrees(+10.88514483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221347"},
        {"Hipparcos Number", "HIP 116087"},
        {"Smithsonian Astrophysical Observation", "SAO 108657"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.83915969),
        dec: Angle.Degrees(+10.88557505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47384"},
        {"Smithsonian Astrophysical Observation", "SAO 98695"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.80938335),
        dec: Angle.Degrees(+10.88621784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9307"},
        {"Hipparcos Number", "HIP 7117"},
        {"Geneva Identification System", "GEN# +1.00009307"},
        {"Smithsonian Astrophysical Observation", "SAO 92485"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.92771598),
        dec: Angle.Degrees(+10.88937825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81000"},
        {"Smithsonian Astrophysical Observation", "SAO 102229"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.13294756),
        dec: Angle.Degrees(+10.88983385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34793"},
        {"Hipparcos Number", "HIP 24921"},
        {"Fundamental Katalog 5th Edition", "FK5 4484"},
        {"Smithsonian Astrophysical Observation", "SAO 94472"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.10198968),
        dec: Angle.Degrees(+10.89044384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171505"},
        {"Hipparcos Number", "HIP 91090"},
        {"Geneva Identification System", "GEN# +1.00171505"},
        {"Smithsonian Astrophysical Observation", "SAO 103867"},
        {"Wilson Evans Batten Catalogue", "WEB 15633"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.69787478),
        dec: Angle.Degrees(+10.89200074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170470"},
        {"Hipparcos Number", "HIP 90599"},
        {"Geneva Identification System", "GEN# +1.00170470"},
        {"Smithsonian Astrophysical Observation", "SAO 103766"},
        {"Wilson Evans Batten Catalogue", "WEB 15513"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.30848388),
        dec: Angle.Degrees(+10.89206252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5359"},
        {"Smithsonian Astrophysical Observation", "SAO 92272"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.12939717),
        dec: Angle.Degrees(+10.89250305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24032",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3736 AB"},
        {"Henry Draper", "HD 33337"},
        {"Hipparcos Number", "HIP 24032"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.49654976),
        dec: Angle.Degrees(+10.89254999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33020"},
        {"Hipparcos Number", "HIP 23866"},
        {"Smithsonian Astrophysical Observation", "SAO 94338"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.94249080),
        dec: Angle.Degrees(+10.89506754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101160",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13920 AB"},
        {"Henry Draper", "HD 195325"},
        {"Hipparcos Number", "HIP 101160"},
        {"Celescope Catalog", "CEL 5083"},
        {"Geneva Identification System", "GEN# +1.00195325"},
        {"Smithsonian Astrophysical Observation", "SAO 106172"},
        {"Wilson Evans Batten Catalogue", "WEB 18274"},
    },
    visualMagnitude: 6.03,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.57479631),
        dec: Angle.Degrees(+10.89591574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267562"},
        {"Hipparcos Number", "HIP 33667"},
        {"Smithsonian Astrophysical Observation", "SAO 96357"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.91463487),
        dec: Angle.Degrees(+10.89640211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216674"},
        {"Hipparcos Number", "HIP 113134"},
        {"Smithsonian Astrophysical Observation", "SAO 108245"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.65458184),
        dec: Angle.Degrees(+10.89798837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158490"},
        {"Hipparcos Number", "HIP 85570"},
        {"Smithsonian Astrophysical Observation", "SAO 102850"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.30534800),
        dec: Angle.Degrees(+10.89936215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16250"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.35533280),
        dec: Angle.Degrees(+10.90049365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173215"},
        {"Hipparcos Number", "HIP 91882"},
        {"Smithsonian Astrophysical Observation", "SAO 104033"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.96455427),
        dec: Angle.Degrees(+10.90114332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205241"},
        {"Hipparcos Number", "HIP 106460"},
        {"Smithsonian Astrophysical Observation", "SAO 107232"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.43239989),
        dec: Angle.Degrees(+10.90184098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9536"},
        {"Hipparcos Number", "HIP 7277"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.43106459),
        dec: Angle.Degrees(+10.90437833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58248"},
        {"Hipparcos Number", "HIP 36006"},
        {"Smithsonian Astrophysical Observation", "SAO 96875"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.31071659),
        dec: Angle.Degrees(+10.90463715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57979"},
        {"Hipparcos Number", "HIP 35894"},
        {"Smithsonian Astrophysical Observation", "SAO 96860"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.00011620),
        dec: Angle.Degrees(+10.90629632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205013"},
        {"Hipparcos Number", "HIP 106337"},
        {"Smithsonian Astrophysical Observation", "SAO 107209"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.04917577),
        dec: Angle.Degrees(+10.91082386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250530"},
        {"Hipparcos Number", "HIP 28558"},
        {"Wilson Evans Batten Catalogue", "WEB 5583"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.41591398),
        dec: Angle.Degrees(+10.91102090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100740"},
        {"Hipparcos Number", "HIP 56553"},
        {"Fundamental Katalog 5th Edition", "FK5 2927"},
        {"Geneva Identification System", "GEN# +1.00100740"},
        {"Smithsonian Astrophysical Observation", "SAO 99683"},
        {"Wilson Evans Batten Catalogue", "WEB 10163"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.93082673),
        dec: Angle.Degrees(+10.91132809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190070"},
        {"Hipparcos Number", "HIP 98705"},
        {"Smithsonian Astrophysical Observation", "SAO 105591"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.71723383),
        dec: Angle.Degrees(+10.91171030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186534"},
        {"Hipparcos Number", "HIP 97145"},
        {"Smithsonian Astrophysical Observation", "SAO 105202"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.17292896),
        dec: Angle.Degrees(+10.91252159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96478"},
        {"Hipparcos Number", "HIP 54351"},
        {"Smithsonian Astrophysical Observation", "SAO 99453"},
        {"Wilson Evans Batten Catalogue", "WEB 9816"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.79806522),
        dec: Angle.Degrees(+10.91328770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32021"},
        {"Hipparcos Number", "HIP 23303"},
        {"Celescope Catalog", "CEL 507"},
        {"Geneva Identification System", "GEN# +1.00032021"},
        {"Smithsonian Astrophysical Observation", "SAO 94256"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.17759929),
        dec: Angle.Degrees(+10.91344927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42769"},
        {"Hipparcos Number", "HIP 29519"},
        {"Smithsonian Astrophysical Observation", "SAO 95392"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.27089614),
        dec: Angle.Degrees(+10.91379000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153540"},
        {"Hipparcos Number", "HIP 83165"},
        {"Smithsonian Astrophysical Observation", "SAO 102514"},
        {"Wilson Evans Batten Catalogue", "WEB 14054"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.94924900),
        dec: Angle.Degrees(+10.91543580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1627"},
        {"Hipparcos Number", "HIP 1638"},
        {"Smithsonian Astrophysical Observation", "SAO 91854"},
        {"Wilson Evans Batten Catalogue", "WEB 298"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.12638484),
        dec: Angle.Degrees(+10.91780810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9606"},
        {"Hipparcos Number", "HIP 7328"},
        {"Smithsonian Astrophysical Observation", "SAO 92517"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.58982891),
        dec: Angle.Degrees(+10.91836311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205374"},
        {"Hipparcos Number", "HIP 106526"},
        {"Smithsonian Astrophysical Observation", "SAO 107247"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.63998598),
        dec: Angle.Degrees(+10.91919022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224260"},
        {"Hipparcos Number", "HIP 118019"},
        {"Smithsonian Astrophysical Observation", "SAO 108918"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.08839344),
        dec: Angle.Degrees(+10.91946728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95192",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12351 AB"},
        {"Henry Draper", "HD 181882"},
        {"Hipparcos Number", "HIP 95192"},
        {"Smithsonian Astrophysical Observation", "SAO 104767"},
        {"Wilson Evans Batten Catalogue", "WEB 16630"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.47145858),
        dec: Angle.Degrees(+10.92048549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109401"},
        {"Hipparcos Number", "HIP 61353"},
        {"Geneva Identification System", "GEN# +1.00109401"},
        {"Smithsonian Astrophysical Observation", "SAO 100149"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.58418505),
        dec: Angle.Degrees(+10.92124385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110722"},
        {"Hipparcos Number", "HIP 62133"},
        {"Geneva Identification System", "GEN# +1.00110722"},
        {"Smithsonian Astrophysical Observation", "SAO 100229"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.00565423),
        dec: Angle.Degrees(+10.92133158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39739"},
        {"Smithsonian Astrophysical Observation", "SAO 97572"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.83118962),
        dec: Angle.Degrees(+10.92171140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73799"},
        {"Hipparcos Number", "HIP 42560"},
        {"Smithsonian Astrophysical Observation", "SAO 98028"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.13564335),
        dec: Angle.Degrees(+10.92415318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286943"},
        {"Hipparcos Number", "HIP 21676"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.80149785),
        dec: Angle.Degrees(+10.92428725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18952"},
        {"Hipparcos Number", "HIP 14214"},
        {"Smithsonian Astrophysical Observation", "SAO 93253"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.81883612),
        dec: Angle.Degrees(+10.92433177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54246"},
        {"Hipparcos Number", "HIP 34450"},
        {"Smithsonian Astrophysical Observation", "SAO 96540"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.12512926),
        dec: Angle.Degrees(+10.92527269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155422"},
        {"Hipparcos Number", "HIP 84060"},
        {"Smithsonian Astrophysical Observation", "SAO 102637"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.78128673),
        dec: Angle.Degrees(+10.92729404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202523"},
        {"Hipparcos Number", "HIP 105008"},
        {"Smithsonian Astrophysical Observation", "SAO 106980"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.03126325),
        dec: Angle.Degrees(+10.92991668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110250"},
        {"Hipparcos Number", "HIP 61856"},
        {"Geneva Identification System", "GEN# +1.00110250"},
        {"Smithsonian Astrophysical Observation", "SAO 100202"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.16269316),
        dec: Angle.Degrees(+10.93106143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126247"},
        {"Hipparcos Number", "HIP 70404"},
        {"Smithsonian Astrophysical Observation", "SAO 101010"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.05673697),
        dec: Angle.Degrees(+10.93169311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38494"},
        {"Hipparcos Number", "HIP 27257"},
        {"Smithsonian Astrophysical Observation", "SAO 94849"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.66837897),
        dec: Angle.Degrees(+10.93187087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30905",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Lusitania"},
        {"Henry Draper", "HD 45652"},
        {"Hipparcos Number", "HIP 30905"},
        {"Smithsonian Astrophysical Observation", "SAO 95735"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.30445502),
        dec: Angle.Degrees(+10.93404377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207676"},
        {"Hipparcos Number", "HIP 107811"},
        {"Smithsonian Astrophysical Observation", "SAO 107431"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.62416621),
        dec: Angle.Degrees(+10.93504469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65578"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.67432231),
        dec: Angle.Degrees(+10.93585802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120119"},
        {"Hipparcos Number", "HIP 67283"},
        {"Smithsonian Astrophysical Observation", "SAO 100708"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.84079659),
        dec: Angle.Degrees(+10.93737685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215243"},
        {"Hipparcos Number", "HIP 112222"},
        {"Geneva Identification System", "GEN# +1.00215243"},
        {"Smithsonian Astrophysical Observation", "SAO 108131"},
        {"Wilson Evans Batten Catalogue", "WEB 20027"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.92787181),
        dec: Angle.Degrees(+10.93978618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150800"},
        {"Hipparcos Number", "HIP 81838"},
        {"Smithsonian Astrophysical Observation", "SAO 102338"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.74062091),
        dec: Angle.Degrees(+10.94171902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75105"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.21576674),
        dec: Angle.Degrees(+10.94201325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41344"},
        {"Smithsonian Astrophysical Observation", "SAO 97811"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.52874520),
        dec: Angle.Degrees(+10.94269539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97835"},
        {"Hipparcos Number", "HIP 54968"},
        {"Smithsonian Astrophysical Observation", "SAO 99520"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.83871864),
        dec: Angle.Degrees(+10.94427546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110737"},
        {"Smithsonian Astrophysical Observation", "SAO 107910"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.52584456),
        dec: Angle.Degrees(+10.94527415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223781"},
        {"Hipparcos Number", "HIP 117730"},
        {"Fundamental Katalog 5th Edition", "FK5 1625"},
        {"Geneva Identification System", "GEN# +1.00223781"},
        {"Smithsonian Astrophysical Observation", "SAO 108879"},
        {"Wilson Evans Batten Catalogue", "WEB 20718"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.15465752),
        dec: Angle.Degrees(+10.94732837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144329"},
        {"Hipparcos Number", "HIP 78779"},
        {"Smithsonian Astrophysical Observation", "SAO 101908"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.24501776),
        dec: Angle.Degrees(+10.94834137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32349"},
        {"Hipparcos Number", "HIP 23485"},
        {"Smithsonian Astrophysical Observation", "SAO 94283"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.71879224),
        dec: Angle.Degrees(+10.94974291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45700",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7296 AB"},
        {"Henry Draper", "HD 80236"},
        {"Hipparcos Number", "HIP 45700"},
        {"Smithsonian Astrophysical Observation", "SAO 98491"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.74634731),
        dec: Angle.Degrees(+10.94988787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52960"},
        {"Hipparcos Number", "HIP 34033"},
        {"Geneva Identification System", "GEN# +1.00052960"},
        {"Smithsonian Astrophysical Observation", "SAO 96429"},
        {"Wilson Evans Batten Catalogue", "WEB 6822"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.90863811),
        dec: Angle.Degrees(+10.95184577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186571"},
        {"Henry Draper 2", "HD 186570"},
        {"Hipparcos Number", "HIP 97154"},
        {"Smithsonian Astrophysical Observation", "SAO 105204"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.21186998),
        dec: Angle.Degrees(+10.95194648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219029"},
        {"Hipparcos Number", "HIP 114575"},
        {"Geneva Identification System", "GEN# +1.00219029"},
        {"Smithsonian Astrophysical Observation", "SAO 108456"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.15214823),
        dec: Angle.Degrees(+10.95251931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184541"},
        {"Hipparcos Number", "HIP 96282"},
        {"Smithsonian Astrophysical Observation", "SAO 104987"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.66026486),
        dec: Angle.Degrees(+10.95271441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10917"},
        {"Hipparcos Number", "HIP 8327"},
        {"Smithsonian Astrophysical Observation", "SAO 92630"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.83993462),
        dec: Angle.Degrees(+10.95369126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8011"},
        {"Hipparcos Number", "HIP 6212"},
        {"Smithsonian Astrophysical Observation", "SAO 92367"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.91474526),
        dec: Angle.Degrees(+10.95769977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169416"},
        {"Hipparcos Number", "HIP 90181"},
        {"Smithsonian Astrophysical Observation", "SAO 103677"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.03765593),
        dec: Angle.Degrees(+10.95781734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221814"},
        {"Hipparcos Number", "HIP 116403"},
        {"Smithsonian Astrophysical Observation", "SAO 108696"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.81655929),
        dec: Angle.Degrees(+10.95856003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16539 AB"},
        {"Henry Draper", "HD 218550"},
        {"Hipparcos Number", "HIP 114280"},
        {"Geneva Identification System", "GEN# +1.00218550J"},
        {"Smithsonian Astrophysical Observation", "SAO 108426"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.19905283),
        dec: Angle.Degrees(+10.95864295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63608",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Vindemiatrix"},
        {"Henry Draper", "HD 113226"},
        {"Hipparcos Number", "HIP 63608"},
        {"Fundamental Katalog 5th Edition", "FK5 488"},
        {"Geneva Identification System", "GEN# +1.00113226"},
        {"Smithsonian Astrophysical Observation", "SAO 100384"},
        {"Wilson Evans Batten Catalogue", "WEB 11257"},
    },
    visualMagnitude: 2.85,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.54483557),
        dec: Angle.Degrees(+10.95910186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -275.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155545"},
        {"Hipparcos Number", "HIP 84125"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.97329081),
        dec: Angle.Degrees(+10.95959930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86419"},
        {"Hipparcos Number", "HIP 48911"},
        {"Geneva Identification System", "GEN# +1.00086419"},
        {"Smithsonian Astrophysical Observation", "SAO 98880"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.66397029),
        dec: Angle.Degrees(+10.96040187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162973"},
        {"Hipparcos Number", "HIP 87570"},
        {"Geneva Identification System", "GEN# +1.00162973"},
        {"Smithsonian Astrophysical Observation", "SAO 103181"},
    },
    visualMagnitude: 8.39,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.34888037),
        dec: Angle.Degrees(+10.96048015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105000"},
        {"Hipparcos Number", "HIP 58968"},
        {"Geneva Identification System", "GEN# +1.00105000"},
        {"Smithsonian Astrophysical Observation", "SAO 99937"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.36414795),
        dec: Angle.Degrees(+10.96065506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12787"},
        {"Geneva Identification System", "GEN# +6.20030401"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.08882575),
        dec: Angle.Degrees(+10.96154942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87911",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10916 AB"},
        {"Hipparcos Number", "HIP 87911"},
        {"Geneva Identification System", "GEN# +0.01003337J"},
        {"Smithsonian Astrophysical Observation", "SAO 103244"},
        {"Wilson Evans Batten Catalogue", "WEB 14845"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.36891832),
        dec: Angle.Degrees(+10.96298807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14861"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.98315748),
        dec: Angle.Degrees(+10.96448566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172587"},
        {"Hipparcos Number", "HIP 91586"},
        {"Smithsonian Astrophysical Observation", "SAO 103979"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.17449380),
        dec: Angle.Degrees(+10.96523180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287148"},
        {"Hipparcos Number", "HIP 22324"},
        {"Geneva Identification System", "GEN# +2.16620002"},
        {"Smithsonian Astrophysical Observation", "SAO 94135"},
        {"New General Catalogue", "NGC 1662 2"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.13368247),
        dec: Angle.Degrees(+10.96639738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138573"},
        {"Hipparcos Number", "HIP 76114"},
        {"Geneva Identification System", "GEN# +1.00138573"},
        {"Smithsonian Astrophysical Observation", "SAO 101603"},
        {"Wilson Evans Batten Catalogue", "WEB 12931"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.18190194),
        dec: Angle.Degrees(+10.96791367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103969"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.97720611),
        dec: Angle.Degrees(+10.97066396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19112",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2981 AB"},
        {"Henry Draper", "HD 25812"},
        {"Hipparcos Number", "HIP 19112"},
        {"Smithsonian Astrophysical Observation", "SAO 93758"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.47037746),
        dec: Angle.Degrees(+10.97342896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209288"},
        {"Hipparcos Number", "HIP 108766"},
        {"Geneva Identification System", "GEN# +1.00209288"},
        {"Smithsonian Astrophysical Observation", "SAO 107599"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.50570044),
        dec: Angle.Degrees(+10.97380235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114687"},
        {"Smithsonian Astrophysical Observation", "SAO 108471"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.49754257),
        dec: Angle.Degrees(+10.97617425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199453"},
        {"Hipparcos Number", "HIP 103402"},
        {"Smithsonian Astrophysical Observation", "SAO 106686"},
    },
    visualMagnitude: 9.07,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.23273266),
        dec: Angle.Degrees(+10.97618265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92475",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11750 AB"},
        {"Henry Draper", "HD 174569"},
        {"Hipparcos Number", "HIP 92475"},
        {"Smithsonian Astrophysical Observation", "SAO 104170"},
        {"Wilson Evans Batten Catalogue", "WEB 15979"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.68977943),
        dec: Angle.Degrees(+10.97637690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21134"},
        {"Hipparcos Number", "HIP 15922"},
        {"Smithsonian Astrophysical Observation", "SAO 93421"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.26911925),
        dec: Angle.Degrees(+10.97650166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1670",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 287 AB"},
        {"Henry Draper", "HD 1663"},
        {"Hipparcos Number", "HIP 1670"},
        {"Smithsonian Astrophysical Observation", "SAO 91858"},
        {"Wilson Evans Batten Catalogue", "WEB 306"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.22755274),
        dec: Angle.Degrees(+10.97696797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140209"},
        {"Hipparcos Number", "HIP 76899"},
        {"Geneva Identification System", "GEN# +1.00140209"},
        {"Smithsonian Astrophysical Observation", "SAO 101688"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.52418373),
        dec: Angle.Degrees(+10.97748946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221494"},
        {"Hipparcos Number", "HIP 116198"},
        {"Smithsonian Astrophysical Observation", "SAO 108671"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.14820371),
        dec: Angle.Degrees(+10.97779785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196793"},
        {"Hipparcos Number", "HIP 101920"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.80434491),
        dec: Angle.Degrees(+10.97833852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180587"},
        {"Hipparcos Number", "HIP 94747"},
        {"Geneva Identification System", "GEN# +1.00180587"},
        {"Smithsonian Astrophysical Observation", "SAO 104676"},
        {"Wilson Evans Batten Catalogue", "WEB 16531"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.19345612),
        dec: Angle.Degrees(+10.97964581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230017"},
        {"Hipparcos Number", "HIP 92836"},
        {"Geneva Identification System", "GEN# +1.00230017"},
        {"Wilson Evans Batten Catalogue", "WEB 16070"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)54, 53.7900),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)58, 54.800)
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
    primaryId: "HIP 57163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101842"},
        {"Hipparcos Number", "HIP 57163"},
        {"Smithsonian Astrophysical Observation", "SAO 99754"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.85170001),
        dec: Angle.Degrees(+10.98518378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195054"},
        {"Hipparcos Number", "HIP 100999"},
        {"Smithsonian Astrophysical Observation", "SAO 106144"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.15487103),
        dec: Angle.Degrees(+10.98698096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78029"},
    },
    visualMagnitude: 11.44,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.98766777),
        dec: Angle.Degrees(+10.98716370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103083"},
        {"Hipparcos Number", "HIP 57882"},
        {"Smithsonian Astrophysical Observation", "SAO 99833"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.07251720),
        dec: Angle.Degrees(+10.98742391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30598"},
        {"Hipparcos Number", "HIP 22416"},
        {"Geneva Identification System", "GEN# +2.16620004"},
        {"Renson", "Renson 7920"},
        {"Smithsonian Astrophysical Observation", "SAO 94149"},
        {"New General Catalogue", "NGC 1662 4"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.36109825),
        dec: Angle.Degrees(+10.98840530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148296"},
        {"Hipparcos Number", "HIP 80548"},
        {"Geneva Identification System", "GEN# +1.00148296"},
        {"Smithsonian Astrophysical Observation", "SAO 102172"},
        {"Wilson Evans Batten Catalogue", "WEB 13626"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.68039910),
        dec: Angle.Degrees(+10.99062453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193738"},
        {"Hipparcos Number", "HIP 100398"},
        {"Smithsonian Astrophysical Observation", "SAO 106013"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.40079063),
        dec: Angle.Degrees(+10.99179984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137294"},
        {"Hipparcos Number", "HIP 75448"},
        {"Geneva Identification System", "GEN# +1.00137294"},
        {"Smithsonian Astrophysical Observation", "SAO 101533"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.20496800),
        dec: Angle.Degrees(+10.99314217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154516"},
        {"Hipparcos Number", "HIP 83636"},
        {"Smithsonian Astrophysical Observation", "SAO 102589"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.38735206),
        dec: Angle.Degrees(+10.99481206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111543"},
        {"Hipparcos Number", "HIP 62619"},
        {"Smithsonian Astrophysical Observation", "SAO 100290"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.46918919),
        dec: Angle.Degrees(+10.99577291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198861"},
        {"Hipparcos Number", "HIP 103068"},
        {"Geneva Identification System", "GEN# +1.00198861"},
        {"Smithsonian Astrophysical Observation", "SAO 106610"},
        {"Wilson Evans Batten Catalogue", "WEB 18711"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.24043999),
        dec: Angle.Degrees(+10.99617831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50371"},
        {"Hipparcos Number", "HIP 33082"},
        {"Geneva Identification System", "GEN# +1.00050371"},
        {"Smithsonian Astrophysical Observation", "SAO 96241"},
        {"Wilson Evans Batten Catalogue", "WEB 6659"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.34333787),
        dec: Angle.Degrees(+10.99694209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80822"},
        {"Smithsonian Astrophysical Observation", "SAO 102213"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.57019563),
        dec: Angle.Degrees(+10.99784169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82967"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.31983702),
        dec: Angle.Degrees(+10.99785742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7022"},
        {"Hipparcos Number", "HIP 5527"},
        {"Geneva Identification System", "GEN# +1.00007022"},
        {"Smithsonian Astrophysical Observation", "SAO 92296"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.68555976),
        dec: Angle.Degrees(+10.99971873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47886"},
        {"Hipparcos Number", "HIP 32012"},
        {"Geneva Identification System", "GEN# +1.00047886"},
        {"Smithsonian Astrophysical Observation", "SAO 95997"},
        {"Wilson Evans Batten Catalogue", "WEB 6458"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.32173864),
        dec: Angle.Degrees(+11.00317922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224983"},
        {"Hipparcos Number", "HIP 184"},
        {"Fundamental Katalog 5th Edition", "FK5 4003"},
        {"Smithsonian Astrophysical Observation", "SAO 108973"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.58977565),
        dec: Angle.Degrees(+11.00634091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9964"},
        {"Smithsonian Astrophysical Observation", "SAO 92805"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.07735442),
        dec: Angle.Degrees(+11.00714435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43984"},
        {"Hipparcos Number", "HIP 30072"},
        {"Celescope Catalog", "CEL 1176"},
        {"Geneva Identification System", "GEN# +1.00043984"},
        {"Smithsonian Astrophysical Observation", "SAO 95541"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.92500995),
        dec: Angle.Degrees(+11.00779041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39209"},
        {"Smithsonian Astrophysical Observation", "SAO 97482"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.30509145),
        dec: Angle.Degrees(+11.00780962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58599"},
        {"Hipparcos Number", "HIP 36141"},
        {"Geneva Identification System", "GEN# +1.00058599"},
        {"Renson", "Renson 16015"},
        {"Smithsonian Astrophysical Observation", "SAO 96901"},
        {"Wilson Evans Batten Catalogue", "WEB 7197"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.67173733),
        dec: Angle.Degrees(+11.00885807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104888"},
        {"Geneva Identification System", "GEN# +9.80025022"},
    },
    visualMagnitude: 12.32,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.70210504),
        dec: Angle.Degrees(+11.00929315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -370.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99636"},
        {"Hipparcos Number", "HIP 55943"},
        {"Geneva Identification System", "GEN# +1.00099636"},
        {"Smithsonian Astrophysical Observation", "SAO 99613"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.98074615),
        dec: Angle.Degrees(+11.01006017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60136"},
        {"Hipparcos Number", "HIP 36746"},
        {"Fundamental Katalog 5th Edition", "FK5 4679"},
        {"Smithsonian Astrophysical Observation", "SAO 97014"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.36456615),
        dec: Angle.Degrees(+11.01175145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57383"},
        {"Hipparcos Number", "HIP 35657"},
        {"Smithsonian Astrophysical Observation", "SAO 96811"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.36453276),
        dec: Angle.Degrees(+11.01184993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18904"},
        {"Hipparcos Number", "HIP 14172"},
        {"Geneva Identification System", "GEN# +1.00018904"},
        {"Smithsonian Astrophysical Observation", "SAO 93249"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.68567333),
        dec: Angle.Degrees(+11.01274697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55825"},
        {"Hipparcos Number", "HIP 35062"},
        {"Smithsonian Astrophysical Observation", "SAO 96682"},
    },
    visualMagnitude: 8.39,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.75676097),
        dec: Angle.Degrees(+11.01295352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222008"},
        {"Hipparcos Number", "HIP 116529"},
        {"Fundamental Katalog 5th Edition", "FK5 6089"},
        {"Geneva Identification System", "GEN# +1.00222008"},
        {"Smithsonian Astrophysical Observation", "SAO 108715"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.24304764),
        dec: Angle.Degrees(+11.01499025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140386"},
        {"Hipparcos Number", "HIP 76972"},
        {"Geneva Identification System", "GEN# +1.00140386"},
        {"Smithsonian Astrophysical Observation", "SAO 101696"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.75364749),
        dec: Angle.Degrees(+11.01728732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 159.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12512"},
        {"Hipparcos Number", "HIP 9569"},
        {"Smithsonian Astrophysical Observation", "SAO 92768"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.73985718),
        dec: Angle.Degrees(+11.01875980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35063"},
    },
    visualMagnitude: 12.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.75726202),
        dec: Angle.Degrees(+11.01879373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45638"},
        {"Hipparcos Number", "HIP 30886"},
        {"Geneva Identification System", "GEN# +1.00045638"},
        {"Renson", "Renson 12127"},
        {"Smithsonian Astrophysical Observation", "SAO 95732"},
        {"Wilson Evans Batten Catalogue", "WEB 6155"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.25069348),
        dec: Angle.Degrees(+11.01924211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91877"},
        {"Hipparcos Number", "HIP 51945"},
        {"Smithsonian Astrophysical Observation", "SAO 99206"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.17910182),
        dec: Angle.Degrees(+11.02215544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50483"},
        {"Hipparcos Number", "HIP 33121"},
        {"Geneva Identification System", "GEN# +1.00050483"},
        {"Smithsonian Astrophysical Observation", "SAO 96247"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.47535187),
        dec: Angle.Degrees(+11.02335012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100518"},
        {"Hipparcos Number", "HIP 56429"},
        {"Geneva Identification System", "GEN# +1.00100518"},
        {"Renson", "Renson 28890"},
        {"Smithsonian Astrophysical Observation", "SAO 99668"},
        {"Wilson Evans Batten Catalogue", "WEB 10141"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.54136233),
        dec: Angle.Degrees(+11.02391942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59204"},
        {"Hipparcos Number", "HIP 36385"},
        {"Smithsonian Astrophysical Observation", "SAO 96942"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.32543681),
        dec: Angle.Degrees(+11.02452663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68476"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.28959278),
        dec: Angle.Degrees(+11.02493472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73418"},
        {"Geneva Identification System", "GEN# +0.01102751"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.06075925),
        dec: Angle.Degrees(+11.02664936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -394.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172312"},
        {"Hipparcos Number", "HIP 91451"},
        {"Smithsonian Astrophysical Observation", "SAO 103950"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.77764888),
        dec: Angle.Degrees(+11.02692998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183341"},
        {"Hipparcos Number", "HIP 95772"},
        {"Geneva Identification System", "GEN# +1.00183341"},
        {"Smithsonian Astrophysical Observation", "SAO 104879"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.19330787),
        dec: Angle.Degrees(+11.02705223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26721"},
        {"Hipparcos Number", "HIP 19750"},
        {"Smithsonian Astrophysical Observation", "SAO 93824"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.50406537),
        dec: Angle.Degrees(+11.02723956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25000"},
        {"Hipparcos Number", "HIP 18581"},
        {"Smithsonian Astrophysical Observation", "SAO 93699"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.65560793),
        dec: Angle.Degrees(+11.02759538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128580"},
        {"Hipparcos Number", "HIP 71505"},
        {"Geneva Identification System", "GEN# +1.00128580"},
        {"Smithsonian Astrophysical Observation", "SAO 101110"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.34458131),
        dec: Angle.Degrees(+11.02786575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -286.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211154"},
        {"Hipparcos Number", "HIP 109863"},
        {"Smithsonian Astrophysical Observation", "SAO 107762"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.76521166),
        dec: Angle.Degrees(+11.02889453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58212"},
    },
    visualMagnitude: 11.05,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.08505092),
        dec: Angle.Degrees(+11.02900209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189659"},
        {"Hipparcos Number", "HIP 98508"},
        {"Geneva Identification System", "GEN# +9.00051007"},
        {"Smithsonian Astrophysical Observation", "SAO 105541"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.18559366),
        dec: Angle.Degrees(+11.03188791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37171"},
        {"Hipparcos Number", "HIP 26386"},
        {"Fundamental Katalog 5th Edition", "FK5 2420"},
        {"Geneva Identification System", "GEN# +1.00037171"},
        {"Smithsonian Astrophysical Observation", "SAO 94702"},
        {"Wilson Evans Batten Catalogue", "WEB 5205"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.26813110),
        dec: Angle.Degrees(+11.03504389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71504"},
        {"Geneva Identification System", "GEN# +9.80066016"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.34420318),
        dec: Angle.Degrees(+11.03512914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -310.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211905"},
        {"Hipparcos Number", "HIP 110286"},
        {"Smithsonian Astrophysical Observation", "SAO 107842"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.08834175),
        dec: Angle.Degrees(+11.03906858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40983"},
        {"Smithsonian Astrophysical Observation", "SAO 97760"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.45772880),
        dec: Angle.Degrees(+11.04223299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127069"},
        {"Hipparcos Number", "HIP 70828"},
        {"Smithsonian Astrophysical Observation", "SAO 101045"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.26176671),
        dec: Angle.Degrees(+11.04280970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11257"},
        {"Hipparcos Number", "HIP 8588"},
        {"Geneva Identification System", "GEN# +1.00011257"},
        {"Smithsonian Astrophysical Observation", "SAO 92659"},
        {"Wilson Evans Batten Catalogue", "WEB 1822"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.71672491),
        dec: Angle.Degrees(+11.04344590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69266"},
        {"Hipparcos Number", "HIP 40530"},
        {"Smithsonian Astrophysical Observation", "SAO 97693"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.13683215),
        dec: Angle.Degrees(+11.04368165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 356404"},
        {"Hipparcos Number", "HIP 98217"},
        {"Geneva Identification System", "GEN# +1.00356404"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.38759321),
        dec: Angle.Degrees(+11.04368897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64284"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.62258649),
        dec: Angle.Degrees(+11.04447244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163772"},
        {"Hipparcos Number", "HIP 87910"},
        {"Geneva Identification System", "GEN# +1.00163772"},
        {"Smithsonian Astrophysical Observation", "SAO 103243"},
        {"Wilson Evans Batten Catalogue", "WEB 14841"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.36245797),
        dec: Angle.Degrees(+11.04456794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113893"},
        {"Hipparcos Number", "HIP 63977"},
        {"Geneva Identification System", "GEN# +1.00113893"},
        {"Smithsonian Astrophysical Observation", "SAO 100418"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.64943035),
        dec: Angle.Degrees(+11.04469688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -245.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64916"},
        {"Hipparcos Number", "HIP 38810"},
        {"Smithsonian Astrophysical Observation", "SAO 97390"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.13872762),
        dec: Angle.Degrees(+11.04581963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22226"},
        {"Hipparcos Number", "HIP 16715"},
        {"Geneva Identification System", "GEN# +1.00022226"},
        {"Smithsonian Astrophysical Observation", "SAO 93500"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.76444306),
        dec: Angle.Degrees(+11.04586834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27262",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4367 B"},
        {"Hipparcos Number", "HIP 27262"},
    },
    visualMagnitude: 9.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)46, 43.7500),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)02, 45.600)
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
    primaryId: "HIP 84923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157168"},
        {"Hipparcos Number", "HIP 84923"},
        {"Geneva Identification System", "GEN# +1.00157168"},
        {"Smithsonian Astrophysical Observation", "SAO 102764"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.33110654),
        dec: Angle.Degrees(+11.04853304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49061"},
        {"Hipparcos Number", "HIP 32506"},
        {"Geneva Identification System", "GEN# +1.00049061"},
        {"Smithsonian Astrophysical Observation", "SAO 96103"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.76086622),
        dec: Angle.Degrees(+11.04871305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73938"},
        {"Hipparcos Number", "HIP 42631"},
        {"Geneva Identification System", "GEN# +1.00073938"},
        {"Smithsonian Astrophysical Observation", "SAO 98042"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.32027309),
        dec: Angle.Degrees(+11.04876402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1612"},
        {"Smithsonian Astrophysical Observation", "SAO 91851"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.04544178),
        dec: Angle.Degrees(+11.04939691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27263",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4367 A"},
        {"Henry Draper", "HD 38505"},
        {"Hipparcos Number", "HIP 27263"},
        {"Geneva Identification System", "GEN# +1.00038505"},
        {"Smithsonian Astrophysical Observation", "SAO 94850"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.68546323),
        dec: Angle.Degrees(+11.05055707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190994"},
        {"Hipparcos Number", "HIP 99111"},
        {"Geneva Identification System", "GEN# +1.00190994"},
        {"Smithsonian Astrophysical Observation", "SAO 105712"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.82459020),
        dec: Angle.Degrees(+11.05392828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50608"},
        {"Hipparcos Number", "HIP 33192"},
        {"Smithsonian Astrophysical Observation", "SAO 96259"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.61956085),
        dec: Angle.Degrees(+11.05515878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84460"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.00299442),
        dec: Angle.Degrees(+11.05851440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -349.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16276"},
        {"Hipparcos Number", "HIP 12194"},
        {"Geneva Identification System", "GEN# +1.00016276"},
        {"Smithsonian Astrophysical Observation", "SAO 93027"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.25994987),
        dec: Angle.Degrees(+11.05927067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15564"},
        {"Hipparcos Number", "HIP 11665"},
        {"Geneva Identification System", "GEN# +1.00015564"},
        {"Smithsonian Astrophysical Observation", "SAO 92978"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.61983984),
        dec: Angle.Degrees(+11.06215077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46069"},
        {"Smithsonian Astrophysical Observation", "SAO 98542"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.92114315),
        dec: Angle.Degrees(+11.06239062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182719"},
        {"Hipparcos Number", "HIP 95510"},
        {"Smithsonian Astrophysical Observation", "SAO 104816"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.40320239),
        dec: Angle.Degrees(+11.06284295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166209"},
        {"Hipparcos Number", "HIP 88930"},
        {"Smithsonian Astrophysical Observation", "SAO 103425"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.29447434),
        dec: Angle.Degrees(+11.06325762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69418",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9160 AB"},
        {"Henry Draper", "HD 124332"},
        {"Hipparcos Number", "HIP 69418"},
        {"Smithsonian Astrophysical Observation", "SAO 100912"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.19611321),
        dec: Angle.Degrees(+11.06362348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114641",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16603 A"},
        {"Henry Draper", "HD 219139"},
        {"Hipparcos Number", "HIP 114641"},
        {"Fundamental Katalog 5th Edition", "FK5 3858"},
        {"Geneva Identification System", "GEN# +1.00219139A"},
        {"Smithsonian Astrophysical Observation", "SAO 108463"},
        {"Wilson Evans Batten Catalogue", "WEB 20335"},
    },
    visualMagnitude: 5.85,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.36045184),
        dec: Angle.Degrees(+11.06501583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3848"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.35604063),
        dec: Angle.Degrees(+11.06612507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22550",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3475 AB"},
        {"Henry Draper", "HD 30810"},
        {"Hipparcos Number", "HIP 22550"},
        {"Celescope Catalog", "CEL 474"},
        {"Geneva Identification System", "GEN# +5.20250122J"},
        {"Smithsonian Astrophysical Observation", "SAO 94163"},
        {"Wilson Evans Batten Catalogue", "WEB 4357"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.80200557),
        dec: Angle.Degrees(+11.06804697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88227"},
        {"Smithsonian Astrophysical Observation", "SAO 103298"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.25748879),
        dec: Angle.Degrees(+11.06930852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104439"},
        {"Hipparcos Number", "HIP 58652"},
        {"Geneva Identification System", "GEN# +1.00104439"},
        {"Smithsonian Astrophysical Observation", "SAO 99914"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.41128073),
        dec: Angle.Degrees(+11.06940549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84346"},
        {"Smithsonian Astrophysical Observation", "SAO 102678"},
        {"Wilson Evans Batten Catalogue", "WEB 14242"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.66574302),
        dec: Angle.Degrees(+11.06941509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3055"},
        {"Hipparcos Number", "HIP 2671"},
        {"Smithsonian Astrophysical Observation", "SAO 91968"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.46390995),
        dec: Angle.Degrees(+11.06970950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56716"},
        {"Hipparcos Number", "HIP 35405"},
        {"Smithsonian Astrophysical Observation", "SAO 96756"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65885982),
        dec: Angle.Degrees(+11.07037109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178125"},
        {"Hipparcos Number", "HIP 93867"},
        {"Fundamental Katalog 5th Edition", "FK5 3525"},
        {"Geneva Identification System", "GEN# +1.00178125"},
        {"Smithsonian Astrophysical Observation", "SAO 104488"},
        {"Wilson Evans Batten Catalogue", "WEB 16329"},
    },
    visualMagnitude: 5.07,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.74418054),
        dec: Angle.Degrees(+11.07130501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151954"},
        {"Hipparcos Number", "HIP 82395"},
        {"Smithsonian Astrophysical Observation", "SAO 102418"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.54294565),
        dec: Angle.Degrees(+11.07539177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199073"},
        {"Hipparcos Number", "HIP 103186"},
        {"Smithsonian Astrophysical Observation", "SAO 106635"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.58763966),
        dec: Angle.Degrees(+11.07551996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129447"},
        {"Hipparcos Number", "HIP 71895"},
        {"Smithsonian Astrophysical Observation", "SAO 101159"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.58021067),
        dec: Angle.Degrees(+11.07563506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89731"},
        {"Hipparcos Number", "HIP 50729"},
        {"Smithsonian Astrophysical Observation", "SAO 99078"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.37231038),
        dec: Angle.Degrees(+11.07806751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110447",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15875 A"},
        {"Henry Draper", "HD 212187"},
        {"Hipparcos Number", "HIP 110447"},
        {"Smithsonian Astrophysical Observation", "SAO 107862"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.57418853),
        dec: Angle.Degrees(+11.08023414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116942"},
    },
    visualMagnitude: 11.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.56787516),
        dec: Angle.Degrees(+24.91626541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110444",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15875 B"},
        {"Hipparcos Number", "HIP 110444"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.57069619),
        dec: Angle.Degrees(+11.08099201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35270"},
        {"Hipparcos Number", "HIP 25245"},
        {"Geneva Identification System", "GEN# +1.00035270"},
        {"Smithsonian Astrophysical Observation", "SAO 94519"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.97454715),
        dec: Angle.Degrees(+11.08358205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106053",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15007 AB"},
        {"Henry Draper", "HD 204509"},
        {"Hipparcos Number", "HIP 106053"},
        {"Geneva Identification System", "GEN# +1.00204509A"},
        {"Smithsonian Astrophysical Observation", "SAO 107165"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.21996092),
        dec: Angle.Degrees(+11.08478766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194074"},
        {"Hipparcos Number", "HIP 100547"},
        {"Fundamental Katalog 5th Edition", "FK5 5797"},
        {"Smithsonian Astrophysical Observation", "SAO 106048"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.81560049),
        dec: Angle.Degrees(+11.08513055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215015"},
        {"Hipparcos Number", "HIP 112082"},
        {"Geneva Identification System", "GEN# +1.00215015"},
        {"Smithsonian Astrophysical Observation", "SAO 108112"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.53393437),
        dec: Angle.Degrees(+11.08552565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10528"},
        {"Hipparcos Number", "HIP 8010"},
        {"Geneva Identification System", "GEN# +1.00010528"},
        {"Smithsonian Astrophysical Observation", "SAO 92590"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.70829101),
        dec: Angle.Degrees(+11.08585762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183082"},
        {"Hipparcos Number", "HIP 95658"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.86174414),
        dec: Angle.Degrees(+11.08621310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61501"},
        {"Hipparcos Number", "HIP 37355"},
        {"Smithsonian Astrophysical Observation", "SAO 97129"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.00917918),
        dec: Angle.Degrees(+11.08933690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17040"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.79522176),
        dec: Angle.Degrees(+11.08997155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9156"},
        {"Hipparcos Number", "HIP 7014"},
        {"Smithsonian Astrophysical Observation", "SAO 92470"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.57799339),
        dec: Angle.Degrees(+11.09089465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207861"},
        {"Hipparcos Number", "HIP 107919"},
        {"Geneva Identification System", "GEN# +1.00207861"},
        {"Smithsonian Astrophysical Observation", "SAO 107452"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.96610226),
        dec: Angle.Degrees(+11.09119705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181384"},
        {"Hipparcos Number", "HIP 95007"},
        {"Smithsonian Astrophysical Observation", "SAO 104730"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.98606494),
        dec: Angle.Degrees(+11.09233502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169649"},
        {"Hipparcos Number", "HIP 90285"},
        {"Smithsonian Astrophysical Observation", "SAO 103698"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.32719858),
        dec: Angle.Degrees(+11.09810019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97324"},
        {"Hipparcos Number", "HIP 54714"},
        {"Smithsonian Astrophysical Observation", "SAO 99495"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.04176473),
        dec: Angle.Degrees(+11.10074295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206720"},
        {"Hipparcos Number", "HIP 107280"},
        {"Smithsonian Astrophysical Observation", "SAO 107355"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.94289331),
        dec: Angle.Degrees(+11.10143068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46076"},
        {"Hipparcos Number", "HIP 31111"},
        {"Geneva Identification System", "GEN# +1.00046076"},
        {"Smithsonian Astrophysical Observation", "SAO 95785"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.92056636),
        dec: Angle.Degrees(+11.10219525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249798"},
        {"Hipparcos Number", "HIP 28260"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.56868377),
        dec: Angle.Degrees(+11.10649735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85091"},
        {"Hipparcos Number", "HIP 48215"},
        {"Cincinnati Publication", "Ci 18 1165"},
        {"Geneva Identification System", "GEN# +1.00085091"},
        {"Smithsonian Astrophysical Observation", "SAO 98794"},
        {"Wilson Evans Batten Catalogue", "WEB 9000"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.45291292),
        dec: Angle.Degrees(+11.10656232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -315.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201548"},
        {"Hipparcos Number", "HIP 104480"},
        {"Smithsonian Astrophysical Observation", "SAO 106885"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.48961945),
        dec: Angle.Degrees(+11.10747513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63186"},
        {"Hipparcos Number", "HIP 38057"},
        {"Smithsonian Astrophysical Observation", "SAO 97259"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.99911444),
        dec: Angle.Degrees(+11.10941076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34907"},
        {"Hipparcos Number", "HIP 24998"},
        {"Geneva Identification System", "GEN# +1.00034907"},
        {"Smithsonian Astrophysical Observation", "SAO 94484"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.29989536),
        dec: Angle.Degrees(+11.10948463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80044"},
        {"Smithsonian Astrophysical Observation", "SAO 102092"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.08100886),
        dec: Angle.Degrees(+11.11066031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3991"},
        {"Hipparcos Number", "HIP 3345"},
        {"Smithsonian Astrophysical Observation", "SAO 92045"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.65792441),
        dec: Angle.Degrees(+11.11124785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106136"},
        {"Hipparcos Number", "HIP 59549"},
        {"Geneva Identification System", "GEN# +1.00106136"},
        {"Smithsonian Astrophysical Observation", "SAO 99986"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.19415526),
        dec: Angle.Degrees(+11.11138942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178772"},
        {"Hipparcos Number", "HIP 94120"},
        {"Geneva Identification System", "GEN# +1.00178772"},
        {"Smithsonian Astrophysical Observation", "SAO 104539"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.39179588),
        dec: Angle.Degrees(+11.11505331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61149"},
        {"Hipparcos Number", "HIP 37168"},
        {"Smithsonian Astrophysical Observation", "SAO 97103"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.56491865),
        dec: Angle.Degrees(+11.11757546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103312"},
        {"Hipparcos Number", "HIP 58010"},
        {"Fundamental Katalog 5th Edition", "FK5 5046"},
        {"Smithsonian Astrophysical Observation", "SAO 99849"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.47335450),
        dec: Angle.Degrees(+11.11958395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113125"},
        {"Hipparcos Number", "HIP 63553"},
        {"Geneva Identification System", "GEN# +1.00113125"},
        {"Smithsonian Astrophysical Observation", "SAO 100377"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.34510592),
        dec: Angle.Degrees(+11.12156164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100139"},
        {"Hipparcos Number", "HIP 56224"},
        {"Smithsonian Astrophysical Observation", "SAO 99646"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.89050259),
        dec: Angle.Degrees(+11.12162376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5179"},
        {"Hipparcos Number", "HIP 4221"},
        {"Smithsonian Astrophysical Observation", "SAO 92141"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.45968955),
        dec: Angle.Degrees(+11.12254384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46660"},
        {"Hipparcos Number", "HIP 31411"},
        {"Geneva Identification System", "GEN# +1.00046660J"},
        {"Smithsonian Astrophysical Observation", "SAO 95865"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.75152604),
        dec: Angle.Degrees(+11.12442382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45090"},
        {"Hipparcos Number", "HIP 30602"},
        {"Smithsonian Astrophysical Observation", "SAO 95672"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.46804172),
        dec: Angle.Degrees(+11.12590779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56391"},
        {"Hipparcos Number", "HIP 35269"},
        {"Smithsonian Astrophysical Observation", "SAO 96725"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.30145262),
        dec: Angle.Degrees(+11.12650042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35405"},
        {"Hipparcos Number", "HIP 25323"},
        {"Smithsonian Astrophysical Observation", "SAO 94534"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.24950058),
        dec: Angle.Degrees(+11.12730515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163151"},
        {"Hipparcos Number", "HIP 87655"},
        {"Fundamental Katalog 5th Edition", "FK5 3422"},
        {"Geneva Identification System", "GEN# +1.00163151J"},
        {"Smithsonian Astrophysical Observation", "SAO 103194"},
        {"Wilson Evans Batten Catalogue", "WEB 14794"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.55920521),
        dec: Angle.Degrees(+11.13095438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223060"},
        {"Hipparcos Number", "HIP 117238"},
        {"Geneva Identification System", "GEN# +1.00223060"},
        {"Smithsonian Astrophysical Observation", "SAO 108820"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.57841908),
        dec: Angle.Degrees(+11.13184245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151616"},
        {"Hipparcos Number", "HIP 82239"},
        {"Smithsonian Astrophysical Observation", "SAO 102391"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.02496863),
        dec: Angle.Degrees(+11.13233566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74809"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.32453484),
        dec: Angle.Degrees(+11.13440319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3131"},
        {"Hipparcos Number", "HIP 2724"},
        {"Smithsonian Astrophysical Observation", "SAO 91975"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.67196043),
        dec: Angle.Degrees(+11.13483499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113998"},
        {"Hipparcos Number", "HIP 64035"},
        {"Smithsonian Astrophysical Observation", "SAO 100422"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.85383262),
        dec: Angle.Degrees(+11.13523116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75718"},
        {"Hipparcos Number", "HIP 43530"},
        {"Smithsonian Astrophysical Observation", "SAO 98181"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.98466911),
        dec: Angle.Degrees(+11.13595397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4634 AB"},
        {"Henry Draper", "HD 41057"},
        {"Hipparcos Number", "HIP 28676"},
        {"Smithsonian Astrophysical Observation", "SAO 95167"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.82362360),
        dec: Angle.Degrees(+11.13606188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220953"},
        {"Hipparcos Number", "HIP 115825"},
        {"Smithsonian Astrophysical Observation", "SAO 108622"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.98371275),
        dec: Angle.Degrees(+11.13614441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19067"},
        {"Hipparcos Number", "HIP 14298"},
        {"Smithsonian Astrophysical Observation", "SAO 93259"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.08427405),
        dec: Angle.Degrees(+11.13626374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108438"},
        {"Hipparcos Number", "HIP 60784"},
        {"Smithsonian Astrophysical Observation", "SAO 100102"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.87636526),
        dec: Angle.Degrees(+11.13633202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23328"},
        {"Hipparcos Number", "HIP 17469"},
        {"Smithsonian Astrophysical Observation", "SAO 93576"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.14934567),
        dec: Angle.Degrees(+11.13765689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60943"},
        {"Fundamental Katalog 5th Edition", "FK5 5101"},
        {"Geneva Identification System", "GEN# +0.01102467"},
        {"Smithsonian Astrophysical Observation", "SAO 100125"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.36778905),
        dec: Angle.Degrees(+11.13888147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93695"},
    },
    visualMagnitude: 10.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.19780201),
        dec: Angle.Degrees(+11.13955162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -212.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14843"},
        {"Smithsonian Astrophysical Observation", "SAO 93330"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.92778711),
        dec: Angle.Degrees(+11.14201322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63314"},
        {"Hipparcos Number", "HIP 38119"},
        {"Smithsonian Astrophysical Observation", "SAO 97265"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.17463716),
        dec: Angle.Degrees(+11.14298155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165145"},
        {"Hipparcos Number", "HIP 88494"},
        {"Fundamental Katalog 5th Edition", "FK5 5591"},
        {"Smithsonian Astrophysical Observation", "SAO 103346"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.04417506),
        dec: Angle.Degrees(+11.14319245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17771",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2778 A"},
        {"Henry Draper", "HD 23793"},
        {"Hipparcos Number", "HIP 17771"},
        {"Geneva Identification System", "GEN# +1.00023793J"},
        {"Smithsonian Astrophysical Observation", "SAO 93611"},
        {"Wilson Evans Batten Catalogue", "WEB 3404"},
    },
    visualMagnitude: 5.08,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.06771677),
        dec: Angle.Degrees(+11.14336637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23952"},
        {"Hipparcos Number", "HIP 17873"},
        {"Geneva Identification System", "GEN# +1.00023952"},
        {"Smithsonian Astrophysical Observation", "SAO 93622"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.36258297),
        dec: Angle.Degrees(+11.14444867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161502"},
        {"Hipparcos Number", "HIP 86906"},
        {"Geneva Identification System", "GEN# +1.00161502"},
        {"Smithsonian Astrophysical Observation", "SAO 103079"},
        {"Wilson Evans Batten Catalogue", "WEB 14660"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.36351950),
        dec: Angle.Degrees(+11.14468478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67962"},
        {"Smithsonian Astrophysical Observation", "SAO 100769"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.76830393),
        dec: Angle.Degrees(+11.14470233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 813",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 122 A"},
        {"Henry Draper", "HD 560"},
        {"Hipparcos Number", "HIP 813"},
        {"Geneva Identification System", "GEN# +1.00000560A"},
        {"Smithsonian Astrophysical Observation", "SAO 91750"},
        {"Wilson Evans Batten Catalogue", "WEB 137"},
    },
    visualMagnitude: 5.54,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.50910252),
        dec: Angle.Degrees(+11.14580908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30034"},
        {"Hipparcos Number", "HIP 22044"},
        {"Celescope Catalog", "CEL 460"},
        {"Geneva Identification System", "GEN# +5.20250111"},
        {"Smithsonian Astrophysical Observation", "SAO 94095"},
        {"Wilson Evans Batten Catalogue", "WEB 4237"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.10737323),
        dec: Angle.Degrees(+11.14616933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7013"},
        {"Hipparcos Number", "HIP 5513"},
        {"Smithsonian Astrophysical Observation", "SAO 92295"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.64691520),
        dec: Angle.Degrees(+11.14743201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96416",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12660 AB"},
        {"Henry Draper", "HD 184884"},
        {"Hipparcos Number", "HIP 96416"},
        {"Smithsonian Astrophysical Observation", "SAO 105032"},
        {"Wilson Evans Batten Catalogue", "WEB 16914"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.03349500),
        dec: Angle.Degrees(+11.15017937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139391"},
        {"Hipparcos Number", "HIP 76512"},
        {"Geneva Identification System", "GEN# +1.00139391"},
        {"Smithsonian Astrophysical Observation", "SAO 101653"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.39191042),
        dec: Angle.Degrees(+11.15122695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5383 AB"},
        {"Henry Draper", "HD 262677"},
        {"Hipparcos Number", "HIP 32220"},
        {"Wilson Evans Batten Catalogue", "WEB 6497"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.89086726),
        dec: Angle.Degrees(+11.15134932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29022"},
        {"Wilson Evans Batten Catalogue", "WEB 5682"},
    },
    visualMagnitude: 11.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.85610396),
        dec: Angle.Degrees(+11.15197329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77624"},
        {"Hipparcos Number", "HIP 44497"},
        {"Smithsonian Astrophysical Observation", "SAO 98332"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.99087646),
        dec: Angle.Degrees(+11.15296516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43756"},
        {"Wilson Evans Batten Catalogue", "WEB 8418"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.69809344),
        dec: Angle.Degrees(+11.15611648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43138",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6995 A"},
        {"Henry Draper", "HD 74926"},
        {"Hipparcos Number", "HIP 43138"},
        {"Geneva Identification System", "GEN# +1.00074926"},
        {"Smithsonian Astrophysical Observation", "SAO 98120"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.79586326),
        dec: Angle.Degrees(+11.15953047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153835"},
        {"Hipparcos Number", "HIP 83299"},
        {"Smithsonian Astrophysical Observation", "SAO 102533"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.36266630),
        dec: Angle.Degrees(+11.16042574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43137",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6995 B"},
        {"Hipparcos Number", "HIP 43137"},
        {"Smithsonian Astrophysical Observation", "SAO 98119"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.79547118),
        dec: Angle.Degrees(+11.16298713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173983"},
        {"Hipparcos Number", "HIP 92236"},
        {"Smithsonian Astrophysical Observation", "SAO 104109"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.97294087),
        dec: Angle.Degrees(+11.16356863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29994",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4918 AB"},
        {"Henry Draper", "HD 43841"},
        {"Hipparcos Number", "HIP 29994"},
        {"Celescope Catalog", "CEL 1166"},
        {"Geneva Identification System", "GEN# +1.00043841J"},
        {"Smithsonian Astrophysical Observation", "SAO 95516"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.70612835),
        dec: Angle.Degrees(+11.16508386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63856"},
        {"Hipparcos Number", "HIP 38362"},
        {"Geneva Identification System", "GEN# +1.00063856"},
        {"Smithsonian Astrophysical Observation", "SAO 97314"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.85466988),
        dec: Angle.Degrees(+11.16569782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286996"},
        {"Hipparcos Number", "HIP 21983"},
        {"Geneva Identification System", "GEN# +6.20030455"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.88201528),
        dec: Angle.Degrees(+11.16665272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97036"},
        {"Hipparcos Number", "HIP 54596"},
        {"Smithsonian Astrophysical Observation", "SAO 99478"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.60423539),
        dec: Angle.Degrees(+11.16689544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52236"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.07672353),
        dec: Angle.Degrees(+11.16708925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174371"},
        {"Hipparcos Number", "HIP 92401"},
        {"Smithsonian Astrophysical Observation", "SAO 104155"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.45211494),
        dec: Angle.Degrees(+11.16755329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107987"},
        {"Hipparcos Number", "HIP 60527"},
        {"Smithsonian Astrophysical Observation", "SAO 100084"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.11813253),
        dec: Angle.Degrees(+11.16806733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91150"},
        {"Hipparcos Number", "HIP 51532"},
        {"Smithsonian Astrophysical Observation", "SAO 99167"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.88542471),
        dec: Angle.Degrees(+11.16819121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85633"},
        {"Hipparcos Number", "HIP 48490"},
        {"Smithsonian Astrophysical Observation", "SAO 98825"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.33767089),
        dec: Angle.Degrees(+11.17081307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26598"},
        {"Hipparcos Number", "HIP 19663"},
        {"Fundamental Katalog 5th Edition", "FK5 4383"},
        {"Geneva Identification System", "GEN# +1.00026598"},
        {"Smithsonian Astrophysical Observation", "SAO 93815"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.19535130),
        dec: Angle.Degrees(+11.17139598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183888"},
        {"Hipparcos Number", "HIP 96017"},
        {"Smithsonian Astrophysical Observation", "SAO 104926"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.84153359),
        dec: Angle.Degrees(+11.17151555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 388"},
        {"Hipparcos Number", "HIP 694"},
        {"Smithsonian Astrophysical Observation", "SAO 91729"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.13130944),
        dec: Angle.Degrees(+11.17153688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156822"},
        {"Hipparcos Number", "HIP 84736"},
        {"Geneva Identification System", "GEN# +1.00156822"},
        {"Smithsonian Astrophysical Observation", "SAO 102738"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.82153153),
        dec: Angle.Degrees(+11.17238849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223462"},
        {"Hipparcos Number", "HIP 117506"},
        {"Smithsonian Astrophysical Observation", "SAO 108856"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.42888957),
        dec: Angle.Degrees(+11.17423172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37589"},
        {"Hipparcos Number", "HIP 26669"},
        {"Smithsonian Astrophysical Observation", "SAO 94740"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.01925464),
        dec: Angle.Degrees(+11.17560678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207381"},
        {"Hipparcos Number", "HIP 107647"},
        {"Smithsonian Astrophysical Observation", "SAO 107403"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.05912196),
        dec: Angle.Degrees(+11.17771523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87668"},
        {"Hipparcos Number", "HIP 49527"},
        {"Smithsonian Astrophysical Observation", "SAO 98951"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.68383557),
        dec: Angle.Degrees(+11.17813108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5971"},
        {"Hipparcos Number", "HIP 4765"},
        {"Geneva Identification System", "GEN# +1.00005971"},
        {"Smithsonian Astrophysical Observation", "SAO 92204"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.30801420),
        dec: Angle.Degrees(+11.18051570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221683"},
        {"Hipparcos Number", "HIP 116325"},
        {"Geneva Identification System", "GEN# +1.00221683"},
        {"Smithsonian Astrophysical Observation", "SAO 108679"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.53994387),
        dec: Angle.Degrees(+11.18083466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68198"},
        {"Hipparcos Number", "HIP 40123"},
        {"Smithsonian Astrophysical Observation", "SAO 97642"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.93634353),
        dec: Angle.Degrees(+11.18345702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23612"},
        {"Hipparcos Number", "HIP 17643"},
        {"Geneva Identification System", "GEN# +1.00023612"},
        {"Smithsonian Astrophysical Observation", "SAO 93594"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.70704371),
        dec: Angle.Degrees(+11.18423789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93329"},
        {"Hipparcos Number", "HIP 52707"},
        {"Fundamental Katalog 5th Edition", "FK5 4956"},
        {"Geneva Identification System", "GEN# +1.00093329"},
        {"Smithsonian Astrophysical Observation", "SAO 99285"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.65276332),
        dec: Angle.Degrees(+11.18445577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68439"},
        {"Hipparcos Number", "HIP 40214"},
        {"Smithsonian Astrophysical Observation", "SAO 97652"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.20054393),
        dec: Angle.Degrees(+11.18468104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205810"},
        {"Hipparcos Number", "HIP 106760"},
        {"Geneva Identification System", "GEN# +1.00205810"},
        {"Smithsonian Astrophysical Observation", "SAO 107282"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.39213153),
        dec: Angle.Degrees(+11.18690043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100717"},
        {"Hipparcos Number", "HIP 56535"},
        {"Fundamental Katalog 5th Edition", "FK5 5022"},
        {"Smithsonian Astrophysical Observation", "SAO 99681"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.88281872),
        dec: Angle.Degrees(+11.18867920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286664"},
        {"Hipparcos Number", "HIP 19974"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.25168056),
        dec: Angle.Degrees(+11.18985858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13072"},
        {"Hipparcos Number", "HIP 9952"},
        {"Fundamental Katalog 5th Edition", "FK5 4195"},
        {"Smithsonian Astrophysical Observation", "SAO 92804"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.03016006),
        dec: Angle.Degrees(+11.19047079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68425"},
        {"Hipparcos Number", "HIP 40197"},
        {"Smithsonian Astrophysical Observation", "SAO 97650"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.16040810),
        dec: Angle.Degrees(+11.19112278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112354"},
        {"Geneva Identification System", "GEN# +0.01004812J"},
        {"Wilson Evans Batten Catalogue", "WEB 20043"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.36608798),
        dec: Angle.Degrees(+11.19234059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101441"},
        {"Hipparcos Number", "HIP 56947"},
        {"Geneva Identification System", "GEN# +1.00101441"},
        {"Smithsonian Astrophysical Observation", "SAO 99725"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.11916547),
        dec: Angle.Degrees(+11.19516803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170673"},
        {"Hipparcos Number", "HIP 90696"},
        {"Smithsonian Astrophysical Observation", "SAO 103786"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.56750299),
        dec: Angle.Degrees(+11.19640006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220302"},
        {"Hipparcos Number", "HIP 115408"},
        {"Smithsonian Astrophysical Observation", "SAO 108572"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.67099425),
        dec: Angle.Degrees(+11.19810021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215550"},
        {"Hipparcos Number", "HIP 112395"},
        {"Fundamental Katalog 5th Edition", "FK5 6006"},
        {"Geneva Identification System", "GEN# +1.00215550"},
        {"Smithsonian Astrophysical Observation", "SAO 108159"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.47487963),
        dec: Angle.Degrees(+11.20036175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177832"},
        {"Hipparcos Number", "HIP 93778"},
        {"Geneva Identification System", "GEN# +1.00177832"},
        {"Smithsonian Astrophysical Observation", "SAO 104469"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.47342672),
        dec: Angle.Degrees(+11.20071680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36577"},
        {"Hipparcos Number", "HIP 26028"},
        {"Geneva Identification System", "GEN# +1.00036577"},
        {"Smithsonian Astrophysical Observation", "SAO 94645"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.29516210),
        dec: Angle.Degrees(+11.20229142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59603"},
        {"Hipparcos Number", "HIP 36553"},
        {"Smithsonian Astrophysical Observation", "SAO 96973"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.78664351),
        dec: Angle.Degrees(+11.20301302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202951"},
        {"Hipparcos Number", "HIP 105224"},
        {"Fundamental Katalog 5th Edition", "FK5 3700"},
        {"Geneva Identification System", "GEN# +1.00202951"},
        {"Smithsonian Astrophysical Observation", "SAO 107020"},
        {"Wilson Evans Batten Catalogue", "WEB 19111"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.71672173),
        dec: Angle.Degrees(+11.20333527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244591"},
        {"Hipparcos Number", "HIP 25917"},
        {"Smithsonian Astrophysical Observation", "SAO 94622"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.96916217),
        dec: Angle.Degrees(+11.20419795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1419"},
        {"Hipparcos Number", "HIP 1465"},
        {"Geneva Identification System", "GEN# +1.00001419"},
        {"Smithsonian Astrophysical Observation", "SAO 91832"},
        {"Wilson Evans Batten Catalogue", "WEB 270"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.57193855),
        dec: Angle.Degrees(+11.20628336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197941"},
        {"Hipparcos Number", "HIP 102510"},
        {"Smithsonian Astrophysical Observation", "SAO 106471"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.62001198),
        dec: Angle.Degrees(+11.20712255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128527"},
        {"Hipparcos Number", "HIP 71476"},
        {"Smithsonian Astrophysical Observation", "SAO 101107"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.26421155),
        dec: Angle.Degrees(+11.20835645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170077"},
        {"Hipparcos Number", "HIP 90439"},
        {"Smithsonian Astrophysical Observation", "SAO 103725"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.79049603),
        dec: Angle.Degrees(+11.20931596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229830"},
        {"Hipparcos Number", "HIP 92638"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.12278607),
        dec: Angle.Degrees(+11.21069539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119335"},
        {"Hipparcos Number", "HIP 66898"},
        {"Geneva Identification System", "GEN# +1.00119335"},
        {"Smithsonian Astrophysical Observation", "SAO 100671"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.64098505),
        dec: Angle.Degrees(+11.21153356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202072"},
        {"Hipparcos Number", "HIP 104759"},
        {"Geneva Identification System", "GEN# +1.00202072"},
        {"Smithsonian Astrophysical Observation", "SAO 106928"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.34311749),
        dec: Angle.Degrees(+11.21156166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105618"},
        {"Hipparcos Number", "HIP 59278"},
        {"Geneva Identification System", "GEN# +1.00105618"},
        {"Smithsonian Astrophysical Observation", "SAO 99967"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.40284641),
        dec: Angle.Degrees(+11.21158255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3228 AB"},
        {"Henry Draper", "HD 28217"},
        {"Hipparcos Number", "HIP 20804"},
        {"Celescope Catalog", "CEL 402"},
        {"Geneva Identification System", "GEN# +1.00028217J"},
        {"Renson", "Renson 7190"},
        {"Smithsonian Astrophysical Observation", "SAO 93943"},
        {"Wilson Evans Batten Catalogue", "WEB 3992"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.86987518),
        dec: Angle.Degrees(+11.21233208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115367"},
        {"Smithsonian Astrophysical Observation", "SAO 108567"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.54030566),
        dec: Angle.Degrees(+11.21355439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173292"},
        {"Hipparcos Number", "HIP 91904"},
        {"Geneva Identification System", "GEN# +1.00173292"},
        {"Smithsonian Astrophysical Observation", "SAO 104039"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.03814675),
        dec: Angle.Degrees(+11.21530697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46627"},
        {"Smithsonian Astrophysical Observation", "SAO 98612"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.62925347),
        dec: Angle.Degrees(+11.21678170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54622"},
        {"Smithsonian Astrophysical Observation", "SAO 99483"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.69703701),
        dec: Angle.Degrees(+11.21884444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55421"},
        {"Smithsonian Astrophysical Observation", "SAO 99568"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.24119156),
        dec: Angle.Degrees(+11.21918873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114705"},
        {"Hipparcos Number", "HIP 64412"},
        {"Smithsonian Astrophysical Observation", "SAO 100455"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.02105616),
        dec: Angle.Degrees(+11.22049982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53538"},
        {"Hipparcos Number", "HIP 34231"},
        {"Smithsonian Astrophysical Observation", "SAO 96481"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.45101452),
        dec: Angle.Degrees(+11.22409477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113496"},
        {"Hipparcos Number", "HIP 63752"},
        {"Geneva Identification System", "GEN# +1.00113496"},
        {"Smithsonian Astrophysical Observation", "SAO 100398"},
        {"Wilson Evans Batten Catalogue", "WEB 11277"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.99904903),
        dec: Angle.Degrees(+11.23072803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68068"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.04708086),
        dec: Angle.Degrees(+11.23168216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65371"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.97238741),
        dec: Angle.Degrees(+11.23219353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -355.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44985"},
        {"Hipparcos Number", "HIP 30552"},
        {"Geneva Identification System", "GEN# +1.00044985"},
        {"Smithsonian Astrophysical Observation", "SAO 95656"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.33465718),
        dec: Angle.Degrees(+11.23338336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48654"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.83110643),
        dec: Angle.Degrees(+11.23523006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79989"},
        {"Smithsonian Astrophysical Observation", "SAO 102088"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.91923325),
        dec: Angle.Degrees(+11.23605202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50845"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.73906646),
        dec: Angle.Degrees(+11.23831932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152328"},
        {"Hipparcos Number", "HIP 82544"},
        {"Smithsonian Astrophysical Observation", "SAO 102438"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.08240559),
        dec: Angle.Degrees(+11.24196194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160766"},
        {"Hipparcos Number", "HIP 86556"},
        {"Smithsonian Astrophysical Observation", "SAO 103021"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.32532594),
        dec: Angle.Degrees(+11.24239333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31400"},
        {"Hipparcos Number", "HIP 22927"},
        {"Celescope Catalog", "CEL 492"},
        {"Geneva Identification System", "GEN# +1.00031400"},
        {"Smithsonian Astrophysical Observation", "SAO 94215"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.01251514),
        dec: Angle.Degrees(+11.24287567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171765"},
        {"Hipparcos Number", "HIP 91191"},
        {"Smithsonian Astrophysical Observation", "SAO 103891"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.04804898),
        dec: Angle.Degrees(+11.24322383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286854"},
        {"Hipparcos Number", "HIP 21091"},
        {"Smithsonian Astrophysical Observation", "SAO 93985"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.79603294),
        dec: Angle.Degrees(+11.24438411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54186"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.26904046),
        dec: Angle.Degrees(+11.24671910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70386",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9251 AB"},
        {"Henry Draper", "HD 126246"},
        {"Hipparcos Number", "HIP 70386"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.02385386),
        dec: Angle.Degrees(+11.24696692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93505"},
        {"Geneva Identification System", "GEN# +0.01103707"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.64844148),
        dec: Angle.Degrees(+11.24909526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196885"},
        {"Henry Draper 2", "HD 196885A"},
        {"Hipparcos Number", "HIP 101966"},
        {"Geneva Identification System", "GEN# +1.00196885"},
        {"Smithsonian Astrophysical Observation", "SAO 106360"},
        {"Wilson Evans Batten Catalogue", "WEB 18432"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.96603077),
        dec: Angle.Degrees(+11.24944743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5153 A"},
        {"Henry Draper", "HD 45995"},
        {"Hipparcos Number", "HIP 31066"},
        {"Geneva Identification System", "GEN# +1.00045995A"},
        {"Geneva Identification System 2", "GEN# +1.00045995J"},
        {"Smithsonian Astrophysical Observation", "SAO 95766"},
        {"Wilson Evans Batten Catalogue", "WEB 6185"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.78983509),
        dec: Angle.Degrees(+11.25138166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131363"},
        {"Hipparcos Number", "HIP 72798"},
        {"Geneva Identification System", "GEN# +1.00131363"},
        {"Smithsonian Astrophysical Observation", "SAO 101268"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.20347632),
        dec: Angle.Degrees(+11.25189176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118791"},
        {"Hipparcos Number", "HIP 66583"},
        {"Geneva Identification System", "GEN# +1.00118791"},
        {"Smithsonian Astrophysical Observation", "SAO 100648"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.73342472),
        dec: Angle.Degrees(+11.25207427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194671"},
        {"Hipparcos Number", "HIP 100828"},
        {"Smithsonian Astrophysical Observation", "SAO 106102"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.66105884),
        dec: Angle.Degrees(+11.25260062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58171"},
        {"Smithsonian Astrophysical Observation", "SAO 99872"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.95406347),
        dec: Angle.Degrees(+11.25355373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41470"},
        {"Fundamental Katalog 5th Edition", "FK5 4760"},
        {"Smithsonian Astrophysical Observation", "SAO 97825"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.88113438),
        dec: Angle.Degrees(+11.25376446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120003",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5153 B"},
        {"Henry Draper", "HD 258782"},
        {"Henry Draper 2", "HD 45995B"},
        {"Hipparcos Number", "HIP 120003"},
        {"Geneva Identification System", "GEN# +1.00045995B"},
        {"Geneva Identification System 2", "GEN# +1.00258782"},
        {"Renson", "Renson 12310"},
        {"Smithsonian Astrophysical Observation", "SAO 95767"},
    },
    visualMagnitude: 9.10,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.79010831),
        dec: Angle.Degrees(+11.25585692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44853"},
        {"Hipparcos Number", "HIP 30492"},
        {"Smithsonian Astrophysical Observation", "SAO 95637"},
        {"Wilson Evans Batten Catalogue", "WEB 6070"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.14082621),
        dec: Angle.Degrees(+11.25650691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192026"},
        {"Hipparcos Number", "HIP 99575"},
        {"Smithsonian Astrophysical Observation", "SAO 105831"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.11171898),
        dec: Angle.Degrees(+11.25768726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101233",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13946 BC"},
        {"Henry Draper", "HD 195482"},
        {"Hipparcos Number", "HIP 101233"},
        {"Geneva Identification System", "GEN# +1.00195482"},
        {"Renson", "Renson 54470"},
        {"Smithsonian Astrophysical Observation", "SAO 106195"},
        {"Wilson Evans Batten Catalogue", "WEB 18288"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.79974933),
        dec: Angle.Degrees(+11.25936569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101235",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13946 A"},
        {"Henry Draper", "HD 195483"},
        {"Hipparcos Number", "HIP 101235"},
        {"Celescope Catalog", "CEL 5092"},
        {"Geneva Identification System", "GEN# +1.00195483"},
        {"Smithsonian Astrophysical Observation", "SAO 106196"},
        {"Wilson Evans Batten Catalogue", "WEB 18289"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.80445003),
        dec: Angle.Degrees(+11.26062772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71830"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.40451772),
        dec: Angle.Degrees(+11.26210456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74329"},
        {"Hipparcos Number", "HIP 42839"},
        {"Geneva Identification System", "GEN# +1.00074329"},
        {"Smithsonian Astrophysical Observation", "SAO 98074"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.93271804),
        dec: Angle.Degrees(+11.26230170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206315"},
        {"Hipparcos Number", "HIP 107062"},
        {"Smithsonian Astrophysical Observation", "SAO 107321"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.25589694),
        dec: Angle.Degrees(+11.26332697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287212"},
        {"Hipparcos Number", "HIP 22708"},
        {"Smithsonian Astrophysical Observation", "SAO 94182"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.24665553),
        dec: Angle.Degrees(+11.26396236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 326"},
        {"Smithsonian Astrophysical Observation", "SAO 91685"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.04484023),
        dec: Angle.Degrees(+11.26438632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286941"},
        {"Hipparcos Number", "HIP 21684"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.82287056),
        dec: Angle.Degrees(+11.26521327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139087"},
        {"Hipparcos Number", "HIP 76372"},
        {"Fundamental Katalog 5th Edition", "FK5 3231"},
        {"Geneva Identification System", "GEN# +1.00139087"},
        {"Smithsonian Astrophysical Observation", "SAO 101634"},
        {"Wilson Evans Batten Catalogue", "WEB 12963"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.97244766),
        dec: Angle.Degrees(+11.26568451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140667"},
        {"Hipparcos Number", "HIP 77098"},
        {"Geneva Identification System", "GEN# +1.00140667"},
        {"Smithsonian Astrophysical Observation", "SAO 101709"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.13305244),
        dec: Angle.Degrees(+11.26657723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287211"},
        {"Hipparcos Number", "HIP 22712"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.25439657),
        dec: Angle.Degrees(+11.26751333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72429"},
        {"Hipparcos Number", "HIP 41951"},
        {"Geneva Identification System", "GEN# +1.00072429"},
        {"Smithsonian Astrophysical Observation", "SAO 97905"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.27089595),
        dec: Angle.Degrees(+11.26824329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19983"},
        {"Hipparcos Number", "HIP 14977"},
        {"Geneva Identification System", "GEN# +1.00019983"},
        {"Smithsonian Astrophysical Observation", "SAO 93341"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.26335793),
        dec: Angle.Degrees(+11.26864842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177725"},
        {"Hipparcos Number", "HIP 93753"},
        {"Geneva Identification System", "GEN# +1.00177725"},
        {"Smithsonian Astrophysical Observation", "SAO 104462"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.37382226),
        dec: Angle.Degrees(+11.26982945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45990"},
        {"Geneva Identification System", "GEN# +0.01102021"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.69615118),
        dec: Angle.Degrees(+11.27152944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -313.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 134.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96481",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12670 A"},
        {"Henry Draper", "HD 185018"},
        {"Hipparcos Number", "HIP 96481"},
        {"Geneva Identification System", "GEN# +1.00185018"},
        {"Smithsonian Astrophysical Observation", "SAO 105045"},
        {"Wilson Evans Batten Catalogue", "WEB 16929"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.21852927),
        dec: Angle.Degrees(+11.27319815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224674"},
        {"Hipparcos Number", "HIP 118309"},
        {"Smithsonian Astrophysical Observation", "SAO 108948"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.94922017),
        dec: Angle.Degrees(+11.27342446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64027"},
        {"Geneva Identification System", "GEN# +0.01202555"},
        {"Smithsonian Astrophysical Observation", "SAO 100420"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.80943983),
        dec: Angle.Degrees(+11.27844030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200373"},
        {"Hipparcos Number", "HIP 103869"},
        {"Geneva Identification System", "GEN# +1.00200373"},
        {"Smithsonian Astrophysical Observation", "SAO 106790"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.69778234),
        dec: Angle.Degrees(+11.28010058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115607"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.28975108),
        dec: Angle.Degrees(+11.28192834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122834"},
        {"Hipparcos Number", "HIP 68708"},
        {"Smithsonian Astrophysical Observation", "SAO 100834"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.98741878),
        dec: Angle.Degrees(+11.28252950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110825",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15946 A"},
        {"Henry Draper", "HD 212860"},
        {"Hipparcos Number", "HIP 110825"},
        {"Smithsonian Astrophysical Observation", "SAO 107922"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.78234186),
        dec: Angle.Degrees(+11.28288773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89209"},
        {"Hipparcos Number", "HIP 50424"},
        {"Smithsonian Astrophysical Observation", "SAO 99041"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.44003411),
        dec: Angle.Degrees(+11.28361394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72780"},
        {"Hipparcos Number", "HIP 42112"},
        {"Geneva Identification System", "GEN# +1.00072780"},
        {"Smithsonian Astrophysical Observation", "SAO 97927"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.76762683),
        dec: Angle.Degrees(+11.28384641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164615"},
        {"Hipparcos Number", "HIP 88272"},
        {"Geneva Identification System", "GEN# +1.00164615"},
        {"Smithsonian Astrophysical Observation", "SAO 103308"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.38829959),
        dec: Angle.Degrees(+11.28575629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7849",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1321 AB"},
        {"Henry Draper", "HD 10297"},
        {"Hipparcos Number", "HIP 7849"},
        {"Smithsonian Astrophysical Observation", "SAO 92572"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.22626008),
        dec: Angle.Degrees(+11.28709690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217130"},
        {"Hipparcos Number", "HIP 113427"},
        {"Smithsonian Astrophysical Observation", "SAO 108299"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.58411860),
        dec: Angle.Degrees(+11.28729927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94251"},
        {"Hipparcos Number", "HIP 53200"},
        {"Geneva Identification System", "GEN# +1.00094251"},
        {"Smithsonian Astrophysical Observation", "SAO 99337"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.21049122),
        dec: Angle.Degrees(+11.28758129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66517"},
        {"Geneva Identification System", "GEN# +0.01202610"},
        {"Smithsonian Astrophysical Observation", "SAO 100643"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.51983066),
        dec: Angle.Degrees(+11.29036202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65292"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.72405876),
        dec: Angle.Degrees(+11.29131335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59255",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8438 A"},
        {"Henry Draper", "HD 105568"},
        {"Hipparcos Number", "HIP 59255"},
        {"Geneva Identification System", "GEN# +1.00105568"},
        {"Smithsonian Astrophysical Observation", "SAO 99964"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.32078811),
        dec: Angle.Degrees(+11.29180038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106026"},
        {"Hipparcos Number", "HIP 59480"},
        {"Geneva Identification System", "GEN# +1.00106026"},
        {"Smithsonian Astrophysical Observation", "SAO 99982"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.99480875),
        dec: Angle.Degrees(+11.29215691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178637"},
        {"Hipparcos Number", "HIP 94064"},
        {"Geneva Identification System", "GEN# +1.00178637"},
        {"Smithsonian Astrophysical Observation", "SAO 104526"},
        {"Wilson Evans Batten Catalogue", "WEB 16377"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.24171832),
        dec: Angle.Degrees(+11.29358511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257971"},
        {"Hipparcos Number", "HIP 30841"},
        {"Geneva Identification System", "GEN# +1.00257971"},
        {"Smithsonian Astrophysical Observation", "SAO 95726"},
        {"Wilson Evans Batten Catalogue", "WEB 6148"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.16396819),
        dec: Angle.Degrees(+11.29708646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82395"},
        {"Hipparcos Number", "HIP 46771"},
        {"Fundamental Katalog 5th Edition", "FK5 1246"},
        {"Geneva Identification System", "GEN# +1.00082395"},
        {"Smithsonian Astrophysical Observation", "SAO 98627"},
        {"Wilson Evans Batten Catalogue", "WEB 8822"},
    },
    visualMagnitude: 4.99,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.98663458),
        dec: Angle.Degrees(+11.30003070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109439"},
        {"Hipparcos Number", "HIP 61374"},
        {"Geneva Identification System", "GEN# +1.00109439"},
        {"Smithsonian Astrophysical Observation", "SAO 100153"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.65743652),
        dec: Angle.Degrees(+11.30099869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152447"},
        {"Hipparcos Number", "HIP 82586"},
        {"Smithsonian Astrophysical Observation", "SAO 102448"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.23896861),
        dec: Angle.Degrees(+11.30104701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34189"},
        {"Smithsonian Astrophysical Observation", "SAO 96470"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.34457397),
        dec: Angle.Degrees(+11.30128423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286442"},
        {"Hipparcos Number", "HIP 18825"},
        {"Smithsonian Astrophysical Observation", "SAO 93730"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.51446168),
        dec: Angle.Degrees(+11.30151428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97068"},
        {"Hipparcos Number", "HIP 54613"},
        {"Smithsonian Astrophysical Observation", "SAO 99480"},
        {"Wilson Evans Batten Catalogue", "WEB 9850"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.65326491),
        dec: Angle.Degrees(+11.30165557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128199"},
        {"Hipparcos Number", "HIP 71338"},
        {"Smithsonian Astrophysical Observation", "SAO 101092"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.83762741),
        dec: Angle.Degrees(+11.30171888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154465"},
        {"Hipparcos Number", "HIP 83596"},
        {"Smithsonian Astrophysical Observation", "SAO 102582"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.28584031),
        dec: Angle.Degrees(+11.30179475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101421",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Aldulfin"},
        {"Henry Draper", "HD 195810"},
        {"Hipparcos Number", "HIP 101421"},
        {"Celescope Catalog", "CEL 5102"},
        {"Fundamental Katalog 5th Edition", "FK5 768"},
        {"Geneva Identification System", "GEN# +1.00195810"},
        {"Smithsonian Astrophysical Observation", "SAO 106230"},
        {"Wilson Evans Batten Catalogue", "WEB 18323"},
    },
    visualMagnitude: 4.03,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.30318657),
        dec: Angle.Degrees(+11.30333217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24621"},
        {"Hipparcos Number", "HIP 18335"},
        {"Smithsonian Astrophysical Observation", "SAO 93673"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.80110279),
        dec: Angle.Degrees(+11.30448297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189337"},
        {"Hipparcos Number", "HIP 98377"},
        {"Fundamental Katalog 5th Edition", "FK5 5761"},
        {"Geneva Identification System", "GEN# +9.00051002"},
        {"Smithsonian Astrophysical Observation", "SAO 105505"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.80021132),
        dec: Angle.Degrees(+11.30556446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286770"},
        {"Hipparcos Number", "HIP 20419"},
        {"Geneva Identification System", "GEN# +5.20253259"},
        {"Geneva Identification System 2", "GEN# +5.20257177"},
        {"Geneva Identification System 3", "GEN# +5.20252033"},
        {"Wilson Evans Batten Catalogue", "WEB 3902"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.60675535),
        dec: Angle.Degrees(+11.30573062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17821"},
        {"Hipparcos Number", "HIP 13364"},
        {"Geneva Identification System", "GEN# +1.00017821"},
        {"Smithsonian Astrophysical Observation", "SAO 93150"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.99099642),
        dec: Angle.Degrees(+11.30668828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160035"},
        {"Hipparcos Number", "HIP 86235"},
        {"Geneva Identification System", "GEN# +1.00160035"},
        {"Smithsonian Astrophysical Observation", "SAO 102973"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.34284206),
        dec: Angle.Degrees(+11.30693223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18052"},
        {"Hipparcos Number", "HIP 13538"},
        {"Geneva Identification System", "GEN# +1.00018052"},
        {"Smithsonian Astrophysical Observation", "SAO 93175"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.58684217),
        dec: Angle.Degrees(+11.30954775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15668"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.46348940),
        dec: Angle.Degrees(+11.30963302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196038"},
        {"Hipparcos Number", "HIP 101522"},
        {"Smithsonian Astrophysical Observation", "SAO 106260"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.60962073),
        dec: Angle.Degrees(+11.31100609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89813"},
        {"Hipparcos Number", "HIP 50782"},
        {"Cincinnati Publication", "Ci 18 1249"},
        {"Geneva Identification System", "GEN# +1.00089813"},
        {"Smithsonian Astrophysical Observation", "SAO 99084"},
        {"Wilson Evans Batten Catalogue", "WEB 9296"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.53947544),
        dec: Angle.Degrees(+11.31103013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -324.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112140"},
        {"Hipparcos Number", "HIP 62974"},
        {"Geneva Identification System", "GEN# +1.00112140"},
        {"Smithsonian Astrophysical Observation", "SAO 100327"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.55650713),
        dec: Angle.Degrees(+11.31211462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159778"},
        {"Hipparcos Number", "HIP 86123"},
        {"Smithsonian Astrophysical Observation", "SAO 102953"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.01751955),
        dec: Angle.Degrees(+11.31259765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6424"},
        {"Hipparcos Number", "HIP 5086"},
        {"Geneva Identification System", "GEN# +1.00006424"},
        {"Smithsonian Astrophysical Observation", "SAO 92234"},
        {"Wilson Evans Batten Catalogue", "WEB 1048"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.29000406),
        dec: Angle.Degrees(+11.31591199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90512"},
        {"Hipparcos Number", "HIP 51179"},
        {"Geneva Identification System", "GEN# +1.00090512"},
        {"Smithsonian Astrophysical Observation", "SAO 99132"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.80106035),
        dec: Angle.Degrees(+11.31705592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 392 AB"},
        {"Henry Draper", "HD 2523"},
        {"Hipparcos Number", "HIP 2280"},
        {"Renson", "Renson 600"},
        {"Smithsonian Astrophysical Observation", "SAO 91918"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.28583471),
        dec: Angle.Degrees(+11.32015120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55461"},
        {"Geneva Identification System", "GEN# +6.20001040"},
    },
    visualMagnitude: 11.13,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.37227756),
        dec: Angle.Degrees(+11.32141109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245409"},
        {"Hipparcos Number", "HIP 26335"},
        {"Geneva Identification System", "GEN# +1.00245409"},
        {"Smithsonian Astrophysical Observation", "SAO 94695"},
        {"Wilson Evans Batten Catalogue", "WEB 5189"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.12913389),
        dec: Angle.Degrees(+11.32800602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68256"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.60132384),
        dec: Angle.Degrees(+11.32867908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147529"},
        {"Hipparcos Number", "HIP 80183"},
        {"Smithsonian Astrophysical Observation", "SAO 102109"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.54524686),
        dec: Angle.Degrees(+11.32982975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64607",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8832 A"},
        {"Henry Draper", "HD 115046"},
        {"Hipparcos Number", "HIP 64607"},
        {"Geneva Identification System", "GEN# +1.00115046J"},
        {"Smithsonian Astrophysical Observation", "SAO 100473"},
        {"Wilson Evans Batten Catalogue", "WEB 11427"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.63017874),
        dec: Angle.Degrees(+11.33178469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125194"},
        {"Hipparcos Number", "HIP 69841"},
        {"Fundamental Katalog 5th Edition", "FK5 5263"},
        {"Smithsonian Astrophysical Observation", "SAO 100958"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.40374760),
        dec: Angle.Degrees(+11.33525330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52525"},
        {"Smithsonian Astrophysical Observation", "SAO 99271"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.08997561),
        dec: Angle.Degrees(+11.33559953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104941"},
        {"Hipparcos Number", "HIP 58932"},
        {"Smithsonian Astrophysical Observation", "SAO 99931"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.25347048),
        dec: Angle.Degrees(+11.33620910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21686"},
        {"Hipparcos Number", "HIP 16322"},
        {"Geneva Identification System", "GEN# +1.00021686"},
        {"Smithsonian Astrophysical Observation", "SAO 93463"},
        {"Wilson Evans Batten Catalogue", "WEB 3118"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.60198294),
        dec: Angle.Degrees(+11.33648129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14920"},
        {"Hipparcos Number", "HIP 11242"},
        {"Smithsonian Astrophysical Observation", "SAO 92929"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.17472339),
        dec: Angle.Degrees(+11.33880022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109083"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46357574),
        dec: Angle.Degrees(+11.34031576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153796"},
        {"Hipparcos Number", "HIP 83271"},
        {"Geneva Identification System", "GEN# +1.00153796"},
        {"Smithsonian Astrophysical Observation", "SAO 102531"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.28053362),
        dec: Angle.Degrees(+11.34088521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34203"},
        {"Hipparcos Number", "HIP 24555"},
        {"Fundamental Katalog 5th Edition", "FK5 2395"},
        {"Geneva Identification System", "GEN# +1.00034203"},
        {"Smithsonian Astrophysical Observation", "SAO 94426"},
        {"Wilson Evans Batten Catalogue", "WEB 4756"},
    },
    visualMagnitude: 5.52,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.01724675),
        dec: Angle.Degrees(+11.34136954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83526"},
        {"Smithsonian Astrophysical Observation", "SAO 102572"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.05508833),
        dec: Angle.Degrees(+11.34483188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179758"},
        {"Hipparcos Number", "HIP 94452"},
        {"Geneva Identification System", "GEN# +1.00179758"},
        {"Smithsonian Astrophysical Observation", "SAO 104619"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.35083158),
        dec: Angle.Degrees(+11.34499029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105784",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14958 AB"},
        {"Henry Draper", "HD 204011"},
        {"Hipparcos Number", "HIP 105784"},
        {"Smithsonian Astrophysical Observation", "SAO 107122"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.36219579),
        dec: Angle.Degrees(+11.34610025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66302"},
        {"Hipparcos Number", "HIP 39404"},
        {"Geneva Identification System", "GEN# +1.00066302"},
        {"Smithsonian Astrophysical Observation", "SAO 97511"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.83459927),
        dec: Angle.Degrees(+11.34873575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217036"},
        {"Hipparcos Number", "HIP 113375"},
        {"Smithsonian Astrophysical Observation", "SAO 108290"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.42248714),
        dec: Angle.Degrees(+11.34964211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69365"},
        {"Hipparcos Number", "HIP 40580"},
        {"Geneva Identification System", "GEN# +1.00069365"},
        {"Smithsonian Astrophysical Observation", "SAO 97705"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.28064654),
        dec: Angle.Degrees(+11.35126958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71086"},
        {"Geneva Identification System", "GEN# +0.01102687"},
        {"Wilson Evans Batten Catalogue", "WEB 12293"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.05465730),
        dec: Angle.Degrees(+11.35263340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89574"},
        {"Hipparcos Number", "HIP 50623"},
        {"Smithsonian Astrophysical Observation", "SAO 99074"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.11020386),
        dec: Angle.Degrees(+11.35284011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111871"},
        {"Geneva Identification System", "GEN# +0.01004791"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.89921467),
        dec: Angle.Degrees(+11.35331778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172010"},
        {"Hipparcos Number", "HIP 91297"},
        {"Smithsonian Astrophysical Observation", "SAO 103918"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.33555482),
        dec: Angle.Degrees(+11.35583605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196201"},
        {"Hipparcos Number", "HIP 101597"},
        {"Cincinnati Publication", "Ci 18 2669"},
        {"Geneva Identification System", "GEN# +1.00196201"},
        {"Smithsonian Astrophysical Observation", "SAO 106276"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.85908133),
        dec: Angle.Degrees(+11.35622337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 372.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94133"},
        {"Hipparcos Number", "HIP 53115"},
        {"Smithsonian Astrophysical Observation", "SAO 99330"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.99647772),
        dec: Angle.Degrees(+11.35723762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13935"},
        {"Hipparcos Number", "HIP 10549"},
        {"Smithsonian Astrophysical Observation", "SAO 92862"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.96978367),
        dec: Angle.Degrees(+11.35963809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33673"},
        {"Hipparcos Number", "HIP 24249"},
        {"Geneva Identification System", "GEN# +1.00033673"},
        {"Smithsonian Astrophysical Observation", "SAO 94390"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.08490936),
        dec: Angle.Degrees(+11.36293577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286444"},
        {"Hipparcos Number", "HIP 18890"},
        {"Smithsonian Astrophysical Observation", "SAO 93737"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.74486470),
        dec: Angle.Degrees(+11.36609258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9565"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.72063869),
        dec: Angle.Degrees(+11.36625323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8356"},
        {"Hipparcos Number", "HIP 6451"},
        {"Smithsonian Astrophysical Observation", "SAO 92407"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.72323497),
        dec: Angle.Degrees(+11.36661822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66272"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.74035799),
        dec: Angle.Degrees(+11.36691357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159674"},
        {"Hipparcos Number", "HIP 86085"},
        {"Smithsonian Astrophysical Observation", "SAO 102944"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.88591357),
        dec: Angle.Degrees(+11.36729717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8816"},
        {"Hipparcos Number", "HIP 6764"},
        {"Smithsonian Astrophysical Observation", "SAO 92447"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.75662312),
        dec: Angle.Degrees(+11.36733301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99577"},
    },
    visualMagnitude: 10.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.12597249),
        dec: Angle.Degrees(+11.37066230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57386",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8295 A"},
        {"Hipparcos Number", "HIP 57386"},
        {"Smithsonian Astrophysical Observation", "SAO 99781"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.48136345),
        dec: Angle.Degrees(+11.37090042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17820"},
        {"Hipparcos Number", "HIP 13366"},
        {"Cincinnati Publication", "Ci 20 189"},
        {"Cincinnati Publication 2", "Ci 18 369"},
        {"Geneva Identification System", "GEN# +1.00017820"},
        {"Smithsonian Astrophysical Observation", "SAO 93151"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.99305490),
        dec: Angle.Degrees(+11.37105887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -444.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209347"},
        {"Hipparcos Number", "HIP 108806"},
        {"Smithsonian Astrophysical Observation", "SAO 107608"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.62772260),
        dec: Angle.Degrees(+11.37114465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192025"},
        {"Hipparcos Number", "HIP 99578"},
        {"Smithsonian Astrophysical Observation", "SAO 105834"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.13175724),
        dec: Angle.Degrees(+11.37151106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12504"},
        {"Hipparcos Number", "HIP 9561"},
        {"Smithsonian Astrophysical Observation", "SAO 92767"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.71424840),
        dec: Angle.Degrees(+11.37228349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116627"},
        {"Smithsonian Astrophysical Observation", "SAO 108736"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.51584680),
        dec: Angle.Degrees(+11.37270686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123880"},
        {"Hipparcos Number", "HIP 69194"},
        {"Smithsonian Astrophysical Observation", "SAO 100886"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.48641340),
        dec: Angle.Degrees(+11.37331591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204844"},
        {"Hipparcos Number", "HIP 106232"},
        {"Smithsonian Astrophysical Observation", "SAO 107192"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.75817014),
        dec: Angle.Degrees(+11.37385431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32202"},
        {"Hipparcos Number", "HIP 23404"},
        {"Celescope Catalog", "CEL 511"},
        {"Geneva Identification System", "GEN# +1.00032202A"},
        {"Smithsonian Astrophysical Observation", "SAO 94274"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.44859762),
        dec: Angle.Degrees(+11.37531445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196544"},
        {"Hipparcos Number", "HIP 101800"},
        {"Geneva Identification System", "GEN# +1.00196544"},
        {"Renson", "Renson 54820"},
        {"Smithsonian Astrophysical Observation", "SAO 106322"},
        {"Wilson Evans Batten Catalogue", "WEB 18392"},
    },
    visualMagnitude: 5.42,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.45456696),
        dec: Angle.Degrees(+11.37769664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20472",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3174 AB"},
        {"Henry Draper", "HD 27762"},
        {"Hipparcos Number", "HIP 20472"},
        {"Smithsonian Astrophysical Observation", "SAO 93899"},
    },
    visualMagnitude: 6.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.82013476),
        dec: Angle.Degrees(+11.37800731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111069"},
        {"Hipparcos Number", "HIP 62350"},
        {"Geneva Identification System", "GEN# +1.00111069"},
        {"Smithsonian Astrophysical Observation", "SAO 100250"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.64271027),
        dec: Angle.Degrees(+11.37849924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82489"},
        {"Hipparcos Number", "HIP 46837"},
        {"Smithsonian Astrophysical Observation", "SAO 98632"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.16955741),
        dec: Angle.Degrees(+11.37870002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70884"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.43851836),
        dec: Angle.Degrees(+11.37935027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85776"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.91155811),
        dec: Angle.Degrees(+11.38023237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6730"},
    },
    visualMagnitude: 11.68,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.67106638),
        dec: Angle.Degrees(+11.38213069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287412"},
        {"Henry Draper 2", "HD 32202B"},
        {"Hipparcos Number", "HIP 23406"},
        {"Renson", "Renson 8197"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.45309470),
        dec: Angle.Degrees(+11.38318423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102066"},
        {"Hipparcos Number", "HIP 57292"},
        {"Smithsonian Astrophysical Observation", "SAO 99765"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.21152574),
        dec: Angle.Degrees(+11.38588279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209459"},
        {"Hipparcos Number", "HIP 108875"},
        {"Geneva Identification System", "GEN# +1.00209459"},
        {"Renson", "Renson 58280"},
        {"Smithsonian Astrophysical Observation", "SAO 107625"},
        {"Wilson Evans Batten Catalogue", "WEB 19583"},
    },
    visualMagnitude: 5.83,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.82925888),
        dec: Angle.Degrees(+11.38655605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21664"},
        {"Hipparcos Number", "HIP 16296"},
        {"Smithsonian Astrophysical Observation", "SAO 93458"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.52477106),
        dec: Angle.Degrees(+11.38755782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75827"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.34997363),
        dec: Angle.Degrees(+11.38884441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85463",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10562 A"},
        {"Henry Draper", "HD 158263"},
        {"Hipparcos Number", "HIP 85463"},
        {"Geneva Identification System", "GEN# +1.00158263"},
        {"Smithsonian Astrophysical Observation", "SAO 102835"},
        {"Wilson Evans Batten Catalogue", "WEB 14434"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.96775031),
        dec: Angle.Degrees(+11.39049574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16193",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2561 A"},
        {"Henry Draper", "HD 21524"},
        {"Hipparcos Number", "HIP 16193"},
        {"Geneva Identification System", "GEN# +1.00021524"},
        {"Smithsonian Astrophysical Observation", "SAO 93448"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.15143511),
        dec: Angle.Degrees(+11.39060714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210812"},
        {"Hipparcos Number", "HIP 109658"},
        {"Smithsonian Astrophysical Observation", "SAO 107738"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.21771899),
        dec: Angle.Degrees(+11.39135805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85460",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10562 B"},
        {"Henry Draper", "HD 158262"},
        {"Hipparcos Number", "HIP 85460"},
        {"Geneva Identification System", "GEN# +1.00158262"},
        {"Smithsonian Astrophysical Observation", "SAO 102833"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.96019300),
        dec: Angle.Degrees(+11.39206830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168201"},
        {"Hipparcos Number", "HIP 89688"},
        {"Smithsonian Astrophysical Observation", "SAO 103580"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.55036479),
        dec: Angle.Degrees(+11.39626217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22254"},
        {"Hipparcos Number", "HIP 16738"},
        {"Geneva Identification System", "GEN# +1.00022254"},
        {"Smithsonian Astrophysical Observation", "SAO 93502"},
        {"Wilson Evans Batten Catalogue", "WEB 3187"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.82987121),
        dec: Angle.Degrees(+11.39675766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116620"},
        {"Hipparcos Number", "HIP 65437"},
        {"Geneva Identification System", "GEN# +1.00116620"},
        {"Smithsonian Astrophysical Observation", "SAO 100557"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.16954388),
        dec: Angle.Degrees(+11.39694995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81175"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.70800442),
        dec: Angle.Degrees(+11.40096561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214266"},
        {"Hipparcos Number", "HIP 111635"},
        {"Smithsonian Astrophysical Observation", "SAO 108040"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.22990448),
        dec: Angle.Degrees(+11.40152787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14333 AB"},
        {"Hipparcos Number", "HIP 102782"},
        {"Geneva Identification System", "GEN# +0.01004385J"},
        {"Smithsonian Astrophysical Observation", "SAO 106532"},
        {"Wilson Evans Batten Catalogue", "WEB 18639"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.34803992),
        dec: Angle.Degrees(+11.40265688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11637"},
        {"Hipparcos Number", "HIP 8888"},
        {"Smithsonian Astrophysical Observation", "SAO 92689"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.60233177),
        dec: Angle.Degrees(+11.40266054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102784",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14333 C"},
        {"Hipparcos Number", "HIP 102784"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.35217649),
        dec: Angle.Degrees(+11.40393543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12721"},
        {"Hipparcos Number", "HIP 9709"},
        {"Smithsonian Astrophysical Observation", "SAO 92781"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.22264798),
        dec: Angle.Degrees(+11.40503519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61493",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8606 AB"},
        {"Henry Draper", "HD 109628"},
        {"Hipparcos Number", "HIP 61493"},
        {"Cincinnati Publication", "Ci 18 1593"},
        {"Geneva Identification System", "GEN# +1.00109628"},
        {"Smithsonian Astrophysical Observation", "SAO 100165"},
        {"Wilson Evans Batten Catalogue", "WEB 10945"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.99099825),
        dec: Angle.Degrees(+11.40560629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -301.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38117"},
        {"Hipparcos Number", "HIP 27020"},
        {"Smithsonian Astrophysical Observation", "SAO 94811"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.96284770),
        dec: Angle.Degrees(+11.40568727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148228"},
        {"Hipparcos Number", "HIP 80514"},
        {"Geneva Identification System", "GEN# +1.00148228"},
        {"Smithsonian Astrophysical Observation", "SAO 102165"},
        {"Wilson Evans Batten Catalogue", "WEB 13623"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.54756086),
        dec: Angle.Degrees(+11.40746123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43387"},
        {"Smithsonian Astrophysical Observation", "SAO 98156"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.57757962),
        dec: Angle.Degrees(+11.40785983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29207"},
        {"Hipparcos Number", "HIP 21446"},
        {"Celescope Catalog", "CEL 439"},
        {"Geneva Identification System", "GEN# +1.00029207"},
        {"Smithsonian Astrophysical Observation", "SAO 94030"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.08172039),
        dec: Angle.Degrees(+11.41251870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223232"},
        {"Hipparcos Number", "HIP 117356"},
        {"Smithsonian Astrophysical Observation", "SAO 108838"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.92922929),
        dec: Angle.Degrees(+11.41257813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98252",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13168 A"},
        {"Henry Draper", "HD 189093"},
        {"Hipparcos Number", "HIP 98252"},
        {"Smithsonian Astrophysical Observation", "SAO 105474"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.48393828),
        dec: Angle.Degrees(+11.41471341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 530"},
        {"Hipparcos Number", "HIP 797"},
        {"Geneva Identification System", "GEN# +1.00000530"},
        {"Smithsonian Astrophysical Observation", "SAO 91748"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.46570707),
        dec: Angle.Degrees(+11.41627112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112516"},
        {"Hipparcos Number", "HIP 63215"},
        {"Smithsonian Astrophysical Observation", "SAO 100343"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.28804685),
        dec: Angle.Degrees(+11.41642061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51249"},
    },
    visualMagnitude: 11.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.02080379),
        dec: Angle.Degrees(+11.41665652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243119"},
        {"Hipparcos Number", "HIP 25155"},
        {"Smithsonian Astrophysical Observation", "SAO 94506"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.74837297),
        dec: Angle.Degrees(+11.41752361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145977"},
        {"Hipparcos Number", "HIP 79504"},
        {"Smithsonian Astrophysical Observation", "SAO 102019"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.35811292),
        dec: Angle.Degrees(+11.41803570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81708"},
        {"Hipparcos Number", "HIP 46398"},
        {"Smithsonian Astrophysical Observation", "SAO 98583"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.92082043),
        dec: Angle.Degrees(+11.41872533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74910"},
        {"Hipparcos Number", "HIP 43130"},
        {"Smithsonian Astrophysical Observation", "SAO 98118"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.78259376),
        dec: Angle.Degrees(+11.41970271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79699",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79699"},
    },
    visualMagnitude: 10.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.98252572),
        dec: Angle.Degrees(+11.42013779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171975"},
        {"Hipparcos Number", "HIP 91286"},
        {"Geneva Identification System", "GEN# +1.00171975"},
        {"Smithsonian Astrophysical Observation", "SAO 103912"},
        {"Wilson Evans Batten Catalogue", "WEB 15687"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.30260865),
        dec: Angle.Degrees(+11.42152504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84637"},
        {"Smithsonian Astrophysical Observation", "SAO 102723"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.53286849),
        dec: Angle.Degrees(+11.42162878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140666"},
        {"Hipparcos Number", "HIP 77103"},
        {"Smithsonian Astrophysical Observation", "SAO 101711"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.15233518),
        dec: Angle.Degrees(+11.42212056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87056"},
        {"Fundamental Katalog 5th Edition", "FK5 5561"},
        {"Smithsonian Astrophysical Observation", "SAO 103108"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.84273408),
        dec: Angle.Degrees(+11.42354762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188728"},
        {"Hipparcos Number", "HIP 98103"},
        {"Fundamental Katalog 5th Edition", "FK5 3590"},
        {"Geneva Identification System", "GEN# +1.00188728"},
        {"Renson", "Renson 52170"},
        {"Smithsonian Astrophysical Observation", "SAO 105438"},
        {"Wilson Evans Batten Catalogue", "WEB 17289"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.05930285),
        dec: Angle.Degrees(+11.42370978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184592"},
        {"Hipparcos Number", "HIP 96308"},
        {"Geneva Identification System", "GEN# +1.00184592"},
        {"Smithsonian Astrophysical Observation", "SAO 104996"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.73104734),
        dec: Angle.Degrees(+11.42408265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 279.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147886"},
        {"Hipparcos Number", "HIP 80347"},
        {"Smithsonian Astrophysical Observation", "SAO 102133"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.03442285),
        dec: Angle.Degrees(+11.42491008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146452"},
        {"Hipparcos Number", "HIP 79704"},
        {"Smithsonian Astrophysical Observation", "SAO 102046"},
        {"Wilson Evans Batten Catalogue", "WEB 13489"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.99950288),
        dec: Angle.Degrees(+11.42515915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31283"},
        {"Hipparcos Number", "HIP 22833"},
        {"Celescope Catalog", "CEL 484"},
        {"Fundamental Katalog 5th Edition", "FK5 2368"},
        {"Geneva Identification System", "GEN# +1.00031283"},
        {"Smithsonian Astrophysical Observation", "SAO 94197"},
        {"Wilson Evans Batten Catalogue", "WEB 4420"},
    },
    visualMagnitude: 5.18,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.69544409),
        dec: Angle.Degrees(+11.42597336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25540"},
        {"Geneva Identification System", "GEN# +0.01100809"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.90972454),
        dec: Angle.Degrees(+11.42748381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
