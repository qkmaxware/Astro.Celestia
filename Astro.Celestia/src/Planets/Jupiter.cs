using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;
using Qkmaxware.Numbers;

namespace Qkmaxware.Astro.Celestia {

public static partial class PlanetCatalogue {

    public static readonly Planet JupiterJ2000 = new Planet(
        name: "Jupiter",
        mass: Mass.Kilograms(new Scientific(1.898, 27)),
        radius: Length.Kilometres(69911),
        epoch: Moment.J2000,
        elements: KeplerElements.FromMean(
            a:  AstronomicalLength.AU(5.20336301),
            i:  Angle.Degrees(1.30530), 
            e:  0.04839266, 
            @Ω: Angle.Degrees(100.55615), 
            w: Angle.Degrees(14.75385), 
            M: Angle.Degrees(34.40438)
        )
    );

}

}