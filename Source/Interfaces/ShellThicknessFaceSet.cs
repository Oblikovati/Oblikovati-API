namespace Oblikovati.API;

/// <summary>
/// The ShellThicknessFaceSet object provides access to the faces and their associated thickness for a shell.
/// </summary>
public interface ShellThicknessFaceSet
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the shell boundary relative to part face.
    /// </summary>
    FaceCollection Faces { get; set; }
    /// <summary>
    /// Property that returns the parameter that controls the thickness of the faces in the face set. This property will return Nothing if the shell feature has not been created yet.
    /// </summary>
    Parameter Thickness { get; }
    /// <summary>
    /// Method that deletes the face set.
    /// </summary>
    [PreserveSig]
    void Delete();
}
