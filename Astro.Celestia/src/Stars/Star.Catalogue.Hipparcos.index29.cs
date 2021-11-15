using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_29() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51206"},
        {"Hipparcos Number", "HIP 33213"},
        {"Smithsonian Astrophysical Observation", "SAO 197351"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.68171809),
        dec: Angle.Degrees(-37.37222993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8621"},
        {"Geneva Identification System", "GEN# -0.03700713"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.80582081),
        dec: Angle.Degrees(-37.37217114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 267.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69402"},
        {"Hipparcos Number", "HIP 40443"},
        {"Celescope Catalog", "CEL 2287"},
        {"Smithsonian Astrophysical Observation", "SAO 199000"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.86698565),
        dec: Angle.Degrees(-37.37204838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48725"},
        {"Hipparcos Number", "HIP 32172"},
        {"Celescope Catalog", "CEL 1365"},
        {"Geneva Identification System", "GEN# +1.00048725"},
        {"Smithsonian Astrophysical Observation", "SAO 197131"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.75989565),
        dec: Angle.Degrees(-37.36988419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40442"},
        {"Smithsonian Astrophysical Observation", "SAO 198999"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.86619370),
        dec: Angle.Degrees(-37.36745759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108085",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Aldhanab"},
        {"Henry Draper", "HD 207971"},
        {"Hipparcos Number", "HIP 108085"},
        {"Fundamental Katalog 5th Edition", "FK5 822"},
        {"Geneva Identification System", "GEN# +1.00207971"},
        {"Smithsonian Astrophysical Observation", "SAO 213374"},
        {"Wilson Evans Batten Catalogue", "WEB 19485"},
    },
    visualMagnitude: 3.00,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.48189202),
        dec: Angle.Degrees(-37.36482290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224096"},
        {"Hipparcos Number", "HIP 117919"},
        {"Smithsonian Astrophysical Observation", "SAO 214859"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.77023468),
        dec: Angle.Degrees(-37.36479582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160046"},
        {"Hipparcos Number", "HIP 86418"},
        {"Geneva Identification System", "GEN# +1.00160046"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.87016698),
        dec: Angle.Degrees(-37.36463528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197970"},
        {"Hipparcos Number", "HIP 102677"},
        {"Geneva Identification System", "GEN# +1.00197970"},
        {"Smithsonian Astrophysical Observation", "SAO 212447"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.09704817),
        dec: Angle.Degrees(-37.36318493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149396"},
        {"Hipparcos Number", "HIP 81269"},
        {"Fundamental Katalog 5th Edition", "FK5 5467"},
        {"Geneva Identification System", "GEN# +1.00149396"},
        {"Smithsonian Astrophysical Observation", "SAO 207806"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.98213194),
        dec: Angle.Degrees(-37.36293971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209509"},
        {"Hipparcos Number", "HIP 108993"},
        {"Smithsonian Astrophysical Observation", "SAO 213524"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.20151618),
        dec: Angle.Degrees(-37.36264831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132094"},
        {"Hipparcos Number", "HIP 73266"},
        {"Geneva Identification System", "GEN# +1.00132094"},
        {"Smithsonian Astrophysical Observation", "SAO 206149"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.60116180),
        dec: Angle.Degrees(-37.36241833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202228"},
        {"Hipparcos Number", "HIP 104951"},
        {"Smithsonian Astrophysical Observation", "SAO 212838"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.88990429),
        dec: Angle.Degrees(-37.36199378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91804"},
        {"Hipparcos Number", "HIP 51838"},
        {"Smithsonian Astrophysical Observation", "SAO 201538"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.86499735),
        dec: Angle.Degrees(-37.36141683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15048"},
        {"Hipparcos Number", "HIP 11222"},
        {"Geneva Identification System", "GEN# +1.00015048"},
        {"Smithsonian Astrophysical Observation", "SAO 193690"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.10889758),
        dec: Angle.Degrees(-37.36130528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217417"},
        {"Hipparcos Number", "HIP 113649"},
        {"Renson", "Renson 59970"},
        {"Smithsonian Astrophysical Observation", "SAO 214247"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.25388976),
        dec: Angle.Degrees(-37.35911941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78626"},
        {"Hipparcos Number", "HIP 44833"},
        {"Smithsonian Astrophysical Observation", "SAO 200014"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.03016367),
        dec: Angle.Degrees(-37.35887142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137597"},
        {"Hipparcos Number", "HIP 75727"},
        {"Geneva Identification System", "GEN# +1.00137597J"},
        {"Smithsonian Astrophysical Observation", "SAO 206673"},
        {"Wilson Evans Batten Catalogue", "WEB 12891"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.05521998),
        dec: Angle.Degrees(-37.35851787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108047"},
        {"Hipparcos Number", "HIP 60581"},
        {"Smithsonian Astrophysical Observation", "SAO 203446"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.25869438),
        dec: Angle.Degrees(-37.35529835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41600"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.21747375),
        dec: Angle.Degrees(-37.35428559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91673"},
        {"Hipparcos Number", "HIP 51760"},
        {"Smithsonian Astrophysical Observation", "SAO 201524"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.63002147),
        dec: Angle.Degrees(-37.35418334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26480"},
        {"Hipparcos Number", "HIP 19439"},
        {"Smithsonian Astrophysical Observation", "SAO 194804"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.45458606),
        dec: Angle.Degrees(-37.35299199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53582"},
        {"Smithsonian Astrophysical Observation", "SAO 137910"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.41649200),
        dec: Angle.Degrees(-04.79957075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89852"},
        {"Hipparcos Number", "HIP 50721"},
        {"Geneva Identification System", "GEN# +1.00089852"},
        {"Smithsonian Astrophysical Observation", "SAO 201311"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.34510235),
        dec: Angle.Degrees(-37.35189603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225213"},
        {"Hipparcos Number", "HIP 439"},
        {"Cincinnati Publication", "Ci 20 3"},
        {"Cincinnati Publication 2", "Ci 18 3161"},
        {"Geneva Identification System", "GEN# +1.00225213"},
        {"Smithsonian Astrophysical Observation", "SAO 192348"},
        {"Wilson Evans Batten Catalogue", "WEB 60"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.33455564),
        dec: Angle.Degrees(-37.35168110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5634.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2337.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77766"},
        {"Hipparcos Number", "HIP 44447"},
        {"Smithsonian Astrophysical Observation", "SAO 199928"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.82923211),
        dec: Angle.Degrees(-37.35151867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118119"},
        {"Hipparcos Number", "HIP 66325"},
        {"Smithsonian Astrophysical Observation", "SAO 204631"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.88766132),
        dec: Angle.Degrees(-37.35087192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218372"},
        {"Hipparcos Number", "HIP 114219"},
        {"Smithsonian Astrophysical Observation", "SAO 214331"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.96159691),
        dec: Angle.Degrees(-37.34763609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87332"},
        {"Hipparcos Number", "HIP 49269"},
        {"Smithsonian Astrophysical Observation", "SAO 201007"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.85457429),
        dec: Angle.Degrees(-37.34639152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17477"},
        {"Hipparcos Number", "HIP 12979"},
        {"Smithsonian Astrophysical Observation", "SAO 193911"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.73747427),
        dec: Angle.Degrees(-37.34559054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215005"},
        {"Hipparcos Number", "HIP 112129"},
        {"Smithsonian Astrophysical Observation", "SAO 214035"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.69135120),
        dec: Angle.Degrees(-37.34546484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161087"},
        {"Hipparcos Number", "HIP 86889"},
        {"Geneva Identification System", "GEN# +1.00161087"},
        {"Smithsonian Astrophysical Observation", "SAO 209215"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.30610632),
        dec: Angle.Degrees(-37.34505360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175362"},
        {"Hipparcos Number", "HIP 92989"},
        {"Geneva Identification System", "GEN# +1.00175362"},
        {"Renson", "Renson 49030"},
        {"Smithsonian Astrophysical Observation", "SAO 210734"},
        {"Wilson Evans Batten Catalogue", "WEB 16105"},
    },
    visualMagnitude: 5.36,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.16871114),
        dec: Angle.Degrees(-37.34318339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127877"},
        {"Hipparcos Number", "HIP 71302"},
        {"Geneva Identification System", "GEN# +1.00127877"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.72752175),
        dec: Angle.Degrees(-37.34242160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150474"},
        {"Hipparcos Number", "HIP 81819"},
        {"Geneva Identification System", "GEN# +1.00150474"},
        {"Smithsonian Astrophysical Observation", "SAO 207949"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.69438518),
        dec: Angle.Degrees(-37.34228899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129297"},
        {"Hipparcos Number", "HIP 71952"},
        {"Geneva Identification System", "GEN# +1.00129297"},
        {"Smithsonian Astrophysical Observation", "SAO 205856"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.74448720),
        dec: Angle.Degrees(-37.34173861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45982"},
        {"Hipparcos Number", "HIP 30875"},
        {"Smithsonian Astrophysical Observation", "SAO 196869"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.21959148),
        dec: Angle.Degrees(-37.34145079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7526"},
    },
    visualMagnitude: 11.38,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.22278084),
        dec: Angle.Degrees(-37.34108342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34899"},
        {"Hipparcos Number", "HIP 24797"},
        {"Smithsonian Astrophysical Observation", "SAO 195742"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.74205489),
        dec: Angle.Degrees(-37.34019386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86019"},
        {"Hipparcos Number", "HIP 48623"},
        {"Smithsonian Astrophysical Observation", "SAO 200862"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.72811420),
        dec: Angle.Degrees(-37.34007989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59967"},
        {"Hipparcos Number", "HIP 36515"},
        {"Geneva Identification System", "GEN# +1.00059967"},
        {"Smithsonian Astrophysical Observation", "SAO 198069"},
        {"Wilson Evans Batten Catalogue", "WEB 7264"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.67739849),
        dec: Angle.Degrees(-37.33949152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19395"},
        {"Hipparcos Number", "HIP 14408"},
        {"Geneva Identification System", "GEN# +1.00019395"},
        {"Smithsonian Astrophysical Observation", "SAO 194080"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.46795334),
        dec: Angle.Degrees(-37.33905904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163520"},
        {"Hipparcos Number", "HIP 87973"},
        {"Geneva Identification System", "GEN# +1.00163520"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.54532222),
        dec: Angle.Degrees(-37.33753169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140391"},
        {"Hipparcos Number", "HIP 77108"},
        {"Geneva Identification System", "GEN# +1.00140391"},
        {"Smithsonian Astrophysical Observation", "SAO 206926"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.16863731),
        dec: Angle.Degrees(-37.33735699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35528"},
        {"Hipparcos Number", "HIP 25221"},
        {"Geneva Identification System", "GEN# +1.00035528"},
        {"Smithsonian Astrophysical Observation", "SAO 195809"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.91194699),
        dec: Angle.Degrees(-37.33670588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199150"},
        {"Hipparcos Number", "HIP 103363"},
        {"Smithsonian Astrophysical Observation", "SAO 212559"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.11775125),
        dec: Angle.Degrees(-37.33667646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187518"},
        {"Hipparcos Number", "HIP 97742"},
        {"Smithsonian Astrophysical Observation", "SAO 211609"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.94254929),
        dec: Angle.Degrees(-37.33617086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192055"},
        {"Hipparcos Number", "HIP 99761"},
        {"Smithsonian Astrophysical Observation", "SAO 211928"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.61217355),
        dec: Angle.Degrees(-37.33514547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88013"},
        {"Hipparcos Number", "HIP 49645"},
        {"Geneva Identification System", "GEN# +1.00088013"},
        {"Smithsonian Astrophysical Observation", "SAO 201081"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.00695797),
        dec: Angle.Degrees(-37.33346184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56260"},
        {"Hipparcos Number", "HIP 35018"},
        {"Geneva Identification System", "GEN# +1.00056260"},
        {"Smithsonian Astrophysical Observation", "SAO 197742"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.65690771),
        dec: Angle.Degrees(-37.33288514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122222"},
        {"Hipparcos Number", "HIP 68500"},
        {"Smithsonian Astrophysical Observation", "SAO 205099"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.34148795),
        dec: Angle.Degrees(-37.33135531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29686"},
        {"Hipparcos Number", "HIP 21651"},
        {"Smithsonian Astrophysical Observation", "SAO 195199"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.73415265),
        dec: Angle.Degrees(-37.33112554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125200"},
        {"Hipparcos Number", "HIP 69948"},
        {"Geneva Identification System", "GEN# +1.00125200"},
        {"Smithsonian Astrophysical Observation", "SAO 205419"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.71234089),
        dec: Angle.Degrees(-37.32995075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170865"},
        {"Hipparcos Number", "HIP 90963"},
        {"Geneva Identification System", "GEN# +1.00170865"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.33425731),
        dec: Angle.Degrees(-37.32951577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85119"},
        {"Hipparcos Number", "HIP 48141"},
        {"Geneva Identification System", "GEN# +1.00085119"},
        {"Smithsonian Astrophysical Observation", "SAO 200763"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.20906033),
        dec: Angle.Degrees(-37.30961617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223492"},
        {"Hipparcos Number", "HIP 117525"},
        {"Geneva Identification System", "GEN# +1.00223492"},
        {"Smithsonian Astrophysical Observation", "SAO 214802"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.51784389),
        dec: Angle.Degrees(-37.32879269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207493"},
        {"Hipparcos Number", "HIP 107801"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.58188777),
        dec: Angle.Degrees(-37.32849635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121962"},
        {"Hipparcos Number", "HIP 68352"},
        {"Geneva Identification System", "GEN# +1.00121962"},
        {"Smithsonian Astrophysical Observation", "SAO 205067"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.86816213),
        dec: Angle.Degrees(-37.32366115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219958"},
        {"Hipparcos Number", "HIP 115230"},
        {"Smithsonian Astrophysical Observation", "SAO 214472"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.08717832),
        dec: Angle.Degrees(-37.32241981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150865"},
        {"Hipparcos Number", "HIP 82026"},
        {"Smithsonian Astrophysical Observation", "SAO 207993"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.33296626),
        dec: Angle.Degrees(-37.32093703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14702"},
        {"Hipparcos Number", "HIP 10980"},
        {"Geneva Identification System", "GEN# +1.00014702"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.35694168),
        dec: Angle.Degrees(-37.31948739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60668"},
        {"Hipparcos Number", "HIP 36792"},
        {"Celescope Catalog", "CEL 1933"},
        {"Geneva Identification System", "GEN# +1.00060668"},
        {"Smithsonian Astrophysical Observation", "SAO 198136"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.51012917),
        dec: Angle.Degrees(-37.31928109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38011"},
        {"Smithsonian Astrophysical Observation", "SAO 198441"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.85564299),
        dec: Angle.Degrees(-37.31703420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175714"},
        {"Hipparcos Number", "HIP 93125"},
        {"Smithsonian Astrophysical Observation", "SAO 210766"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.56227054),
        dec: Angle.Degrees(-37.31694308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6234"},
        {"Hipparcos Number", "HIP 4892"},
        {"Geneva Identification System", "GEN# +1.00006234"},
        {"Smithsonian Astrophysical Observation", "SAO 192889"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.70769890),
        dec: Angle.Degrees(-37.31592004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9577"},
        {"Hipparcos Number", "HIP 7239"},
        {"Geneva Identification System", "GEN# +1.00009577"},
        {"Smithsonian Astrophysical Observation", "SAO 193176"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.31965499),
        dec: Angle.Degrees(-37.31524506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81496"},
        {"Hipparcos Number", "HIP 46161"},
        {"Geneva Identification System", "GEN# +1.00081496"},
        {"Smithsonian Astrophysical Observation", "SAO 200338"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.20773248),
        dec: Angle.Degrees(-37.31503265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209576"},
        {"Hipparcos Number", "HIP 109032"},
        {"Geneva Identification System", "GEN# +1.00209576"},
        {"Smithsonian Astrophysical Observation", "SAO 213532"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.31351954),
        dec: Angle.Degrees(-37.31487364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 536"},
        {"Hipparcos Number", "HIP 786"},
        {"Geneva Identification System", "GEN# +1.00000536J"},
        {"Smithsonian Astrophysical Observation", "SAO 192378"},
        {"Wilson Evans Batten Catalogue", "WEB 134"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.42337039),
        dec: Angle.Degrees(-37.31481117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23319"},
        {"Hipparcos Number", "HIP 17351"},
        {"Fundamental Katalog 5th Edition", "FK5 2265"},
        {"Geneva Identification System", "GEN# +1.00023319J"},
        {"Smithsonian Astrophysical Observation", "SAO 194475"},
        {"Wilson Evans Batten Catalogue", "WEB 3279"},
    },
    visualMagnitude: 4.59,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.70884185),
        dec: Angle.Degrees(-37.31334485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35976"},
        {"Hipparcos Number", "HIP 25455"},
        {"Smithsonian Astrophysical Observation", "SAO 195860"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.66473342),
        dec: Angle.Degrees(-37.30846838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154503"},
        {"Hipparcos Number", "HIP 83789"},
        {"Smithsonian Astrophysical Observation", "SAO 208434"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.87007546),
        dec: Angle.Degrees(-37.30752799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143846"},
        {"Hipparcos Number", "HIP 78716"},
        {"Geneva Identification System", "GEN# +1.00143846"},
        {"Smithsonian Astrophysical Observation", "SAO 207288"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.04071380),
        dec: Angle.Degrees(-37.30735914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -330.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6391"},
        {"Hipparcos Number", "HIP 5022"},
        {"Smithsonian Astrophysical Observation", "SAO 192905"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.08735625),
        dec: Angle.Degrees(-37.30358661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68067"},
        {"Smithsonian Astrophysical Observation", "SAO 205006"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.04485267),
        dec: Angle.Degrees(-37.30283611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211865"},
        {"Hipparcos Number", "HIP 110332"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.20389984),
        dec: Angle.Degrees(-37.30275332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65"},
        {"Hipparcos Number", "HIP 456"},
        {"Smithsonian Astrophysical Observation", "SAO 192352"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.36543236),
        dec: Angle.Degrees(-37.30254152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128150"},
        {"Hipparcos Number", "HIP 71430"},
        {"Smithsonian Astrophysical Observation", "SAO 205746"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.10280654),
        dec: Angle.Degrees(-37.30251661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65888"},
        {"Hipparcos Number", "HIP 39063"},
        {"Celescope Catalog", "CEL 2127"},
        {"Geneva Identification System", "GEN# +1.00065888"},
        {"Smithsonian Astrophysical Observation", "SAO 198667"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.87759211),
        dec: Angle.Degrees(-37.30240446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153575"},
        {"Hipparcos Number", "HIP 83340"},
        {"Geneva Identification System", "GEN# +1.00153575"},
        {"Smithsonian Astrophysical Observation", "SAO 208319"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.48059417),
        dec: Angle.Degrees(-37.30145699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7460"},
        {"Smithsonian Astrophysical Observation", "SAO 193202"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.03449386),
        dec: Angle.Degrees(-37.29665667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85696",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Lesath"},
        {"Henry Draper", "HD 158408"},
        {"Hipparcos Number", "HIP 85696"},
        {"Fundamental Katalog 5th Edition", "FK5 649"},
        {"Geneva Identification System", "GEN# +1.00158408"},
        {"Smithsonian Astrophysical Observation", "SAO 208896"},
        {"Wilson Evans Batten Catalogue", "WEB 14463"},
    },
    visualMagnitude: 2.70,
    bvColour: -0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.69099501),
        dec: Angle.Degrees(-37.29574016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15182"},
        {"Hipparcos Number", "HIP 11325"},
        {"Smithsonian Astrophysical Observation", "SAO 193705"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.43851865),
        dec: Angle.Degrees(-37.29557015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4069"},
        {"Smithsonian Astrophysical Observation", "SAO 192787"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.04895668),
        dec: Angle.Degrees(-37.29379631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68450"},
        {"Hipparcos Number", "HIP 40063"},
        {"Celescope Catalog", "CEL 2211"},
        {"Geneva Identification System", "GEN# +2.25460682"},
        {"Renson", "Renson 18940"},
        {"Smithsonian Astrophysical Observation", "SAO 198898"},
        {"Wilson Evans Batten Catalogue", "WEB 7814"},
        {"New General Catalogue", "NGC 2546 682"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.75702941),
        dec: Angle.Degrees(-37.29238656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9918"},
        {"Hipparcos Number", "HIP 7466"},
        {"Geneva Identification System", "GEN# +1.00009918B"},
        {"Renson", "Renson 2440"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.04288031),
        dec: Angle.Degrees(-37.29234097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128976"},
        {"Hipparcos Number", "HIP 71798"},
        {"Smithsonian Astrophysical Observation", "SAO 205825"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.29267009),
        dec: Angle.Degrees(-37.29188853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35960"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.19735096),
        dec: Angle.Degrees(-37.29126075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85964"},
        {"Hipparcos Number", "HIP 48580"},
        {"Geneva Identification System", "GEN# +1.00085964"},
        {"Smithsonian Astrophysical Observation", "SAO 200854"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.62062037),
        dec: Angle.Degrees(-37.29001031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99696"},
        {"Hipparcos Number", "HIP 55940"},
        {"Smithsonian Astrophysical Observation", "SAO 202474"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.97247994),
        dec: Angle.Degrees(-37.28866790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3460"},
        {"Hipparcos Number", "HIP 2944"},
        {"Geneva Identification System", "GEN# +1.00003460"},
        {"Smithsonian Astrophysical Observation", "SAO 192643"},
        {"Wilson Evans Batten Catalogue", "WEB 533"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.34217573),
        dec: Angle.Degrees(-37.28798048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 547.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3581"},
        {"Smithsonian Astrophysical Observation", "SAO 192718"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.43209543),
        dec: Angle.Degrees(-37.28629861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110035"},
        {"Hipparcos Number", "HIP 61775"},
        {"Geneva Identification System", "GEN# +1.00110035"},
        {"Smithsonian Astrophysical Observation", "SAO 203675"},
        {"Wilson Evans Batten Catalogue", "WEB 10989"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.91304609),
        dec: Angle.Degrees(-37.28628660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -271.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -266.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209687"},
        {"Hipparcos Number", "HIP 109101"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.50719552),
        dec: Angle.Degrees(-37.28513760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9476"},
        {"Hipparcos Number", "HIP 7167"},
        {"Smithsonian Astrophysical Observation", "SAO 193171"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.10232321),
        dec: Angle.Degrees(-37.28458870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6233"},
        {"Hipparcos Number", "HIP 4899"},
        {"Geneva Identification System", "GEN# +1.00006233"},
        {"Smithsonian Astrophysical Observation", "SAO 192890"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.71893727),
        dec: Angle.Degrees(-37.28427683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66358"},
        {"Hipparcos Number", "HIP 39251"},
        {"Celescope Catalog", "CEL 2140"},
        {"Geneva Identification System", "GEN# +1.00066358"},
        {"Smithsonian Astrophysical Observation", "SAO 198714"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.40636615),
        dec: Angle.Degrees(-37.28373201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116447"},
        {"Hipparcos Number", "HIP 65403"},
        {"Smithsonian Astrophysical Observation", "SAO 204430"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.07583565),
        dec: Angle.Degrees(-37.28368530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201497"},
        {"Hipparcos Number", "HIP 104582"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.78290819),
        dec: Angle.Degrees(-37.28353875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122664"},
        {"Hipparcos Number", "HIP 68722"},
        {"Geneva Identification System", "GEN# +1.00122664"},
        {"Smithsonian Astrophysical Observation", "SAO 205138"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.02061228),
        dec: Angle.Degrees(-37.28351445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21221"},
        {"Hipparcos Number", "HIP 15839"},
        {"Smithsonian Astrophysical Observation", "SAO 194273"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.00855530),
        dec: Angle.Degrees(-37.28330157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217171"},
        {"Hipparcos Number", "HIP 113491"},
        {"Smithsonian Astrophysical Observation", "SAO 214219"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.76651578),
        dec: Angle.Degrees(-37.28096581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7818"},
        {"Hipparcos Number", "HIP 6009"},
        {"Smithsonian Astrophysical Observation", "SAO 193026"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.31878869),
        dec: Angle.Degrees(-37.27692176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49903"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.83514788),
        dec: Angle.Degrees(-37.27609944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -254.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32675"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.23505838),
        dec: Angle.Degrees(-37.27593638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211723"},
        {"Hipparcos Number", "HIP 110245"},
        {"Geneva Identification System", "GEN# +1.00211723"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.96884359),
        dec: Angle.Degrees(-37.27507462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10710"},
        {"Hipparcos Number", "HIP 8085"},
        {"Smithsonian Astrophysical Observation", "SAO 193272"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.95855700),
        dec: Angle.Degrees(-37.27408104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22792"},
        {"Hipparcos Number", "HIP 16982"},
        {"Geneva Identification System", "GEN# +1.00022792"},
        {"Smithsonian Astrophysical Observation", "SAO 194422"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.60128862),
        dec: Angle.Degrees(-37.27244814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134555"},
        {"Hipparcos Number", "HIP 74354"},
        {"Smithsonian Astrophysical Observation", "SAO 206382"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.93311977),
        dec: Angle.Degrees(-37.27200348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7819"},
        {"Hipparcos Number", "HIP 6021"},
        {"Geneva Identification System", "GEN# +1.00007819"},
        {"Smithsonian Astrophysical Observation", "SAO 193030"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.34134356),
        dec: Angle.Degrees(-37.27001429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149964"},
        {"Hipparcos Number", "HIP 81569"},
    },
    visualMagnitude: 10.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.88969158),
        dec: Angle.Degrees(-37.26945768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208781"},
        {"Hipparcos Number", "HIP 108568"},
        {"Smithsonian Astrophysical Observation", "SAO 213454"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.88878053),
        dec: Angle.Degrees(-37.26941144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205428"},
        {"Hipparcos Number", "HIP 106669"},
        {"Smithsonian Astrophysical Observation", "SAO 213125"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.07394320),
        dec: Angle.Degrees(-37.26712042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200954"},
        {"Hipparcos Number", "HIP 104307"},
        {"Smithsonian Astrophysical Observation", "SAO 212729"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.95681790),
        dec: Angle.Degrees(-37.26430782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105737"},
        {"Smithsonian Astrophysical Observation", "SAO 212978"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.24705562),
        dec: Angle.Degrees(-37.26411907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122683"},
        {"Hipparcos Number", "HIP 68726"},
        {"Geneva Identification System", "GEN# +1.00122683"},
        {"Smithsonian Astrophysical Observation", "SAO 205139"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.02970141),
        dec: Angle.Degrees(-37.26397346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78345"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.95637879),
        dec: Angle.Degrees(-36.47431280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94527"},
        {"Hipparcos Number", "HIP 53306"},
        {"Geneva Identification System", "GEN# +1.00094527"},
        {"Smithsonian Astrophysical Observation", "SAO 201877"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.54572305),
        dec: Angle.Degrees(-37.26392042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27928"},
        {"Hipparcos Number", "HIP 20454"},
        {"Geneva Identification System", "GEN# +1.00027928"},
        {"Smithsonian Astrophysical Observation", "SAO 194967"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.72965830),
        dec: Angle.Degrees(-37.26351513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154834"},
        {"Hipparcos Number", "HIP 83937"},
        {"Geneva Identification System", "GEN# +1.00154834"},
        {"Smithsonian Astrophysical Observation", "SAO 208475"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.35256121),
        dec: Angle.Degrees(-37.26322399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193643"},
        {"Hipparcos Number", "HIP 100502"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.69360155),
        dec: Angle.Degrees(-37.26202135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48203"},
        {"Smithsonian Astrophysical Observation", "SAO 200781"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.41220644),
        dec: Angle.Degrees(-37.25466776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208321"},
        {"Hipparcos Number", "HIP 108294"},
        {"Geneva Identification System", "GEN# +1.00208321"},
        {"Smithsonian Astrophysical Observation", "SAO 213414"},
        {"Wilson Evans Batten Catalogue", "WEB 19507"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.09495119),
        dec: Angle.Degrees(-37.25363145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43940"},
        {"Hipparcos Number", "HIP 29852"},
        {"Geneva Identification System", "GEN# +1.00043940"},
        {"Smithsonian Astrophysical Observation", "SAO 196659"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.28988535),
        dec: Angle.Degrees(-37.25344284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29034",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Elkurud"},
        {"Henry Draper", "HD 42167"},
        {"Hipparcos Number", "HIP 29034"},
        {"Fundamental Katalog 5th Edition", "FK5 2468"},
        {"Geneva Identification System", "GEN# +1.00042167"},
        {"Smithsonian Astrophysical Observation", "SAO 196514"},
        {"Wilson Evans Batten Catalogue", "WEB 5683"},
    },
    visualMagnitude: 5.00,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.88180046),
        dec: Angle.Degrees(-37.25292114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151379"},
        {"Hipparcos Number", "HIP 82272"},
        {"Geneva Identification System", "GEN# +1.00151379"},
        {"Smithsonian Astrophysical Observation", "SAO 208051"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.15733455),
        dec: Angle.Degrees(-37.25169989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166747"},
        {"Hipparcos Number", "HIP 89339"},
        {"Geneva Identification System", "GEN# +1.00166747"},
        {"Smithsonian Astrophysical Observation", "SAO 209872"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.43028618),
        dec: Angle.Degrees(-37.25135491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29528"},
    },
    visualMagnitude: 12.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.31140598),
        dec: Angle.Degrees(-37.25018019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5698"},
        {"Hipparcos Number", "HIP 4545"},
        {"Geneva Identification System", "GEN# +1.00005698"},
        {"Smithsonian Astrophysical Observation", "SAO 192842"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.54570998),
        dec: Angle.Degrees(-37.24941524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174217"},
        {"Hipparcos Number", "HIP 92502"},
        {"Smithsonian Astrophysical Observation", "SAO 210630"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.77488290),
        dec: Angle.Degrees(-37.24780626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134799"},
        {"Hipparcos Number", "HIP 74468"},
        {"Geneva Identification System", "GEN# +1.00134799J"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.25451870),
        dec: Angle.Degrees(-37.24661767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56284"},
        {"Hipparcos Number", "HIP 35031"},
        {"Celescope Catalog", "CEL 1712"},
        {"Geneva Identification System", "GEN# +1.00056284"},
        {"Smithsonian Astrophysical Observation", "SAO 197745"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.69544493),
        dec: Angle.Degrees(-37.24541058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149002"},
        {"Hipparcos Number", "HIP 81064"},
        {"Geneva Identification System", "GEN# +1.00149002"},
        {"Smithsonian Astrophysical Observation", "SAO 207764"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.36192529),
        dec: Angle.Degrees(-37.24468113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139011"},
        {"Hipparcos Number", "HIP 76469"},
        {"Smithsonian Astrophysical Observation", "SAO 206805"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.25604914),
        dec: Angle.Degrees(-37.24319342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201108"},
        {"Hipparcos Number", "HIP 104374"},
        {"Smithsonian Astrophysical Observation", "SAO 212743"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.17197414),
        dec: Angle.Degrees(-37.24268933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127590"},
        {"Hipparcos Number", "HIP 71166"},
        {"Smithsonian Astrophysical Observation", "SAO 205683"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.33183366),
        dec: Angle.Degrees(-37.24154163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160126"},
        {"Hipparcos Number", "HIP 86461"},
        {"Smithsonian Astrophysical Observation", "SAO 209094"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.98939010),
        dec: Angle.Degrees(-37.23777908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100911"},
        {"Hipparcos Number", "HIP 56632"},
        {"Geneva Identification System", "GEN# +1.00100911"},
        {"Smithsonian Astrophysical Observation", "SAO 202627"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.16976145),
        dec: Angle.Degrees(-37.23719322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110693"},
        {"Hipparcos Number", "HIP 62144"},
        {"Smithsonian Astrophysical Observation", "SAO 203759"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.06000263),
        dec: Angle.Degrees(-37.23700727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43208"},
        {"Smithsonian Astrophysical Observation", "SAO 199640"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.03353594),
        dec: Angle.Degrees(-37.23479227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72215"},
        {"Smithsonian Astrophysical Observation", "SAO 205918"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.54114574),
        dec: Angle.Degrees(-37.23336925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45632"},
        {"Hipparcos Number", "HIP 30677"},
        {"Smithsonian Astrophysical Observation", "SAO 196831"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.69761236),
        dec: Angle.Degrees(-37.23255495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200521"},
        {"Hipparcos Number", "HIP 104077"},
        {"Smithsonian Astrophysical Observation", "SAO 212691"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.28555343),
        dec: Angle.Degrees(-37.23115169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36187"},
        {"Hipparcos Number", "HIP 25608"},
        {"Geneva Identification System", "GEN# +1.00036187"},
        {"Smithsonian Astrophysical Observation", "SAO 195887"},
        {"Wilson Evans Batten Catalogue", "WEB 4970"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.06386207),
        dec: Angle.Degrees(-37.23093130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114848"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.94921327),
        dec: Angle.Degrees(-37.23014459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 256.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224936"},
        {"Hipparcos Number", "HIP 150"},
        {"Fundamental Katalog 5th Edition", "FK5 3931"},
        {"Smithsonian Astrophysical Observation", "SAO 214931"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.48036559),
        dec: Angle.Degrees(-37.22984397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36546"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.76700972),
        dec: Angle.Degrees(-37.22888824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -241.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154310"},
        {"Hipparcos Number", "HIP 83693"},
        {"Geneva Identification System", "GEN# +1.00154310"},
        {"Smithsonian Astrophysical Observation", "SAO 208406"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.58414643),
        dec: Angle.Degrees(-37.22753062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169074"},
        {"Hipparcos Number", "HIP 90219"},
        {"Smithsonian Astrophysical Observation", "SAO 210098"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.12918424),
        dec: Angle.Degrees(-37.22688127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82726"},
        {"Hipparcos Number", "HIP 46845"},
        {"Geneva Identification System", "GEN# +1.00082726"},
        {"Smithsonian Astrophysical Observation", "SAO 200483"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.18479243),
        dec: Angle.Degrees(-37.22628574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167820"},
        {"Hipparcos Number", "HIP 89724"},
        {"Fundamental Katalog 5th Edition", "FK5 5613"},
        {"Smithsonian Astrophysical Observation", "SAO 209979"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.66335022),
        dec: Angle.Degrees(-37.22441027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129929"},
        {"Hipparcos Number", "HIP 72241"},
        {"Geneva Identification System", "GEN# +1.00129929"},
        {"Smithsonian Astrophysical Observation", "SAO 205922"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.60733243),
        dec: Angle.Degrees(-37.22224207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157097"},
        {"Hipparcos Number", "HIP 85048"},
        {"Geneva Identification System", "GEN# +1.00157097"},
        {"Smithsonian Astrophysical Observation", "SAO 208747"},
    },
    visualMagnitude: 5.91,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.72806023),
        dec: Angle.Degrees(-37.22069314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44848"},
    },
    visualMagnitude: 12.04,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.06585541),
        dec: Angle.Degrees(-37.21901467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16954"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.52516580),
        dec: Angle.Degrees(-37.21835571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 237.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149886"},
        {"Hipparcos Number", "HIP 81523"},
        {"Fundamental Katalog 5th Edition", "FK5 3317"},
        {"Geneva Identification System", "GEN# +1.00149886J"},
        {"Smithsonian Astrophysical Observation", "SAO 207878"},
    },
    visualMagnitude: 5.93,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.77181329),
        dec: Angle.Degrees(-37.21726333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55247"},
        {"Hipparcos Number", "HIP 34635"},
        {"Smithsonian Astrophysical Observation", "SAO 197658"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.61056931),
        dec: Angle.Degrees(-37.21613957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90624"},
        {"Hipparcos Number", "HIP 51175"},
        {"Smithsonian Astrophysical Observation", "SAO 201406"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.79180926),
        dec: Angle.Degrees(-37.21312903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170640"},
        {"Hipparcos Number", "HIP 90871"},
        {"Smithsonian Astrophysical Observation", "SAO 210276"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.05592932),
        dec: Angle.Degrees(-37.21235572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178729"},
        {"Hipparcos Number", "HIP 94275"},
        {"Geneva Identification System", "GEN# +1.00178729"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.83367751),
        dec: Angle.Degrees(-37.21190312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171526"},
        {"Hipparcos Number", "HIP 91266"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.24014928),
        dec: Angle.Degrees(-37.21148407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211119"},
        {"Hipparcos Number", "HIP 109914"},
        {"Geneva Identification System", "GEN# +1.00211119"},
        {"Smithsonian Astrophysical Observation", "SAO 213675"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.91636306),
        dec: Angle.Degrees(-37.21139042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53464"},
        {"Hipparcos Number", "HIP 34011"},
        {"Geneva Identification System", "GEN# +1.00053464"},
        {"Smithsonian Astrophysical Observation", "SAO 197522"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.86229329),
        dec: Angle.Degrees(-37.20536733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127894"},
        {"Hipparcos Number", "HIP 71308"},
        {"Geneva Identification System", "GEN# +1.00127894"},
        {"Smithsonian Astrophysical Observation", "SAO 205718"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.73583679),
        dec: Angle.Degrees(-37.20431317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36518"},
        {"Hipparcos Number", "HIP 25795"},
        {"Geneva Identification System", "GEN# +1.00036518"},
        {"Smithsonian Astrophysical Observation", "SAO 195915"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.62625797),
        dec: Angle.Degrees(-37.20306746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 172.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220506"},
        {"Hipparcos Number", "HIP 115556"},
        {"Geneva Identification System", "GEN# +1.00220506"},
        {"Smithsonian Astrophysical Observation", "SAO 214525"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.11090141),
        dec: Angle.Degrees(-37.20092716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2821"},
        {"Hipparcos Number", "HIP 2478"},
        {"Geneva Identification System", "GEN# +1.00002821"},
        {"Smithsonian Astrophysical Observation", "SAO 192586"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.86542487),
        dec: Angle.Degrees(-37.20082776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42138"},
        {"Hipparcos Number", "HIP 29012"},
        {"Geneva Identification System", "GEN# +1.00042138"},
        {"Smithsonian Astrophysical Observation", "SAO 196510"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.82859266),
        dec: Angle.Degrees(-37.20013553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44409"},
    },
    visualMagnitude: 10.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.69067219),
        dec: Angle.Degrees(-37.19981921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12704"},
        {"Hipparcos Number", "HIP 9606"},
        {"Geneva Identification System", "GEN# +1.00012704"},
        {"Smithsonian Astrophysical Observation", "SAO 193482"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.88601607),
        dec: Angle.Degrees(-37.19981669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110714"},
        {"Geneva Identification System", "GEN# -0.03714777"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.46962201),
        dec: Angle.Degrees(-37.19758817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27078"},
        {"Hipparcos Number", "HIP 19836"},
        {"Smithsonian Astrophysical Observation", "SAO 194870"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.79614160),
        dec: Angle.Degrees(-37.19690064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98271"},
        {"Hipparcos Number", "HIP 55184"},
        {"Geneva Identification System", "GEN# +1.00098271"},
        {"Smithsonian Astrophysical Observation", "SAO 202294"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.48141024),
        dec: Angle.Degrees(-37.19659928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141557"},
        {"Hipparcos Number", "HIP 77654"},
        {"Smithsonian Astrophysical Observation", "SAO 207043"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.79771495),
        dec: Angle.Degrees(-37.19570377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105734"},
        {"Hipparcos Number", "HIP 59332"},
        {"Smithsonian Astrophysical Observation", "SAO 203188"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.56692024),
        dec: Angle.Degrees(-37.19441936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216254"},
        {"Hipparcos Number", "HIP 112910"},
        {"Smithsonian Astrophysical Observation", "SAO 214145"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.98095126),
        dec: Angle.Degrees(-37.19204262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101883"},
        {"Hipparcos Number", "HIP 57165"},
        {"Fundamental Katalog 5th Edition", "FK5 2939"},
        {"Geneva Identification System", "GEN# +1.00101883"},
        {"Smithsonian Astrophysical Observation", "SAO 202744"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.86333833),
        dec: Angle.Degrees(-37.19010227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152637"},
        {"Hipparcos Number", "HIP 82869"},
        {"Smithsonian Astrophysical Observation", "SAO 208206"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.03905514),
        dec: Angle.Degrees(-37.18795605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33212"},
        {"Hipparcos Number", "HIP 23800"},
        {"Smithsonian Astrophysical Observation", "SAO 195564"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.71660636),
        dec: Angle.Degrees(-37.18710622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85206"},
        {"Hipparcos Number", "HIP 48191"},
        {"Geneva Identification System", "GEN# +1.00085206"},
        {"Smithsonian Astrophysical Observation", "SAO 200777"},
        {"Wilson Evans Batten Catalogue", "WEB 8997"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.36728577),
        dec: Angle.Degrees(-37.18678490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27359"},
        {"Geneva Identification System", "GEN# -0.03602458"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.91676194),
        dec: Angle.Degrees(-36.32826614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 769.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157902"},
        {"Hipparcos Number", "HIP 85445"},
        {"Smithsonian Astrophysical Observation", "SAO 208838"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.92246044),
        dec: Angle.Degrees(-37.18559698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39235"},
        {"Hipparcos Number", "HIP 27505"},
        {"Smithsonian Astrophysical Observation", "SAO 196213"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.35838821),
        dec: Angle.Degrees(-37.18510875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19915"},
        {"Hipparcos Number", "HIP 14782"},
        {"Smithsonian Astrophysical Observation", "SAO 194135"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.71539040),
        dec: Angle.Degrees(-37.18316789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148247"},
        {"Hipparcos Number", "HIP 80672"},
        {"Geneva Identification System", "GEN# +1.00148247"},
        {"Smithsonian Astrophysical Observation", "SAO 207688"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.06024024),
        dec: Angle.Degrees(-37.17981606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183625"},
        {"Hipparcos Number", "HIP 96069"},
        {"Geneva Identification System", "GEN# +1.00183625"},
        {"Smithsonian Astrophysical Observation", "SAO 211335"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.00022650),
        dec: Angle.Degrees(-37.17675492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46462"},
        {"Hipparcos Number", "HIP 31116"},
        {"Celescope Catalog", "CEL 1290"},
        {"Geneva Identification System", "GEN# +1.00046462"},
        {"Renson", "Renson 12430"},
        {"Smithsonian Astrophysical Observation", "SAO 196909"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.93833654),
        dec: Angle.Degrees(-37.17313995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161577"},
        {"Hipparcos Number", "HIP 87121"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.00197461),
        dec: Angle.Degrees(-37.17297876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62367"},
    },
    visualMagnitude: 11.80,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.71664814),
        dec: Angle.Degrees(-37.17033696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21208"},
        {"Hipparcos Number", "HIP 15836"},
        {"Smithsonian Astrophysical Observation", "SAO 194272"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.99776558),
        dec: Angle.Degrees(-37.17021309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148356"},
        {"Hipparcos Number", "HIP 80732"},
        {"Smithsonian Astrophysical Observation", "SAO 207699"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.23649176),
        dec: Angle.Degrees(-37.17000072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40775"},
        {"Smithsonian Astrophysical Observation", "SAO 199079"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.83215125),
        dec: Angle.Degrees(-37.16980816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140145"},
        {"Hipparcos Number", "HIP 77023"},
        {"Smithsonian Astrophysical Observation", "SAO 206905"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.89001030),
        dec: Angle.Degrees(-37.16948594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62801"},
        {"Hipparcos Number", "HIP 37711"},
        {"Smithsonian Astrophysical Observation", "SAO 198368"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.04492231),
        dec: Angle.Degrees(-37.16512213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205696"},
        {"Hipparcos Number", "HIP 106822"},
        {"Smithsonian Astrophysical Observation", "SAO 213151"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.51980604),
        dec: Angle.Degrees(-37.16416134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131574"},
        {"Hipparcos Number", "HIP 73030"},
        {"Geneva Identification System", "GEN# +1.00131574"},
        {"Smithsonian Astrophysical Observation", "SAO 206092"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.87522908),
        dec: Angle.Degrees(-37.16153452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15876"},
        {"Hipparcos Number", "HIP 11788"},
        {"Smithsonian Astrophysical Observation", "SAO 193758"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.03523606),
        dec: Angle.Degrees(-37.16135323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186668"},
        {"Hipparcos Number", "HIP 97354"},
        {"Smithsonian Astrophysical Observation", "SAO 211548"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.79657399),
        dec: Angle.Degrees(-37.16032397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52947"},
        {"Hipparcos Number", "HIP 33839"},
        {"Smithsonian Astrophysical Observation", "SAO 197488"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.37280704),
        dec: Angle.Degrees(-37.15990584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11050"},
        {"Hipparcos Number", "HIP 8369"},
        {"Geneva Identification System", "GEN# +1.00011050"},
        {"Smithsonian Astrophysical Observation", "SAO 193303"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.94903392),
        dec: Angle.Degrees(-37.15953257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83927"},
        {"Hipparcos Number", "HIP 47482"},
        {"Smithsonian Astrophysical Observation", "SAO 200624"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.18104531),
        dec: Angle.Degrees(-37.15949879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174427"},
        {"Hipparcos Number", "HIP 92596"},
        {"Smithsonian Astrophysical Observation", "SAO 210647"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.01603158),
        dec: Angle.Degrees(-37.15299981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21341"},
        {"Hipparcos Number", "HIP 15933"},
        {"Smithsonian Astrophysical Observation", "SAO 194283"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.30327196),
        dec: Angle.Degrees(-37.15268114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78286"},
        {"Hipparcos Number", "HIP 44668"},
        {"Geneva Identification System", "GEN# +1.00078286"},
        {"Smithsonian Astrophysical Observation", "SAO 199978"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.54165667),
        dec: Angle.Degrees(-37.15265187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163044"},
        {"Hipparcos Number", "HIP 87776"},
        {"Smithsonian Astrophysical Observation", "SAO 209479"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.96090189),
        dec: Angle.Degrees(-37.15264473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95105"},
        {"Hipparcos Number", "HIP 53631"},
        {"Smithsonian Astrophysical Observation", "SAO 201955"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.57323914),
        dec: Angle.Degrees(-37.15134358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125804"},
        {"Hipparcos Number", "HIP 70280"},
        {"Smithsonian Astrophysical Observation", "SAO 205493"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.69072684),
        dec: Angle.Degrees(-37.14937460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214913"},
        {"Hipparcos Number", "HIP 112083"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.53569048),
        dec: Angle.Degrees(-37.14928895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169257"},
        {"Hipparcos Number", "HIP 90302"},
        {"Smithsonian Astrophysical Observation", "SAO 210122"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.38105291),
        dec: Angle.Degrees(-37.14912883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202080"},
        {"Hipparcos Number", "HIP 104885"},
        {"Geneva Identification System", "GEN# +1.00202080"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.69327685),
        dec: Angle.Degrees(-37.14850506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74824"},
        {"Hipparcos Number", "HIP 42923"},
        {"Geneva Identification System", "GEN# +1.00074824"},
        {"Smithsonian Astrophysical Observation", "SAO 199573"},
        {"Wilson Evans Batten Catalogue", "WEB 8296"},
    },
    visualMagnitude: 5.74,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.21638717),
        dec: Angle.Degrees(-37.14725990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29992"},
        {"Hipparcos Number", "HIP 21861"},
        {"Fundamental Katalog 5th Edition", "FK5 1130"},
        {"Geneva Identification System", "GEN# +1.00029992"},
        {"Renson", "Renson 7700"},
        {"Smithsonian Astrophysical Observation", "SAO 195239"},
        {"Wilson Evans Batten Catalogue", "WEB 4205"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.51435953),
        dec: Angle.Degrees(-37.14476616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 193.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66741"},
        {"Hipparcos Number", "HIP 39415"},
        {"Smithsonian Astrophysical Observation", "SAO 198750"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.86256843),
        dec: Angle.Degrees(-37.14200401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115651"},
        {"Smithsonian Astrophysical Observation", "SAO 214538"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.42532087),
        dec: Angle.Degrees(-37.14145746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205891"},
        {"Hipparcos Number", "HIP 106931"},
        {"Geneva Identification System", "GEN# +1.00205891"},
        {"Smithsonian Astrophysical Observation", "SAO 213170"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.83679644),
        dec: Angle.Degrees(-37.14088468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94890"},
        {"Hipparcos Number", "HIP 53502"},
        {"Fundamental Katalog 5th Edition", "FK5 414"},
        {"Geneva Identification System", "GEN# +1.00094890"},
        {"Smithsonian Astrophysical Observation", "SAO 201927"},
        {"Wilson Evans Batten Catalogue", "WEB 9713"},
    },
    visualMagnitude: 4.60,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.17915128),
        dec: Angle.Degrees(-37.13746290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14248"},
        {"Hipparcos Number", "HIP 10675"},
        {"Smithsonian Astrophysical Observation", "SAO 193624"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.33858117),
        dec: Angle.Degrees(-37.13502200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89834"},
        {"Hipparcos Number", "HIP 50708"},
        {"Smithsonian Astrophysical Observation", "SAO 201305"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.31517085),
        dec: Angle.Degrees(-37.13272634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82949"},
        {"Hipparcos Number", "HIP 46949"},
        {"Smithsonian Astrophysical Observation", "SAO 200510"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.53021188),
        dec: Angle.Degrees(-37.13084617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110690"},
        {"Geneva Identification System", "GEN# -0.03714774"},
        {"Smithsonian Astrophysical Observation", "SAO 213809"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.38976530),
        dec: Angle.Degrees(-37.13071336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -343.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47948"},
        {"Hipparcos Number", "HIP 31830"},
        {"Geneva Identification System", "GEN# +1.00047948"},
        {"Smithsonian Astrophysical Observation", "SAO 197051"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.82956547),
        dec: Angle.Degrees(-37.12964583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120207"},
        {"Hipparcos Number", "HIP 67389"},
        {"Geneva Identification System", "GEN# +1.00120207"},
        {"Smithsonian Astrophysical Observation", "SAO 204864"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.17429224),
        dec: Angle.Degrees(-37.12740177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76668"},
        {"Hipparcos Number", "HIP 43880"},
        {"Fundamental Katalog 5th Edition", "FK5 2709"},
        {"Geneva Identification System", "GEN# +1.00076668"},
        {"Smithsonian Astrophysical Observation", "SAO 199803"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.08316076),
        dec: Angle.Degrees(-37.12246922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219457"},
        {"Hipparcos Number", "HIP 114878"},
        {"Geneva Identification System", "GEN# +1.00219457"},
        {"Smithsonian Astrophysical Observation", "SAO 214419"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.03806914),
        dec: Angle.Degrees(-37.12245155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112358"},
        {"Hipparcos Number", "HIP 63156"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.11628345),
        dec: Angle.Degrees(-37.12194389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22059"},
        {"Geneva Identification System", "GEN# -0.03701883"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.17409863),
        dec: Angle.Degrees(-37.12100310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40176"},
        {"Hipparcos Number", "HIP 28010"},
        {"Geneva Identification System", "GEN# +1.00040176"},
        {"Smithsonian Astrophysical Observation", "SAO 196316"},
        {"Wilson Evans Batten Catalogue", "WEB 5488"},
    },
    visualMagnitude: 4.97,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.87454313),
        dec: Angle.Degrees(-37.12060931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215423"},
        {"Hipparcos Number", "HIP 112375"},
        {"Smithsonian Astrophysical Observation", "SAO 214059"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.40813894),
        dec: Angle.Degrees(-37.11920221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44513"},
    },
    visualMagnitude: 11.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.04634972),
        dec: Angle.Degrees(-35.70721755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13032"},
        {"Hipparcos Number", "HIP 9841"},
        {"Smithsonian Astrophysical Observation", "SAO 193509"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.65448171),
        dec: Angle.Degrees(-37.11863610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116079"},
        {"Hipparcos Number", "HIP 65213"},
        {"Smithsonian Astrophysical Observation", "SAO 204391"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.46840944),
        dec: Angle.Degrees(-37.11759106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222836"},
        {"Hipparcos Number", "HIP 117090"},
        {"Smithsonian Astrophysical Observation", "SAO 214743"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.05462409),
        dec: Angle.Degrees(-37.11570027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78644"},
        {"Hipparcos Number", "HIP 44851"},
        {"Geneva Identification System", "GEN# +1.00078644"},
        {"Smithsonian Astrophysical Observation", "SAO 200016"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.07163077),
        dec: Angle.Degrees(-37.11486332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157707"},
        {"Hipparcos Number", "HIP 85352"},
        {"Fundamental Katalog 5th Edition", "FK5 5535"},
        {"Smithsonian Astrophysical Observation", "SAO 208814"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.62284164),
        dec: Angle.Degrees(-37.11219318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160224"},
        {"Hipparcos Number", "HIP 86484"},
        {"Geneva Identification System", "GEN# +1.00160224"},
        {"Smithsonian Astrophysical Observation", "SAO 209112"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.09125896),
        dec: Angle.Degrees(-37.11185748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216185"},
        {"Hipparcos Number", "HIP 112851"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.80565268),
        dec: Angle.Degrees(-37.10981305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194325"},
        {"Hipparcos Number", "HIP 100813"},
        {"Fundamental Katalog 5th Edition", "FK5 5803"},
        {"Smithsonian Astrophysical Observation", "SAO 212117"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.60886005),
        dec: Angle.Degrees(-37.10915085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204745"},
        {"Hipparcos Number", "HIP 106298"},
        {"Smithsonian Astrophysical Observation", "SAO 213068"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.93876763),
        dec: Angle.Degrees(-37.10882288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167711"},
        {"Hipparcos Number", "HIP 89679"},
        {"Smithsonian Astrophysical Observation", "SAO 209968"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.52021077),
        dec: Angle.Degrees(-37.10786214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13887"},
        {"Hipparcos Number", "HIP 10426"},
        {"Smithsonian Astrophysical Observation", "SAO 193591"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.58516251),
        dec: Angle.Degrees(-37.10782815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196082"},
        {"Hipparcos Number", "HIP 101653"},
        {"Smithsonian Astrophysical Observation", "SAO 212274"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.09366729),
        dec: Angle.Degrees(-37.10738100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175813"},
        {"Hipparcos Number", "HIP 93174"},
        {"Fundamental Katalog 5th Edition", "FK5 3512"},
        {"Geneva Identification System", "GEN# +1.00175813"},
        {"Smithsonian Astrophysical Observation", "SAO 210781"},
        {"Wilson Evans Batten Catalogue", "WEB 16142"},
    },
    visualMagnitude: 4.83,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.68114151),
        dec: Angle.Degrees(-37.10708855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204097"},
        {"Hipparcos Number", "HIP 105945"},
        {"Smithsonian Astrophysical Observation", "SAO 213011"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.84346201),
        dec: Angle.Degrees(-37.10703479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22229"},
        {"Hipparcos Number", "HIP 16577"},
        {"Smithsonian Astrophysical Observation", "SAO 194370"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.34754204),
        dec: Angle.Degrees(-37.10494133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53015"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.69154616),
        dec: Angle.Degrees(-04.73842746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85927",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Shaula"},
        {"Henry Draper", "HD 158926"},
        {"Hipparcos Number", "HIP 85927"},
        {"Fundamental Katalog 5th Edition", "FK5 652"},
        {"Geneva Identification System", "GEN# +1.00158926"},
        {"Smithsonian Astrophysical Observation", "SAO 208954"},
        {"Wilson Evans Batten Catalogue", "WEB 14501"},
    },
    visualMagnitude: 1.62,
    bvColour: -0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.40219373),
        dec: Angle.Degrees(-37.10374835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84749"},
        {"Smithsonian Astrophysical Observation", "SAO 208683"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.85406663),
        dec: Angle.Degrees(-37.10367015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45698"},
        {"Hipparcos Number", "HIP 30712"},
        {"Geneva Identification System", "GEN# +1.00045698"},
        {"Renson", "Renson 12150"},
        {"Smithsonian Astrophysical Observation", "SAO 196844"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.79724905),
        dec: Angle.Degrees(-37.10208358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154337"},
        {"Hipparcos Number", "HIP 83701"},
        {"Geneva Identification System", "GEN# +1.00154337"},
        {"Smithsonian Astrophysical Observation", "SAO 208407"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.59689904),
        dec: Angle.Degrees(-37.10135996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69644"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.81014046),
        dec: Angle.Degrees(-37.10031858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118335"},
        {"Hipparcos Number", "HIP 66419"},
        {"Geneva Identification System", "GEN# +1.00118335"},
        {"Smithsonian Astrophysical Observation", "SAO 204656"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.25143293),
        dec: Angle.Degrees(-37.10024485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224443"},
        {"Hipparcos Number", "HIP 118147"},
        {"Geneva Identification System", "GEN# +1.00224443"},
        {"Smithsonian Astrophysical Observation", "SAO 214882"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.47947203),
        dec: Angle.Degrees(-37.09875316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82852"},
        {"Smithsonian Astrophysical Observation", "SAO 208200"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.98001933),
        dec: Angle.Degrees(-37.09852140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209228"},
        {"Hipparcos Number", "HIP 108808"},
        {"Smithsonian Astrophysical Observation", "SAO 213494"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.63735035),
        dec: Angle.Degrees(-37.09816275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217725"},
        {"Hipparcos Number", "HIP 113823"},
        {"Smithsonian Astrophysical Observation", "SAO 214267"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.75153148),
        dec: Angle.Degrees(-37.09769547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56855"},
        {"Hipparcos Number", "HIP 35264"},
        {"Fundamental Katalog 5th Edition", "FK5 278"},
        {"Geneva Identification System", "GEN# +1.00056855"},
        {"Smithsonian Astrophysical Observation", "SAO 197795"},
        {"Wilson Evans Batten Catalogue", "WEB 7041"},
    },
    visualMagnitude: 2.71,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.28568399),
        dec: Angle.Degrees(-37.09748689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130779"},
        {"Hipparcos Number", "HIP 72639"},
        {"Geneva Identification System", "GEN# +1.00130779"},
        {"Smithsonian Astrophysical Observation", "SAO 206004"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.76386696),
        dec: Angle.Degrees(-37.09704437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136014"},
        {"Hipparcos Number", "HIP 75003"},
        {"Geneva Identification System", "GEN# +1.00136014"},
        {"Smithsonian Astrophysical Observation", "SAO 206523"},
        {"Wilson Evans Batten Catalogue", "WEB 12793"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.88240574),
        dec: Angle.Degrees(-37.09680759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190530"},
        {"Hipparcos Number", "HIP 99062"},
        {"Smithsonian Astrophysical Observation", "SAO 211813"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.67588981),
        dec: Angle.Degrees(-37.08917872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62659"},
        {"Hipparcos Number", "HIP 37653"},
        {"Celescope Catalog", "CEL 1997"},
        {"Geneva Identification System", "GEN# +1.00062659"},
        {"Smithsonian Astrophysical Observation", "SAO 198349"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.90005551),
        dec: Angle.Degrees(-37.08914867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170706"},
        {"Hipparcos Number", "HIP 90896"},
        {"Geneva Identification System", "GEN# +1.00170706"},
        {"Smithsonian Astrophysical Observation", "SAO 210282"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.11327738),
        dec: Angle.Degrees(-37.08833290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30967"},
        {"Hipparcos Number", "HIP 22493"},
        {"Smithsonian Astrophysical Observation", "SAO 195340"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.58833153),
        dec: Angle.Degrees(-37.08694626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105094"},
        {"Hipparcos Number", "HIP 59019"},
        {"Geneva Identification System", "GEN# +1.00105094"},
        {"Smithsonian Astrophysical Observation", "SAO 203122"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.50957957),
        dec: Angle.Degrees(-37.08667945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84134"},
        {"Hipparcos Number", "HIP 47572"},
        {"Smithsonian Astrophysical Observation", "SAO 200646"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.50728104),
        dec: Angle.Degrees(-37.08270111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12463"},
        {"Hipparcos Number", "HIP 9443"},
        {"Geneva Identification System", "GEN# +1.00012463"},
        {"Smithsonian Astrophysical Observation", "SAO 193457"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.32749999),
        dec: Angle.Degrees(-37.08079093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5265"},
        {"Hipparcos Number", "HIP 4226"},
        {"Geneva Identification System", "GEN# +1.00005265"},
        {"Smithsonian Astrophysical Observation", "SAO 192803"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.47653036),
        dec: Angle.Degrees(-37.07998371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150420"},
        {"Hipparcos Number", "HIP 81803"},
        {"Smithsonian Astrophysical Observation", "SAO 207943"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.62127741),
        dec: Angle.Degrees(-37.07914846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203057"},
        {"Hipparcos Number", "HIP 105392"},
        {"Smithsonian Astrophysical Observation", "SAO 212928"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.21586284),
        dec: Angle.Degrees(-37.07809274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61075"},
        {"Hipparcos Number", "HIP 36959"},
        {"Smithsonian Astrophysical Observation", "SAO 198173"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.97345095),
        dec: Angle.Degrees(-37.07789258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157192"},
        {"Hipparcos Number", "HIP 85094"},
        {"Smithsonian Astrophysical Observation", "SAO 208758"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.87469052),
        dec: Angle.Degrees(-37.07756888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212854"},
        {"Hipparcos Number", "HIP 110884"},
        {"Smithsonian Astrophysical Observation", "SAO 213838"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.96725164),
        dec: Angle.Degrees(-37.07753792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181893"},
        {"Hipparcos Number", "HIP 95337"},
        {"Geneva Identification System", "GEN# +1.00181893"},
        {"Smithsonian Astrophysical Observation", "SAO 211227"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.93689195),
        dec: Angle.Degrees(-37.07717447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41070"},
        {"Hipparcos Number", "HIP 28504"},
        {"Smithsonian Astrophysical Observation", "SAO 196410"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.26297157),
        dec: Angle.Degrees(-37.07160728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25786"},
        {"Hipparcos Number", "HIP 18956"},
        {"Renson", "Renson 6550"},
        {"Smithsonian Astrophysical Observation", "SAO 194726"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.93490246),
        dec: Angle.Degrees(-37.07019806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17765"},
        {"Hipparcos Number", "HIP 13200"},
        {"Smithsonian Astrophysical Observation", "SAO 193938"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.47235314),
        dec: Angle.Degrees(-37.06754158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211397"},
        {"Hipparcos Number", "HIP 110059"},
        {"Smithsonian Astrophysical Observation", "SAO 213703"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.37533398),
        dec: Angle.Degrees(-37.06649546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131700"},
        {"Hipparcos Number", "HIP 73089"},
        {"Smithsonian Astrophysical Observation", "SAO 206105"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.05710607),
        dec: Angle.Degrees(-37.06628076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100850"},
        {"Hipparcos Number", "HIP 56594"},
        {"Geneva Identification System", "GEN# +1.00100850"},
        {"Smithsonian Astrophysical Observation", "SAO 202615"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.04725057),
        dec: Angle.Degrees(-37.06422410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18180"},
        {"Geneva Identification System", "GEN# -0.03701501"},
    },
    visualMagnitude: 12.13,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.33331726),
        dec: Angle.Degrees(-37.06378375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -408.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1084.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93825"},
        {"Smithsonian Astrophysical Observation", "SAO 210928"},
    },
    visualMagnitude: 4.23,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.60433158),
        dec: Angle.Degrees(-37.06275714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26242"},
        {"Hipparcos Number", "HIP 19256"},
        {"Geneva Identification System", "GEN# +1.00026242"},
        {"Smithsonian Astrophysical Observation", "SAO 194782"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.90596605),
        dec: Angle.Degrees(-37.06194983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5725"},
        {"Hipparcos Number", "HIP 4568"},
        {"Geneva Identification System", "GEN# +1.00005725"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.61269010),
        dec: Angle.Degrees(-37.06169838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176270"},
        {"Hipparcos Number", "HIP 93371"},
        {"Smithsonian Astrophysical Observation", "SAO 210816"},
        {"Wilson Evans Batten Catalogue", "WEB 16189"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.26792264),
        dec: Angle.Degrees(-37.06150446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176269"},
        {"Hipparcos Number", "HIP 93368"},
        {"Geneva Identification System", "GEN# +1.00176269"},
        {"Smithsonian Astrophysical Observation", "SAO 210815"},
        {"Wilson Evans Batten Catalogue", "WEB 16188"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.26354736),
        dec: Angle.Degrees(-37.06085142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40865"},
        {"Hipparcos Number", "HIP 28403"},
        {"Geneva Identification System", "GEN# +1.00040865"},
        {"Smithsonian Astrophysical Observation", "SAO 196395"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.98179235),
        dec: Angle.Degrees(-37.05716916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 182.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19737"},
        {"Smithsonian Astrophysical Observation", "SAO 194850"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.47616773),
        dec: Angle.Degrees(-37.05669365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118587"},
        {"Hipparcos Number", "HIP 66554"},
        {"Smithsonian Astrophysical Observation", "SAO 204687"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.64281633),
        dec: Angle.Degrees(-37.05400202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167253"},
        {"Hipparcos Number", "HIP 89513"},
        {"Smithsonian Astrophysical Observation", "SAO 209925"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.99602640),
        dec: Angle.Degrees(-37.05368570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158287"},
        {"Hipparcos Number", "HIP 85635"},
        {"Smithsonian Astrophysical Observation", "SAO 208880"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.51515121),
        dec: Angle.Degrees(-37.05366005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8351"},
        {"Hipparcos Number", "HIP 6393"},
        {"Geneva Identification System", "GEN# +1.00008351"},
        {"Smithsonian Astrophysical Observation", "SAO 193072"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.53848700),
        dec: Angle.Degrees(-37.05156189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44381"},
        {"Hipparcos Number", "HIP 30078"},
        {"Smithsonian Astrophysical Observation", "SAO 196691"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.94912189),
        dec: Angle.Degrees(-37.05115655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66435"},
        {"Hipparcos Number", "HIP 39299"},
        {"Geneva Identification System", "GEN# +1.00066435"},
        {"Smithsonian Astrophysical Observation", "SAO 198725"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.52554892),
        dec: Angle.Degrees(-37.05007505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58136"},
        {"Hipparcos Number", "HIP 35764"},
        {"Geneva Identification System", "GEN# +1.00058136"},
        {"Smithsonian Astrophysical Observation", "SAO 197920"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.65125263),
        dec: Angle.Degrees(-37.04892909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54284",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54284"},
        {"Smithsonian Astrophysical Observation", "SAO 202091"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.57573102),
        dec: Angle.Degrees(-37.04849256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206292"},
        {"Hipparcos Number", "HIP 107137"},
        {"Smithsonian Astrophysical Observation", "SAO 213211"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.52351194),
        dec: Angle.Degrees(-37.04795270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201018"},
        {"Hipparcos Number", "HIP 104337"},
        {"Renson", "Renson 56040"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.03168533),
        dec: Angle.Degrees(-37.04519290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23357"},
        {"Hipparcos Number", "HIP 17368"},
        {"Geneva Identification System", "GEN# +1.00023357"},
        {"Renson", "Renson 5960"},
        {"Smithsonian Astrophysical Observation", "SAO 194479"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.77972284),
        dec: Angle.Degrees(-37.04377543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87261",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Fuyue"},
        {"Henry Draper", "HD 161892"},
        {"Hipparcos Number", "HIP 87261"},
        {"Fundamental Katalog 5th Edition", "FK5 669"},
        {"Geneva Identification System", "GEN# +1.00161892"},
        {"Smithsonian Astrophysical Observation", "SAO 209318"},
        {"Wilson Evans Batten Catalogue", "WEB 14720"},
    },
    visualMagnitude: 3.19,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.46438020),
        dec: Angle.Degrees(-37.04337105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214485"},
        {"Hipparcos Number", "HIP 111827"},
        {"Geneva Identification System", "GEN# +1.00214485"},
        {"Smithsonian Astrophysical Observation", "SAO 213985"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.76241263),
        dec: Angle.Degrees(-37.04277722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38703"},
        {"Hipparcos Number", "HIP 27201"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.48810180),
        dec: Angle.Degrees(-37.04233211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11459"},
        {"Hipparcos Number", "HIP 8694"},
        {"Geneva Identification System", "GEN# +1.00011459"},
        {"Smithsonian Astrophysical Observation", "SAO 193342"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.96748295),
        dec: Angle.Degrees(-37.04206688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111340"},
        {"Hipparcos Number", "HIP 62535"},
        {"Geneva Identification System", "GEN# +1.00111340"},
        {"Smithsonian Astrophysical Observation", "SAO 203830"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.21667262),
        dec: Angle.Degrees(-37.04181195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20379"},
        {"Hipparcos Number", "HIP 15152"},
        {"Smithsonian Astrophysical Observation", "SAO 194184"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.82117142),
        dec: Angle.Degrees(-37.04168169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126935"},
        {"Hipparcos Number", "HIP 70868"},
        {"Smithsonian Astrophysical Observation", "SAO 205609"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.38625498),
        dec: Angle.Degrees(-37.03945517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40951"},
        {"Hipparcos Number", "HIP 28450"},
        {"Geneva Identification System", "GEN# +1.00040951"},
        {"Smithsonian Astrophysical Observation", "SAO 196402"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.10820290),
        dec: Angle.Degrees(-37.03925662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -237.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100939"},
        {"Hipparcos Number", "HIP 56640"},
        {"Smithsonian Astrophysical Observation", "SAO 202628"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.20069313),
        dec: Angle.Degrees(-37.03903754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209508"},
        {"Hipparcos Number", "HIP 108984"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.18303363),
        dec: Angle.Degrees(-37.03900834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183198"},
        {"Hipparcos Number", "HIP 95864"},
        {"Geneva Identification System", "GEN# +1.00183198"},
        {"Smithsonian Astrophysical Observation", "SAO 211306"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.46308691),
        dec: Angle.Degrees(-37.03792368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77154"},
        {"Hipparcos Number", "HIP 44153"},
        {"Smithsonian Astrophysical Observation", "SAO 199861"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.88260117),
        dec: Angle.Degrees(-37.03716881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42137"},
        {"Hipparcos Number", "HIP 29009"},
        {"Smithsonian Astrophysical Observation", "SAO 196509"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.82137493),
        dec: Angle.Degrees(-37.03656348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116572"},
        {"Hipparcos Number", "HIP 65459"},
        {"Geneva Identification System", "GEN# +1.00116572"},
        {"Smithsonian Astrophysical Observation", "SAO 204445"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.24825389),
        dec: Angle.Degrees(-37.03595366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195080"},
        {"Hipparcos Number", "HIP 101178"},
        {"Smithsonian Astrophysical Observation", "SAO 212186"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.62387271),
        dec: Angle.Degrees(-37.03511970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199656"},
        {"Hipparcos Number", "HIP 103631"},
        {"Smithsonian Astrophysical Observation", "SAO 212603"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.95076998),
        dec: Angle.Degrees(-37.03174512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26934"},
        {"Hipparcos Number", "HIP 19741"},
        {"Fundamental Katalog 5th Edition", "FK5 2309"},
        {"Smithsonian Astrophysical Observation", "SAO 194852"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.48855292),
        dec: Angle.Degrees(-37.03036602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136533"},
        {"Hipparcos Number", "HIP 75244"},
        {"Smithsonian Astrophysical Observation", "SAO 206567"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.62516704),
        dec: Angle.Degrees(-37.02844266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59351"},
        {"Hipparcos Number", "HIP 36257"},
        {"Smithsonian Astrophysical Observation", "SAO 198024"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.99482540),
        dec: Angle.Degrees(-37.02269225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65723"},
        {"Hipparcos Number", "HIP 38981"},
        {"Geneva Identification System", "GEN# +1.00065723"},
        {"Smithsonian Astrophysical Observation", "SAO 198657"},
        {"Wilson Evans Batten Catalogue", "WEB 7645"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.65682328),
        dec: Angle.Degrees(-37.02006625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173488"},
        {"Hipparcos Number", "HIP 92173"},
        {"Smithsonian Astrophysical Observation", "SAO 210566"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.79045790),
        dec: Angle.Degrees(-37.02006310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123835"},
        {"Hipparcos Number", "HIP 69263"},
        {"Smithsonian Astrophysical Observation", "SAO 205264"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.69423708),
        dec: Angle.Degrees(-37.01771556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115431"},
        {"Hipparcos Number", "HIP 64859"},
        {"Smithsonian Astrophysical Observation", "SAO 204325"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.40945023),
        dec: Angle.Degrees(-37.01720138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12198"},
        {"Hipparcos Number", "HIP 9251"},
        {"Smithsonian Astrophysical Observation", "SAO 193428"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.72890255),
        dec: Angle.Degrees(-37.01685785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75007"},
        {"Hipparcos Number", "HIP 43031"},
        {"Smithsonian Astrophysical Observation", "SAO 199593"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.52107346),
        dec: Angle.Degrees(-37.01494273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45098"},
        {"Hipparcos Number", "HIP 30418"},
        {"Celescope Catalog", "CEL 1223"},
        {"Geneva Identification System", "GEN# +1.00045098"},
        {"Smithsonian Astrophysical Observation", "SAO 196769"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.93854167),
        dec: Angle.Degrees(-37.01460328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173712"},
        {"Hipparcos Number", "HIP 92275"},
        {"Smithsonian Astrophysical Observation", "SAO 210584"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.09054122),
        dec: Angle.Degrees(-37.01346698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15403"},
        {"Hipparcos Number", "HIP 11459"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.95673899),
        dec: Angle.Degrees(-37.01238577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28740"},
        {"Hipparcos Number", "HIP 21005"},
        {"Smithsonian Astrophysical Observation", "SAO 195079"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.56917799),
        dec: Angle.Degrees(-37.01224754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2254"},
        {"Smithsonian Astrophysical Observation", "SAO 192553"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.17487513),
        dec: Angle.Degrees(-37.01068181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170038"},
        {"Hipparcos Number", "HIP 90590"},
        {"Geneva Identification System", "GEN# +1.00170038"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.28099852),
        dec: Angle.Degrees(-37.00998299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144528"},
        {"Hipparcos Number", "HIP 79026"},
        {"Smithsonian Astrophysical Observation", "SAO 207354"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.94937960),
        dec: Angle.Degrees(-37.00998067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14701"},
        {"Hipparcos Number", "HIP 10976"},
        {"Geneva Identification System", "GEN# +1.00014701"},
        {"Smithsonian Astrophysical Observation", "SAO 193660"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.34481758),
        dec: Angle.Degrees(-37.00785958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7488"},
        {"Hipparcos Number", "HIP 5798"},
        {"Fundamental Katalog 5th Edition", "FK5 4110"},
        {"Geneva Identification System", "GEN# +1.00007488"},
        {"Smithsonian Astrophysical Observation", "SAO 193002"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.59757212),
        dec: Angle.Degrees(-37.00725909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65750"},
        {"Smithsonian Astrophysical Observation", "SAO 204506"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.17314395),
        dec: Angle.Degrees(-37.00316622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50000"},
        {"Hipparcos Number", "HIP 32712"},
        {"Renson", "Renson 13570"},
        {"Smithsonian Astrophysical Observation", "SAO 197255"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.37011512),
        dec: Angle.Degrees(-37.00308963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125283"},
        {"Hipparcos Number", "HIP 69995"},
        {"Celescope Catalog", "CEL 4312"},
        {"Geneva Identification System", "GEN# +1.00125283"},
        {"Smithsonian Astrophysical Observation", "SAO 205430"},
        {"Wilson Evans Batten Catalogue", "WEB 12173"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.84964562),
        dec: Angle.Degrees(-37.00280675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184374"},
        {"Hipparcos Number", "HIP 96374"},
        {"Geneva Identification System", "GEN# +1.00184374"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.90822436),
        dec: Angle.Degrees(-37.00268003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135343"},
        {"Hipparcos Number", "HIP 74691"},
        {"Smithsonian Astrophysical Observation", "SAO 206465"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.96974967),
        dec: Angle.Degrees(-36.99875479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194047"},
        {"Hipparcos Number", "HIP 100692"},
        {"Smithsonian Astrophysical Observation", "SAO 212093"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.20456508),
        dec: Angle.Degrees(-36.99626288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169972"},
        {"Hipparcos Number", "HIP 90564"},
        {"Geneva Identification System", "GEN# +1.00169972"},
        {"Smithsonian Astrophysical Observation", "SAO 210205"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.19615211),
        dec: Angle.Degrees(-36.99589145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40720"},
        {"Hipparcos Number", "HIP 28310"},
        {"Geneva Identification System", "GEN# +1.00040720"},
        {"Smithsonian Astrophysical Observation", "SAO 196377"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.73345231),
        dec: Angle.Degrees(-36.99414180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123702"},
        {"Hipparcos Number", "HIP 69200"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.51389873),
        dec: Angle.Degrees(-36.99390804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47500"},
        {"Hipparcos Number", "HIP 31637"},
        {"Celescope Catalog", "CEL 1327"},
        {"Geneva Identification System", "GEN# +1.00047500J"},
        {"Smithsonian Astrophysical Observation", "SAO 197014"},
        {"Wilson Evans Batten Catalogue", "WEB 6334"},
    },
    visualMagnitude: 5.72,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.30767433),
        dec: Angle.Degrees(-36.99068388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68761"},
        {"Hipparcos Number", "HIP 40181"},
        {"Celescope Catalog", "CEL 2233"},
        {"Geneva Identification System", "GEN# +1.00068761"},
        {"Smithsonian Astrophysical Observation", "SAO 198931"},
        {"Wilson Evans Batten Catalogue", "WEB 7839"},
    },
    visualMagnitude: 6.54,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.11405048),
        dec: Angle.Degrees(-36.98924573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182912"},
        {"Hipparcos Number", "HIP 95743"},
        {"Smithsonian Astrophysical Observation", "SAO 211288"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.10746458),
        dec: Angle.Degrees(-36.98894724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50267"},
        {"Hipparcos Number", "HIP 32843"},
        {"Smithsonian Astrophysical Observation", "SAO 197275"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.69003784),
        dec: Angle.Degrees(-36.98295331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110987"},
        {"Smithsonian Astrophysical Observation", "SAO 213858"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.28584019),
        dec: Angle.Degrees(-36.98292228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73041"},
        {"Hipparcos Number", "HIP 42095"},
        {"Geneva Identification System", "GEN# +1.00073041"},
        {"Smithsonian Astrophysical Observation", "SAO 199392"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.69694627),
        dec: Angle.Degrees(-36.98249252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17576"},
        {"Hipparcos Number", "HIP 13080"},
        {"Smithsonian Astrophysical Observation", "SAO 193923"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.03298114),
        dec: Angle.Degrees(-36.98166764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136625"},
        {"Hipparcos Number", "HIP 75290"},
        {"Smithsonian Astrophysical Observation", "SAO 206577"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.74179335),
        dec: Angle.Degrees(-36.98045389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55947"},
    },
    visualMagnitude: 11.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.98430401),
        dec: Angle.Degrees(-36.97932006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32491"},
        {"Hipparcos Number", "HIP 23412"},
        {"Fundamental Katalog 5th Edition", "FK5 4462"},
        {"Geneva Identification System", "GEN# +1.00032491"},
        {"Smithsonian Astrophysical Observation", "SAO 195503"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.47660996),
        dec: Angle.Degrees(-36.97843303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12078"},
        {"Hipparcos Number", "HIP 9130"},
        {"Smithsonian Astrophysical Observation", "SAO 193409"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.42371995),
        dec: Angle.Degrees(-36.97744758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112669"},
        {"Hipparcos Number", "HIP 63347"},
        {"Smithsonian Astrophysical Observation", "SAO 204000"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.70735884),
        dec: Angle.Degrees(-36.97566905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204804"},
        {"Hipparcos Number", "HIP 106319"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.00875430),
        dec: Angle.Degrees(-36.97178336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213019"},
        {"Hipparcos Number", "HIP 110984"},
        {"Smithsonian Astrophysical Observation", "SAO 213857"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.28022211),
        dec: Angle.Degrees(-36.97004303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190216"},
        {"Hipparcos Number", "HIP 98938"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.32818053),
        dec: Angle.Degrees(-36.96678668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164004"},
        {"Hipparcos Number", "HIP 88195"},
        {"Smithsonian Astrophysical Observation", "SAO 209585"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.16332812),
        dec: Angle.Degrees(-36.96670278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165774"},
        {"Hipparcos Number", "HIP 88940"},
        {"Smithsonian Astrophysical Observation", "SAO 209775"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.32158357),
        dec: Angle.Degrees(-36.96598565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20157"},
        {"Hipparcos Number", "HIP 14973"},
        {"Smithsonian Astrophysical Observation", "SAO 194164"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.25757726),
        dec: Angle.Degrees(-36.96563624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75584"},
        {"Hipparcos Number", "HIP 43321"},
        {"Geneva Identification System", "GEN# +1.00075584"},
        {"Smithsonian Astrophysical Observation", "SAO 199671"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.39454604),
        dec: Angle.Degrees(-36.96246037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221240"},
        {"Hipparcos Number", "HIP 116024"},
        {"Geneva Identification System", "GEN# +1.00221240"},
        {"Smithsonian Astrophysical Observation", "SAO 214591"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.64248390),
        dec: Angle.Degrees(-36.95746424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94105"},
        {"Hipparcos Number", "HIP 53046"},
        {"Smithsonian Astrophysical Observation", "SAO 201827"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.79991306),
        dec: Angle.Degrees(-36.95727536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114088"},
        {"Hipparcos Number", "HIP 64137"},
        {"Smithsonian Astrophysical Observation", "SAO 204164"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.16923782),
        dec: Angle.Degrees(-36.95641874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42397"},
        {"Smithsonian Astrophysical Observation", "SAO 199461"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.67898243),
        dec: Angle.Degrees(-36.95532543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48113"},
        {"Hipparcos Number", "HIP 31898"},
        {"Smithsonian Astrophysical Observation", "SAO 197066"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.01237277),
        dec: Angle.Degrees(-36.95505714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81449"},
        {"Hipparcos Number", "HIP 46142"},
        {"Smithsonian Astrophysical Observation", "SAO 200337"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.15079287),
        dec: Angle.Degrees(-36.95227796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93449"},
        {"Geneva Identification System", "GEN# -0.03713027"},
        {"Wilson Evans Batten Catalogue", "WEB 16219"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.47364755),
        dec: Angle.Degrees(-36.95224000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69106"},
        {"Hipparcos Number", "HIP 40328"},
        {"Celescope Catalog", "CEL 2260"},
        {"Geneva Identification System", "GEN# +1.00069106"},
        {"Smithsonian Astrophysical Observation", "SAO 198971"},
        {"Wilson Evans Batten Catalogue", "WEB 7865"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.51584518),
        dec: Angle.Degrees(-36.95221764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179831"},
        {"Hipparcos Number", "HIP 94651"},
        {"Smithsonian Astrophysical Observation", "SAO 211097"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.89752167),
        dec: Angle.Degrees(-36.94930430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118613"},
        {"Hipparcos Number", "HIP 66568"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.68026566),
        dec: Angle.Degrees(-36.94763499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29086"},
        {"Hipparcos Number", "HIP 21223"},
        {"Geneva Identification System", "GEN# +1.00029086"},
        {"Smithsonian Astrophysical Observation", "SAO 195121"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.28897895),
        dec: Angle.Degrees(-36.94615167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160668"},
        {"Hipparcos Number", "HIP 86698"},
        {"Geneva Identification System", "GEN# +1.00160668"},
        {"Smithsonian Astrophysical Observation", "SAO 209172"},
        {"Wilson Evans Batten Catalogue", "WEB 14619"},
    },
    visualMagnitude: 5.53,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.71288389),
        dec: Angle.Degrees(-36.94550742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218037"},
        {"Hipparcos Number", "HIP 114003"},
        {"Smithsonian Astrophysical Observation", "SAO 214298"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.31904408),
        dec: Angle.Degrees(-36.94547218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67626"},
        {"Wilson Evans Batten Catalogue", "WEB 11892"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.85607684),
        dec: Angle.Degrees(-36.94377710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40178"},
        {"Geneva Identification System", "GEN# -0.03604319"},
        {"Smithsonian Astrophysical Observation", "SAO 198930"},
        {"Wilson Evans Batten Catalogue", "WEB 7838"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.09335962),
        dec: Angle.Degrees(-36.94376906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93297"},
        {"Hipparcos Number", "HIP 52635"},
        {"Smithsonian Astrophysical Observation", "SAO 201720"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.45647065),
        dec: Angle.Degrees(-36.94352901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39793"},
        {"Hipparcos Number", "HIP 27812"},
        {"Smithsonian Astrophysical Observation", "SAO 196279"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.28102012),
        dec: Angle.Degrees(-36.94252602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46431"},
        {"Hipparcos Number", "HIP 31099"},
        {"Fundamental Katalog 5th Edition", "FK5 2501"},
        {"Geneva Identification System", "GEN# +1.00046431"},
        {"Smithsonian Astrophysical Observation", "SAO 196906"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.89561314),
        dec: Angle.Degrees(-36.94019636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8389"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.05516861),
        dec: Angle.Degrees(-36.93974821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4597"},
        {"Hipparcos Number", "HIP 3704"},
        {"Cincinnati Publication", "Ci 18 103"},
        {"Cincinnati Publication 2", "Ci 20 54"},
        {"Geneva Identification System", "GEN# +1.00004597"},
        {"Smithsonian Astrophysical Observation", "SAO 192744"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.87869685),
        dec: Angle.Degrees(-36.93934176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -350.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163708"},
        {"Hipparcos Number", "HIP 88069"},
        {"Smithsonian Astrophysical Observation", "SAO 209552"},
        {"Wilson Evans Batten Catalogue", "WEB 14876"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.80609020),
        dec: Angle.Degrees(-36.93881859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144752"},
        {"Hipparcos Number", "HIP 79118"},
        {"Smithsonian Astrophysical Observation", "SAO 207374"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.24048380),
        dec: Angle.Degrees(-36.93829341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115411"},
        {"Hipparcos Number", "HIP 64846"},
    },
    visualMagnitude: 9.93,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.38936179),
        dec: Angle.Degrees(-36.93807006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140757"},
        {"Hipparcos Number", "HIP 77295"},
        {"Smithsonian Astrophysical Observation", "SAO 206964"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.71521938),
        dec: Angle.Degrees(-36.93678876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3357"},
        {"Hipparcos Number", "HIP 2855"},
        {"Smithsonian Astrophysical Observation", "SAO 192629"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.03930253),
        dec: Angle.Degrees(-36.93662441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1645"},
        {"Hipparcos Number", "HIP 1636"},
        {"Smithsonian Astrophysical Observation", "SAO 192470"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.12100148),
        dec: Angle.Degrees(-36.93641775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64674"},
        {"Hipparcos Number", "HIP 38544"},
        {"Geneva Identification System", "GEN# +1.00064674"},
        {"Smithsonian Astrophysical Observation", "SAO 198565"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.39017329),
        dec: Angle.Degrees(-36.93613947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102980"},
        {"Hipparcos Number", "HIP 57807"},
        {"Smithsonian Astrophysical Observation", "SAO 202873"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.79688666),
        dec: Angle.Degrees(-36.93580192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6620"},
        {"Hipparcos Number", "HIP 5196"},
        {"Smithsonian Astrophysical Observation", "SAO 192926"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.61238154),
        dec: Angle.Degrees(-36.93544530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16676"},
        {"Hipparcos Number", "HIP 12380"},
        {"Smithsonian Astrophysical Observation", "SAO 193839"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.84667738),
        dec: Angle.Degrees(-36.93471053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82097"},
        {"Hipparcos Number", "HIP 46480"},
        {"Renson", "Renson 23350"},
        {"Smithsonian Astrophysical Observation", "SAO 200409"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.19496587),
        dec: Angle.Degrees(-36.93419180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82872"},
        {"Hipparcos Number", "HIP 46917"},
        {"Smithsonian Astrophysical Observation", "SAO 200499"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.44201371),
        dec: Angle.Degrees(-36.93120401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93105"},
        {"Hipparcos Number", "HIP 52550"},
        {"Geneva Identification System", "GEN# +1.00093105"},
        {"Smithsonian Astrophysical Observation", "SAO 201698"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.16393616),
        dec: Angle.Degrees(-36.93057902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3012"},
        {"Hipparcos Number", "HIP 2605"},
        {"Smithsonian Astrophysical Observation", "SAO 192603"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.27516136),
        dec: Angle.Degrees(-36.92728706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83517"},
        {"Hipparcos Number", "HIP 47255"},
        {"Geneva Identification System", "GEN# +1.00083517"},
        {"Smithsonian Astrophysical Observation", "SAO 200581"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.48229567),
        dec: Angle.Degrees(-36.92614218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15848"},
        {"Hipparcos Number", "HIP 11768"},
        {"Smithsonian Astrophysical Observation", "SAO 193755"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.96817722),
        dec: Angle.Degrees(-36.92608131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132996"},
        {"Hipparcos Number", "HIP 73650"},
        {"Cincinnati Publication", "Ci 20 905"},
        {"Geneva Identification System", "GEN# +1.00132996"},
        {"Smithsonian Astrophysical Observation", "SAO 206243"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.82564771),
        dec: Angle.Degrees(-36.92366010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -394.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135685"},
        {"Hipparcos Number", "HIP 74839"},
        {"Geneva Identification System", "GEN# +1.00135685"},
        {"Smithsonian Astrophysical Observation", "SAO 206493"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.41620212),
        dec: Angle.Degrees(-36.92099196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96584"},
        {"Smithsonian Astrophysical Observation", "SAO 143629"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.51657105),
        dec: Angle.Degrees(-04.60832180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57639"},
        {"Hipparcos Number", "HIP 35580"},
        {"Geneva Identification System", "GEN# +1.00057639"},
        {"Smithsonian Astrophysical Observation", "SAO 197872"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.13591229),
        dec: Angle.Degrees(-36.91725203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117352"},
        {"Hipparcos Number", "HIP 65886"},
        {"Smithsonian Astrophysical Observation", "SAO 204537"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.58602515),
        dec: Angle.Degrees(-36.91591908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106320"},
        {"Hipparcos Number", "HIP 59650"},
        {"Smithsonian Astrophysical Observation", "SAO 203258"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.50215528),
        dec: Angle.Degrees(-36.91391162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64501"},
        {"Hipparcos Number", "HIP 38475"},
        {"Smithsonian Astrophysical Observation", "SAO 198548"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.20458531),
        dec: Angle.Degrees(-36.91211686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17409"},
        {"Hipparcos Number", "HIP 12940"},
        {"Smithsonian Astrophysical Observation", "SAO 193906"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.60816810),
        dec: Angle.Degrees(-36.90969983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89171"},
        {"Hipparcos Number", "HIP 50311"},
        {"Geneva Identification System", "GEN# +1.00089171"},
        {"Smithsonian Astrophysical Observation", "SAO 201229"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.09131516),
        dec: Angle.Degrees(-36.90838351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15018"},
        {"Hipparcos Number", "HIP 11205"},
        {"Geneva Identification System", "GEN# +1.00015018"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.06677467),
        dec: Angle.Degrees(-36.90795297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65355"},
        {"Hipparcos Number", "HIP 38842"},
        {"Geneva Identification System", "GEN# +1.00065355"},
        {"Smithsonian Astrophysical Observation", "SAO 198620"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.22965372),
        dec: Angle.Degrees(-36.90730591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72936"},
        {"Hipparcos Number", "HIP 42042"},
        {"Geneva Identification System", "GEN# +1.00072936"},
        {"Smithsonian Astrophysical Observation", "SAO 199381"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.54765091),
        dec: Angle.Degrees(-36.90634953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90907"},
        {"Hipparcos Number", "HIP 51330"},
        {"Geneva Identification System", "GEN# +1.00090907"},
        {"Smithsonian Astrophysical Observation", "SAO 201434"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.27280304),
        dec: Angle.Degrees(-36.90529675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211146"},
        {"Hipparcos Number", "HIP 109929"},
        {"Smithsonian Astrophysical Observation", "SAO 213679"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.97680697),
        dec: Angle.Degrees(-36.90367623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100420"},
        {"Smithsonian Astrophysical Observation", "SAO 212041"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.44819539),
        dec: Angle.Degrees(-36.90146649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115344"},
        {"Smithsonian Astrophysical Observation", "SAO 214489"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.45333142),
        dec: Angle.Degrees(-36.90106978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158174"},
        {"Hipparcos Number", "HIP 85587"},
        {"Smithsonian Astrophysical Observation", "SAO 208871"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.34652151),
        dec: Angle.Degrees(-36.90068364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8238"},
        {"Hipparcos Number", "HIP 6319"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.28836867),
        dec: Angle.Degrees(-36.89961846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166970"},
        {"Hipparcos Number", "HIP 89399"},
        {"Smithsonian Astrophysical Observation", "SAO 209897"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.66153509),
        dec: Angle.Degrees(-36.89889191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101405"},
        {"Hipparcos Number", "HIP 56911"},
        {"Smithsonian Astrophysical Observation", "SAO 202692"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.00356921),
        dec: Angle.Degrees(-36.89835071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86139"},
        {"Hipparcos Number", "HIP 48686"},
        {"Smithsonian Astrophysical Observation", "SAO 200874"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.93662543),
        dec: Angle.Degrees(-36.89780381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187387"},
        {"Hipparcos Number", "HIP 97683"},
        {"Smithsonian Astrophysical Observation", "SAO 211599"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.79090572),
        dec: Angle.Degrees(-36.89651857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207895"},
        {"Hipparcos Number", "HIP 108035"},
        {"Geneva Identification System", "GEN# +1.00207895"},
        {"Smithsonian Astrophysical Observation", "SAO 213364"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.31128153),
        dec: Angle.Degrees(-36.89651025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214408"},
        {"Hipparcos Number", "HIP 111771"},
        {"Smithsonian Astrophysical Observation", "SAO 213975"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.61626599),
        dec: Angle.Degrees(-36.89508718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52296"},
        {"Geneva Identification System", "GEN# -0.03606589"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.28835164),
        dec: Angle.Degrees(-36.89496769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114597"},
        {"Smithsonian Astrophysical Observation", "SAO 214384"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.23017130),
        dec: Angle.Degrees(-36.89455595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198870"},
        {"Hipparcos Number", "HIP 103205"},
        {"Smithsonian Astrophysical Observation", "SAO 212535"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.64654482),
        dec: Angle.Degrees(-36.89445106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180771"},
        {"Hipparcos Number", "HIP 94956"},
        {"Smithsonian Astrophysical Observation", "SAO 211166"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.84094957),
        dec: Angle.Degrees(-36.89443951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57195"},
        {"Hipparcos Number", "HIP 35390"},
        {"Geneva Identification System", "GEN# +1.00057195"},
        {"Smithsonian Astrophysical Observation", "SAO 197834"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63824621),
        dec: Angle.Degrees(-36.89350309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142446"},
        {"Hipparcos Number", "HIP 78043"},
        {"Smithsonian Astrophysical Observation", "SAO 207130"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.02350698),
        dec: Angle.Degrees(-36.89280767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132348"},
        {"Hipparcos Number", "HIP 73379"},
        {"Smithsonian Astrophysical Observation", "SAO 206176"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.92880639),
        dec: Angle.Degrees(-36.89119817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176386"},
        {"Henry Draper 2", "HD 176386A"},
        {"Hipparcos Number", "HIP 93425"},
        {"Geneva Identification System", "GEN# +1.00176386"},
        {"Smithsonian Astrophysical Observation", "SAO 210828"},
        {"Wilson Evans Batten Catalogue", "WEB 16210"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.41220395),
        dec: Angle.Degrees(-36.89064295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215864"},
        {"Hipparcos Number", "HIP 112637"},
        {"Geneva Identification System", "GEN# +1.00215864"},
        {"Smithsonian Astrophysical Observation", "SAO 214100"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.19485165),
        dec: Angle.Degrees(-36.89008869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -243.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59098"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.79129495),
        dec: Angle.Degrees(-36.89006569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23419"},
        {"Hipparcos Number", "HIP 17400"},
        {"Smithsonian Astrophysical Observation", "SAO 194485"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.92146391),
        dec: Angle.Degrees(-36.88924966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223599"},
        {"Hipparcos Number", "HIP 117597"},
        {"Geneva Identification System", "GEN# +1.00223599"},
        {"Smithsonian Astrophysical Observation", "SAO 214810"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.73408772),
        dec: Angle.Degrees(-36.88908243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152404"},
        {"Hipparcos Number", "HIP 82747"},
        {"Geneva Identification System", "GEN# +1.00152404"},
        {"Smithsonian Astrophysical Observation", "SAO 208174"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.68689622),
        dec: Angle.Degrees(-36.88841932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172969"},
        {"Hipparcos Number", "HIP 91959"},
        {"Smithsonian Astrophysical Observation", "SAO 210514"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.16899116),
        dec: Angle.Degrees(-36.88760949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185691"},
        {"Hipparcos Number", "HIP 96896"},
        {"Smithsonian Astrophysical Observation", "SAO 211482"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.45583711),
        dec: Angle.Degrees(-36.88755770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51826"},
        {"Hipparcos Number", "HIP 33442"},
        {"Celescope Catalog", "CEL 1455"},
        {"Geneva Identification System", "GEN# +1.00051826"},
        {"Smithsonian Astrophysical Observation", "SAO 197400"},
        {"Wilson Evans Batten Catalogue", "WEB 6725"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.30070666),
        dec: Angle.Degrees(-36.88680758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16716"},
        {"Hipparcos Number", "HIP 12403"},
        {"Smithsonian Astrophysical Observation", "SAO 193842"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.92059569),
        dec: Angle.Degrees(-36.88617017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129013"},
        {"Hipparcos Number", "HIP 71809"},
        {"Geneva Identification System", "GEN# +1.00129013"},
        {"Smithsonian Astrophysical Observation", "SAO 205828"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.33017741),
        dec: Angle.Degrees(-36.88500375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113903"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.99975080),
        dec: Angle.Degrees(-36.88229974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157957"},
        {"Hipparcos Number", "HIP 85476"},
        {"Geneva Identification System", "GEN# +1.00157957"},
        {"Smithsonian Astrophysical Observation", "SAO 208846"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.01453741),
        dec: Angle.Degrees(-36.88207560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58633"},
        {"Hipparcos Number", "HIP 35974"},
        {"Smithsonian Astrophysical Observation", "SAO 197976"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.21017237),
        dec: Angle.Degrees(-36.88083481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81889"},
        {"Hipparcos Number", "HIP 46376"},
        {"Renson", "Renson 23280"},
        {"Smithsonian Astrophysical Observation", "SAO 200388"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.84542889),
        dec: Angle.Degrees(-36.88011035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134971"},
        {"Hipparcos Number", "HIP 74544"},
        {"Smithsonian Astrophysical Observation", "SAO 206433"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.47922535),
        dec: Angle.Degrees(-36.87942694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177848"},
        {"Hipparcos Number", "HIP 93962"},
        {"Renson", "Renson 49560"},
        {"Smithsonian Astrophysical Observation", "SAO 210956"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.97753416),
        dec: Angle.Degrees(-36.87711821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141978"},
        {"Hipparcos Number", "HIP 77814"},
        {"Smithsonian Astrophysical Observation", "SAO 207083"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.33811653),
        dec: Angle.Degrees(-36.87684624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224528"},
        {"Hipparcos Number", "HIP 118206"},
        {"Geneva Identification System", "GEN# +1.00224528"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.65124254),
        dec: Angle.Degrees(-36.87661306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28810"},
        {"Hipparcos Number", "HIP 21064"},
        {"Smithsonian Astrophysical Observation", "SAO 195089"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.72371870),
        dec: Angle.Degrees(-36.87618168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67358",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67358"},
        {"Smithsonian Astrophysical Observation", "SAO 204856"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.08555695),
        dec: Angle.Degrees(-36.87579054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60464"},
        {"Smithsonian Astrophysical Observation", "SAO 203425"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.93954832),
        dec: Angle.Degrees(-36.87490430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165385"},
        {"Hipparcos Number", "HIP 88773"},
        {"Smithsonian Astrophysical Observation", "SAO 209727"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.83866629),
        dec: Angle.Degrees(-36.87338418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41392"},
        {"Hipparcos Number", "HIP 28662"},
        {"Smithsonian Astrophysical Observation", "SAO 196445"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.78483198),
        dec: Angle.Degrees(-36.87295307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32152"},
        {"Hipparcos Number", "HIP 23185"},
        {"Geneva Identification System", "GEN# +1.00032152"},
        {"Smithsonian Astrophysical Observation", "SAO 195458"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.83546269),
        dec: Angle.Degrees(-36.87175791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62151"},
        {"Hipparcos Number", "HIP 37430"},
        {"Smithsonian Astrophysical Observation", "SAO 198291"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.25090988),
        dec: Angle.Degrees(-36.86852178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143697"},
        {"Hipparcos Number", "HIP 78652"},
        {"Smithsonian Astrophysical Observation", "SAO 207277"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.84150153),
        dec: Angle.Degrees(-36.86651333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9525"},
        {"Hipparcos Number", "HIP 7213"},
        {"Fundamental Katalog 5th Edition", "FK5 2101"},
        {"Geneva Identification System", "GEN# +1.00009525"},
        {"Smithsonian Astrophysical Observation", "SAO 193173"},
        {"Wilson Evans Batten Catalogue", "WEB 1553"},
    },
    visualMagnitude: 5.49,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.23355059),
        dec: Angle.Degrees(-36.86518161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91980"},
        {"Hipparcos Number", "HIP 51938"},
        {"Geneva Identification System", "GEN# +1.00091980"},
        {"Smithsonian Astrophysical Observation", "SAO 201558"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.15158588),
        dec: Angle.Degrees(-36.86393317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67359"},
        {"Smithsonian Astrophysical Observation", "SAO 204857"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.08731512),
        dec: Angle.Degrees(-36.86254548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1885"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.94775648),
        dec: Angle.Degrees(-36.86120296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219837"},
        {"Hipparcos Number", "HIP 115133"},
        {"Smithsonian Astrophysical Observation", "SAO 214449"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.80581575),
        dec: Angle.Degrees(-36.86010555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136664"},
        {"Hipparcos Number", "HIP 75304"},
        {"Fundamental Katalog 5th Edition", "FK5 1403"},
        {"Geneva Identification System", "GEN# +1.00136664"},
        {"Smithsonian Astrophysical Observation", "SAO 206580"},
        {"Wilson Evans Batten Catalogue", "WEB 12846"},
    },
    visualMagnitude: 4.54,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.78901374),
        dec: Angle.Degrees(-36.85843627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163652"},
        {"Hipparcos Number", "HIP 88038"},
        {"Geneva Identification System", "GEN# +1.00163652"},
        {"Smithsonian Astrophysical Observation", "SAO 209545"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.73199696),
        dec: Angle.Degrees(-36.85840855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125343"},
        {"Hipparcos Number", "HIP 70026"},
        {"Smithsonian Astrophysical Observation", "SAO 205436"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.93475147),
        dec: Angle.Degrees(-36.85816413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198178"},
        {"Hipparcos Number", "HIP 102818"},
        {"Smithsonian Astrophysical Observation", "SAO 212466"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.44993430),
        dec: Angle.Degrees(-36.85503698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149830"},
        {"Hipparcos Number", "HIP 81495"},
        {"Smithsonian Astrophysical Observation", "SAO 207873"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.68217587),
        dec: Angle.Degrees(-36.85464529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117735"},
        {"Hipparcos Number", "HIP 66088"},
        {"Smithsonian Astrophysical Observation", "SAO 204574"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.20922369),
        dec: Angle.Degrees(-36.85388097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125382"},
        {"Hipparcos Number", "HIP 70043"},
        {"Smithsonian Astrophysical Observation", "SAO 205444"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.99289323),
        dec: Angle.Degrees(-36.85324436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11102"},
        {"Hipparcos Number", "HIP 8405"},
        {"Smithsonian Astrophysical Observation", "SAO 193306"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.11238350),
        dec: Angle.Degrees(-36.85237621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30912"},
        {"Smithsonian Astrophysical Observation", "SAO 196873"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.32353890),
        dec: Angle.Degrees(-36.85165250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27328"},
        {"Hipparcos Number", "HIP 20002"},
        {"Geneva Identification System", "GEN# +1.00027328"},
        {"Smithsonian Astrophysical Observation", "SAO 194896"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.33391571),
        dec: Angle.Degrees(-36.85030751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49169"},
        {"Hipparcos Number", "HIP 32381"},
        {"Smithsonian Astrophysical Observation", "SAO 197181"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.36989988),
        dec: Angle.Degrees(-36.84942081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18048"},
        {"Hipparcos Number", "HIP 13417"},
        {"Smithsonian Astrophysical Observation", "SAO 193958"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.18771145),
        dec: Angle.Degrees(-36.84656518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132603"},
        {"Hipparcos Number", "HIP 73487"},
        {"Smithsonian Astrophysical Observation", "SAO 206207"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.28660710),
        dec: Angle.Degrees(-36.84555936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177076"},
        {"Hipparcos Number", "HIP 93689"},
        {"Smithsonian Astrophysical Observation", "SAO 210888"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.18504919),
        dec: Angle.Degrees(-36.84464588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145087"},
        {"Hipparcos Number", "HIP 79259"},
        {"Smithsonian Astrophysical Observation", "SAO 207415"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.65068610),
        dec: Angle.Degrees(-36.84453632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79060"},
        {"Hipparcos Number", "HIP 45052"},
        {"Geneva Identification System", "GEN# +1.00079060"},
        {"Smithsonian Astrophysical Observation", "SAO 200062"},
        {"Wilson Evans Batten Catalogue", "WEB 8601"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.63840399),
        dec: Angle.Degrees(-36.84453154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120809"},
        {"Hipparcos Number", "HIP 67730"},
        {"Geneva Identification System", "GEN# +1.00120809"},
        {"Smithsonian Astrophysical Observation", "SAO 204929"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.11996667),
        dec: Angle.Degrees(-36.83561573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187112"},
        {"Hipparcos Number", "HIP 97552"},
        {"Smithsonian Astrophysical Observation", "SAO 211581"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.42307126),
        dec: Angle.Degrees(-36.83521124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105775"},
        {"Hipparcos Number", "HIP 59354"},
        {"Smithsonian Astrophysical Observation", "SAO 203197"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.65007247),
        dec: Angle.Degrees(-36.83486884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113472"},
        {"Hipparcos Number", "HIP 63791"},
        {"Smithsonian Astrophysical Observation", "SAO 204096"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.11731178),
        dec: Angle.Degrees(-36.83383906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9085"},
        {"Hipparcos Number", "HIP 6899"},
        {"Geneva Identification System", "GEN# +1.00009085"},
        {"Smithsonian Astrophysical Observation", "SAO 193137"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.20720533),
        dec: Angle.Degrees(-36.83309619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10538"},
        {"Hipparcos Number", "HIP 7941"},
        {"Fundamental Katalog 5th Edition", "FK5 58"},
        {"Geneva Identification System", "GEN# +1.00010538"},
        {"Smithsonian Astrophysical Observation", "SAO 193261"},
        {"Wilson Evans Batten Catalogue", "WEB 1701"},
    },
    visualMagnitude: 5.70,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.51256331),
        dec: Angle.Degrees(-36.83226421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68111"},
        {"Hipparcos Number", "HIP 39965"},
        {"Geneva Identification System", "GEN# +1.00068111"},
        {"Smithsonian Astrophysical Observation", "SAO 198867"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.40547677),
        dec: Angle.Degrees(-36.83156335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1083"},
    },
    visualMagnitude: 10.77,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.37179173),
        dec: Angle.Degrees(-36.82792674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -209.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -319.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205873"},
        {"Hipparcos Number", "HIP 106925"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.82215834),
        dec: Angle.Degrees(-36.82606837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170304"},
        {"Hipparcos Number", "HIP 90698"},
        {"Geneva Identification System", "GEN# +1.00170304"},
        {"Smithsonian Astrophysical Observation", "SAO 210238"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.56989400),
        dec: Angle.Degrees(-36.82358782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48159"},
    },
    visualMagnitude: 11.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.24561024),
        dec: Angle.Degrees(-36.81841777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115393"},
        {"Hipparcos Number", "HIP 64830"},
        {"Smithsonian Astrophysical Observation", "SAO 204322"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.35129528),
        dec: Angle.Degrees(-36.81725153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52332"},
        {"Hipparcos Number", "HIP 33629"},
        {"Geneva Identification System", "GEN# +1.00052332"},
        {"Smithsonian Astrophysical Observation", "SAO 197440"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.79675127),
        dec: Angle.Degrees(-36.81528181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9208"},
        {"Smithsonian Astrophysical Observation", "SAO 193423"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.61251095),
        dec: Angle.Degrees(-36.81497578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174120"},
        {"Hipparcos Number", "HIP 92454"},
        {"Geneva Identification System", "GEN# +1.00174120"},
        {"Smithsonian Astrophysical Observation", "SAO 210619"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.62664943),
        dec: Angle.Degrees(-36.81493659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208301"},
        {"Hipparcos Number", "HIP 108290"},
        {"Smithsonian Astrophysical Observation", "SAO 213413"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.08790568),
        dec: Angle.Degrees(-36.81368034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112133"},
        {"Hipparcos Number", "HIP 62998"},
        {"Smithsonian Astrophysical Observation", "SAO 203924"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.63399393),
        dec: Angle.Degrees(-36.81155840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170461"},
        {"Hipparcos Number", "HIP 90775"},
        {"Geneva Identification System", "GEN# +1.00170461"},
        {"Smithsonian Astrophysical Observation", "SAO 210256"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.79777161),
        dec: Angle.Degrees(-36.80922962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220232"},
        {"Hipparcos Number", "HIP 115384"},
        {"Smithsonian Astrophysical Observation", "SAO 214496"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.60318735),
        dec: Angle.Degrees(-36.80616540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170943"},
        {"Hipparcos Number", "HIP 90992"},
        {"Smithsonian Astrophysical Observation", "SAO 210304"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.41567905),
        dec: Angle.Degrees(-36.80560131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184439"},
        {"Hipparcos Number", "HIP 96398"},
        {"Smithsonian Astrophysical Observation", "SAO 211396"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.98814999),
        dec: Angle.Degrees(-36.80513092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8681"},
        {"Smithsonian Astrophysical Observation", "SAO 193339"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.92453988),
        dec: Angle.Degrees(-36.80490755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89442"},
        {"Hipparcos Number", "HIP 50492"},
        {"Geneva Identification System", "GEN# +1.00089442"},
        {"Smithsonian Astrophysical Observation", "SAO 201266"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.65782263),
        dec: Angle.Degrees(-36.80459709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78323"},
        {"Hipparcos Number", "HIP 44686"},
        {"Smithsonian Astrophysical Observation", "SAO 199981"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.59631188),
        dec: Angle.Degrees(-36.80318238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144294"},
        {"Hipparcos Number", "HIP 78918"},
        {"Fundamental Katalog 5th Edition", "FK5 599"},
        {"Geneva Identification System", "GEN# +1.00144294"},
        {"Smithsonian Astrophysical Observation", "SAO 207332"},
        {"Wilson Evans Batten Catalogue", "WEB 13339"},
    },
    visualMagnitude: 4.22,
    bvColour: -0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.64815129),
        dec: Angle.Degrees(-36.80221297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221982"},
        {"Hipparcos Number", "HIP 116528"},
        {"Smithsonian Astrophysical Observation", "SAO 214657"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.23806739),
        dec: Angle.Degrees(-36.80121569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68510"},
        {"Hipparcos Number", "HIP 40092"},
        {"Smithsonian Astrophysical Observation", "SAO 198905"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.84045903),
        dec: Angle.Degrees(-36.80095917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88494"},
        {"Hipparcos Number", "HIP 49916"},
        {"Smithsonian Astrophysical Observation", "SAO 201147"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.87971168),
        dec: Angle.Degrees(-36.79835647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1234"},
        {"Hipparcos Number", "HIP 1311"},
        {"Geneva Identification System", "GEN# +1.00001234"},
        {"Smithsonian Astrophysical Observation", "SAO 192435"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.11529698),
        dec: Angle.Degrees(-36.79624740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25168"},
        {"Hipparcos Number", "HIP 18573"},
        {"Smithsonian Astrophysical Observation", "SAO 194668"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.63845796),
        dec: Angle.Degrees(-36.79620798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3032"},
        {"Hipparcos Number", "HIP 2638"},
        {"Smithsonian Astrophysical Observation", "SAO 192605"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.36539822),
        dec: Angle.Degrees(-36.78885494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202985"},
        {"Hipparcos Number", "HIP 105351"},
        {"Smithsonian Astrophysical Observation", "SAO 212915"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.08425532),
        dec: Angle.Degrees(-36.78833484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55794"},
    },
    visualMagnitude: 11.73,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.46720051),
        dec: Angle.Degrees(-36.78795273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126557"},
        {"Hipparcos Number", "HIP 70662"},
        {"Smithsonian Astrophysical Observation", "SAO 205572"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.79956220),
        dec: Angle.Degrees(-36.78715004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222701"},
        {"Hipparcos Number", "HIP 116998"},
        {"Geneva Identification System", "GEN# +1.00222701"},
        {"Renson", "Renson 61050"},
        {"Smithsonian Astrophysical Observation", "SAO 214729"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.77983333),
        dec: Angle.Degrees(-36.78498643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130260"},
        {"Henry Draper 2", "HD 130260A"},
        {"Hipparcos Number", "HIP 72399"},
        {"Smithsonian Astrophysical Observation", "SAO 205956"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.04070243),
        dec: Angle.Degrees(-36.78390247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130260B"},
        {"Hipparcos Number", "HIP 72400"},
    },
    visualMagnitude: 10.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.04445429),
        dec: Angle.Degrees(-36.78346921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66185"},
        {"Hipparcos Number", "HIP 39190"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.23076322),
        dec: Angle.Degrees(-36.78209714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198047"},
        {"Hipparcos Number", "HIP 102734"},
        {"Geneva Identification System", "GEN# +1.00198047"},
        {"Smithsonian Astrophysical Observation", "SAO 212457"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.25762227),
        dec: Angle.Degrees(-36.78071105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188739"},
        {"Hipparcos Number", "HIP 98276"},
        {"Geneva Identification System", "GEN# +1.00188739"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.52594553),
        dec: Angle.Degrees(-36.78067623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168005"},
        {"Hipparcos Number", "HIP 89784"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.84285536),
        dec: Angle.Degrees(-36.78065029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47144"},
        {"Hipparcos Number", "HIP 31457"},
        {"Celescope Catalog", "CEL 1314"},
        {"Geneva Identification System", "GEN# +1.00047144J"},
        {"Renson", "Renson 12660"},
        {"Smithsonian Astrophysical Observation", "SAO 196978"},
        {"Wilson Evans Batten Catalogue", "WEB 6294"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.85093436),
        dec: Angle.Degrees(-36.77993005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10812"},
        {"Geneva Identification System", "GEN# +9.85941040"},
    },
    visualMagnitude: 11.59,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.78776199),
        dec: Angle.Degrees(-36.77942028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1394.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 549.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159380"},
        {"Hipparcos Number", "HIP 86126"},
        {"Smithsonian Astrophysical Observation", "SAO 209009"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.02044467),
        dec: Angle.Degrees(-36.77849877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 481"},
        {"Smithsonian Astrophysical Observation", "SAO 192355"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.43360334),
        dec: Angle.Degrees(-36.77845599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158105"},
        {"Hipparcos Number", "HIP 85543"},
        {"Geneva Identification System", "GEN# +1.00158105"},
        {"Smithsonian Astrophysical Observation", "SAO 208860"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.23370580),
        dec: Angle.Degrees(-36.77826780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165839"},
        {"Hipparcos Number", "HIP 88967"},
        {"Geneva Identification System", "GEN# +1.00165839"},
        {"Smithsonian Astrophysical Observation", "SAO 209784"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.39912967),
        dec: Angle.Degrees(-36.77703129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20878"},
        {"Hipparcos Number", "HIP 15570"},
        {"Smithsonian Astrophysical Observation", "SAO 194239"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.15187057),
        dec: Angle.Degrees(-36.77548226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10123"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.55483411),
        dec: Angle.Degrees(-36.77115170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 209.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100064"},
        {"Hipparcos Number", "HIP 56152"},
        {"Smithsonian Astrophysical Observation", "SAO 202518"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.64289890),
        dec: Angle.Degrees(-36.76930407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57194"},
        {"Hipparcos Number", "HIP 35386"},
        {"Geneva Identification System", "GEN# +1.00057194"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63525691),
        dec: Angle.Degrees(-36.76891152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137432"},
        {"Hipparcos Number", "HIP 75647"},
        {"Geneva Identification System", "GEN# +1.00137432"},
        {"Smithsonian Astrophysical Observation", "SAO 206660"},
        {"Wilson Evans Batten Catalogue", "WEB 12882"},
    },
    visualMagnitude: 5.46,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.82560314),
        dec: Angle.Degrees(-36.76750151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38100"},
        {"Smithsonian Astrophysical Observation", "SAO 198465"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.11765819),
        dec: Angle.Degrees(-36.76685697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129278"},
        {"Hipparcos Number", "HIP 71935"},
        {"Smithsonian Astrophysical Observation", "SAO 205853"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.69033266),
        dec: Angle.Degrees(-36.76635296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54950"},
        {"Smithsonian Astrophysical Observation", "SAO 202242"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.79069030),
        dec: Angle.Degrees(-36.76583991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131417"},
        {"Hipparcos Number", "HIP 72957"},
        {"Geneva Identification System", "GEN# +1.00131417"},
        {"Smithsonian Astrophysical Observation", "SAO 206077"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.65604863),
        dec: Angle.Degrees(-36.76531166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218722"},
        {"Hipparcos Number", "HIP 114439"},
        {"Smithsonian Astrophysical Observation", "SAO 214360"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.65120603),
        dec: Angle.Degrees(-36.76400675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206883"},
        {"Hipparcos Number", "HIP 107467"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.50861368),
        dec: Angle.Degrees(-36.76272203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115821"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.96006630),
        dec: Angle.Degrees(-36.76269674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 396.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167618"},
        {"Hipparcos Number", "HIP 89642"},
        {"Fundamental Katalog 5th Edition", "FK5 683"},
        {"Geneva Identification System", "GEN# +1.00167618"},
        {"Smithsonian Astrophysical Observation", "SAO 209957"},
        {"Wilson Evans Batten Catalogue", "WEB 15268"},
    },
    visualMagnitude: 3.10,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.40720490),
        dec: Angle.Degrees(-36.76128103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196533"},
        {"Hipparcos Number", "HIP 101927"},
        {"Smithsonian Astrophysical Observation", "SAO 212317"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.82521531),
        dec: Angle.Degrees(-36.76055943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5184"},
        {"Geneva Identification System", "GEN# -0.03700402"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.58937784),
        dec: Angle.Degrees(-36.75640236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43011"},
        {"Hipparcos Number", "HIP 29443"},
        {"Smithsonian Astrophysical Observation", "SAO 196582"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.05906059),
        dec: Angle.Degrees(-36.75634224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200215"},
        {"Hipparcos Number", "HIP 103914"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.81847735),
        dec: Angle.Degrees(-36.75616491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54513"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.30181297),
        dec: Angle.Degrees(-04.60671132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -331.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144415"},
        {"Hipparcos Number", "HIP 78970"},
        {"Geneva Identification System", "GEN# +1.00144415"},
        {"Smithsonian Astrophysical Observation", "SAO 207341"},
        {"Wilson Evans Batten Catalogue", "WEB 13347"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.81739481),
        dec: Angle.Degrees(-36.75553887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151770"},
        {"Hipparcos Number", "HIP 82447"},
        {"Geneva Identification System", "GEN# +1.00151770"},
        {"Smithsonian Astrophysical Observation", "SAO 208088"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.73948118),
        dec: Angle.Degrees(-36.75511473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88261"},
        {"Hipparcos Number", "HIP 49793"},
        {"Cincinnati Publication", "Ci 20 563"},
        {"Geneva Identification System", "GEN# +1.00088261"},
        {"Smithsonian Astrophysical Observation", "SAO 201116"},
        {"Wilson Evans Batten Catalogue", "WEB 9177"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.45756560),
        dec: Angle.Degrees(-36.75505215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -322.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 371.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75222"},
        {"Hipparcos Number", "HIP 43158"},
        {"Geneva Identification System", "GEN# +1.00075222"},
        {"Smithsonian Astrophysical Observation", "SAO 199621"},
        {"Wilson Evans Batten Catalogue", "WEB 8329"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.85475534),
        dec: Angle.Degrees(-36.75076821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82531"},
        {"Hipparcos Number", "HIP 46730"},
        {"Smithsonian Astrophysical Observation", "SAO 200461"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.87831623),
        dec: Angle.Degrees(-36.75046619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175479"},
        {"Hipparcos Number", "HIP 93031"},
        {"Smithsonian Astrophysical Observation", "SAO 210751"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.27123726),
        dec: Angle.Degrees(-36.74941967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23929"},
        {"Hipparcos Number", "HIP 17709"},
        {"Smithsonian Astrophysical Observation", "SAO 194533"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.89496282),
        dec: Angle.Degrees(-36.74865214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146179"},
        {"Hipparcos Number", "HIP 79741"},
        {"Geneva Identification System", "GEN# +1.00146179"},
        {"Smithsonian Astrophysical Observation", "SAO 207500"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.11706695),
        dec: Angle.Degrees(-36.74815180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34951"},
        {"Hipparcos Number", "HIP 24833"},
        {"Smithsonian Astrophysical Observation", "SAO 195755"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.85551241),
        dec: Angle.Degrees(-36.74509705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 428"},
        {"Hipparcos Number", "HIP 708"},
        {"Geneva Identification System", "GEN# +1.00000428"},
        {"Smithsonian Astrophysical Observation", "SAO 192370"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.19513310),
        dec: Angle.Degrees(-36.74408179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143488"},
        {"Hipparcos Number", "HIP 78541"},
        {"Smithsonian Astrophysical Observation", "SAO 207246"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.52022562),
        dec: Angle.Degrees(-36.74386164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74966"},
        {"Hipparcos Number", "HIP 43000"},
        {"Celescope Catalog", "CEL 2866"},
        {"Geneva Identification System", "GEN# +1.00074966"},
        {"Smithsonian Astrophysical Observation", "SAO 199588"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.45149106),
        dec: Angle.Degrees(-36.74300366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57219"},
        {"Hipparcos Number", "HIP 35406"},
        {"Celescope Catalog", "CEL 1772"},
        {"Geneva Identification System", "GEN# +1.00057219"},
        {"Renson", "Renson 15640"},
        {"Smithsonian Astrophysical Observation", "SAO 197837"},
        {"Wilson Evans Batten Catalogue", "WEB 7062"},
    },
    visualMagnitude: 5.11,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65913632),
        dec: Angle.Degrees(-36.74274935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217793"},
        {"Hipparcos Number", "HIP 113866"},
        {"Smithsonian Astrophysical Observation", "SAO 214276"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.89153489),
        dec: Angle.Degrees(-36.74163411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171138"},
        {"Hipparcos Number", "HIP 91076"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.65783033),
        dec: Angle.Degrees(-36.74130645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51612"},
    },
    visualMagnitude: 11.66,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.14633176),
        dec: Angle.Degrees(-36.74115282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -335.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86846"},
        {"Hipparcos Number", "HIP 49038"},
        {"Geneva Identification System", "GEN# +1.00086846"},
        {"Smithsonian Astrophysical Observation", "SAO 200952"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.07520473),
        dec: Angle.Degrees(-36.73976940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77881"},
        {"Hipparcos Number", "HIP 44500"},
        {"Geneva Identification System", "GEN# +1.00077881"},
        {"Smithsonian Astrophysical Observation", "SAO 199942"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.99405896),
        dec: Angle.Degrees(-36.73907325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128772"},
        {"Hipparcos Number", "HIP 71692"},
        {"Geneva Identification System", "GEN# +1.00128772"},
        {"Smithsonian Astrophysical Observation", "SAO 205813"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.98095768),
        dec: Angle.Degrees(-36.73704421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17885"},
        {"Hipparcos Number", "HIP 13305"},
        {"Smithsonian Astrophysical Observation", "SAO 193947"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.80527920),
        dec: Angle.Degrees(-36.73545482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57150"},
        {"Hipparcos Number", "HIP 35363"},
        {"Celescope Catalog", "CEL 1759"},
        {"Geneva Identification System", "GEN# +1.00057150"},
        {"Smithsonian Astrophysical Observation", "SAO 197824"},
        {"Wilson Evans Batten Catalogue", "WEB 7058"},
    },
    visualMagnitude: 4.65,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.57667037),
        dec: Angle.Degrees(-36.73396660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149776"},
        {"Hipparcos Number", "HIP 81475"},
        {"Smithsonian Astrophysical Observation", "SAO 207866"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.62024953),
        dec: Angle.Degrees(-36.73080791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109902"},
        {"Hipparcos Number", "HIP 61683"},
        {"Smithsonian Astrophysical Observation", "SAO 203659"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.67313454),
        dec: Angle.Degrees(-36.73062393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161629"},
        {"Hipparcos Number", "HIP 87139"},
        {"Smithsonian Astrophysical Observation", "SAO 209268"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.06110023),
        dec: Angle.Degrees(-36.73060536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106338"},
        {"Hipparcos Number", "HIP 59659"},
        {"Smithsonian Astrophysical Observation", "SAO 203261"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.52595182),
        dec: Angle.Degrees(-36.72898805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101029"},
        {"Hipparcos Number", "HIP 56694"},
        {"Geneva Identification System", "GEN# +1.00101029"},
        {"Smithsonian Astrophysical Observation", "SAO 202641"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.37144184),
        dec: Angle.Degrees(-36.72708983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97200"},
        {"Hipparcos Number", "HIP 54628"},
        {"Smithsonian Astrophysical Observation", "SAO 202169"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.72070159),
        dec: Angle.Degrees(-36.72377463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71835"},
        {"Hipparcos Number", "HIP 41529"},
        {"Geneva Identification System", "GEN# +1.00071835"},
        {"Smithsonian Astrophysical Observation", "SAO 199265"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.05017805),
        dec: Angle.Degrees(-36.72312272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96054"},
        {"Hipparcos Number", "HIP 54106"},
        {"Smithsonian Astrophysical Observation", "SAO 202055"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.06949472),
        dec: Angle.Degrees(-36.72155656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72268"},
        {"Hipparcos Number", "HIP 41726"},
        {"Geneva Identification System", "GEN# +1.00072268"},
        {"Smithsonian Astrophysical Observation", "SAO 199310"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.62416525),
        dec: Angle.Degrees(-36.72133746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154421"},
        {"Hipparcos Number", "HIP 83745"},
        {"Smithsonian Astrophysical Observation", "SAO 208422"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.73697247),
        dec: Angle.Degrees(-36.72022908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72249"},
        {"Hipparcos Number", "HIP 41716"},
        {"Celescope Catalog", "CEL 2582"},
        {"Smithsonian Astrophysical Observation", "SAO 199309"},
    },
    visualMagnitude: 8.49,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.60007465),
        dec: Angle.Degrees(-36.72000809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60104"},
        {"Geneva Identification System", "GEN# -0.03607775"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.90043889),
        dec: Angle.Degrees(-36.71994340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144475"},
        {"Hipparcos Number", "HIP 79000"},
        {"Smithsonian Astrophysical Observation", "SAO 207348"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.89471876),
        dec: Angle.Degrees(-36.71967876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195626"},
        {"Hipparcos Number", "HIP 101464"},
        {"Smithsonian Astrophysical Observation", "SAO 212231"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.44430091),
        dec: Angle.Degrees(-36.71852673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172875"},
        {"Hipparcos Number", "HIP 91901"},
        {"Geneva Identification System", "GEN# +1.00172875"},
        {"Smithsonian Astrophysical Observation", "SAO 210507"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.03304750),
        dec: Angle.Degrees(-36.71823408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54034"},
        {"Hipparcos Number", "HIP 34223"},
        {"Smithsonian Astrophysical Observation", "SAO 197564"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.42937371),
        dec: Angle.Degrees(-36.71753310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39719"},
        {"Hipparcos Number", "HIP 27776"},
        {"Smithsonian Astrophysical Observation", "SAO 196267"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.16442693),
        dec: Angle.Degrees(-36.71474196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198764"},
        {"Hipparcos Number", "HIP 103136"},
        {"Smithsonian Astrophysical Observation", "SAO 212525"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.44036937),
        dec: Angle.Degrees(-36.71271490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115892"},
        {"Hipparcos Number", "HIP 65109"},
        {"Fundamental Katalog 5th Edition", "FK5 496"},
        {"Geneva Identification System", "GEN# +1.00115892"},
        {"Smithsonian Astrophysical Observation", "SAO 204371"},
        {"Wilson Evans Batten Catalogue", "WEB 11498"},
    },
    visualMagnitude: 2.75,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.15027321),
        dec: Angle.Degrees(-36.71208109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -340.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153444"},
        {"Hipparcos Number", "HIP 83284"},
        {"Smithsonian Astrophysical Observation", "SAO 208306"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.30683323),
        dec: Angle.Degrees(-36.70958605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41631"},
        {"Hipparcos Number", "HIP 28780"},
        {"Smithsonian Astrophysical Observation", "SAO 196466"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.15036931),
        dec: Angle.Degrees(-36.70939344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45145"},
        {"Hipparcos Number", "HIP 30444"},
        {"Geneva Identification System", "GEN# +1.00045145"},
        {"Smithsonian Astrophysical Observation", "SAO 196774"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.00424570),
        dec: Angle.Degrees(-36.70789674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121273"},
        {"Hipparcos Number", "HIP 67982"},
        {"Smithsonian Astrophysical Observation", "SAO 204985"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.82023530),
        dec: Angle.Degrees(-36.70733905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108481"},
        {"Hipparcos Number", "HIP 60819"},
        {"Smithsonian Astrophysical Observation", "SAO 203497"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.98764962),
        dec: Angle.Degrees(-36.70714290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169122"},
        {"Hipparcos Number", "HIP 90245"},
        {"Smithsonian Astrophysical Observation", "SAO 210109"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.20163220),
        dec: Angle.Degrees(-36.70638438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201242"},
        {"Hipparcos Number", "HIP 104441"},
        {"Geneva Identification System", "GEN# +1.00201242"},
        {"Smithsonian Astrophysical Observation", "SAO 212753"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.34296496),
        dec: Angle.Degrees(-36.70561595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224386"},
        {"Hipparcos Number", "HIP 118107"},
        {"Smithsonian Astrophysical Observation", "SAO 214876"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.37003889),
        dec: Angle.Degrees(-36.70557422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161172"},
        {"Hipparcos Number", "HIP 86922"},
        {"Smithsonian Astrophysical Observation", "SAO 209226"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.41392672),
        dec: Angle.Degrees(-36.70460213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49797"},
        {"Geneva Identification System", "GEN# -0.03606181"},
        {"Smithsonian Astrophysical Observation", "SAO 201118"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.47322367),
        dec: Angle.Degrees(-36.70337235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45158"},
        {"Hipparcos Number", "HIP 30455"},
        {"Geneva Identification System", "GEN# +1.00045158"},
        {"Smithsonian Astrophysical Observation", "SAO 196776"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.02551686),
        dec: Angle.Degrees(-36.70297055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18447"},
        {"Hipparcos Number", "HIP 13722"},
        {"Smithsonian Astrophysical Observation", "SAO 193997"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.18388590),
        dec: Angle.Degrees(-36.69957884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44574"},
        {"Hipparcos Number", "HIP 30156"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.18095466),
        dec: Angle.Degrees(-36.69925360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135984"},
        {"Hipparcos Number", "HIP 74984"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.84342694),
        dec: Angle.Degrees(-36.69766327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207399"},
        {"Hipparcos Number", "HIP 107745"},
        {"Smithsonian Astrophysical Observation", "SAO 213319"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.39876222),
        dec: Angle.Degrees(-36.69682897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211742"},
        {"Henry Draper 2", "HD 211742A"},
        {"Hipparcos Number", "HIP 110252"},
        {"Smithsonian Astrophysical Observation", "SAO 213739"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.98570233),
        dec: Angle.Degrees(-36.69496831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105559"},
        {"Hipparcos Number", "HIP 59249"},
        {"Geneva Identification System", "GEN# +1.00105559"},
        {"Smithsonian Astrophysical Observation", "SAO 203174"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.30736638),
        dec: Angle.Degrees(-36.69383619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72973"},
        {"Hipparcos Number", "HIP 42060"},
        {"Celescope Catalog", "CEL 2659"},
        {"Geneva Identification System", "GEN# +1.00072973"},
        {"Smithsonian Astrophysical Observation", "SAO 199387"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.59979631),
        dec: Angle.Degrees(-36.69361150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15402"},
        {"Hipparcos Number", "HIP 11458"},
        {"Geneva Identification System", "GEN# +1.00015402"},
        {"Smithsonian Astrophysical Observation", "SAO 193721"},
        {"Wilson Evans Batten Catalogue", "WEB 2392"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.95215132),
        dec: Angle.Degrees(-36.69341003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188787"},
        {"Hipparcos Number", "HIP 98287"},
        {"Geneva Identification System", "GEN# +1.00188787"},
        {"Smithsonian Astrophysical Observation", "SAO 211696"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.55544904),
        dec: Angle.Degrees(-36.68681135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57656"},
    },
    visualMagnitude: 12.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.36545376),
        dec: Angle.Degrees(-36.68625570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7347"},
        {"Smithsonian Astrophysical Observation", "SAO 129381"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.66816615),
        dec: Angle.Degrees(-04.58476959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59675"},
        {"Hipparcos Number", "HIP 36409"},
        {"Smithsonian Astrophysical Observation", "SAO 198053"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.37624066),
        dec: Angle.Degrees(-36.68470719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156687"},
        {"Hipparcos Number", "HIP 84863"},
        {"Smithsonian Astrophysical Observation", "SAO 208702"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.16792316),
        dec: Angle.Degrees(-36.68269157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126707"},
        {"Hipparcos Number", "HIP 70748"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.03836680),
        dec: Angle.Degrees(-36.68220636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16998"},
        {"Smithsonian Astrophysical Observation", "SAO 194425"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.65465192),
        dec: Angle.Degrees(-36.68190514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71584"},
        {"Hipparcos Number", "HIP 41424"},
        {"Smithsonian Astrophysical Observation", "SAO 199238"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.73571116),
        dec: Angle.Degrees(-36.68080401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216781"},
        {"Hipparcos Number", "HIP 113272"},
        {"Smithsonian Astrophysical Observation", "SAO 214193"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.05050393),
        dec: Angle.Degrees(-36.68029131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1371"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.28580249),
        dec: Angle.Degrees(-36.67995312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118240"},
        {"Hipparcos Number", "HIP 66365"},
        {"Smithsonian Astrophysical Observation", "SAO 204642"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.05080196),
        dec: Angle.Degrees(-36.67917212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189441"},
        {"Hipparcos Number", "HIP 98591"},
        {"Smithsonian Astrophysical Observation", "SAO 211739"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.38876213),
        dec: Angle.Degrees(-36.67894598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53427"},
        {"Smithsonian Astrophysical Observation", "SAO 201907"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.93917707),
        dec: Angle.Degrees(-36.67860061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92363"},
        {"Hipparcos Number", "HIP 52151"},
        {"Geneva Identification System", "GEN# +1.00092363"},
        {"Smithsonian Astrophysical Observation", "SAO 201598"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.81794550),
        dec: Angle.Degrees(-36.67718405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164390"},
        {"Hipparcos Number", "HIP 88351"},
        {"Geneva Identification System", "GEN# +1.00164390"},
        {"Smithsonian Astrophysical Observation", "SAO 209629"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.63044949),
        dec: Angle.Degrees(-36.67650264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117357"},
        {"Smithsonian Astrophysical Observation", "SAO 214778"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.93476741),
        dec: Angle.Degrees(-36.67640921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75708"},
        {"Hipparcos Number", "HIP 43383"},
        {"Smithsonian Astrophysical Observation", "SAO 199687"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.55347281),
        dec: Angle.Degrees(-36.67513296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115170"},
        {"Hipparcos Number", "HIP 64720"},
        {"Smithsonian Astrophysical Observation", "SAO 204301"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.98431905),
        dec: Angle.Degrees(-36.67447892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40196"},
        {"Geneva Identification System", "GEN# -0.03604326"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.15699254),
        dec: Angle.Degrees(-36.67442158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4250"},
        {"Hipparcos Number", "HIP 3491"},
        {"Smithsonian Astrophysical Observation", "SAO 192711"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.15100552),
        dec: Angle.Degrees(-36.67440845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165793"},
        {"Hipparcos Number", "HIP 88947"},
        {"Geneva Identification System", "GEN# +1.00165793"},
        {"Smithsonian Astrophysical Observation", "SAO 209779"},
        {"Wilson Evans Batten Catalogue", "WEB 15085"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.34375880),
        dec: Angle.Degrees(-36.67251846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38971"},
        {"Hipparcos Number", "HIP 27365"},
        {"Smithsonian Astrophysical Observation", "SAO 196180"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.93185764),
        dec: Angle.Degrees(-36.67164038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66333"},
        {"Hipparcos Number", "HIP 39252"},
        {"Smithsonian Astrophysical Observation", "SAO 198713"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.41001618),
        dec: Angle.Degrees(-36.67119416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213729"},
        {"Hipparcos Number", "HIP 111409"},
        {"Smithsonian Astrophysical Observation", "SAO 213919"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.55535085),
        dec: Angle.Degrees(-36.67101803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35490"},
        {"Hipparcos Number", "HIP 25190"},
        {"Smithsonian Astrophysical Observation", "SAO 195802"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.83769606),
        dec: Angle.Degrees(-36.67097994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 194.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168375"},
        {"Hipparcos Number", "HIP 89932"},
        {"Smithsonian Astrophysical Observation", "SAO 210018"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.25052072),
        dec: Angle.Degrees(-36.66998707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168733"},
        {"Hipparcos Number", "HIP 90074"},
        {"Geneva Identification System", "GEN# +1.00168733"},
        {"Renson", "Renson 47280"},
        {"Smithsonian Astrophysical Observation", "SAO 210061"},
        {"Wilson Evans Batten Catalogue", "WEB 15396"},
    },
    visualMagnitude: 5.33,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.72115824),
        dec: Angle.Degrees(-36.66949254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87588"},
        {"Hipparcos Number", "HIP 49404"},
        {"Smithsonian Astrophysical Observation", "SAO 201032"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.28340320),
        dec: Angle.Degrees(-36.66937522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188338"},
        {"Hipparcos Number", "HIP 98088"},
        {"Smithsonian Astrophysical Observation", "SAO 211662"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.01129131),
        dec: Angle.Degrees(-36.66786827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133196"},
        {"Hipparcos Number", "HIP 73739"},
        {"Smithsonian Astrophysical Observation", "SAO 206260"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.09871941),
        dec: Angle.Degrees(-36.66748177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68784"},
        {"Hipparcos Number", "HIP 40191"},
        {"Smithsonian Astrophysical Observation", "SAO 198935"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.14562592),
        dec: Angle.Degrees(-36.66728813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128224"},
        {"Hipparcos Number", "HIP 71457"},
        {"Renson", "Renson 36430"},
        {"Smithsonian Astrophysical Observation", "SAO 205754"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.19451821),
        dec: Angle.Degrees(-36.66533601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81308"},
        {"Hipparcos Number", "HIP 46077"},
        {"Smithsonian Astrophysical Observation", "SAO 200321"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.94998882),
        dec: Angle.Degrees(-36.66533007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95924"},
        {"Hipparcos Number", "HIP 54046"},
        {"Smithsonian Astrophysical Observation", "SAO 202046"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.89308453),
        dec: Angle.Degrees(-36.66332765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163252"},
        {"Hipparcos Number", "HIP 87855"},
        {"Smithsonian Astrophysical Observation", "SAO 209501"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.21338505),
        dec: Angle.Degrees(-36.66232921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150225"},
        {"Hipparcos Number", "HIP 81682"},
        {"Smithsonian Astrophysical Observation", "SAO 207918"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.28541188),
        dec: Angle.Degrees(-36.66104139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72600"},
        {"Hipparcos Number", "HIP 41972"},
        {"Celescope Catalog", "CEL 2639"},
        {"Geneva Identification System", "GEN# +1.00072600"},
        {"Smithsonian Astrophysical Observation", "SAO 199361"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.33501385),
        dec: Angle.Degrees(-36.66097416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222055"},
        {"Hipparcos Number", "HIP 116581"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.37814039),
        dec: Angle.Degrees(-36.65990322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152195"},
        {"Hipparcos Number", "HIP 82623"},
        {"Smithsonian Astrophysical Observation", "SAO 208143"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.35794372),
        dec: Angle.Degrees(-36.65981350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70060"},
        {"Hipparcos Number", "HIP 40706"},
        {"Celescope Catalog", "CEL 2347"},
        {"Fundamental Katalog 5th Edition", "FK5 313"},
        {"Geneva Identification System", "GEN# +1.00070060"},
        {"Renson", "Renson 19350"},
        {"Smithsonian Astrophysical Observation", "SAO 199070"},
        {"Wilson Evans Batten Catalogue", "WEB 7908"},
    },
    visualMagnitude: 4.44,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.63913830),
        dec: Angle.Degrees(-36.65953286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161249"},
        {"Hipparcos Number", "HIP 86951"},
        {"Geneva Identification System", "GEN# +1.00161249"},
        {"Smithsonian Astrophysical Observation", "SAO 209232"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.52285690),
        dec: Angle.Degrees(-36.65898922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205266"},
        {"Hipparcos Number", "HIP 106580"},
        {"Smithsonian Astrophysical Observation", "SAO 213114"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.79432507),
        dec: Angle.Degrees(-36.65878324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107458"},
        {"Smithsonian Astrophysical Observation", "SAO 213267"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.46948011),
        dec: Angle.Degrees(-36.65873467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180802"},
        {"Hipparcos Number", "HIP 94966"},
        {"Smithsonian Astrophysical Observation", "SAO 211169"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.87906505),
        dec: Angle.Degrees(-36.65829879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77789"},
        {"Hipparcos Number", "HIP 44460"},
        {"Smithsonian Astrophysical Observation", "SAO 199932"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.87174323),
        dec: Angle.Degrees(-36.65819050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203056"},
        {"Hipparcos Number", "HIP 105394"},
        {"Smithsonian Astrophysical Observation", "SAO 212929"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.21843053),
        dec: Angle.Degrees(-36.65667666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92759"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.53608467),
        dec: Angle.Degrees(-36.65639463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27240"},
        {"Hipparcos Number", "HIP 19939"},
        {"Smithsonian Astrophysical Observation", "SAO 194887"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.15272888),
        dec: Angle.Degrees(-36.65539538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26443"},
        {"Hipparcos Number", "HIP 19413"},
        {"Geneva Identification System", "GEN# +1.00026443"},
        {"Smithsonian Astrophysical Observation", "SAO 194801"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.36587321),
        dec: Angle.Degrees(-36.65493092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191216"},
        {"Hipparcos Number", "HIP 99368"},
        {"Smithsonian Astrophysical Observation", "SAO 211873"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.53673322),
        dec: Angle.Degrees(-36.65481611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71649"},
        {"Hipparcos Number", "HIP 41444"},
        {"Celescope Catalog", "CEL 2524"},
        {"Geneva Identification System", "GEN# +1.00071649"},
        {"Smithsonian Astrophysical Observation", "SAO 199247"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.80048242),
        dec: Angle.Degrees(-36.65385675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41630"},
        {"Hipparcos Number", "HIP 28781"},
        {"Smithsonian Astrophysical Observation", "SAO 196467"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.15363139),
        dec: Angle.Degrees(-36.65321649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34358"},
        {"Hipparcos Number", "HIP 24474"},
        {"Smithsonian Astrophysical Observation", "SAO 195689"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.78650842),
        dec: Angle.Degrees(-36.65289547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152961"},
        {"Hipparcos Number", "HIP 83041"},
        {"Smithsonian Astrophysical Observation", "SAO 208242"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.53443149),
        dec: Angle.Degrees(-36.65268395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24470"},
        {"Smithsonian Astrophysical Observation", "SAO 195688"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.77858898),
        dec: Angle.Degrees(-36.65109707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 741"},
        {"Smithsonian Astrophysical Observation", "SAO 192373"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.27351039),
        dec: Angle.Degrees(-36.65060208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47305"},
        {"Hipparcos Number", "HIP 31549"},
        {"Smithsonian Astrophysical Observation", "SAO 196991"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.05506291),
        dec: Angle.Degrees(-36.64773494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205186"},
        {"Hipparcos Number", "HIP 106541"},
        {"Smithsonian Astrophysical Observation", "SAO 213103"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.66671710),
        dec: Angle.Degrees(-36.64697385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222196"},
        {"Hipparcos Number", "HIP 116670"},
        {"Smithsonian Astrophysical Observation", "SAO 214682"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.65647895),
        dec: Angle.Degrees(-36.64616628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82400"},
        {"Hipparcos Number", "HIP 46649"},
        {"Smithsonian Astrophysical Observation", "SAO 200446"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.67274750),
        dec: Angle.Degrees(-36.64350058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154682"},
        {"Hipparcos Number", "HIP 83874"},
        {"Geneva Identification System", "GEN# +1.00154682"},
        {"Smithsonian Astrophysical Observation", "SAO 208457"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.13640669),
        dec: Angle.Degrees(-36.64283078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153964"},
        {"Hipparcos Number", "HIP 83527"},
        {"Smithsonian Astrophysical Observation", "SAO 208365"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.05719030),
        dec: Angle.Degrees(-36.64260160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53235"},
        {"Geneva Identification System", "GEN# -0.03506811"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.34426439),
        dec: Angle.Degrees(-36.64142185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150655"},
        {"Hipparcos Number", "HIP 81921"},
        {"Smithsonian Astrophysical Observation", "SAO 207971"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.99330540),
        dec: Angle.Degrees(-36.63917731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208533"},
        {"Hipparcos Number", "HIP 108411"},
        {"Smithsonian Astrophysical Observation", "SAO 213437"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.43062384),
        dec: Angle.Degrees(-36.63899108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57416"},
        {"Smithsonian Astrophysical Observation", "SAO 202789"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.57617200),
        dec: Angle.Degrees(-36.63699903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90131"},
        {"Hipparcos Number", "HIP 50894"},
        {"Renson", "Renson 25910"},
        {"Smithsonian Astrophysical Observation", "SAO 201349"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.88826305),
        dec: Angle.Degrees(-36.63600795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173891"},
        {"Hipparcos Number", "HIP 92353"},
        {"Geneva Identification System", "GEN# +1.00173891"},
        {"Smithsonian Astrophysical Observation", "SAO 210601"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.33756610),
        dec: Angle.Degrees(-36.63535832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130328"},
        {"Hipparcos Number", "HIP 72432"},
        {"Geneva Identification System", "GEN# +1.00130328"},
        {"Smithsonian Astrophysical Observation", "SAO 205966"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.15857155),
        dec: Angle.Degrees(-36.63458507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65722"},
        {"Hipparcos Number", "HIP 38977"},
        {"Geneva Identification System", "GEN# +1.00065722"},
        {"Smithsonian Astrophysical Observation", "SAO 198655"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.63653108),
        dec: Angle.Degrees(-36.63457085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150530"},
        {"Hipparcos Number", "HIP 81853"},
        {"Smithsonian Astrophysical Observation", "SAO 207954"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.77346611),
        dec: Angle.Degrees(-36.63383217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184033"},
        {"Hipparcos Number", "HIP 96213"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.47178414),
        dec: Angle.Degrees(-36.63378402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100006"},
    },
    visualMagnitude: 10.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)17, 20.2800),
        dec: Angle.DegreesMinutesSeconds((int)-36, (int)38, 01.400)
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
    primaryId: "HIP 52341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52341"},
        {"Geneva Identification System", "GEN# -0.03506662A"},
        {"Smithsonian Astrophysical Observation", "SAO 201646"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.46625943),
        dec: Angle.Degrees(-36.63353726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185771"},
        {"Hipparcos Number", "HIP 96932"},
        {"Geneva Identification System", "GEN# +1.00185771"},
        {"Smithsonian Astrophysical Observation", "SAO 211487"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.55426217),
        dec: Angle.Degrees(-36.63326236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52818"},
        {"Hipparcos Number", "HIP 33797"},
        {"Smithsonian Astrophysical Observation", "SAO 197482"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.26399087),
        dec: Angle.Degrees(-36.63303363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45706"},
        {"Smithsonian Astrophysical Observation", "SAO 200230"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.76964925),
        dec: Angle.Degrees(-36.63238431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43106"},
        {"Hipparcos Number", "HIP 29485"},
        {"Geneva Identification System", "GEN# +1.00043106"},
        {"Smithsonian Astrophysical Observation", "SAO 196588"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.18159821),
        dec: Angle.Degrees(-36.63197800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107296"},
        {"Hipparcos Number", "HIP 60166"},
        {"Smithsonian Astrophysical Observation", "SAO 203358"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.06826204),
        dec: Angle.Degrees(-36.63186977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48630"},
        {"Hipparcos Number", "HIP 32136"},
        {"Celescope Catalog", "CEL 1363"},
        {"Geneva Identification System", "GEN# +1.00048630"},
        {"Smithsonian Astrophysical Observation", "SAO 197119"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.66853286),
        dec: Angle.Degrees(-36.63042757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192653"},
        {"Hipparcos Number", "HIP 100005"},
        {"Smithsonian Astrophysical Observation", "SAO 211966"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.32919754),
        dec: Angle.Degrees(-36.62928696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26282"},
        {"Hipparcos Number", "HIP 19288"},
        {"Smithsonian Astrophysical Observation", "SAO 194786"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.00715984),
        dec: Angle.Degrees(-36.62881555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21010"},
        {"Hipparcos Number", "HIP 15685"},
        {"Smithsonian Astrophysical Observation", "SAO 194259"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.51952735),
        dec: Angle.Degrees(-36.62841899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142408"},
        {"Hipparcos Number", "HIP 78014"},
        {"Smithsonian Astrophysical Observation", "SAO 207122"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.95086545),
        dec: Angle.Degrees(-36.62728743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130926"},
        {"Hipparcos Number", "HIP 72712"},
        {"Smithsonian Astrophysical Observation", "SAO 206021"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.99368218),
        dec: Angle.Degrees(-36.62716820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22791"},
        {"Hipparcos Number", "HIP 16981"},
        {"Geneva Identification System", "GEN# +1.00022791"},
        {"Smithsonian Astrophysical Observation", "SAO 194421"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.59989809),
        dec: Angle.Degrees(-36.62504028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32224"},
        {"Hipparcos Number", "HIP 23224"},
        {"Smithsonian Astrophysical Observation", "SAO 195467"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.96412959),
        dec: Angle.Degrees(-36.62443859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120734"},
        {"Hipparcos Number", "HIP 67682"},
        {"Geneva Identification System", "GEN# +1.00120734"},
        {"Smithsonian Astrophysical Observation", "SAO 204919"},
        {"Wilson Evans Batten Catalogue", "WEB 11905"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.98261451),
        dec: Angle.Degrees(-36.62341162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124324"},
        {"Hipparcos Number", "HIP 69508"},
        {"Geneva Identification System", "GEN# +1.00124324"},
        {"Smithsonian Astrophysical Observation", "SAO 205325"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.44262393),
        dec: Angle.Degrees(-36.62100382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141276"},
        {"Hipparcos Number", "HIP 77507"},
        {"Fundamental Katalog 5th Edition", "FK5 5400"},
        {"Smithsonian Astrophysical Observation", "SAO 207013"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.39326860),
        dec: Angle.Degrees(-36.61790985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25565"},
        {"Hipparcos Number", "HIP 18828"},
        {"Geneva Identification System", "GEN# +1.00025565"},
        {"Smithsonian Astrophysical Observation", "SAO 194710"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.52562913),
        dec: Angle.Degrees(-36.61660278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75653"},
        {"Hipparcos Number", "HIP 43358"},
        {"Geneva Identification System", "GEN# +1.00075653"},
        {"Smithsonian Astrophysical Observation", "SAO 199681"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.48208604),
        dec: Angle.Degrees(-36.61618479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46924"},
        {"Smithsonian Astrophysical Observation", "SAO 200500"},
        {"Wilson Evans Batten Catalogue", "WEB 8846"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.46193571),
        dec: Angle.Degrees(-36.61577729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191990"},
        {"Hipparcos Number", "HIP 99718"},
        {"Smithsonian Astrophysical Observation", "SAO 211924"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.51885222),
        dec: Angle.Degrees(-36.61507795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70327"},
        {"Hipparcos Number", "HIP 40826"},
        {"Celescope Catalog", "CEL 2379"},
        {"Geneva Identification System", "GEN# +1.00070327"},
        {"Smithsonian Astrophysical Observation", "SAO 199094"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.99351110),
        dec: Angle.Degrees(-36.61122474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193464"},
        {"Hipparcos Number", "HIP 100417"},
        {"Geneva Identification System", "GEN# +1.00193464"},
        {"Smithsonian Astrophysical Observation", "SAO 212038"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.42933369),
        dec: Angle.Degrees(-36.60997125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210021"},
        {"Hipparcos Number", "HIP 109264"},
        {"Smithsonian Astrophysical Observation", "SAO 213571"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.04781411),
        dec: Angle.Degrees(-36.60839245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73900"},
        {"Hipparcos Number", "HIP 42455"},
        {"Geneva Identification System", "GEN# +1.00073900J"},
        {"Smithsonian Astrophysical Observation", "SAO 199473"},
        {"Wilson Evans Batten Catalogue", "WEB 8169"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.84255538),
        dec: Angle.Degrees(-36.60681885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120037"},
        {"Hipparcos Number", "HIP 67310"},
        {"Geneva Identification System", "GEN# +1.00120037"},
        {"Smithsonian Astrophysical Observation", "SAO 204842"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.93112949),
        dec: Angle.Degrees(-36.60514550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167293"},
        {"Hipparcos Number", "HIP 89537"},
        {"Smithsonian Astrophysical Observation", "SAO 209931"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.05219852),
        dec: Angle.Degrees(-36.60148859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124993"},
        {"Hipparcos Number", "HIP 69840"},
        {"Smithsonian Astrophysical Observation", "SAO 205394"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.39716362),
        dec: Angle.Degrees(-36.59929239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 321320"},
        {"Hipparcos Number", "HIP 88648"},
        {"Geneva Identification System", "GEN# +1.00321320"},
        {"Wilson Evans Batten Catalogue", "WEB 15019"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.48246061),
        dec: Angle.Degrees(-36.59909965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -276.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137261"},
        {"Hipparcos Number", "HIP 75571"},
        {"Smithsonian Astrophysical Observation", "SAO 206647"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.57172487),
        dec: Angle.Degrees(-36.59825798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45268"},
        {"Hipparcos Number", "HIP 30508"},
        {"Smithsonian Astrophysical Observation", "SAO 196795"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.19408414),
        dec: Angle.Degrees(-36.59748555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39376"},
        {"Geneva Identification System", "GEN# -0.03604137"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.75687774),
        dec: Angle.Degrees(-36.59668851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139096"},
        {"Hipparcos Number", "HIP 76514"},
        {"Smithsonian Astrophysical Observation", "SAO 206815"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.39659862),
        dec: Angle.Degrees(-36.59652340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8410"},
        {"Hipparcos Number", "HIP 6440"},
        {"Geneva Identification System", "GEN# +1.00008410"},
        {"Smithsonian Astrophysical Observation", "SAO 193079"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.67922797),
        dec: Angle.Degrees(-36.59646586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189830"},
        {"Hipparcos Number", "HIP 98756"},
        {"Smithsonian Astrophysical Observation", "SAO 211769"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.88182931),
        dec: Angle.Degrees(-36.59630403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98284"},
        {"Hipparcos Number", "HIP 55189"},
        {"Geneva Identification System", "GEN# +1.00098284"},
        {"Smithsonian Astrophysical Observation", "SAO 202296"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.49303172),
        dec: Angle.Degrees(-36.59624967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49420"},
        {"Hipparcos Number", "HIP 32476"},
        {"Fundamental Katalog 5th Edition", "FK5 4618"},
        {"Smithsonian Astrophysical Observation", "SAO 197199"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.67337239),
        dec: Angle.Degrees(-36.59619879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88376"},
        {"Hipparcos Number", "HIP 49845"},
        {"Smithsonian Astrophysical Observation", "SAO 201128"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.65945985),
        dec: Angle.Degrees(-36.59470241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102626",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Speedy Mic"},
        {"Henry Draper", "HD 197890"},
        {"Hipparcos Number", "HIP 102626"},
        {"Geneva Identification System", "GEN# +1.00197890"},
        {"Smithsonian Astrophysical Observation", "SAO 212437"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.93749323),
        dec: Angle.Degrees(-36.59447993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197612"},
        {"Hipparcos Number", "HIP 102482"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.51629238),
        dec: Angle.Degrees(-36.59383632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6433"},
        {"Hipparcos Number", "HIP 5059"},
        {"Smithsonian Astrophysical Observation", "SAO 192912"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.17869184),
        dec: Angle.Degrees(-36.59280011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56779"},
        {"Hipparcos Number", "HIP 35226"},
        {"Celescope Catalog", "CEL 1739"},
        {"Geneva Identification System", "GEN# +1.00056779"},
        {"Smithsonian Astrophysical Observation", "SAO 197790"},
        {"Wilson Evans Batten Catalogue", "WEB 7037"},
    },
    visualMagnitude: 5.03,
    bvColour: -0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.20589876),
        dec: Angle.Degrees(-36.59264813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92579"},
        {"Hipparcos Number", "HIP 52268"},
        {"Smithsonian Astrophysical Observation", "SAO 201629"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.20768564),
        dec: Angle.Degrees(-36.58944025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114923"},
        {"Geneva Identification System", "GEN# -0.03715174"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.17374732),
        dec: Angle.Degrees(-36.58607771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37990"},
        {"Hipparcos Number", "HIP 26722"},
        {"Geneva Identification System", "GEN# +1.00037990"},
        {"Smithsonian Astrophysical Observation", "SAO 196075"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.17907131),
        dec: Angle.Degrees(-36.58496106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35975"},
        {"Hipparcos Number", "HIP 25465"},
        {"Smithsonian Astrophysical Observation", "SAO 195861"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.68681426),
        dec: Angle.Degrees(-36.58488954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94374"},
        {"Smithsonian Astrophysical Observation", "SAO 211040"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.11965717),
        dec: Angle.Degrees(-36.58463213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174541"},
        {"Hipparcos Number", "HIP 92639"},
        {"Geneva Identification System", "GEN# +1.00174541"},
        {"Smithsonian Astrophysical Observation", "SAO 210655"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.13589162),
        dec: Angle.Degrees(-36.58393793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140799"},
        {"Hipparcos Number", "HIP 77308"},
        {"Smithsonian Astrophysical Observation", "SAO 206967"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.74733342),
        dec: Angle.Degrees(-36.58288138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111322"},
        {"Hipparcos Number", "HIP 62526"},
        {"Smithsonian Astrophysical Observation", "SAO 203828"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.20253815),
        dec: Angle.Degrees(-36.58200127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94871"},
        {"Hipparcos Number", "HIP 53499"},
        {"Smithsonian Astrophysical Observation", "SAO 201923"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.16021649),
        dec: Angle.Degrees(-36.58054285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165063"},
        {"Hipparcos Number", "HIP 88629"},
        {"Geneva Identification System", "GEN# +1.00165063"},
        {"Smithsonian Astrophysical Observation", "SAO 209691"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.43571282),
        dec: Angle.Degrees(-36.57946456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103257"},
        {"Hipparcos Number", "HIP 57960"},
        {"Geneva Identification System", "GEN# +1.00103257"},
        {"Smithsonian Astrophysical Observation", "SAO 202903"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.32002679),
        dec: Angle.Degrees(-36.57726344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102308"},
        {"Smithsonian Astrophysical Observation", "SAO 212386"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.93903377),
        dec: Angle.Degrees(-36.57682765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175195"},
        {"Hipparcos Number", "HIP 92907"},
        {"Smithsonian Astrophysical Observation", "SAO 210723"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.94871396),
        dec: Angle.Degrees(-36.57663770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211722"},
        {"Hipparcos Number", "HIP 110244"},
        {"Geneva Identification System", "GEN# +1.00211722"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.96835359),
        dec: Angle.Degrees(-36.57611497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179579"},
        {"Hipparcos Number", "HIP 94553"},
        {"Smithsonian Astrophysical Observation", "SAO 211078"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.66080932),
        dec: Angle.Degrees(-36.57418744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200008"},
        {"Hipparcos Number", "HIP 103783"},
        {"Smithsonian Astrophysical Observation", "SAO 212643"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.46096123),
        dec: Angle.Degrees(-36.57413517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167233"},
        {"Hipparcos Number", "HIP 89502"},
        {"Geneva Identification System", "GEN# +1.00167233"},
        {"Smithsonian Astrophysical Observation", "SAO 209922"},
        {"Wilson Evans Batten Catalogue", "WEB 15232"},
    },
    visualMagnitude: 6.94,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.96210248),
        dec: Angle.Degrees(-36.57375634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75301"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.78350250),
        dec: Angle.Degrees(-36.57311870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13841"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.53787594),
        dec: Angle.Degrees(-36.57229772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 195.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36346"},
        {"Hipparcos Number", "HIP 25703"},
        {"Smithsonian Astrophysical Observation", "SAO 195903"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.33137016),
        dec: Angle.Degrees(-36.57146056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112979"},
        {"Hipparcos Number", "HIP 63518"},
        {"Smithsonian Astrophysical Observation", "SAO 204036"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.24040787),
        dec: Angle.Degrees(-36.56709065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2338"},
        {"Hipparcos Number", "HIP 2136"},
        {"Geneva Identification System", "GEN# +1.00002338"},
        {"Smithsonian Astrophysical Observation", "SAO 192528"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.77197154),
        dec: Angle.Degrees(-36.56647579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26620"},
        {"Smithsonian Astrophysical Observation", "SAO 196058"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.87508444),
        dec: Angle.Degrees(-36.56640605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199242"},
        {"Hipparcos Number", "HIP 103415"},
        {"Geneva Identification System", "GEN# +1.00199242"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.29399261),
        dec: Angle.Degrees(-36.56598283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146546"},
        {"Hipparcos Number", "HIP 79884"},
        {"Smithsonian Astrophysical Observation", "SAO 207528"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.58806031),
        dec: Angle.Degrees(-36.56598269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20759"},
        {"Hipparcos Number", "HIP 15462"},
        {"Geneva Identification System", "GEN# +1.00020759"},
        {"Smithsonian Astrophysical Observation", "SAO 194231"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.84785333),
        dec: Angle.Degrees(-36.56503417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43071"},
        {"Hipparcos Number", "HIP 29464"},
        {"Geneva Identification System", "GEN# +1.00043071"},
        {"Smithsonian Astrophysical Observation", "SAO 196585"},
        {"Wilson Evans Batten Catalogue", "WEB 5794"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.12150074),
        dec: Angle.Degrees(-36.56375352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211086"},
        {"Hipparcos Number", "HIP 109892"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.86484008),
        dec: Angle.Degrees(-36.56360134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104270"},
        {"Hipparcos Number", "HIP 58548"},
        {"Renson", "Renson 30160"},
        {"Smithsonian Astrophysical Observation", "SAO 203029"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.08551309),
        dec: Angle.Degrees(-36.56269394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56453"},
        {"Hipparcos Number", "HIP 35094"},
        {"Geneva Identification System", "GEN# +1.00056453"},
        {"Smithsonian Astrophysical Observation", "SAO 197762"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.86942979),
        dec: Angle.Degrees(-36.56088180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134288"},
        {"Hipparcos Number", "HIP 74228"},
        {"Geneva Identification System", "GEN# +1.00134288"},
        {"Smithsonian Astrophysical Observation", "SAO 206353"},
        {"Wilson Evans Batten Catalogue", "WEB 12673"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.54105108),
        dec: Angle.Degrees(-36.55758378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58587"},
        {"Hipparcos Number", "HIP 35952"},
        {"Smithsonian Astrophysical Observation", "SAO 197968"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.16847061),
        dec: Angle.Degrees(-36.55723983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51015"},
        {"Hipparcos Number", "HIP 33132"},
        {"Geneva Identification System", "GEN# +1.00051015"},
        {"Smithsonian Astrophysical Observation", "SAO 197331"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.48708509),
        dec: Angle.Degrees(-36.55671653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106337"},
        {"Hipparcos Number", "HIP 59662"},
        {"Geneva Identification System", "GEN# +1.00106337"},
        {"Smithsonian Astrophysical Observation", "SAO 203262"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.52895584),
        dec: Angle.Degrees(-36.55646027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150369"},
        {"Hipparcos Number", "HIP 81769"},
        {"Smithsonian Astrophysical Observation", "SAO 207936"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.53255517),
        dec: Angle.Degrees(-36.55634841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208992"},
        {"Hipparcos Number", "HIP 108681"},
        {"Smithsonian Astrophysical Observation", "SAO 213472"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.24617111),
        dec: Angle.Degrees(-36.55622318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210976"},
        {"Hipparcos Number", "HIP 109839"},
        {"Smithsonian Astrophysical Observation", "SAO 213663"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.69779201),
        dec: Angle.Degrees(-36.55460250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133898"},
        {"Hipparcos Number", "HIP 74056"},
        {"Smithsonian Astrophysical Observation", "SAO 206321"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.02363620),
        dec: Angle.Degrees(-36.55337295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136569"},
        {"Hipparcos Number", "HIP 75251"},
        {"Geneva Identification System", "GEN# +1.00136569"},
        {"Smithsonian Astrophysical Observation", "SAO 206571"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.65260261),
        dec: Angle.Degrees(-36.55315491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141362"},
        {"Hipparcos Number", "HIP 77556"},
        {"Smithsonian Astrophysical Observation", "SAO 207023"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.51624368),
        dec: Angle.Degrees(-36.55198052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128032"},
        {"Hipparcos Number", "HIP 71362"},
        {"Smithsonian Astrophysical Observation", "SAO 205729"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.90725540),
        dec: Angle.Degrees(-36.55176372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141094"},
        {"Hipparcos Number", "HIP 77443"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.15128967),
        dec: Angle.Degrees(-36.55129750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116049"},
        {"Hipparcos Number", "HIP 65196"},
        {"Smithsonian Astrophysical Observation", "SAO 204385"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.41245666),
        dec: Angle.Degrees(-36.54917638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68826"},
        {"Smithsonian Astrophysical Observation", "SAO 205163"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.38190211),
        dec: Angle.Degrees(-36.54887638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220674"},
        {"Hipparcos Number", "HIP 115660"},
        {"Smithsonian Astrophysical Observation", "SAO 214541"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.46060053),
        dec: Angle.Degrees(-36.54874868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103443"},
        {"Geneva Identification System", "GEN# -0.03714010"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.36401792),
        dec: Angle.Degrees(-36.54798223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68334"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.82367675),
        dec: Angle.Degrees(-36.54785471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164519"},
        {"Hipparcos Number", "HIP 88426"},
        {"Smithsonian Astrophysical Observation", "SAO 209638"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.80197821),
        dec: Angle.Degrees(-36.54765961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204635"},
        {"Hipparcos Number", "HIP 106224"},
        {"Smithsonian Astrophysical Observation", "SAO 213058"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.74043319),
        dec: Angle.Degrees(-36.54713452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154232"},
        {"Hipparcos Number", "HIP 83646"},
        {"Smithsonian Astrophysical Observation", "SAO 208391"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.44109682),
        dec: Angle.Degrees(-36.54685884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173574"},
        {"Hipparcos Number", "HIP 92220"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.91825675),
        dec: Angle.Degrees(-36.54576158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76073"},
        {"Henry Draper 2", "HD 76072"},
        {"Hipparcos Number", "HIP 43590"},
        {"Geneva Identification System", "GEN# +1.00076072J"},
        {"Smithsonian Astrophysical Observation", "SAO 199731"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.16125560),
        dec: Angle.Degrees(-36.54533685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122917"},
        {"Hipparcos Number", "HIP 68824"},
        {"Smithsonian Astrophysical Observation", "SAO 205162"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.37645467),
        dec: Angle.Degrees(-36.54522933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26832"},
        {"Hipparcos Number", "HIP 19694"},
        {"Smithsonian Astrophysical Observation", "SAO 194838"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.28008130),
        dec: Angle.Degrees(-36.54507402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55718"},
        {"Hipparcos Number", "HIP 34817"},
        {"Celescope Catalog", "CEL 1677"},
        {"Geneva Identification System", "GEN# +1.00055718J"},
        {"Smithsonian Astrophysical Observation", "SAO 197694"},
        {"Wilson Evans Batten Catalogue", "WEB 6962"},
    },
    visualMagnitude: 5.94,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.10762542),
        dec: Angle.Degrees(-36.54439953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7027"},
        {"Hipparcos Number", "HIP 5478"},
        {"Geneva Identification System", "GEN# +1.00007027"},
        {"Smithsonian Astrophysical Observation", "SAO 192960"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.53084893),
        dec: Angle.Degrees(-36.54436113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47808"},
    },
    visualMagnitude: 11.43,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.18980649),
        dec: Angle.Degrees(-36.54361553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -267.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22876"},
        {"Smithsonian Astrophysical Observation", "SAO 131597"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.81717603),
        dec: Angle.Degrees(-04.33946196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211845"},
        {"Hipparcos Number", "HIP 110315"},
        {"Smithsonian Astrophysical Observation", "SAO 213749"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.16445424),
        dec: Angle.Degrees(-36.53974228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196288"},
        {"Hipparcos Number", "HIP 101778"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.40998067),
        dec: Angle.Degrees(-36.53898999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47467"},
        {"Smithsonian Astrophysical Observation", "SAO 200620"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.14539533),
        dec: Angle.Degrees(-36.53712937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132590"},
        {"Hipparcos Number", "HIP 73484"},
        {"Smithsonian Astrophysical Observation", "SAO 206205"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.25987204),
        dec: Angle.Degrees(-36.53491207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98233"},
        {"Hipparcos Number", "HIP 55168"},
        {"Geneva Identification System", "GEN# +1.00098233"},
        {"Smithsonian Astrophysical Observation", "SAO 202291"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.42891754),
        dec: Angle.Degrees(-36.53429812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58771"},
        {"Smithsonian Astrophysical Observation", "SAO 203073"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.81364342),
        dec: Angle.Degrees(-36.53392121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111824"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.74507110),
        dec: Angle.Degrees(-36.53328110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114246"},
        {"Hipparcos Number", "HIP 64229"},
        {"Geneva Identification System", "GEN# +1.00114246"},
        {"Smithsonian Astrophysical Observation", "SAO 204182"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.45329418),
        dec: Angle.Degrees(-36.53256503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7867"},
        {"Hipparcos Number", "HIP 6068"},
        {"Geneva Identification System", "GEN# +1.00007867"},
        {"Smithsonian Astrophysical Observation", "SAO 193035"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.46892548),
        dec: Angle.Degrees(-36.52965458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83609"},
        {"Hipparcos Number", "HIP 47339"},
        {"Geneva Identification System", "GEN# +1.00083609"},
        {"Smithsonian Astrophysical Observation", "SAO 200592"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.70097878),
        dec: Angle.Degrees(-36.52928668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51798"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.74863859),
        dec: Angle.Degrees(-36.52832237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10142"},
        {"Hipparcos Number", "HIP 7643"},
        {"Geneva Identification System", "GEN# +1.00010142"},
        {"Smithsonian Astrophysical Observation", "SAO 193224"},
        {"Wilson Evans Batten Catalogue", "WEB 1637"},
    },
    visualMagnitude: 5.94,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.61455891),
        dec: Angle.Degrees(-36.52795330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44265"},
        {"Hipparcos Number", "HIP 30032"},
        {"Geneva Identification System", "GEN# +1.00044265"},
        {"Smithsonian Astrophysical Observation", "SAO 196683"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.79595817),
        dec: Angle.Degrees(-36.52597470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137413"},
        {"Hipparcos Number", "HIP 75633"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.79146793),
        dec: Angle.Degrees(-36.52541660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117938"},
        {"Hipparcos Number", "HIP 66219"},
        {"Smithsonian Astrophysical Observation", "SAO 204604"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.57953231),
        dec: Angle.Degrees(-36.52372051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161791"},
        {"Hipparcos Number", "HIP 87218"},
        {"Geneva Identification System", "GEN# +1.00161791J"},
        {"Smithsonian Astrophysical Observation", "SAO 209297"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.28329102),
        dec: Angle.Degrees(-36.52327059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193569"},
        {"Hipparcos Number", "HIP 100456"},
        {"Smithsonian Astrophysical Observation", "SAO 212051"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.56602224),
        dec: Angle.Degrees(-36.52285657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145172"},
        {"Hipparcos Number", "HIP 79299"},
        {"Smithsonian Astrophysical Observation", "SAO 207422"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.74732433),
        dec: Angle.Degrees(-36.52186472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213455"},
        {"Hipparcos Number", "HIP 111224"},
        {"Smithsonian Astrophysical Observation", "SAO 213888"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.01359489),
        dec: Angle.Degrees(-36.52067588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89015"},
        {"Hipparcos Number", "HIP 50234"},
        {"Geneva Identification System", "GEN# +1.00089015"},
        {"Smithsonian Astrophysical Observation", "SAO 201211"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.83705315),
        dec: Angle.Degrees(-36.51773519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151472"},
        {"Hipparcos Number", "HIP 82311"},
        {"Smithsonian Astrophysical Observation", "SAO 208062"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.26792459),
        dec: Angle.Degrees(-36.51554121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27453"},
        {"Hipparcos Number", "HIP 20092"},
        {"Smithsonian Astrophysical Observation", "SAO 194915"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.61815498),
        dec: Angle.Degrees(-36.51443351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198688"},
        {"Hipparcos Number", "HIP 103088"},
        {"Smithsonian Astrophysical Observation", "SAO 212515"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.30967128),
        dec: Angle.Degrees(-36.51376703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74452"},
        {"Hipparcos Number", "HIP 42758"},
        {"Smithsonian Astrophysical Observation", "SAO 199533"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.70119731),
        dec: Angle.Degrees(-36.51369499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118351"},
        {"Hipparcos Number", "HIP 66426"},
        {"Smithsonian Astrophysical Observation", "SAO 204659"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.27385117),
        dec: Angle.Degrees(-36.51287292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109434"},
        {"Hipparcos Number", "HIP 61393"},
        {"Smithsonian Astrophysical Observation", "SAO 203604"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.71166712),
        dec: Angle.Degrees(-36.51283126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1434"},
        {"Hipparcos Number", "HIP 1469"},
        {"Smithsonian Astrophysical Observation", "SAO 192453"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.57672776),
        dec: Angle.Degrees(-36.50989445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162613"},
        {"Hipparcos Number", "HIP 87580"},
        {"Renson", "Renson 45910"},
        {"Smithsonian Astrophysical Observation", "SAO 209419"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.37498043),
        dec: Angle.Degrees(-36.50854376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93970"},
        {"Hipparcos Number", "HIP 52981"},
        {"Smithsonian Astrophysical Observation", "SAO 201810"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.57540713),
        dec: Angle.Degrees(-36.50728184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191053"},
        {"Hipparcos Number", "HIP 99296"},
        {"Geneva Identification System", "GEN# +1.00191053"},
        {"Smithsonian Astrophysical Observation", "SAO 211860"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.34604967),
        dec: Angle.Degrees(-36.50438477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61517"},
        {"Hipparcos Number", "HIP 37157"},
        {"Smithsonian Astrophysical Observation", "SAO 198219"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.53847976),
        dec: Angle.Degrees(-36.50366857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159277"},
        {"Hipparcos Number", "HIP 86071"},
        {"Smithsonian Astrophysical Observation", "SAO 208992"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.86203399),
        dec: Angle.Degrees(-36.50360391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95222"},
        {"Hipparcos Number", "HIP 53694"},
        {"Smithsonian Astrophysical Observation", "SAO 201975"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.79028987),
        dec: Angle.Degrees(-36.50334237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214972"},
        {"Hipparcos Number", "HIP 112112"},
        {"Geneva Identification System", "GEN# +1.00214972"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.64440685),
        dec: Angle.Degrees(-36.50278582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27219"},
        {"Hipparcos Number", "HIP 19920"},
        {"Smithsonian Astrophysical Observation", "SAO 194885"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.11302116),
        dec: Angle.Degrees(-36.50235732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190307"},
        {"Hipparcos Number", "HIP 98990"},
        {"Geneva Identification System", "GEN# +1.00190307"},
        {"Smithsonian Astrophysical Observation", "SAO 211802"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.44207265),
        dec: Angle.Degrees(-36.49947532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60977",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60977"},
    },
    visualMagnitude: 12.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.48412291),
        dec: Angle.Degrees(-36.49849957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126446"},
        {"Hipparcos Number", "HIP 70607"},
        {"Smithsonian Astrophysical Observation", "SAO 205558"},
    },
    visualMagnitude: 9.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.63623516),
        dec: Angle.Degrees(-36.49797017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61641"},
        {"Hipparcos Number", "HIP 37223"},
        {"Celescope Catalog", "CEL 1962"},
        {"Geneva Identification System", "GEN# +1.00061641"},
        {"Renson", "Renson 16910"},
        {"Smithsonian Astrophysical Observation", "SAO 198237"},
        {"Wilson Evans Batten Catalogue", "WEB 7374"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.68293452),
        dec: Angle.Degrees(-36.49684165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1947"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.15581956),
        dec: Angle.Degrees(-36.49682085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103725"},
        {"Hipparcos Number", "HIP 58238"},
        {"Smithsonian Astrophysical Observation", "SAO 202964"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.17184901),
        dec: Angle.Degrees(-36.49611384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35756"},
        {"Hipparcos Number", "HIP 25345"},
        {"Geneva Identification System", "GEN# +1.00035756"},
        {"Smithsonian Astrophysical Observation", "SAO 195836"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.32073380),
        dec: Angle.Degrees(-36.49551351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108186"},
        {"Smithsonian Astrophysical Observation", "SAO 213387"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.77890124),
        dec: Angle.Degrees(-36.49423180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16789"},
        {"Hipparcos Number", "HIP 12470"},
        {"Smithsonian Astrophysical Observation", "SAO 193850"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.13248473),
        dec: Angle.Degrees(-36.49388693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27942"},
        {"Hipparcos Number", "HIP 20462"},
        {"Geneva Identification System", "GEN# +1.00027942"},
        {"Smithsonian Astrophysical Observation", "SAO 194968"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.76107355),
        dec: Angle.Degrees(-36.49146267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38920"},
        {"Hipparcos Number", "HIP 27340"},
        {"Smithsonian Astrophysical Observation", "SAO 196175"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.86177855),
        dec: Angle.Degrees(-36.48727224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 319738"},
        {"Hipparcos Number", "HIP 85117"},
        {"Wilson Evans Batten Catalogue", "WEB 14374"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.93475407),
        dec: Angle.Degrees(-36.48640098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98857"},
        {"Hipparcos Number", "HIP 55520"},
        {"Geneva Identification System", "GEN# +1.00098857"},
        {"Smithsonian Astrophysical Observation", "SAO 202371"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.56779182),
        dec: Angle.Degrees(-36.48604346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1010"},
        {"Smithsonian Astrophysical Observation", "SAO 192400"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.14640282),
        dec: Angle.Degrees(-36.48600696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70556"},
        {"Hipparcos Number", "HIP 40943"},
        {"Celescope Catalog", "CEL 2410"},
        {"Geneva Identification System", "GEN# +1.00070556J"},
        {"Smithsonian Astrophysical Observation", "SAO 199119"},
        {"Wilson Evans Batten Catalogue", "WEB 7940"},
    },
    visualMagnitude: 5.18,
    bvColour: -0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.33770565),
        dec: Angle.Degrees(-36.48419365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82238"},
        {"Hipparcos Number", "HIP 46572"},
        {"Geneva Identification System", "GEN# +1.00082238"},
        {"Smithsonian Astrophysical Observation", "SAO 200430"},
        {"Wilson Evans Batten Catalogue", "WEB 8789"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.46518867),
        dec: Angle.Degrees(-36.48346424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10370"},
        {"Hipparcos Number", "HIP 7822"},
        {"Geneva Identification System", "GEN# +1.00010370"},
        {"Smithsonian Astrophysical Observation", "SAO 193248"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.15145606),
        dec: Angle.Degrees(-36.48323827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103016"},
        {"Hipparcos Number", "HIP 57825"},
        {"Smithsonian Astrophysical Observation", "SAO 202878"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.87999246),
        dec: Angle.Degrees(-36.48279430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217706"},
        {"Hipparcos Number", "HIP 113818"},
        {"Smithsonian Astrophysical Observation", "SAO 214265"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.72842901),
        dec: Angle.Degrees(-36.48258868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218360"},
        {"Hipparcos Number", "HIP 114208"},
        {"Smithsonian Astrophysical Observation", "SAO 214327"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.92825430),
        dec: Angle.Degrees(-36.48154534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20169"},
        {"Hipparcos Number", "HIP 14983"},
        {"Smithsonian Astrophysical Observation", "SAO 194166"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.28371240),
        dec: Angle.Degrees(-36.47985796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121732"},
        {"Hipparcos Number", "HIP 68217"},
        {"Smithsonian Astrophysical Observation", "SAO 205040"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.48874147),
        dec: Angle.Degrees(-36.47962039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33835"},
        {"Hipparcos Number", "HIP 24165"},
        {"Smithsonian Astrophysical Observation", "SAO 195633"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.83953219),
        dec: Angle.Degrees(-36.47928617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1676"},
        {"Hipparcos Number", "HIP 1662"},
        {"Fundamental Katalog 5th Edition", "FK5 4038"},
        {"Smithsonian Astrophysical Observation", "SAO 192471"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.20662909),
        dec: Angle.Degrees(-36.47768325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50396"},
        {"Hipparcos Number", "HIP 32904"},
        {"Smithsonian Astrophysical Observation", "SAO 197287"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.84056030),
        dec: Angle.Degrees(-36.47563677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162926"},
        {"Hipparcos Number", "HIP 87722"},
        {"Geneva Identification System", "GEN# +1.00162926"},
        {"Smithsonian Astrophysical Observation", "SAO 209458"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.78345435),
        dec: Angle.Degrees(-36.47563276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44309"},
        {"Hipparcos Number", "HIP 30053"},
        {"Smithsonian Astrophysical Observation", "SAO 196685"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.86644840),
        dec: Angle.Degrees(-36.47435136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48262"},
        {"Hipparcos Number", "HIP 31971"},
        {"Smithsonian Astrophysical Observation", "SAO 197082"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.23061361),
        dec: Angle.Degrees(-36.47346875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137230"},
        {"Hipparcos Number", "HIP 75549"},
        {"Smithsonian Astrophysical Observation", "SAO 206638"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.51550283),
        dec: Angle.Degrees(-36.47298370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28014"},
        {"Hipparcos Number", "HIP 20520"},
        {"Geneva Identification System", "GEN# +1.00028014"},
        {"Smithsonian Astrophysical Observation", "SAO 194980"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.95816347),
        dec: Angle.Degrees(-36.47239042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116567"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.34155647),
        dec: Angle.Degrees(-36.47195981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14119"},
        {"Hipparcos Number", "HIP 10567"},
        {"Geneva Identification System", "GEN# +1.00014119"},
        {"Smithsonian Astrophysical Observation", "SAO 193611"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.00696333),
        dec: Angle.Degrees(-36.47150914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193463"},
        {"Hipparcos Number", "HIP 100413"},
        {"Smithsonian Astrophysical Observation", "SAO 212039"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.42724495),
        dec: Angle.Degrees(-36.47125712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187310"},
        {"Hipparcos Number", "HIP 97645"},
        {"Smithsonian Astrophysical Observation", "SAO 211594"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.68381427),
        dec: Angle.Degrees(-36.46990630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41069"},
        {"Hipparcos Number", "HIP 28515"},
        {"Smithsonian Astrophysical Observation", "SAO 196411"},
        {"Wilson Evans Batten Catalogue", "WEB 5571"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.28736810),
        dec: Angle.Degrees(-36.46890980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174151"},
        {"Hipparcos Number", "HIP 92471"},
        {"Smithsonian Astrophysical Observation", "SAO 210622"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.67423376),
        dec: Angle.Degrees(-36.46806187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122588"},
        {"Hipparcos Number", "HIP 68683"},
        {"Geneva Identification System", "GEN# +1.00122588"},
        {"Smithsonian Astrophysical Observation", "SAO 205130"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.89380968),
        dec: Angle.Degrees(-36.46464334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41025"},
        {"New General Catalogue", "NGC 2579 48"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.58866569),
        dec: Angle.Degrees(-36.46381504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110530"},
        {"Hipparcos Number", "HIP 62052"},
        {"Smithsonian Astrophysical Observation", "SAO 203742"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.77445167),
        dec: Angle.Degrees(-36.46154461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157418"},
        {"Hipparcos Number", "HIP 85210"},
        {"Smithsonian Astrophysical Observation", "SAO 208780"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.17945750),
        dec: Angle.Degrees(-36.45947912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129948"},
        {"Hipparcos Number", "HIP 72248"},
        {"Smithsonian Astrophysical Observation", "SAO 205924"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.61720232),
        dec: Angle.Degrees(-36.45751292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94504"},
        {"Hipparcos Number", "HIP 53289"},
        {"Geneva Identification System", "GEN# +1.00094504"},
        {"Smithsonian Astrophysical Observation", "SAO 201873"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.48527993),
        dec: Angle.Degrees(-36.45689575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155736"},
        {"Hipparcos Number", "HIP 84370"},
        {"Smithsonian Astrophysical Observation", "SAO 208578"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.73216119),
        dec: Angle.Degrees(-36.45409345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30251"},
        {"Hipparcos Number", "HIP 22043"},
        {"Smithsonian Astrophysical Observation", "SAO 195261"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.09742813),
        dec: Angle.Degrees(-36.45391213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9894"},
        {"Hipparcos Number", "HIP 7449"},
        {"Geneva Identification System", "GEN# +1.00009894"},
        {"Smithsonian Astrophysical Observation", "SAO 193200"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.99553688),
        dec: Angle.Degrees(-36.45365558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192472"},
        {"Hipparcos Number", "HIP 99920"},
        {"Geneva Identification System", "GEN# +1.00192472J"},
        {"Smithsonian Astrophysical Observation", "SAO 211948"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.09837360),
        dec: Angle.Degrees(-36.45353610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199370"},
        {"Hipparcos Number", "HIP 103479"},
        {"Geneva Identification System", "GEN# +1.00199370"},
        {"Smithsonian Astrophysical Observation", "SAO 212579"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.47681435),
        dec: Angle.Degrees(-36.45311810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126668"},
        {"Hipparcos Number", "HIP 70726"},
        {"Smithsonian Astrophysical Observation", "SAO 205582"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.97011182),
        dec: Angle.Degrees(-36.45242259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147493"},
        {"Hipparcos Number", "HIP 80312"},
        {"Geneva Identification System", "GEN# +1.00147493"},
        {"Smithsonian Astrophysical Observation", "SAO 207621"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.94677607),
        dec: Angle.Degrees(-36.45173743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196475"},
        {"Hipparcos Number", "HIP 101889"},
        {"Geneva Identification System", "GEN# +1.00196475"},
        {"Smithsonian Astrophysical Observation", "SAO 212311"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.71949738),
        dec: Angle.Degrees(-36.45010655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163604"},
        {"Hipparcos Number", "HIP 88000"},
        {"Smithsonian Astrophysical Observation", "SAO 209535"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.63110966),
        dec: Angle.Degrees(-36.44957985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209188"},
        {"Hipparcos Number", "HIP 108790"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.57147221),
        dec: Angle.Degrees(-36.44890379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10804"},
        {"Hipparcos Number", "HIP 8162"},
        {"Smithsonian Astrophysical Observation", "SAO 193286"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.24742684),
        dec: Angle.Degrees(-36.44637779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129855"},
        {"Hipparcos Number", "HIP 72196"},
        {"Smithsonian Astrophysical Observation", "SAO 205915"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.50012672),
        dec: Angle.Degrees(-36.44568626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203969"},
        {"Hipparcos Number", "HIP 105865"},
        {"Smithsonian Astrophysical Observation", "SAO 212999"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.61787527),
        dec: Angle.Degrees(-36.44298535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91719"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.55247199),
        dec: Angle.Degrees(-36.44203660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76485"},
        {"Hipparcos Number", "HIP 43801"},
        {"Smithsonian Astrophysical Observation", "SAO 199788"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.81439606),
        dec: Angle.Degrees(-36.43673122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51149"},
        {"Smithsonian Astrophysical Observation", "SAO 201404"},
    },
    visualMagnitude: 10.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.73210478),
        dec: Angle.Degrees(-36.43672889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139503"},
        {"Hipparcos Number", "HIP 76711"},
        {"Geneva Identification System", "GEN# +1.00139503"},
        {"Smithsonian Astrophysical Observation", "SAO 206844"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.96753816),
        dec: Angle.Degrees(-36.43520924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5591"},
        {"Hipparcos Number", "HIP 4462"},
        {"Geneva Identification System", "GEN# +1.00005591"},
        {"Smithsonian Astrophysical Observation", "SAO 192835"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.29940186),
        dec: Angle.Degrees(-36.43508855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101563"},
        {"Smithsonian Astrophysical Observation", "SAO 212251"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.75787220),
        dec: Angle.Degrees(-36.43435004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26123"},
        {"Smithsonian Astrophysical Observation", "SAO 195972"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.56632824),
        dec: Angle.Degrees(-36.43366061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120672"},
        {"Hipparcos Number", "HIP 67648"},
        {"Geneva Identification System", "GEN# +1.00120672"},
        {"Smithsonian Astrophysical Observation", "SAO 204911"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.90240126),
        dec: Angle.Degrees(-36.43300247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18487"},
        {"Hipparcos Number", "HIP 13767"},
        {"Geneva Identification System", "GEN# +1.00018487"},
        {"Smithsonian Astrophysical Observation", "SAO 194005"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.30267677),
        dec: Angle.Degrees(-36.43298341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134054"},
        {"Hipparcos Number", "HIP 74139"},
        {"Smithsonian Astrophysical Observation", "SAO 206336"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.24892555),
        dec: Angle.Degrees(-36.43262039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3450"},
        {"Smithsonian Astrophysical Observation", "SAO 192701"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.02491861),
        dec: Angle.Degrees(-36.43233334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131461"},
        {"Hipparcos Number", "HIP 72984"},
        {"Smithsonian Astrophysical Observation", "SAO 206083"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.72707131),
        dec: Angle.Degrees(-36.43029089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108261"},
        {"Smithsonian Astrophysical Observation", "SAO 213404"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.98482507),
        dec: Angle.Degrees(-36.42966388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168237"},
        {"Hipparcos Number", "HIP 89868"},
        {"Smithsonian Astrophysical Observation", "SAO 210007"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.08511043),
        dec: Angle.Degrees(-36.42938523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15889"},
        {"Hipparcos Number", "HIP 11802"},
        {"Geneva Identification System", "GEN# +1.00015889"},
        {"Smithsonian Astrophysical Observation", "SAO 193759"},
        {"Wilson Evans Batten Catalogue", "WEB 2446"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.06133465),
        dec: Angle.Degrees(-36.42733787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56142"},
        {"Hipparcos Number", "HIP 34979"},
        {"Geneva Identification System", "GEN# +1.00056142"},
        {"Smithsonian Astrophysical Observation", "SAO 197732"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.55856923),
        dec: Angle.Degrees(-36.42674127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24305"},
        {"Hipparcos Number", "HIP 17982"},
        {"Geneva Identification System", "GEN# +1.00024305"},
        {"Smithsonian Astrophysical Observation", "SAO 194570"},
        {"Wilson Evans Batten Catalogue", "WEB 3465"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.65645519),
        dec: Angle.Degrees(-36.42561968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9206"},
        {"Hipparcos Number", "HIP 6996"},
        {"Geneva Identification System", "GEN# +1.00009206"},
        {"Smithsonian Astrophysical Observation", "SAO 193148"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.50962996),
        dec: Angle.Degrees(-36.42486820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17564"},
        {"Hipparcos Number", "HIP 13072"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.00225629),
        dec: Angle.Degrees(-36.42458278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201852"},
        {"Hipparcos Number", "HIP 104752"},
        {"Geneva Identification System", "GEN# +1.00201852"},
        {"Smithsonian Astrophysical Observation", "SAO 212800"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.32890517),
        dec: Angle.Degrees(-36.42353599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50356"},
        {"Smithsonian Astrophysical Observation", "SAO 201241"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.23549470),
        dec: Angle.Degrees(-36.42284469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217642"},
        {"Hipparcos Number", "HIP 113784"},
        {"Geneva Identification System", "GEN# +1.00217642"},
        {"Smithsonian Astrophysical Observation", "SAO 214261"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.64195419),
        dec: Angle.Degrees(-36.42080597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54113"},
        {"Hipparcos Number", "HIP 34249"},
        {"Smithsonian Astrophysical Observation", "SAO 197570"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.50327860),
        dec: Angle.Degrees(-36.42002721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179980"},
        {"Hipparcos Number", "HIP 94698"},
        {"Smithsonian Astrophysical Observation", "SAO 211106"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.04688301),
        dec: Angle.Degrees(-36.41954644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118317"},
        {"Smithsonian Astrophysical Observation", "SAO 214906"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.96170060),
        dec: Angle.Degrees(-36.41948090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139824"},
        {"Hipparcos Number", "HIP 76856"},
        {"Smithsonian Astrophysical Observation", "SAO 206874"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.40355081),
        dec: Angle.Degrees(-36.41918553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67780"},
        {"Hipparcos Number", "HIP 39814"},
        {"Geneva Identification System", "GEN# +1.00067780"},
        {"Smithsonian Astrophysical Observation", "SAO 198838"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.03357244),
        dec: Angle.Degrees(-36.41849095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61373"},
        {"Hipparcos Number", "HIP 37098"},
        {"Smithsonian Astrophysical Observation", "SAO 198201"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.34816238),
        dec: Angle.Degrees(-36.41793813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203197"},
        {"Hipparcos Number", "HIP 105473"},
        {"Fundamental Katalog 5th Edition", "FK5 5882"},
        {"Smithsonian Astrophysical Observation", "SAO 212942"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.44986405),
        dec: Angle.Degrees(-36.41726321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17710"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.90053051),
        dec: Angle.Degrees(-36.41344949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104041"},
        {"Hipparcos Number", "HIP 58430"},
        {"Smithsonian Astrophysical Observation", "SAO 203002"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.71186681),
        dec: Angle.Degrees(-36.41300550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66889"},
        {"Hipparcos Number", "HIP 39481"},
        {"Smithsonian Astrophysical Observation", "SAO 198762"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.03561349),
        dec: Angle.Degrees(-36.41241338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165981"},
        {"Hipparcos Number", "HIP 89027"},
        {"Smithsonian Astrophysical Observation", "SAO 209800"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.54428627),
        dec: Angle.Degrees(-36.41236728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70742"},
        {"Hipparcos Number", "HIP 41024"},
        {"Smithsonian Astrophysical Observation", "SAO 199138"},
        {"New General Catalogue", "NGC 2579 23"},
    },
    visualMagnitude: 9.51,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.57012357),
        dec: Angle.Degrees(-36.41204543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13779"},
        {"Hipparcos Number", "HIP 10343"},
        {"Smithsonian Astrophysical Observation", "SAO 193579"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.31208644),
        dec: Angle.Degrees(-36.41131689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102098"},
        {"Hipparcos Number", "HIP 57297"},
        {"Geneva Identification System", "GEN# +1.00102098"},
        {"Smithsonian Astrophysical Observation", "SAO 202765"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.22092904),
        dec: Angle.Degrees(-36.40989229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4249"},
        {"Geneva Identification System", "GEN# -0.03700322"},
        {"Smithsonian Astrophysical Observation", "SAO 192807"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.54842877),
        dec: Angle.Degrees(-36.40755525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170368"},
        {"Hipparcos Number", "HIP 90724"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.64879318),
        dec: Angle.Degrees(-36.40661706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67359"},
        {"Hipparcos Number", "HIP 39651"},
        {"Smithsonian Astrophysical Observation", "SAO 198800"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.53805585),
        dec: Angle.Degrees(-36.40636924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151581"},
        {"Hipparcos Number", "HIP 82360"},
        {"Smithsonian Astrophysical Observation", "SAO 208070"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.43553286),
        dec: Angle.Degrees(-36.40615678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89512"},
        {"Hipparcos Number", "HIP 50510"},
        {"Smithsonian Astrophysical Observation", "SAO 201273"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.74594573),
        dec: Angle.Degrees(-36.40522963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76142"},
        {"Smithsonian Astrophysical Observation", "SAO 206751"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.28801804),
        dec: Angle.Degrees(-36.40504371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2367"},
        {"Hipparcos Number", "HIP 2161"},
        {"Geneva Identification System", "GEN# +1.00002367"},
        {"Smithsonian Astrophysical Observation", "SAO 192532"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.81386738),
        dec: Angle.Degrees(-36.40493279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119893"},
        {"Hipparcos Number", "HIP 67241"},
        {"Smithsonian Astrophysical Observation", "SAO 204831"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.69134877),
        dec: Angle.Degrees(-36.40483391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82774"},
        {"Hipparcos Number", "HIP 46877"},
        {"Smithsonian Astrophysical Observation", "SAO 200490"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.29103049),
        dec: Angle.Degrees(-36.40462536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146797"},
        {"Hipparcos Number", "HIP 79983"},
        {"Smithsonian Astrophysical Observation", "SAO 207555"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.89353624),
        dec: Angle.Degrees(-36.40303291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66540"},
        {"Hipparcos Number", "HIP 39353"},
        {"Geneva Identification System", "GEN# +1.00066540"},
        {"Smithsonian Astrophysical Observation", "SAO 198734"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.65634758),
        dec: Angle.Degrees(-36.40124879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55683"},
        {"Smithsonian Astrophysical Observation", "SAO 202410"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.14456028),
        dec: Angle.Degrees(-36.39759716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144370"},
        {"Hipparcos Number", "HIP 78944"},
        {"Geneva Identification System", "GEN# +1.00144370"},
        {"Smithsonian Astrophysical Observation", "SAO 207336"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.74269097),
        dec: Angle.Degrees(-36.39346309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15439"},
    },
    visualMagnitude: 11.84,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.74315380),
        dec: Angle.Degrees(-36.39265929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7200"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.19504995),
        dec: Angle.Degrees(-36.39111643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221200"},
        {"Hipparcos Number", "HIP 115999"},
        {"Smithsonian Astrophysical Observation", "SAO 214585"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.54473256),
        dec: Angle.Degrees(-36.39055165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25946"},
        {"Hipparcos Number", "HIP 19060"},
        {"Smithsonian Astrophysical Observation", "SAO 194749"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.26687301),
        dec: Angle.Degrees(-36.38984290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216666"},
        {"Hipparcos Number", "HIP 113189"},
        {"Fundamental Katalog 5th Edition", "FK5 3831"},
        {"Geneva Identification System", "GEN# +1.00216666"},
        {"Smithsonian Astrophysical Observation", "SAO 214182"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.81196404),
        dec: Angle.Degrees(-36.38858056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41125"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.86912945),
        dec: Angle.Degrees(-36.38759723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51847"},
        {"Smithsonian Astrophysical Observation", "SAO 201540"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.88482735),
        dec: Angle.Degrees(-36.38671486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87748"},
        {"Hipparcos Number", "HIP 49488"},
        {"Smithsonian Astrophysical Observation", "SAO 201052"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.55297636),
        dec: Angle.Degrees(-36.38601506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130731"},
        {"Hipparcos Number", "HIP 72630"},
        {"Geneva Identification System", "GEN# +1.00130731"},
        {"Smithsonian Astrophysical Observation", "SAO 206003"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.75277911),
        dec: Angle.Degrees(-36.38511189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87606"},
        {"Hipparcos Number", "HIP 49418"},
        {"Geneva Identification System", "GEN# +1.00087606"},
        {"Smithsonian Astrophysical Observation", "SAO 201037"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.31368590),
        dec: Angle.Degrees(-36.38435183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119674"},
        {"Hipparcos Number", "HIP 67123"},
        {"Geneva Identification System", "GEN# +1.00119674"},
        {"Renson", "Renson 34510"},
        {"Smithsonian Astrophysical Observation", "SAO 204804"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.35214081),
        dec: Angle.Degrees(-36.38346171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8868"},
        {"Hipparcos Number", "HIP 6742"},
        {"Geneva Identification System", "GEN# +1.00008868"},
        {"Smithsonian Astrophysical Observation", "SAO 193120"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.70281313),
        dec: Angle.Degrees(-36.38247667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67556"},
        {"Hipparcos Number", "HIP 39720"},
        {"Geneva Identification System", "GEN# +1.00067556"},
        {"Smithsonian Astrophysical Observation", "SAO 198815"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.78659519),
        dec: Angle.Degrees(-36.38165721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33891"},
        {"Hipparcos Number", "HIP 24204"},
        {"Smithsonian Astrophysical Observation", "SAO 195642"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.93960287),
        dec: Angle.Degrees(-36.38139929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170997"},
        {"Hipparcos Number", "HIP 91010"},
        {"Geneva Identification System", "GEN# +1.00170997"},
        {"Smithsonian Astrophysical Observation", "SAO 210309"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.48360781),
        dec: Angle.Degrees(-36.38007692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164245"},
        {"Hipparcos Number", "HIP 88294"},
        {"Geneva Identification System", "GEN# +1.00164245"},
        {"Smithsonian Astrophysical Observation", "SAO 209608"},
        {"Wilson Evans Batten Catalogue", "WEB 14922"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.45126566),
        dec: Angle.Degrees(-36.37780307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62447"},
        {"Hipparcos Number", "HIP 37562"},
        {"Celescope Catalog", "CEL 1990"},
        {"Geneva Identification System", "GEN# +1.00062447"},
        {"Smithsonian Astrophysical Observation", "SAO 198331"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.64432047),
        dec: Angle.Degrees(-36.37482189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35470"},
        {"Hipparcos Number", "HIP 25186"},
        {"Smithsonian Astrophysical Observation", "SAO 195798"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.81462068),
        dec: Angle.Degrees(-36.37190764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115050"},
        {"Hipparcos Number", "HIP 64651"},
        {"Geneva Identification System", "GEN# +1.00115050"},
        {"Smithsonian Astrophysical Observation", "SAO 204282"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.78954038),
        dec: Angle.Degrees(-36.37135768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68933",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Menkent"},
        {"Henry Draper", "HD 123139"},
        {"Hipparcos Number", "HIP 68933"},
        {"Cincinnati Publication", "Ci 20 831"},
        {"Fundamental Katalog 5th Edition", "FK5 520"},
        {"Geneva Identification System", "GEN# +1.00123139"},
        {"Smithsonian Astrophysical Observation", "SAO 205188"},
        {"Wilson Evans Batten Catalogue", "WEB 12044"},
    },
    visualMagnitude: 2.06,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.67218608),
        dec: Angle.Degrees(-36.36869575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -519.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -517.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91920"},
        {"Hipparcos Number", "HIP 51901"},
        {"Geneva Identification System", "GEN# +1.00091920"},
        {"Smithsonian Astrophysical Observation", "SAO 201549"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.05482831),
        dec: Angle.Degrees(-36.36700363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79584"},
        {"Hipparcos Number", "HIP 45298"},
        {"Smithsonian Astrophysical Observation", "SAO 200128"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.47639697),
        dec: Angle.Degrees(-36.36492476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64572"},
        {"Hipparcos Number", "HIP 38497"},
        {"Geneva Identification System", "GEN# +1.00064572"},
        {"Smithsonian Astrophysical Observation", "SAO 198553"},
        {"Wilson Evans Batten Catalogue", "WEB 7568"},
    },
    visualMagnitude: 5.44,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.26464297),
        dec: Angle.Degrees(-36.36377387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164389"},
        {"Hipparcos Number", "HIP 88345"},
        {"Geneva Identification System", "GEN# +1.00164389"},
        {"Smithsonian Astrophysical Observation", "SAO 209628"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.62282204),
        dec: Angle.Degrees(-36.36322478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135953"},
        {"Hipparcos Number", "HIP 74959"},
        {"Smithsonian Astrophysical Observation", "SAO 206514"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.77265519),
        dec: Angle.Degrees(-36.36221732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194748"},
        {"Hipparcos Number", "HIP 101009"},
        {"Smithsonian Astrophysical Observation", "SAO 212158"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.18140260),
        dec: Angle.Degrees(-36.36199419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53604"},
        {"Hipparcos Number", "HIP 34071"},
        {"Smithsonian Astrophysical Observation", "SAO 197531"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.99986377),
        dec: Angle.Degrees(-36.36041232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164321"},
        {"Hipparcos Number", "HIP 88312"},
        {"Geneva Identification System", "GEN# +1.00164321"},
        {"Smithsonian Astrophysical Observation", "SAO 209616"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.54112439),
        dec: Angle.Degrees(-36.35923299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194625"},
        {"Hipparcos Number", "HIP 100938"},
        {"Geneva Identification System", "GEN# +1.00194625"},
        {"Smithsonian Astrophysical Observation", "SAO 212143"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.99133669),
        dec: Angle.Degrees(-36.35866528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30928"},
        {"Hipparcos Number", "HIP 22470"},
        {"Smithsonian Astrophysical Observation", "SAO 195338"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.53096415),
        dec: Angle.Degrees(-36.35615919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196497"},
        {"Hipparcos Number", "HIP 101908"},
        {"Smithsonian Astrophysical Observation", "SAO 212313"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.76840770),
        dec: Angle.Degrees(-36.35594691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78455"},
        {"Hipparcos Number", "HIP 44750"},
        {"Renson", "Renson 22220"},
        {"Smithsonian Astrophysical Observation", "SAO 199994"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.79827850),
        dec: Angle.Degrees(-36.35549275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200624"},
        {"Hipparcos Number", "HIP 104120"},
        {"Smithsonian Astrophysical Observation", "SAO 212698"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.40998027),
        dec: Angle.Degrees(-36.35429622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44465"},
        {"Hipparcos Number", "HIP 30121"},
        {"Smithsonian Astrophysical Observation", "SAO 196699"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.07273055),
        dec: Angle.Degrees(-36.35326719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40405"},
        {"Hipparcos Number", "HIP 28136"},
        {"Renson", "Renson 10800"},
        {"Smithsonian Astrophysical Observation", "SAO 196339"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.20304527),
        dec: Angle.Degrees(-36.35127475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110653"},
        {"Hipparcos Number", "HIP 62128"},
        {"Fundamental Katalog 5th Edition", "FK5 3016"},
        {"Geneva Identification System", "GEN# +1.00110653"},
        {"Smithsonian Astrophysical Observation", "SAO 203756"},
    },
    visualMagnitude: 6.38,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.99443237),
        dec: Angle.Degrees(-36.34913468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48038"},
        {"Smithsonian Astrophysical Observation", "SAO 200737"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.89603873),
        dec: Angle.Degrees(-36.34233547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135745"},
        {"Hipparcos Number", "HIP 74864"},
        {"Smithsonian Astrophysical Observation", "SAO 206498"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.48342689),
        dec: Angle.Degrees(-36.34217039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68944"},
        {"Hipparcos Number", "HIP 40255"},
        {"Celescope Catalog", "CEL 2248"},
        {"Geneva Identification System", "GEN# +1.00068944"},
        {"Smithsonian Astrophysical Observation", "SAO 198949"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.32582898),
        dec: Angle.Degrees(-36.34175529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15447"},
        {"Hipparcos Number", "HIP 11496"},
        {"Smithsonian Astrophysical Observation", "SAO 193724"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.06740022),
        dec: Angle.Degrees(-36.34089299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193868"},
        {"Hipparcos Number", "HIP 100585"},
        {"Smithsonian Astrophysical Observation", "SAO 212077"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.96163833),
        dec: Angle.Degrees(-36.34081928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69082"},
        {"Hipparcos Number", "HIP 40324"},
        {"Geneva Identification System", "GEN# +1.00069082"},
        {"Smithsonian Astrophysical Observation", "SAO 198970"},
    },
    visualMagnitude: 6.11,
    bvColour: -0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.49460507),
        dec: Angle.Degrees(-36.34079527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58260"},
        {"Hipparcos Number", "HIP 35830"},
        {"Celescope Catalog", "CEL 1822"},
        {"Geneva Identification System", "GEN# +1.00058260"},
        {"Renson", "Renson 15890"},
        {"Smithsonian Astrophysical Observation", "SAO 197934"},
        {"Wilson Evans Batten Catalogue", "WEB 7139"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.83167331),
        dec: Angle.Degrees(-36.34016723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60606"},
        {"Hipparcos Number", "HIP 36778"},
        {"Celescope Catalog", "CEL 1931"},
        {"Geneva Identification System", "GEN# +1.00060606"},
        {"Smithsonian Astrophysical Observation", "SAO 198130"},
        {"Wilson Evans Batten Catalogue", "WEB 7309"},
    },
    visualMagnitude: 5.42,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.46270622),
        dec: Angle.Degrees(-36.33840157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48187"},
        {"Smithsonian Astrophysical Observation", "SAO 200772"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.34895400),
        dec: Angle.Degrees(-36.33697077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10741"},
        {"Geneva Identification System", "GEN# -0.03600866"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.55847659),
        dec: Angle.Degrees(-36.33677299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106923"},
        {"Hipparcos Number", "HIP 59944"},
        {"Smithsonian Astrophysical Observation", "SAO 203317"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.44226076),
        dec: Angle.Degrees(-36.33401157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27958"},
        {"Hipparcos Number", "HIP 20470"},
        {"Smithsonian Astrophysical Observation", "SAO 194973"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.80932641),
        dec: Angle.Degrees(-36.33296628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185575"},
        {"Hipparcos Number", "HIP 96848"},
        {"Geneva Identification System", "GEN# +1.00185575"},
        {"Smithsonian Astrophysical Observation", "SAO 211474"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.29410151),
        dec: Angle.Degrees(-36.33162347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31200"},
        {"Hipparcos Number", "HIP 22641"},
        {"Geneva Identification System", "GEN# +1.00031200"},
        {"Smithsonian Astrophysical Observation", "SAO 195369"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.06596374),
        dec: Angle.Degrees(-36.32474690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100320"},
        {"Hipparcos Number", "HIP 56292"},
        {"Smithsonian Astrophysical Observation", "SAO 202547"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.09647751),
        dec: Angle.Degrees(-36.32332371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219154"},
        {"Hipparcos Number", "HIP 114694"},
        {"Smithsonian Astrophysical Observation", "SAO 214395"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.50878604),
        dec: Angle.Degrees(-36.32258494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146239"},
        {"Hipparcos Number", "HIP 79758"},
        {"Smithsonian Astrophysical Observation", "SAO 207505"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.18641502),
        dec: Angle.Degrees(-36.32252605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69081"},
        {"Hipparcos Number", "HIP 40321"},
        {"Celescope Catalog", "CEL 2257"},
        {"Geneva Identification System", "GEN# +1.00069081A"},
        {"Smithsonian Astrophysical Observation", "SAO 198969"},
        {"Wilson Evans Batten Catalogue", "WEB 7863"},
    },
    visualMagnitude: 5.09,
    bvColour: -0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.49299197),
        dec: Angle.Degrees(-36.32229977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14004"},
        {"Hipparcos Number", "HIP 10490"},
        {"Smithsonian Astrophysical Observation", "SAO 193604"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.80752367),
        dec: Angle.Degrees(-36.32043801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68962"},
        {"Hipparcos Number", "HIP 40268"},
        {"Geneva Identification System", "GEN# +1.00068962"},
        {"Smithsonian Astrophysical Observation", "SAO 198953"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.34441459),
        dec: Angle.Degrees(-36.31043505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24824"},
        {"Hipparcos Number", "HIP 18357"},
        {"Smithsonian Astrophysical Observation", "SAO 194630"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.87311154),
        dec: Angle.Degrees(-36.31019706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209109"},
        {"Hipparcos Number", "HIP 108747"},
        {"Smithsonian Astrophysical Observation", "SAO 213482"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.43810338),
        dec: Angle.Degrees(-36.30961454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42166"},
        {"Hipparcos Number", "HIP 29031"},
        {"Smithsonian Astrophysical Observation", "SAO 196512"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.87818806),
        dec: Angle.Degrees(-36.30941635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211413"},
        {"Hipparcos Number", "HIP 110061"},
        {"Smithsonian Astrophysical Observation", "SAO 213704"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.38216126),
        dec: Angle.Degrees(-36.30921802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199756"},
        {"Hipparcos Number", "HIP 103668"},
        {"Smithsonian Astrophysical Observation", "SAO 212616"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.06974914),
        dec: Angle.Degrees(-36.30865969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172358"},
        {"Hipparcos Number", "HIP 91639"},
        {"Smithsonian Astrophysical Observation", "SAO 210458"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.32087770),
        dec: Angle.Degrees(-36.30851601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17169"},
        {"Hipparcos Number", "HIP 12778"},
        {"Geneva Identification System", "GEN# +1.00017169"},
        {"Smithsonian Astrophysical Observation", "SAO 193887"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.05399401),
        dec: Angle.Degrees(-36.30741502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159163"},
        {"Hipparcos Number", "HIP 86014"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.68185682),
        dec: Angle.Degrees(-36.30325632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72049",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72049"},
        {"Smithsonian Astrophysical Observation", "SAO 140101"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.06146409),
        dec: Angle.Degrees(-04.31986789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191847"},
        {"Hipparcos Number", "HIP 99642"},
        {"Geneva Identification System", "GEN# +1.00191847"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.33154341),
        dec: Angle.Degrees(-36.30247853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83293"},
        {"Hipparcos Number", "HIP 47147"},
        {"Geneva Identification System", "GEN# +1.00083293"},
        {"Smithsonian Astrophysical Observation", "SAO 200543"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.10716192),
        dec: Angle.Degrees(-36.30174049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101974"},
        {"Hipparcos Number", "HIP 57225"},
        {"Geneva Identification System", "GEN# +1.00101974"},
        {"Smithsonian Astrophysical Observation", "SAO 202756"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.00741075),
        dec: Angle.Degrees(-36.30041789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143116"},
        {"Hipparcos Number", "HIP 78372"},
        {"Geneva Identification System", "GEN# +1.00143116"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.00086192),
        dec: Angle.Degrees(-36.29907844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30558"},
        {"Geneva Identification System", "GEN# +1.00045406"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.35877366),
        dec: Angle.Degrees(-36.29891139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18456"},
        {"Hipparcos Number", "HIP 13735"},
        {"Geneva Identification System", "GEN# +1.00018456"},
        {"Smithsonian Astrophysical Observation", "SAO 193999"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.21813227),
        dec: Angle.Degrees(-36.29734475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142275"},
        {"Hipparcos Number", "HIP 77937"},
        {"Smithsonian Astrophysical Observation", "SAO 207107"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.74853555),
        dec: Angle.Degrees(-36.29593220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183197"},
        {"Hipparcos Number", "HIP 95863"},
        {"Smithsonian Astrophysical Observation", "SAO 211307"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.45838047),
        dec: Angle.Degrees(-36.29554997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216076"},
        {"Hipparcos Number", "HIP 112773"},
        {"Geneva Identification System", "GEN# +1.00216076"},
        {"Smithsonian Astrophysical Observation", "SAO 214123"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.57862224),
        dec: Angle.Degrees(-36.29440471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22621"},
        {"Hipparcos Number", "HIP 16868"},
        {"Smithsonian Astrophysical Observation", "SAO 194404"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.26923986),
        dec: Angle.Degrees(-36.29224569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188738"},
        {"Hipparcos Number", "HIP 98277"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.53054538),
        dec: Angle.Degrees(-36.29170146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221342"},
        {"Hipparcos Number", "HIP 116111"},
        {"Fundamental Katalog 5th Edition", "FK5 6080"},
        {"Geneva Identification System", "GEN# +1.00221342"},
        {"Smithsonian Astrophysical Observation", "SAO 214601"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.89746586),
        dec: Angle.Degrees(-36.29099275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146902"},
        {"Hipparcos Number", "HIP 80025"},
        {"Smithsonian Astrophysical Observation", "SAO 207569"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.03663198),
        dec: Angle.Degrees(-36.28761274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218319"},
        {"Hipparcos Number", "HIP 114181"},
        {"Smithsonian Astrophysical Observation", "SAO 214322"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.84697576),
        dec: Angle.Degrees(-36.28743157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41111"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.82956992),
        dec: Angle.Degrees(-36.28702654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92229"},
        {"Hipparcos Number", "HIP 52071"},
        {"Smithsonian Astrophysical Observation", "SAO 201584"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.60888387),
        dec: Angle.Degrees(-36.28584091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104248"},
        {"Hipparcos Number", "HIP 58542"},
        {"Smithsonian Astrophysical Observation", "SAO 203028"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.07266435),
        dec: Angle.Degrees(-36.28528850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165728"},
        {"Hipparcos Number", "HIP 88920"},
        {"Smithsonian Astrophysical Observation", "SAO 209765"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.25817689),
        dec: Angle.Degrees(-36.28477941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112657"},
        {"Hipparcos Number", "HIP 63331"},
        {"Smithsonian Astrophysical Observation", "SAO 203996"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.67049559),
        dec: Angle.Degrees(-36.27518075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52057"},
        {"Hipparcos Number", "HIP 33535"},
        {"Geneva Identification System", "GEN# +1.00052057"},
        {"Smithsonian Astrophysical Observation", "SAO 197421"},
        {"Wilson Evans Batten Catalogue", "WEB 6744"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.54139045),
        dec: Angle.Degrees(-36.27516755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33740"},
        {"Hipparcos Number", "HIP 24106"},
        {"Renson", "Renson 8610"},
        {"Smithsonian Astrophysical Observation", "SAO 195621"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.67445348),
        dec: Angle.Degrees(-36.27475644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2833"},
        {"Hipparcos Number", "HIP 2486"},
        {"Smithsonian Astrophysical Observation", "SAO 192587"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.88950200),
        dec: Angle.Degrees(-36.27373127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163275"},
        {"Hipparcos Number", "HIP 87870"},
        {"Smithsonian Astrophysical Observation", "SAO 209505"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.24481359),
        dec: Angle.Degrees(-36.27258560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127692"},
        {"Hipparcos Number", "HIP 71203"},
        {"Fundamental Katalog 5th Edition", "FK5 5289"},
        {"Smithsonian Astrophysical Observation", "SAO 205694"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.42737744),
        dec: Angle.Degrees(-36.26935938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85296"},
        {"Hipparcos Number", "HIP 48219"},
        {"Geneva Identification System", "GEN# +1.00085296"},
        {"Smithsonian Astrophysical Observation", "SAO 200784"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.46400531),
        dec: Angle.Degrees(-36.26847322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
