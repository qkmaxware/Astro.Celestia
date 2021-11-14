using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {

/// <summary>
/// Basic list of classes of deep sky objects
/// </summary>
public enum DeepSkyObjectClass {
    Galaxy,
    Nebula,
    StarCluster,
    Asterism,
    Other
}

/// <summary>
/// Deep Sky Object data class
/// </summary>
public class DeepSkyObject : CelestialEntity {
    /// <summary>
    /// Basic classification of deep sky object type
    /// </summary>
    /// <value>classification</value>
    public DeepSkyObjectClass Class {get; private set;}
    /// <summary>
    /// Celestial coordinates of this planet around its star
    /// </summary>
    /// <returns>coordinates</returns>
    public EquatorialCoordinate Coordiantes {get; private set;}
    /// <summary>
    /// Apparent magnitude of this star
    /// </summary>
    /// <value>apparent magnitude</value>
    public double? ApparentMagnitude {get; private set;}
    /// <summary>
    /// Angular diametre along longest edge
    /// </summary>
    /// <value>angular diametre</value>
    public Angle AngularDiametre {get; private set;}
    public DeepSkyObject(string primaryId, Dictionary<string,string> secondaryIds, DeepSkyObjectClass @class, double? apparentMagnitude, Angle diametre, EquatorialCoordinate coordinates) : base(primaryId, secondaryIds) {
        this.Coordiantes = coordinates;
        this.ApparentMagnitude = apparentMagnitude;
        this.AngularDiametre = diametre;
        this.Class = @class;
    }
}

}