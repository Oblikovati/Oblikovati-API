namespace Oblikovati.API;

/// <summary>
/// The ToExtent object defines the feature extent type where the feature extent is defined up to a specified entity.
/// </summary>
public interface ToExtent
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object ToFace { get; set; }
    /// <summary>
    /// Gets and sets the entity that defines the 'to' extents of the feature.
    /// </summary>
    object ToEntity { get; set; }
    /// <summary>
    /// Property that gets and sets whether the plane defined by the 'to entity' should be extended to contain the extents of the profile.
    /// </summary>
    bool ExtendToFace { get; set; }
    /// <summary>
    /// Gets and sets whether the feature terminates on the nearest valid face when there are multiple options for valid termination faces.
    /// </summary>
    bool MinimumSolution { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SolutionDirectionReversed { get; set; }
    /// <summary>
    /// Gets and sets the direction of the feature.
    /// </summary>
    PartFeatureExtentDirectionEnum Direction { get; set; }
}
