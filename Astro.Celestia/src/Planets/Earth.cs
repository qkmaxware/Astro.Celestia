using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;
using Qkmaxware.Numbers;

namespace Qkmaxware.Astro.Celestia {

public static partial class PlanetCatalogue {

    public static readonly Planet EarthJ2000 = new Planet(
        name: "Earth",
        mass: Mass.Kilograms(new Scientific(5.972, 24)),
        radius: Length.Kilometres(6371),
        epoch: Moment.J2000,
        elements: KeplerElements.FromMean(
            a: AstronomicalLength.AU(1),
            i: Angle.Degrees(0.00005),
            e: 0.01671022,
            Ω: Angle.Degrees(-11.26064),
            w: Angle.Degrees(102.94719),
            M: Angle.Degrees(100.46435)
        )
    );

}

}