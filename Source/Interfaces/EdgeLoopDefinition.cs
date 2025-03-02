namespace Oblikovati.API;

/// <summary>
/// The FaceDefinition represents a transient definition of a Face object.
/// </summary>
public interface EdgeLoopDefinition
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
    /// Property that returns the collection of EdgeUseDefinition objects associated with this EdgeLoopDefinition object.
    /// </summary>
    EdgeUseDefinitions EdgeUseDefinitions { get; }
}
