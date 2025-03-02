namespace Oblikovati.API;

/// <summary>
/// The ProjectPath object represents a folder path for a library, workspace or a workgroup.
/// </summary>
public interface ProjectPath
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-write property that gets and sets the name of the folder path.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the parent DesignProject object.
    /// </summary>
    DesignProject Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the folder path associated with this object.
    /// </summary>
    string Path { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that deletes this path from the collection.
    /// </summary>
    [PreserveSig]
    void Delete();
}
