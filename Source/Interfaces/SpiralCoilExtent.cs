namespace Oblikovati.API;

/// <summary>
/// The SpiralCoilExtent object provides access to the information that defines the variables for a spiral coil feature.
/// </summary>
public interface SpiralCoilExtent
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
    /// Property that returns the parameter that controls the pitch of the coil feature.
    /// </summary>
    Parameter Pitch { get; }
    /// <summary>
    /// Property that returns the parameter that controls the number of revolutions of the coil feature.
    /// </summary>
    Parameter Revolution { get; }
}
