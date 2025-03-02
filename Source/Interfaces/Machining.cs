namespace Oblikovati.API;

/// <summary>
/// Allows editing for environment-specific features.
/// </summary>
public interface Machining
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
    /// Method that activates this object for editing by the user.
    /// </summary>
    [PreserveSig]
    void Edit();
    /// <summary>
    /// Method that causes the current editing environment to be closed and the user interface to return to weldment editing environment.
    /// </summary>
    [PreserveSig]
    void ExitEdit();
}
