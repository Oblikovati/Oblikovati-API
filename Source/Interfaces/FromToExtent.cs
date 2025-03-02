namespace Oblikovati.API;

/// <summary>
/// The FromToExtent object provides access to the information that defines the extent for a feature using 'from' and 'to' faces to define the extent.
/// </summary>
public interface FromToExtent
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
    /// Property that gets and sets the face that defines the 'to' extents of the feature.
    /// </summary>
    object ToFace { get; set; }
    /// <summary>
    /// Property that gets and sets whether the 'to face' should be extended to contain the extents of the feature. This property is not valid for every surface type.
    /// </summary>
    bool ExtendToFace { get; set; }
    /// <summary>
    /// Property that gets and sets the face that defines the 'from' extents of the feature.
    /// </summary>
    object FromFace { get; set; }
    /// <summary>
    /// Property that gets and sets whether the 'from face' should be extended to contain the extents of the feature. This property is not valid for every surface type.
    /// </summary>
    bool ExtendFromFace { get; set; }
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
