using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;
using Qkmaxware.Numbers;

namespace Qkmaxware.Astro.Celestia {

public static partial class PlanetCatalogue {

    public static readonly Planet UranusJ2000 = new Planet(
        name: "Uranus",
        mass: Mass.Kilograms(new Scientific(8.681, 25)),
        radius: Length.Kilometres(25362),
        epoch: Moment.J2000,
        elements: KeplerElements.FromMean(
            a:  AstronomicalLength.AU(19.19126393),
            i:  Angle.Degrees(0.76986), 
            e:  0.04716771, 
            @Ω: Angle.Degrees(74.22988), 
            w: Angle.Degrees(170.96424), 
            M: Angle.Degrees(313.23218)
        )
    );

}

}