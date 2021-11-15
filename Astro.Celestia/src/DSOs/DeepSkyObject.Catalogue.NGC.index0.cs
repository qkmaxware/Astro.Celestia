using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class DeepSkyObjectCatalogue {
private static void _addNGC_0() {
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2573",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Polarissima Australis"},
        {"New General Catalogue", "NGC 2573"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)42.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-89, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6438",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6438"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)26.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-85, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4333",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-84, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1841",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1841"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)45.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-84, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2051",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)52.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-83, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4499",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-82, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2144",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2144"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)41.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-82, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7637",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7637"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-81, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4545",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-81, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3195",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3195"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)09.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-80, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3149",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3149"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-80, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4647",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)26.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-80, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4641",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-80, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4640",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-80, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6920",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6920"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-80, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2012",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2012"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-79, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2884",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-79, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3104",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-79, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4448",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)40.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-78, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5612",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5612"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)34.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-78, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2054",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-78, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4555",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)48.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-78, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5026",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)48.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-78, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2142",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-78, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1956",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1956"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)19.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-77, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4631",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-77, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4864",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-77, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4633",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)13.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-77, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4608",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)46.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-77, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4635",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-77, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4912",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)06.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-77, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4928",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)10.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-77, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4618",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-77, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5025",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)45.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2160",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)55.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1520",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1520"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2103",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)39.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5040",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2915",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2915"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)26.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2631",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)09.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6557",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6557"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5022",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3620",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3620"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4522",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)11.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5967",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5967"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)48.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4377",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 643",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 643"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2089",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2148",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)39.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2134",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)23.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2203",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2203"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2140",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2164",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2161",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)57.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7098",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7098"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)46.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4825",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)17.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4578",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)53.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2146",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)37.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2190",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2190"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 339",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 339"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)57.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4654",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2161",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2161"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)55.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1777",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1777"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)55.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 796",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 796"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5085",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)13.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5109",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)33.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5103",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)29.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4661",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5130",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)50.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-74, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4644",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)24.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3059",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3059"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4964",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)17.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2209",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2209"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)08.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5087",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)14.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2980",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5077",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)09.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6932",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6932"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 602",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 602"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 269",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 269"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)48.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 256",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 256"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 265",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 265"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)47.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5014",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)35.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 242",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "ESO29-6e"},
        {"New General Catalogue", "NGC 242"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)43.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1662",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 241",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Cl Kron 22W"},
        {"Common Name 2", "Cl Lindsay 29w"},
        {"Common Name 3", "ESO29-6w"},
        {"New General Catalogue", "NGC 241"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)43.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 220",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 220"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)40.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 222",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 222"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)40.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2199",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2199"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 248",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 248"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 231",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 231"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)41.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 294",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 294"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 465",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 465"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5102",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4484",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)47.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 267",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 267"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)48.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1626",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)06.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 456",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 456"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)14.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6653",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6653"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)44.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6151",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6151"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)38.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2596",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7113"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)09.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 176",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 176"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 152",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 152"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 290",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 290"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)51.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5066",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 261",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 261"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)46.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 249",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 249"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-73, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2173",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2173"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)58.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5072",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5016",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 419",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 419"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)08.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5833",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5833"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)11.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 292",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "SMC"},
        {"Common Name 2", "Nubecula Minor"},
        {"Common Name 3", "Small Magellanic Cloud"},
        {"New General Catalogue", "NGC 292"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)52.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 376",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 376"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)03.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4958",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5008",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5073",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)03.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4372",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4372"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 18.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4746",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5108",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)32.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5071",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4747",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6209",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6209"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4893",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271224"},
        {"New General Catalogue", "NGC 1944"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 330",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 330"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5799",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5799"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)05.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4822",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)14.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5123",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1612",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)00.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1611",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)59.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 416",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 416"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)08.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 460",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 460"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 306",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 306"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)54.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4841",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)20.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6101",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6101"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 346",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 346"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 14.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 299",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 299"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)54.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5009",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 104",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "47 Tuc Cluster"},
        {"Henry Draper", "HD 2051"},
        {"New General Catalogue", "NGC 104"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 4.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 371",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 371"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)03.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1890",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1890"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1624",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 395",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 395"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-72, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5045",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)50.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5044",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271303"},
        {"New General Catalogue", "NGC 2000"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1789",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1789"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5075",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)04.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1629",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1629"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1840",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1840"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5048",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)51.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5069",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)00.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5051",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 411",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 411"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)07.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 422",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 422"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)08.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1641",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)09.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1660",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2025",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2025"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4705",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4712",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)31.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1466",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1466"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)44.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4929",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)06.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5060",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4704",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)27.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4682",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)16.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4992",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 361",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 361"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)02.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 458",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 458"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)14.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2213",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2213"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 121",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 121"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6777",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2121",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2121"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)48.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2466",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2466"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5118",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)40.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1655",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)11.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2103",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2103"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)41.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1914",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1914"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1708",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1848",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1848"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)07.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2133",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2133"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)51.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5053",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)53.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270190"},
        {"New General Catalogue", "NGC 2134"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)50.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5024",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2018",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2018"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 25.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)30.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4853",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)30.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4945",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5054",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)53.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2051",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2051"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4962",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)15.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4982",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5099",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)21.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-71, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2031",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2031"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4985",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)20.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5116",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2111",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2111"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)44.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2145",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2145"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4972",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4833",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4833"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 13.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6876",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6876"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)18.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6880",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6880"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6405"},
        {"New General Catalogue", "NGC 362"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6877",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6877"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)18.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4981",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)19.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5106",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2010",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2010"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)30.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1861",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1861"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)10.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1987",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1987"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6872",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6872"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)16.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4970",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)16.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1833",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1833"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)04.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269052"},
        {"New General Catalogue", "NGC 1837"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2171",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2171"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269838"},
        {"New General Catalogue", "NGC 2056"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2075",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2075"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)38.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6808",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6808"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5091",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4971",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)17.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5093",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1815",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1815"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)02.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2107",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2107"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4899",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1651",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1651"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4541",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)29.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4967",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)16.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2038",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2038"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)34.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4960",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1845",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1845"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)06.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1878",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1878"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1754",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1754"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4903",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1775",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1775"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1557",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1557"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)13.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5359",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5359"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)59.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1823",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1823"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)03.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7123",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7123"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1813",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1813"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2057",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2057"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1766",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1766"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)55.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2046",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2046"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2072",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2072"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4892",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)49.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2065",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2065"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)37.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2047",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2047"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4904",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)58.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1791",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1791"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1943",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1943"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2019",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2019"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)31.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2066",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2066"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4595",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)20.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2058",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2058"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4724",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2059",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2059"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2043",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2043"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2036",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2036"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)34.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2122",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2122"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)48.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1711",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1711"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)50.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1986",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1986"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1950",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1950"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78991"},
        {"Wilson Evans Batten Catalogue", "WEB 8556"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)07.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1939",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1939"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1959",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1959"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2016",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2016"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2028",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2028"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1938",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "ESO 56-108W"},
        {"New General Catalogue", "NGC 1938"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4773",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)51.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 406",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 406"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1673",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1673"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1702",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1702"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1971",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1971"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1958",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1958"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)25.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1751",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1751"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)54.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1969",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1969"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1972",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1972"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1664",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)14.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1795",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1795"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1921",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1921"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38437"},
        {"New General Catalogue", "NGC 2079"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6392",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6392"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269822"},
        {"New General Catalogue", "NGC 2048"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 18.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1704",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1704"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)49.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2037",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2037"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2052",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)37.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2078",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2078"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2083",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2083"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)39.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2084",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2084"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)39.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270077"},
        {"New General Catalogue", "NGC 2113"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)45.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2005",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2005"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)30.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2033",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2033"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)34.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269937"},
        {"Henry Draper 2", "HD 38416"},
        {"New General Catalogue", "NGC 2077"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38540"},
        {"New General Catalogue", "NGC 2086"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1918",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1918"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38436"},
        {"New General Catalogue", "NGC 2080"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2085",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2085"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)40.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38540"},
        {"New General Catalogue", "NGC 2086"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1801",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1801"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2822",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2822"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)14.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1898",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1898"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4887",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)48.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1772",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1772"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1809",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1809"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2150",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2150"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2187",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2187"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)03.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5301",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1793",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1793"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1913",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1913"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2443",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2442"},
        {"New General Catalogue 2", "NGC 2443"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2442",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2442"},
        {"New General Catalogue 2", "NGC 2443"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)36.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1926",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1926"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)20.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2136",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2136"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)52.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269388"},
        {"Geneva Identification System", "GEN# +1.00269388"},
        {"New General Catalogue", "NGC 1922"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)19.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1928",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1928"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)20.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2074",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2074"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)38.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2102",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2102"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2125",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2125"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)50.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2137",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2137"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)53.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1712",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "LH1w"},
        {"New General Catalogue", "NGC 1712"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)51.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2088",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2088"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)40.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4934",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1894",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1894"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2091",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2091"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)40.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268626"},
        {"New General Catalogue", "NGC 1695"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)47.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31673"},
        {"Geneva Identification System", "GEN# +1.00031673"},
        {"New General Catalogue", "NGC 1722"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)51.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31673"},
        {"Geneva Identification System", "GEN# +1.00031673"},
        {"New General Catalogue", "NGC 1722"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268820"},
        {"Geneva Identification System", "GEN# +1.00268820"},
        {"New General Catalogue", "NGC 1767"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269016"},
        {"New General Catalogue", "NGC 1835"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2055",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2055"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)37.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2081",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2081"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1782",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1782"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1828",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1828"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)04.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1874",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1874"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34679"},
        {"New General Catalogue", "NGC 1876"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1877",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1877"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1880",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1880"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6183",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6183"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)41.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4988",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1916",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1916"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)17.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2050",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2050"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2127",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2127"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5173",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1693",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1693"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)47.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1727",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1727"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1881",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1881"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1830",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1830"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)04.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1872",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1872"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2836",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2836"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)13.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35231"},
        {"New General Catalogue", "NGC 1903"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2434",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2434"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1756",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1756"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2100",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2100"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)42.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1834",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1834"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1910",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1910"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2015",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2015"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)31.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2092",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2092"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5279",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31351"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)49.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31947"},
        {"New General Catalogue", "NGC 1743"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)54.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1737",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1737"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)54.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1745",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1745"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)54.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32014"},
        {"New General Catalogue", "NGC 1748"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32014"},
        {"New General Catalogue", "NGC 1748"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2108",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2108"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)43.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5052",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2044",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2044"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2157",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2157"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1698",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1698"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)49.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2060",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "30 Dor B"},
        {"New General Catalogue", "NGC 2060"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)37.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2009",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2009"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270138"},
        {"New General Catalogue", "NGC 2118"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)47.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1856",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1856"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1870",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1870"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 272034"},
        {"New General Catalogue", "NGC 2210"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)11.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1994",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1994"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269574"},
        {"New General Catalogue", "NGC 1984"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1804",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1804"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2069",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2069"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)38.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2070",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tarantula"},
        {"Common Name 2", "30 Dor Association"},
        {"Common Name 3", "30 Dor Cluster"},
        {"New General Catalogue", "NGC 2070"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 40.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2504",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1967",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1967"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5263",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2151",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2151"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1917",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1917"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2397",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2397"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-69, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269054"},
        {"New General Catalogue", "NGC 1847"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1885",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1885"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)15.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1983",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1983"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2241",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2241"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5138",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1825",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1825"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)04.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2093",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2093"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6730",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6730"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)07.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1858",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1858"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)09.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2042",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "LH89n"},
        {"New General Catalogue", "NGC 2042"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5252",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)48.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1785",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1785"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5232",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)37.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1854",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1855"},
        {"New General Catalogue 2", "NGC 1854"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)09.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1855",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1855"},
        {"New General Catalogue 2", "NGC 1854"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1676",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1676"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1649",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1649"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1966",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1966"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 13.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1953",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1953"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2249",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2249"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1734",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1734"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)53.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269158"},
        {"New General Catalogue", "NGC 1863"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)11.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1865",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1865"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)12.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1962",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1962"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1965",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1965"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1970",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1970"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34039"},
        {"New General Catalogue", "NGC 1850"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)08.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1860",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1860"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6943",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6943"},
        {"New General Catalogue 2", "NGC 6943a"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)44.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2001",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2001"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5256",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)49.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4787",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1652",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1652"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1732",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1732"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7216",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7216"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2159",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2159"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2172",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2172"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1836",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1836"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1839",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1839"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2140",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2140"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)54.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6719",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6719"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)03.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4789",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1697",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1697"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2109",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2109"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2116",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2116"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)46.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2164",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2164"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36301"},
        {"New General Catalogue", "NGC 1949"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)25.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2096",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2096"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32364"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1838",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1838"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2156",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2156"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)57.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5055",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5339",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 813",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 813"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)01.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1901",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1901"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1770",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1770"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4740",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2094",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2094"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2160",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2160"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7032",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7032"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1696",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1696"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)48.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2098",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2098"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)42.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 272055"},
        {"New General Catalogue", "NGC 2214"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5286",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)09.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1768",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1768"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1473",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1473"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)47.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1749",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1749"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2147",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2147"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)56.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1755",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1755"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)55.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2601",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2601"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)25.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5288",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)11.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1736",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1736"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1829",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1829"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269443"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2114",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2114"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7655",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7655"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-68, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1806",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1806"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35861"},
        {"New General Catalogue", "NGC 1936"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35814"},
        {"New General Catalogue", "NGC 1935"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35861"},
        {"New General Catalogue", "NGC 1936"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35814"},
        {"New General Catalogue", "NGC 1935"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269407"},
        {"New General Catalogue", "NGC 1929"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1934",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1934"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2166",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2166"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2788",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2788"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)09.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1937",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1937"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1899",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1899"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 802",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 802"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4921",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)03.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5323",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)27.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5324",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1852",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1852"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)09.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1786",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1786"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5320",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5322",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2177",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2177"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2020",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2020"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1764",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1764"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2014",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2014"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113981"},
        {"Wilson Evans Batten Catalogue", "WEB 11338"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7633",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7633"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)23.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1511",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1511"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1864",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1864"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)12.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37731"},
        {"New General Catalogue", "NGC 2032"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2035",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2035"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2202",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)27.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2029",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2029"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2040",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2040"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1717",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)32.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2231",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2231"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5031",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5032",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2011",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2011"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)32.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5158",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1955",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1955"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1846",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1846"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)07.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1871",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1871"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2117",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2117"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1897",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1897"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)17.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1968",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1968"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1991",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1974"},
        {"New General Catalogue 2", "NGC 1991"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2021",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2021"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)33.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2135",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2135"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4729",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5257",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1974",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1974"},
        {"New General Catalogue 2", "NGC 1991"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)27.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2053",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2053"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)37.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5335",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1869",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1869"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2348",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2348"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)03.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3136",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3136"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)05.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4860",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1873",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1873"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2130",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2130"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5140",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)54.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1844",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1844"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1895",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1895"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)16.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2095",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2095"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4571",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)48.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4862",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)31.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4071",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4071"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1814",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1814"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1816",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1816"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1820",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1820"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2004",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2004"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.8,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)30.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1842",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1842"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)07.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1774",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1774"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1905",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1905"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)18.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2154",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2154"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4713",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)30.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1940",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1940"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1747",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1747"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)54.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5023",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1735",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1735"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)53.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4811",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)05.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2197",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2197"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1718",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1718"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6362",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6362"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)31.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2554",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)08.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4993",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)22.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-67, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4710",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269872"},
        {"New General Catalogue", "NGC 2041"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)36.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2006",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2006"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1246",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1246"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)07.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31606"},
        {"New General Catalogue", "NGC 1714"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1731",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1731"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)53.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2034",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2034"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1715",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1715"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1919",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1919"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)20.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2027",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2027"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4990",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)21.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2062",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2062"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269647"},
        {"New General Catalogue", "NGC 2002"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)30.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5938",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5938"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)36.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2176",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2176"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5176",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)14.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5206",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1915",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1915"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1920",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1920"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)20.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1244",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1244"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1911",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1911"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1733",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1733"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)53.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4714",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)30.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1902",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1902"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269515"},
        {"New General Catalogue", "NGC 1951"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5236",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5235",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)41.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1760",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1760"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120800"},
        {"Wilson Evans Batten Catalogue", "WEB 11929"},
        {"New General Catalogue", "NGC 5315"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)53.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4813",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)05.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1313",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1313"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)18.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1761",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1761"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1769",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1769"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7329",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7329"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)40.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2003",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2003"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1776",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1776"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5094",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32340"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1946",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1946"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)25.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2105",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2105"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)44.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6492",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6492"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)02.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1763",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1763"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 25.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2115",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33294"},
        {"New General Catalogue", "NGC 1818"},
        {"New General Catalogue 2", "NGC 1818A"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2153",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2153"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1941",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1941"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)23.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4584",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)00.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1810",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1810"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)03.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1773",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1773"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1945",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1945"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4585",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4859",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1849",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1849"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)09.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1887",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1887"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1867",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1867"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1948",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "LH53s"},
        {"New General Catalogue", "NGC 1948"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)25.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1978",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1978"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1826",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1826"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)05.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1644",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1644"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)38.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1822",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1822"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5380",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1884",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)15.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1933",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1933"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271203"},
        {"New General Catalogue", "NGC 1932"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1862",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1862"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)12.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1882",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1882"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)15.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6718",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6718"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)01.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5154",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)04.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1805",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1805"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)02.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1490",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1490"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1503",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1503"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)56.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2030",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2030"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270921"},
        {"New General Catalogue", "NGC 1783"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-66, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117622"},
        {"Wilson Evans Batten Catalogue", "WEB 11687"},
        {"New General Catalogue", "NGC 5189"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7733",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7733"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7734",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7734"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5100",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5215",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)27.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5010",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)31.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5221",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)28.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5219",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5185",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1526",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1526"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2138",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2138"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5101",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)21.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6545",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6545"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)12.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4870",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)37.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1669",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1669"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1925",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "LH45s"},
        {"New General Catalogue", "NGC 1925"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5202",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5234",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)40.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1641",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1641"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4758",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)46.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5200",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)22.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1787",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1787"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5107",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5222",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)29.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5028",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)43.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 360",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 360"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)02.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6784",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6784"},
        {"New General Catalogue 2", "NGC 6784A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5137",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)51.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4847",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5142",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)55.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1923",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1923"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34574"},
        {"New General Catalogue", "NGC 1866"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2155",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2155"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6734",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6734"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5147",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5182",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6736",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6736"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)07.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6502",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6502"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5196",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7697",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7697"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5333",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7697"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5129",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)47.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5245",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 271628"},
        {"New General Catalogue", "NGC 2123"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)51.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5247",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)46.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7661",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7661"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2181",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2181"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95541"},
        {"Wilson Evans Batten Catalogue", "WEB 9745"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6844",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6844"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)02.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5208",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)24.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1859",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1859"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)11.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5280",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5277",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5382",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6684",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6684"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)49.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5272",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5266",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7358",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7358"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2193",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2193"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5042",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)47.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2233",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2233"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5250",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7417",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7417"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)57.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5038",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)46.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2230",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2230"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-65, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6328",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6328"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)23.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2229",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2229"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1892",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1892"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)17.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2235",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2235"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)22.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4815",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4815"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4711",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4745",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4790",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)56.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 646",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 646"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)37.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1831",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1831"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)06.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2966",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)50.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6722",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6722"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)03.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5246",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)46.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79627"},
        {"New General Catalogue", "NGC 2808"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 13.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)12.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7219",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7219"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)13.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5249",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)47.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4463",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4463"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)30.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4968",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)14.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4696",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)20.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7199",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7199"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)08.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5227",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)34.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5288",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5288"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)48.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5844",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5844"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4801",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4662",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)47.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7191",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7191"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5165",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)10.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5302",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4680",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)13.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5092",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2228",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2228"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)21.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2602",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "THETA CAR Cluster"},
        {"Common Name 2", "tet Car Cluster"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 1.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 50.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1532",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)09.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5120",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)38.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2307",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2307"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)48.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2257",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2257"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 13.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)30.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7192",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7192"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)06.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2082",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2082"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)41.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2305",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2305"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4748",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4752",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)43.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7020",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7020"},
        {"New General Catalogue 2", "NGC 7021"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)11.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7179",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7179"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)04.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5244",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)44.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7021",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7020"},
        {"New General Catalogue 2", "NGC 7021"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4834",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4823",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)12.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-64, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1868",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1868"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)14.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4741",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)41.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1942",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1942"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4799",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5121",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7096"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7083",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7083"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7096",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7096"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4742",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)41.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6776",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Pentagon"},
        {"New General Catalogue", "NGC 6776"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6744",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6744"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)09.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2887",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2887"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)23.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6588",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6588"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)21.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1947",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1947"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2178",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2178"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)02.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5096",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2162",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2162"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4656",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)37.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2297",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2297"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7408",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7408"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2120",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2120"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4755",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)45.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6483",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6483"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2948",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 60.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)38.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4764",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)47.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4820",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)09.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4788",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)54.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5045",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5045"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)17.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5120",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5120"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)26.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5155",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5155"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4784",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)52.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4767",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)47.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4770",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)48.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4698",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4723",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4730",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)38.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4765",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1771",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1771"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6630",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6630"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4766",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)47.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5084",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)09.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4664",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)49.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4771",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)48.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6614",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6614"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)25.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4744",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)41.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4749",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)42.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1997",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1997"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)30.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4052",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4052"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4769",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)47.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6706",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6706"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4800",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5074",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4759",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2381",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2381"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)20.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2842",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2842"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)15.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4805",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1900",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1900"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2944",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "lam Cen Nebula"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 4.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 75.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4779",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)50.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-63, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1706",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1706"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4609",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Coalsack Cluster"},
        {"New General Catalogue", "NGC 4609"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4750",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99898"},
        {"Geneva Identification System", "GEN# +1.00099898"},
        {"Smithsonian Astrophysical Observation", "SAO 251419"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4731",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)38.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4735",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4760",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5269",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5269"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1529",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1529"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5281",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5281"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 5.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)46.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4849",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4726",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4672",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)02.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4963",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)12.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-55, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6300",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6300"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)17.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4953",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)10.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1534",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1534"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1559",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1559"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2097",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2097"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)44.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4781",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)51.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2714",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4184",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4184"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4727",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)37.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3036",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3036"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89516"},
        {"Wilson Evans Batten Catalogue", "WEB 9254"},
        {"New General Catalogue", "NGC 3211"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88367"},
        {"Wilson Evans Batten Catalogue", "WEB 9171"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)09.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4737",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)39.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2205",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2205"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)10.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4728",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)37.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4674",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)08.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2200",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2369",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2369"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4833",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)15.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6673",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6673"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4831",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2417",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2417"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6733",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6733"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4809",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)04.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4751",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4798",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7622",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7622"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4753",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4794",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4824",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)13.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7823",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7823"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)04.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4803",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4828",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4291",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)37.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1765",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1765"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4754",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6746",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6746"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4349",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4349"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 16.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4738",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4739",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)40.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4976",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5316",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5316"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 14.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)53.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4974",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4951",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)09.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4804",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)01.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4743",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4778",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)50.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6398",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6398"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6403",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6403"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4815",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)06.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3766",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3766"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 5.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4838",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4795",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)57.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 432",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 432"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)11.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5230",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4936",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3576",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3576"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)11.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4793",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5229",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3519",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3519"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)04.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6739",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6739"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)07.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3586",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3586"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3581",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3581"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)12.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3582",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3582"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)12.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3603",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3603"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)15.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4103",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4103"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)06.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3579",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3579"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)11.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140586"},
        {"Wilson Evans Batten Catalogue", "WEB 13104"},
        {"New General Catalogue", "NGC 5979"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)47.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4905",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3584",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3584"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)12.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4866",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1796",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1796"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2609",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2609"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)29.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6860",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6860"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4869",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)36.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-61, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5168",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5168"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4653",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2516",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2516"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 3.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4827",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)13.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3590",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3590"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)12.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5238",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6407",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6407"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)45.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4939",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5617",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5617"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)29.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4655",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7125",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7125"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3255",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3255"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4842",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4885",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7126",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7126"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6156",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6156"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4400",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)22.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5207",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6771",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6771"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)18.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6769",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6769"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6770",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6770"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)18.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6025",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6025"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 5.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)03.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5213",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4906",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)56.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5218",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4845",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 53",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 53"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3496",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3496"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 9.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)59.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4755",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Herschel's Jewel Box"},
        {"Common Name 2", "Jewel Box"},
        {"Common Name 3", "kap Cru Cluster"},
        {"Common Name 4", "kappa Crucis Cluster"},
        {"New General Catalogue", "NGC 4755"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 4.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4852",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3572",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3572"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2056",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4938",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4836",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)16.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7278",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7278"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4718",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5197",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)19.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3114",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3114"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 4.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 35.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4439",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4439"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83832"},
        {"Wilson Evans Batten Catalogue", "WEB 8894"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)38.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5043",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5043"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7059",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7059"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4646",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-60, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6752",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6752"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 5.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)10.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5110",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)30.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 306491"},
        {"New General Catalogue", "NGC 3699"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2010",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)52.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5299",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5299"},
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)50.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5095",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)17.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1096",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1096"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)43.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2132",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2132"},
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)55.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6782",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6782"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5190",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 888",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 888"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)17.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3372",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Keyhole"},
        {"Common Name 2", "Car Nebula"},
        {"Common Name 3", "Carina Nebula"},
        {"Common Name 4", "eta Car Nebula"},
        {"Common Name 5", "Keyhole Nebula"},
        {"New General Catalogue", "NGC 3372"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 120.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)43.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3503",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3503"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)01.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1463",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1463"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)46.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1688",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1688"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)48.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5205",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)22.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5203",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1703",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1703"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4652",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1824",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1824"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5220",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7676",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7676"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)28.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5606",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5606"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5188",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5187",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)18.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4852",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4852"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 11.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4658",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)37.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5381",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5381"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 14.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5141",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)53.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4819",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)07.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2017",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4830",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)13.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4843",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4854",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4855",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1672",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1672"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4785",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)52.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4702",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)23.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4780",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)50.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2714",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2714"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6221",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6221"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)52.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5284",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5284"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)46.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6305",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6305"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1997",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2148",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2148"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2220",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Toby Jug Nebula"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)56.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2022",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5138",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5138"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-59, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6215",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6215"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4896",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 466",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 466"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4695",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)17.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4783",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4857",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4858",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2037",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)08.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4814",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4901",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4692",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3532",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3532"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 3.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 55.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6810",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6810"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)43.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2012",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)52.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3324",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3324"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 16.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)37.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2599",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)37.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2049",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)12.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4989",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 484",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 484"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4721",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)34.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5037",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)45.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4720",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4973",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)14.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81119"},
        {"Wilson Evans Batten Catalogue", "WEB 8704"},
        {"New General Catalogue", "NGC 2867"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 440",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 440"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)12.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 434",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 434"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)12.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3293",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3293"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 4.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 40.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4835",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4694",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4878",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)38.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1252",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1252"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)10.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4337",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4337"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1597",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4884",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-58, (int)07, 0)
    )
)
);
}
}

}
