using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;
using Qkmaxware.Numbers;

namespace Qkmaxware.Astro.Celestia {

public static partial class PlanetCatalogue {

    public static readonly Planet MercuryJ2000 = new Planet(
        name: "Mercury",
        mass: Mass.Kilograms(new Scientific(3.285, 23)),
        radius: Length.Kilometres(2439.7),
        epoch: Moment.J2000,
        elements: KeplerElements.FromMean(
            a:  AstronomicalLength.AU(0.38709893),
            i:  Angle.Degrees(7.00487), 
            e:  0.20563069, 
            @Ω: Angle.Degrees(48.33167), 
            w: Angle.Degrees(77.45645), 
            M: Angle.Degrees(252.25084)
        )
    );

}

}