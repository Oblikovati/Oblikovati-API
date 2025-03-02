namespace Oblikovati.API;

/// <summary>
/// The SculptSurface object provides access to a sculpt surface and its associated direction. The surface defines a boundary of the sculpt feature and the associated direction defines the side of the surface used to create the sculpt feature.
/// </summary>
public interface SculptSurface
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the direction associated with the surface.
    /// </summary>
    PartFeatureExtentDirectionEnum Direction { get; set; }
    /// <summary>
    /// Gets and sets a boundary surface for the sculpt feature.
    /// </summary>
    object Surface { get; set; }
}
