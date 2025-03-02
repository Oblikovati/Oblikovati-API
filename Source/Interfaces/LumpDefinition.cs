namespace Oblikovati.API;

/// <summary>
/// The LumpDefinition represents a transient definition of a lump. A lump represents a bounded area of space. It can consist of one or more FaceShell objects.
/// </summary>
public interface LumpDefinition
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
    /// Property that returns the collection of FaceShellDefinitionobjects associated with this LumpDefinition object.
    /// </summary>
    FaceShellDefinitions FaceShellDefinitions { get; }
}
