namespace Oblikovati.API;

/// <summary>
/// The AngleExtent object provides access to the information that defines the extent for a feature using an angle.
/// </summary>
public interface AngleExtent
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
    /// Property that returns the parameter that controls the sweep angle of the revolution.
    /// </summary>
    Parameter Angle { get; }
    /// <summary>
    /// Property that indicates the distance direction of the feature. Valid input is kPositiveExtentDirection, kNegativeExtentDirection, or kSymmetricExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.
    /// </summary>
    PartFeatureExtentDirectionEnum Direction { get; set; }
}
