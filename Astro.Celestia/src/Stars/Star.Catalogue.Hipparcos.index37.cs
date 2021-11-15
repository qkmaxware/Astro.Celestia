using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_37() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51936",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7852 AB"},
        {"Henry Draper", "HD 91955"},
        {"Hipparcos Number", "HIP 51936"},
        {"Smithsonian Astrophysical Observation", "SAO 179025"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.14750829),
        dec: Angle.Degrees(-28.77183677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6979"},
        {"Hipparcos Number", "HIP 5456"},
        {"Smithsonian Astrophysical Observation", "SAO 166844"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.45958065),
        dec: Angle.Degrees(-28.77078565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197172"},
        {"Hipparcos Number", "HIP 102241"},
        {"Smithsonian Astrophysical Observation", "SAO 189601"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.76013713),
        dec: Angle.Degrees(-28.77008172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102311"},
        {"Hipparcos Number", "HIP 57441"},
        {"Smithsonian Astrophysical Observation", "SAO 180178"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.62927000),
        dec: Angle.Degrees(-28.77004573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121672"},
        {"Hipparcos Number", "HIP 68176"},
        {"Geneva Identification System", "GEN# +1.00121672"},
        {"Smithsonian Astrophysical Observation", "SAO 182121"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.35857333),
        dec: Angle.Degrees(-28.77002895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72294",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9381 AB"},
        {"Henry Draper", "HD 130116"},
        {"Hipparcos Number", "HIP 72294"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.76220043),
        dec: Angle.Degrees(-28.76704748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27965"},
        {"Hipparcos Number", "HIP 20509"},
        {"Geneva Identification System", "GEN# +1.00027965"},
        {"Smithsonian Astrophysical Observation", "SAO 169408"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.92857824),
        dec: Angle.Degrees(-28.76651053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82363"},
        {"Hipparcos Number", "HIP 46646"},
        {"Smithsonian Astrophysical Observation", "SAO 177582"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.66781929),
        dec: Angle.Degrees(-28.76640423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110848"},
        {"Hipparcos Number", "HIP 62232"},
        {"Smithsonian Astrophysical Observation", "SAO 181075"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.31835456),
        dec: Angle.Degrees(-28.76602411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207892"},
        {"Hipparcos Number", "HIP 108009"},
        {"Smithsonian Astrophysical Observation", "SAO 190705"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.23350932),
        dec: Angle.Degrees(-28.76575351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202773"},
        {"Hipparcos Number", "HIP 105228"},
        {"Geneva Identification System", "GEN# +1.00202773"},
        {"Smithsonian Astrophysical Observation", "SAO 190220"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.72633611),
        dec: Angle.Degrees(-28.76565847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110088"},
        {"Hipparcos Number", "HIP 61790"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.97049962),
        dec: Angle.Degrees(-28.76227887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196999"},
        {"Hipparcos Number", "HIP 102134"},
        {"Geneva Identification System", "GEN# +1.00196999"},
        {"Smithsonian Astrophysical Observation", "SAO 189583"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.44451432),
        dec: Angle.Degrees(-28.76190183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64265"},
        {"Hipparcos Number", "HIP 38398"},
        {"Smithsonian Astrophysical Observation", "SAO 174694"},
    },
    visualMagnitude: 12.03,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)51, 59.8600),
        dec: Angle.DegreesMinutesSeconds((int)-28, (int)45, 39.500)
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
    primaryId: "HIP 116625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222127"},
        {"Hipparcos Number", "HIP 116625"},
        {"Smithsonian Astrophysical Observation", "SAO 192045"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.51418387),
        dec: Angle.Degrees(-28.76027139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163685"},
        {"Hipparcos Number", "HIP 88012"},
        {"Geneva Identification System", "GEN# +1.00163685"},
        {"Smithsonian Astrophysical Observation", "SAO 186025"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.66270935),
        dec: Angle.Degrees(-28.75907603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47719"},
        {"Hipparcos Number", "HIP 31786"},
        {"Smithsonian Astrophysical Observation", "SAO 172084"},
    },
    visualMagnitude: 9.52,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.69605678),
        dec: Angle.Degrees(-28.75637879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45003",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7223 AB"},
        {"Aitken 2", "ADS 7223"},
        {"Henry Draper", "HD 78921"},
        {"Hipparcos Number", "HIP 45003"},
        {"Smithsonian Astrophysical Observation", "SAO 177059"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.48852636),
        dec: Angle.Degrees(-28.75555518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169761"},
        {"Hipparcos Number", "HIP 90455"},
        {"Smithsonian Astrophysical Observation", "SAO 186831"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.86539383),
        dec: Angle.Degrees(-28.75520139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86437"},
        {"Hipparcos Number", "HIP 48857"},
        {"Smithsonian Astrophysical Observation", "SAO 178240"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.48286258),
        dec: Angle.Degrees(-28.75406575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175793"},
        {"Hipparcos Number", "HIP 93123"},
        {"Smithsonian Astrophysical Observation", "SAO 187511"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.55805753),
        dec: Angle.Degrees(-28.75254946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24514"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.88015791),
        dec: Angle.Degrees(-28.75068585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2949"},
        {"Hipparcos Number", "HIP 2561"},
        {"Smithsonian Astrophysical Observation", "SAO 166342"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.13967203),
        dec: Angle.Degrees(-28.74977463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22505"},
        {"Hipparcos Number", "HIP 16798"},
        {"Smithsonian Astrophysical Observation", "SAO 168672"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.05246679),
        dec: Angle.Degrees(-28.74892755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160682"},
        {"Hipparcos Number", "HIP 86672"},
        {"Geneva Identification System", "GEN# +1.00160682"},
        {"Smithsonian Astrophysical Observation", "SAO 185635"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.62648724),
        dec: Angle.Degrees(-28.74867778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214462"},
        {"Hipparcos Number", "HIP 111801"},
        {"Geneva Identification System", "GEN# +1.00214462"},
        {"Smithsonian Astrophysical Observation", "SAO 191292"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.68626016),
        dec: Angle.Degrees(-28.74818538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55019"},
        {"Hipparcos Number", "HIP 34601"},
        {"Celescope Catalog", "CEL 1637"},
        {"Geneva Identification System", "GEN# +1.00055019"},
        {"Smithsonian Astrophysical Observation", "SAO 173116"},
        {"Wilson Evans Batten Catalogue", "WEB 6923"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.50216812),
        dec: Angle.Degrees(-28.74818457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121157"},
        {"Hipparcos Number", "HIP 67888"},
        {"Smithsonian Astrophysical Observation", "SAO 182064"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.56704507),
        dec: Angle.Degrees(-28.74314580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181481"},
        {"Hipparcos Number", "HIP 95182"},
        {"Smithsonian Astrophysical Observation", "SAO 188016"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.44542593),
        dec: Angle.Degrees(-28.74260830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141756"},
        {"Hipparcos Number", "HIP 77698"},
        {"Smithsonian Astrophysical Observation", "SAO 183868"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.95704207),
        dec: Angle.Degrees(-28.74242718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89749"},
        {"Hipparcos Number", "HIP 50681"},
        {"Geneva Identification System", "GEN# +1.00089749"},
        {"Smithsonian Astrophysical Observation", "SAO 178710"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.23988440),
        dec: Angle.Degrees(-28.74125598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219794"},
        {"Hipparcos Number", "HIP 115110"},
        {"Geneva Identification System", "GEN# +1.00219794"},
        {"Renson", "Renson 60330"},
        {"Smithsonian Astrophysical Observation", "SAO 191814"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.72322477),
        dec: Angle.Degrees(-28.74087151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178251"},
        {"Hipparcos Number", "HIP 94059"},
        {"Smithsonian Astrophysical Observation", "SAO 187731"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.23429149),
        dec: Angle.Degrees(-28.74084721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29656"},
        {"Smithsonian Astrophysical Observation", "SAO 171457"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.72728991),
        dec: Angle.Degrees(-28.74072431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212981"},
        {"Hipparcos Number", "HIP 110944"},
        {"Smithsonian Astrophysical Observation", "SAO 191167"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.17531289),
        dec: Angle.Degrees(-28.73945409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61430"},
        {"Hipparcos Number", "HIP 37154"},
        {"Geneva Identification System", "GEN# +1.00061430"},
        {"Smithsonian Astrophysical Observation", "SAO 174172"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.53376973),
        dec: Angle.Degrees(-28.73903301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98688"},
        {"Hipparcos Number", "HIP 55431"},
        {"Geneva Identification System", "GEN# +1.00098688"},
        {"Smithsonian Astrophysical Observation", "SAO 179795"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.27922718),
        dec: Angle.Degrees(-28.73889286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64420"},
        {"Hipparcos Number", "HIP 38467"},
        {"Geneva Identification System", "GEN# +1.00064420"},
        {"Smithsonian Astrophysical Observation", "SAO 174720"},
    },
    visualMagnitude: 9.81,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.19164526),
        dec: Angle.Degrees(-28.73795696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221804"},
        {"Hipparcos Number", "HIP 116408"},
        {"Geneva Identification System", "GEN# +1.00221804"},
        {"Smithsonian Astrophysical Observation", "SAO 192016"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.84014117),
        dec: Angle.Degrees(-28.73658015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137475"},
        {"Hipparcos Number", "HIP 75640"},
        {"Smithsonian Astrophysical Observation", "SAO 183480"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.81164249),
        dec: Angle.Degrees(-28.73616839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38540"},
        {"Geneva Identification System", "GEN# -0.02805034J"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.38642764),
        dec: Angle.Degrees(-28.73531841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60196"},
        {"Hipparcos Number", "HIP 36646"},
        {"Celescope Catalog", "CEL 1915"},
        {"Geneva Identification System", "GEN# +1.00060196"},
        {"Smithsonian Astrophysical Observation", "SAO 173957"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.04952543),
        dec: Angle.Degrees(-28.73437064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65865"},
        {"Hipparcos Number", "HIP 39086"},
        {"Geneva Identification System", "GEN# +5.30440187"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.94269435),
        dec: Angle.Degrees(-28.73419645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7931"},
        {"Hipparcos Number", "HIP 6116"},
        {"Geneva Identification System", "GEN# +1.00007931"},
        {"Smithsonian Astrophysical Observation", "SAO 166944"},
        {"Wilson Evans Batten Catalogue", "WEB 1374"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.63416160),
        dec: Angle.Degrees(-28.73296728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219897"},
        {"Hipparcos Number", "HIP 115166"},
        {"Geneva Identification System", "GEN# +1.00219897"},
        {"Smithsonian Astrophysical Observation", "SAO 191823"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.91763371),
        dec: Angle.Degrees(-28.73151747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111787"},
        {"Hipparcos Number", "HIP 62796"},
        {"Smithsonian Astrophysical Observation", "SAO 181171"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.01833800),
        dec: Angle.Degrees(-28.73019138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18979"},
        {"Hipparcos Number", "HIP 14127"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.55344519),
        dec: Angle.Degrees(-28.72980289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73227"},
        {"Smithsonian Astrophysical Observation", "SAO 183049"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.48855284),
        dec: Angle.Degrees(-28.72840326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213075"},
        {"Hipparcos Number", "HIP 111013"},
        {"Geneva Identification System", "GEN# +1.00213075"},
        {"Smithsonian Astrophysical Observation", "SAO 191177"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.35345182),
        dec: Angle.Degrees(-28.72778955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49959"},
        {"Hipparcos Number", "HIP 32751"},
        {"Smithsonian Astrophysical Observation", "SAO 172397"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.44737413),
        dec: Angle.Degrees(-28.72776548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96441"},
        {"Hipparcos Number", "HIP 54311"},
        {"Geneva Identification System", "GEN# +1.00096441"},
        {"Smithsonian Astrophysical Observation", "SAO 179542"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.66199429),
        dec: Angle.Degrees(-28.72751926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10778"},
        {"Hipparcos Number", "HIP 8160"},
        {"Smithsonian Astrophysical Observation", "SAO 167265"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.23991784),
        dec: Angle.Degrees(-28.72636081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95773"},
        {"Hipparcos Number", "HIP 54004"},
        {"Smithsonian Astrophysical Observation", "SAO 179465"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.71783837),
        dec: Angle.Degrees(-28.72517375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206868"},
        {"Hipparcos Number", "HIP 107431"},
        {"Fundamental Katalog 5th Edition", "FK5 5919"},
        {"Geneva Identification System", "GEN# +1.00206868"},
        {"Smithsonian Astrophysical Observation", "SAO 190605"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.38932819),
        dec: Angle.Degrees(-28.72467877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30733"},
        {"Hipparcos Number", "HIP 22373"},
        {"Geneva Identification System", "GEN# +1.00030733"},
        {"Smithsonian Astrophysical Observation", "SAO 169790"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.24169902),
        dec: Angle.Degrees(-28.72410154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128341"},
        {"Hipparcos Number", "HIP 71471"},
        {"Geneva Identification System", "GEN# +1.00128341"},
        {"Smithsonian Astrophysical Observation", "SAO 182703"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.25622024),
        dec: Angle.Degrees(-28.72181101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63704"},
        {"Hipparcos Number", "HIP 38154"},
        {"Geneva Identification System", "GEN# +1.00063704"},
        {"Smithsonian Astrophysical Observation", "SAO 174598"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.28189923),
        dec: Angle.Degrees(-28.72155206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114383"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.49122809),
        dec: Angle.Degrees(-28.72023541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76856"},
        {"Hipparcos Number", "HIP 44026"},
        {"Smithsonian Astrophysical Observation", "SAO 176749"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.48386439),
        dec: Angle.Degrees(-28.71854757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146974"},
        {"Hipparcos Number", "HIP 80036"},
        {"Smithsonian Astrophysical Observation", "SAO 184320"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.06468404),
        dec: Angle.Degrees(-28.71685163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104982"},
        {"Hipparcos Number", "HIP 58950"},
        {"Cincinnati Publication", "Ci 20 680"},
        {"Geneva Identification System", "GEN# +1.00104982"},
        {"Smithsonian Astrophysical Observation", "SAO 180442"},
        {"Wilson Evans Batten Catalogue", "WEB 10495"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.30530872),
        dec: Angle.Degrees(-28.71623167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -411.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141444"},
        {"Hipparcos Number", "HIP 77569"},
        {"Geneva Identification System", "GEN# +1.00141444"},
        {"Smithsonian Astrophysical Observation", "SAO 183841"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.54779452),
        dec: Angle.Degrees(-28.70431194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60775",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8555 AB"},
        {"Henry Draper", "HD 108410"},
        {"Hipparcos Number", "HIP 60775"},
        {"Smithsonian Astrophysical Observation", "SAO 180809"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.86010013),
        dec: Angle.Degrees(-28.71622354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133500"},
        {"Hipparcos Number", "HIP 73857"},
        {"Smithsonian Astrophysical Observation", "SAO 183160"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.41779297),
        dec: Angle.Degrees(-28.71480500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176367"},
        {"Hipparcos Number", "HIP 93375"},
        {"Geneva Identification System", "GEN# +1.00176367"},
        {"Smithsonian Astrophysical Observation", "SAO 187573"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.27516483),
        dec: Angle.Degrees(-28.71377583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196275"},
        {"Hipparcos Number", "HIP 101738"},
        {"Smithsonian Astrophysical Observation", "SAO 189492"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.31461518),
        dec: Angle.Degrees(-28.71313120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60463"},
        {"Hipparcos Number", "HIP 36738"},
        {"Celescope Catalog", "CEL 1925"},
        {"Smithsonian Astrophysical Observation", "SAO 173998"},
    },
    visualMagnitude: 8.77,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.35036315),
        dec: Angle.Degrees(-28.71046256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132173"},
        {"Hipparcos Number", "HIP 73269"},
        {"Geneva Identification System", "GEN# +1.00132173"},
        {"Smithsonian Astrophysical Observation", "SAO 183057"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.62745965),
        dec: Angle.Degrees(-28.70930607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111881"},
        {"Hipparcos Number", "HIP 62841"},
        {"Smithsonian Astrophysical Observation", "SAO 181184"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.16983513),
        dec: Angle.Degrees(-28.70897249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37286"},
        {"Hipparcos Number", "HIP 26309"},
        {"Geneva Identification System", "GEN# +1.00037286"},
        {"Renson", "Renson 9990"},
        {"Smithsonian Astrophysical Observation", "SAO 170587"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.04282744),
        dec: Angle.Degrees(-28.70800575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22447"},
        {"Hipparcos Number", "HIP 16765"},
        {"Smithsonian Astrophysical Observation", "SAO 168664"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.93331416),
        dec: Angle.Degrees(-28.70781780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5523 AB"},
        {"Henry Draper", "HD 50216"},
        {"Hipparcos Number", "HIP 32869"},
        {"Smithsonian Astrophysical Observation", "SAO 172434"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.74434274),
        dec: Angle.Degrees(-28.70736757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222321"},
        {"Hipparcos Number", "HIP 116747"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.91492885),
        dec: Angle.Degrees(-28.70724548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168467"},
        {"Hipparcos Number", "HIP 89929"},
        {"Smithsonian Astrophysical Observation", "SAO 186683"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.24461952),
        dec: Angle.Degrees(-28.70712189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155686"},
        {"Hipparcos Number", "HIP 84322"},
        {"Geneva Identification System", "GEN# +1.00155686"},
        {"Smithsonian Astrophysical Observation", "SAO 185179"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.57406073),
        dec: Angle.Degrees(-28.70677306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47390"},
        {"Hipparcos Number", "HIP 31621"},
        {"Smithsonian Astrophysical Observation", "SAO 172037"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.26388017),
        dec: Angle.Degrees(-28.70613004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209740"},
        {"Hipparcos Number", "HIP 109128"},
        {"Geneva Identification System", "GEN# +1.00209740"},
        {"Smithsonian Astrophysical Observation", "SAO 190888"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.56048445),
        dec: Angle.Degrees(-28.70448118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95356",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12376 A"},
        {"Henry Draper", "HD 182047"},
        {"Hipparcos Number", "HIP 95356"},
        {"Smithsonian Astrophysical Observation", "SAO 188065"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.99479745),
        dec: Angle.Degrees(-28.70391819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175025"},
        {"Hipparcos Number", "HIP 92805"},
        {"Smithsonian Astrophysical Observation", "SAO 187432"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.64746717),
        dec: Angle.Degrees(-28.70374825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110651"},
        {"Hipparcos Number", "HIP 62114"},
        {"Smithsonian Astrophysical Observation", "SAO 181059"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.95392181),
        dec: Angle.Degrees(-28.70229078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16195"},
        {"Hipparcos Number", "HIP 12036"},
        {"Smithsonian Astrophysical Observation", "SAO 167893"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.79552679),
        dec: Angle.Degrees(-28.69761836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5626 AB"},
        {"Henry Draper", "HD 51633"},
        {"Hipparcos Number", "HIP 33411"},
        {"Smithsonian Astrophysical Observation", "SAO 172622"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.22928636),
        dec: Angle.Degrees(-28.69687142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191521"},
        {"Hipparcos Number", "HIP 99489"},
        {"Smithsonian Astrophysical Observation", "SAO 188999"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.86149488),
        dec: Angle.Degrees(-28.69475461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117716"},
        {"Hipparcos Number", "HIP 66065"},
        {"Fundamental Katalog 5th Edition", "FK5 3080"},
        {"Geneva Identification System", "GEN# +1.00117716"},
        {"Smithsonian Astrophysical Observation", "SAO 181737"},
        {"Wilson Evans Batten Catalogue", "WEB 11674"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.14984195),
        dec: Angle.Degrees(-28.69271440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118415"},
        {"Hipparcos Number", "HIP 66445"},
        {"Smithsonian Astrophysical Observation", "SAO 181799"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.31559571),
        dec: Angle.Degrees(-28.69241134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166924"},
        {"Hipparcos Number", "HIP 89356"},
        {"Smithsonian Astrophysical Observation", "SAO 186501"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.50984990),
        dec: Angle.Degrees(-28.69087715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26152"},
        {"Hipparcos Number", "HIP 19228"},
        {"Smithsonian Astrophysical Observation", "SAO 169141"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.82761830),
        dec: Angle.Degrees(-28.69004406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37495"},
        {"Hipparcos Number", "HIP 26460"},
        {"Geneva Identification System", "GEN# +1.00037495"},
        {"Smithsonian Astrophysical Observation", "SAO 170613"},
        {"Wilson Evans Batten Catalogue", "WEB 5215"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.43601282),
        dec: Angle.Degrees(-28.68979391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90935"},
    },
    visualMagnitude: 11.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.25338267),
        dec: Angle.Degrees(-28.68973746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71928"},
        {"Hipparcos Number", "HIP 41617"},
        {"Geneva Identification System", "GEN# +1.00071928"},
        {"Smithsonian Astrophysical Observation", "SAO 175924"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.27051589),
        dec: Angle.Degrees(-28.68935846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18690"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.06017662),
        dec: Angle.Degrees(-28.68759523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88589",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11041 AB"},
        {"Henry Draper", "HD 165054"},
        {"Hipparcos Number", "HIP 88589"},
        {"Geneva Identification System", "GEN# +1.00165054J"},
        {"Smithsonian Astrophysical Observation", "SAO 186246"},
        {"Wilson Evans Batten Catalogue", "WEB 15003"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.31863375),
        dec: Angle.Degrees(-28.68612220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69279"},
        {"Hipparcos Number", "HIP 40424"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.81149011),
        dec: Angle.Degrees(-28.68597852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10987"},
        {"Hipparcos Number", "HIP 8331"},
        {"Geneva Identification System", "GEN# +1.00010987"},
        {"Smithsonian Astrophysical Observation", "SAO 167295"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.86099170),
        dec: Angle.Degrees(-28.68436664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219519"},
        {"Hipparcos Number", "HIP 114920"},
        {"Smithsonian Astrophysical Observation", "SAO 191783"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.16499886),
        dec: Angle.Degrees(-28.68409159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30413"},
    },
    visualMagnitude: 11.75,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.92032852),
        dec: Angle.Degrees(-28.68276604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182432"},
        {"Hipparcos Number", "HIP 95519"},
        {"Smithsonian Astrophysical Observation", "SAO 188108"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.43899954),
        dec: Angle.Degrees(-28.68092534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42803",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6953 A"},
        {"Henry Draper", "HD 74474"},
        {"Hipparcos Number", "HIP 42803"},
        {"Smithsonian Astrophysical Observation", "SAO 176355"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.80968536),
        dec: Angle.Degrees(-28.68090396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28852",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4682 AB"},
        {"Henry Draper", "HD 41683"},
        {"Hipparcos Number", "HIP 28852"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.35278001),
        dec: Angle.Degrees(-28.67724963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221547"},
        {"Hipparcos Number", "HIP 116246"},
        {"Smithsonian Astrophysical Observation", "SAO 191986"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.31111963),
        dec: Angle.Degrees(-28.67696810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49146",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7614 A"},
        {"Henry Draper", "HD 87038"},
        {"Hipparcos Number", "HIP 49146"},
        {"Renson", "Renson 24890"},
        {"Smithsonian Astrophysical Observation", "SAO 178319"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.46477296),
        dec: Angle.Degrees(-28.67620040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184620"},
        {"Hipparcos Number", "HIP 96438"},
        {"Smithsonian Astrophysical Observation", "SAO 188330"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.10655151),
        dec: Angle.Degrees(-28.67451967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220378"},
        {"Hipparcos Number", "HIP 115469"},
        {"Smithsonian Astrophysical Observation", "SAO 191864"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.86907679),
        dec: Angle.Degrees(-28.67445249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212372"},
        {"Hipparcos Number", "HIP 110586"},
        {"Geneva Identification System", "GEN# +1.00212372"},
        {"Smithsonian Astrophysical Observation", "SAO 191114"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.05411813),
        dec: Angle.Degrees(-28.67439105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115632"},
        {"Hipparcos Number", "HIP 64942"},
        {"Smithsonian Astrophysical Observation", "SAO 181541"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.68637009),
        dec: Angle.Degrees(-28.67254599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28339"},
        {"Hipparcos Number", "HIP 20773"},
        {"Smithsonian Astrophysical Observation", "SAO 169460"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.75640798),
        dec: Angle.Degrees(-28.67143390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49152",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7614 B"},
        {"Henry Draper", "HD 87037"},
        {"Hipparcos Number", "HIP 49152"},
        {"Smithsonian Astrophysical Observation", "SAO 178320"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.46853409),
        dec: Angle.Degrees(-28.67109534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207970"},
        {"Hipparcos Number", "HIP 108065"},
        {"Geneva Identification System", "GEN# +1.00207970"},
        {"Smithsonian Astrophysical Observation", "SAO 190714"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.42380435),
        dec: Angle.Degrees(-28.67007866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184533"},
        {"Hipparcos Number", "HIP 96408"},
        {"Smithsonian Astrophysical Observation", "SAO 188325"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.01323549),
        dec: Angle.Degrees(-28.66836135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210849"},
        {"Hipparcos Number", "HIP 109744"},
        {"Smithsonian Astrophysical Observation", "SAO 190977"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.45320284),
        dec: Angle.Degrees(-28.66798931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17312"},
        {"Hipparcos Number", "HIP 12905"},
        {"Smithsonian Astrophysical Observation", "SAO 168029"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.47395336),
        dec: Angle.Degrees(-28.66724895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99261"},
        {"Hipparcos Number", "HIP 55731"},
        {"Smithsonian Astrophysical Observation", "SAO 179858"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.27797670),
        dec: Angle.Degrees(-28.66710257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180233"},
        {"Hipparcos Number", "HIP 94752"},
        {"Smithsonian Astrophysical Observation", "SAO 187905"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.20345257),
        dec: Angle.Degrees(-28.66707069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119465"},
        {"Hipparcos Number", "HIP 67006"},
        {"Smithsonian Astrophysical Observation", "SAO 181911"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.98597437),
        dec: Angle.Degrees(-28.66601175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71947"},
        {"Hipparcos Number", "HIP 41627"},
        {"Smithsonian Astrophysical Observation", "SAO 175926"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.29532128),
        dec: Angle.Degrees(-28.66573808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30118"},
        {"Hipparcos Number", "HIP 21985"},
        {"Smithsonian Astrophysical Observation", "SAO 169699"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.89175961),
        dec: Angle.Degrees(-28.66432877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194215"},
        {"Hipparcos Number", "HIP 100738"},
        {"Fundamental Katalog 5th Edition", "FK5 1532"},
        {"Geneva Identification System", "GEN# +1.00194215"},
        {"Smithsonian Astrophysical Observation", "SAO 189264"},
        {"Wilson Evans Batten Catalogue", "WEB 18203"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.36175161),
        dec: Angle.Degrees(-28.66327932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1961"},
        {"Hipparcos Number", "HIP 1870"},
        {"Smithsonian Astrophysical Observation", "SAO 166236"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.91245484),
        dec: Angle.Degrees(-28.66261667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202337"},
        {"Hipparcos Number", "HIP 104999"},
        {"Smithsonian Astrophysical Observation", "SAO 190176"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.98636100),
        dec: Angle.Degrees(-28.66225542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85602"},
        {"Hipparcos Number", "HIP 48420"},
        {"Smithsonian Astrophysical Observation", "SAO 178120"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.06568559),
        dec: Angle.Degrees(-28.66103837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111015",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15978 AB"},
        {"Henry Draper", "HD 213074"},
        {"Hipparcos Number", "HIP 111015"},
        {"Smithsonian Astrophysical Observation", "SAO 191178"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.35770198),
        dec: Angle.Degrees(-28.65951732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30349"},
        {"Hipparcos Number", "HIP 22123"},
        {"Smithsonian Astrophysical Observation", "SAO 169739"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.41802984),
        dec: Angle.Degrees(-28.65887207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46094"},
        {"Hipparcos Number", "HIP 30976"},
        {"Geneva Identification System", "GEN# +1.00046094"},
        {"Smithsonian Astrophysical Observation", "SAO 171852"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.52194568),
        dec: Angle.Degrees(-28.65795278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72747"},
    },
    visualMagnitude: 11.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.08502736),
        dec: Angle.Degrees(-28.65754596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38854"},
    },
    visualMagnitude: 12.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.26547960),
        dec: Angle.Degrees(-28.16160058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39576"},
        {"Hipparcos Number", "HIP 27727"},
        {"Smithsonian Astrophysical Observation", "SAO 170952"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.06659941),
        dec: Angle.Degrees(-28.65687437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44774"},
        {"Smithsonian Astrophysical Observation", "SAO 176987"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.87944164),
        dec: Angle.Degrees(-28.65613144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4401"},
        {"Geneva Identification System", "GEN# -0.02900270"},
        {"Smithsonian Astrophysical Observation", "SAO 166693"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.10952956),
        dec: Angle.Degrees(-28.65604342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33144"},
        {"Hipparcos Number", "HIP 23805"},
        {"Geneva Identification System", "GEN# +1.00033144"},
        {"Smithsonian Astrophysical Observation", "SAO 170081"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.74524760),
        dec: Angle.Degrees(-28.65590355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60571"},
        {"Hipparcos Number", "HIP 36786"},
        {"Smithsonian Astrophysical Observation", "SAO 174013"},
    },
    visualMagnitude: 9.19,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.49222393),
        dec: Angle.Degrees(-28.65582892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157692"},
        {"Hipparcos Number", "HIP 85299"},
        {"Geneva Identification System", "GEN# +1.00157692"},
        {"Smithsonian Astrophysical Observation", "SAO 185391"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.46321387),
        dec: Angle.Degrees(-28.65528968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157434"},
        {"Hipparcos Number", "HIP 85174"},
        {"Geneva Identification System", "GEN# +1.00157434"},
        {"Smithsonian Astrophysical Observation", "SAO 185360"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.09710611),
        dec: Angle.Degrees(-28.65326779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49894"},
        {"Hipparcos Number", "HIP 32708"},
        {"Smithsonian Astrophysical Observation", "SAO 172380"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.36127043),
        dec: Angle.Degrees(-28.65222114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167666"},
        {"Hipparcos Number", "HIP 89622"},
        {"Geneva Identification System", "GEN# +1.00167666"},
        {"Smithsonian Astrophysical Observation", "SAO 186594"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.35033079),
        dec: Angle.Degrees(-28.65202985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15047"},
        {"Hipparcos Number", "HIP 11244"},
        {"Fundamental Katalog 5th Edition", "FK5 4224"},
        {"Geneva Identification System", "GEN# +1.00015047"},
        {"Smithsonian Astrophysical Observation", "SAO 167766"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.18972805),
        dec: Angle.Degrees(-28.65140925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176612"},
        {"Hipparcos Number", "HIP 93479"},
        {"Geneva Identification System", "GEN# +1.00176612"},
        {"Smithsonian Astrophysical Observation", "SAO 187592"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.55769795),
        dec: Angle.Degrees(-28.65061109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87744"},
        {"Hipparcos Number", "HIP 49503"},
        {"Smithsonian Astrophysical Observation", "SAO 178417"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.61235151),
        dec: Angle.Degrees(-28.64878059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159783"},
        {"Hipparcos Number", "HIP 86276"},
        {"Geneva Identification System", "GEN# +1.00159783"},
        {"Smithsonian Astrophysical Observation", "SAO 185559"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.42818176),
        dec: Angle.Degrees(-28.64660838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93500",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11949 AB"},
        {"Henry Draper", "HD 176686"},
        {"Hipparcos Number", "HIP 93500"},
        {"Smithsonian Astrophysical Observation", "SAO 187597"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.63360358),
        dec: Angle.Degrees(-28.64451930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109533"},
        {"Hipparcos Number", "HIP 61453"},
        {"Smithsonian Astrophysical Observation", "SAO 180932"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.90083840),
        dec: Angle.Degrees(-28.64293620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128816"},
        {"Hipparcos Number", "HIP 71688"},
        {"Smithsonian Astrophysical Observation", "SAO 182744"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.96157915),
        dec: Angle.Degrees(-28.64270920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5608"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.97993818),
        dec: Angle.Degrees(-28.64005096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9717"},
        {"Hipparcos Number", "HIP 7340"},
        {"Smithsonian Astrophysical Observation", "SAO 167151"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.64190029),
        dec: Angle.Degrees(-28.63896448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38804"},
        {"Hipparcos Number", "HIP 27303"},
        {"Geneva Identification System", "GEN# +1.00038804"},
        {"Smithsonian Astrophysical Observation", "SAO 170836"},
        {"Wilson Evans Batten Catalogue", "WEB 5368"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.76908719),
        dec: Angle.Degrees(-28.63893860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75306"},
        {"Hipparcos Number", "HIP 43215"},
        {"Smithsonian Astrophysical Observation", "SAO 176496"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.06097234),
        dec: Angle.Degrees(-28.63877951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28008"},
    },
    visualMagnitude: 11.79,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.86720488),
        dec: Angle.Degrees(-28.63826174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15677"},
        {"Hipparcos Number", "HIP 11668"},
        {"Geneva Identification System", "GEN# +1.00015677"},
        {"Smithsonian Astrophysical Observation", "SAO 167841"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.63172885),
        dec: Angle.Degrees(-28.63717411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103295"},
        {"Hipparcos Number", "HIP 57982"},
        {"Geneva Identification System", "GEN# +1.00103295"},
        {"Smithsonian Astrophysical Observation", "SAO 180273"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.40442184),
        dec: Angle.Degrees(-28.63697959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177846"},
        {"Hipparcos Number", "HIP 93925"},
        {"Geneva Identification System", "GEN# +1.00177846"},
        {"Smithsonian Astrophysical Observation", "SAO 187701"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.87850541),
        dec: Angle.Degrees(-28.63678162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46242"},
        {"Smithsonian Astrophysical Observation", "SAO 177430"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.41160831),
        dec: Angle.Degrees(-28.63627237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121653"},
        {"Hipparcos Number", "HIP 68161"},
        {"Smithsonian Astrophysical Observation", "SAO 182117"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.32146376),
        dec: Angle.Degrees(-28.63520127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158304"},
        {"Hipparcos Number", "HIP 85613"},
        {"Geneva Identification System", "GEN# +1.00158304"},
        {"Smithsonian Astrophysical Observation", "SAO 185449"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.42726808),
        dec: Angle.Degrees(-28.63510806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20411"},
        {"Hipparcos Number", "HIP 15208"},
        {"Geneva Identification System", "GEN# +1.00020411"},
        {"Smithsonian Astrophysical Observation", "SAO 168425"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.01616252),
        dec: Angle.Degrees(-28.63440322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10807"},
    },
    visualMagnitude: 12.72,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.78097896),
        dec: Angle.Degrees(-28.63105826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38741"},
        {"Geneva Identification System", "GEN# -0.02805104"},
        {"Smithsonian Astrophysical Observation", "SAO 174826"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.97021979),
        dec: Angle.Degrees(-28.62967084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191502"},
        {"Hipparcos Number", "HIP 99478"},
        {"Smithsonian Astrophysical Observation", "SAO 188996"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.83723579),
        dec: Angle.Degrees(-28.62952982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201482"},
        {"Hipparcos Number", "HIP 104556"},
        {"Smithsonian Astrophysical Observation", "SAO 190089"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.69476663),
        dec: Angle.Degrees(-28.62912199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23405"},
        {"Hipparcos Number", "HIP 17422"},
        {"Renson", "Renson 5990"},
        {"Smithsonian Astrophysical Observation", "SAO 168781"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.99122345),
        dec: Angle.Degrees(-28.62858849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82610"},
        {"Hipparcos Number", "HIP 46810"},
        {"Geneva Identification System", "GEN# +1.00082610"},
        {"Renson", "Renson 23516"},
        {"Smithsonian Astrophysical Observation", "SAO 177619"},
        {"Wilson Evans Batten Catalogue", "WEB 8827"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.07685571),
        dec: Angle.Degrees(-28.62787596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35630"},
        {"Smithsonian Astrophysical Observation", "SAO 173536"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.28212300),
        dec: Angle.Degrees(-28.62742150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316300"},
        {"Hipparcos Number", "HIP 87109"},
        {"Geneva Identification System", "GEN# +1.00316300"},
        {"Smithsonian Astrophysical Observation", "SAO 185764"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.97575387),
        dec: Angle.Degrees(-28.62665928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37484"},
        {"Hipparcos Number", "HIP 26453"},
        {"Geneva Identification System", "GEN# +1.00037484"},
        {"Smithsonian Astrophysical Observation", "SAO 170610"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.41504533),
        dec: Angle.Degrees(-28.62628562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127359"},
        {"Hipparcos Number", "HIP 71024"},
        {"Geneva Identification System", "GEN# +1.00127359"},
        {"Smithsonian Astrophysical Observation", "SAO 182632"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.88964843),
        dec: Angle.Degrees(-28.62617036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70423"},
        {"Hipparcos Number", "HIP 40914"},
        {"Smithsonian Astrophysical Observation", "SAO 175654"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.25050840),
        dec: Angle.Degrees(-28.62494316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70657"},
        {"Hipparcos Number", "HIP 41004"},
        {"Smithsonian Astrophysical Observation", "SAO 175688"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.52801849),
        dec: Angle.Degrees(-28.62395227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164019"},
        {"Hipparcos Number", "HIP 88157"},
        {"Geneva Identification System", "GEN# +1.00164019"},
        {"Smithsonian Astrophysical Observation", "SAO 186076"},
        {"Wilson Evans Batten Catalogue", "WEB 14892"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.08313896),
        dec: Angle.Degrees(-28.62073892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208869"},
        {"Hipparcos Number", "HIP 108585"},
        {"Geneva Identification System", "GEN# +1.00208869"},
        {"Smithsonian Astrophysical Observation", "SAO 190803"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.94934831),
        dec: Angle.Degrees(-28.61885249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41572"},
        {"Hipparcos Number", "HIP 28786"},
        {"Geneva Identification System", "GEN# +1.00041572"},
        {"Smithsonian Astrophysical Observation", "SAO 171210"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.16304451),
        dec: Angle.Degrees(-28.61780075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75649"},
        {"Hipparcos Number", "HIP 43394"},
        {"Geneva Identification System", "GEN# +1.00075649"},
        {"Renson", "Renson 21180"},
        {"Smithsonian Astrophysical Observation", "SAO 176554"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.59020878),
        dec: Angle.Degrees(-28.61760308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89090"},
        {"Hipparcos Number", "HIP 50288"},
        {"Geneva Identification System", "GEN# +1.00089090"},
        {"Smithsonian Astrophysical Observation", "SAO 178597"},
        {"Wilson Evans Batten Catalogue", "WEB 9234"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.01759132),
        dec: Angle.Degrees(-28.61410602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146624"},
        {"Hipparcos Number", "HIP 79881"},
        {"Celescope Catalog", "CEL 4418"},
        {"Fundamental Katalog 5th Edition", "FK5 3288"},
        {"Geneva Identification System", "GEN# +1.00146624"},
        {"Renson", "Renson 41430"},
        {"Smithsonian Astrophysical Observation", "SAO 184301"},
        {"Wilson Evans Batten Catalogue", "WEB 13522"},
    },
    visualMagnitude: 4.80,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.57467023),
        dec: Angle.Degrees(-28.61377598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54672"},
        {"Hipparcos Number", "HIP 34457"},
        {"Geneva Identification System", "GEN# +1.00054672"},
        {"Smithsonian Astrophysical Observation", "SAO 173054"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.14060318),
        dec: Angle.Degrees(-28.61327330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174907"},
        {"Hipparcos Number", "HIP 92753"},
        {"Smithsonian Astrophysical Observation", "SAO 187420"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.51725522),
        dec: Angle.Degrees(-28.61025073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205588"},
        {"Hipparcos Number", "HIP 106719"},
        {"Smithsonian Astrophysical Observation", "SAO 190489"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.25089690),
        dec: Angle.Degrees(-28.60902167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55889"},
        {"Hipparcos Number", "HIP 34934"},
        {"Smithsonian Astrophysical Observation", "SAO 173248"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.42781895),
        dec: Angle.Degrees(-28.60888686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185183"},
        {"Hipparcos Number", "HIP 96644"},
        {"Renson", "Renson 51130"},
        {"Smithsonian Astrophysical Observation", "SAO 188386"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.73421311),
        dec: Angle.Degrees(-28.60720650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13349"},
        {"Hipparcos Number", "HIP 10093"},
        {"Geneva Identification System", "GEN# +1.00013349"},
        {"Smithsonian Astrophysical Observation", "SAO 167602"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.43951811),
        dec: Angle.Degrees(-28.60698775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216821"},
        {"Hipparcos Number", "HIP 113291"},
        {"Geneva Identification System", "GEN# +1.00216821"},
        {"Smithsonian Astrophysical Observation", "SAO 191509"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.11479662),
        dec: Angle.Degrees(-28.60595623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49967",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7681 AB"},
        {"Henry Draper", "HD 88522"},
        {"Hipparcos Number", "HIP 49967"},
        {"Geneva Identification System", "GEN# +1.00088522J"},
        {"Smithsonian Astrophysical Observation", "SAO 178526"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.01198942),
        dec: Angle.Degrees(-28.60595499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94985",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12299 AB"},
        {"Henry Draper", "HD 180957"},
        {"Hipparcos Number", "HIP 94985"},
        {"Smithsonian Astrophysical Observation", "SAO 187969"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.91437317),
        dec: Angle.Degrees(-28.60515751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105058",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14802 AB"},
        {"Henry Draper", "HD 202481"},
        {"Hipparcos Number", "HIP 105058"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.23220383),
        dec: Angle.Degrees(-28.60467351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195438"},
        {"Hipparcos Number", "HIP 101340"},
        {"Smithsonian Astrophysical Observation", "SAO 189404"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.09078347),
        dec: Angle.Degrees(-28.60177324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56751"},
        {"Hipparcos Number", "HIP 35262"},
        {"Celescope Catalog", "CEL 1742"},
        {"Smithsonian Astrophysical Observation", "SAO 173381"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.28003500),
        dec: Angle.Degrees(-28.60037588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68753",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9097 AB"},
        {"Henry Draper", "HD 122754"},
        {"Hipparcos Number", "HIP 68753"},
        {"Smithsonian Astrophysical Observation", "SAO 182212"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.09075368),
        dec: Angle.Degrees(-28.59984345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42750"},
        {"Hipparcos Number", "HIP 29340"},
        {"Smithsonian Astrophysical Observation", "SAO 171355"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.78323219),
        dec: Angle.Degrees(-28.59812467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195500"},
        {"Hipparcos Number", "HIP 101367"},
        {"Smithsonian Astrophysical Observation", "SAO 189413"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.17660704),
        dec: Angle.Degrees(-28.59541966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82236"},
        {"Hipparcos Number", "HIP 46593"},
        {"Smithsonian Astrophysical Observation", "SAO 177556"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.52088034),
        dec: Angle.Degrees(-28.59366237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188812"},
        {"Hipparcos Number", "HIP 98264"},
        {"Smithsonian Astrophysical Observation", "SAO 188761"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.49982738),
        dec: Angle.Degrees(-28.59279828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175979"},
        {"Hipparcos Number", "HIP 93207"},
        {"Geneva Identification System", "GEN# +1.00175979"},
        {"Smithsonian Astrophysical Observation", "SAO 187535"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.78113011),
        dec: Angle.Degrees(-28.59266767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76640"},
    },
    visualMagnitude: 11.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)39, 00.0100),
        dec: Angle.DegreesMinutesSeconds((int)-28, (int)35, 33.200)
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
    primaryId: "HIP 98496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189365"},
        {"Hipparcos Number", "HIP 98496"},
        {"Smithsonian Astrophysical Observation", "SAO 188808"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.14959262),
        dec: Angle.Degrees(-28.58643139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150347"},
        {"Hipparcos Number", "HIP 81727"},
        {"Geneva Identification System", "GEN# +1.00150347"},
        {"Renson", "Renson 42510"},
        {"Smithsonian Astrophysical Observation", "SAO 184546"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.39786469),
        dec: Angle.Degrees(-28.58635054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14099"},
        {"Hipparcos Number", "HIP 10577"},
        {"Smithsonian Astrophysical Observation", "SAO 167672"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.03208588),
        dec: Angle.Degrees(-28.58412318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220413"},
        {"Hipparcos Number", "HIP 115490"},
        {"Smithsonian Astrophysical Observation", "SAO 191867"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.92969140),
        dec: Angle.Degrees(-28.58328018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218359"},
        {"Hipparcos Number", "HIP 114197"},
        {"Smithsonian Astrophysical Observation", "SAO 191668"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.89986946),
        dec: Angle.Degrees(-28.58317335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154088"},
        {"Hipparcos Number", "HIP 83541"},
        {"Geneva Identification System", "GEN# +1.00154088"},
        {"Geneva Identification System 2", "GEN# +6.10010065B"},
        {"Smithsonian Astrophysical Observation", "SAO 184990"},
        {"Wilson Evans Batten Catalogue", "WEB 14123"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.11578258),
        dec: Angle.Degrees(-28.58202423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -269.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10573"},
        {"Hipparcos Number", "HIP 7977"},
        {"Smithsonian Astrophysical Observation", "SAO 167241"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.61590484),
        dec: Angle.Degrees(-28.57918530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68595"},
        {"Hipparcos Number", "HIP 40164"},
        {"Smithsonian Astrophysical Observation", "SAO 175374"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.04649026),
        dec: Angle.Degrees(-28.57690534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54555"},
        {"Hipparcos Number", "HIP 34412"},
        {"Celescope Catalog", "CEL 1606"},
        {"Geneva Identification System", "GEN# +1.00054555"},
        {"Smithsonian Astrophysical Observation", "SAO 173036"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.01258375),
        dec: Angle.Degrees(-28.57686300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16959"},
        {"Hipparcos Number", "HIP 12639"},
        {"Smithsonian Astrophysical Observation", "SAO 167984"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.58848918),
        dec: Angle.Degrees(-28.57516129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32547"},
        {"Smithsonian Astrophysical Observation", "SAO 172334"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.86801608),
        dec: Angle.Degrees(-28.57360312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84671"},
        {"Hipparcos Number", "HIP 47942"},
        {"Smithsonian Astrophysical Observation", "SAO 177957"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.54144255),
        dec: Angle.Degrees(-28.57285475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86149",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10647 AB"},
        {"Henry Draper", "HD 159509"},
        {"Hipparcos Number", "HIP 86149"},
        {"Geneva Identification System", "GEN# +1.00159509J"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.07292375),
        dec: Angle.Degrees(-28.57190116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16943"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.51241642),
        dec: Angle.Degrees(-28.57086049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -323.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140857"},
        {"Hipparcos Number", "HIP 77307"},
        {"Smithsonian Astrophysical Observation", "SAO 183783"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.74469145),
        dec: Angle.Degrees(-28.57042988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121156"},
        {"Hipparcos Number", "HIP 67890"},
        {"Geneva Identification System", "GEN# +1.00121156"},
        {"Smithsonian Astrophysical Observation", "SAO 182065"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.56979864),
        dec: Angle.Degrees(-28.56942861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60555"},
        {"Hipparcos Number", "HIP 36780"},
        {"Fundamental Katalog 5th Edition", "FK5 4681"},
        {"Geneva Identification System", "GEN# +1.00060555"},
        {"Smithsonian Astrophysical Observation", "SAO 174008"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.46826726),
        dec: Angle.Degrees(-28.56774711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27523"},
        {"Smithsonian Astrophysical Observation", "SAO 170888"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.41442980),
        dec: Angle.Degrees(-28.56686392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21762"},
        {"Hipparcos Number", "HIP 16264"},
        {"Smithsonian Astrophysical Observation", "SAO 168585"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.40056493),
        dec: Angle.Degrees(-28.56679001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31560"},
        {"Hipparcos Number", "HIP 22907"},
        {"Geneva Identification System", "GEN# +1.00031560"},
        {"Smithsonian Astrophysical Observation", "SAO 169892"},
        {"Wilson Evans Batten Catalogue", "WEB 4445"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.92410720),
        dec: Angle.Degrees(-28.56336116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10118"},
        {"Hipparcos Number", "HIP 7638"},
        {"Smithsonian Astrophysical Observation", "SAO 167192"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.60457928),
        dec: Angle.Degrees(-28.56331085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16053",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2543 A"},
        {"Henry Draper", "HD 21460"},
        {"Hipparcos Number", "HIP 16053"},
        {"Smithsonian Astrophysical Observation", "SAO 168549"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.68418960),
        dec: Angle.Degrees(-28.56094671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88414",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Pincoya"},
        {"Henry Draper", "HD 164604"},
        {"Hipparcos Number", "HIP 88414"},
        {"Geneva Identification System", "GEN# +1.00164604"},
        {"Smithsonian Astrophysical Observation", "SAO 186165"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77897929),
        dec: Angle.Degrees(-28.56055021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33073"},
        {"Hipparcos Number", "HIP 23771"},
        {"Geneva Identification System", "GEN# +1.00033073"},
        {"Smithsonian Astrophysical Observation", "SAO 170071"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.63334655),
        dec: Angle.Degrees(-28.56026164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49488"},
        {"Hipparcos Number", "HIP 32542"},
        {"Geneva Identification System", "GEN# +1.00049488"},
        {"Smithsonian Astrophysical Observation", "SAO 172332"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.86413415),
        dec: Angle.Degrees(-28.55877889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12835"},
        {"Hipparcos Number", "HIP 9737"},
        {"Geneva Identification System", "GEN# +1.00012835"},
        {"Smithsonian Astrophysical Observation", "SAO 167540"},
        {"Wilson Evans Batten Catalogue", "WEB 2049"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.31785906),
        dec: Angle.Degrees(-28.55813335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187605"},
        {"Hipparcos Number", "HIP 97748"},
        {"Smithsonian Astrophysical Observation", "SAO 188643"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.96026720),
        dec: Angle.Degrees(-28.55690111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107912"},
        {"Hipparcos Number", "HIP 60498"},
        {"Smithsonian Astrophysical Observation", "SAO 180758"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.04424221),
        dec: Angle.Degrees(-28.55556365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4452"},
        {"Hipparcos Number", "HIP 3629"},
        {"Geneva Identification System", "GEN# +1.00004452"},
        {"Smithsonian Astrophysical Observation", "SAO 166564"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.62976403),
        dec: Angle.Degrees(-28.55365360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153503"},
        {"Hipparcos Number", "HIP 83261"},
        {"Smithsonian Astrophysical Observation", "SAO 184914"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.26374863),
        dec: Angle.Degrees(-28.55307466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196838"},
        {"Hipparcos Number", "HIP 102050"},
        {"Smithsonian Astrophysical Observation", "SAO 189564"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.21824065),
        dec: Angle.Degrees(-28.54925732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12593",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2069 AB"},
        {"Henry Draper", "HD 16915"},
        {"Hipparcos Number", "HIP 12593"},
        {"Smithsonian Astrophysical Observation", "SAO 167978"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.48597182),
        dec: Angle.Degrees(-28.54670361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95278"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.76488719),
        dec: Angle.Degrees(-28.54564449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5227"},
        {"Hipparcos Number", "HIP 4218"},
        {"Geneva Identification System", "GEN# +1.00005227"},
        {"Smithsonian Astrophysical Observation", "SAO 166658"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.45525600),
        dec: Angle.Degrees(-28.54465123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157719"},
        {"Hipparcos Number", "HIP 85320"},
        {"Geneva Identification System", "GEN# +1.00157719"},
        {"Smithsonian Astrophysical Observation", "SAO 185394"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.52862960),
        dec: Angle.Degrees(-28.54331390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19684",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3069"},
        {"Aitken 2", "ADS 3069 AB"},
        {"Henry Draper", "HD 26770"},
        {"Hipparcos Number", "HIP 19684"},
        {"Geneva Identification System", "GEN# +1.00026770"},
        {"Smithsonian Astrophysical Observation", "SAO 169233"},
        {"Wilson Evans Batten Catalogue", "WEB 3756"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.25197064),
        dec: Angle.Degrees(-28.54075193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50806"},
        {"Hipparcos Number", "HIP 33094"},
        {"Cincinnati Publication", "Ci 20 401"},
        {"Geneva Identification System", "GEN# +1.00050806"},
        {"Smithsonian Astrophysical Observation", "SAO 172524"},
        {"Wilson Evans Batten Catalogue", "WEB 6661"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.39064640),
        dec: Angle.Degrees(-28.53872019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 282.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -441.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86016"},
        {"Hipparcos Number", "HIP 48648"},
        {"Smithsonian Astrophysical Observation", "SAO 178179"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.80152011),
        dec: Angle.Degrees(-28.53670701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2722"},
        {"Hipparcos Number", "HIP 2404"},
        {"Smithsonian Astrophysical Observation", "SAO 166322"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.65883799),
        dec: Angle.Degrees(-28.53625644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114994"},
        {"Hipparcos Number", "HIP 64610"},
        {"Smithsonian Astrophysical Observation", "SAO 181477"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.64486431),
        dec: Angle.Degrees(-28.53553024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50919"},
        {"Hipparcos Number", "HIP 33141"},
        {"Smithsonian Astrophysical Observation", "SAO 172543"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.51436559),
        dec: Angle.Degrees(-28.53470406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178814"},
        {"Hipparcos Number", "HIP 94261"},
        {"Fundamental Katalog 5th Edition", "FK5 5687"},
        {"Smithsonian Astrophysical Observation", "SAO 187785"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.79975809),
        dec: Angle.Degrees(-28.53411738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18839",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2952 AB"},
        {"Henry Draper", "HD 25546"},
        {"Hipparcos Number", "HIP 18839"},
        {"Smithsonian Astrophysical Observation", "SAO 169052"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.59103773),
        dec: Angle.Degrees(-28.53085028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93065"},
        {"Hipparcos Number", "HIP 52527"},
        {"Smithsonian Astrophysical Observation", "SAO 179179"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.09685628),
        dec: Angle.Degrees(-28.52987140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36516"},
        {"Hipparcos Number", "HIP 25843"},
        {"Geneva Identification System", "GEN# +1.00036516"},
        {"Smithsonian Astrophysical Observation", "SAO 170508"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.75493101),
        dec: Angle.Degrees(-28.52909622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107261"},
        {"Hipparcos Number", "HIP 60142"},
        {"Geneva Identification System", "GEN# +1.00107261"},
        {"Smithsonian Astrophysical Observation", "SAO 180691"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.99863874),
        dec: Angle.Degrees(-28.52546148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215784"},
        {"Hipparcos Number", "HIP 112571"},
        {"Smithsonian Astrophysical Observation", "SAO 191414"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.00460994),
        dec: Angle.Degrees(-28.52040314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113612"},
        {"Hipparcos Number", "HIP 63851"},
        {"Geneva Identification System", "GEN# +1.00113612"},
        {"Smithsonian Astrophysical Observation", "SAO 181375"},
        {"Wilson Evans Batten Catalogue", "WEB 11291"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.29384988),
        dec: Angle.Degrees(-28.51750505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122870"},
        {"Hipparcos Number", "HIP 68802"},
        {"Geneva Identification System", "GEN# +1.00122870"},
        {"Smithsonian Astrophysical Observation", "SAO 182223"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.27224618),
        dec: Angle.Degrees(-28.51656600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156570"},
        {"Hipparcos Number", "HIP 84750"},
        {"Smithsonian Astrophysical Observation", "SAO 185265"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.85638311),
        dec: Angle.Degrees(-28.51520777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15749"},
        {"Hipparcos Number", "HIP 11709"},
        {"Smithsonian Astrophysical Observation", "SAO 167850"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.77474551),
        dec: Angle.Degrees(-28.51373609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88656"},
        {"Hipparcos Number", "HIP 50032"},
        {"Geneva Identification System", "GEN# +1.00088656"},
        {"Smithsonian Astrophysical Observation", "SAO 178540"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.22004380),
        dec: Angle.Degrees(-28.51332301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171627"},
        {"Hipparcos Number", "HIP 91273"},
        {"Geneva Identification System", "GEN# +1.00171627"},
        {"Smithsonian Astrophysical Observation", "SAO 187048"},
        {"Wilson Evans Batten Catalogue", "WEB 15683"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.26367197),
        dec: Angle.Degrees(-28.51273226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8409"},
        {"Hipparcos Number", "HIP 6444"},
        {"Smithsonian Astrophysical Observation", "SAO 167000"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.68826707),
        dec: Angle.Degrees(-28.51273178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22924"},
        {"Hipparcos Number", "HIP 17108"},
        {"Geneva Identification System", "GEN# +1.00022924"},
        {"Smithsonian Astrophysical Observation", "SAO 168720"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.97272993),
        dec: Angle.Degrees(-28.51122346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150894"},
        {"Hipparcos Number", "HIP 81992"},
        {"Geneva Identification System", "GEN# +1.00150894J"},
        {"Smithsonian Astrophysical Observation", "SAO 184602"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.25086797),
        dec: Angle.Degrees(-28.50965621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32457"},
    },
    visualMagnitude: 10.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.60979070),
        dec: Angle.Degrees(-28.50772959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99043"},
        {"Hipparcos Number", "HIP 55624"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.93812035),
        dec: Angle.Degrees(-28.50688540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317084"},
        {"Hipparcos Number", "HIP 88789"},
        {"Wilson Evans Batten Catalogue", "WEB 15045"},
    },
    visualMagnitude: 10.04,
    bvColour: 3.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.86962852),
        dec: Angle.Degrees(-28.50656541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139500"},
        {"Hipparcos Number", "HIP 76683"},
        {"Smithsonian Astrophysical Observation", "SAO 183667"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.88344341),
        dec: Angle.Degrees(-28.50605574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55622",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 12.25,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23, 43.3600),
        dec: Angle.DegreesMinutesSeconds((int)-28, (int)30, 10.700)
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
    primaryId: "HIP 72027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129588"},
        {"Hipparcos Number", "HIP 72027"},
        {"Smithsonian Astrophysical Observation", "SAO 182814"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.00837832),
        dec: Angle.Degrees(-28.50095105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37207"},
        {"Geneva Identification System", "GEN# -0.02804645"},
        {"Wilson Evans Batten Catalogue", "WEB 7373"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.64682891),
        dec: Angle.Degrees(-28.49961654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194586"},
        {"Hipparcos Number", "HIP 100893"},
        {"Geneva Identification System", "GEN# +1.00194586"},
        {"Smithsonian Astrophysical Observation", "SAO 189300"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.85828614),
        dec: Angle.Degrees(-28.49905265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87361"},
        {"Hipparcos Number", "HIP 49311"},
        {"Geneva Identification System", "GEN# +1.00087361"},
        {"Smithsonian Astrophysical Observation", "SAO 178361"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.98367203),
        dec: Angle.Degrees(-28.49881907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60766"},
        {"Hipparcos Number", "HIP 36890"},
        {"Geneva Identification System", "GEN# +1.00060766"},
        {"Smithsonian Astrophysical Observation", "SAO 174051"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.76445725),
        dec: Angle.Degrees(-28.49806986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8592"},
        {"Hipparcos Number", "HIP 6569"},
        {"Smithsonian Astrophysical Observation", "SAO 167022"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.10251661),
        dec: Angle.Degrees(-28.49784040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101430"},
        {"Hipparcos Number", "HIP 56931"},
        {"Fundamental Katalog 5th Edition", "FK5 5029"},
        {"Smithsonian Astrophysical Observation", "SAO 180083"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.06989897),
        dec: Angle.Degrees(-28.49656485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32690"},
        {"Hipparcos Number", "HIP 23552"},
        {"Smithsonian Astrophysical Observation", "SAO 170031"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.96990460),
        dec: Angle.Degrees(-28.49585833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4691"},
        {"Hipparcos Number", "HIP 3788"},
        {"Fundamental Katalog 5th Edition", "FK5 2052"},
        {"Geneva Identification System", "GEN# +1.00004691"},
        {"Smithsonian Astrophysical Observation", "SAO 166593"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.17172583),
        dec: Angle.Degrees(-28.49529780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55948",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8174 AB"},
        {"Henry Draper", "HD 99694"},
        {"Hipparcos Number", "HIP 55948"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.98609821),
        dec: Angle.Degrees(-28.49297870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20462"},
        {"Hipparcos Number", "HIP 15242"},
        {"Smithsonian Astrophysical Observation", "SAO 168431"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.14777590),
        dec: Angle.Degrees(-28.49242483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199016"},
        {"Hipparcos Number", "HIP 103259"},
        {"Smithsonian Astrophysical Observation", "SAO 189836"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.78332098),
        dec: Angle.Degrees(-28.49208645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96599"},
        {"Hipparcos Number", "HIP 54372"},
        {"Smithsonian Astrophysical Observation", "SAO 179553"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.86583299),
        dec: Angle.Degrees(-28.49126824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186829"},
        {"Hipparcos Number", "HIP 97401"},
        {"Geneva Identification System", "GEN# +1.00186829"},
        {"Smithsonian Astrophysical Observation", "SAO 188571"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.95103918),
        dec: Angle.Degrees(-28.49117625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201448"},
        {"Hipparcos Number", "HIP 104532"},
        {"Smithsonian Astrophysical Observation", "SAO 190085"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.62219266),
        dec: Angle.Degrees(-28.49105466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111698"},
        {"Cincinnati Publication", "Ci 20 1375"},
        {"Geneva Identification System", "GEN# -0.02817856"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.40216449),
        dec: Angle.Degrees(-28.09080952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 334.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52619"},
        {"Hipparcos Number", "HIP 33760"},
        {"Geneva Identification System", "GEN# +1.00052619"},
        {"Smithsonian Astrophysical Observation", "SAO 172749"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.17719800),
        dec: Angle.Degrees(-28.48947369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85432"},
        {"Hipparcos Number", "HIP 48333"},
        {"Geneva Identification System", "GEN# +1.00085432"},
        {"Smithsonian Astrophysical Observation", "SAO 178091"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.78305602),
        dec: Angle.Degrees(-28.48626406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179027"},
        {"Hipparcos Number", "HIP 94340"},
        {"Geneva Identification System", "GEN# +1.00179027"},
        {"Smithsonian Astrophysical Observation", "SAO 187801"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.02695121),
        dec: Angle.Degrees(-28.48494129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 811"},
    },
    visualMagnitude: 10.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.50217025),
        dec: Angle.Degrees(-28.48237046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192352"},
        {"Hipparcos Number", "HIP 99844"},
        {"Smithsonian Astrophysical Observation", "SAO 189071"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.85744952),
        dec: Angle.Degrees(-28.48044367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218036"},
        {"Hipparcos Number", "HIP 113988"},
        {"Smithsonian Astrophysical Observation", "SAO 191634"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.26828120),
        dec: Angle.Degrees(-28.47980704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51332",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7795 AB"},
        {"Henry Draper", "HD 90893"},
        {"Hipparcos Number", "HIP 51332"},
        {"Smithsonian Astrophysical Observation", "SAO 178882"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.27653227),
        dec: Angle.Degrees(-28.47925697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73116"},
        {"Hipparcos Number", "HIP 42166"},
        {"Smithsonian Astrophysical Observation", "SAO 176139"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.94356099),
        dec: Angle.Degrees(-28.47852406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14674 AB"},
        {"Henry Draper", "HD 201226"},
        {"Hipparcos Number", "HIP 104398"},
        {"Fundamental Katalog 5th Edition", "FK5 5862"},
        {"Smithsonian Astrophysical Observation", "SAO 190055"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.24332962),
        dec: Angle.Degrees(-28.47734886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103596"},
        {"Hipparcos Number", "HIP 58158"},
        {"Geneva Identification System", "GEN# +1.00103596"},
        {"Smithsonian Astrophysical Observation", "SAO 180307"},
        {"Wilson Evans Batten Catalogue", "WEB 10411"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.91720463),
        dec: Angle.Degrees(-28.47703681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98456"},
        {"Hipparcos Number", "HIP 55293"},
        {"Smithsonian Astrophysical Observation", "SAO 179768"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.85997630),
        dec: Angle.Degrees(-28.47566534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138779"},
        {"Hipparcos Number", "HIP 76304"},
        {"Geneva Identification System", "GEN# +1.00138779"},
        {"Smithsonian Astrophysical Observation", "SAO 183592"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.80678977),
        dec: Angle.Degrees(-28.47419226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102817"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.44964547),
        dec: Angle.Degrees(-28.46883780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24032"},
        {"Hipparcos Number", "HIP 17816"},
        {"Geneva Identification System", "GEN# +1.00024032"},
        {"Smithsonian Astrophysical Observation", "SAO 168854"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.18670522),
        dec: Angle.Degrees(-28.46668568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74245",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9524 AB"},
        {"Henry Draper", "HD 134374"},
        {"Hipparcos Number", "HIP 74245"},
        {"Geneva Identification System", "GEN# +1.00134374J"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.58675773),
        dec: Angle.Degrees(-28.46606908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43070"},
        {"Hipparcos Number", "HIP 29507"},
        {"Smithsonian Astrophysical Observation", "SAO 171406"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.24652328),
        dec: Angle.Degrees(-28.46367448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219226"},
        {"Hipparcos Number", "HIP 114737"},
        {"Geneva Identification System", "GEN# +1.00219226"},
        {"Smithsonian Astrophysical Observation", "SAO 191745"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.63433148),
        dec: Angle.Degrees(-28.45864208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2375"},
        {"Smithsonian Astrophysical Observation", "SAO 166315"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.57896745),
        dec: Angle.Degrees(-28.45750691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165634"},
        {"Hipparcos Number", "HIP 88839"},
        {"Fundamental Katalog 5th Edition", "FK5 3439"},
        {"Geneva Identification System", "GEN# +1.00165634"},
        {"Smithsonian Astrophysical Observation", "SAO 186328"},
        {"Wilson Evans Batten Catalogue", "WEB 15058"},
    },
    visualMagnitude: 4.55,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.02067917),
        dec: Angle.Degrees(-28.45701627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95183"},
        {"Hipparcos Number", "HIP 53690"},
        {"Smithsonian Astrophysical Observation", "SAO 179399"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.77793610),
        dec: Angle.Degrees(-28.45625596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51928"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.11904377),
        dec: Angle.Degrees(-28.45424333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -222.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108661",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15536 AB"},
        {"Henry Draper", "HD 209014"},
        {"Hipparcos Number", "HIP 108661"},
        {"Geneva Identification System", "GEN# +1.00209014"},
        {"Renson", "Renson 58100"},
        {"Smithsonian Astrophysical Observation", "SAO 190822"},
        {"Wilson Evans Batten Catalogue", "WEB 19552"},
    },
    visualMagnitude: 5.43,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.20922938),
        dec: Angle.Degrees(-28.45373726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84272"},
        {"Hipparcos Number", "HIP 47692"},
        {"Smithsonian Astrophysical Observation", "SAO 177894"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.85756099),
        dec: Angle.Degrees(-28.45174377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69233"},
        {"Hipparcos Number", "HIP 40416"},
        {"Smithsonian Astrophysical Observation", "SAO 175453"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.75872733),
        dec: Angle.Degrees(-28.45133478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316515"},
        {"Hipparcos Number", "HIP 87455"},
        {"Smithsonian Astrophysical Observation", "SAO 185864"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.04503243),
        dec: Angle.Degrees(-28.45112955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29134"},
        {"Hipparcos Number", "HIP 21287"},
        {"Geneva Identification System", "GEN# +1.00029134"},
        {"Smithsonian Astrophysical Observation", "SAO 169574"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.51105085),
        dec: Angle.Degrees(-28.44955379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200869"},
        {"Hipparcos Number", "HIP 104226"},
        {"Geneva Identification System", "GEN# +1.00200869"},
        {"Smithsonian Astrophysical Observation", "SAO 190020"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.73788555),
        dec: Angle.Degrees(-28.44879113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100558",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13768 AB"},
        {"Henry Draper", "HD 193848"},
        {"Hipparcos Number", "HIP 100558"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.86544205),
        dec: Angle.Degrees(-28.44587697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54913"},
        {"Hipparcos Number", "HIP 34562"},
        {"Celescope Catalog", "CEL 1629"},
        {"Geneva Identification System", "GEN# +1.00054913"},
        {"Smithsonian Astrophysical Observation", "SAO 173094"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.38884865),
        dec: Angle.Degrees(-28.44462122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197693"},
        {"Hipparcos Number", "HIP 102491"},
        {"Smithsonian Astrophysical Observation", "SAO 189665"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.56197954),
        dec: Angle.Degrees(-28.44289254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53679"},
        {"Smithsonian Astrophysical Observation", "SAO 118599"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.74932870),
        dec: Angle.Degrees(+02.19513977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130565"},
        {"Hipparcos Number", "HIP 72522"},
        {"Smithsonian Astrophysical Observation", "SAO 182900"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.41213592),
        dec: Angle.Degrees(-28.44151744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47850"},
        {"Hipparcos Number", "HIP 31840"},
        {"Smithsonian Astrophysical Observation", "SAO 172101"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.86071179),
        dec: Angle.Degrees(-28.44082446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32030"},
        {"Hipparcos Number", "HIP 23176"},
        {"Geneva Identification System", "GEN# +1.00032030"},
        {"Smithsonian Astrophysical Observation", "SAO 169947"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.78640963),
        dec: Angle.Degrees(-28.44077877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315883"},
        {"Hipparcos Number", "HIP 85884"},
        {"Geneva Identification System", "GEN# +1.00315883"},
        {"Smithsonian Astrophysical Observation", "SAO 185492"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.27107461),
        dec: Angle.Degrees(-28.44055300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69249"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.64376594),
        dec: Angle.Degrees(-28.44038115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191113"},
        {"Hipparcos Number", "HIP 99288"},
        {"Geneva Identification System", "GEN# +1.00191113"},
        {"Smithsonian Astrophysical Observation", "SAO 188957"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.32655836),
        dec: Angle.Degrees(-28.44009721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113255"},
        {"Hipparcos Number", "HIP 63656"},
        {"Smithsonian Astrophysical Observation", "SAO 181339"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.69596512),
        dec: Angle.Degrees(-28.43953219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40403"},
        {"Hipparcos Number", "HIP 28181"},
        {"Smithsonian Astrophysical Observation", "SAO 171063"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.31688950),
        dec: Angle.Degrees(-28.43943596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219580"},
        {"Hipparcos Number", "HIP 114969"},
        {"Smithsonian Astrophysical Observation", "SAO 191792"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.28638088),
        dec: Angle.Degrees(-28.43803072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49072"},
        {"Hipparcos Number", "HIP 32372"},
        {"Smithsonian Astrophysical Observation", "SAO 172278"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.35241943),
        dec: Angle.Degrees(-28.43778913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18896"},
        {"Hipparcos Number", "HIP 14079"},
        {"Geneva Identification System", "GEN# +1.00018896"},
        {"Smithsonian Astrophysical Observation", "SAO 168235"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.36209369),
        dec: Angle.Degrees(-28.43512643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209523"},
        {"Hipparcos Number", "HIP 108978"},
        {"Smithsonian Astrophysical Observation", "SAO 190865"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.16316920),
        dec: Angle.Degrees(-28.43505339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188200"},
        {"Hipparcos Number", "HIP 98009"},
        {"Smithsonian Astrophysical Observation", "SAO 188704"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.76319941),
        dec: Angle.Degrees(-28.43370014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65813"},
        {"Hipparcos Number", "HIP 39062"},
        {"Geneva Identification System", "GEN# +1.00065813"},
        {"Smithsonian Astrophysical Observation", "SAO 174945"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.87647412),
        dec: Angle.Degrees(-28.43314032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62640"},
        {"Hipparcos Number", "HIP 37692"},
        {"Celescope Catalog", "CEL 2000"},
        {"Geneva Identification System", "GEN# +1.00062640"},
        {"Renson", "Renson 17220"},
        {"Smithsonian Astrophysical Observation", "SAO 174406"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.99230574),
        dec: Angle.Degrees(-28.43160210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168646"},
        {"Hipparcos Number", "HIP 90012"},
        {"Geneva Identification System", "GEN# +1.00168646"},
        {"Smithsonian Astrophysical Observation", "SAO 186704"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.50055387),
        dec: Angle.Degrees(-28.42995389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218733"},
        {"Hipparcos Number", "HIP 114433"},
        {"Smithsonian Astrophysical Observation", "SAO 191699"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.62663402),
        dec: Angle.Degrees(-28.42856482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79149"},
        {"Hipparcos Number", "HIP 45117"},
        {"Smithsonian Astrophysical Observation", "SAO 177091"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.88003640),
        dec: Angle.Degrees(-28.42777663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195263"},
        {"Hipparcos Number", "HIP 101242"},
        {"Smithsonian Astrophysical Observation", "SAO 189382"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.82122507),
        dec: Angle.Degrees(-28.42687158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196531"},
        {"Hipparcos Number", "HIP 101904"},
        {"Geneva Identification System", "GEN# +1.00196531"},
        {"Smithsonian Astrophysical Observation", "SAO 189523"},
        {"Wilson Evans Batten Catalogue", "WEB 18412"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.76077183),
        dec: Angle.Degrees(-28.42544471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316204"},
        {"Hipparcos Number", "HIP 86898"},
        {"Geneva Identification System", "GEN# +1.00316204"},
        {"Smithsonian Astrophysical Observation", "SAO 185695"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.33668992),
        dec: Angle.Degrees(-28.42290154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151453"},
        {"Hipparcos Number", "HIP 82264"},
        {"Smithsonian Astrophysical Observation", "SAO 184656"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.13416972),
        dec: Angle.Degrees(-28.42256268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30669"},
        {"Hipparcos Number", "HIP 22320"},
        {"Geneva Identification System", "GEN# +1.00030669"},
        {"Smithsonian Astrophysical Observation", "SAO 169782"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.11803186),
        dec: Angle.Degrees(-28.41941837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 237.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79399",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9953 AB"},
        {"Henry Draper", "HD 145483"},
        {"Hipparcos Number", "HIP 79399"},
        {"Celescope Catalog", "CEL 4415"},
        {"Geneva Identification System", "GEN# +1.00145483"},
        {"Smithsonian Astrophysical Observation", "SAO 184217"},
        {"Wilson Evans Batten Catalogue", "WEB 13430"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.06689523),
        dec: Angle.Degrees(-28.41720570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225119"},
        {"Hipparcos Number", "HIP 291"},
        {"Geneva Identification System", "GEN# +1.00225119"},
        {"Geneva Identification System 2", "GEN# +4.09010065"},
        {"Renson", "Renson 61740"},
        {"Smithsonian Astrophysical Observation", "SAO 166023"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.90454413),
        dec: Angle.Degrees(-28.41713516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10041"},
    },
    visualMagnitude: 11.25,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.31755104),
        dec: Angle.Degrees(-28.41700125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66838"},
        {"Hipparcos Number", "HIP 39491"},
        {"Geneva Identification System", "GEN# +1.00066838"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.09185849),
        dec: Angle.Degrees(-28.41662616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109773"},
        {"Hipparcos Number", "HIP 61607"},
        {"Geneva Identification System", "GEN# +1.00109773"},
        {"Smithsonian Astrophysical Observation", "SAO 180962"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.38038282),
        dec: Angle.Degrees(-28.41654274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216471"},
        {"Hipparcos Number", "HIP 113027"},
        {"Smithsonian Astrophysical Observation", "SAO 191469"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.36153704),
        dec: Angle.Degrees(-28.41560107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2038"},
        {"Hipparcos Number", "HIP 1940"},
        {"Smithsonian Astrophysical Observation", "SAO 166244"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.13080063),
        dec: Angle.Degrees(-28.41549847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219087"},
        {"Hipparcos Number", "HIP 114633"},
        {"Smithsonian Astrophysical Observation", "SAO 191733"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.32622985),
        dec: Angle.Degrees(-28.41476511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73963"},
        {"Hipparcos Number", "HIP 42524"},
        {"Smithsonian Astrophysical Observation", "SAO 176265"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.04961214),
        dec: Angle.Degrees(-28.41454252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2289"},
        {"Hipparcos Number", "HIP 2095"},
        {"Smithsonian Astrophysical Observation", "SAO 166270"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.62569161),
        dec: Angle.Degrees(-28.41298203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160043"},
        {"Hipparcos Number", "HIP 86376"},
        {"Geneva Identification System", "GEN# +1.00160043"},
        {"Smithsonian Astrophysical Observation", "SAO 185588"},
        {"Wilson Evans Batten Catalogue", "WEB 14574"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.75296712),
        dec: Angle.Degrees(-28.41237542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168880"},
        {"Hipparcos Number", "HIP 90100"},
        {"Smithsonian Astrophysical Observation", "SAO 186744"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.81109218),
        dec: Angle.Degrees(-28.41208970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58257"},
        {"Hipparcos Number", "HIP 35870"},
        {"Geneva Identification System", "GEN# +1.00058257"},
        {"Renson", "Renson 15870"},
        {"Smithsonian Astrophysical Observation", "SAO 173632"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.92878115),
        dec: Angle.Degrees(-28.41123400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37648",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6324 A"},
        {"Henry Draper", "HD 62576"},
        {"Hipparcos Number", "HIP 37648"},
        {"Geneva Identification System", "GEN# +1.00062576"},
        {"Smithsonian Astrophysical Observation", "SAO 174391"},
        {"Wilson Evans Batten Catalogue", "WEB 7443"},
    },
    visualMagnitude: 4.63,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.88498187),
        dec: Angle.Degrees(-28.41095714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187083"},
        {"Hipparcos Number", "HIP 97505"},
        {"Smithsonian Astrophysical Observation", "SAO 188601"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.27146681),
        dec: Angle.Degrees(-28.41076969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27187"},
        {"Hipparcos Number", "HIP 19926"},
        {"Geneva Identification System", "GEN# +1.00027187"},
        {"Smithsonian Astrophysical Observation", "SAO 169292"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.13149200),
        dec: Angle.Degrees(-28.41055032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155732"},
        {"Hipparcos Number", "HIP 84343"},
        {"Smithsonian Astrophysical Observation", "SAO 185184"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.64958404),
        dec: Angle.Degrees(-28.40924060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66291"},
        {"Hipparcos Number", "HIP 39269"},
        {"Geneva Identification System", "GEN# +1.00066291"},
        {"Smithsonian Astrophysical Observation", "SAO 175017"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.45521334),
        dec: Angle.Degrees(-28.40788691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161247"},
        {"Hipparcos Number", "HIP 86919"},
        {"Geneva Identification System", "GEN# +1.00161247"},
        {"Smithsonian Astrophysical Observation", "SAO 185707"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.40557012),
        dec: Angle.Degrees(-28.40733989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138236"},
        {"Hipparcos Number", "HIP 76034"},
        {"Smithsonian Astrophysical Observation", "SAO 183540"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.93329279),
        dec: Angle.Degrees(-28.40702890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113481"},
        {"Hipparcos Number", "HIP 63783"},
        {"Smithsonian Astrophysical Observation", "SAO 181365"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.10034505),
        dec: Angle.Degrees(-28.40656440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131338"},
        {"Hipparcos Number", "HIP 72883"},
        {"Geneva Identification System", "GEN# +1.00131338"},
        {"Smithsonian Astrophysical Observation", "SAO 182971"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.44487694),
        dec: Angle.Degrees(-28.40564676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47878",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7510 AB"},
        {"Henry Draper", "HD 84566"},
        {"Hipparcos Number", "HIP 47878"},
        {"Smithsonian Astrophysical Observation", "SAO 177941"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.36748975),
        dec: Angle.Degrees(-28.40544486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61049"},
        {"Hipparcos Number", "HIP 36994"},
        {"Smithsonian Astrophysical Observation", "SAO 174102"},
    },
    visualMagnitude: 9.12,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.05992427),
        dec: Angle.Degrees(-28.40523740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117090"},
        {"Hipparcos Number", "HIP 65730"},
        {"Smithsonian Astrophysical Observation", "SAO 181680"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11463711),
        dec: Angle.Degrees(-28.40423572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152286"},
        {"Hipparcos Number", "HIP 82647"},
        {"Geneva Identification System", "GEN# +1.00152286"},
        {"Smithsonian Astrophysical Observation", "SAO 184756"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.40808557),
        dec: Angle.Degrees(-28.40365622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3631"},
        {"Smithsonian Astrophysical Observation", "SAO 166563"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.63126975),
        dec: Angle.Degrees(-28.40170218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103240"},
        {"Hipparcos Number", "HIP 57957"},
        {"Geneva Identification System", "GEN# +1.00103240"},
        {"Smithsonian Astrophysical Observation", "SAO 180266"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.30524428),
        dec: Angle.Degrees(-28.40054794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52356"},
        {"Hipparcos Number", "HIP 33673"},
        {"Celescope Catalog", "CEL 1488"},
        {"Geneva Identification System", "GEN# +1.00052356"},
        {"Smithsonian Astrophysical Observation", "SAO 172706"},
        {"Wilson Evans Batten Catalogue", "WEB 6765"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.93563129),
        dec: Angle.Degrees(-28.39972476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18418"},
        {"Smithsonian Astrophysical Observation", "SAO 168974"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.06656359),
        dec: Angle.Degrees(-28.39963393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83246",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10300 AB"},
        {"Henry Draper", "HD 153483"},
        {"Hipparcos Number", "HIP 83246"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.22546113),
        dec: Angle.Degrees(-28.39917580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27077"},
        {"Hipparcos Number", "HIP 19864"},
        {"Smithsonian Astrophysical Observation", "SAO 169272"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.90073761),
        dec: Angle.Degrees(-28.39590030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225118"},
        {"Hipparcos Number", "HIP 296"},
        {"Geneva Identification System", "GEN# +1.00225118"},
        {"Geneva Identification System 2", "GEN# +4.09010066"},
        {"Smithsonian Astrophysical Observation", "SAO 166024"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.92207847),
        dec: Angle.Degrees(-28.39584776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 280.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81866"},
        {"Hipparcos Number", "HIP 46382"},
        {"Geneva Identification System", "GEN# +1.00081866"},
        {"Smithsonian Astrophysical Observation", "SAO 177478"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.86475336),
        dec: Angle.Degrees(-28.39480332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82941"},
        {"Smithsonian Astrophysical Observation", "SAO 184824"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.23653812),
        dec: Angle.Degrees(-28.39457723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48939"},
        {"Hipparcos Number", "HIP 32317"},
        {"Smithsonian Astrophysical Observation", "SAO 172263"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.20397655),
        dec: Angle.Degrees(-28.39440035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225155"},
        {"Hipparcos Number", "HIP 305"},
        {"Geneva Identification System", "GEN# +1.00225155"},
        {"Geneva Identification System 2", "GEN# +4.09010069"},
        {"Smithsonian Astrophysical Observation", "SAO 166025"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.97206281),
        dec: Angle.Degrees(-28.39376930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75692"},
        {"Hipparcos Number", "HIP 43404"},
        {"Smithsonian Astrophysical Observation", "SAO 176558"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.61784238),
        dec: Angle.Degrees(-28.39007955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219823"},
        {"Hipparcos Number", "HIP 115121"},
        {"Smithsonian Astrophysical Observation", "SAO 191816"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.76368600),
        dec: Angle.Degrees(-28.38787084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169919"},
        {"Hipparcos Number", "HIP 90504"},
        {"Geneva Identification System", "GEN# +1.00169919"},
        {"Smithsonian Astrophysical Observation", "SAO 186842"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.01900320),
        dec: Angle.Degrees(-28.38571241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28626"},
        {"Hipparcos Number", "HIP 20955"},
        {"Smithsonian Astrophysical Observation", "SAO 169504"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.39165621),
        dec: Angle.Degrees(-28.38541374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88401"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.76596045),
        dec: Angle.Degrees(-28.38441256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173900"},
        {"Hipparcos Number", "HIP 92324"},
        {"Smithsonian Astrophysical Observation", "SAO 187309"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.25096259),
        dec: Angle.Degrees(-28.38310123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219466"},
        {"Hipparcos Number", "HIP 114882"},
        {"Smithsonian Astrophysical Observation", "SAO 191774"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.05391980),
        dec: Angle.Degrees(-28.38290796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24980"},
        {"Smithsonian Astrophysical Observation", "SAO 170341"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.23944934),
        dec: Angle.Degrees(-28.38106844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31185"},
        {"Hipparcos Number", "HIP 22666"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.12909506),
        dec: Angle.Degrees(-28.38056346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151347"},
        {"Hipparcos Number", "HIP 82229"},
        {"Geneva Identification System", "GEN# +1.00151347"},
        {"Smithsonian Astrophysical Observation", "SAO 184648"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.99014415),
        dec: Angle.Degrees(-28.38052583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100622"},
        {"Hipparcos Number", "HIP 56460"},
        {"Smithsonian Astrophysical Observation", "SAO 179999"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.64221148),
        dec: Angle.Degrees(-28.38033876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189764"},
        {"Hipparcos Number", "HIP 98693"},
        {"Smithsonian Astrophysical Observation", "SAO 188845"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.68408299),
        dec: Angle.Degrees(-28.37979359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84887"},
        {"Hipparcos Number", "HIP 48047"},
        {"Geneva Identification System", "GEN# +1.00084887"},
        {"Smithsonian Astrophysical Observation", "SAO 178005"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.91806038),
        dec: Angle.Degrees(-28.37978849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27473"},
        {"Smithsonian Astrophysical Observation", "SAO 170872"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.27181312),
        dec: Angle.Degrees(-28.37965627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7629 AB"},
        {"Henry Draper", "HD 87416"},
        {"Hipparcos Number", "HIP 49336"},
        {"Geneva Identification System", "GEN# +1.00087416J"},
        {"Smithsonian Astrophysical Observation", "SAO 178366"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.07424050),
        dec: Angle.Degrees(-28.37871252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12834"},
        {"Hipparcos Number", "HIP 9738"},
        {"Geneva Identification System", "GEN# +1.00012834"},
        {"Smithsonian Astrophysical Observation", "SAO 167541"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.31857002),
        dec: Angle.Degrees(-28.37825942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42456",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6918 A"},
        {"Henry Draper", "HD 73806"},
        {"Hipparcos Number", "HIP 42456"},
        {"Smithsonian Astrophysical Observation", "SAO 176238"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.84681722),
        dec: Angle.Degrees(-28.37769599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94365"},
        {"Hipparcos Number", "HIP 53221"},
        {"Smithsonian Astrophysical Observation", "SAO 179305"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.28939628),
        dec: Angle.Degrees(-28.37742277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183782"},
        {"Hipparcos Number", "HIP 96094"},
        {"Smithsonian Astrophysical Observation", "SAO 188249"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.05863881),
        dec: Angle.Degrees(-28.37525236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51116"},
        {"Hipparcos Number", "HIP 33222"},
        {"Smithsonian Astrophysical Observation", "SAO 172563"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.70000610),
        dec: Angle.Degrees(-28.37487403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82153"},
        {"Smithsonian Astrophysical Observation", "SAO 184631"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.75216647),
        dec: Angle.Degrees(-28.37394140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143520"},
        {"Hipparcos Number", "HIP 78523"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.46476674),
        dec: Angle.Degrees(-28.37392566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65520"},
        {"Geneva Identification System", "GEN# -0.02709225"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.45477509),
        dec: Angle.Degrees(-28.37373355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -451.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14294"},
        {"Hipparcos Number", "HIP 10716"},
        {"Geneva Identification System", "GEN# +1.00014294"},
        {"Smithsonian Astrophysical Observation", "SAO 167688"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.49677711),
        dec: Angle.Degrees(-28.37315937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223761"},
        {"Hipparcos Number", "HIP 117714"},
        {"Smithsonian Astrophysical Observation", "SAO 192209"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.11153742),
        dec: Angle.Degrees(-28.37281639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102171"},
        {"Henry Draper 2", "HD 102172"},
        {"Hipparcos Number", "HIP 57341"},
        {"Smithsonian Astrophysical Observation", "SAO 180163"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.35806113),
        dec: Angle.Degrees(-28.37202463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99057",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13357 AB"},
        {"Henry Draper", "HD 190578"},
        {"Hipparcos Number", "HIP 99057"},
        {"Smithsonian Astrophysical Observation", "SAO 188915"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.66575291),
        dec: Angle.Degrees(-28.37136082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59215"},
        {"Hipparcos Number", "HIP 36246"},
        {"Celescope Catalog", "CEL 1867"},
        {"Geneva Identification System", "GEN# +1.00059215J"},
        {"Smithsonian Astrophysical Observation", "SAO 173793"},
        {"Wilson Evans Batten Catalogue", "WEB 7220"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.95592755),
        dec: Angle.Degrees(-28.37121232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65382",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8886 AB"},
        {"Henry Draper", "HD 116412"},
        {"Hipparcos Number", "HIP 65382"},
        {"Smithsonian Astrophysical Observation", "SAO 181613"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.98878632),
        dec: Angle.Degrees(-28.37073570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36917",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6205 A"},
        {"Henry Draper", "HD 60863"},
        {"Hipparcos Number", "HIP 36917"},
        {"Celescope Catalog", "CEL 1939"},
        {"Geneva Identification System", "GEN# +1.00060863A"},
        {"Smithsonian Astrophysical Observation", "SAO 174058"},
        {"Wilson Evans Batten Catalogue", "WEB 7329"},
    },
    visualMagnitude: 4.65,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.84557180),
        dec: Angle.Degrees(-28.36927798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316514"},
        {"Hipparcos Number", "HIP 87429"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.00017140),
        dec: Angle.Degrees(-28.36913937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18563"},
        {"Hipparcos Number", "HIP 13848"},
        {"Geneva Identification System", "GEN# +1.00018563"},
        {"Smithsonian Astrophysical Observation", "SAO 168194"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.56631282),
        dec: Angle.Degrees(-28.36871523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 315.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9474"},
        {"Hipparcos Number", "HIP 7180"},
        {"Geneva Identification System", "GEN# +1.00009474"},
        {"Smithsonian Astrophysical Observation", "SAO 167124"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.13157224),
        dec: Angle.Degrees(-28.36848862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100071"},
        {"Smithsonian Astrophysical Observation", "SAO 189115"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.53984496),
        dec: Angle.Degrees(-28.36764554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120285"},
        {"Hipparcos Number", "HIP 67419"},
        {"Fundamental Katalog 5th Edition", "FK5 5220"},
        {"Smithsonian Astrophysical Observation", "SAO 181981"},
        {"Wilson Evans Batten Catalogue", "WEB 11855"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.25846060),
        dec: Angle.Degrees(-28.36749079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8819"},
        {"Smithsonian Astrophysical Observation", "SAO 167379"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.34459890),
        dec: Angle.Degrees(-28.36639831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56282"},
        {"Hipparcos Number", "HIP 35079"},
        {"Smithsonian Astrophysical Observation", "SAO 173305"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.82938684),
        dec: Angle.Degrees(-28.36466779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19691"},
        {"Hipparcos Number", "HIP 14652"},
        {"Smithsonian Astrophysical Observation", "SAO 168338"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.33453857),
        dec: Angle.Degrees(-28.36391200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165365"},
        {"Hipparcos Number", "HIP 88720"},
        {"Smithsonian Astrophysical Observation", "SAO 186286"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.69080786),
        dec: Angle.Degrees(-28.36379424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134141"},
        {"Hipparcos Number", "HIP 74149"},
        {"Fundamental Katalog 5th Edition", "FK5 5346"},
        {"Geneva Identification System", "GEN# +1.00134141"},
        {"Smithsonian Astrophysical Observation", "SAO 183215"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.26936507),
        dec: Angle.Degrees(-28.36262094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142457"},
        {"Hipparcos Number", "HIP 78006"},
        {"Geneva Identification System", "GEN# +1.00142457"},
        {"Smithsonian Astrophysical Observation", "SAO 183934"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.93724326),
        dec: Angle.Degrees(-28.36048463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222396"},
        {"Hipparcos Number", "HIP 116791"},
        {"Geneva Identification System", "GEN# +1.00222396"},
        {"Smithsonian Astrophysical Observation", "SAO 192073"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.05693629),
        dec: Angle.Degrees(-28.35896723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157988"},
        {"Hipparcos Number", "HIP 85453"},
        {"Geneva Identification System", "GEN# +1.00157988"},
        {"Smithsonian Astrophysical Observation", "SAO 185420"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.94052572),
        dec: Angle.Degrees(-28.35877469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221505"},
        {"Hipparcos Number", "HIP 116220"},
        {"Smithsonian Astrophysical Observation", "SAO 191983"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.21778869),
        dec: Angle.Degrees(-28.35869083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12806"},
        {"Hipparcos Number", "HIP 9710"},
        {"Smithsonian Astrophysical Observation", "SAO 167538"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.23019962),
        dec: Angle.Degrees(-28.35862198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63547"},
        {"Hipparcos Number", "HIP 38085"},
        {"Geneva Identification System", "GEN# +1.00063547"},
        {"Smithsonian Astrophysical Observation", "SAO 174570"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.07885044),
        dec: Angle.Degrees(-28.35851100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12925"},
        {"Hipparcos Number", "HIP 9789"},
        {"Smithsonian Astrophysical Observation", "SAO 167548"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.47049106),
        dec: Angle.Degrees(-28.35613118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223828"},
        {"Hipparcos Number", "HIP 117767"},
        {"Smithsonian Astrophysical Observation", "SAO 192214"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.24834488),
        dec: Angle.Degrees(-28.35417491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129606"},
        {"Hipparcos Number", "HIP 72035"},
        {"Geneva Identification System", "GEN# +1.00129606"},
        {"Smithsonian Astrophysical Observation", "SAO 182816"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.03225438),
        dec: Angle.Degrees(-28.35285645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48628"},
        {"Hipparcos Number", "HIP 32185"},
        {"Smithsonian Astrophysical Observation", "SAO 172226"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.79124792),
        dec: Angle.Degrees(-28.35274600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105869"},
        {"Smithsonian Astrophysical Observation", "SAO 190338"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.62429752),
        dec: Angle.Degrees(-28.35218813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123906"},
        {"Hipparcos Number", "HIP 69288"},
        {"Geneva Identification System", "GEN# +1.00123906"},
        {"Smithsonian Astrophysical Observation", "SAO 182317"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.74228267),
        dec: Angle.Degrees(-28.35182848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25856"},
        {"Hipparcos Number", "HIP 19041"},
        {"Smithsonian Astrophysical Observation", "SAO 169098"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.18831579),
        dec: Angle.Degrees(-28.34851105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131415"},
        {"Hipparcos Number", "HIP 72930"},
        {"Smithsonian Astrophysical Observation", "SAO 182982"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.58644454),
        dec: Angle.Degrees(-28.34818731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111882",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16149 BC"},
        {"Henry Draper", "HD 214600"},
        {"Hipparcos Number", "HIP 111882"},
        {"Geneva Identification System", "GEN# +1.00214600"},
        {"Smithsonian Astrophysical Observation", "SAO 191309"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.94342866),
        dec: Angle.Degrees(-28.34805438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80201"},
        {"Hipparcos Number", "HIP 45599"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.41587227),
        dec: Angle.Degrees(-28.34668179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171134"},
        {"Hipparcos Number", "HIP 91033"},
        {"Smithsonian Astrophysical Observation", "SAO 186988"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.55337345),
        dec: Angle.Degrees(-28.34586707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20322"},
        {"Hipparcos Number", "HIP 15142"},
        {"Smithsonian Astrophysical Observation", "SAO 168411"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.80555525),
        dec: Angle.Degrees(-28.34500550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26153"},
        {"Smithsonian Astrophysical Observation", "SAO 170572"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.63277101),
        dec: Angle.Degrees(-28.33966256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188112"},
        {"Hipparcos Number", "HIP 97962"},
        {"Geneva Identification System", "GEN# +1.00188112"},
        {"Smithsonian Astrophysical Observation", "SAO 188694"},
    },
    visualMagnitude: 10.22,
    bvColour: -0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.63082374),
        dec: Angle.Degrees(-28.33912683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12540"},
        {"Hipparcos Number", "HIP 9514"},
        {"Smithsonian Astrophysical Observation", "SAO 167509"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.59185476),
        dec: Angle.Degrees(-28.33906589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 827"},
        {"Smithsonian Astrophysical Observation", "SAO 166090"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.52808509),
        dec: Angle.Degrees(-28.33779222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148671"},
        {"Hipparcos Number", "HIP 80868"},
        {"Geneva Identification System", "GEN# +1.00148671A"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.69372716),
        dec: Angle.Degrees(-28.33641585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22413"},
        {"Hipparcos Number", "HIP 16745"},
        {"Geneva Identification System", "GEN# +1.00022413"},
        {"Smithsonian Astrophysical Observation", "SAO 168659"},
        {"Wilson Evans Batten Catalogue", "WEB 3188"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.85265243),
        dec: Angle.Degrees(-28.33627874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148671B"},
        {"Hipparcos Number", "HIP 80870"},
        {"Geneva Identification System", "GEN# +1.00148671B"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.69024010),
        dec: Angle.Degrees(-28.33617641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34295"},
        {"Hipparcos Number", "HIP 24478"},
        {"Geneva Identification System", "GEN# +1.00034295"},
        {"Smithsonian Astrophysical Observation", "SAO 170235"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.79449281),
        dec: Angle.Degrees(-28.33531008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78478",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9874 A"},
        {"Henry Draper", "HD 143402"},
        {"Hipparcos Number", "HIP 78478"},
        {"Smithsonian Astrophysical Observation", "SAO 184025"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.29656648),
        dec: Angle.Degrees(-28.33284679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36482"},
        {"Smithsonian Astrophysical Observation", "SAO 173888"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.60087806),
        dec: Angle.Degrees(-28.33280193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115577"},
        {"Hipparcos Number", "HIP 64920"},
        {"Fundamental Katalog 5th Edition", "FK5 3062"},
        {"Geneva Identification System", "GEN# +1.00115577"},
        {"Smithsonian Astrophysical Observation", "SAO 181536"},
        {"Wilson Evans Batten Catalogue", "WEB 11473"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.59775394),
        dec: Angle.Degrees(-28.33231087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98579"},
        {"Hipparcos Number", "HIP 55374"},
        {"Geneva Identification System", "GEN# +1.00098579"},
        {"Smithsonian Astrophysical Observation", "SAO 179783"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.07937419),
        dec: Angle.Degrees(-28.33224937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 464"},
        {"Hipparcos Number", "HIP 739"},
        {"Geneva Identification System", "GEN# +1.00000464"},
        {"Smithsonian Astrophysical Observation", "SAO 166081"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.26631833),
        dec: Angle.Degrees(-28.33000796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223698"},
        {"Hipparcos Number", "HIP 117676"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.97605808),
        dec: Angle.Degrees(-28.32682503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60369"},
        {"Hipparcos Number", "HIP 36706"},
        {"Celescope Catalog", "CEL 1923"},
        {"Geneva Identification System", "GEN# +1.00060369J"},
        {"Smithsonian Astrophysical Observation", "SAO 173983"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.25769230),
        dec: Angle.Degrees(-28.32581770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111879",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16149 A"},
        {"Henry Draper", "HD 214599"},
        {"Hipparcos Number", "HIP 111879"},
        {"Geneva Identification System", "GEN# +1.00214599"},
        {"Smithsonian Astrophysical Observation", "SAO 191308"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.93383671),
        dec: Angle.Degrees(-28.32556040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77397"},
        {"Hipparcos Number", "HIP 44302"},
        {"Smithsonian Astrophysical Observation", "SAO 176839"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.34051019),
        dec: Angle.Degrees(-28.32457808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172534"},
        {"Hipparcos Number", "HIP 91696"},
        {"Smithsonian Astrophysical Observation", "SAO 187144"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.47573220),
        dec: Angle.Degrees(-28.32446034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209056"},
        {"Hipparcos Number", "HIP 108707"},
        {"Smithsonian Astrophysical Observation", "SAO 190828"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.31094885),
        dec: Angle.Degrees(-28.32437597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110666"},
        {"Hipparcos Number", "HIP 62131"},
        {"Fundamental Katalog 5th Edition", "FK5 479"},
        {"Geneva Identification System", "GEN# +1.00110666"},
        {"Smithsonian Astrophysical Observation", "SAO 181063"},
        {"Wilson Evans Batten Catalogue", "WEB 11042"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.00229297),
        dec: Angle.Degrees(-28.32386102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102528"},
        {"Hipparcos Number", "HIP 57560"},
        {"Renson", "Renson 29570"},
        {"Smithsonian Astrophysical Observation", "SAO 180197"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.97333030),
        dec: Angle.Degrees(-28.32317164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145556"},
        {"Hipparcos Number", "HIP 79437"},
        {"Geneva Identification System", "GEN# +1.00145556"},
        {"Smithsonian Astrophysical Observation", "SAO 184225"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.18150991),
        dec: Angle.Degrees(-28.32168913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67604"},
        {"Hipparcos Number", "HIP 39775"},
        {"Smithsonian Astrophysical Observation", "SAO 175222"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.92865577),
        dec: Angle.Degrees(-28.32129227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54006"},
        {"Hipparcos Number", "HIP 34251"},
    },
    visualMagnitude: 10.27,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.50670223),
        dec: Angle.Degrees(-28.32127282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27526"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.43156112),
        dec: Angle.Degrees(-28.32038696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6485"},
        {"Hipparcos Number", "HIP 5105"},
        {"Smithsonian Astrophysical Observation", "SAO 166789"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.35848719),
        dec: Angle.Degrees(-28.32023518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111607"},
        {"Hipparcos Number", "HIP 62691"},
        {"Smithsonian Astrophysical Observation", "SAO 181150"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.69370278),
        dec: Angle.Degrees(-28.31989115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79202"},
        {"Hipparcos Number", "HIP 45141"},
        {"Smithsonian Astrophysical Observation", "SAO 177098"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.96182049),
        dec: Angle.Degrees(-28.31492483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77537"},
        {"Smithsonian Astrophysical Observation", "SAO 183835"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.47209966),
        dec: Angle.Degrees(-28.31312392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120557"},
        {"Hipparcos Number", "HIP 67568"},
        {"Geneva Identification System", "GEN# +1.00120557"},
        {"Smithsonian Astrophysical Observation", "SAO 182013"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.68981926),
        dec: Angle.Degrees(-28.31174861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150635"},
        {"Hipparcos Number", "HIP 81874"},
        {"Geneva Identification System", "GEN# +1.00150635"},
        {"Smithsonian Astrophysical Observation", "SAO 184574"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.85972810),
        dec: Angle.Degrees(-28.31144401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117343"},
        {"Smithsonian Astrophysical Observation", "SAO 192153"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.89898659),
        dec: Angle.Degrees(-28.31072800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137320"},
        {"Hipparcos Number", "HIP 75563"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.55437549),
        dec: Angle.Degrees(-28.31047614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125734"},
        {"Hipparcos Number", "HIP 70225"},
        {"Geneva Identification System", "GEN# +1.00125734"},
        {"Smithsonian Astrophysical Observation", "SAO 182468"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.50682001),
        dec: Angle.Degrees(-28.30843195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97784"},
        {"Hipparcos Number", "HIP 54916"},
        {"Smithsonian Astrophysical Observation", "SAO 179682"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.69159110),
        dec: Angle.Degrees(-28.30758220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77016"},
        {"Hipparcos Number", "HIP 44091"},
        {"Smithsonian Astrophysical Observation", "SAO 176781"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.71474942),
        dec: Angle.Degrees(-28.30682754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217124"},
        {"Hipparcos Number", "HIP 113459"},
        {"Smithsonian Astrophysical Observation", "SAO 191539"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.66339894),
        dec: Angle.Degrees(-28.30559219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79505"},
        {"Hipparcos Number", "HIP 45280"},
        {"Smithsonian Astrophysical Observation", "SAO 177138"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.42679438),
        dec: Angle.Degrees(-28.30520450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3695"},
        {"Smithsonian Astrophysical Observation", "SAO 166576"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.83600507),
        dec: Angle.Degrees(-28.30238528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142954"},
        {"Hipparcos Number", "HIP 78245"},
        {"Geneva Identification System", "GEN# +1.00142954"},
        {"Smithsonian Astrophysical Observation", "SAO 183980"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.64086158),
        dec: Angle.Degrees(-28.30209026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1094"},
        {"Geneva Identification System", "GEN# +9.80266067"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.41311626),
        dec: Angle.Degrees(-28.30071283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133295"},
        {"Hipparcos Number", "HIP 73754"},
        {"Geneva Identification System", "GEN# +1.00133295"},
        {"Smithsonian Astrophysical Observation", "SAO 183145"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.13772237),
        dec: Angle.Degrees(-28.30004743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35061"},
        {"Smithsonian Astrophysical Observation", "SAO 173293"},
    },
    visualMagnitude: 9.60,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.75307485),
        dec: Angle.Degrees(-28.29968012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110195"},
    },
    visualMagnitude: 12.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.82793801),
        dec: Angle.Degrees(-28.29920008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16632"},
        {"Hipparcos Number", "HIP 12366"},
        {"Smithsonian Astrophysical Observation", "SAO 167954"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.79655653),
        dec: Angle.Degrees(-28.29812244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96942"},
        {"Hipparcos Number", "HIP 54527"},
        {"Smithsonian Astrophysical Observation", "SAO 179591"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.36422660),
        dec: Angle.Degrees(-28.29362043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146775"},
        {"Hipparcos Number", "HIP 79946"},
        {"Geneva Identification System", "GEN# +1.00146775"},
        {"Smithsonian Astrophysical Observation", "SAO 184308"},
        {"Wilson Evans Batten Catalogue", "WEB 13531"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.78499521),
        dec: Angle.Degrees(-28.29326373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210300"},
        {"Hipparcos Number", "HIP 109412"},
        {"Geneva Identification System", "GEN# +1.00210300"},
        {"Smithsonian Astrophysical Observation", "SAO 190930"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.50055511),
        dec: Angle.Degrees(-28.29249314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133585"},
        {"Hipparcos Number", "HIP 73889"},
        {"Geneva Identification System", "GEN# +1.00133585"},
        {"Smithsonian Astrophysical Observation", "SAO 183167"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.52817103),
        dec: Angle.Degrees(-28.29063654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101141"},
        {"Hipparcos Number", "HIP 56762"},
        {"Smithsonian Astrophysical Observation", "SAO 180054"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.55085713),
        dec: Angle.Degrees(-28.29055651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154332"},
        {"Hipparcos Number", "HIP 83657"},
        {"Smithsonian Astrophysical Observation", "SAO 185016"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.47409159),
        dec: Angle.Degrees(-28.28947224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167665"},
        {"Hipparcos Number", "HIP 89620"},
        {"Geneva Identification System", "GEN# +1.00167665"},
        {"Smithsonian Astrophysical Observation", "SAO 186593"},
        {"Wilson Evans Batten Catalogue", "WEB 15265"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.34860342),
        dec: Angle.Degrees(-28.28860655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100604"},
        {"Hipparcos Number", "HIP 56454"},
        {"Geneva Identification System", "GEN# +1.00100604"},
        {"Smithsonian Astrophysical Observation", "SAO 179998"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.63130141),
        dec: Angle.Degrees(-28.28810280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65674"},
        {"Geneva Identification System", "GEN# -0.02709236"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.98476602),
        dec: Angle.Degrees(-28.28764661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -472.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136246"},
        {"Hipparcos Number", "HIP 75077"},
        {"Smithsonian Astrophysical Observation", "SAO 183389"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.13098242),
        dec: Angle.Degrees(-28.28703670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173966"},
        {"Hipparcos Number", "HIP 92356"},
        {"Smithsonian Astrophysical Observation", "SAO 187314"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.34439638),
        dec: Angle.Degrees(-28.28633942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113203"},
        {"Hipparcos Number", "HIP 63623"},
        {"Fundamental Katalog 5th Edition", "FK5 3040"},
        {"Smithsonian Astrophysical Observation", "SAO 181334"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.59451992),
        dec: Angle.Degrees(-28.28632514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56900"},
        {"Hipparcos Number", "HIP 35328"},
        {"Smithsonian Astrophysical Observation", "SAO 173415"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.45139991),
        dec: Angle.Degrees(-28.28626147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71621"},
        {"Hipparcos Number", "HIP 41465"},
        {"Smithsonian Astrophysical Observation", "SAO 175874"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.86912692),
        dec: Angle.Degrees(-28.28516756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53041"},
        {"Hipparcos Number", "HIP 33920"},
        {"Smithsonian Astrophysical Observation", "SAO 172821"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.58410148),
        dec: Angle.Degrees(-28.28150395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173657"},
        {"Hipparcos Number", "HIP 92215"},
        {"Renson", "Renson 48690"},
        {"Smithsonian Astrophysical Observation", "SAO 187286"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.90477425),
        dec: Angle.Degrees(-28.27971489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89851"},
        {"Hipparcos Number", "HIP 50738"},
        {"Smithsonian Astrophysical Observation", "SAO 178727"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.39872462),
        dec: Angle.Degrees(-28.27819357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10255"},
        {"Hipparcos Number", "HIP 7752"},
        {"Geneva Identification System", "GEN# +1.00010255"},
        {"Smithsonian Astrophysical Observation", "SAO 167207"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.94911983),
        dec: Angle.Degrees(-28.27517725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190178"},
        {"Hipparcos Number", "HIP 98883"},
        {"Geneva Identification System", "GEN# +1.00190178"},
        {"Smithsonian Astrophysical Observation", "SAO 188884"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.20611548),
        dec: Angle.Degrees(-28.27376646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2222"},
        {"Hipparcos Number", "HIP 2049"},
        {"Geneva Identification System", "GEN# +1.00002222"},
        {"Smithsonian Astrophysical Observation", "SAO 166264"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.49259608),
        dec: Angle.Degrees(-28.27346916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26731"},
        {"Smithsonian Astrophysical Observation", "SAO 170683"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.19451931),
        dec: Angle.Degrees(-28.27339290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77299"},
        {"Hipparcos Number", "HIP 44267"},
        {"Geneva Identification System", "GEN# +1.00077299"},
        {"Smithsonian Astrophysical Observation", "SAO 176824"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.21705185),
        dec: Angle.Degrees(-28.27335306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106920"},
        {"Hipparcos Number", "HIP 59949"},
        {"Smithsonian Astrophysical Observation", "SAO 180657"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.44598266),
        dec: Angle.Degrees(-28.27132102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202409"},
        {"Hipparcos Number", "HIP 105025"},
        {"Geneva Identification System", "GEN# +1.00202409"},
        {"Smithsonian Astrophysical Observation", "SAO 190183"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.09294314),
        dec: Angle.Degrees(-28.27062467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25394"},
        {"Hipparcos Number", "HIP 18757"},
        {"Smithsonian Astrophysical Observation", "SAO 169035"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.26936036),
        dec: Angle.Degrees(-28.27059410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97072"},
        {"Hipparcos Number", "HIP 54588"},
        {"Geneva Identification System", "GEN# +1.00097072"},
        {"Smithsonian Astrophysical Observation", "SAO 179612"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.57459913),
        dec: Angle.Degrees(-28.27012538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54418"},
        {"Cincinnati Publication", "Ci 20 610"},
        {"Geneva Identification System", "GEN# -0.02707881"},
        {"Smithsonian Astrophysical Observation", "SAO 179566"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.02771153),
        dec: Angle.Degrees(-28.26805532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -503.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3314"},
        {"Hipparcos Number", "HIP 2840"},
        {"Geneva Identification System", "GEN# +1.00003314"},
        {"Smithsonian Astrophysical Observation", "SAO 166398"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.00223973),
        dec: Angle.Degrees(-28.26800678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116691",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16895 AB"},
        {"Henry Draper", "HD 222224"},
        {"Hipparcos Number", "HIP 116691"},
        {"Smithsonian Astrophysical Observation", "SAO 192057"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.71068479),
        dec: Angle.Degrees(-28.26784375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71122"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.15750425),
        dec: Angle.Degrees(-28.26662703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -455.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48112"},
        {"Hipparcos Number", "HIP 31949"},
        {"Geneva Identification System", "GEN# +1.00048112"},
        {"Smithsonian Astrophysical Observation", "SAO 172145"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.14403270),
        dec: Angle.Degrees(-28.26556576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221083"},
        {"Hipparcos Number", "HIP 115916"},
        {"Geneva Identification System", "GEN# +1.00221083"},
        {"Smithsonian Astrophysical Observation", "SAO 191940"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.27692125),
        dec: Angle.Degrees(-28.26389301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194676"},
        {"Hipparcos Number", "HIP 100935"},
        {"Geneva Identification System", "GEN# +1.00194676"},
        {"Smithsonian Astrophysical Observation", "SAO 189308"},
        {"Wilson Evans Batten Catalogue", "WEB 18234"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.97997433),
        dec: Angle.Degrees(-28.26108604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99478"},
        {"Hipparcos Number", "HIP 55832"},
        {"Smithsonian Astrophysical Observation", "SAO 179888"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.64997758),
        dec: Angle.Degrees(-28.26005137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104643"},
        {"Hipparcos Number", "HIP 58759"},
        {"Smithsonian Astrophysical Observation", "SAO 180411"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.75968805),
        dec: Angle.Degrees(-28.25859615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122350"},
        {"Hipparcos Number", "HIP 68550"},
        {"Smithsonian Astrophysical Observation", "SAO 182176"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.49379154),
        dec: Angle.Degrees(-28.25806438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101095"},
        {"Hipparcos Number", "HIP 56733"},
        {"Smithsonian Astrophysical Observation", "SAO 180049"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.48192463),
        dec: Angle.Degrees(-28.25642390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154002"},
        {"Hipparcos Number", "HIP 83505"},
        {"Smithsonian Astrophysical Observation", "SAO 184978"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.99619959),
        dec: Angle.Degrees(-28.25628801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78141"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.33848980),
        dec: Angle.Degrees(+02.23090143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75547"},
        {"Hipparcos Number", "HIP 43334"},
        {"Smithsonian Astrophysical Observation", "SAO 176536"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.42666720),
        dec: Angle.Degrees(-28.25592545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7568"},
        {"Hipparcos Number", "HIP 5869"},
        {"Geneva Identification System", "GEN# +1.00007568"},
        {"Smithsonian Astrophysical Observation", "SAO 166908"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.82782559),
        dec: Angle.Degrees(-28.25535868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166808"},
        {"Hipparcos Number", "HIP 89319"},
        {"Renson", "Renson 46940"},
        {"Smithsonian Astrophysical Observation", "SAO 186486"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.37690607),
        dec: Angle.Degrees(-28.25526112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38241"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.51304269),
        dec: Angle.Degrees(-28.25517921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145793"},
        {"Hipparcos Number", "HIP 79552"},
        {"Smithsonian Astrophysical Observation", "SAO 184244"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.49219969),
        dec: Angle.Degrees(-28.25259952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106373"},
        {"Hipparcos Number", "HIP 59672"},
        {"Geneva Identification System", "GEN# +1.00106373"},
        {"Smithsonian Astrophysical Observation", "SAO 180591"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.55567958),
        dec: Angle.Degrees(-28.25187422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98865"},
        {"Hipparcos Number", "HIP 55542"},
        {"Smithsonian Astrophysical Observation", "SAO 179821"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.64818956),
        dec: Angle.Degrees(-28.24756253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199543"},
        {"Hipparcos Number", "HIP 103547"},
        {"Smithsonian Astrophysical Observation", "SAO 189891"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.68103960),
        dec: Angle.Degrees(-28.24318456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2376"},
        {"Hipparcos Number", "HIP 2169"},
        {"Geneva Identification System", "GEN# +1.00002376"},
        {"Smithsonian Astrophysical Observation", "SAO 166284"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.84233979),
        dec: Angle.Degrees(-28.24314790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82220"},
        {"Hipparcos Number", "HIP 46585"},
        {"Smithsonian Astrophysical Observation", "SAO 177552"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.49266311),
        dec: Angle.Degrees(-28.24298012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117805"},
        {"Hipparcos Number", "HIP 66108"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.27642947),
        dec: Angle.Degrees(-28.24278683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66742",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8990 A"},
        {"Henry Draper", "HD 118959"},
        {"Hipparcos Number", "HIP 66742"},
        {"Smithsonian Astrophysical Observation", "SAO 181852"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.19652154),
        dec: Angle.Degrees(-28.24182305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66739",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8990 C"},
        {"Hipparcos Number", "HIP 66739"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.19161730),
        dec: Angle.Degrees(-28.24104840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217884"},
        {"Hipparcos Number", "HIP 113916"},
        {"Smithsonian Astrophysical Observation", "SAO 191619"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.02884587),
        dec: Angle.Degrees(-28.23815571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45862"},
        {"Hipparcos Number", "HIP 30851"},
        {"Smithsonian Astrophysical Observation", "SAO 171816"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.17832970),
        dec: Angle.Degrees(-28.23749369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91280"},
        {"Hipparcos Number", "HIP 51551"},
        {"Geneva Identification System", "GEN# +1.00091280"},
        {"Smithsonian Astrophysical Observation", "SAO 178938"},
        {"Wilson Evans Batten Catalogue", "WEB 9404"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.95305052),
        dec: Angle.Degrees(-28.23709212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9692"},
        {"Hipparcos Number", "HIP 7330"},
        {"Geneva Identification System", "GEN# +1.00009692"},
        {"Smithsonian Astrophysical Observation", "SAO 167148"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.59759031),
        dec: Angle.Degrees(-28.23663362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166612"},
        {"Henry Draper 2", "HD 166613"},
        {"Hipparcos Number", "HIP 89238"},
        {"Geneva Identification System", "GEN# +1.00166612"},
        {"Smithsonian Astrophysical Observation", "SAO 186461"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.15648015),
        dec: Angle.Degrees(-28.23628508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51088"},
        {"Smithsonian Astrophysical Observation", "SAO 178815"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.56897591),
        dec: Angle.Degrees(-28.23621922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8073"},
        {"Hipparcos Number", "HIP 6222"},
        {"Geneva Identification System", "GEN# +1.00008073"},
        {"Smithsonian Astrophysical Observation", "SAO 166964"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.93905343),
        dec: Angle.Degrees(-28.23372910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30183"},
        {"Hipparcos Number", "HIP 22031"},
        {"Smithsonian Astrophysical Observation", "SAO 169711"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.04487405),
        dec: Angle.Degrees(-28.23267015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121911"},
        {"Hipparcos Number", "HIP 68308"},
        {"Smithsonian Astrophysical Observation", "SAO 182140"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.74729877),
        dec: Angle.Degrees(-28.23264111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11918",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1954 A"},
        {"Henry Draper", "HD 16046"},
        {"Hipparcos Number", "HIP 11918"},
        {"Geneva Identification System", "GEN# +1.00016046A"},
        {"Smithsonian Astrophysical Observation", "SAO 167882"},
        {"Wilson Evans Batten Catalogue", "WEB 2466"},
    },
    visualMagnitude: 4.96,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.46130170),
        dec: Angle.Degrees(-28.23234010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180769"},
        {"Hipparcos Number", "HIP 94914"},
        {"Smithsonian Astrophysical Observation", "SAO 187949"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.71781302),
        dec: Angle.Degrees(-28.23051016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31938"},
        {"Smithsonian Astrophysical Observation", "SAO 172142"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.11171422),
        dec: Angle.Degrees(-28.22729416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38384"},
        {"Hipparcos Number", "HIP 27045"},
        {"Smithsonian Astrophysical Observation", "SAO 170751"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.03263134),
        dec: Angle.Degrees(-28.22703944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82561"},
        {"Hipparcos Number", "HIP 46777"},
        {"Geneva Identification System", "GEN# +1.00082561"},
        {"Smithsonian Astrophysical Observation", "SAO 177613"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.99720528),
        dec: Angle.Degrees(-28.22616595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187536"},
        {"Hipparcos Number", "HIP 97707"},
        {"Geneva Identification System", "GEN# +1.00187536"},
        {"Smithsonian Astrophysical Observation", "SAO 188631"},
        {"Wilson Evans Batten Catalogue", "WEB 17186"},
    },
    visualMagnitude: 9.46,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.85538744),
        dec: Angle.Degrees(-28.22508280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24213"},
        {"Smithsonian Astrophysical Observation", "SAO 170180"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.98998919),
        dec: Angle.Degrees(-28.22347365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34871"},
        {"Smithsonian Astrophysical Observation", "SAO 173217"},
    },
    visualMagnitude: 9.44,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.23122169),
        dec: Angle.Degrees(-28.22215115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14559"},
    },
    visualMagnitude: 11.72,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.99144229),
        dec: Angle.Degrees(-28.22097006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173179"},
        {"Hipparcos Number", "HIP 92004"},
        {"Smithsonian Astrophysical Observation", "SAO 187225"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.28803294),
        dec: Angle.Degrees(-28.22060227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4099"},
    },
    visualMagnitude: 12.13,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.15406667),
        dec: Angle.Degrees(-28.21946104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14555"},
        {"Geneva Identification System", "GEN# -0.02801030"},
    },
    visualMagnitude: 10.21,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.98322257),
        dec: Angle.Degrees(-28.21943517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -339.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61919"},
        {"Hipparcos Number", "HIP 37389"},
        {"Smithsonian Astrophysical Observation", "SAO 174268"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.12587209),
        dec: Angle.Degrees(-28.21926789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13435"},
        {"Hipparcos Number", "HIP 10164"},
        {"Geneva Identification System", "GEN# +1.00013435A"},
        {"Smithsonian Astrophysical Observation", "SAO 167613"},
        {"Wilson Evans Batten Catalogue", "WEB 2121"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.67335990),
        dec: Angle.Degrees(-28.21925054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16297"},
        {"Hipparcos Number", "HIP 12119"},
        {"Geneva Identification System", "GEN# +1.00016297"},
        {"Smithsonian Astrophysical Observation", "SAO 167910"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.03285379),
        dec: Angle.Degrees(-28.21870551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5645"},
        {"Hipparcos Number", "HIP 4508"},
        {"Smithsonian Astrophysical Observation", "SAO 166706"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.45635460),
        dec: Angle.Degrees(-28.21863169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154821"},
        {"Hipparcos Number", "HIP 83900"},
        {"Geneva Identification System", "GEN# +1.00154821"},
        {"Smithsonian Astrophysical Observation", "SAO 185071"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.20603440),
        dec: Angle.Degrees(-28.21698335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76109"},
        {"Smithsonian Astrophysical Observation", "SAO 183555"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.16124464),
        dec: Angle.Degrees(-28.21640552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81266",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Paikauhale"},
        {"Henry Draper", "HD 149438"},
        {"Hipparcos Number", "HIP 81266"},
        {"Fundamental Katalog 5th Edition", "FK5 620"},
        {"Geneva Identification System", "GEN# +1.00149438"},
        {"Smithsonian Astrophysical Observation", "SAO 184481"},
        {"Wilson Evans Batten Catalogue", "WEB 13733"},
    },
    visualMagnitude: 2.82,
    bvColour: -0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.97066423),
        dec: Angle.Degrees(-28.21596156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49723"},
        {"Hipparcos Number", "HIP 32646"},
        {"Smithsonian Astrophysical Observation", "SAO 172357"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.15531229),
        dec: Angle.Degrees(-28.21538076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208464"},
        {"Hipparcos Number", "HIP 108341"},
        {"Smithsonian Astrophysical Observation", "SAO 190763"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.24219610),
        dec: Angle.Degrees(-28.21158345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207252"},
        {"Hipparcos Number", "HIP 107644"},
        {"Smithsonian Astrophysical Observation", "SAO 190636"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.04942950),
        dec: Angle.Degrees(-28.21070370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77719"},
        {"Smithsonian Astrophysical Observation", "SAO 183870"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.00298796),
        dec: Angle.Degrees(-28.21047555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211687"},
        {"Hipparcos Number", "HIP 110198"},
        {"Smithsonian Astrophysical Observation", "SAO 191053"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.83272629),
        dec: Angle.Degrees(-28.20857743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28090"},
        {"Hipparcos Number", "HIP 20607"},
        {"Smithsonian Astrophysical Observation", "SAO 169421"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.21628265),
        dec: Angle.Degrees(-28.20852626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139290"},
        {"Hipparcos Number", "HIP 76567"},
        {"Geneva Identification System", "GEN# +1.00139290"},
        {"Smithsonian Astrophysical Observation", "SAO 183641"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.56583222),
        dec: Angle.Degrees(-28.20660943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78054"},
        {"Smithsonian Astrophysical Observation", "SAO 183943"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.04377659),
        dec: Angle.Degrees(-28.20538163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114049"},
        {"Hipparcos Number", "HIP 64100"},
        {"Smithsonian Astrophysical Observation", "SAO 181401"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.04642001),
        dec: Angle.Degrees(-28.20468720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197426"},
        {"Hipparcos Number", "HIP 102373"},
        {"Fundamental Katalog 5th Edition", "FK5 5825"},
        {"Smithsonian Astrophysical Observation", "SAO 189630"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.14719213),
        dec: Angle.Degrees(-28.20456944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159309"},
        {"Hipparcos Number", "HIP 86052"},
        {"Geneva Identification System", "GEN# +1.00159309"},
        {"Smithsonian Astrophysical Observation", "SAO 185524"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.79334053),
        dec: Angle.Degrees(-28.20362374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177033"},
        {"Hipparcos Number", "HIP 93639"},
        {"Geneva Identification System", "GEN# +1.00177033"},
        {"Smithsonian Astrophysical Observation", "SAO 187627"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.02735730),
        dec: Angle.Degrees(-28.20315000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79895"},
        {"Hipparcos Number", "HIP 45463"},
        {"Smithsonian Astrophysical Observation", "SAO 177182"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.97106706),
        dec: Angle.Degrees(-28.20270910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106046"},
        {"Smithsonian Astrophysical Observation", "SAO 190372"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.19441129),
        dec: Angle.Degrees(-28.20195603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88273"},
        {"Hipparcos Number", "HIP 49822"},
        {"Geneva Identification System", "GEN# +1.00088273"},
        {"Smithsonian Astrophysical Observation", "SAO 178496"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.56039053),
        dec: Angle.Degrees(-28.20110947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42975"},
        {"Geneva Identification System", "GEN# -0.02705879"},
        {"Smithsonian Astrophysical Observation", "SAO 176430"},
    },
    visualMagnitude: 8.98,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.37795370),
        dec: Angle.Degrees(-28.20079214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29813"},
        {"Hipparcos Number", "HIP 21778"},
        {"Geneva Identification System", "GEN# +1.00029813"},
        {"Smithsonian Astrophysical Observation", "SAO 169663"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.17684545),
        dec: Angle.Degrees(-28.20055160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -282.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174494"},
        {"Hipparcos Number", "HIP 92580"},
        {"Geneva Identification System", "GEN# +1.00174494"},
        {"Smithsonian Astrophysical Observation", "SAO 187370"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.97553808),
        dec: Angle.Degrees(-28.20000571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6053",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1047 A"},
        {"Henry Draper", "HD 7848"},
        {"Hipparcos Number", "HIP 6053"},
        {"Geneva Identification System", "GEN# +1.00007848"},
        {"Smithsonian Astrophysical Observation", "SAO 166931"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.42889499),
        dec: Angle.Degrees(-28.19862029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78500"},
        {"Hipparcos Number", "HIP 44802"},
        {"Geneva Identification System", "GEN# +1.00078500"},
        {"Smithsonian Astrophysical Observation", "SAO 176996"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.95283222),
        dec: Angle.Degrees(-28.19786028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7635 AB"},
        {"Henry Draper", "HD 87556"},
        {"Hipparcos Number", "HIP 49411"},
        {"Smithsonian Astrophysical Observation", "SAO 178385"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.30013626),
        dec: Angle.Degrees(-28.19705470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26445"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.40461977),
        dec: Angle.Degrees(+02.31792053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39542"},
        {"Geneva Identification System", "GEN# +2.25270043"},
        {"New General Catalogue", "NGC 2527 43"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.21222084),
        dec: Angle.Degrees(-28.19404312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140104"},
        {"Hipparcos Number", "HIP 76960"},
        {"Smithsonian Astrophysical Observation", "SAO 183721"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.71563515),
        dec: Angle.Degrees(-28.19387841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74645"},
        {"Hipparcos Number", "HIP 42872"},
        {"Geneva Identification System", "GEN# +1.00074645"},
        {"Smithsonian Astrophysical Observation", "SAO 176382"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.04510862),
        dec: Angle.Degrees(-28.19305635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39636"},
        {"Hipparcos Number", "HIP 27771"},
        {"Smithsonian Astrophysical Observation", "SAO 170958"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.15331369),
        dec: Angle.Degrees(-28.19203936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57758"},
        {"Hipparcos Number", "HIP 35660"},
        {"Smithsonian Astrophysical Observation", "SAO 173544"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.36872900),
        dec: Angle.Degrees(-28.19121900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98516"},
        {"Hipparcos Number", "HIP 55328"},
        {"Smithsonian Astrophysical Observation", "SAO 179776"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.94850326),
        dec: Angle.Degrees(-28.18879115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87488"},
        {"Hipparcos Number", "HIP 49375"},
        {"Geneva Identification System", "GEN# +1.00087488"},
        {"Renson", "Renson 25100"},
        {"Smithsonian Astrophysical Observation", "SAO 178378"},
    },
    visualMagnitude: 6.99,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.20431722),
        dec: Angle.Degrees(-28.18871533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163452"},
        {"Hipparcos Number", "HIP 87903"},
        {"Smithsonian Astrophysical Observation", "SAO 185984"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.33939925),
        dec: Angle.Degrees(-28.18823580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58630"},
        {"Hipparcos Number", "HIP 36009"},
        {"Celescope Catalog", "CEL 1839"},
        {"Smithsonian Astrophysical Observation", "SAO 173692"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.31824091),
        dec: Angle.Degrees(-28.18691750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120426"},
        {"Hipparcos Number", "HIP 67496"},
        {"Smithsonian Astrophysical Observation", "SAO 181996"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.47658386),
        dec: Angle.Degrees(-28.18674235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120453"},
        {"Hipparcos Number", "HIP 67502"},
        {"Smithsonian Astrophysical Observation", "SAO 181998"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.49352142),
        dec: Angle.Degrees(-28.18641599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79016"},
        {"Hipparcos Number", "HIP 45051"},
        {"Smithsonian Astrophysical Observation", "SAO 177074"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.63795994),
        dec: Angle.Degrees(-28.18403039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69816"},
        {"Hipparcos Number", "HIP 40642"},
        {"Smithsonian Astrophysical Observation", "SAO 175536"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.45462505),
        dec: Angle.Degrees(-28.18324857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209589"},
        {"Hipparcos Number", "HIP 109021"},
        {"Smithsonian Astrophysical Observation", "SAO 190873"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.29651622),
        dec: Angle.Degrees(-28.18185612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29508"},
        {"Hipparcos Number", "HIP 21548"},
        {"Smithsonian Astrophysical Observation", "SAO 169622"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.40138892),
        dec: Angle.Degrees(-28.18168304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66964"},
        {"Hipparcos Number", "HIP 39545"},
        {"New General Catalogue", "NGC 2527 44"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.21618774),
        dec: Angle.Degrees(-28.18152581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222645"},
        {"Hipparcos Number", "HIP 116964"},
        {"Geneva Identification System", "GEN# +1.00222645"},
        {"Smithsonian Astrophysical Observation", "SAO 192099"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.64555252),
        dec: Angle.Degrees(-28.18115145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172054"},
        {"Hipparcos Number", "HIP 91460"},
        {"Smithsonian Astrophysical Observation", "SAO 187089"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.80728175),
        dec: Angle.Degrees(-28.18064533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15235"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.11003933),
        dec: Angle.Degrees(-28.17996435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73438"},
        {"Hipparcos Number", "HIP 42305"},
        {"Smithsonian Astrophysical Observation", "SAO 176183"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.37998052),
        dec: Angle.Degrees(-28.17851169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172775"},
        {"Hipparcos Number", "HIP 91804"},
        {"Smithsonian Astrophysical Observation", "SAO 187175"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.78510667),
        dec: Angle.Degrees(-28.17496603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115972"},
        {"Hipparcos Number", "HIP 65141"},
        {"Smithsonian Astrophysical Observation", "SAO 181573"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.23352020),
        dec: Angle.Degrees(-28.17210956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34641"},
        {"Hipparcos Number", "HIP 24696"},
        {"Smithsonian Astrophysical Observation", "SAO 170287"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.45000162),
        dec: Angle.Degrees(-28.17155371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315783"},
        {"Hipparcos Number", "HIP 85456"},
        {"Geneva Identification System", "GEN# +1.00315783"},
        {"Smithsonian Astrophysical Observation", "SAO 185421"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.95329298),
        dec: Angle.Degrees(-28.17099162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56044"},
        {"Hipparcos Number", "HIP 34983"},
        {"Celescope Catalog", "CEL 1699"},
        {"Geneva Identification System", "GEN# +1.00056044"},
        {"Smithsonian Astrophysical Observation", "SAO 173268"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.56997017),
        dec: Angle.Degrees(-28.16952441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118215"},
        {"Smithsonian Astrophysical Observation", "SAO 192283"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.69651833),
        dec: Angle.Degrees(-28.16626427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138295"},
        {"Hipparcos Number", "HIP 76068"},
        {"Geneva Identification System", "GEN# +1.00138295"},
        {"Smithsonian Astrophysical Observation", "SAO 183546"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.03171513),
        dec: Angle.Degrees(-28.16618687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2016 A"},
        {"Henry Draper", "HD 16601"},
        {"Hipparcos Number", "HIP 12336"},
        {"Smithsonian Astrophysical Observation", "SAO 167944"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.71706341),
        dec: Angle.Degrees(-28.16603284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72962"},
        {"Smithsonian Astrophysical Observation", "SAO 182988"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.66805197),
        dec: Angle.Degrees(-28.16447564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146236"},
        {"Hipparcos Number", "HIP 79733"},
        {"Geneva Identification System", "GEN# +1.00146236"},
        {"Renson", "Renson 41340"},
        {"Smithsonian Astrophysical Observation", "SAO 184273"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.09135938),
        dec: Angle.Degrees(-28.16398654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12337",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2016 B"},
        {"Hipparcos Number", "HIP 12337"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.71819481),
        dec: Angle.Degrees(-28.16240798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29175"},
        {"Hipparcos Number", "HIP 21309"},
        {"Smithsonian Astrophysical Observation", "SAO 169580"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.62629690),
        dec: Angle.Degrees(-28.15953314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54771"},
        {"Hipparcos Number", "HIP 34507"},
        {"Celescope Catalog", "CEL 1617"},
        {"Geneva Identification System", "GEN# +1.00054771J"},
        {"Smithsonian Astrophysical Observation", "SAO 173073"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.25245324),
        dec: Angle.Degrees(-28.15915917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12282"},
        {"Hipparcos Number", "HIP 9337"},
        {"Smithsonian Astrophysical Observation", "SAO 167472"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.98018997),
        dec: Angle.Degrees(-28.15688381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121035"},
        {"Hipparcos Number", "HIP 67835"},
        {"Geneva Identification System", "GEN# +1.00121035"},
        {"Smithsonian Astrophysical Observation", "SAO 182052"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.42837866),
        dec: Angle.Degrees(-28.15192411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77507"},
        {"Hipparcos Number", "HIP 44366"},
        {"Smithsonian Astrophysical Observation", "SAO 176852"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.52515178),
        dec: Angle.Degrees(-28.15182828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215082"},
        {"Hipparcos Number", "HIP 112176"},
        {"Geneva Identification System", "GEN# +1.00215082"},
        {"Smithsonian Astrophysical Observation", "SAO 191350"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.79559699),
        dec: Angle.Degrees(-28.15131486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17005"},
        {"Hipparcos Number", "HIP 12675"},
        {"Geneva Identification System", "GEN# +1.00017005"},
        {"Smithsonian Astrophysical Observation", "SAO 167996"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.71035729),
        dec: Angle.Degrees(-28.15130538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126037"},
        {"Hipparcos Number", "HIP 70370"},
        {"Smithsonian Astrophysical Observation", "SAO 182496"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.96375392),
        dec: Angle.Degrees(-28.15084323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217123"},
        {"Hipparcos Number", "HIP 113462"},
        {"Geneva Identification System", "GEN# +1.00217123"},
        {"Smithsonian Astrophysical Observation", "SAO 191540"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.66979054),
        dec: Angle.Degrees(-28.14976274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39602",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39602"},
        {"Geneva Identification System", "GEN# +2.25270203"},
        {"New General Catalogue", "NGC 2527 203"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.39132308),
        dec: Angle.Degrees(-28.14955019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3665"},
        {"Hipparcos Number", "HIP 3088"},
        {"Geneva Identification System", "GEN# +1.00003665"},
        {"Smithsonian Astrophysical Observation", "SAO 166455"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.82104042),
        dec: Angle.Degrees(-28.14911778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36941"},
        {"Hipparcos Number", "HIP 26096"},
        {"Smithsonian Astrophysical Observation", "SAO 170562"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.48419002),
        dec: Angle.Degrees(-28.14867659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209970"},
        {"Hipparcos Number", "HIP 109230"},
        {"Geneva Identification System", "GEN# +1.00209970"},
        {"Renson", "Renson 58460"},
        {"Smithsonian Astrophysical Observation", "SAO 190904"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.93459373),
        dec: Angle.Degrees(-28.14760544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213639"},
        {"Hipparcos Number", "HIP 111341"},
        {"Smithsonian Astrophysical Observation", "SAO 191221"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.35507595),
        dec: Angle.Degrees(-28.14754325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174709"},
        {"Hipparcos Number", "HIP 92664"},
        {"Smithsonian Astrophysical Observation", "SAO 187398"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.24370362),
        dec: Angle.Degrees(-28.14520979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82452"},
        {"Hipparcos Number", "HIP 46705"},
        {"Smithsonian Astrophysical Observation", "SAO 177600"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.82742191),
        dec: Angle.Degrees(-28.14440077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35208"},
        {"Hipparcos Number", "HIP 25063"},
        {"Smithsonian Astrophysical Observation", "SAO 170356"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.48731358),
        dec: Angle.Degrees(-28.14407799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157236"},
        {"Hipparcos Number", "HIP 85084"},
        {"Geneva Identification System", "GEN# +1.00157236"},
        {"Smithsonian Astrophysical Observation", "SAO 185350"},
        {"Wilson Evans Batten Catalogue", "WEB 14366"},
    },
    visualMagnitude: 5.30,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.83996212),
        dec: Angle.Degrees(-28.14276032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121081"},
        {"Hipparcos Number", "HIP 67864"},
        {"Geneva Identification System", "GEN# +1.00121081"},
        {"Renson", "Renson 34830"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.50396965),
        dec: Angle.Degrees(-28.14253716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103582"},
        {"Hipparcos Number", "HIP 58150"},
        {"Smithsonian Astrophysical Observation", "SAO 180305"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.88303669),
        dec: Angle.Degrees(-28.14213623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62020"},
        {"Geneva Identification System", "GEN# -0.02708817"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.66903509),
        dec: Angle.Degrees(-28.14145076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93381"},
        {"Hipparcos Number", "HIP 52699"},
        {"Geneva Identification System", "GEN# +1.00093381"},
        {"Smithsonian Astrophysical Observation", "SAO 179212"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.62028781),
        dec: Angle.Degrees(-28.14048076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80480"},
        {"Hipparcos Number", "HIP 45716"},
        {"Smithsonian Astrophysical Observation", "SAO 177272"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.79567477),
        dec: Angle.Degrees(-28.14017689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34474"},
        {"Hipparcos Number", "HIP 24586"},
        {"Smithsonian Astrophysical Observation", "SAO 170262"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.11918362),
        dec: Angle.Degrees(-28.13877570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22582B"},
        {"Hipparcos Number", "HIP 16858"},
    },
    visualMagnitude: 10.93,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.23537711),
        dec: Angle.Degrees(-28.13704401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36655"},
        {"Geneva Identification System", "GEN# -0.02704197"},
        {"Smithsonian Astrophysical Observation", "SAO 173962"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.09250438),
        dec: Angle.Degrees(-28.13529580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76470",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9705 AB"},
        {"Henry Draper", "HD 139063"},
        {"Hipparcos Number", "HIP 76470"},
        {"Fundamental Katalog 5th Edition", "FK5 579"},
        {"Geneva Identification System", "GEN# +1.00139063J"},
        {"Smithsonian Astrophysical Observation", "SAO 183619"},
        {"Wilson Evans Batten Catalogue", "WEB 12981"},
    },
    visualMagnitude: 3.60,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.25607748),
        dec: Angle.Degrees(-28.13507099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316485"},
        {"Hipparcos Number", "HIP 87684"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.64275942),
        dec: Angle.Degrees(-28.13500614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72770"},
        {"Hipparcos Number", "HIP 42009"},
        {"Renson", "Renson 20160"},
        {"Smithsonian Astrophysical Observation", "SAO 176081"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.43341926),
        dec: Angle.Degrees(-28.13453071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92625"},
        {"Hipparcos Number", "HIP 52310"},
        {"Smithsonian Astrophysical Observation", "SAO 179117"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.32643793),
        dec: Angle.Degrees(-28.13412454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213987"},
        {"Hipparcos Number", "HIP 111520"},
        {"Geneva Identification System", "GEN# +1.00213987"},
        {"Smithsonian Astrophysical Observation", "SAO 191248"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.91677955),
        dec: Angle.Degrees(-28.13274320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17838"},
        {"Hipparcos Number", "HIP 13283"},
        {"Smithsonian Astrophysical Observation", "SAO 168096"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.74428377),
        dec: Angle.Degrees(-28.13227921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145573"},
        {"Hipparcos Number", "HIP 79451"},
        {"Geneva Identification System", "GEN# +1.00145573"},
        {"Smithsonian Astrophysical Observation", "SAO 184228"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.21083630),
        dec: Angle.Degrees(-28.13204130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213466"},
        {"Hipparcos Number", "HIP 111218"},
        {"Smithsonian Astrophysical Observation", "SAO 191208"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.99191236),
        dec: Angle.Degrees(-28.13197354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 152"},
        {"Smithsonian Astrophysical Observation", "SAO 192328"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.48445318),
        dec: Angle.Degrees(-28.13095543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70498",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9256 AB"},
        {"Henry Draper", "HD 126279"},
        {"Hipparcos Number", "HIP 70498"},
        {"Smithsonian Astrophysical Observation", "SAO 182524"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.30489814),
        dec: Angle.Degrees(-28.13093765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22582"},
        {"Hipparcos Number", "HIP 16860"},
        {"Geneva Identification System", "GEN# +1.00022582"},
        {"Smithsonian Astrophysical Observation", "SAO 168683"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.24229777),
        dec: Angle.Degrees(-28.13086406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138722"},
        {"Hipparcos Number", "HIP 76275"},
        {"Smithsonian Astrophysical Observation", "SAO 183584"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.69990158),
        dec: Angle.Degrees(-28.13070660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92927",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11828 AB"},
        {"Henry Draper", "HD 175321"},
        {"Hipparcos Number", "HIP 92927"},
        {"Smithsonian Astrophysical Observation", "SAO 187463"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.99502383),
        dec: Angle.Degrees(-28.13021370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117452",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17021 A"},
        {"Henry Draper", "HD 223352"},
        {"Hipparcos Number", "HIP 117452"},
        {"Fundamental Katalog 5th Edition", "FK5 896"},
        {"Geneva Identification System", "GEN# +1.00223352"},
        {"Smithsonian Astrophysical Observation", "SAO 192167"},
        {"Wilson Evans Batten Catalogue", "WEB 20687"},
    },
    visualMagnitude: 4.59,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.23116631),
        dec: Angle.Degrees(-28.13001480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98062"},
        {"Hipparcos Number", "HIP 55075"},
        {"Geneva Identification System", "GEN# +1.00098062"},
        {"Smithsonian Astrophysical Observation", "SAO 179722"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.13527181),
        dec: Angle.Degrees(-28.12977838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67053"},
        {"Hipparcos Number", "HIP 39574"},
        {"Geneva Identification System", "GEN# +2.25270057"},
        {"Smithsonian Astrophysical Observation", "SAO 175141"},
        {"New General Catalogue", "NGC 2527 57"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.29931823),
        dec: Angle.Degrees(-28.12850182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206854"},
        {"Hipparcos Number", "HIP 107425"},
        {"Smithsonian Astrophysical Observation", "SAO 190604"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.37077624),
        dec: Angle.Degrees(-28.12684775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44135"},
        {"Hipparcos Number", "HIP 30001"},
        {"Geneva Identification System", "GEN# +1.00044135"},
        {"Smithsonian Astrophysical Observation", "SAO 171553"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.71908606),
        dec: Angle.Degrees(-28.12281742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158722"},
        {"Hipparcos Number", "HIP 85802"},
        {"Geneva Identification System", "GEN# +1.00158722"},
        {"Smithsonian Astrophysical Observation", "SAO 185480"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.98460338),
        dec: Angle.Degrees(-28.11866227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211570"},
        {"Hipparcos Number", "HIP 110136"},
        {"Smithsonian Astrophysical Observation", "SAO 191040"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.64422513),
        dec: Angle.Degrees(-28.11745189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79569"},
        {"Hipparcos Number", "HIP 45313"},
        {"Smithsonian Astrophysical Observation", "SAO 177149"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.53393811),
        dec: Angle.Degrees(-28.11734103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109036"},
        {"Hipparcos Number", "HIP 61150"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.96378642),
        dec: Angle.Degrees(-28.11697304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175568"},
        {"Hipparcos Number", "HIP 93036"},
        {"Geneva Identification System", "GEN# +1.00175568"},
        {"Smithsonian Astrophysical Observation", "SAO 187489"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.27707056),
        dec: Angle.Degrees(-28.11579474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149048"},
        {"Hipparcos Number", "HIP 81050"},
        {"Smithsonian Astrophysical Observation", "SAO 184457"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.30675038),
        dec: Angle.Degrees(-28.11531321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152400"},
        {"Hipparcos Number", "HIP 82697"},
        {"Geneva Identification System", "GEN# +1.00152400"},
        {"Smithsonian Astrophysical Observation", "SAO 184768"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.56229766),
        dec: Angle.Degrees(-28.11483550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117558"},
        {"Hipparcos Number", "HIP 65969"},
        {"Geneva Identification System", "GEN# +1.00117558"},
        {"Smithsonian Astrophysical Observation", "SAO 181723"},
        {"Wilson Evans Batten Catalogue", "WEB 11667"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.88841442),
        dec: Angle.Degrees(-28.11274555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92227"},
        {"Hipparcos Number", "HIP 52076"},
        {"Smithsonian Astrophysical Observation", "SAO 179062"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.61691807),
        dec: Angle.Degrees(-28.11165796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34784"},
        {"Smithsonian Astrophysical Observation", "SAO 173190"},
    },
    visualMagnitude: 9.55,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.01875569),
        dec: Angle.Degrees(-28.10942499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64756"},
        {"Hipparcos Number", "HIP 38615"},
        {"Geneva Identification System", "GEN# +1.00064756"},
        {"Smithsonian Astrophysical Observation", "SAO 174779"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.60638052),
        dec: Angle.Degrees(-28.10536210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36595"},
        {"Hipparcos Number", "HIP 25894"},
        {"Smithsonian Astrophysical Observation", "SAO 170517"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.91832079),
        dec: Angle.Degrees(-28.10494879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154739"},
        {"Hipparcos Number", "HIP 83859"},
        {"Smithsonian Astrophysical Observation", "SAO 185058"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.07966623),
        dec: Angle.Degrees(-28.10282342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9317"},
        {"Hipparcos Number", "HIP 7084"},
        {"Geneva Identification System", "GEN# +1.00009317"},
        {"Smithsonian Astrophysical Observation", "SAO 167105"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.81447385),
        dec: Angle.Degrees(-28.10016946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152752"},
        {"Hipparcos Number", "HIP 82878"},
        {"Smithsonian Astrophysical Observation", "SAO 184814"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.06715003),
        dec: Angle.Degrees(-28.09940658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49996"},
        {"Hipparcos Number", "HIP 32767"},
        {"Geneva Identification System", "GEN# +1.00049996"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.48198651),
        dec: Angle.Degrees(-28.09928041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203461"},
        {"Hipparcos Number", "HIP 105578"},
        {"Smithsonian Astrophysical Observation", "SAO 190284"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.76313424),
        dec: Angle.Degrees(-28.09896941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36520",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6151 AB"},
        {"Hipparcos Number", "HIP 36520"},
        {"Smithsonian Astrophysical Observation", "SAO 173901"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.69259301),
        dec: Angle.Degrees(-28.09697145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18907"},
        {"Hipparcos Number", "HIP 14086"},
        {"Cincinnati Publication", "Ci 20 202"},
        {"Fundamental Katalog 5th Edition", "FK5 2215"},
        {"Geneva Identification System", "GEN# +1.00018907"},
        {"Smithsonian Astrophysical Observation", "SAO 168238"},
        {"Wilson Evans Batten Catalogue", "WEB 2773"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.40604298),
        dec: Angle.Degrees(-28.09048221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 282.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -440.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79522"},
        {"Hipparcos Number", "HIP 45288"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.44798628),
        dec: Angle.Degrees(-28.09009722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218619"},
        {"Hipparcos Number", "HIP 114366"},
        {"Fundamental Katalog 5th Edition", "FK5 3855"},
        {"Geneva Identification System", "GEN# +1.00218619"},
        {"Smithsonian Astrophysical Observation", "SAO 191686"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.43590830),
        dec: Angle.Degrees(-28.08857609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30422"},
        {"Hipparcos Number", "HIP 22192"},
        {"Fundamental Katalog 5th Edition", "FK5 1132"},
        {"Geneva Identification System", "GEN# +1.00030422"},
        {"Smithsonian Astrophysical Observation", "SAO 169752"},
        {"Wilson Evans Batten Catalogue", "WEB 4270"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.60730189),
        dec: Angle.Degrees(-28.08748820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78146"},
        {"Hipparcos Number", "HIP 44636"},
        {"Geneva Identification System", "GEN# +1.00078146"},
        {"Smithsonian Astrophysical Observation", "SAO 176938"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.43424383),
        dec: Angle.Degrees(-28.08316712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76403"},
        {"Hipparcos Number", "HIP 43782"},
        {"Smithsonian Astrophysical Observation", "SAO 176686"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.76003835),
        dec: Angle.Degrees(-28.08239050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67022"},
        {"Hipparcos Number", "HIP 39569"},
        {"New General Catalogue", "NGC 2527 63"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.27073861),
        dec: Angle.Degrees(-28.08070591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96819"},
        {"Hipparcos Number", "HIP 54477"},
        {"Geneva Identification System", "GEN# +1.00096819"},
        {"Smithsonian Astrophysical Observation", "SAO 179577"},
        {"Wilson Evans Batten Catalogue", "WEB 9834"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.18353198),
        dec: Angle.Degrees(-28.08061647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8781",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1506 AB"},
        {"Henry Draper", "HD 11563"},
        {"Hipparcos Number", "HIP 8781"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)52, 57.3600),
        dec: Angle.DegreesMinutesSeconds((int)-28, (int)04, 50.100)
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
    primaryId: "HIP 13991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18762"},
        {"Hipparcos Number", "HIP 13991"},
        {"Smithsonian Astrophysical Observation", "SAO 168213"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.03963545),
        dec: Angle.Degrees(-28.07974250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30116"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.06564516),
        dec: Angle.Degrees(-28.07549672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195366"},
        {"Hipparcos Number", "HIP 101283"},
        {"Geneva Identification System", "GEN# +1.00195366"},
        {"Smithsonian Astrophysical Observation", "SAO 189392"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.94188987),
        dec: Angle.Degrees(-28.07338295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171238"},
        {"Hipparcos Number", "HIP 91085"},
        {"Geneva Identification System", "GEN# +1.00171238"},
        {"Smithsonian Astrophysical Observation", "SAO 186998"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.68206009),
        dec: Angle.Degrees(-28.07204666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166241"},
        {"Hipparcos Number", "HIP 89088"},
        {"Smithsonian Astrophysical Observation", "SAO 186412"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.73532204),
        dec: Angle.Degrees(-28.07122896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9749"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.34762968),
        dec: Angle.Degrees(-28.07075687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 340.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 422.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92116"},
        {"Hipparcos Number", "HIP 52016"},
        {"Smithsonian Astrophysical Observation", "SAO 179049"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.40414164),
        dec: Angle.Degrees(-28.06878805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26825"},
        {"Smithsonian Astrophysical Observation", "SAO 170704"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.43233576),
        dec: Angle.Degrees(-28.06846788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105814"},
        {"Hipparcos Number", "HIP 59373"},
        {"Smithsonian Astrophysical Observation", "SAO 180541"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.71791295),
        dec: Angle.Degrees(-28.06780686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129195"},
        {"Hipparcos Number", "HIP 71862"},
        {"Smithsonian Astrophysical Observation", "SAO 182775"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.48821249),
        dec: Angle.Degrees(-28.06577195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163318"},
        {"Hipparcos Number", "HIP 87836"},
        {"Geneva Identification System", "GEN# +1.00163318"},
        {"Smithsonian Astrophysical Observation", "SAO 185975"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.17424596),
        dec: Angle.Degrees(-28.06534940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115278"},
        {"Hipparcos Number", "HIP 64772"},
        {"Smithsonian Astrophysical Observation", "SAO 181505"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.11563450),
        dec: Angle.Degrees(-28.06491643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133194"},
        {"Hipparcos Number", "HIP 73710"},
        {"Geneva Identification System", "GEN# +1.00133194"},
        {"Smithsonian Astrophysical Observation", "SAO 183138"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.00814627),
        dec: Angle.Degrees(-28.06150080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77235",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9775 AB"},
        {"Henry Draper", "HD 140722"},
        {"Hipparcos Number", "HIP 77235"},
        {"Geneva Identification System", "GEN# +1.00140722J"},
        {"Renson", "Renson 39987"},
        {"Smithsonian Astrophysical Observation", "SAO 183772"},
        {"Wilson Evans Batten Catalogue", "WEB 13087"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.55372448),
        dec: Angle.Degrees(-28.06142741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41571"},
        {"Hipparcos Number", "HIP 28793"},
        {"Smithsonian Astrophysical Observation", "SAO 171211"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.18029461),
        dec: Angle.Degrees(-28.06074634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132851"},
        {"Hipparcos Number", "HIP 73566"},
        {"Fundamental Katalog 5th Edition", "FK5 3184"},
        {"Geneva Identification System", "GEN# +1.00132851"},
        {"Renson", "Renson 37690"},
        {"Smithsonian Astrophysical Observation", "SAO 183099"},
        {"Wilson Evans Batten Catalogue", "WEB 12583"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.52657921),
        dec: Angle.Degrees(-28.06052808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31115"},
        {"Hipparcos Number", "HIP 22619"},
        {"Smithsonian Astrophysical Observation", "SAO 169827"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.00380354),
        dec: Angle.Degrees(-28.05708361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72870"},
        {"Hipparcos Number", "HIP 42055"},
        {"Smithsonian Astrophysical Observation", "SAO 176096"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.58300777),
        dec: Angle.Degrees(-28.05223495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8985"},
        {"Hipparcos Number", "HIP 6854"},
        {"Geneva Identification System", "GEN# +1.00008985"},
        {"Smithsonian Astrophysical Observation", "SAO 167068"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.03015884),
        dec: Angle.Degrees(-28.05140031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176165"},
        {"Hipparcos Number", "HIP 93277"},
        {"Smithsonian Astrophysical Observation", "SAO 187552"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.00091149),
        dec: Angle.Degrees(-28.05074855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8591"},
        {"Hipparcos Number", "HIP 6566"},
        {"Smithsonian Astrophysical Observation", "SAO 167021"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.09339444),
        dec: Angle.Degrees(-28.04973327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125438"},
        {"Hipparcos Number", "HIP 70050"},
        {"Smithsonian Astrophysical Observation", "SAO 182447"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.03481356),
        dec: Angle.Degrees(-28.04899141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129730"},
        {"Hipparcos Number", "HIP 72102"},
        {"Geneva Identification System", "GEN# +1.00129730"},
        {"Smithsonian Astrophysical Observation", "SAO 182837"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.24451931),
        dec: Angle.Degrees(-28.04788356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209882"},
        {"Hipparcos Number", "HIP 109189"},
        {"Smithsonian Astrophysical Observation", "SAO 190897"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.78914871),
        dec: Angle.Degrees(-28.04771582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138688"},
        {"Hipparcos Number", "HIP 76259"},
        {"Geneva Identification System", "GEN# +1.00138688"},
        {"Smithsonian Astrophysical Observation", "SAO 183580"},
        {"Wilson Evans Batten Catalogue", "WEB 12946"},
    },
    visualMagnitude: 5.13,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.65545605),
        dec: Angle.Degrees(-28.04690734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33472"},
        {"Hipparcos Number", "HIP 23979"},
        {"Smithsonian Astrophysical Observation", "SAO 170124"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.30684457),
        dec: Angle.Degrees(-28.04679622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159881"},
        {"Hipparcos Number", "HIP 86317"},
        {"Geneva Identification System", "GEN# +1.00159881"},
        {"Smithsonian Astrophysical Observation", "SAO 185573"},
        {"Wilson Evans Batten Catalogue", "WEB 14564"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.54997051),
        dec: Angle.Degrees(-28.04672468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220852"},
        {"Hipparcos Number", "HIP 115776"},
        {"Smithsonian Astrophysical Observation", "SAO 191916"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.83199477),
        dec: Angle.Degrees(-28.04523459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222818"},
        {"Hipparcos Number", "HIP 117064"},
        {"Smithsonian Astrophysical Observation", "SAO 192113"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.98796191),
        dec: Angle.Degrees(-28.04429957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146606"},
        {"Hipparcos Number", "HIP 79878"},
        {"Geneva Identification System", "GEN# +1.00146606"},
        {"Smithsonian Astrophysical Observation", "SAO 184300"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.56736243),
        dec: Angle.Degrees(-28.04164667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16214"},
        {"Hipparcos Number", "HIP 12050"},
        {"Smithsonian Astrophysical Observation", "SAO 167894"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.83993819),
        dec: Angle.Degrees(-28.03864425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51482"},
        {"Hipparcos Number", "HIP 33370"},
        {"Smithsonian Astrophysical Observation", "SAO 172602"},
    },
    visualMagnitude: 9.97,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.09555166),
        dec: Angle.Degrees(-28.03841417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218773"},
        {"Hipparcos Number", "HIP 114461"},
        {"Smithsonian Astrophysical Observation", "SAO 191704"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.71589623),
        dec: Angle.Degrees(-28.03686934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99923"},
        {"Hipparcos Number", "HIP 56076"},
        {"Fundamental Katalog 5th Edition", "FK5 1298"},
        {"Geneva Identification System", "GEN# +1.00099923"},
        {"Smithsonian Astrophysical Observation", "SAO 179934"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.40642750),
        dec: Angle.Degrees(-28.03058361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112208"},
        {"Hipparcos Number", "HIP 63059"},
        {"Geneva Identification System", "GEN# +1.00112208"},
        {"Smithsonian Astrophysical Observation", "SAO 181224"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.81063610),
        dec: Angle.Degrees(-28.03016905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19026"},
        {"Hipparcos Number", "HIP 14171"},
        {"Smithsonian Astrophysical Observation", "SAO 168253"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.68406649),
        dec: Angle.Degrees(-28.02576168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209733"},
        {"Hipparcos Number", "HIP 109116"},
        {"Smithsonian Astrophysical Observation", "SAO 190885"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.54359249),
        dec: Angle.Degrees(-28.02460128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128084"},
        {"Hipparcos Number", "HIP 71357"},
        {"Smithsonian Astrophysical Observation", "SAO 182680"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.89237132),
        dec: Angle.Degrees(-28.02446739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198749"},
        {"Hipparcos Number", "HIP 103097"},
        {"Geneva Identification System", "GEN# +1.00198749"},
        {"Smithsonian Astrophysical Observation", "SAO 189806"},
        {"Wilson Evans Batten Catalogue", "WEB 18717"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.33399734),
        dec: Angle.Degrees(-28.02421829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216780"},
        {"Hipparcos Number", "HIP 113253"},
        {"Renson", "Renson 59840"},
        {"Smithsonian Astrophysical Observation", "SAO 191505"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.00933618),
        dec: Angle.Degrees(-28.02376241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316496"},
        {"Hipparcos Number", "HIP 87433"},
    },
    visualMagnitude: 8.58,
    bvColour: 3.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.00302695),
        dec: Angle.Degrees(-28.02237410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82479",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10228 AB"},
        {"Henry Draper", "HD 151904"},
        {"Hipparcos Number", "HIP 82479"},
        {"Smithsonian Astrophysical Observation", "SAO 184714"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.85366053),
        dec: Angle.Degrees(-28.02190826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8677"},
        {"Smithsonian Astrophysical Observation", "SAO 167355"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.91974050),
        dec: Angle.Degrees(-28.01938785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183877"},
        {"Hipparcos Number", "HIP 96124"},
        {"Cincinnati Publication", "Ci 20 1155"},
        {"Geneva Identification System", "GEN# +1.00183877"},
        {"Smithsonian Astrophysical Observation", "SAO 188257"},
        {"Wilson Evans Batten Catalogue", "WEB 16839"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.16785025),
        dec: Angle.Degrees(-28.01798732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -748.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8191"},
    },
    visualMagnitude: 11.75,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.33133948),
        dec: Angle.Degrees(-28.01621743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316285"},
        {"Hipparcos Number", "HIP 87136"},
        {"Geneva Identification System", "GEN# +1.00316285"},
        {"Smithsonian Astrophysical Observation", "SAO 185776"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.05849584),
        dec: Angle.Degrees(-28.01474520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90028"},
        {"Hipparcos Number", "HIP 50839"},
        {"Geneva Identification System", "GEN# +1.00090028"},
        {"Smithsonian Astrophysical Observation", "SAO 178752"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.71450912),
        dec: Angle.Degrees(-28.01358384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212633"},
        {"Hipparcos Number", "HIP 110745"},
        {"Smithsonian Astrophysical Observation", "SAO 191140"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.54420668),
        dec: Angle.Degrees(-28.01251290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217500"},
        {"Hipparcos Number", "HIP 113677"},
        {"Geneva Identification System", "GEN# +1.00217500"},
        {"Smithsonian Astrophysical Observation", "SAO 191583"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.35632097),
        dec: Angle.Degrees(-28.01114089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193978"},
        {"Hipparcos Number", "HIP 100619"},
        {"Smithsonian Astrophysical Observation", "SAO 189238"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.03881144),
        dec: Angle.Degrees(-28.00504870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81395"},
        {"Hipparcos Number", "HIP 46140"},
        {"Geneva Identification System", "GEN# +1.00081395"},
        {"Smithsonian Astrophysical Observation", "SAO 177407"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.13794300),
        dec: Angle.Degrees(-28.00393588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118155",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17132 AB"},
        {"Henry Draper", "HD 224452"},
        {"Hipparcos Number", "HIP 118155"},
        {"Smithsonian Astrophysical Observation", "SAO 192271"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.51019937),
        dec: Angle.Degrees(-28.00015694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45861"},
        {"Hipparcos Number", "HIP 30858"},
        {"Smithsonian Astrophysical Observation", "SAO 171819"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.18959738),
        dec: Angle.Degrees(-28.00009898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181197"},
        {"Hipparcos Number", "HIP 95075"},
        {"Smithsonian Astrophysical Observation", "SAO 187990"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.15365496),
        dec: Angle.Degrees(-27.99939761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48547",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7570 AB"},
        {"Henry Draper", "HD 85860"},
        {"Hipparcos Number", "HIP 48547"},
        {"Smithsonian Astrophysical Observation", "SAO 178157"},
    },
    visualMagnitude: 7.20,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.52144077),
        dec: Angle.Degrees(-27.99900451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194024"},
        {"Hipparcos Number", "HIP 100630"},
        {"Geneva Identification System", "GEN# +1.00194024"},
        {"Smithsonian Astrophysical Observation", "SAO 189242"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.07453953),
        dec: Angle.Degrees(-27.99899907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15739"},
        {"Hipparcos Number", "HIP 11705"},
        {"Smithsonian Astrophysical Observation", "SAO 167847"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.75129173),
        dec: Angle.Degrees(-27.99860017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18426",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2887 AB"},
        {"Henry Draper", "HD 24893"},
        {"Hipparcos Number", "HIP 18426"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.10429560),
        dec: Angle.Degrees(-27.99845992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10143 ABC"},
        {"Henry Draper", "HD 150148"},
        {"Hipparcos Number", "HIP 81619"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.05080642),
        dec: Angle.Degrees(-27.99734401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74815"},
    },
    visualMagnitude: 11.08,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.33844896),
        dec: Angle.Degrees(-27.99716807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42110"},
        {"Smithsonian Astrophysical Observation", "SAO 176122"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.75767804),
        dec: Angle.Degrees(-27.99647757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71703",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9332 AB"},
        {"Henry Draper", "HD 128873"},
        {"Hipparcos Number", "HIP 71703"},
        {"Smithsonian Astrophysical Observation", "SAO 182748"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.01443278),
        dec: Angle.Degrees(-27.99557026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198501"},
        {"Hipparcos Number", "HIP 102959"},
        {"Geneva Identification System", "GEN# +1.00198501"},
        {"Renson", "Renson 55250"},
        {"Smithsonian Astrophysical Observation", "SAO 189777"},
        {"Wilson Evans Batten Catalogue", "WEB 18684"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.90092947),
        dec: Angle.Degrees(-27.99526294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196963"},
        {"Hipparcos Number", "HIP 102108"},
        {"Smithsonian Astrophysical Observation", "SAO 189579"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.38890397),
        dec: Angle.Degrees(-27.99486518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 761",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 111 AB"},
        {"Henry Draper", "HD 493"},
        {"Hipparcos Number", "HIP 761"},
        {"Geneva Identification System", "GEN# +1.00000493"},
        {"Smithsonian Astrophysical Observation", "SAO 166083"},
        {"Wilson Evans Batten Catalogue", "WEB 128"},
    },
    visualMagnitude: 5.42,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.33758620),
        dec: Angle.Degrees(-27.98790390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83547"},
        {"Hipparcos Number", "HIP 47317"},
        {"Smithsonian Astrophysical Observation", "SAO 177781"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.62530551),
        dec: Angle.Degrees(-27.98516990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2948"},
        {"Hipparcos Number", "HIP 2570"},
        {"Smithsonian Astrophysical Observation", "SAO 166343"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.15375422),
        dec: Angle.Degrees(-27.98270046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105575"},
        {"Hipparcos Number", "HIP 59259"},
        {"Geneva Identification System", "GEN# +1.00105575"},
        {"Smithsonian Astrophysical Observation", "SAO 180519"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.33703497),
        dec: Angle.Degrees(-27.98227558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149960"},
        {"Hipparcos Number", "HIP 81521"},
        {"Geneva Identification System", "GEN# +1.00149960"},
        {"Smithsonian Astrophysical Observation", "SAO 184520"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.76859403),
        dec: Angle.Degrees(-27.98226903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196012"},
        {"Hipparcos Number", "HIP 101610"},
        {"Smithsonian Astrophysical Observation", "SAO 189466"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.88831747),
        dec: Angle.Degrees(-27.98201368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64618"},
        {"Hipparcos Number", "HIP 38563"},
        {"Smithsonian Astrophysical Observation", "SAO 174754"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.43356272),
        dec: Angle.Degrees(-27.98123085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167038"},
        {"Hipparcos Number", "HIP 89396"},
        {"Smithsonian Astrophysical Observation", "SAO 186515"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.65270096),
        dec: Angle.Degrees(-27.98040895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151856"},
        {"Hipparcos Number", "HIP 82458"},
        {"Fundamental Katalog 5th Edition", "FK5 5489"},
        {"Geneva Identification System", "GEN# +1.00151856"},
        {"Smithsonian Astrophysical Observation", "SAO 184705"},
        {"Wilson Evans Batten Catalogue", "WEB 13921"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.77312374),
        dec: Angle.Degrees(-27.97990694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50426"},
        {"Hipparcos Number", "HIP 32972"},
        {"Smithsonian Astrophysical Observation", "SAO 172468"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.01952836),
        dec: Angle.Degrees(-27.97930613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60479"},
        {"Hipparcos Number", "HIP 36756"},
        {"Celescope Catalog", "CEL 1930"},
        {"Geneva Identification System", "GEN# +1.00060479"},
        {"Smithsonian Astrophysical Observation", "SAO 174002"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.39301125),
        dec: Angle.Degrees(-27.97731831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84955"},
        {"Hipparcos Number", "HIP 48073"},
        {"Geneva Identification System", "GEN# +1.00084955"},
        {"Smithsonian Astrophysical Observation", "SAO 178011"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.00545720),
        dec: Angle.Degrees(-27.97721299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198355"},
        {"Hipparcos Number", "HIP 102884"},
        {"Smithsonian Astrophysical Observation", "SAO 189758"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.66498233),
        dec: Angle.Degrees(-27.97659966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76977",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9753 A"},
        {"Henry Draper", "HD 140144"},
        {"Hipparcos Number", "HIP 76977"},
        {"Smithsonian Astrophysical Observation", "SAO 183724"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.76623694),
        dec: Angle.Degrees(-27.97646362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137410"},
        {"Hipparcos Number", "HIP 75605"},
        {"Geneva Identification System", "GEN# +1.00137410"},
        {"Smithsonian Astrophysical Observation", "SAO 183473"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.70515870),
        dec: Angle.Degrees(-27.97220488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213665"},
        {"Hipparcos Number", "HIP 111354"},
        {"Smithsonian Astrophysical Observation", "SAO 191224"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.39349553),
        dec: Angle.Degrees(-27.97145946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10493"},
        {"Hipparcos Number", "HIP 7917"},
        {"Smithsonian Astrophysical Observation", "SAO 167236"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.43991112),
        dec: Angle.Degrees(-27.97087779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170209"},
        {"Hipparcos Number", "HIP 90611"},
        {"Geneva Identification System", "GEN# +1.00170209"},
        {"Smithsonian Astrophysical Observation", "SAO 186871"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.34311605),
        dec: Angle.Degrees(-27.97085976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -449.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155867"},
        {"Hipparcos Number", "HIP 84407"},
        {"Geneva Identification System", "GEN# +1.00155867"},
        {"Smithsonian Astrophysical Observation", "SAO 185197"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.84252285),
        dec: Angle.Degrees(-27.97031147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36118"},
        {"Smithsonian Astrophysical Observation", "SAO 173738"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.60194610),
        dec: Angle.Degrees(-27.97005313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23024"},
        {"Hipparcos Number", "HIP 17186"},
        {"Smithsonian Astrophysical Observation", "SAO 168732"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.20538997),
        dec: Angle.Degrees(-27.96967879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54339"},
        {"Geneva Identification System", "GEN# -0.02707867"},
        {"Smithsonian Astrophysical Observation", "SAO 179548"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.73147148),
        dec: Angle.Degrees(-27.96938832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -288.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135931"},
        {"Hipparcos Number", "HIP 74934"},
        {"Smithsonian Astrophysical Observation", "SAO 183360"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.68629926),
        dec: Angle.Degrees(-27.96937678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153352"},
        {"Hipparcos Number", "HIP 83194"},
        {"Geneva Identification System", "GEN# +1.00153352"},
        {"Smithsonian Astrophysical Observation", "SAO 184896"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.03781664),
        dec: Angle.Degrees(-27.96824951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157235"},
        {"Hipparcos Number", "HIP 85081"},
        {"Geneva Identification System", "GEN# +1.00157235"},
        {"Smithsonian Astrophysical Observation", "SAO 185348"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.82361726),
        dec: Angle.Degrees(-27.96693993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48556"},
    },
    visualMagnitude: 10.00,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.53496869),
        dec: Angle.Degrees(-27.96649091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216985"},
        {"Hipparcos Number", "HIP 113377"},
        {"Smithsonian Astrophysical Observation", "SAO 191527"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.42842055),
        dec: Angle.Degrees(-27.96609455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102301"},
        {"Hipparcos Number", "HIP 57421"},
        {"Geneva Identification System", "GEN# +1.00102301"},
        {"Smithsonian Astrophysical Observation", "SAO 180171"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.58801587),
        dec: Angle.Degrees(-27.96354671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83277"},
        {"Hipparcos Number", "HIP 47155"},
        {"Geneva Identification System", "GEN# +1.00083277"},
        {"Smithsonian Astrophysical Observation", "SAO 177740"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.13271443),
        dec: Angle.Degrees(-27.96261205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88752"},
        {"Hipparcos Number", "HIP 50094"},
        {"Smithsonian Astrophysical Observation", "SAO 178547"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.42713871),
        dec: Angle.Degrees(-27.96150122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130694"},
        {"Hipparcos Number", "HIP 72571"},
        {"Geneva Identification System", "GEN# +1.00130694"},
        {"Smithsonian Astrophysical Observation", "SAO 182911"},
        {"Wilson Evans Batten Catalogue", "WEB 12475"},
    },
    visualMagnitude: 4.42,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.57277790),
        dec: Angle.Degrees(-27.96021925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112086"},
        {"Hipparcos Number", "HIP 62978"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.56649120),
        dec: Angle.Degrees(-27.95942317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172440"},
        {"Hipparcos Number", "HIP 91650"},
        {"Smithsonian Astrophysical Observation", "SAO 187132"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.35080294),
        dec: Angle.Degrees(-27.95774889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17980"},
        {"Hipparcos Number", "HIP 13401"},
        {"Geneva Identification System", "GEN# +1.00017980"},
        {"Smithsonian Astrophysical Observation", "SAO 168114"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.13247798),
        dec: Angle.Degrees(-27.95768408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191131"},
        {"Hipparcos Number", "HIP 99290"},
        {"Geneva Identification System", "GEN# +1.00191131"},
        {"Smithsonian Astrophysical Observation", "SAO 188958"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.33491000),
        dec: Angle.Degrees(-27.95561197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57394"},
        {"Hipparcos Number", "HIP 35518"},
        {"Smithsonian Astrophysical Observation", "SAO 173484"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.97090253),
        dec: Angle.Degrees(-27.95456806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1451"},
        {"Hipparcos Number", "HIP 1489"},
        {"Smithsonian Astrophysical Observation", "SAO 166177"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.63318179),
        dec: Angle.Degrees(-27.95196267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136838"},
        {"Hipparcos Number", "HIP 75343"},
        {"Geneva Identification System", "GEN# +1.00136838"},
        {"Smithsonian Astrophysical Observation", "SAO 183430"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.93302303),
        dec: Angle.Degrees(-27.95179681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170499"},
        {"Hipparcos Number", "HIP 90739"},
        {"Smithsonian Astrophysical Observation", "SAO 186903"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.72358685),
        dec: Angle.Degrees(-27.95175051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30216"},
        {"Hipparcos Number", "HIP 22046"},
        {"Geneva Identification System", "GEN# +1.00030216"},
        {"Smithsonian Astrophysical Observation", "SAO 169714"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.12123183),
        dec: Angle.Degrees(-27.94886233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61987"},
        {"Hipparcos Number", "HIP 37399"},
        {"Celescope Catalog", "CEL 1975"},
        {"Geneva Identification System", "GEN# +1.00061987"},
        {"Smithsonian Astrophysical Observation", "SAO 174273"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.18082454),
        dec: Angle.Degrees(-27.94536710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12225"},
        {"Hipparcos Number", "HIP 9298"},
        {"Smithsonian Astrophysical Observation", "SAO 167463"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.86468033),
        dec: Angle.Degrees(-27.94410233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22789"},
        {"Hipparcos Number", "HIP 17007"},
        {"Fundamental Katalog 5th Edition", "FK5 1102"},
        {"Geneva Identification System", "GEN# +1.00022789"},
        {"Smithsonian Astrophysical Observation", "SAO 168701"},
        {"Wilson Evans Batten Catalogue", "WEB 3234"},
    },
    visualMagnitude: 6.01,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.69857269),
        dec: Angle.Degrees(-27.94311708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17729"},
        {"Hipparcos Number", "HIP 13202"},
        {"Geneva Identification System", "GEN# +1.00017729"},
        {"Smithsonian Astrophysical Observation", "SAO 168082"},
        {"Wilson Evans Batten Catalogue", "WEB 2653"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.47562958),
        dec: Angle.Degrees(-27.94203549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46546"},
        {"Hipparcos Number", "HIP 31218"},
        {"Smithsonian Astrophysical Observation", "SAO 171929"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.23017773),
        dec: Angle.Degrees(-27.93978775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208356"},
        {"Hipparcos Number", "HIP 108293"},
        {"Smithsonian Astrophysical Observation", "SAO 190748"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.09459078),
        dec: Angle.Degrees(-27.93689004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2721"},
        {"Hipparcos Number", "HIP 2405"},
        {"Geneva Identification System", "GEN# +1.00002721"},
        {"Smithsonian Astrophysical Observation", "SAO 166323"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.66014086),
        dec: Angle.Degrees(-27.93525051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33856",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Unurgunite"},
        {"Aitken", "ADS 5719 A"},
        {"Henry Draper", "HD 52877"},
        {"Hipparcos Number", "HIP 33856"},
        {"Fundamental Katalog 5th Edition", "FK5 1183"},
        {"Geneva Identification System", "GEN# +5.11210028"},
        {"Smithsonian Astrophysical Observation", "SAO 172797"},
        {"Wilson Evans Batten Catalogue", "WEB 6799"},
    },
    visualMagnitude: 3.49,
    bvColour: 1.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.42979876),
        dec: Angle.Degrees(-27.93484165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107834",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15365 A"},
        {"Henry Draper", "HD 207603"},
        {"Hipparcos Number", "HIP 107834"},
        {"Geneva Identification System", "GEN# +1.00207603"},
        {"Smithsonian Astrophysical Observation", "SAO 190677"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.69277044),
        dec: Angle.Degrees(-27.93236167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198939"},
        {"Hipparcos Number", "HIP 103207"},
        {"Smithsonian Astrophysical Observation", "SAO 189823"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.64967394),
        dec: Angle.Degrees(-27.93051515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21131"},
        {"Hipparcos Number", "HIP 15809"},
        {"Smithsonian Astrophysical Observation", "SAO 168507"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.91537177),
        dec: Angle.Degrees(-27.93000376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70010"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.87501350),
        dec: Angle.Degrees(+02.57567980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29389",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4806 AB"},
        {"Henry Draper", "HD 42815"},
        {"Hipparcos Number", "HIP 29389"},
        {"Smithsonian Astrophysical Observation", "SAO 171364"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.90399492),
        dec: Angle.Degrees(-27.92812749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145482"},
        {"Hipparcos Number", "HIP 79404"},
        {"Celescope Catalog", "CEL 4416"},
        {"Geneva Identification System", "GEN# +1.00145482"},
        {"Smithsonian Astrophysical Observation", "SAO 184221"},
        {"Wilson Evans Batten Catalogue", "WEB 13429"},
    },
    visualMagnitude: 4.58,
    bvColour: -0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.07588221),
        dec: Angle.Degrees(-27.92631564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38716"},
        {"Geneva Identification System", "GEN# +2.24830041"},
        {"New General Catalogue", "NGC 2483 41"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.89767784),
        dec: Angle.Degrees(-27.92573399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198853"},
        {"Hipparcos Number", "HIP 103168"},
        {"Geneva Identification System", "GEN# +1.00198853"},
        {"Smithsonian Astrophysical Observation", "SAO 189815"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.52740209),
        dec: Angle.Degrees(-27.92519765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136445"},
        {"Hipparcos Number", "HIP 75162"},
        {"Geneva Identification System", "GEN# +1.00136445"},
        {"Smithsonian Astrophysical Observation", "SAO 183402"},
        {"Wilson Evans Batten Catalogue", "WEB 12821"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.39351076),
        dec: Angle.Degrees(-27.92320437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217327"},
        {"Hipparcos Number", "HIP 113571"},
        {"Geneva Identification System", "GEN# +1.00217327"},
        {"Smithsonian Astrophysical Observation", "SAO 191560"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.05431501),
        dec: Angle.Degrees(-27.92313721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150923"},
        {"Hipparcos Number", "HIP 82008"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.28677151),
        dec: Angle.Degrees(-27.92244779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21871"},
        {"Hipparcos Number", "HIP 16349"},
        {"Smithsonian Astrophysical Observation", "SAO 168598"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.66768558),
        dec: Angle.Degrees(-27.92228279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23076"},
        {"Hipparcos Number", "HIP 17221"},
        {"Smithsonian Astrophysical Observation", "SAO 168740"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.33421285),
        dec: Angle.Degrees(-27.92225275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126821"},
        {"Hipparcos Number", "HIP 70788"},
        {"Smithsonian Astrophysical Observation", "SAO 182577"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.14364101),
        dec: Angle.Degrees(-27.91961959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100349"},
        {"Hipparcos Number", "HIP 56312"},
        {"Smithsonian Astrophysical Observation", "SAO 179975"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.17453488),
        dec: Angle.Degrees(-27.91842153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93731"},
        {"Hipparcos Number", "HIP 52883"},
        {"Geneva Identification System", "GEN# +1.00093731"},
        {"Renson", "Renson 27110"},
        {"Smithsonian Astrophysical Observation", "SAO 179248"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.24036498),
        dec: Angle.Degrees(-27.91782438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178556"},
        {"Hipparcos Number", "HIP 94166"},
        {"Smithsonian Astrophysical Observation", "SAO 187762"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.53026524),
        dec: Angle.Degrees(-27.91774321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148594"},
        {"Hipparcos Number", "HIP 80819"},
        {"Geneva Identification System", "GEN# +1.00148594"},
        {"Smithsonian Astrophysical Observation", "SAO 184428"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.56534662),
        dec: Angle.Degrees(-27.91621934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197338"},
        {"Hipparcos Number", "HIP 102324"},
        {"Smithsonian Astrophysical Observation", "SAO 189622"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.97873447),
        dec: Angle.Degrees(-27.91428655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101043"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.30358191),
        dec: Angle.Degrees(+02.80241016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29637"},
        {"Hipparcos Number", "HIP 21653"},
        {"Renson", "Renson 7610"},
        {"Smithsonian Astrophysical Observation", "SAO 169637"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.73543291),
        dec: Angle.Degrees(-27.91161764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60195"},
        {"Hipparcos Number", "HIP 36648"},
        {"Celescope Catalog", "CEL 1916"},
        {"Smithsonian Astrophysical Observation", "SAO 173958"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.05448573),
        dec: Angle.Degrees(-27.91035175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115663"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.47112819),
        dec: Angle.Degrees(-27.90938653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63290"},
        {"Hipparcos Number", "HIP 37981"},
        {"Geneva Identification System", "GEN# +1.00063290"},
        {"Smithsonian Astrophysical Observation", "SAO 174532"},
        {"Wilson Evans Batten Catalogue", "WEB 7493"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.77282279),
        dec: Angle.Degrees(-27.90888248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110284"},
        {"Hipparcos Number", "HIP 61908"},
        {"Smithsonian Astrophysical Observation", "SAO 181014"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.30726357),
        dec: Angle.Degrees(-27.90818276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25515"},
        {"Smithsonian Astrophysical Observation", "SAO 170441"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.84761123),
        dec: Angle.Degrees(-27.90803731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224798"},
        {"Hipparcos Number", "HIP 64"},
        {"Smithsonian Astrophysical Observation", "SAO 192314"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.18458893),
        dec: Angle.Degrees(-27.90754614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13847"},
        {"Hipparcos Number", "HIP 10423"},
        {"Geneva Identification System", "GEN# +1.00013847"},
        {"Smithsonian Astrophysical Observation", "SAO 167651"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.58102291),
        dec: Angle.Degrees(-27.90746291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65701"},
        {"Hipparcos Number", "HIP 39001"},
        {"Geneva Identification System", "GEN# +1.00065701"},
        {"Smithsonian Astrophysical Observation", "SAO 174926"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.72244452),
        dec: Angle.Degrees(-27.90707799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41842"},
        {"Hipparcos Number", "HIP 28921"},
        {"Geneva Identification System", "GEN# +1.00041842"},
        {"Smithsonian Astrophysical Observation", "SAO 171235"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.56927375),
        dec: Angle.Degrees(-27.90591232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201744"},
        {"Hipparcos Number", "HIP 104683"},
        {"Smithsonian Astrophysical Observation", "SAO 190118"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.07293840),
        dec: Angle.Degrees(-27.90449971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59410"},
        {"Hipparcos Number", "HIP 36332"},
        {"Smithsonian Astrophysical Observation", "SAO 173828"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.17564050),
        dec: Angle.Degrees(-27.90397552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142333"},
        {"Hipparcos Number", "HIP 77943"},
        {"Smithsonian Astrophysical Observation", "SAO 183919"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.75870403),
        dec: Angle.Degrees(-27.90391805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205153"},
        {"Hipparcos Number", "HIP 106490"},
        {"Geneva Identification System", "GEN# +1.00205153"},
        {"Smithsonian Astrophysical Observation", "SAO 190449"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.53810757),
        dec: Angle.Degrees(-27.90103254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12739",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2092 AB"},
        {"Henry Draper", "HD 17082"},
        {"Hipparcos Number", "HIP 12739"},
        {"Smithsonian Astrophysical Observation", "SAO 168005"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.93864078),
        dec: Angle.Degrees(-27.89934228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38721"},
        {"Geneva Identification System", "GEN# +2.24830008"},
        {"New General Catalogue", "NGC 2483 8"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.91373200),
        dec: Angle.Degrees(-27.89843257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223282"},
        {"Hipparcos Number", "HIP 117404"},
        {"Geneva Identification System", "GEN# +1.00223282"},
        {"Smithsonian Astrophysical Observation", "SAO 192162"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.08842283),
        dec: Angle.Degrees(-27.89731081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144985"},
        {"Hipparcos Number", "HIP 79185"},
        {"Smithsonian Astrophysical Observation", "SAO 184175"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.41955076),
        dec: Angle.Degrees(-27.89450797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18226"},
        {"Hipparcos Number", "HIP 13570"},
        {"Smithsonian Astrophysical Observation", "SAO 168142"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.70688125),
        dec: Angle.Degrees(-27.89411338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205818"},
        {"Hipparcos Number", "HIP 106853"},
        {"Geneva Identification System", "GEN# +1.00205818"},
        {"Smithsonian Astrophysical Observation", "SAO 190513"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.63120762),
        dec: Angle.Degrees(-27.89390371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5424"},
        {"Hipparcos Number", "HIP 4347"},
        {"Geneva Identification System", "GEN# +1.00005424"},
        {"Smithsonian Astrophysical Observation", "SAO 166684"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.93306669),
        dec: Angle.Degrees(-27.89358919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206627"},
        {"Hipparcos Number", "HIP 107305"},
        {"Smithsonian Astrophysical Observation", "SAO 190582"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.00647001),
        dec: Angle.Degrees(-27.89329341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160370"},
        {"Hipparcos Number", "HIP 86507"},
        {"Smithsonian Astrophysical Observation", "SAO 185607"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.17921420),
        dec: Angle.Degrees(-27.89301010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205067"},
        {"Hipparcos Number", "HIP 106438"},
        {"Geneva Identification System", "GEN# +1.00205067"},
        {"Smithsonian Astrophysical Observation", "SAO 190437"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.37853981),
        dec: Angle.Degrees(-27.89010323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22525"},
        {"Hipparcos Number", "HIP 16817"},
        {"Smithsonian Astrophysical Observation", "SAO 168675"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.10467775),
        dec: Angle.Degrees(-27.88849970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40886"},
        {"Hipparcos Number", "HIP 28457"},
        {"Renson", "Renson 10930"},
        {"Smithsonian Astrophysical Observation", "SAO 171122"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.11878179),
        dec: Angle.Degrees(-27.88849150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74003"},
        {"Hipparcos Number", "HIP 42553"},
        {"Smithsonian Astrophysical Observation", "SAO 176270"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.10207279),
        dec: Angle.Degrees(-27.88806660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215049"},
        {"Hipparcos Number", "HIP 112136"},
        {"Geneva Identification System", "GEN# +1.00215049"},
        {"Smithsonian Astrophysical Observation", "SAO 191344"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.71749257),
        dec: Angle.Degrees(-27.88674416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173750"},
        {"Hipparcos Number", "HIP 92257"},
        {"Smithsonian Astrophysical Observation", "SAO 187295"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.01396998),
        dec: Angle.Degrees(-27.88644737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94092"},
        {"Hipparcos Number", "HIP 53054"},
        {"Smithsonian Astrophysical Observation", "SAO 179273"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.81932416),
        dec: Angle.Degrees(-27.88595065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72252"},
        {"Smithsonian Astrophysical Observation", "SAO 182860"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.62527157),
        dec: Angle.Degrees(-27.88510165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160839"},
        {"Hipparcos Number", "HIP 86725"},
        {"Geneva Identification System", "GEN# +1.00160839"},
        {"Renson", "Renson 45305"},
        {"Smithsonian Astrophysical Observation", "SAO 185655"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.82377433),
        dec: Angle.Degrees(-27.88397195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141382"},
        {"Hipparcos Number", "HIP 77531"},
        {"Geneva Identification System", "GEN# +1.00141382"},
        {"Smithsonian Astrophysical Observation", "SAO 183834"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.46368870),
        dec: Angle.Degrees(-27.88165981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56618"},
        {"Hipparcos Number", "HIP 35205"},
        {"Fundamental Katalog 5th Edition", "FK5 2562"},
        {"Geneva Identification System", "GEN# +5.11210044"},
        {"Smithsonian Astrophysical Observation", "SAO 173360"},
        {"Wilson Evans Batten Catalogue", "WEB 7034"},
    },
    visualMagnitude: 4.66,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.14583928),
        dec: Angle.Degrees(-27.88127313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6268"},
        {"Hipparcos Number", "HIP 4933"},
        {"Geneva Identification System", "GEN# +1.00006268"},
        {"Smithsonian Astrophysical Observation", "SAO 166773"},
        {"Wilson Evans Batten Catalogue", "WEB 984"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.82579566),
        dec: Angle.Degrees(-27.88046115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6517"},
        {"Smithsonian Astrophysical Observation", "SAO 167013"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.92280799),
        dec: Angle.Degrees(-27.87620098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25051"},
        {"Hipparcos Number", "HIP 18535"},
        {"Smithsonian Astrophysical Observation", "SAO 168990"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.46647941),
        dec: Angle.Degrees(-27.87231576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37430"},
        {"Hipparcos Number", "HIP 26412"},
        {"Geneva Identification System", "GEN# +1.00037430"},
        {"Smithsonian Astrophysical Observation", "SAO 170601"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.31872154),
        dec: Angle.Degrees(-27.87119898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50741"},
        {"Hipparcos Number", "HIP 33073"},
        {"Smithsonian Astrophysical Observation", "SAO 172515"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.31960041),
        dec: Angle.Degrees(-27.87106005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61468"},
        {"Hipparcos Number", "HIP 37181"},
        {"Renson", "Renson 16860"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.59407865),
        dec: Angle.Degrees(-27.86880166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182180"},
        {"Hipparcos Number", "HIP 95408"},
        {"Geneva Identification System", "GEN# +1.00182180"},
        {"Smithsonian Astrophysical Observation", "SAO 188079"},
        {"Wilson Evans Batten Catalogue", "WEB 16678"},
    },
    visualMagnitude: 6.03,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.12571955),
        dec: Angle.Degrees(-27.86590574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88864",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11084 AB"},
        {"Henry Draper", "HD 165723"},
        {"Hipparcos Number", "HIP 88864"},
    },
    visualMagnitude: 7.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.14494318),
        dec: Angle.Degrees(-27.86417879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2756 AB"},
        {"Henry Draper", "HD 23588"},
        {"Hipparcos Number", "HIP 17544"},
        {"Geneva Identification System", "GEN# +1.00023588J"},
        {"Smithsonian Astrophysical Observation", "SAO 168807"},
        {"Wilson Evans Batten Catalogue", "WEB 3328"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.34967157),
        dec: Angle.Degrees(-27.86282003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 320.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14757"},
        {"Hipparcos Number", "HIP 11030"},
        {"Geneva Identification System", "GEN# +1.00014757"},
        {"Smithsonian Astrophysical Observation", "SAO 167731"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.51066889),
        dec: Angle.Degrees(-27.86144684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60284"},
        {"Hipparcos Number", "HIP 36668"},
        {"Celescope Catalog", "CEL 1918"},
        {"Geneva Identification System", "GEN# +1.00060284J"},
        {"Smithsonian Astrophysical Observation", "SAO 173972"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.15794976),
        dec: Angle.Degrees(-27.86059862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52813"},
        {"Hipparcos Number", "HIP 33844"},
        {"Smithsonian Astrophysical Observation", "SAO 172786"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.38356200),
        dec: Angle.Degrees(-27.85934075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28104"},
    },
    visualMagnitude: 12.25,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.10244032),
        dec: Angle.Degrees(-27.85860680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74895"},
        {"Hipparcos Number", "HIP 43003"},
        {"Smithsonian Astrophysical Observation", "SAO 176440"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.45728358),
        dec: Angle.Degrees(-27.85658224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4569"},
        {"Geneva Identification System", "GEN# -0.02800302"},
    },
    visualMagnitude: 11.77,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.61282693),
        dec: Angle.Degrees(-27.85630511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1293.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -298.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67140",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9012 AB"},
        {"Henry Draper", "HD 119753"},
        {"Hipparcos Number", "HIP 67140"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.39569842),
        dec: Angle.Degrees(-27.85427071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223408"},
        {"Hipparcos Number", "HIP 117481"},
        {"Fundamental Katalog 5th Edition", "FK5 6109"},
        {"Geneva Identification System", "GEN# +1.00223408"},
        {"Smithsonian Astrophysical Observation", "SAO 192174"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.33156347),
        dec: Angle.Degrees(-27.85413264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12943"},
        {"Smithsonian Astrophysical Observation", "SAO 168041"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.61728566),
        dec: Angle.Degrees(-27.85380512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4282"},
        {"Hipparcos Number", "HIP 3529"},
        {"Smithsonian Astrophysical Observation", "SAO 166534"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.25312231),
        dec: Angle.Degrees(-27.85311125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83939"},
        {"Hipparcos Number", "HIP 47500"},
        {"Smithsonian Astrophysical Observation", "SAO 177837"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.26478116),
        dec: Angle.Degrees(-27.85188149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111596"},
        {"Hipparcos Number", "HIP 62684"},
        {"Geneva Identification System", "GEN# +1.00111596"},
        {"Smithsonian Astrophysical Observation", "SAO 181148"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.67292131),
        dec: Angle.Degrees(-27.85003650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70117"},
        {"Hipparcos Number", "HIP 40768"},
        {"Smithsonian Astrophysical Observation", "SAO 175592"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.81554074),
        dec: Angle.Degrees(-27.84922940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28797"},
        {"Hipparcos Number", "HIP 21097"},
        {"Smithsonian Astrophysical Observation", "SAO 169532"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.81070535),
        dec: Angle.Degrees(-27.84479252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182120"},
        {"Hipparcos Number", "HIP 95386"},
        {"Smithsonian Astrophysical Observation", "SAO 188073"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.06092073),
        dec: Angle.Degrees(-27.84475975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160769"},
        {"Hipparcos Number", "HIP 86696"},
        {"Smithsonian Astrophysical Observation", "SAO 185645"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.70824976),
        dec: Angle.Degrees(-27.84392244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108933"},
        {"Hipparcos Number", "HIP 61089"},
        {"Smithsonian Astrophysical Observation", "SAO 180862"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.80797737),
        dec: Angle.Degrees(-27.84379420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73674",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9488 AB"},
        {"Henry Draper", "HD 133131"},
        {"Hipparcos Number", "HIP 73674"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.89876330),
        dec: Angle.Degrees(-27.84065709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112878"},
        {"Hipparcos Number", "HIP 63450"},
        {"Geneva Identification System", "GEN# +1.00112878"},
        {"Smithsonian Astrophysical Observation", "SAO 181299"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.02424825),
        dec: Angle.Degrees(-27.83961807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8638"},
        {"Hipparcos Number", "HIP 6607"},
        {"Geneva Identification System", "GEN# +1.00008638"},
        {"Smithsonian Astrophysical Observation", "SAO 167029"},
        {"Wilson Evans Batten Catalogue", "WEB 1446"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.20414696),
        dec: Angle.Degrees(-27.83837476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 320.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193243"},
        {"Hipparcos Number", "HIP 100263"},
        {"Smithsonian Astrophysical Observation", "SAO 189158"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.04873507),
        dec: Angle.Degrees(-27.83826802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58215"},
        {"Hipparcos Number", "HIP 35848"},
        {"Geneva Identification System", "GEN# +1.00058215J"},
        {"Smithsonian Astrophysical Observation", "SAO 173622"},
        {"Wilson Evans Batten Catalogue", "WEB 7143"},
    },
    visualMagnitude: 5.37,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.87072892),
        dec: Angle.Degrees(-27.83428348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72195"},
        {"Hipparcos Number", "HIP 41735"},
        {"Geneva Identification System", "GEN# +1.00072195"},
        {"Smithsonian Astrophysical Observation", "SAO 175976"},
        {"Wilson Evans Batten Catalogue", "WEB 8043"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.65410207),
        dec: Angle.Degrees(-27.83424760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63759"},
        {"Hipparcos Number", "HIP 38187"},
        {"Geneva Identification System", "GEN# +1.00063759"},
        {"Renson", "Renson 17570"},
        {"Smithsonian Astrophysical Observation", "SAO 174613"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.37218982),
        dec: Angle.Degrees(-27.83394707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122000"},
        {"Hipparcos Number", "HIP 68364"},
        {"Smithsonian Astrophysical Observation", "SAO 182148"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.90828572),
        dec: Angle.Degrees(-27.83387147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174998"},
        {"Hipparcos Number", "HIP 92784"},
        {"Geneva Identification System", "GEN# +1.00174998"},
        {"Smithsonian Astrophysical Observation", "SAO 187430"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.61143735),
        dec: Angle.Degrees(-27.83331337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32180"},
        {"Hipparcos Number", "HIP 23243"},
        {"Smithsonian Astrophysical Observation", "SAO 169961"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.01163504),
        dec: Angle.Degrees(-27.83259791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19545"},
        {"Hipparcos Number", "HIP 14551"},
        {"Geneva Identification System", "GEN# +1.00019545"},
        {"Smithsonian Astrophysical Observation", "SAO 168321"},
        {"Wilson Evans Batten Catalogue", "WEB 2827"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.96168705),
        dec: Angle.Degrees(-27.83110110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161592"},
        {"Hipparcos Number", "HIP 87072"},
        {"Fundamental Katalog 5th Edition", "FK5 1464"},
        {"Geneva Identification System", "GEN# +1.00161592"},
        {"Smithsonian Astrophysical Observation", "SAO 185755"},
        {"Wilson Evans Batten Catalogue", "WEB 14691"},
    },
    visualMagnitude: 4.53,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.89011276),
        dec: Angle.Degrees(-27.83076255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27957"},
        {"Hipparcos Number", "HIP 20506"},
        {"Smithsonian Astrophysical Observation", "SAO 169405"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.91834776),
        dec: Angle.Degrees(-27.83041708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2861"},
        {"Hipparcos Number", "HIP 2511"},
        {"Geneva Identification System", "GEN# +1.00002861"},
        {"Smithsonian Astrophysical Observation", "SAO 166335"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.96261887),
        dec: Angle.Degrees(-27.82839734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116212"},
        {"Hipparcos Number", "HIP 65264"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.62293824),
        dec: Angle.Degrees(-27.82757298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164562"},
        {"Hipparcos Number", "HIP 88384"},
        {"Smithsonian Astrophysical Observation", "SAO 186161"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.72623582),
        dec: Angle.Degrees(-27.82666167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70889"},
        {"Hipparcos Number", "HIP 41134"},
        {"Geneva Identification System", "GEN# +1.00070889"},
        {"Smithsonian Astrophysical Observation", "SAO 175729"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.88289900),
        dec: Angle.Degrees(-27.82226926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125968"},
        {"Hipparcos Number", "HIP 70330"},
        {"Geneva Identification System", "GEN# +1.00125968"},
        {"Smithsonian Astrophysical Observation", "SAO 182489"},
        {"Wilson Evans Batten Catalogue", "WEB 12209"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.84810256),
        dec: Angle.Degrees(-27.82203460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16624"},
        {"Hipparcos Number", "HIP 12358"},
        {"Smithsonian Astrophysical Observation", "SAO 167951"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.77270624),
        dec: Angle.Degrees(-27.82161970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94740"},
        {"Hipparcos Number", "HIP 53434"},
        {"Smithsonian Astrophysical Observation", "SAO 179347"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.96505339),
        dec: Angle.Degrees(-27.82041798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147935"},
        {"Hipparcos Number", "HIP 80491"},
        {"Geneva Identification System", "GEN# +1.00147935"},
        {"Smithsonian Astrophysical Observation", "SAO 184385"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.45517093),
        dec: Angle.Degrees(-27.81914746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9888",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1665 AB"},
        {"Henry Draper", "HD 13064"},
        {"Hipparcos Number", "HIP 9888"},
        {"Smithsonian Astrophysical Observation", "SAO 167563"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.80246451),
        dec: Angle.Degrees(-27.81873209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77137"},
        {"Hipparcos Number", "HIP 44164"},
        {"Geneva Identification System", "GEN# +1.00077137"},
        {"Smithsonian Astrophysical Observation", "SAO 176805"},
        {"Wilson Evans Batten Catalogue", "WEB 8483"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.92812912),
        dec: Angle.Degrees(-27.81619461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77506"},
        {"Hipparcos Number", "HIP 44364"},
        {"Geneva Identification System", "GEN# +1.00077506"},
        {"Smithsonian Astrophysical Observation", "SAO 176851"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.52166508),
        dec: Angle.Degrees(-27.81394742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 892"},
        {"Hipparcos Number", "HIP 1056"},
        {"Geneva Identification System", "GEN# +1.00000892"},
        {"Smithsonian Astrophysical Observation", "SAO 166123"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.28971078),
        dec: Angle.Degrees(-27.81349246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55119"},
        {"Geneva Identification System", "GEN# -0.02707978"},
        {"Smithsonian Astrophysical Observation", "SAO 179740"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.28071594),
        dec: Angle.Degrees(-27.81334682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114845",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16629 AB"},
        {"Henry Draper", "HD 219408"},
        {"Hipparcos Number", "HIP 114845"},
        {"Smithsonian Astrophysical Observation", "SAO 191767"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.94483463),
        dec: Angle.Degrees(-27.81162217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190286"},
        {"Hipparcos Number", "HIP 98933"},
        {"Smithsonian Astrophysical Observation", "SAO 188894"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.32357349),
        dec: Angle.Degrees(-27.81157568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26389"},
        {"Hipparcos Number", "HIP 19407"},
        {"Geneva Identification System", "GEN# +1.00026389"},
        {"Smithsonian Astrophysical Observation", "SAO 169177"},
        {"Wilson Evans Batten Catalogue", "WEB 3728"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.34816089),
        dec: Angle.Degrees(-27.80987340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150367"},
        {"Hipparcos Number", "HIP 81731"},
        {"Smithsonian Astrophysical Observation", "SAO 184547"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.40645565),
        dec: Angle.Degrees(-27.80958310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118042"},
        {"Smithsonian Astrophysical Observation", "SAO 192258"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.15141263),
        dec: Angle.Degrees(-27.80955514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104001"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.06174972),
        dec: Angle.Degrees(-27.80679380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74495"},
        {"Hipparcos Number", "HIP 42813"},
        {"Smithsonian Astrophysical Observation", "SAO 176358"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.85519438),
        dec: Angle.Degrees(-27.80475599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24954"},
        {"Smithsonian Astrophysical Observation", "SAO 170334"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.16907903),
        dec: Angle.Degrees(-27.80466102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200007"},
        {"Hipparcos Number", "HIP 103759"},
        {"Smithsonian Astrophysical Observation", "SAO 189941"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.38678103),
        dec: Angle.Degrees(-27.80337029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82146"},
        {"Hipparcos Number", "HIP 46541"},
        {"Smithsonian Astrophysical Observation", "SAO 177533"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.37979489),
        dec: Angle.Degrees(-27.80158550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52463"},
        {"Hipparcos Number", "HIP 33708"},
        {"Celescope Catalog", "CEL 1496"},
        {"Geneva Identification System", "GEN# +1.00052463"},
        {"Smithsonian Astrophysical Observation", "SAO 172727"},
        {"Wilson Evans Batten Catalogue", "WEB 6772"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.05112970),
        dec: Angle.Degrees(-27.79995311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 720"},
        {"Hipparcos Number", "HIP 930"},
        {"Fundamental Katalog 5th Edition", "FK5 5"},
        {"Geneva Identification System", "GEN# +1.00000720"},
        {"Smithsonian Astrophysical Observation", "SAO 166103"},
        {"Wilson Evans Batten Catalogue", "WEB 166"},
    },
    visualMagnitude: 5.41,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.89340430),
        dec: Angle.Degrees(-27.79977820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169496"},
        {"Hipparcos Number", "HIP 90348"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.52185233),
        dec: Angle.Degrees(-27.79743523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155650"},
        {"Hipparcos Number", "HIP 84297"},
        {"Geneva Identification System", "GEN# +1.00155650"},
        {"Smithsonian Astrophysical Observation", "SAO 185175"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.50842906),
        dec: Angle.Degrees(-27.79655885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153421"},
        {"Hipparcos Number", "HIP 83239"},
        {"Geneva Identification System", "GEN# +1.00153421"},
        {"Smithsonian Astrophysical Observation", "SAO 184907"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.16842090),
        dec: Angle.Degrees(-27.79232732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15847"},
        {"Hipparcos Number", "HIP 11800"},
        {"Smithsonian Astrophysical Observation", "SAO 167860"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.05587171),
        dec: Angle.Degrees(-27.78974329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 798"},
        {"Hipparcos Number", "HIP 985"},
        {"Geneva Identification System", "GEN# +1.00000798"},
        {"Smithsonian Astrophysical Observation", "SAO 166109"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.05385165),
        dec: Angle.Degrees(-27.78455628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165787"},
        {"Hipparcos Number", "HIP 88906"},
        {"Smithsonian Astrophysical Observation", "SAO 186349"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22569762),
        dec: Angle.Degrees(-27.78365700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316948"},
        {"Hipparcos Number", "HIP 88354"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.63859446),
        dec: Angle.Degrees(-27.77958869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7059"},
        {"Hipparcos Number", "HIP 5509"},
        {"Geneva Identification System", "GEN# +1.00007059"},
        {"Smithsonian Astrophysical Observation", "SAO 166851"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.63640128),
        dec: Angle.Degrees(-27.77857076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315726"},
        {"Hipparcos Number", "HIP 85215"},
        {"Smithsonian Astrophysical Observation", "SAO 185366"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.19072751),
        dec: Angle.Degrees(-27.77853984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1196"},
        {"Hipparcos Number", "HIP 1290"},
        {"Geneva Identification System", "GEN# +1.00001196"},
        {"Smithsonian Astrophysical Observation", "SAO 166159"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.04350921),
        dec: Angle.Degrees(-27.77814247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45773"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.99649847),
        dec: Angle.Degrees(-27.77760083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80589"},
        {"Hipparcos Number", "HIP 45769"},
        {"Smithsonian Astrophysical Observation", "SAO 177288"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.99306740),
        dec: Angle.Degrees(-27.77642578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5445"},
        {"Hipparcos Number", "HIP 4363"},
        {"Geneva Identification System", "GEN# +1.00005445"},
        {"Smithsonian Astrophysical Observation", "SAO 166686"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.98137347),
        dec: Angle.Degrees(-27.77582706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11174"},
        {"Hipparcos Number", "HIP 8484"},
        {"Smithsonian Astrophysical Observation", "SAO 167323"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.34224572),
        dec: Angle.Degrees(-27.77430537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52617"},
        {"Hipparcos Number", "HIP 33771"},
        {"Smithsonian Astrophysical Observation", "SAO 172755"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.19846911),
        dec: Angle.Degrees(-27.77390591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317479"},
        {"Hipparcos Number", "HIP 90154"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.96338670),
        dec: Angle.Degrees(-27.77130601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129525"},
        {"Hipparcos Number", "HIP 72011"},
        {"Smithsonian Astrophysical Observation", "SAO 182804"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.92308244),
        dec: Angle.Degrees(-27.77083614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46189"},
        {"Hipparcos Number", "HIP 31037"},
        {"Fundamental Katalog 5th Edition", "FK5 2499"},
        {"Geneva Identification System", "GEN# +1.00046189"},
        {"Smithsonian Astrophysical Observation", "SAO 171866"},
        {"Wilson Evans Batten Catalogue", "WEB 6180"},
    },
    visualMagnitude: 5.92,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.69288857),
        dec: Angle.Degrees(-27.76958910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84367"},
        {"Hipparcos Number", "HIP 47758"},
        {"Fundamental Katalog 5th Edition", "FK5 366"},
        {"Geneva Identification System", "GEN# +1.00084367J"},
        {"Smithsonian Astrophysical Observation", "SAO 177908"},
        {"Wilson Evans Batten Catalogue", "WEB 8945"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.05054261),
        dec: Angle.Degrees(-27.76956287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4289"},
        {"Hipparcos Number", "HIP 3538"},
        {"Geneva Identification System", "GEN# +1.00004289"},
        {"Smithsonian Astrophysical Observation", "SAO 166536"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.29253875),
        dec: Angle.Degrees(-27.76771296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210934"},
        {"Hipparcos Number", "HIP 109789"},
        {"Fundamental Katalog 5th Edition", "FK5 838"},
        {"Geneva Identification System", "GEN# +1.00210934"},
        {"Smithsonian Astrophysical Observation", "SAO 190985"},
        {"Wilson Evans Batten Catalogue", "WEB 19719"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.57806796),
        dec: Angle.Degrees(-27.76691218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156212"},
        {"Hipparcos Number", "HIP 84588"},
        {"Fundamental Katalog 5th Edition", "FK5 5526"},
        {"Geneva Identification System", "GEN# +1.00156212"},
        {"Smithsonian Astrophysical Observation", "SAO 185228"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.36498953),
        dec: Angle.Degrees(-27.76689010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75145"},
        {"Hipparcos Number", "HIP 43149"},
        {"Smithsonian Astrophysical Observation", "SAO 176467"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.83337403),
        dec: Angle.Degrees(-27.76628386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93491"},
        {"Hipparcos Number", "HIP 52756"},
        {"Geneva Identification System", "GEN# +1.00093491"},
        {"Smithsonian Astrophysical Observation", "SAO 179225"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.80707227),
        dec: Angle.Degrees(-27.76488196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105041"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.14687994),
        dec: Angle.Degrees(-27.76472365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40420"},
        {"Hipparcos Number", "HIP 28191"},
        {"Geneva Identification System", "GEN# +1.00040420"},
        {"Smithsonian Astrophysical Observation", "SAO 171069"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.36810268),
        dec: Angle.Degrees(-27.76460955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316189"},
        {"Hipparcos Number", "HIP 86803"},
        {"Geneva Identification System", "GEN# +1.00316189"},
        {"Smithsonian Astrophysical Observation", "SAO 185673"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.06314444),
        dec: Angle.Degrees(-27.76333500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69120"},
        {"Hipparcos Number", "HIP 40373"},
        {"Geneva Identification System", "GEN# +1.00069120"},
        {"Smithsonian Astrophysical Observation", "SAO 175438"},
    },
    visualMagnitude: 8.58,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.64025409),
        dec: Angle.Degrees(-27.76299359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155401"},
        {"Hipparcos Number", "HIP 84175"},
        {"Geneva Identification System", "GEN# +1.00155401"},
        {"Smithsonian Astrophysical Observation", "SAO 185142"},
        {"Wilson Evans Batten Catalogue", "WEB 14215"},
    },
    visualMagnitude: 6.12,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.10444671),
        dec: Angle.Degrees(-27.76200634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107711"},
        {"Hipparcos Number", "HIP 60369"},
        {"Smithsonian Astrophysical Observation", "SAO 180736"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.67857488),
        dec: Angle.Degrees(-27.76197657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124502"},
        {"Hipparcos Number", "HIP 69596"},
        {"Geneva Identification System", "GEN# +1.00124502"},
        {"Smithsonian Astrophysical Observation", "SAO 182368"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.67468897),
        dec: Angle.Degrees(-27.76175915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50917"},
        {"Hipparcos Number", "HIP 33137"},
        {"Smithsonian Astrophysical Observation", "SAO 172541"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.50706246),
        dec: Angle.Degrees(-27.76005475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216896"},
        {"Hipparcos Number", "HIP 113339"},
        {"Smithsonian Astrophysical Observation", "SAO 191517"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.29168700),
        dec: Angle.Degrees(-27.75977598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99801"},
        {"Hipparcos Number", "HIP 56013"},
        {"Smithsonian Astrophysical Observation", "SAO 179920"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.18815048),
        dec: Angle.Degrees(-27.75846208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111489"},
        {"Hipparcos Number", "HIP 62625"},
        {"Smithsonian Astrophysical Observation", "SAO 181140"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.48260007),
        dec: Angle.Degrees(-27.75751197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54521"},
        {"Hipparcos Number", "HIP 34409"},
        {"Smithsonian Astrophysical Observation", "SAO 173034"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.00753509),
        dec: Angle.Degrees(-27.75694566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75950"},
        {"Hipparcos Number", "HIP 43562"},
        {"Smithsonian Astrophysical Observation", "SAO 176607"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.07357504),
        dec: Angle.Degrees(-27.75659394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1496 AB"},
        {"Henry Draper", "HD 11469"},
        {"Hipparcos Number", "HIP 8723"},
        {"Smithsonian Astrophysical Observation", "SAO 167360"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.05613788),
        dec: Angle.Degrees(-27.75594336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125932"},
        {"Hipparcos Number", "HIP 70306"},
        {"Geneva Identification System", "GEN# +1.00125932"},
        {"Smithsonian Astrophysical Observation", "SAO 182483"},
        {"Wilson Evans Batten Catalogue", "WEB 12206"},
    },
    visualMagnitude: 4.78,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.77461567),
        dec: Angle.Degrees(-27.75373395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78561"},
        {"Hipparcos Number", "HIP 44826"},
        {"Smithsonian Astrophysical Observation", "SAO 177006"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.02141780),
        dec: Angle.Degrees(-27.75340456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34400"},
        {"Smithsonian Astrophysical Observation", "SAO 173030"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.98693297),
        dec: Angle.Degrees(-27.75210952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207175"},
        {"Hipparcos Number", "HIP 107601"},
        {"Smithsonian Astrophysical Observation", "SAO 190629"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.92055765),
        dec: Angle.Degrees(-27.75087972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43056"},
        {"Hipparcos Number", "HIP 29495"},
        {"Geneva Identification System", "GEN# +1.00043056"},
        {"Smithsonian Astrophysical Observation", "SAO 171401"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.22889256),
        dec: Angle.Degrees(-27.73501929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102641",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14288 A"},
        {"Henry Draper", "HD 197956"},
        {"Hipparcos Number", "HIP 102641"},
        {"Smithsonian Astrophysical Observation", "SAO 189701"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.97003297),
        dec: Angle.Degrees(-27.75030492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108110"},
        {"Hipparcos Number", "HIP 60603"},
        {"Fundamental Katalog 5th Edition", "FK5 1319"},
        {"Geneva Identification System", "GEN# +1.00108110"},
        {"Smithsonian Astrophysical Observation", "SAO 180786"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.32670513),
        dec: Angle.Degrees(-27.74899915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152501"},
        {"Hipparcos Number", "HIP 82754"},
        {"Geneva Identification System", "GEN# +1.00152501"},
        {"Smithsonian Astrophysical Observation", "SAO 184783"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.70671153),
        dec: Angle.Degrees(-27.74856749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195301"},
        {"Hipparcos Number", "HIP 101250"},
        {"Smithsonian Astrophysical Observation", "SAO 189385"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.85270020),
        dec: Angle.Degrees(-27.74846723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190103"},
        {"Hipparcos Number", "HIP 98849"},
        {"Smithsonian Astrophysical Observation", "SAO 188875"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.10648952),
        dec: Angle.Degrees(-27.74751010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21533"},
        {"Hipparcos Number", "HIP 16106"},
        {"Smithsonian Astrophysical Observation", "SAO 168558"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.86390836),
        dec: Angle.Degrees(-27.74673464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47718"},
        {"Hipparcos Number", "HIP 31791"},
        {"Geneva Identification System", "GEN# +1.00047718"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.70625827),
        dec: Angle.Degrees(-27.74663202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43010"},
        {"Hipparcos Number", "HIP 29482"},
        {"Smithsonian Astrophysical Observation", "SAO 171396"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.17546721),
        dec: Angle.Degrees(-27.74607324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100923"},
        {"Geneva Identification System", "GEN# -0.02816676"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.92412765),
        dec: Angle.Degrees(-27.74557538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -876.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199386"},
        {"Hipparcos Number", "HIP 103459"},
        {"Smithsonian Astrophysical Observation", "SAO 189873"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.41858907),
        dec: Angle.Degrees(-27.74454574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114124"},
        {"Smithsonian Astrophysical Observation", "SAO 191652"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.69015714),
        dec: Angle.Degrees(-27.74172451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48339"},
        {"Hipparcos Number", "HIP 32047"},
        {"Smithsonian Astrophysical Observation", "SAO 172176"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.43332096),
        dec: Angle.Degrees(-27.74141276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35401"},
        {"Smithsonian Astrophysical Observation", "SAO 173445"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65336905),
        dec: Angle.Degrees(-27.74111817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316800"},
        {"Hipparcos Number", "HIP 88233"},
        {"Geneva Identification System", "GEN# +1.00316800"},
        {"Smithsonian Astrophysical Observation", "SAO 186095"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.26789980),
        dec: Angle.Degrees(-27.73881944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45832"},
        {"Smithsonian Astrophysical Observation", "SAO 177307"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.17369661),
        dec: Angle.Degrees(-27.73827681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25839"},
        {"Hipparcos Number", "HIP 19042"},
        {"Smithsonian Astrophysical Observation", "SAO 169097"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.19078069),
        dec: Angle.Degrees(-27.73573271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29766"},
        {"Hipparcos Number", "HIP 21755"},
        {"Renson", "Renson 7640"},
        {"Smithsonian Astrophysical Observation", "SAO 169655"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.06331914),
        dec: Angle.Degrees(-27.73500319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186852"},
        {"Hipparcos Number", "HIP 97408"},
        {"Geneva Identification System", "GEN# +1.00186852"},
        {"Smithsonian Astrophysical Observation", "SAO 188574"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.96863661),
        dec: Angle.Degrees(-27.73195698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55345"},
        {"Hipparcos Number", "HIP 34729"},
        {"Smithsonian Astrophysical Observation", "SAO 173161"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.86185420),
        dec: Angle.Degrees(-27.73182565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25900"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.93026910),
        dec: Angle.Degrees(-27.73154772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103902",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14565 AB"},
        {"Henry Draper", "HD 200245"},
        {"Hipparcos Number", "HIP 103902"},
        {"Geneva Identification System", "GEN# +1.00200245J"},
        {"Smithsonian Astrophysical Observation", "SAO 189966"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.79235790),
        dec: Angle.Degrees(-27.73150578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154613"},
        {"Hipparcos Number", "HIP 83804"},
        {"Geneva Identification System", "GEN# +1.00154613"},
        {"Smithsonian Astrophysical Observation", "SAO 185040"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.90229748),
        dec: Angle.Degrees(-27.73104079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31132"},
    },
    visualMagnitude: 10.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)31, 56.0400),
        dec: Angle.DegreesMinutesSeconds((int)-27, (int)43, 51.600)
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
    primaryId: "HIP 105418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203144"},
        {"Hipparcos Number", "HIP 105418"},
        {"Smithsonian Astrophysical Observation", "SAO 190251"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.28845111),
        dec: Angle.Degrees(-27.73074192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171613"},
        {"Hipparcos Number", "HIP 91268"},
        {"Geneva Identification System", "GEN# +1.00171613"},
        {"Smithsonian Astrophysical Observation", "SAO 187047"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.24343774),
        dec: Angle.Degrees(-27.73070396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144663"},
        {"Hipparcos Number", "HIP 79049"},
        {"Geneva Identification System", "GEN# +1.00144663"},
        {"Smithsonian Astrophysical Observation", "SAO 184143"},
        {"Wilson Evans Batten Catalogue", "WEB 13360"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.02996874),
        dec: Angle.Degrees(-27.73042476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62358"},
        {"Hipparcos Number", "HIP 37554"},
        {"Celescope Catalog", "CEL 1988"},
        {"Geneva Identification System", "GEN# +1.00062358"},
        {"Smithsonian Astrophysical Observation", "SAO 174342"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.60894798),
        dec: Angle.Degrees(-27.72989135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24765"},
        {"Hipparcos Number", "HIP 18340"},
        {"Smithsonian Astrophysical Observation", "SAO 168954"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.81938418),
        dec: Angle.Degrees(-27.72958437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132819"},
        {"Hipparcos Number", "HIP 73553"},
        {"Smithsonian Astrophysical Observation", "SAO 183096"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.48527963),
        dec: Angle.Degrees(-27.72910466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87449"},
        {"Hipparcos Number", "HIP 49349"},
        {"Smithsonian Astrophysical Observation", "SAO 178369"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.11071225),
        dec: Angle.Degrees(-27.72878272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204178"},
        {"Hipparcos Number", "HIP 105962"},
        {"Smithsonian Astrophysical Observation", "SAO 190354"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.88806925),
        dec: Angle.Degrees(-27.72845339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114193"},
        {"Hipparcos Number", "HIP 64193"},
        {"Geneva Identification System", "GEN# +1.00114193"},
        {"Smithsonian Astrophysical Observation", "SAO 181416"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.33754241),
        dec: Angle.Degrees(-27.72794730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42987"},
        {"Hipparcos Number", "HIP 29480"},
        {"Smithsonian Astrophysical Observation", "SAO 171394"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.17005302),
        dec: Angle.Degrees(-27.72582163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6722"},
        {"Hipparcos Number", "HIP 5287"},
        {"Geneva Identification System", "GEN# +1.00006722"},
        {"Smithsonian Astrophysical Observation", "SAO 166819"},
        {"Wilson Evans Batten Catalogue", "WEB 1127"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.90815106),
        dec: Angle.Degrees(-27.72172227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147838"},
        {"Hipparcos Number", "HIP 80446"},
        {"Smithsonian Astrophysical Observation", "SAO 184374"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.31903740),
        dec: Angle.Degrees(-27.72128788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144432"},
        {"Hipparcos Number", "HIP 78943"},
        {"Smithsonian Astrophysical Observation", "SAO 184124"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.74150776),
        dec: Angle.Degrees(-27.71931967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34781"},
        {"Celescope Catalog", "CEL 1664"},
        {"Geneva Identification System", "GEN# -0.02703748"},
        {"Renson", "Renson 15090"},
        {"Smithsonian Astrophysical Observation", "SAO 173185"},
    },
    visualMagnitude: 9.28,
    bvColour: -0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.00955383),
        dec: Angle.Degrees(-27.71802181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196697"},
        {"Hipparcos Number", "HIP 101976"},
        {"Geneva Identification System", "GEN# +1.00196697"},
        {"Smithsonian Astrophysical Observation", "SAO 189538"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.98292986),
        dec: Angle.Degrees(-27.71724881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76800"},
        {"Hipparcos Number", "HIP 43997"},
        {"Smithsonian Astrophysical Observation", "SAO 176746"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.38645200),
        dec: Angle.Degrees(-27.71581584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167576"},
        {"Hipparcos Number", "HIP 89592"},
        {"Geneva Identification System", "GEN# +1.00167576"},
        {"Smithsonian Astrophysical Observation", "SAO 186582"},
        {"Wilson Evans Batten Catalogue", "WEB 15257"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.23955847),
        dec: Angle.Degrees(-27.71560511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61884",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8624 A"},
        {"Henry Draper", "HD 110225"},
        {"Hipparcos Number", "HIP 61884"},
        {"Geneva Identification System", "GEN# +1.00110225"},
        {"Smithsonian Astrophysical Observation", "SAO 181011"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.21446245),
        dec: Angle.Degrees(-27.71323515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221749"},
        {"Hipparcos Number", "HIP 116371"},
        {"Smithsonian Astrophysical Observation", "SAO 192009"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.71148577),
        dec: Angle.Degrees(-27.71266975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191166"},
        {"Hipparcos Number", "HIP 99313"},
        {"Smithsonian Astrophysical Observation", "SAO 188963"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.38755807),
        dec: Angle.Degrees(-27.71227896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213540"},
        {"Hipparcos Number", "HIP 111275"},
        {"Smithsonian Astrophysical Observation", "SAO 191212"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.14319935),
        dec: Angle.Degrees(-27.71125594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94411"},
        {"Smithsonian Astrophysical Observation", "SAO 187826"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.23089297),
        dec: Angle.Degrees(-27.71067059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62683"},
        {"Hipparcos Number", "HIP 37715"},
        {"Geneva Identification System", "GEN# +1.00062683"},
        {"Smithsonian Astrophysical Observation", "SAO 174418"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.04785808),
        dec: Angle.Degrees(-27.71015311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2199"},
        {"Hipparcos Number", "HIP 2032"},
        {"Smithsonian Astrophysical Observation", "SAO 166262"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.43993806),
        dec: Angle.Degrees(-27.71010361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75691"},
        {"Hipparcos Number", "HIP 43409"},
        {"Fundamental Katalog 5th Edition", "FK5 332"},
        {"Geneva Identification System", "GEN# +1.00075691"},
        {"Smithsonian Astrophysical Observation", "SAO 176559"},
        {"Wilson Evans Batten Catalogue", "WEB 8364"},
    },
    visualMagnitude: 4.02,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.63338051),
        dec: Angle.Degrees(-27.71005869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189763"},
        {"Hipparcos Number", "HIP 98688"},
        {"Fundamental Katalog 5th Edition", "FK5 753"},
        {"Geneva Identification System", "GEN# +1.00189763"},
        {"Smithsonian Astrophysical Observation", "SAO 188844"},
        {"Wilson Evans Batten Catalogue", "WEB 17472"},
    },
    visualMagnitude: 4.43,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.66441367),
        dec: Angle.Degrees(-27.70987972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89101"},
        {"Hipparcos Number", "HIP 50304"},
        {"Geneva Identification System", "GEN# +1.00089101"},
        {"Smithsonian Astrophysical Observation", "SAO 178599"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.06318337),
        dec: Angle.Degrees(-27.70969890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127419"},
        {"Hipparcos Number", "HIP 71077"},
        {"Geneva Identification System", "GEN# +1.00127419"},
        {"Smithsonian Astrophysical Observation", "SAO 182637"},
        {"Wilson Evans Batten Catalogue", "WEB 12290"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.02169431),
        dec: Angle.Degrees(-27.70890640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1966"},
        {"Smithsonian Astrophysical Observation", "SAO 166251"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.21036727),
        dec: Angle.Degrees(-27.70863762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144349"},
        {"Hipparcos Number", "HIP 78912"},
        {"Smithsonian Astrophysical Observation", "SAO 184116"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.62195737),
        dec: Angle.Degrees(-27.70860580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38137"},
        {"Hipparcos Number", "HIP 26873"},
        {"Geneva Identification System", "GEN# +1.00038137"},
        {"Smithsonian Astrophysical Observation", "SAO 170718"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.58346506),
        dec: Angle.Degrees(-27.70739804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103932"},
        {"Hipparcos Number", "HIP 58345"},
        {"Cincinnati Publication", "Ci 20 673"},
        {"Cincinnati Publication 2", "Ci 18 1487"},
        {"Fundamental Katalog 5th Edition", "FK5 5052"},
        {"Geneva Identification System", "GEN# +1.00103932"},
        {"Smithsonian Astrophysical Observation", "SAO 180337"},
        {"Wilson Evans Batten Catalogue", "WEB 10432"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.48716146),
        dec: Angle.Degrees(-27.70553634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1079.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -619.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31572"},
        {"Hipparcos Number", "HIP 22912"},
        {"Smithsonian Astrophysical Observation", "SAO 169895"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.95814983),
        dec: Angle.Degrees(-27.70454373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9388"},
        {"Hipparcos Number", "HIP 7133"},
        {"Smithsonian Astrophysical Observation", "SAO 167115"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.97301126),
        dec: Angle.Degrees(-27.70311544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137861"},
        {"Hipparcos Number", "HIP 75821"},
        {"Smithsonian Astrophysical Observation", "SAO 183514"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.33452117),
        dec: Angle.Degrees(-27.70238526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154626"},
        {"Hipparcos Number", "HIP 83809"},
        {"Smithsonian Astrophysical Observation", "SAO 185041"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.91916888),
        dec: Angle.Degrees(-27.70220567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52897"},
        {"Hipparcos Number", "HIP 33867"},
        {"Geneva Identification System", "GEN# +1.00052897"},
        {"Smithsonian Astrophysical Observation", "SAO 172799"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.45119175),
        dec: Angle.Degrees(-27.70214278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31332"},
        {"Hipparcos Number", "HIP 22757"},
        {"Smithsonian Astrophysical Observation", "SAO 169860"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.43045675),
        dec: Angle.Degrees(-27.70144642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14555"},
        {"Hipparcos Number", "HIP 10911"},
        {"Geneva Identification System", "GEN# +1.00014555"},
        {"Smithsonian Astrophysical Observation", "SAO 167717"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.11531844),
        dec: Angle.Degrees(-27.70098650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
