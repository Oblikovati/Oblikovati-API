namespace Oblikovati.API;

/// <summary>
/// The LegacyDistanceHeightExtent is used by the FlangeFeature object when the 'Old Method' is specified in the Flange feature dialog.
/// </summary>
public interface LegacyDistanceHeightExtent
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
    /// Property that returns the parameter controlling the extent distance of the flange.
    /// </summary>
    Parameter Distance { get; }
    /// <summary>
    /// Gets and sets the direction of the flange.
    /// </summary>
    PartFeatureExtentDirectionEnum FlangeDirection { get; set; }
}
