using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;
using Qkmaxware.Numbers;

namespace Qkmaxware.Astro.Celestia {

public static partial class PlanetCatalogue {

    public static readonly Planet NeptuneJ2000 = new Planet(
        name: "Neptune",
        mass: Mass.Kilograms(new Scientific(1.024, 26)),
        radius: Length.Kilometres(24622),
        epoch: Moment.J2000,
        elements: KeplerElements.FromMean(
            a:  AstronomicalLength.AU(30.06896348),
            i:  Angle.Degrees(1.76917), 
            e:  0.00858587, 
            @Ω: Angle.Degrees(131.72169), 
            w: Angle.Degrees(44.97135), 
            M: Angle.Degrees(304.88003)
        )
    );

}

}