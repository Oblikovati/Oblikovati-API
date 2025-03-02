namespace Oblikovati.API;

/// <summary>
/// The AssetLibraries collection object provides access to the various asset libraries and also supports opening and migrating existing libraries, and creating new libraries.  A library can contain both appearance and physical material assets.
/// </summary>
public interface AssetLibraries : IEnumerable
{
    /// <summary>
    /// Read-only property returning kAssetLibrariesObject indicating this object’s type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-only property that returns the specified AssetLibrary object from the collection.
    /// </summary>
    AssetLibrary Item { get; }
    /// <summary>
    /// Method that creates a new asset library. The newly created AssetLibrary object is returned. The library can contain both appearance and material assets.
    /// </summary>
    /// <param name="FullFileName">The full filename of the library to create.  This must be the full path and the filename, including the .adsklib extension.  For example: “C:\MyLibs\Acme.adsklib”</param>
    /// <returns></returns>
    [PreserveSig]
    AssetLibrary Add([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that open an existing asset library. The opened AssetLibrary object is returned.
    /// </summary>
    /// <param name="FullFileName">The full filename of the library to open.</param>
    /// <returns></returns>
    [PreserveSig]
    AssetLibrary Open([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that migrates existing inventor color and material styles into an existing or new library.
    /// </summary>
    /// <param name="InventorLibraryPath">The full path to the existing Inventor styles.</param>
    /// <param name="ImportMaterialStyles">Indicates if material styles should be imported.</param>
    /// <param name="TargetLibrary">The full path of the library to import the styles into.  If the specified library already exists they will be merged into that library.  If it doesn’t exist, a new library will be created.</param>
    [PreserveSig]
    void MigrateInventorStyle([In] [MarshalAs(UnmanagedType.BStr)] string InventorLibraryPath, [In] bool ImportMaterialStyles, [In] [MarshalAs(UnmanagedType.BStr)] string TargetLibrary);
}
