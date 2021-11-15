using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class DeepSkyObjectCatalogue {
private static void _addNGC_6() {
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1082",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6944",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6944"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 485",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 485"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5554",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5554"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5564",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5564"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 190",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 190"},
        {"New General Catalogue 2", "NGC 190N"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)38.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2394",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2394"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2775",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2775"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)10.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 601",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)18.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4180",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4180"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)13.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5552",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5552"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5558",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)19.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 602",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)18.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4342",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4342"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3256",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4342"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3267",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5537",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5537"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5563",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5563"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)20.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1025",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6384",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6384"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)32.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 332",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 332"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3260",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4341"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4341",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4341"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1089",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4309",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4309"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3404",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3521",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3531",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3526"},
        {"New General Catalogue 2", "NGC 3531"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3526",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3526"},
        {"New General Catalogue 2", "NGC 3531"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)07.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5210",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5210"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)32.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2773",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2773"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)09.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4235",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4235"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4246",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4246"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3113",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4246"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3259",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2777",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2777"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4191",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4191"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)13.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3098",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4235"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1112",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 638",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 638"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3441",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3441"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)52.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4570",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4570"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4247",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4247"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3257",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5645",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5645"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7455",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7455"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7564",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7564"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)15.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 997",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 997"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)37.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5212",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5212"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5942",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5942"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 448",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4365",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4365"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4612",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4612"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5208",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5208"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)32.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5944",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5944"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)31.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1634",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1634"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5209",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5209"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5941",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5941"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7818",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7818"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1633",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1633"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5239",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5239"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5549",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5549"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)18.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7577",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7577"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)17.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6933",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)33.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6934",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6934"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7583",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7583"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 182",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)59.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6106",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6106"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7605",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 998",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 998"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)37.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5519",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5519"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)14.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5570",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5570"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7604",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7604"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4370",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4370"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4366",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4366"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 789",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7816",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7816"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 748",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4224",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4224"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4334",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4334"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5940",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5940"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2485",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2485"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5538",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5538"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2499",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2499"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 61",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3624",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3624"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1197",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)08.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3322",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5542",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5542"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5546",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5546"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7503",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7503"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5931",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5931"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)29.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1122",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5931"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)29.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7499",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7499"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7501",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7501"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)10.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1590",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1590"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4233",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4233"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3133",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3537",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5543",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5543"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2254",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2254"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)36.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5514",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5514"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4560",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4560A"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4623",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4623"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 13",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2074",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3462",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3462"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)55.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4276",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "FAUST V023"},
        {"New General Catalogue", "NGC 4276"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3191",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4466",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4466"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4526",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4526"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5418",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5418"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5920",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5920"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 55",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)51.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2894",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2894"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4610",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5405",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5405"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)01.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1772",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5919",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5919"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)21.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7804",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)01.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6969",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6969"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)48.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4353",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4353"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3266",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4353"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4223",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2830",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3150",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3265",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4353"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2758",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3281",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4470",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4470"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5075",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5075"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 840",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 840"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)10.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5059",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5059"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)17.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3131",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4518",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4518"},
        {"New General Catalogue 2", "NGC 4518A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3666",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7781",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7781"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)53.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3132",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3148",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3417",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7778",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7778"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)53.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7779",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7779"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)53.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 540",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)30.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 250",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 250"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4471",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4471"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6828",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6828"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)50.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2882",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2882"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3436",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3436"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3843",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3843"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4416",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4416"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5071",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5071"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)18.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5769",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5769"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)52.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3271",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 827",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 827"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3617",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6063",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6063"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5223",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)29.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7782",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7782"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)53.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 652",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 652"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)40.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2491",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2491"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5309",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+07, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4467",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4467"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4472",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 49"},
        {"New General Catalogue", "NGC 4472"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2526",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2526"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2496",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2496"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2228",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)07.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4465",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4465"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4791",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4791"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5417",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5417"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3123",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4795",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4795"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4796",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4796"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7611",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7611"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4492",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4492"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3438",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4492"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5487",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5487"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)09.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5665",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5665"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)32.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1107",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1107"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)49.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3716",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3719",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6049",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)05.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6917",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6917"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7780",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7780"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)53.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4434",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4434"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4464",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4464"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7617",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7617"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5535",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5535"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5539",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5539"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4029",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4029"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)00.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4318",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4318"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4535",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4535"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7619",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7619"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7626",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7626"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)20.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7631",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7631"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1707",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3130",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4803",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4803"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5983",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5983"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2107",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 658",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5621",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7586",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7586"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)07.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5528",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5528"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5790",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5790"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2731",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2731"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3427",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3427"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5681",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5681"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 257",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 257"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)48.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5997",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5997"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)47.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7837",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7837"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7838",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7838"},
        {"New General Catalogue 2", "NGC 7838E"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)07.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 766",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 766"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7608",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7608"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7621",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7621"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7834",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7834"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)06.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3754",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)46.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7830",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2251",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2251"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4488",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4488"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)30.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4598",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4598"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2757",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1414",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1462",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7615",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7615"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7623",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7623"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)20.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7835",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7835"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)06.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4415",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4415"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5080",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5080"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7451",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7451"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3111",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1116",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)21.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2906",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2906"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2825",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1220",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)29.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 791",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 791"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3417",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3417"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3863",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3863"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4698",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4698"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)48.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5106",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1721",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)41.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7427",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7427"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)57.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2809",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3273",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4356"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7840",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)07.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2412",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)34.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3874",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4356",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4356"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7612",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7612"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2508",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2508"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3425",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3425"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3439",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3439"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2749",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1137",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)48.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3388",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)48.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2871",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5511",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5511"},
        {"New General Catalogue 2", "NGC 5511A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)13.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 180",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 180"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)38.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2039",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2039"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)44.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1517",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1517"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)09.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4519",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4519"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2743",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1046",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1046"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2828",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7362",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7362"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1695",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1044",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1044"},
        {"New General Catalogue 2", "NGC 1044A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2261",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "HUBBLE'S VAR NEB"},
        {"Common Name 2", "Hubble's Nebula"},
        {"Geneva Identification System", "GEN# +0.00801427"},
        {"Wilson Evans Batten Catalogue", "WEB 6394"},
        {"New General Catalogue", "NGC 2261"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)39.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 502",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)22.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2740",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3352",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4469",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4469"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 720",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7675",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7675"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)28.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1863",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)54.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7674",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7674"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)27.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2063",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2063"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)46.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2747",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2748",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4621",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7430",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7430"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1865",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)55.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 776",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7040",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7040"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)13.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 718",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)39.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4411",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4411"},
        {"New General Catalogue 2", "NGC 4411A"},
        {"New General Catalogue 3", "NGC 4411a"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3339",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4411"},
        {"New General Catalogue 2", "NGC 4411A"},
        {"New General Catalogue 3", "NGC 4411a"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7469",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7469"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)03.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7634",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7634"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1551",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1723",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2783",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3343",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5248",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5248"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7100",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7100"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7101",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7101"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5283",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)03.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2189",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5482",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5482"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)08.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5411",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5411"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2854",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3134",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5100",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5100"},
        {"New General Catalogue 2", "NGC 5100a"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)21.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7529",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7529"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2831",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 699",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3211",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4307A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+08, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 495",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)08.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 719",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)40.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3161",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3162",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2869",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2876",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2879",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2924",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)32.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3086",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4410",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4410"},
        {"New General Catalogue 2", "NGC 4410A"},
        {"New General Catalogue 3", "NGC 4410W"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 790",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4410C"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4483",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4483"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 724",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4307",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4307"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6219",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6219"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)46.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 502",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 502"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)22.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2866",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 676",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)12.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2850",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 722",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3117",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3430",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)30.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3709",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37882"},
        {"Wilson Evans Batten Catalogue", "WEB 5294"},
        {"New General Catalogue", "NGC 2022"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2836",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 696",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2867",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3076",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 201",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)07.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1825",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)38.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2849",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2857",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2863",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 698",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2868",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2905",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3160",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 203",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)07.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2859",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2865",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3245",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 34",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2808",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2853",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3139",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 523",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)53.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2741",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2817",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3156",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3517",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3777",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 202",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)07.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2811",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4522",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4522"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3332",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3332"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3876",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3876"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 489",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 489"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3770",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 199",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)06.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1778",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)06.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3328",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3477",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3477"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2770",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3485",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183932"},
        {"Wilson Evans Batten Catalogue", "WEB 16822"},
        {"New General Catalogue", "NGC 6804"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5291",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)13.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3706",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3798",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)48.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7601",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7601"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 473",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3429",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3429"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3163",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 532",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 532"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)25.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3049",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3049"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)54.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4451",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4451"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 198",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)06.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3428",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3428"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3476",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3476"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)58.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3705",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3705"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4360",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4360"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3274",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4360B"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1867",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3158",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2433",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2433"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4315",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 518",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 518"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5469",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5469"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1035",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1868",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3480",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2796",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4316",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4316"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 900",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5423",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5423"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1078",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)56.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1849",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3490",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3490"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)59.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3103",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5463",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5463"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)06.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1079",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)56.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2887",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3705A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3493",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5431",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5431"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1092",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)07.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2511",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2511"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)02.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2641",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3692",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3692"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3097",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3151",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3400",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3487",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2513",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2513"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)02.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2682",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2702",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3170",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4424",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4424"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3366",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7579",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7579"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7584",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7584"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 509",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 509"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)23.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 548",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)38.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3342",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3090",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 793",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4445",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4445"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5424",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5424"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1044",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2793",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3350",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5416",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5416"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5434",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5434"},
        {"New General Catalogue 2", "NGC 5434A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 505",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 505"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2913",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2913"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)34.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3085",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3088",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1040",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)40.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1398",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2510",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2510"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)02.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2707",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3223",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7609",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7609"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3118",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5409",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5409"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1873",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2939",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2939"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5437",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5437"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4365",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1205",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)14.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 524",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 524"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3167",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 516",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 516"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2459",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2459"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)52.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2790",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4119",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4124"},
        {"New General Catalogue 2", "NGC 4119"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)07.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3071",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3072",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4578",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4578"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3190",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5161",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)05.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4207",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4207"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3124",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4417",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4417"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5436",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5436"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2940",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2940"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2637",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)13.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3129",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 975",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 975"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 559",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)44.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3106",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3255",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3518",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5438",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5438"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5446",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5446"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)05.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2712",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2402",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2402"},
        {"New General Catalogue 2", "NGC 2402SW"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2639",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)13.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2806",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2842",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7648",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7648"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)23.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1486",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7648"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)23.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2657",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2657"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2750",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2814",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2855",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7587",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7587"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 525",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 525"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5125",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5125"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4779",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4779"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 404",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)13.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3466",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3466"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3357",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3467",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3467"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2885",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3318",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2852",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4442",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4442"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2680",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2676",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3175",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3634",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2803",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)24.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 816",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)46.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3764",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 817",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)46.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6081",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6081"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)13.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1202",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6081"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)13.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6930",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6930"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)33.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2264",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "XMAS TREE CL"},
        {"Common Name 2", "Christmas Tree Cluster"},
        {"New General Catalogue", "NGC 2264"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 3.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 60.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2753",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3633",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5669",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5669"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1325",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 102",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 383",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)39.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2169",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 25.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2907",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1326",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)33.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6972",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6972"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)50.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7595",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7595"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2888",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3562",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6927",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6927"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 101",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 114",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6928",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6928"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7743",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7743"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5414",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5414"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1771",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)02.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2756",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2878",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1770",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)02.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3130",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3130"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)08.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 692",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2895",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)31.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3037",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)12.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3374",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3412",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 522",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 522"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3043",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3013",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4380",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4380"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 447",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 596",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)10.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4012",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4012"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1199",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)10.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2941",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3092",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3328",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183889"},
        {"Wilson Evans Batten Catalogue", "WEB 16818"},
        {"New General Catalogue", "NGC 6803"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2930",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3236",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3602",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2685",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)17.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2937",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1429",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2914",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2914"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)34.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2611",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)52.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2643",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2862",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2912",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2912"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2911",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2911"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)33.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3433",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3433"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2780",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)22.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4608",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4608"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7616",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7616"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2245",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2245"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2672",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2673",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2687",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3833",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3833"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3069",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3525",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3767",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7610",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7610"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 137",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 137"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)31.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2801",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3025",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)10.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4596",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4596"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3714",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3444",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3444"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)53.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 735",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3773",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7528",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7528"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)14.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5307",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7594",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7594"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2648",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2820",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3174",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3468",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7132",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7132"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)47.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7212",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7212"},
        {"New General Catalogue 2", "NGC 7212a"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)07.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2935",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5562",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5562"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)20.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5306",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2312",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2312"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2642",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3848",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3822"},
        {"New General Catalogue 2", "NGC 3848"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5305",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2919",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2919"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3822",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3822"},
        {"New General Catalogue 2", "NGC 3848"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3825",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3825"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3383",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3724",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5988",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5988"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)44.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2829",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2921",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3852",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3732",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1478",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7594"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2837",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3817",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3817"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)41.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2247",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2247"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3240",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 35",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)37.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6709",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6709"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 13.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 161",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)48.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3070",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3070"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 584",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)59.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3819",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3819"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3011",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4124"},
        {"New General Catalogue 2", "NGC 4119"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3607",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)38.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3690",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3712",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6724",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6724"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4124",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4124"},
        {"New General Catalogue 2", "NGC 4119"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3319",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3820",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3820"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3275",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 665",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 665"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2141",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2141"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)03.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 446",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)31.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2167",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3069",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3069"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 580",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3069"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 663",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2742",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4390",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4390"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3320",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3647",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 14",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 578",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 666",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)01.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3608",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5666",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5666"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 95",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 95"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)22.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 577",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3492",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3492"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2634",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)13.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 162",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)48.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3638",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6988",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6988"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)55.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7328",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7328"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 7",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 156",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)45.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 664",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)00.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2653",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2932",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)33.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4320",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4320"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3438",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3438"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2638",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)13.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3686",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2892",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3220",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4078",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4078"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)04.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4107",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)06.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3199",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4368",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3425",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 53",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)50.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2991",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)05.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4083",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4083"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 840",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 552",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)41.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2816",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2874",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2899",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4325",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4325"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3361",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3803",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 154",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7542",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7542"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3447",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3693",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4082",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4082"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3074",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2939",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)35.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4398",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7794",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7794"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2002",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1474"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3547",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3547"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)09.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2724",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)19.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7791",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2644",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2692",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 727",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)44.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3427",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4482"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7366",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7366"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)44.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7742",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7742"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)44.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1029",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1029"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3416",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4482",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4482"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)30.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3704",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1196",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)08.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1243",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)10.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7519",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7519"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)12.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3839",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3839"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5532",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5532"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)16.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1236",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1236"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)11.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2839",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3284",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7193",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7193"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)03.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1028",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1028"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 526",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3869",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3869"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3107",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 75",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1024",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1024"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)39.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4067",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4067"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7374",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7374"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)46.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4178",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4178"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3042",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4178"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3371",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2259",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2259"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3217",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3217"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3347",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3702",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5531",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5531"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3727",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 569",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2883",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3490",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4733",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4733"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7569",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7569"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1662",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1662"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)48.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5160",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2917",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3548",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3801",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 606",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3217"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3625",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 557",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)44.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3499",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4694",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4694"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+10, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 821",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 821"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)08.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 595",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)09.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2640",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5174",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5174"},
        {"New General Catalogue 2", "NGC 5175"},
        {"New General Catalogue 3", "NGC 5162"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5175",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5174"},
        {"New General Catalogue 2", "NGC 5175"},
        {"New General Catalogue 3", "NGC 5162"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 613",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)27.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3188",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7500",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7500"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)10.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 576",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2990",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3701",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7347",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7347"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)39.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 612",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)27.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2674",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4641",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4641"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6525",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6525"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7370",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7370"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)45.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2728",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2728"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2984",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2984"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)43.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 556",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2984"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3040",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)12.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3510",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 193",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2725",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2725"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)01.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 615",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3506",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3506"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3792",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)48.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7346",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7346"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3578",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3743",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2701",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4429",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4429"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)27.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3790",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2649",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7372",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7372"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 569",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 569"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2846",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3566",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5251",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2720",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2720"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3012",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)08.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3187",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3711",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 622",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3279"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3560",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4503",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4503"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4554",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3652",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4660",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4660"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 994",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)18.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1817",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)33.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3279",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3279"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2681",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5191",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5191"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7190",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7190"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)03.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4352",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4352"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3694",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3698",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5736",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5736"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1424",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4568",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4568"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4762",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4762"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)52.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2813",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3470",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4567",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4567"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5162",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5174"},
        {"New General Catalogue 2", "NGC 5175"},
        {"New General Catalogue 3", "NGC 5162"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 993",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6858",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6858"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)03.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 511",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 511"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1206",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1483",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7638"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)22.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7638",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7638"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)22.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4528",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4528"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)34.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4754",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4754"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1480",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2678",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2678"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3038",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3173",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3437",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1513",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1526",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)01.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3666",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3666"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)24.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3346",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3483",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7593",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7593"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7607",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1485",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7639",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)22.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5627",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5627"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4330",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4330"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5165",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5165"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1484",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3524",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3524"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2792",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2851",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3418",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3481",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3653",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7630",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7630"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3016",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7015",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7015"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)05.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2872",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2872"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)25.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2874",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2874"},
        {"New General Catalogue 2", "NGC 2875"},
        {"New General Catalogue 3", "NGC 2874 75"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2875",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2874"},
        {"New General Catalogue 2", "NGC 2875"},
        {"New General Catalogue 3", "NGC 2874 75"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2822",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3413",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4564",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4564"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4638",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4638"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4637",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4637"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4667",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7683",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7683"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 63",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 63"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 112",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)26.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2871",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)25.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2873",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2873"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2636",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2844",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1842",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2635",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)13.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2909",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3810",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3810"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)41.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3261",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7774",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7774"},
        {"New General Catalogue 2", "NGC 7774A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4491",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4491"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3446",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3068",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4299",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4299"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3665",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2827",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3079",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4294",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4294"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 673",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 673"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)48.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2807",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2812",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7390",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7390"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2897",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4649",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 60"},
        {"New General Catalogue", "NGC 4649"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 8.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6368",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6368"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)27.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7384",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7384"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)49.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2886",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3356",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3431",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)30.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4647",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4647"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7389",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7389"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2633",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)13.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3797",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6738",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6738"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7383",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7383"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)49.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7385",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7385"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)49.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2416",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2416"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4497",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4497"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3452",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3572",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5178",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5178"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 222",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4992",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4992"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)09.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7387",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7387"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 990",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 990"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)36.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3159",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3358",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4621",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 59"},
        {"New General Catalogue", "NGC 4621"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2632",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)13.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3542",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 683",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 683"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)49.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2916",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6837",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6837"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3351",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 95"},
        {"New General Catalogue", "NGC 3351"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2716",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2797",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)24.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4371",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4371"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)24.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4688",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)08.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7386",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7386"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)50.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2665",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2912",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)32.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3128",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3239",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3604",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3684",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7305",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7305"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2746",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3192",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3196",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)21.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3775",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5171",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5171"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7388",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7388"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3028",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)10.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3209",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4452",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4452"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3670",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 809",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3672",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5179",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5179"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5956",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5956"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)35.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3573",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5083",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1168",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1168"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2651",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2651"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2670",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3381",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3467",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3722",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5176",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5176"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5115",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)30.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7353",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7353"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4313",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4313"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3331",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)26.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3466",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5177",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5177"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6132",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6132"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)23.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5177",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)11.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 62",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2682",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 67"},
        {"New General Catalogue", "NGC 2682"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)50.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3368",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 96"},
        {"New General Catalogue", "NGC 3368"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)46.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2942",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4579",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 58"},
        {"New General Catalogue", "NGC 4579"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)37.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4676",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)02.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 57",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)54.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3305",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)25.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4691",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)08.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1166",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1166"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3127",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)18.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3558",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2870",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 18.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3760",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)46.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 889",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5647",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5647"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)30.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 530",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)15.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2958",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2958"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)40.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 620",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2698",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3408",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3461",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)32.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4607",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4607"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3756",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)46.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 815",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)46.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5456",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5456"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5782",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5782"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7641",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7641"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)22.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2645",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2705",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3577",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7348",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7348"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)40.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7627",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)22.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2699",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2739",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)21.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4606",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4606"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)41.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5644",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5644"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)30.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1038",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)39.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2265",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2265"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)+11, (int)56, 0)
    )
)
);
}
}

}
