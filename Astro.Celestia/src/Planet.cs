using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {

/// <summary>
/// Planetary data class
/// </summary>
public class Planet : CelestialEntity {
    /// <summary>
    /// Mass of the planet
    /// </summary>
    /// <value>mass</value>
    public Mass Mass {get; private set;}

    /// <summary>
    /// Approximate planet radius
    /// </summary>
    /// <value>Approximate radius</value>
    public Length Radius {get; private set;}

    /// <summary>
    /// Approximate planetary diametre
    /// </summary>
    /// <returns>Approximate diametre</returns>
    public Length Diametre() => 2 * Radius;

    /// <summary>
    /// Epoch at which the oribital elements are relative to
    /// </summary>
    /// <returns>epoch</returns>
    public Moment Epoch {get; private set;}
    /// <summary>
    /// Orbital elements of this planet around its star
    /// </summary>
    /// <returns>Keplerian orbital elements</returns>
    public KeplerElements OrbitalElements {get; private set;}

    /// <summary>
    /// Approximate apparent radius as viewed from the given distance
    /// </summary>
    /// <param name="atDistance">observation distance</param>
    /// <returns>Approximate apparent size</returns>
    public Angle ApparentRadius(Length atDistance) => 2 * Angle.Atan2((double)Radius.TotalKilometres(), (double)atDistance.TotalKilometres());

    public Planet(string name, Mass mass, Length radius, Moment epoch, KeplerElements elements, Dictionary<string,string> otherNames = null) : base(name, otherNames){
        this.Epoch = epoch;
        this.Mass = mass;
        this.Radius = radius;
        this.OrbitalElements = elements;
    }
}

}