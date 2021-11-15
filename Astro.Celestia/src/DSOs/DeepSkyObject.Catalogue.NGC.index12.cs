using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class DeepSkyObjectCatalogue {
private static void _addNGC_12() {
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4288",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4288"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5391",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5391"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5439",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5439"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1169",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1169"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7062",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7062"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1221",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1146",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3192",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3191"},
        {"New General Catalogue 2", "NGC 3192"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4144",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4144"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)10.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3191",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3191"},
        {"New General Catalogue 2", "NGC 3192"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191916"},
        {"Wilson Evans Batten Catalogue", "WEB 17740"},
        {"New General Catalogue", "NGC 6884"},
        {"New General Catalogue 2", "NGC 6766"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7209",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7209"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 25.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3782",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3782"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)39.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4800",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4800"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1883",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1883"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6811",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6811"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 13.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)38.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3170",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5173",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5173"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5714",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5714"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)38.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5169",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5169"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5198",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5198"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)30.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5722",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5722"},
        {"New General Catalogue 2", "NGC 5721A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)39.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5717",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5717"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5721",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5721"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)38.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5723",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5723"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)38.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5724",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5724"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 17.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)39.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4284",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4285",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1363",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)10.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4257",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6560",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6560"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1525",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4263",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 260",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3677",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3677"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 256",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)49.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 257",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)49.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4346",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4346"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3726",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3726"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)33.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4226",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4226"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2666",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2666"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)50.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5029",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5029"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7082",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7082"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 25.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4217",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4217"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2344",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2344"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)12.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4282",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4636",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4901",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4901"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5194",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Whirlpool"},
        {"Common Name 2", "Question Mark Galaxy"},
        {"Common Name 3", "Whirlpool Galaxy"},
        {"Messier Catalogue", "M 51"},
        {"New General Catalogue", "NGC 5194"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4917",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4917"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5377",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5377"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6279",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6279"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1245",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1245"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4278",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)30.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3111",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3111"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4010",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4010"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5195",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5195"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)30.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5146",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Cocoon Nebula"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)53.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4258",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 106"},
        {"New General Catalogue", "NGC 4258"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 8.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 18.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4277",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)30.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7011",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7011"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4001",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4001"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5767",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5767"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)49.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3320",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3320"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4248",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4248"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5076",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 9.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6991",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6991"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)56.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4232",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4232"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3595",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3595"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4231",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4231"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4096",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4096"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)06.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3877",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3877"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)46.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6229",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6229"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)47.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 278",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 278"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2676",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2676"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6711",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6711"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)49.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1798",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1798"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)11.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4741",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4741"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 65",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3811",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3811"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1369",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)12.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 687",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201192"},
        {"Wilson Evans Batten Catalogue", "WEB 18972"},
        {"New General Catalogue", "NGC 7026"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)06.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3949",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3949"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)53.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5830",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5830"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4220",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4220"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3769",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3769"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)37.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5229",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5229"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)34.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3950",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3950"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)53.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1033",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1032",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7071",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7071"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7067",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7067"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1031",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1152",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6443",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6443"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)44.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1536",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)14.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4218",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4218"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1534",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)13.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1535",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)14.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1153",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)56.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 48",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 48"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)14.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 49",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 49"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)14.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 51",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 51"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)14.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3577",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3577"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)13.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5256",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5256"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)38.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4837",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4837"},
        {"New General Catalogue 2", "NGC 4837a"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3583",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3583"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6313",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6313"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 185",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 185"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)39.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3985",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3985"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6155",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6155"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)26.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 562",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 562"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3906",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3906"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7092",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 39"},
        {"New General Catalogue", "NGC 7092"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 4.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 32.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5425",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5425"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3932",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3932"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)52.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6742",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6742"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 147",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 147"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5500",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5500"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)10.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5622",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5622"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)26.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5700",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5700"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5693",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5693"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2329",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2329"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)09.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5932",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5932"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5933",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5933"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)27.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4047",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4047"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)02.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5682",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5682"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5683",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5683"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3896",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3896"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)48.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3928",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Miniature Spiral"},
        {"New General Catalogue", "NGC 3928"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)51.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3893",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3893"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5689",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5689"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4357",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4357"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4381",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5835",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5835"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)02.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 711",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187836"},
        {"Wilson Evans Batten Catalogue", "WEB 17156"},
        {"New General Catalogue", "NGC 6833"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)49.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+48, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 709",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 708",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)33.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2541",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2541"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 712",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2688",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2688"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4528",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2684",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2684"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)54.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2686",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2686"},
        {"New General Catalogue 2", "NGC 2686A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)54.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7686",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7686"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 5.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)30.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2687",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2687"},
        {"New General Catalogue 2", "NGC 2687A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 17.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2689",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2689"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5448",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5448"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2854",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2854"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2856",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2856"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1223",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1291",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2857",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2857"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5795",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5795"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5676",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5676"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1724",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1724"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)03.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1513",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1513"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 9.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)10.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 731",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)46.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4100",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4100"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 472",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)43.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5660",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5660"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)29.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 471",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)43.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5804",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5804"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5797",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5797"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5805",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5805"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5794",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5794"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1301",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7150",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)50.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5818",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5818"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6154",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6154"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)25.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6582",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6582"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7243",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7243"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 21.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2126",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2126"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1029",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)32.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6283",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6283"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 902",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)36.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5673",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5673"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5828",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5828"},
        {"New General Catalogue 2", "NGC 5828A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+49, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2552",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2552"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3924",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3924"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)52.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 461",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5009",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5009"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)10.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 458",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)10.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3298",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3298"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)37.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4867",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 463",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)10.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 457",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2330"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 464",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2340",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2340"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2332",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2332"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)09.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 459",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)10.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 462",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3922",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3922"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)51.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2330",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2330"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)09.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2334",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)09.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2639",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2639"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)43.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3870",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3870"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 460",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 705",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)32.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6895",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6895"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)16.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1545",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1545"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 18.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 465",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)11.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6759",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6759"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4085",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4085"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)05.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5902",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5902"},
        {"New General Catalogue 2", "NGC 5902S"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)14.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5520",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5520"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)12.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1057",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)46.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2771",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2771"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)10.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2767",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2767"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)10.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1056",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2762",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2762"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)09.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4617",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4617"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1624",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1624"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2769",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NGC 2769 Group"},
        {"New General Catalogue", "NGC 2769"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4932",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4932"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3148",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3148"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)13.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4157",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4157"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)11.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2322",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2322"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5602",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5602"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)22.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6826",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Blinking Planetary"},
        {"Henry Draper", "HD 186924"},
        {"Smithsonian Astrophysical Observation", "SAO 31951"},
        {"Wilson Evans Batten Catalogue", "WEB 17056"},
        {"New General Catalogue", "NGC 6826"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4088",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4088"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)05.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2315",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2315"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)02.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2320",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2320"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)05.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4998",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4998"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)08.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7801",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7801"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 907",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5480",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5480"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5481",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5481"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)06.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2326",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2326"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)08.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2500",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2500"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4187",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4187"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)13.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6515",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6515"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)57.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2321",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2321"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4181",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4181"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)13.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6409",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6409"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7058",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7058"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4542",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4542"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4537",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4537"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7031",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7031"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)07.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5720",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5720"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6764",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6764"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)08.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2841",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2841"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)22.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4026",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4026"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212534"},
        {"Wilson Evans Batten Catalogue", "WEB 19817"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+50, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 951",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)51.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3410",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3410"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3406",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3406"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2519",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2518"},
        {"New General Catalogue 2", "NGC 2519"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)08.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2518",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2518"},
        {"New General Catalogue 2", "NGC 2519"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)07.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6478",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6478"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4707",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4707"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)48.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1230",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1528",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1528"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 24.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5250",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5250"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)36.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5040",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5040"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1074",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)52.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1229",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)45.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1491",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1491"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2681",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2681"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2694",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2694"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4938",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4938"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2693",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2693"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1348",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1348"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)33.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6466",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6466"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5225",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5225"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)33.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 650",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Barbell Nebula"},
        {"Common Name 2", "Cork Nebula"},
        {"Common Name 3", "Little Dumbbell Nebula"},
        {"Henry Draper", "HD 10346"},
        {"Wilson Evans Batten Catalogue", "WEB 1707"},
        {"Messier Catalogue", "M 76"},
        {"New General Catalogue", "NGC 651"},
        {"New General Catalogue 2", "NGC 650"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)42.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5707",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5707"},
        {"New General Catalogue 2", "NGC 5707SW"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 651",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Barbell Nebula"},
        {"Common Name 2", "Cork Nebula"},
        {"Common Name 3", "Little Dumbbell Nebula"},
        {"Henry Draper", "HD 10346"},
        {"Wilson Evans Batten Catalogue", "WEB 1707"},
        {"Messier Catalogue", "M 76"},
        {"New General Catalogue", "NGC 651"},
        {"New General Catalogue 2", "NGC 650"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)42.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7086",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7086"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 9.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)30.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5624",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5624"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5238",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5238"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2165",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2165"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)11.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2740",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2740"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)06.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2739",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2739"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)06.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3917",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3917"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2208",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2208"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)22.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4987",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4987"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)08.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+51, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3931",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3931"},
        {"New General Catalogue 2", "NGC 3917A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)51.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5788",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5788"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)53.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1790",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1790"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2436",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)46.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2692",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2692"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5783",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5783"},
        {"New General Catalogue 2", "NGC 5785"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5785",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5783"},
        {"New General Catalogue 2", "NGC 5785"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)53.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7394",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7394"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 801",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6566",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6566"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)07.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7296",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7296"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4834",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4834"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3953",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3953"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)53.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2429",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2429"},
        {"New General Catalogue 2", "NGC 2429A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6732",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6732"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)56.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6090",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6090"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)11.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2800",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2800"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)18.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5875",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5875"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)09.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4068",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4068"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)04.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1496",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1496"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6358",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6358"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 757",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4068"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1300",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6798"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1444",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1444"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)49.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3829",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3829"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4102",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4102"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2600",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2600"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6386",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6386"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)28.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5163",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5163"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)26.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 853",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)08.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2603",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2606"},
        {"New General Catalogue 2", "NGC 2603"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3824",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3824"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5366",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)57.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2606",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2606"},
        {"New General Catalogue 2", "NGC 2603"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2426",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2426"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2602",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2602"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)35.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1434",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)10.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7295",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2474",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2474"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2475",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2475"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2605",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2605"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4732",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4732"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4205",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)08.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1708",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1708"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3657",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3657"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1400",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)44.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+52, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1211",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2431",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2431"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3718",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3718"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5201",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5201"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4142",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4142"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)09.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4801",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4801"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3729",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3729"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)33.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3631",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3631"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1402",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1220",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1220"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)11.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3549",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3549"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)10.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3992",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 109"},
        {"New General Catalogue", "NGC 3992"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5751",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5751"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5001",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5001"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)09.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3310",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3310"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)38.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6448",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)44.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2505",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2505"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)04.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4967",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4967"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2675",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2675"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)51.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6798",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6798"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4974",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4974"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5474",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5474"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 830",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4973",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4973"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 847",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4973"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)06.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7128",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7128"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2701",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2701"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2756",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2756"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)09.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3656",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3656"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2656",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2656"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)47.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5820",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5820"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5821",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5821"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1027",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)29.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+53, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1442",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.1,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6479",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6479"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)48.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5455",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5455"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4566",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4566"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5450",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5450"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5458",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5458"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5447",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5447"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3756",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3756"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5453",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5453"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3448",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3448"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)54.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5449",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5449"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5461",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5461"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5368",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5368"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7245",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7245"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5457",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Pinwheel"},
        {"Messier Catalogue", "M 101"},
        {"New General Catalogue", "NGC 5457"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 7.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 26.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7438",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7438"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)57.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5451",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5451"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5462",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5462"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6801",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6801"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)27.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4695",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4695"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1069",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5471",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5471"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)04.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3791",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5477",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5477"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)05.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5687",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5687"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4384",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4384"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5876",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5876"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)09.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3738",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3738"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4194",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Medusa Galaxy Merger"},
        {"New General Catalogue", "NGC 4194"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)14.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1111",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)14.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4686",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4686"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)46.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7008",
    secondaryIds: new Dictionary<string,string>{
        {"Wilson Evans Batten Catalogue", "WEB 18870"},
        {"New General Catalogue", "NGC 7008"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2446",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2446"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)48.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7127",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7127"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4675",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4675"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5874",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5874"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)07.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3759",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3759"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7175",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7175"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3733",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3733"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)35.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2943",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4646",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4646"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4669",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4669"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5473",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5473"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3737",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3737"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+54, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5485",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5485"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3587",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Owl Nebula"},
        {"Messier Catalogue", "M 97"},
        {"New General Catalogue", "NGC 3587"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5484",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5484"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)06.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1237",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3921",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3921"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6143",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6143"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5486",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5486"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3982",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3982"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)56.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3916",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3916"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4644",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4644"},
        {"New General Catalogue 2", "NGC 4644A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5422",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5422"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)00.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3794",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3804"},
        {"New General Catalogue 2", "NGC 3794"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5294",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5294"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3972",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3972"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)55.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3913",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3913"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 740",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3913"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6157",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6157"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)25.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3398",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3398"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 644",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3980",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3977"},
        {"New General Catalogue 2", "NGC 3980"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3977",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3977"},
        {"New General Catalogue 2", "NGC 3980"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5908",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5908"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7226",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7226"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)10.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3998",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3998"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1378",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)23.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 646",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3990",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3990"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5870",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5870"},
        {"New General Catalogue 2", "NGC 5826"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)06.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 744",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 744"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2456",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2456"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5164",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5164"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5826",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5870"},
        {"New General Catalogue 2", "NGC 5826"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)59.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5905",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5905"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6182",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6182"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)29.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2457",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2457"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)54.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6246",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6246"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)49.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5862",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5862"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)06.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1286",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 919",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)42.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 918",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)42.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 922",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 925",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 935",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1098",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3073",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3073"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 923",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 928",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 931",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 934",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 936",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 938",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)44.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 917",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 932",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6691",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6691"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)39.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4977",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4977"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 926",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 929",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 937",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)44.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2534",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2534"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)12.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3556",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 108"},
        {"New General Catalogue", "NGC 3556"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)11.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3846",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3846"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)44.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5278",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5278"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)41.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5279",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5279"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)41.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 921",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2710",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2710"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)59.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3079",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3079"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 930",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3594",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3594"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6454",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6454"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6757",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6757"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)05.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5867",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5475",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5475"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6459",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6459"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5866",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 102"},
        {"New General Catalogue", "NGC 5866"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4666",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2013",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2013"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5443",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5443"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 657",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 657"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3850",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3850"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)45.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4667",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)46.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5779",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5779"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6136",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6136"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)20.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3353",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3353"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3888",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3888"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)47.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+55, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 778",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4198",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4198"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)14.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3889",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)47.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3264",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3264"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)32.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3898",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3898"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6824",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6824"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6856",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6856"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4172",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4172"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)12.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3804",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3804"},
        {"New General Catalogue 2", "NGC 3794"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)40.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3499",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3499"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6532",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6532"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6562",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6562"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3780",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3780"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)39.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4964",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4964"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)05.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5907",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5906"},
        {"New General Catalogue 2", "NGC 5907"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)15.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1293",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)41.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5906",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5906"},
        {"New General Catalogue 2", "NGC 5907"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2468",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2468"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5969",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5969"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4511",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4511"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5971",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5971"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3517",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3517"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)05.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1099",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2488",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2488"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1590",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5631",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5631"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5963",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5963"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 11",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)20.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 942",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)47.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 281",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 281"},
        {"New General Catalogue 2", "NGC 281W"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 35.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)52.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2462",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2462"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2463",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2463"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2210",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6133",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)20.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2461",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2458"},
        {"New General Catalogue 2", "NGC 2461"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)56.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2464",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)57.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2469",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2469"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2473",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2473"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3164",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3164"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)15.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2472",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2472"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5965",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5965"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)34.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2458",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2458"},
        {"New General Catalogue 2", "NGC 2461"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)55.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5585",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5585"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)19.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7789",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7789"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 16.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2465",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)57.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2471",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4271",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4271"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6449",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6449"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6382",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6382"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3683",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3683"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1234",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)52.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3206",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3206"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6262",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6262"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)53.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2497",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2497"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)02.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7234",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7234"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)12.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3445",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3445"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+56, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5879",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5879"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)09.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6370",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6370"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)23.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3214",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3214"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)23.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3220",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3220"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)23.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 604",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)23.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3674",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3674"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 884",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "chi Per Cluster"},
        {"Common Name 2", "chi Persei Cluster"},
        {"Common Name 3", "khi Per Cluster"},
        {"New General Catalogue", "NGC 884"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 4.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)22.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3440",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3440"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)53.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3458",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3458"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)56.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7423",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7423"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)55.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 869",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "h Per Cluster"},
        {"Common Name 2", "h Persei Cluster"},
        {"New General Catalogue", "NGC 869"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 4.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 522",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3238",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3238"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3530",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3530"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)08.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7235",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7235"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6346",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6346"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4650",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)15.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6474",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6473"},
        {"New General Catalogue 2", "NGC 6474"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)46.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6473",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6473"},
        {"New General Catalogue 2", "NGC 6474"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)47.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6345",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6345"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2870",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2870"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1252",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4649",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4668",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)46.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7352",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7352"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3188",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3188"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)19.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1250",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)14.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6338",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6338"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6088",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6088"},
        {"New General Catalogue 2", "NGC 6088A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2895",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2895"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)32.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1396",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 3.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 170.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)39.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6198",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6198"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 957",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 957"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)33.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 875",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)17.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6385",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6385"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)28.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6387",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6387"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7055",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7055"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6125",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6125"},
        {"New General Catalogue 2", "NGC 6127"},
        {"New General Catalogue 3", "NGC 6128"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6130",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6130"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2128",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2128"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5109",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5109"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 996",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3488",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3488"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5113",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5113"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3669",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3669"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6187",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6187"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4161",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4161"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)11.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2521",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2521"},
        {"New General Catalogue 2", "NGC 2521A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3619",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3619"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5526",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5526"},
        {"New General Catalogue 2", "NGC 5526NE"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)13.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3625",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3625"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)20.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6211",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6211"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2549",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2549"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 995",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6213",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6213"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7281",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7281"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4054",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4054"},
        {"New General Catalogue 2", "NGC 4054W"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5678",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5678"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)32.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3838",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3838"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)44.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4500",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4500"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6127",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6125"},
        {"New General Catalogue 2", "NGC 6127"},
        {"New General Catalogue 3", "NGC 6128"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6128",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6125"},
        {"New General Catalogue 2", "NGC 6127"},
        {"New General Catalogue 3", "NGC 6128"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+57, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3613",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3613"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5987",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5987"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)39.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7261",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7261"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4284",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4284"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4290",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4290"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7380",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7380"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 25.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)47.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3225",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3225"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)25.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3182",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3182"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 361",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1851",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)51.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4149",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4149"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 457",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "ET Cluster"},
        {"Common Name 2", "Owl Cluster"},
        {"New General Catalogue", "NGC 457"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 13.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4154",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4814",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4814"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3958",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3958"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4362",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4362"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6916",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6916"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4358",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4358"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4364",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4364"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5204",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5204"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3408",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3408"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3757",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3757"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4335",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4335"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6190",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6190"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)32.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1231",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)46.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1260",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3963",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3963"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)55.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1258",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3284",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3286"},
        {"New General Catalogue 2", "NGC 3284"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)36.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3288",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3288"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)36.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3690",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3690"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1259",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 694",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3286",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3286"},
        {"New General Catalogue 2", "NGC 3284"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3795",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3795"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1227",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6206",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6206"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5372",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5372"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)54.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6418",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6418"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2685",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Helix Galaxy"},
        {"Common Name 2", "Pancake Galaxy"},
        {"New General Catalogue", "NGC 2685"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)55.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5561",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5561"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3610",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3610"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6191",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)32.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 436",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 436"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)15.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6376",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6376"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6377",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6377"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2950",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2950"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4141",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4141"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)09.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6391",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6391"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)28.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4547",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4547"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4549",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4549"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4652",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4652"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5777",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5777"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)51.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6286",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "IRAS F16577+5900 SE"},
        {"New General Catalogue", "NGC 6286"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6291",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6291"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6285",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6285"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+58, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6290",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6290"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6373",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6373"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2166",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)27.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3642",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3642"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 691",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6750",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6750"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)00.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 10",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3043",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3043"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6696",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6696"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5430",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5430"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5985",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5985"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5982",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5982"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)38.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5976",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5976"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)36.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5981",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5981"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)37.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1267",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)38.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3894",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3894"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)48.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6832",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6832"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)48.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3895",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3895"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5667",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5667"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)30.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6498",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5376",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5376"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)55.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6497",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6497"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)51.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3470",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3470"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6394",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6394"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6170",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)27.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6176",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6176"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3770",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3770"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)38.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4195",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4195"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)14.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6687",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6687"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)37.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6399",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6399"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6189",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6189"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6393",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6393"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)30.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5389",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5389"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5379",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5379"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)55.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5989",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5989"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 155",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)47.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5402",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5402"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5894",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5894"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)11.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5342",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5342"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)51.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6670",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6670"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3809",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3809"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4199",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4199"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6831",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6831"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)47.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6829",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6829"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)47.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2726",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2726"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3740",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3740"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7429",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7429"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+59, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5540",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5540"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1248",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)11.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7795",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7795"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6381",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6381"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2768",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2768"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)11.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6390",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6390"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6489",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6489"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)50.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3102",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3102"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)04.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3835",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3835"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)44.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 433",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 433"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3097",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)04.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 852",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)07.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6946",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6946"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 8.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 743",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 743"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5322",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5322"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2654",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2654"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)49.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 129",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 129"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 21.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)29.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3168",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3168"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)16.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1470",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2209",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3796",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3796"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)40.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6295",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6295"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)03.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2460",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2460"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5503",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5503"},
        {"New General Catalogue 2", "NGC 5502"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6787",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6787"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)16.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1848",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 60.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)51.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5502",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5503"},
        {"New General Catalogue 2", "NGC 5502"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)09.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2816",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2742"},
        {"New General Catalogue 2", "NGC 2816"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)21.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6436",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6436"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2742",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2742"},
        {"New General Catalogue 2", "NGC 2816"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)07.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3671",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3671"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3978",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3978"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3975",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3975"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6258",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6258"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7510",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7510"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)11.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6361",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6361"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)18.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6939",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6939"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)31.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6701",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6701"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1871",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3945",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3945"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)53.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5370",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5370"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 581",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 103"},
        {"New General Catalogue", "NGC 581"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 659",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 659"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)44.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3589",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3589"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)15.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3166",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3180",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6306",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6306"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)07.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6307",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6307"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)07.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6411",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6411"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6510",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6510"},
        {"New General Catalogue 2", "NGC 6511"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)54.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6511",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6510"},
        {"New General Catalogue 2", "NGC 6511"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)54.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 63",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6410",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)35.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7419",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7419"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)54.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2273",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2273"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)50.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6464",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6464"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1501",
    secondaryIds: new Dictionary<string,string>{
        {"Wilson Evans Batten Catalogue", "WEB 3688"},
        {"New General Catalogue", "NGC 1501"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)07.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5308",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5308"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)47.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+60, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6310",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6310"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)08.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1240",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6292",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6292"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 189",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 189"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 59",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6594",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6594"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)10.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4708",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)13.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6796",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6796"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)21.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6597",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6597"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7635",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Bubble Nebula"},
        {"New General Catalogue", "NGC 7635"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)20.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7790",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7790"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 17.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 663",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 663"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 16.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)46.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3236",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3236"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6095",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6095"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)11.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7354",
    secondaryIds: new Dictionary<string,string>{
        {"Wilson Evans Batten Catalogue", "WEB 19988"},
        {"New General Catalogue", "NGC 7354"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3435",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3435"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)54.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 289",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)10.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6607",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6607"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)12.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6608",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6608"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6609",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6609"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6617",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6617"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 103",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 103"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)25.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3543",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3543"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)10.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6542",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6542"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)59.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3407",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3407"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7788",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7788"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 9.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6592",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6592"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)09.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4669",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)47.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6601",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6601"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)11.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1805",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "AFGL 333 Cloud"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 60.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7538",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7538"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)13.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 136",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 136"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3471",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3471"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6491",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6491"},
        {"New General Catalogue 2", "NGC 6493A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)50.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1027",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1027"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6493",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6493"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)50.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6223",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6223"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)43.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 381",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 381"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)08.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7654",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 52"},
        {"New General Catalogue", "NGC 7654"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 13.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1824",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4605",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4605"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3762",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3762"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 225",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 225"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)43.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6359",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6359"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 166",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)52.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 654",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 654"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)44.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3725",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3725"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6462",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6462"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)44.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 896",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 896"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 27.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)24.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4036",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4036"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6123",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6123"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6202",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6226"},
        {"New General Catalogue 2", "NGC 6202"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6226",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6226"},
        {"New General Catalogue 2", "NGC 6202"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+61, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 358",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 358"},
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1049",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6298",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6297",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6297"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)03.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1795",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4041",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4041"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)02.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6238",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6238"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)47.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5007",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5007"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)09.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6244",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6244"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)48.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6365",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6365"},
        {"New General Catalogue 2", "NGC 6365B"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1270",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)47.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 366",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 366"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6488",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6488"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6015",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6015"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)51.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1502",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1502"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 5.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)07.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6817",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6817"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)37.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6299",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6299"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2880",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2880"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 758",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5205",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5205"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1210",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)14.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7160",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7160"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)53.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6435",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6435"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6521",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6521"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)55.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6512",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6512"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)54.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6516",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6516"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)55.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5216",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5216"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)32.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6111",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6111"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5218",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5218"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6317",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6317"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)09.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7076",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7076"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5881",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5881"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)09.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6247",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6247"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6319",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6319"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)09.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+62, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1100",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5881"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)06.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1235",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1233",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)48.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3359",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3359"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)46.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6275",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6275"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)55.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1065",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 146",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 146"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 559",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 559"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)29.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11758"},
        {"Wilson Evans Batten Catalogue", "WEB 1916"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)57.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 133",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 133"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4238",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4238"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3668",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3668"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4545",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4545"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1831",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)44.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 836",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)56.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7139",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7139"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1241",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6260",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6260"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)51.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 886",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 886"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4205",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4205"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)14.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4512",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4512"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5807",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5807"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6762",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6762"},
        {"New General Catalogue 2", "NGC 6763"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)05.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6763",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6762"},
        {"New General Catalogue 2", "NGC 6763"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)05.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4521",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4521"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+63, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 637",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 637"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)42.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6789",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6789"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4481",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4481"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6825",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6825"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)41.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2805",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2805"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)20.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2458",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2820A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1212",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2814",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2814"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)21.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4510",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4510"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2820",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2820"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6534",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6534"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)56.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4081",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4081"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)04.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 609",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 609"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)37.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2347",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2347"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3266",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3266"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)33.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5949",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5949"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)28.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4441",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4441"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6949",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6949"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1569",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1569"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6019",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6019"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6135",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6135"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2179",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4391",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4391"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5413",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5413"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6024",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6024"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)53.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6536",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6536"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4733",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6648",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)25.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+64, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3259",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3259"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4121",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4121"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)07.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4125",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4125"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6140",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6140"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6505",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6505"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)51.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1228",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)42.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2403",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2403"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 17.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5479",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5479"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2404",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3394",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3394"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3392",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3392"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6953",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)37.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7142",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7142"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4332",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4332"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4256",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4256"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1214",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2909",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2909"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4210",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4210"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+65, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6214",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6214"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7133",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7133"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6952",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6951"},
        {"New General Catalogue 2", "NGC 6952"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)37.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6951",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6951"},
        {"New General Catalogue 2", "NGC 6952"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)37.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7129",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NGC 7129 IR Cluster"},
        {"New General Catalogue", "NGC 7129"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5134",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5132",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)42.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5133",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6869",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6869"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)00.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4221",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4221"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4513",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4513"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6457",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6457"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)42.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3682",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3682"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6552",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6552"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)00.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4677",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6543",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sunflower Nebula"},
        {"Common Name 2", "Snail Nebula"},
        {"Common Name 3", "Cat's Eye Nebula"},
        {"Henry Draper", "HD 164963"},
        {"Wilson Evans Batten Catalogue", "WEB 14862"},
        {"New General Catalogue", "NGC 6543"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6636",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6636"},
        {"New General Catalogue 2", "NGC 6636A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)22.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6714",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6911",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6911"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3231",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3231"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6676",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6676"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+66, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6668",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4763",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6679"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6677",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6677"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6679",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6679"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4108",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4108"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)06.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3622",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3622"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1110",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)12.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6456",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6456"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6470",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6470"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)44.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6471",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6471e"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)44.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6463",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6463"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6472",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6472"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)44.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2892",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2892"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)32.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6477",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6477"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1225",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5283",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5283"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4762",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)32.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 445",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)37.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6678",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2976",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2976"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6667",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6667"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+67, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6650",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6650"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6420",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6420"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6422",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6422"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7762",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7762"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)49.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 342",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 17.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)46.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6419",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6419"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6423",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6423"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)36.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7023",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "IRIS Nebula"},
        {"New General Catalogue", "NGC 7023"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 18.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1218",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1129",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)32.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 396",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6622",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6622"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)13.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6303",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6303"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)05.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1216",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)16.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6621",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6621"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)12.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1083",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)55.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2574",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Coddington's Nebula"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1215",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)15.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6288",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6288"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6289",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6289"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)57.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1469",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1469"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2959",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2959"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2961",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2961"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7822",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7822"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 60.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)03.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3077",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3077"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)03.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5939",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5939"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)24.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4128",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4128"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+68, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1046",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)37.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+69, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2363",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NGC 2366 I"},
        {"New General Catalogue", "NGC 2363"},
        {"New General Catalogue 2", "NGC 2366A"},
        {"New General Catalogue 3", "NGC 2366I"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+69, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3031",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "M 81*"},
        {"Common Name 2", "Bode's Galaxy"},
        {"Henry Draper", "HD 85534"},
        {"Messier Catalogue", "M 81"},
        {"New General Catalogue", "NGC 3031"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 6.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 25.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)55.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+69, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6598",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6598"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+69, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2787",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2787"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+69, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2366",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2366"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)28.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+69, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4034",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4034"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)01.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+69, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3961",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3961"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)55.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+69, (int)20, 0)
    )
)
);
}
}

}
