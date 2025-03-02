namespace Oblikovati.API;

/// <summary>
/// WireDefinition Object.
/// </summary>
public interface WireDefinition
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
    /// Gets the collection of EdgeDefinition objects associated with this WireDefinition object.
    /// </summary>
    WireEdgeDefinitions WireEdgeDefinitions { get; }
}
