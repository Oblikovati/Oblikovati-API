namespace Oblikovati.API;

/// <summary>
/// The DistanceHeightExtent is used by the FlangeFeature object when the height extent type is defined as a distance extent.
/// </summary>
public interface DistanceHeightExtent
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
    /// <summary>
    /// Gets and set the how the height of the flange is defined when the height extent is a distance extent.
    /// </summary>
    HeightDatumTypeEnum HeightDatumType { get; set; }
}
