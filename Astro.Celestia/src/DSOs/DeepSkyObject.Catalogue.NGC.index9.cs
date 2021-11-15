using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class DeepSkyObjectCatalogue {
private static void _addNGC_9() {
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4455",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4455"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3679",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3926",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3248",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3248"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3817",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2442",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)10.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3971",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4124",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)03.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4172",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2441",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)10.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6658",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6658"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4054",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4055",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4160",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)04.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4639",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)02.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6641",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6641"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)28.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1809",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5012",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5012"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)11.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4632",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)58.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6660",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6660"},
        {"New General Catalogue 2", "NGC 6661"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6661",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6660"},
        {"New General Catalogue 2", "NGC 6661"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3437",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3437"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)52.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3659",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4053",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5285",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1806",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1807",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)30.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2885",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2885"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6267",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6267"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+22, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3744",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3744"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3761",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3761"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5092",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5092"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)19.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7489",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7489"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 538",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2885"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1239",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6278",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6278"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1544",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2474",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3734",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5258",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1585",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2269",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)18.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 813",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6277",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6276"},
        {"New General Catalogue 2", "NGC 6277"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2376",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2376"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6482",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6482"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)51.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6830",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6830"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7053",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7053"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)21.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1583",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)47.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3953",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1238",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 846",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1802",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6276",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6276"},
        {"New General Catalogue 2", "NGC 6277"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1497",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1497"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2248",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4003",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4003"},
        {"New General Catalogue 2", "NGC 4007"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1803",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2929",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2929"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)37.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4057",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1804",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 905",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 913",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5637",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5637"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)28.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2930",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2930"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 744",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 914",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)41.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4002",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4002"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 933",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4532",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)04.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6315",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6315"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2931",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2931"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)37.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 911",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)41.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 912",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)41.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 444",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6314",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6314"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 910",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6820",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6820"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 40.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)43.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2129",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2129"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3272",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 795",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6823",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6823"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)43.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4475",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5829",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5829"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6243",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6243"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5231",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)34.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2357",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2357"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 906",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4526",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4076",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6308",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6308"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)12.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5243",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)41.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2512",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2512"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)03.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3615",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3615"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3951",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3951"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)53.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4531",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5242",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 354",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)53.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3662",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 984",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 984"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4474",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2255",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2452",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)15.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 336",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)38.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 477",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2554",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2554"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4554",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 229",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 229"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2451",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3618",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3618"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5581",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5581"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)21.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4553",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)35.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1127",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6628",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6628"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 228",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 228"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)42.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3359",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2261",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3671",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 190",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7677",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7677"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 189",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2628",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2628"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)40.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3429",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4495",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)44.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2259",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)17.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4154",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)04.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6233",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6233"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)50.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6659",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6659"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2258",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)17.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2263",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2927",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2927"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)37.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3075",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3312",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3314",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7673",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7673"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)27.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7712",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7712"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 180",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)00.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 776",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 776"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2250",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4517",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1124",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)30.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1750",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1750"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)03.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2257",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2896",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2896"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)30.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 181",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)00.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3428",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4492"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3962",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4594",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6417",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6417"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)41.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6619",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6619"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7539",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7539"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)14.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4576",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1540",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)19.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2264",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4019",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6623",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6623"},
        {"New General Catalogue 2", "NGC 6623N"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3286",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6201",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6201"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)40.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1758",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1758"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2481",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2481"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2288",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3326",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4579",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)42.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6203",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6203"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1435",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Merope Nebula"},
        {"New General Catalogue", "NGC 1435"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)46.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2370",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2370"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2480",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2480"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)57.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3595",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3944",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1006",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)23.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4577",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7339",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7339"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)37.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4573",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4575",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)42.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7332",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7332"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)37.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 9",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 9"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)08.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1746",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1746"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 42.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)03.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 739",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)50.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3089",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4583",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)46.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151121"},
        {"Wilson Evans Batten Catalogue", "WEB 13838"},
        {"New General Catalogue", "NGC 6210"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)44.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 8",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 8"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2246",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)16.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3082",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2144",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2239",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3213",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3597",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)37.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3983",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3983"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)56.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1674",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1675",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3216",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3216"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3084",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3325",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 349",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Barnard's Merope Nebula"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)46.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3095",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6051",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6051"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4588",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6051"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 160",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 160"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2251",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3670",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3670"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 772",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3067",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6075",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6075"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)11.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 162",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 162"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2198",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)34.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2243",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3541",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 916",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 916"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)25.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 169",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 169"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1559",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 169A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4213",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4213"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3539",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+23, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2157",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 509",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)32.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 941",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)48.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7574",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4096",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)02.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3958",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2236",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3948",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2235",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3327",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3327"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3701",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3701"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3227",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3570",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4099",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)02.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6148",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6148"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)27.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1802",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1802"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)10.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2158",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2158"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)07.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5016",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5016"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)12.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 304",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 304"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3765",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3765"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4162",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4162"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)11.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2241",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)15.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2242",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)15.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3619",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2156",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)04.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 481",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2256",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3141",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2247",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2265",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7620",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7620"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)20.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3475",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3475"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3204",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3653",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3653"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2575",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2575"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)22.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2191",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)30.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3651",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3651"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3145",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2759",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 280",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 280"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)52.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2168",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 35"},
        {"New General Catalogue", "NGC 2168"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 5.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 28.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)08.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3228",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3207",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1432",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Maia Nebula"},
        {"New General Catalogue", "NGC 1432"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3125",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3345",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3296",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3424",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3581",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2551",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1941",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2218",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)01.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3232",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2465",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3728",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3728"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2240",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 916",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2398",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2398"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)30.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 909",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)40.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7568",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7568"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)16.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2249",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6484",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6484"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)51.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2271",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2466",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)23.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2245",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 501",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2244",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1764",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4607",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)30.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3411",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 854",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)09.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2569",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3287",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 860",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)15.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5610",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5610"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1990",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)47.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5991",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5991"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3403",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2567",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)22.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5509",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5509"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)12.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5508",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5508"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)12.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2238",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2260",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)17.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3186",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2237",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3119",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2252",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4202",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)08.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3098",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3098"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)02.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3798",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3798"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)40.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2267",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3472",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2254",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2283",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2268",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2282",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5559",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5559"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3814",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3814"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3815",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3815"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)41.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3231",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3390",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4979",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4979"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)07.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4198",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4979"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)07.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3270",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3270"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3812",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3812"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3285",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 765",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 765"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 497",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)10.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5347",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 544",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6513",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6513"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7527",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7527"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2215",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2622",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2622"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)38.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3344",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3344"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3184",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3377",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6599",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6599"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)15.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7698",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7698"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)34.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2620",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2620"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 545",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3911",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3911"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3920",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3920"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)50.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3164",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3288",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5346",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)41.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2498",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2498"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2621",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2621"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)37.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2743",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2743"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4023",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4023"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5297",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)16.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2611",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2611"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3395",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4344",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)55.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6600",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6602",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6602"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4015",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4015"},
        {"New General Catalogue 2", "NGC 4015A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3396",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3739",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3739"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4345",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)55.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7664",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7664"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3116",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3384",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1272",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 493",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4021",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4021"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4343",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)55.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1285",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5296",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 508",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 536",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)24.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4011",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4011"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4342",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1273",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5295",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2487",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2487"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4005",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4005"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4007",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4003"},
        {"New General Catalogue 2", "NGC 4007"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3194",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5548",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5548"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6800",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6800"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5293",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2486",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2486"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4000",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4000"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3999",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3999"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4331",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)49.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4346",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4349",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)55.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2536",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2536"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4332",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)49.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4348",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1314",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2535",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2535"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)11.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3987",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3987"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4009",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4009"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3122",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6547",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6547"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)05.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1156",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1156"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)59.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3989",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3989"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4022",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4022"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4373",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)05.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3993",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3993"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3997",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3997"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7548",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7548"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)15.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3216",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3221",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3332",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3372",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3144",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3323",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3323"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3337",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5523",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5523"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4556",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2753",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2753"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4018",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4018"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 482",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3317",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5659",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5659"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)31.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4558",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4559",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6429",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6429"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3507",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4420",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)25.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5315",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5008",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5008"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4322",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6674",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6674"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1508",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1508"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)05.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3479",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4215",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3304",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4561",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6581",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6581"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2750",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2750"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)05.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3185",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3189",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3385",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3630",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4287",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4697",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)12.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2450",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3197",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3249",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3373",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5677",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5677"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4712",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4712"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1861",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)53.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 353",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 180.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)55.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3209",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3209"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)20.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3497",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4381",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5008"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6427",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6427"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)43.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 214",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 214"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4725",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4725"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4382",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)11.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6431",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)44.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3176",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4228",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4418",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)25.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6697",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6697"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3171",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6428",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3248",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5298",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4101",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4101"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3264",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3277",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3364",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3439",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1995",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3154",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4521",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4524",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3294",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3348",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 360",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 180.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)13.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3250",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4525",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)02.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3251",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3689",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3689"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3282",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1280",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6581"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)12.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2230",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)10.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3526",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3626",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7718",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7718"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3399",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3529",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5498",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5498"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3146",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3201",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6921",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6921"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2087",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "IC 2087 IR"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2576",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2576"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3397",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3535",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2623",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2623"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 762",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6904",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6904"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 780",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3533",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5233",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4494",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4494"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3455",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4747",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4747"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 490",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)03.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3195",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3469",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1996",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1996"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)38.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2386",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 763",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3276",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 26",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 26"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 961",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)55.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1013",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5629",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5629"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7224",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7224"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)11.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 710",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4562",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4562"},
        {"New General Catalogue 2", "NGC 4565A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1018",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 496",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)09.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2594",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2594"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1017",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2229",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)09.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 746",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)55.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3203",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3302",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3338",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3532",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7628",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7628"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)20.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7745",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7745"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 488",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 23",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 23"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)09.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2405",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2405"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 483",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3449",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2735",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2735"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1019",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3219",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3300",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4587",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2592",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2592"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)27.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5827",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5827"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4565",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4565"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 16.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+25, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 489",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)01.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3464",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3112",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4614",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4614"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1020",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)28.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2583",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3215",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3360",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3477",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3226",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4615",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4615"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3251",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3251"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3321",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3571",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4613",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4613"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4530",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7741",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7741"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3579",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2579",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3251"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3902",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3902"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3594",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3335",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7435",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7435"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 656",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 656"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3527",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7433",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7433"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7436",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7436"},
        {"New General Catalogue 2", "NGC 7436B"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 492",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)05.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3178",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3179",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3316",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7431",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7431"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)57.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3553",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3582",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1138",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6228",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6228"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)48.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3546",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4565B"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7735",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7735"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)42.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3944",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3944"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3421",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3538",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3242",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3628",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5594",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5594"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4423",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2435",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)06.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2824",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2824"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4405",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4412",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3543",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4565C"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5553",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5553"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4498",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)45.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3614",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2248",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2248"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3785",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3785"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3784",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3784"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)39.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3205",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3547",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 834",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1166",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2540",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2540"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3488",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3781",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3781"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)39.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3198",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3206",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2180",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3217",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3935",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4399",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)18.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3549",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4849",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4849"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 838",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6671",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6671"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)37.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4397",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4146",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4146"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)10.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4297",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)35.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 832",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4244",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7052",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7052"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)18.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 187",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3899",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3899"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3401",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1256",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)23.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6372",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6372"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 474",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)46.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 478",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)53.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3912",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3912"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)50.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 831",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)52.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 835",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4250",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4436",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)27.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6885",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6885"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)12.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3826",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3826"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3644",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3650",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 837",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6371",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6371"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 900",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 900"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4555",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4555"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3545",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3596",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)37.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3640",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3641",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3646",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4461",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)35.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 491",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3536",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3645",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4462",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)35.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6882",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6882"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 18.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)11.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 901",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6096",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6096"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3830",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3830"},
        {"New General Catalogue 2", "NGC 3830B"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3534",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3534"},
        {"New General Catalogue 2", "NGC 3534A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)08.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3169",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 486",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3502",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3609",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3609"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3612",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3612"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3531",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2486",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)30.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4630",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 484",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3380",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3508",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3362",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3618",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3632",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 485",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3308",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3514",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3599",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)37.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7080",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7080"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)30.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2598",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3324",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3496",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3498",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3642",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3651",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4230",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)22.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4241",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)24.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4314",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3565",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4313",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2862",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2862"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)24.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2954",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2956",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3200",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3297",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3415",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 480",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)55.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3394",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3495",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3450",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3336",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4859",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4859"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3480",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3585",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6710",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6710"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1539",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1539"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4395",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4427",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)27.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6815",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)40.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 326",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 326"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3610",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)38.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6076",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6076"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)11.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2205",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)46.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3241",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4556",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4556"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3561",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4892",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4892"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2449",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2449"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2626",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)09.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6077",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6077"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)11.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 476",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3367",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4557",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4557"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4821",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4821"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2266",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2266"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2590",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3563",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3563"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)11.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3629",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3629"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)20.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3556",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2607",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2607"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)33.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3376",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4563",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4563"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3559",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4819",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4819"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5116",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5116"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6016",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6016"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5341",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2450",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2450"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)47.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 479",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4080",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4080"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7726",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7726"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)38.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3234",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3235"},
        {"New General Catalogue 2", "NGC 3234"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)24.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3900",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3900"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4558",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4558"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7660",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7660"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)25.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5342",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 188",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2492",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2492"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5281",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7466"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)02.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7720",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7720"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)38.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 64",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3202",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5164",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)06.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7466",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7466"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7737",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7737"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)42.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1512",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1170",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)02.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4673",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4673"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4787",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4787"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4789",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4789"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5166",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)06.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2490",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2490"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3560",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5163",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)05.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7767",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7767"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)50.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1511",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7767"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3491",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4317",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)41.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7210",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)06.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3623",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4234",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)23.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4384",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)11.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7766",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7766"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)50.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3140",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3342",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3600",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)37.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4670",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4670"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7728",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7728"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7765",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7765"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7768",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7768"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)50.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4702",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4702"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4827",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4827"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1731",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 823",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4692"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4425",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 919",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 919"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)26.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3283",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4692",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4692"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 915",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 915"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)25.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 928",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 928"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)27.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2520",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)56.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3451",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3451"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3214",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 46",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2506",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4475",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4475"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3900",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4307",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2088",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2505",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3590",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3913",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3143",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6813",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6813"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4788",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4788"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7624",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7624"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1727",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)47.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3513",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4721",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4721"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 904",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 904"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2331",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2331"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 18.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3511",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4797",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4798"},
        {"New General Catalogue 2", "NGC 4797"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7740",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7740"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)43.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 903",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 903"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)23.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3375",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3512",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7747",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7747"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)45.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3299",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3460",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3262",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3306",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3278",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4798",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4798"},
        {"New General Catalogue 2", "NGC 4797"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5251",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5251"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5635",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5635"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 672",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 672"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)47.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4017",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4017"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3269",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4728",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4728"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4745",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4745"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4452",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)32.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2219",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3516",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2213",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4842",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4842"},
        {"New General Catalogue 2", "NGC 4842A"},
        {"New General Catalogue 3", "NGC 4842a"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2208",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)52.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2217",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3135",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3454",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3627",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4839",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4839"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1307",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)42.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4016",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4016"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4807",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4807"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4824",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4824"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6632",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6632"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4393",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4393"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3323",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4393"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3444",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3587",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3949",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4960",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4960"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3329",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4393"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4957",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4957"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3570",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3570"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)12.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3270",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3494",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3351",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4853",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4853"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3574",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3574"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)12.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4275",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4275"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4840",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4840"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4926",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4926"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4514",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)50.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7833",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7839",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7839"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)07.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 252",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 252"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)48.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 258",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 258"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 165",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 684"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3406",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6270",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6270"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 684",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 684"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3196",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3196"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3274",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3274"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4854",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4854"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)07.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 260",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 260"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4512",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)49.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)07.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)08.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 18",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 16",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 16"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)09.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3493",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3493"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)01.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4961",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4961"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3230",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3243",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3341",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4816",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4816"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2618",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3593",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4559B"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)37.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3957",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3407",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3947",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3959",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3963",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4911",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4911"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4919",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4919"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5032",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5032"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)13.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4533",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1584",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)47.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3204",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3204"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2982",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4004B"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3172",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4715",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4715"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3946",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 22",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 22"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)09.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2366",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3482",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6263",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6263"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4426",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4426"},
        {"New General Catalogue 2", "NGC 4427"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4427",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4426"},
        {"New General Catalogue 2", "NGC 4427"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3389",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3960",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3964",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3976",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4923",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4923"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6265",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6265"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2365",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3515",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6264",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6264"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6269",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6269"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 670",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 670"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)47.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 855",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 855"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)14.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2361",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)25.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3678",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3678"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3988",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3988"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4004",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4004"},
        {"New General Catalogue 2", "NGC 4004A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4408",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4408"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3592",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4559A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3973",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4921",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4921"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2499",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)41.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3193",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4875",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4875"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3168",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3353",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3620",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4869",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4869"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4876",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4876"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4906",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4906"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.2,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4044",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2565",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3550",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3554",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3563",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3564",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6272",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6272"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2430",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)04.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2550",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4805",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4871",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4871"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4872",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4872"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4898",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Z Coma Coma"},
        {"New General Catalogue", "NGC 4898"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4030",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3504",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3504"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3165",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3551",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4559",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4559"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4850",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4850"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4867",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4867"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3968",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4874",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "TT 12"},
        {"New General Catalogue", "NGC 4874"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3998",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.7,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4889",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4889"},
        {"New General Catalogue 2", "NGC 4884"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4894",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4894"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4033",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4042",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.3,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6092",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6092"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)12.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3414",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3414"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4864",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4864"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4873",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4873"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4882",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4886"},
        {"New General Catalogue 2", "NGC 4882"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4884",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4889"},
        {"New General Catalogue 2", "NGC 4884"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4886",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4886"},
        {"New General Catalogue 2", "NGC 4882"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4133",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6271",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6271"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3387",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3552",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3555",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4817",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4817"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3955",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4011",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4041",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4051",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4927",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4927"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6261",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6261"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)56.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3232",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3232"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3235",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3235"},
        {"New General Catalogue 2", "NGC 3234"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)24.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4828",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4828"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4934",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4934"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)03.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3512",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3512"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)04.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4883",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4883"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.3,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4021",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4908",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4908"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4931",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4931"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2495",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)38.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4026",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.7,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4040",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4929",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4929"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4111",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)02.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 962",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 962"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4865",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4865"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4012",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.8,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4045",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4943",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4943"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2498",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2572",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4582",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+28, (int)06, 0)
    )
)
);
}
}

}
