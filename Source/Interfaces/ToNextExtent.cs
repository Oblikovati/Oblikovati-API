namespace Oblikovati.API;

/// <summary>
/// The ToNextExtent object provides access to the information that defines the extent for a feature that's extent is determined by extruding up to the closest set of faces that the feature completely intersects.
/// </summary>
public interface ToNextExtent
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent PartFeature of the definition.
    /// </summary>
    PartFeature Parent { get; }
    /// <summary>
    /// Property that gets and sets the direction of the feature. Valid \input is kPositiveExtentDirection or kNegativeExtentDirection. kPositiveExtentDirection defines the extrusion direction to be in the same direction as the normal of the sketch plane.
    /// </summary>
    PartFeatureExtentDirectionEnum Direction { get; set; }
    /// <summary>
    /// Gets and sets the SurfaceBody that specifies the solid or the surface on which to terminate the revolution.
    /// </summary>
    SurfaceBody Terminator { get; set; }
}
