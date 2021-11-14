using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {

/// <summary>
/// Star data class
/// </summary>
public class Star : CelestialEntity {
    /// <summary>
    /// Celestial coordinates of this planet around its star
    /// </summary>
    /// <returns>coordinates</returns>
    public EquatorialCoordinate Coordiantes {get; private set;}
    /// <summary>
    /// Proper motion of this star's coordiantes
    /// </summary>
    /// <returns>proper motion</returns>
    public ProperMotion CoodinateProperMotion {get; private set;}
    /// <summary>
    /// Visual magnitude of this star
    /// </summary>
    /// <value>visual magnitude</value>
    public double? VisualMagnitude {get; private set;}
    /// <summary>
    /// Colour index of the star (BV)
    /// </summary>
    /// <value>colour index</value>
    public double? BvColourIndex {get; private set;}
    public Star(string primaryId, Dictionary<string,string> secondaryIds, double? visualMagnitude, double? bvColour, EquatorialCoordinate coordinates, ProperMotion motion) : base(primaryId, secondaryIds) {
        this.Coordiantes = coordinates;
        this.CoodinateProperMotion = motion;
        this.VisualMagnitude = visualMagnitude;
        this.BvColourIndex = bvColour;
    }
}

}