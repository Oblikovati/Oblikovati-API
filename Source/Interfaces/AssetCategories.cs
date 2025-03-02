namespace Oblikovati.API;

/// <summary>
/// The AssetCategories collection object provides access to the categories associated with a library.
/// </summary>
public interface AssetCategories : IEnumerable
{
    /// <summary>
    /// Read-only property returning kAssetCategoriesObject indicating this object’s type.
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
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    AssetCategory Item { get; }
    /// <summary>
    /// Method that creates a new asset category in the library.
    /// </summary>
    /// <param name="DisplayName">Displayed name of the category as shown to the user in the browser.</param>
    /// <param name="Asset">An Asset that will be used as the first item in the category.  The asset must exist in the same library or document as the category being created.</param>
    /// <returns></returns>
    [PreserveSig]
    AssetCategory Add([In] [MarshalAs(UnmanagedType.BStr)] string DisplayName, [In] [MarshalAs(UnmanagedType.Interface)] Asset Asset);
}
