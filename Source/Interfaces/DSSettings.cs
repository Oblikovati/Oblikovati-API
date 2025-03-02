namespace Oblikovati.API;

/// <summary>
/// The DSDegreeOfFreedom object represents a degree of freedom associated with a joint.
/// </summary>
public interface DSSettings
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
}
