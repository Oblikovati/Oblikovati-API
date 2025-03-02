namespace Oblikovati.API;

/// <summary>
/// The ProjectAssetLibraries collection object provides access to the list of material and appearance libraries associated with a project.  Through the collection object you can add additional materials or appearances and access the specific library references.
/// </summary>
public interface ProjectAssetLibraries : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ProjectAssetLibrary object from the collection.
    /// </summary>
    ProjectAssetLibrary this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that adds a reference to a material library to the project.
    /// </summary>
    /// <param name="LibraryFilename">Input String that specifies the full filename to the .asdklib file that contains the material and/or appearance definitions.</param>
    /// <returns></returns>
    [PreserveSig]
    ProjectAssetLibrary Add([In] [MarshalAs(UnmanagedType.BStr)] string LibraryFilename);
}
