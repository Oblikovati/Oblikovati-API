namespace Oblikovati.API;

/// <summary>
/// The ProjectAssetLibrary object represents a reference in this project to a material or appearance library.
/// </summary>
public interface ProjectAssetLibrary
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the name of the library.&nbsp;This is the name displayed in the Projects dialog.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the parent DesignProject object.
    /// </summary>
    DesignProject Parent { get; }
    /// <summary>
    /// Read-only property that returns the full filename of the library file.
    /// </summary>
    string LibraryFilename { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that activates this material or appearance library.
    /// The user can override this and specify another library as the currently active library using the check boxes at the bottom of the material drop-down, as shown below, which will not change the project settings.
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Method that deletes this library reference from the collection.
    /// </summary>
    [PreserveSig]
    void Delete();
}
