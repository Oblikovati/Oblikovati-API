namespace Oblikovati.API;

/// <summary>
/// The Asset object represents an appearance, material, or physical asset within a library.
/// </summary>
public interface Asset : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
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
    AssetValue this[object Index] { get; }
    /// <summary>
    /// Read-only property that returns the parent object of this asset.&nbsp;This can return an AssetLibrary, or Document object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the data type that returns whether this is an appearance, physical properties, or material asset.
    /// </summary>
    AssetTypeEnum AssetType { get; }
    /// <summary>
    /// Gets the category that this asset is a member of. A value of Nothing indicates this asset is not a member of a category. A value of Nothing is also returned when an Asset is associated with a document, rather than a library. Categories don’t exist in a documen.
    /// </summary>
    AssetCategory Category { get; set; }
    /// <summary>
    /// Gets the name of the category this Asset is designated to be in. This can include the the category and subcategories which are delimited by a colon.
    /// </summary>
    string CategoryName { get; }
    /// <summary>
    /// Gets and sets the name of this asset as seen in the Material or Appearance Browser.
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Gets the boolean flag that indicates if this asset is read-only. If True any attempted edits will fail.
    /// </summary>
    bool IsReadOnly { get; }
    /// <summary>
    /// Gets the boolean flag that indicates if this asset is being used in the document or in a material definition.
    /// </summary>
    bool IsUsed { get; }
    /// <summary>
    /// Gets the key name of the asset. This name will remain constant for all languages and is the name used as input to the Item property.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the flag that indicates if this asset has texture.
    /// </summary>
    bool HasTexture { get; }
    /// <summary>
    /// Returns the local type of this asset. This is applicable to appearance asset.
    /// </summary>
    AssetLocalTypeEnum LocalType { get; }
    /// <summary>
    /// Method that copies this asset to the specified target and returns the new asset.&nbsp;A failure will occur if you attempt to copy it to the location where it already exists.
    /// </summary>
    /// <param name="Target">Input Variant value that specifies the target where the asset should be copied. Valid values are:
    /// AssetLibrary object - Copied to the asset library, assuming the library is not read only.
    /// AssetCategory object - Copied to the category, assuming the associated library is not read-only.
    /// Document object - Copied to the specified document.
    /// The String “Favorites” - Copies it to the Favorites list of assets.</param>
    /// <param name="ReplaceExisting">Optional input Boolean that specifies whether replace the existing asset if an asset of the same name exists. If set to False, and an asset of the same name exists, this method creates a duplicate asset and returns the new asset. If the asset is a material asset that specify this value will either replace the existing material asset and its referenced appearance and physical assets, or duplicate all of them.</param>
    /// <returns></returns>
    [PreserveSig]
    Asset CopyTo([In] [MarshalAs(UnmanagedType.Struct)] object Target, [In] [MarshalAs(UnmanagedType.Struct)] object? ReplaceExisting = default);
    /// <summary>
    /// Method that deletes this asset from the library.&nbsp;An asset can only be deleted if it is not currently being used, which you can determine using the IsUsed property.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that creates a copy of this asset within the document using a new display name. This method is only valid when called on an asset that is owned by a document. A failure will occur if you attempt to copy an asset that isn’t owned by a document and if the.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Asset Duplicate([In] [MarshalAs(UnmanagedType.Struct)] object? NewDisplayName = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="assetBinary">assetBinary</param>
    /// <param name="referenceLabel">referenceLabel</param>
    [PreserveSig]
    void _GetProteinAsset([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] assetBinary, [Out] [MarshalAs(UnmanagedType.BStr)] out string referenceLabel);
}
