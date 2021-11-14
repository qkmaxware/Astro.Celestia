using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;
using Qkmaxware.Numbers;

namespace Qkmaxware.Astro.Celestia {

public static partial class PlanetCatalogue {

    public static readonly Planet SaturnJ2000 = new Planet(
        name: "Saturn",
        mass: Mass.Kilograms(new Scientific(5.683, 26)),
        radius: Length.Kilometres(58232),
        epoch: Moment.J2000,
        elements: KeplerElements.FromMean(
            a:  AstronomicalLength.AU(9.53707032),
            i:  Angle.Degrees(2.48446), 
            e:  0.05415060, 
            @Ω: Angle.Degrees(113.71504), 
            w: Angle.Degrees(92.43194), 
            M: Angle.Degrees(49.94432)
        )
    );

}

}