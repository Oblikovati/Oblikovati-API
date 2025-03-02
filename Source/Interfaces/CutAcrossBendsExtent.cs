namespace Oblikovati.API;

/// <summary>
/// The CutAcrossBendsExtent object represents the extent definition for a sheet metal cut feature that cuts across the bends of the part.
/// </summary>
public interface CutAcrossBendsExtent
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
    /// Property that returns the parameter controlling the depth of the cut.
    /// </summary>
    Parameter Distance { get; }
}
