using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;
using Qkmaxware.Numbers;

namespace Qkmaxware.Astro.Celestia {

public static partial class PlanetCatalogue {

    public static readonly Planet MarsJ2000 = new Planet(
        name: "Mars",
        mass: Mass.Kilograms(new Scientific(6.39, 23)),
        radius: Length.Kilometres(3389.5),
        epoch: Moment.J2000,
        elements: KeplerElements.FromMean(
            a:  AstronomicalLength.AU(1.52366231),
            i:  Angle.Degrees(1.85061), 
            e:  0.09341233, 
            @Ω: Angle.Degrees(49.57854), 
            w: Angle.Degrees(336.04084), 
            M: Angle.Degrees(355.45332)
        )
    );

}

}