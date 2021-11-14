using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;
using Qkmaxware.Numbers;

namespace Qkmaxware.Astro.Celestia {

public static partial class PlanetCatalogue {

    public static IEnumerable<Planet> SolSystemAtJ2000 {
        get {
            yield return EarthJ2000;
            yield return MercuryJ2000;
            yield return VenusJ2000;
            yield return MarsJ2000;
            yield return JupiterJ2000;
            yield return SaturnJ2000;
            yield return UranusJ2000;
            yield return NeptuneJ2000;
        }
    }

}

}