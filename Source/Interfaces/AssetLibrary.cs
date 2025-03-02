namespace Oblikovati.API;

/// <summary>
/// The AssetLibrary object represents a material and appearance library which exists as a .asdklib file.  A library can contain both appearance and physical material information.
/// </summary>
public interface AssetLibrary
{
    /// <summary>
    /// Read-only property returning kAssetLibraryObject indicating this object’s type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the AssetCategories collection which provides access to the appearance related categories defined within this library.
    /// </summary>
    AssetCategories AppearanceAssetCategories { get; }
    /// <summary>
    /// Gets an Assets collection which provides access to all of the appearance assets in this library.
    /// </summary>
    AssetsEnumerator AppearanceAssets { get; }
    /// <summary>
    /// Gets and sets the name of this library as seen in the Material or Appearance Browser.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Gets the full filename of this library.
    /// </summary>
    string FullFileName { get; }
    /// <summary>
    /// Gets the unique internal name of this library.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Gets the boolean flag that indicates if this library is read-only. If True any attempted edits will fail.
    /// </summary>
    bool IsReadOnly { get; }
    /// <summary>
    /// Gets the AssetCategories collection which provides access to the material related categories defined within this library.
    /// </summary>
    AssetCategories MaterialAssetCategories { get; }
    /// <summary>
    /// Gets the Assets collection which provides access to all of the materials in this library.
    /// </summary>
    AssetsEnumerator MaterialAssets { get; }
    /// <summary>
    /// Gets an Assets collection which provides access to all of the physical assets in this library. A physical asset defines the physical properties that are associated with a material.
    /// </summary>
    AssetsEnumerator PhysicalAssets { get; }
    /// <summary>
    /// Method that removes the library from the set of loaded libraries. The associated .adsklib file is not affected.
    /// </summary>
    [PreserveSig]
    void Remove();
}
