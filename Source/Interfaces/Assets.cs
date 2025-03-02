namespace Oblikovati.API;

/// <summary>
/// The Assets collection object provides access to assets within a library and supports the creation of new assets.  Depending on where the Assets object was obtained from it will provide access to different types of assets.
/// </summary>
public interface Assets : IEnumerable
{
    /// <summary>
    /// Read-only property returning kAssetsObject indicating this object’s type.
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
    /// Read-only property that returns the specified Asset object from the collection.
    /// </summary>
    Asset this[object Index] { get; }
    /// <summary>
    /// Method that creates a new asset. The new created Asset object is returned. Currently only material and appearance assets can be created. When a material asset is created a physical asset is automatically created that is associated with it that you can edit.
    /// </summary>
    /// <param name="AssetType">The type of asset to be created, either an appearance or material asset.</param>
    /// <param name="LocalType">If the AssetType argument is kAssetAppearanceType, then you can specify the type of appearance asset you want to create. If a material asset is being created, this argument is ignored. If an appearance argument is being created and this argument is not provided it will default to creating a Generic type of appearance asset.
    /// The valid types of assets that can be created are: “Ceramic”, “Concrete”, “Generic”, “Glazing”, “Masonry”, “Metal”, “Metallic Paint”, “Mirror”, “Plastic”, “Solid Glass”, “Stone”, “Wall Paint”, “Water” and “Wood”.</param>
    /// <param name="Reserved">Reserved for future use.</param>
    /// <param name="DisplayName">Displayed name of the asset as shown to the user in the browser. If no name is specified, Inventor creates a default name.</param>
    /// <returns></returns>
    [PreserveSig]
    Asset Add([In] AssetTypeEnum AssetType, [In] [MarshalAs(UnmanagedType.BStr)] string LocalType, [In] [MarshalAs(UnmanagedType.Struct)] object? Reserved = default, [In] [MarshalAs(UnmanagedType.Struct)] object? DisplayName = default);
}
