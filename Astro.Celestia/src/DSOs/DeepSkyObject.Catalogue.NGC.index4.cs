using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class DeepSkyObjectCatalogue {
private static void _addNGC_4() {
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 370",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3791",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3791"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)39.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1064",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1064"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3854",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3865"},
        {"New General Catalogue 2", "NGC 3854"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)44.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 988",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 988"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3771",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3771"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3866",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3866"},
        {"New General Catalogue 2", "NGC 3858"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1504",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1504"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)02.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 853",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 853"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)11.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1505",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1505"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 960",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 960"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3858",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3866"},
        {"New General Catalogue 2", "NGC 3858"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1404",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)50.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7399",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7399"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)52.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4675",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 649",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 649"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3865",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3865"},
        {"New General Catalogue 2", "NGC 3854"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 647",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 647"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)39.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1450",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1450"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)45.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4776",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4759"},
        {"New General Catalogue 2", "NGC 4776"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 195",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 195"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 481",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 481"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4778",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4761"},
        {"New General Catalogue 2", "NGC 4778"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7526",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)13.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 341",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 341"},
        {"New General Catalogue 2", "NGC 341A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4759",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4759"},
        {"New General Catalogue 2", "NGC 4776"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4761",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4761"},
        {"New General Catalogue 2", "NGC 4778"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4764",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4764"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3688",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3688"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1779",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1779"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1185",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1185"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 402",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)06.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4176",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4176"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)12.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1147",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)55.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4703",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4703"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3859",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 713",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 713"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 755",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 755"},
        {"New General Catalogue 2", "NGC 763"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)56.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1324",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 22",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5729",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5729"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)42.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180324"},
        {"Wilson Evans Batten Catalogue", "WEB 16522"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4129",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4129"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6865",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6865"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)06.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1563",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 191A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)39.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 731",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 731"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)54.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1470",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1470"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3634",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3634"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)20.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3635",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3635"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)20.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 191",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 191"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)39.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 787",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 787"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3826",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1464",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 763",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 755"},
        {"New General Catalogue 2", "NGC 763"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)57.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1447",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1447"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3774",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3774"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 879",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 879"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6517",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6517"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1243",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)11.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2574",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2574"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)20.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6728",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6728"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)00.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 757",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)56.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1241",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1241"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1242",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1242"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1516",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1516"},
        {"New General Catalogue 2", "NGC 1516B"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)08.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3702",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3702"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1467",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1467"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)51.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1206",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1206"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)06.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1295",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7122",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1033",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1033"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1524",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)10.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1525",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)10.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5203",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5203"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 985",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 985"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1133",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1133"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)52.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4777",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4777"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7051",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7051"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)19.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1449",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1071",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1071"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2589",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 291",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 291"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)53.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 352",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)47.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 809",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 809"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 905",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 905"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6712",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6712"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1237",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3660",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3660"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4699",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4699"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 270",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 270"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)50.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 159",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)46.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4674",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4674"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)46.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4773",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4773"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2349",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2349"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)10.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2969",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2969"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)41.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3703",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3703"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4780",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4780"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5973",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5973"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)40.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1636",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1636"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)40.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 277",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 277"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1472",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1472"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)53.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1477",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1477"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)54.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1614",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1614"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)34.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1822",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1478",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1478"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1048",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1048"},
        {"New General Catalogue 2", "NGC 1048B"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)40.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1646",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1646"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)44.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 168",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)50.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 170",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)52.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4818",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4818"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 707",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 707"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)51.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5232",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5232"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)36.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1648",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1648"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)44.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3142",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3142"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)10.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7606",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7606"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1042",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1042"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4739",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4739"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 157",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 157"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5241",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5241"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1337",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1337"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1927",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 715",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 721",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5062",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 156",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 624",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 690",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2323",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 50"},
        {"New General Catalogue", "NGC 2323"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 5.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 16.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6968",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6968"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)48.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 158",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 723",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1069",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1069"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)42.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 747",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 107",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 107"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)25.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 734",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)46.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4433",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4433"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1052",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1052"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1752",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1752"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1082",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1082"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6664",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6664"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 16.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)36.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 733",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)46.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4428",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4428"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1047",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1047"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)40.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3883",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1577",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)44.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1035",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1035"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1909",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "the Witch Head Nebula"},
        {"New General Catalogue", "NGC 1909"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 828",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5167",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)07.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5278",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1475",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7211",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7211"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3638",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3638"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)20.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 814",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 421",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4928",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4928"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 899",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3029",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3029"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)48.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4487",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4487"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1797",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1797"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)07.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4958",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4958"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-08, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 90",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1108",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1108"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1799",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1799"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)07.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2313",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2313"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4948",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4948"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5339",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5339"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)53.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 48",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)43.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1720",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1720"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1110",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1110"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1234",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1234"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)09.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 384",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)39.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3967",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3967"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)55.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4995",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4995"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)09.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 829",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 829"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)08.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1152",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1152"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)57.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 398",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 830",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 830"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)09.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2317",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2316",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2316"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)59.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 842",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 842"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)09.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1726",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1726"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3959",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3959"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3115",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Spindle Galaxy"},
        {"New General Catalogue", "NGC 3115"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 116",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 116"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1148",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1148"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4925",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4925"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4403",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4403"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4404",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4404"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1286",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1286"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4942",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4942"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)04.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4627",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 337",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 337"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)59.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1084",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1084"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)46.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3908",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4071",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6539",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6539"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)04.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7600",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7600"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2364",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2364"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)20.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4504",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4504"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5343",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5343"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)54.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 636",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 636"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)39.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3481",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3481"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1409",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)53.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2110",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2110"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5812",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5812"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1084",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)01.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1533",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)10.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 607",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)34.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1303",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1303"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)20.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5534",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5534"},
        {"New General Catalogue 2", "NGC 5534A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 799",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4520"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4520",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4520"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1458",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)56.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5917",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5917"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 297",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 297"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)55.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 298",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 298"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)55.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 980",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 50",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 50"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 615",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 615"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1285",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1285"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 600",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 600"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 388",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)42.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 389",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)42.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2215",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2215"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 379",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 293",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 293"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)54.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 390",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2118",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "the Witch Head Nebula"},
        {"New General Catalogue", "NGC 1909"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 180.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1060",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)51.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2309",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2309"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5306",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5306"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1276",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 47",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 47"},
        {"New General Catalogue 2", "NGC 58"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)14.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2306",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2306"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 58",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 47"},
        {"New General Catalogue 2", "NGC 58"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)14.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 630",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)38.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4209",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 991",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 991"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1521",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 54",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 54"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)15.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 385",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1257",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 387",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)41.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 430",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)38.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 275",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 275"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 209",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)09.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2302",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2302"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)51.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4671",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4671"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7441",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7441"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 274",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 274"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 325",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 429",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)38.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 631",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)39.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 596",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 596"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)32.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 206",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)07.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4626",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4626"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 626",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)37.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 356",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 356"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)03.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2299",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7065",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7065"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-07, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 127",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)29.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 207",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)07.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4212",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)12.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 574",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 68",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4628",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4628"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 158",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1051",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1051"},
        {"New General Catalogue 2", "NGC 961"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 249",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1051"},
        {"New General Catalogue 2", "NGC 961"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 550",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)40.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1477",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 67",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 219",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)18.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 242",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)38.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 243",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)38.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 586",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7596",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7596"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 345",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 345"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 586",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 586"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 961",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1051"},
        {"New General Catalogue 2", "NGC 961"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 597",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)10.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 273",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 273"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 340",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 340"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 584",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 584"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1712",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 584"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)31.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4786",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4786"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 64",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 64"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)17.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 575",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 184",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2471",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)25.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4885",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4885"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6821",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6821"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 347",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 347"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 349",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 349"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 350",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 350"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 788",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 788"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)01.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3035",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3035"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)51.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4813",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4813"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 342",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 342"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 71",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)01.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 215",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)14.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4981",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4981"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7108",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7108"},
        {"New General Catalogue 2", "NGC 7111"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 72",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)01.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 774",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 883",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 883"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 833",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 337",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2876",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2876"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)25.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7111",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7108"},
        {"New General Catalogue 2", "NGC 7111"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)41.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1999",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1999"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 16.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3812",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1080",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)58.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1022",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1022"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)38.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 427",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4775",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4775"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7406",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7406"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)54.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 881",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 881"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)18.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1666",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1666"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)48.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7120",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7120"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3122",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3110"},
        {"New General Catalogue 2", "NGC 3518"},
        {"New General Catalogue 3", "NGC 3122"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 428",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7721",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7721"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)38.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4951",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4951"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 286",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)04.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1202",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1202"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3110",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3110"},
        {"New General Catalogue 2", "NGC 3518"},
        {"New General Catalogue 3", "NGC 3122"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)04.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3518",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3110"},
        {"New General Catalogue 2", "NGC 3518"},
        {"New General Catalogue 3", "NGC 3122"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)04.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3007",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3007"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)47.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6059",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2170",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mon R2 IRS3"},
        {"New General Catalogue", "NGC 2170"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)07.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4731",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4731"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4589",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1423",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1423"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3064",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3064"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)55.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1468",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1468"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7453",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 355",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 355"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 357",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 357"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1689",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1667"},
        {"New General Catalogue 2", "NGC 1689"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)53.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2182",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2182"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)09.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1667",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1667"},
        {"New General Catalogue 2", "NGC 1689"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1299",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1299"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)20.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 394",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)48.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6683",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6683"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 659",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)58.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4156",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4948"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6705",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Amas de l'Ecu de Sobieski"},
        {"Common Name 2", "Wild Duck Cluster"},
        {"Messier Catalogue", "M 11"},
        {"New General Catalogue", "NGC 6705"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 5.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 14.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1361",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1361"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2101",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)51.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 61",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 61"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2183",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2183"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)10.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2185",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2185"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)11.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2167",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3292",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3292"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3818",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3818"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4878",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4878"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5476",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5476"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)08.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4888",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4888"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5426",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5426"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 645",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4879",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4879"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5324",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5324"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 608",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5427",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5427"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5428",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5429",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177656"},
        {"Wilson Evans Batten Catalogue", "WEB 16300"},
        {"New General Catalogue", "NGC 6751"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-06, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4407",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5634",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5634"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6655",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 779",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 779"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)59.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4136",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4942"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7491",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7491"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)08.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5432",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1980",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Lower Sword"},
        {"New General Catalogue", "NGC 1980"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 14.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5435",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2489",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6973",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1420",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 865",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1681",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1681"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)51.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4422",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4422"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6980",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1594",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1594"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2075",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1594"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2548",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 48"},
        {"New General Catalogue", "NGC 2548"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 5.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 54.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)13.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4597",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4597"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4697",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4697"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2975",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)54.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6975",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6976"},
        {"New General Catalogue 2", "NGC 6975"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6976",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6976"},
        {"New General Catalogue 2", "NGC 6975"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1324",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1324"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2080",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1376",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6977",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6977"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6978",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6978"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 589",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 603",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5050",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 599",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)13.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2031",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2338",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2338"},
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)07.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1372",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)20.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 38",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 38"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)11.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7692",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7692"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3679",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3679"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1063",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1063"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1346",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1346"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4941",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4941"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7393",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7393"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)51.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1457",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)55.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5465",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 895",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 894"},
        {"New General Catalogue 2", "NGC 895"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 974",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)06.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4768",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)41.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 894",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 894"},
        {"New General Catalogue 2", "NGC 895"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7416",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7416"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5369",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5369"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)56.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5467",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 973",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1041",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1041"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)40.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5472",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5472"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1976",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Great Orion Nebula"},
        {"Common Name 2", "Ori Nebula"},
        {"Common Name 3", "Orion Nebula"},
        {"Messier Catalogue", "M 42"},
        {"New General Catalogue", "NGC 1976"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 4.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 66.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5468",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5468"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)06.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7170",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7170"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 762",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 762"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1645",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1645"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2098",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)50.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 553",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)40.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1665",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1665"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4989",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4989"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 790",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 790"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)01.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 825",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3709",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 183",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1604",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1604"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2094",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)48.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5126",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4593",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4593"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1924",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1924"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)27.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1643",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1643"},
        {"New General Catalogue 2", "NGC 1643A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)43.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4718",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4718"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1982",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mairan's Nebula"},
        {"Messier Catalogue", "M 43"},
        {"New General Catalogue", "NGC 1982"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4990",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Cocoon Galaxy"},
        {"New General Catalogue", "NGC 4990"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1248",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1248"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 268",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 268"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4705",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4705"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6704",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6704"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)50.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1580",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1580"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 106",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 106"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 145",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 145"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)31.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3022",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3022"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)49.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2974",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)53.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4604",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4604"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1447",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)30.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 325",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 325"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 327",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 327"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1656",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1656"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2095",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)48.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3915",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3915"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4602",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4602"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 333",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)34.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2963",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1603",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1603"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1601",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1601"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2700",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1358",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1358"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1600",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1600"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2097",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1104",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6366",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6366"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7239",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7239"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)14.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 329",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 329"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1376",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1376"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5493",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5493"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)11.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 321",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 321"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)57.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1606",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1606"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)32.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2250",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2250"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 372",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2583",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2583"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 804",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4975",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4975"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)08.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6945",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6945"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)38.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 118",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)27.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1355",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1355"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)33.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1626",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1621"},
        {"New General Catalogue 2", "NGC 1626"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)37.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2584",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2584"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 693",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5189",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1498",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)32.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-05, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 116",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2096",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)49.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2696",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1621",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1621"},
        {"New General Catalogue 2", "NGC 1626"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2102",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)51.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5344",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)39.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2092",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)46.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2585",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2585"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)23.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2586",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2586"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)24.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 702",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5877",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7663",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7663"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2850",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2850"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2099",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1677"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 657",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1371",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)20.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1397",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 373",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1677",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1677"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1700",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1700"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1977",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "ONC Flank N"},
        {"Common Name 2", "the Running Man Nebula"},
        {"New General Catalogue", "NGC 1977"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5340",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1627",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1627"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1619",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2100",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)51.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 741",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)50.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1659",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1659"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)46.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2721",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2721"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6682",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6682"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)41.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1699",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1699"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2232",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2232"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 3.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1418",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1418"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)42.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1424",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1424"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1757",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1973",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1973"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2817",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2817"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)17.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3014",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3014"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)49.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7576",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7576"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)17.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1080",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1080"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1429",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1417",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1417"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)42.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1610",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1610"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)34.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1628",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1628"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2078",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2091",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)46.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1975",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1975"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2219",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2219"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)23.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 738",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)48.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1397",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1397"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 100",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 344",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1694",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1694"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)55.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 784",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7585",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7585"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6941",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6941"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1304",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1304"},
        {"New General Catalogue 2", "NGC 1307"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1599",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1599"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2311",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2311"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)57.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4678",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4678"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)46.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 824",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4890",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4890"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1307",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1304"},
        {"New General Catalogue 2", "NGC 1307"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 770",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)13.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4915",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4915"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 76",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)08.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7725",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7725"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)39.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4401",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5334",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 420",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4918",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4918"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 855",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)10.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 748",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 748"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)56.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 998",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1115",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)22.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1607",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1607"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)32.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 997",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)19.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7351",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7351"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1981",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Upper Sword"},
        {"New General Catalogue", "NGC 1981"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 4.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 25.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 812",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7592",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7592"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1886",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)08.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3807",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 886",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1609",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1609"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 466",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)08.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5015",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5015"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)12.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 908",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 399",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.5,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 347",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)42.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1611",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1611"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)33.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1741",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1741"},
        {"New General Catalogue 2", "NGC 1741A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)01.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 352",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 352"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1221",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1221"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)08.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1613",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1613"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)33.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 541",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)30.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 963",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 963"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)30.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1808",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 963"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)30.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 880",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 880"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1314",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1314"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5036",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5036"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 969",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7666",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1612",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1612"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5039",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5039"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)14.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 981",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)10.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7344",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7344"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1575",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)43.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1223",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1223"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)08.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1524",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1328",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1328"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)25.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1449",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1449"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)46.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1490",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2642",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2642"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)40.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4720",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4720"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7260",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7260"},
        {"New General Catalogue 2", "NGC 7257"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1225",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1225"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1441",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1441"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6254",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 10"},
        {"New General Catalogue", "NGC 6254"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1446",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1446"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)46.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1451",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1451"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)46.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7266",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7266"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 702",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 702"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)51.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2617",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2617"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5133",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5133"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)24.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1443",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7257",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7260"},
        {"New General Catalogue 2", "NGC 7257"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 533",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3952",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3952"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)53.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4130",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2972",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3952"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)53.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1453",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1453"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)46.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 562",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)46.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 164",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2969",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)52.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5089",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4546",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4546"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 239",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 239"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)44.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2733",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2722"},
        {"New General Catalogue 2", "NGC 2733"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5386",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7832"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2722",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2722"},
        {"New General Catalogue 2", "NGC 2733"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7832",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7832"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)06.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2974",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2974"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1119",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)25.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1576",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1576"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)26.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2652",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)43.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4843",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4843"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7121",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7121"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6863",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6863"},
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)05.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1505",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)41.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2184",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2184"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)10.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1705",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 600",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 614",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)26.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4348",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4348"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2425",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2727",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2708"},
        {"New General Catalogue 2", "NGC 2727"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)01.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2708",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2708"},
        {"New General Catalogue 2", "NGC 2727"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 627",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)37.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1729",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1729"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)00.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1753",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1753"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)02.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1788",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1788"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3776",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3776"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)38.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4691",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4691"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1625",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1625"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1742",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1740",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1740"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2703",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 6",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2709",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2709"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159974"},
        {"Messier Catalogue", "M 14"},
        {"New General Catalogue", "NGC 6402"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)37.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4347",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 985",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)11.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 8",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3708",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5506",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5506"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)13.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5604",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5604"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1467",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5392",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5392"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1622",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1622"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2698",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2698"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1468",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2286",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2286"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)47.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1618",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1618"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2699",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2699"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5507",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5507"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)13.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1501",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1528",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)05.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 758",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 758"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)56.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1682",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1682"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1684",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1684"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1413",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)58.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2695",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2695"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6915",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6915"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2707",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2702",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1492",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1320",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1320"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)24.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1683",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1683"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1321",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1321"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)24.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2697",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2697"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2705",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)56.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3092",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3092"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 977",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)08.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-03, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3101",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3101"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1222",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1222"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)08.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3086",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3086"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)00.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 978",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)09.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 958",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 958"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1685",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1685"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3090",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3090"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3093",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3093"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 968",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1496",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7700",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7700"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1322",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1322"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7699",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7699"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)34.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1410",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)56.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7710",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7710"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3083",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3083"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5330",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1557",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1637",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1637"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5400",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5400"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7288",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7288"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7701",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7701"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 161",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 161"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 413",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 413"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)09.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3017",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3017"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1253",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1253"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1323",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1323"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5937",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5937"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 259",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 259"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)48.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1466",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)03.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1287",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1287"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)18.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1308",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1308"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)22.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7530",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7530"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)14.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1670",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1670"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)49.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 331",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 331"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2093",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)47.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2976",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3979"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4684",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4684"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 892",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1403",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)50.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7695",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7695"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)33.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3979",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3979"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6772",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6772"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)14.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7532",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7532"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)14.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7694",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7694"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)33.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 12",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)20.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7534",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7534"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)14.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 111",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 111"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1678",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1678"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)51.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3243",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3243"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2690",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2690"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)52.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 893",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2706",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2706"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5913",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5913"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6900",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6900"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 539",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1908",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2615",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2615"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 593",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)08.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5768",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5768"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1239",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1239"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4224",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 113",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 113"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2917",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2917"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)34.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 592",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)07.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1653",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1653"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1266",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1266"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)16.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 434",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 60.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)41.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 587",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4229",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4079",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4079"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)04.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7554",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7554"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1870",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7566",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7566"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7556",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7556"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)15.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1305",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1305"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 435",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5356",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)47.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7546",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7546"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)15.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5351",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5357",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)47.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 54",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5095",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5095"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)20.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6118",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6118"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5359",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)47.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4218",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)17.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5618",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5618"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5352",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)47.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2023",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2023"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)41.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 609",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)25.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 279",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 279"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5327",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5327"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7182",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7182"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7544",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7544"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)15.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 29",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1507",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1507"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)04.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6922",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6922"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)29.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 510",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)32.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7506",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7506"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)11.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 32",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)35.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 33",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 651",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6033",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6033"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7517",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7517"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)13.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 205",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1298",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1298"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1654",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1654"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 30",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)34.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4006",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4006"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2983",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4006"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1657",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1657"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)46.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 517",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 119",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)27.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1661",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1661"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)47.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 514",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6929",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6929"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)33.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5090",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)11.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 176",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 216",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6926",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6926"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7533",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7533"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)14.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 580",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 577"},
        {"New General Catalogue 2", "NGC 580"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-02, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 126",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)29.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 577",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 577"},
        {"New General Catalogue 2", "NGC 580"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1289",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1289"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 558",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 558"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 314",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1289"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7181",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7181"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6218",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 12"},
        {"New General Catalogue", "NGC 6218"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 14.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)47.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 353",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 353"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 124",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)29.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 680",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4454",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4454"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 351",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 351"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 560",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 560"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 120",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 515",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 271",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 271"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 564",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 564"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 117",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 516",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 525",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)01.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1390",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)32.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1037",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1037"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)38.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2024",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2024"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)41.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2616",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2616"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 124",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 124"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1638",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1638"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)41.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 114",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 114"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 118",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 118"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 308",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 308"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)56.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5192",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5192"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)30.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 307",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 307"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)56.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 310",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7524",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7524"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)13.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 245",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 245"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)46.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1121",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1121"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5183",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5183"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7521",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7521"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)13.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5197",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5197"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5202",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5202"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)32.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5478",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5478"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)08.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 81",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)09.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5184",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5184"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)30.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7746",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7746"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 725",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1693",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 122",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 519",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 519"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1703",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 557"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 557",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 557"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 754",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4690",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4690"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1125",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7069",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7069"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 448",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 448"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1696",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 697",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5196",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5196"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)31.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1298",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)18.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 123",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 728",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180871"},
        {"Geneva Identification System", "GEN# +1.00180871"},
        {"Wilson Evans Batten Catalogue", "WEB 16559"},
        {"New General Catalogue", "NGC 6778"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 530",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 530"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 106",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 530"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 538",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 538"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 186",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1128",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)37.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1136",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)47.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 227",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 227"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 120",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 120"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 185",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)00.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1213",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6172"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)22.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1411",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7391",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7391"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)50.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 850",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 850"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)11.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 432",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)40.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6172",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6172"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)32.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2260",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2260"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 104",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 431",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)40.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 535",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 535"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)25.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5345",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5345"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)54.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 541",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 541"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)25.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 204",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1384",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 547",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 547"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)26.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4629",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4629"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1387",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 545",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 545"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)26.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1015",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1015"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 543",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 543"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 565",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 565"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1126",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1126"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3047",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3047"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1409",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1409"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1410",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1410"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7693",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7693"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)33.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1132",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1132"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)52.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 548",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 548"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)26.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1990",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1990"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 50.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4753",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4753"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1446",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1381",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)27.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7434",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7434"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 936",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 936"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)27.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 941",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 941"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 976",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)08.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5496",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5496"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)11.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4338",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5334"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)52.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 955",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 955"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)30.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5334",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5334"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)52.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3662",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3662"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4030",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4030"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6785",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1194",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1194"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5792",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5792"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1383",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)27.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3907",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3907"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4202",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4202"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1385",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)28.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 535",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5211",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5211"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7428",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7428"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 442",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 442"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)14.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4355",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4355"},
        {"New General Catalogue 2", "NGC 4418"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-01, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1515",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 570",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 570"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 849",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)07.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5651",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 585",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 585"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)31.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6775",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6775"},
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1516",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 497",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 497"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)22.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 450",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 450"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1059",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)50.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 364",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 364"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)04.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4418",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4355"},
        {"New General Catalogue 2", "NGC 4418"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 850",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)07.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7047",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7047"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205146"},
        {"Messier Catalogue", "M 2"},
        {"New General Catalogue", "NGC 7089"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293373"},
        {"Hipparcos Number", "HIP 34541"},
        {"New General Catalogue", "NGC 2346"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1211",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1211"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 863",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 863"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)14.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 866",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)14.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 885",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 885"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)14.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1856",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)48.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1671",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1671"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 359",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 359"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1568",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1568"},
        {"New General Catalogue 2", "NGC 1568B"},
        {"New General Catalogue 3", "NGC 1568E"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)24.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 856",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 856"},
        {"New General Catalogue 2", "NGC 859"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 859",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 856"},
        {"New General Catalogue 2", "NGC 859"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)13.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 868",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 868"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)16.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5705",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5705"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)39.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 138",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)33.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1552",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1552"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)20.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 487",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2494"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 594",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)08.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1639",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)11.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4642",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4642"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7198",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7198"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2494",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2494"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1388",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)29.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1640",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)11.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 423",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)33.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2590",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2590"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)25.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4653",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4653"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 371",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)30.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1635",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1635"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 653",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4592",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4592"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4668",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4668"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1781",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1087",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1087"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)46.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1713",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1713"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 753",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1391",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1757",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1709",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1709"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 85",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)11.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1756",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4666",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4666"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6735",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6735"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 507",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)25.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6741",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Phantom Streak Nebula"},
        {"Aitken", "ADS 11967 AB"},
        {"Henry Draper", "HD 176946"},
        {"Wilson Evans Batten Catalogue", "WEB 16233"},
        {"New General Catalogue", "NGC 6741"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)27, 0)
    )
)
);
}
}

}
