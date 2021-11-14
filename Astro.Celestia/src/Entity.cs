using System.Collections.Generic;
using System.Collections.ObjectModel;
using Qkmaxware.Astro.Coordinates;

namespace Qkmaxware.Astro.Celestia {

/// <summary>
/// Base class for celestial entity data
/// </summary>
public class CelestialEntity {
    #region identifiers
    public string PrimaryIdentitfier {get; private set;}
    public ReadOnlyDictionary<string,string> SecondaryIdentifiers {get; private set;}
    #endregion
    
    /// <summary>
    /// The reference frame the object's coordinates are relative to
    /// </summary>
    /// <value>refrence frame</value>
    public object ReferenceFrame {get; set;}

    private static readonly object DefaultCoordianteFrame = new Coordinates.Frames.EquatorialGeocentric();

    /// <summary>
    /// Create a new celestial entity in the default ICRS reference frame
    /// </summary>
    /// <param name="primaryId">primary entity identifier</param>
    /// <param name="secondaryIds">collection of secndary identifiers</param>
    public CelestialEntity(string primaryId, Dictionary<string,string> secondaryIds) 
        : this(primaryId, secondaryIds, DefaultCoordianteFrame) {} 

    /// <summary>
    /// Create a new celestial entity in the given reference frame
    /// </summary>
    /// <param name="primaryId">primary entity identifier</param>
    /// <param name="secondaryIds">collection of secndary identifiers</param>
    /// <param name="reference">reference frame for cooordinates</param>
    public CelestialEntity(string primaryId, Dictionary<string,string> secondaryIds, object reference) {
        this.PrimaryIdentitfier = primaryId;
        this.SecondaryIdentifiers = new ReadOnlyDictionary<string, string>(secondaryIds ?? new Dictionary<string, string>());
        this.ReferenceFrame = reference;
    } 
}

}