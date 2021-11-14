using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;
using Qkmaxware.Numbers;

namespace Qkmaxware.Astro.Celestia {

public static partial class PlanetCatalogue {

    public static readonly Planet VenusJ2000 = new Planet(
        name: "Venus",
        mass: Mass.Kilograms(new Scientific(4.867, 24)),
        radius: Length.Kilometres(6051.8),
        epoch: Moment.J2000,
        elements: KeplerElements.FromMean(
            a:  AstronomicalLength.AU(0.72333199),
            i:  Angle.Degrees(3.39471), 
            e:  0.00677323, 
            @Ω: Angle.Degrees(76.68069), 
            w: Angle.Degrees(131.53298), 
            M: Angle.Degrees(181.97973)
        )
    );

}

}