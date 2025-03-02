namespace Oblikovati.API;

/// <summary>
/// The AssetCategory object represents a category within a library.
/// </summary>
public interface AssetCategory
{
    /// <summary>
    /// Read-only property returning kAssetCategoryObject indicating this object’s type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    AssetLibrary Parent { get; }
    /// <summary>
    /// Gets the assets associated with category.
    /// </summary>
    AssetsEnumerator Assets { get; }
    /// <summary>
    /// Gets and sets the name of this category as seen in the Material or Appearance Browser.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Adds the specified asset to this category. The asset must exist in the same library as the category and the library must not be read-only. If the asset is already in another category, it will be moved to this category.
    /// </summary>
    /// <param name="Asset">Input Asset object that will be added to the category.</param>
    [PreserveSig]
    void AddAsset([In] [MarshalAs(UnmanagedType.Interface)] Asset Asset);
    /// <summary>
    /// Method that deletes this category from the library. Any assets associated with the category will also be deleted.
    /// </summary>
    [PreserveSig]
    void Delete();
}
