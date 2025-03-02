namespace Oblikovati.API;

/// <summary>
/// The ColorAssetValue object represents an asset value that consists of a color.  The Value property will return and must be set with a Color object.
/// </summary>
public interface ColorAssetValue
{
    /// <summary>
    /// Read-only property returning kAssetValueObject indicating this object’s type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the parent Asset object.
    /// </summary>
    Asset Parent { get; }
    /// <summary>
    /// Gets the name of this value as seen in the Material or Appearance Browser. This can change based on the current Inventor language.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Gets the boolean flag that indicates if this asset value is read-only. If True any attempted edits will fail.
    /// </summary>
    bool IsReadOnly { get; }
    /// <summary>
    /// Gets the key name of the value. This name will remain constant for all languages and is the name used as input to the Item property or the Asset object.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the data type that the Value property for this AssetValue object will return.
    /// </summary>
    AssetValueTypeEnum ValueType { get; }
    /// <summary>
    /// Gets the associated texture, if one exists. The HasConnectedTexture property controls if there is an associated texture or not. If the library is writable you can edit the texture. If not texture exists, this property will return Nothing.
    /// </summary>
    AssetTexture ConnectedTexture { get; }
    /// <summary>
    /// Read-write property that indicates if the color has been overridden using a texture.&nbsp;Setting this property to False will remove the texture so that a basic color is used.&nbsp;Setting this property to True will connect a texture to this color which you can then edit to create the desired texture.
    /// </summary>
    bool HasConnectedTexture { get; set; }
    /// <summary>
    /// Gets and sets this asset value. The value of this property should be ignored if the HasConnectedTexture property is ture. Setting this will remove any associated texture, if there is one.
    /// </summary>
    Color Value { get; set; }
    /// <summary>
    /// Gets the boolean flag that indicates if this value has multiple values or not.
    /// </summary>
    bool HasMultipleValues { get; }
    /// <summary>
    /// Gets and sets the values associated with this asset value. HasMultipleValues property indicates if this property will be returning more than one value.
    /// </summary>
    Color[] Values { get; set; }
}
