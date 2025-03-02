namespace Oblikovati.API;

/// <summary>
/// The AssetTexture object represents a texture that’s associated with an asset value.
/// </summary>
public interface AssetTexture : IEnumerable
{
    /// <summary>
    /// Read-only property returning kAssetTextureObject indicating this object’s type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the number of asset values associated with this texture.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-only property that returns the specified AssetValue object from the asset.
    /// </summary>
    AssetValue Item { get; }
    /// <summary>
    /// Gets the current texture type.
    /// </summary>
    AssetTextureTypeEnum TextureType { get; }
    /// <summary>
    /// Method that changes the type of of this texture.
    /// </summary>
    [PreserveSig]
    void ChangeTextureType([In] AssetTextureTypeEnum TextureType, [In] [MarshalAs(UnmanagedType.Struct)] object? ImageFileName = default);
}
