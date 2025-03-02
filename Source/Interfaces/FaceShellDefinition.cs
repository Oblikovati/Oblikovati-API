namespace Oblikovati.API;

/// <summary>
/// The FaceShellDefinition represents a transient definition of a FaceShell object.
/// </summary>
public interface FaceShellDefinition
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
    /// Property that returns the collection of FaceDefinition objects associated with this FaceShellDefinition object.
    /// </summary>
    FaceDefinitions FaceDefinitions { get; }
    /// <summary>
    /// Gets&nbsp;the collection of WireDefinition objects associated with this SurfaceBodyDefinition object. The primary use of the WireDefinitions collection is to create new WireDefinition objects.
    /// </summary>
    WireDefinitions WireDefinitions { get; }
}
