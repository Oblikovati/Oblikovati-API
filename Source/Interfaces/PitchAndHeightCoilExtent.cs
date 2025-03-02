namespace Oblikovati.API;

/// <summary>
/// The PitchAndHeightExtent object provides access to the information that defines the variables for a coil feature created using pitch and height values.
/// </summary>
public interface PitchAndHeightCoilExtent
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
    /// Property that indicates the pitch of the coil feature.
    /// </summary>
    Parameter Pitch { get; }
    /// <summary>
    /// Property that gets the height of the coil feature.
    /// </summary>
    Parameter Height { get; }
    /// <summary>
    /// Property that indicates the taper angle of the coil feature.
    /// </summary>
    Parameter TaperAngle { get; }
}
