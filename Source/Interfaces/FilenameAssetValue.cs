namespace Oblikovati.API;

/// <summary>
/// The FilenameAssetValue object represents an asset value that consists of a String that represents a file.  The Value property will return and must be set with a String that represents a valid file.
/// </summary>
public interface FilenameAssetValue
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
    /// Gets and sets this asset value.
    /// </summary>
    string Value { get; set; }
    /// <summary>
    /// Gets the boolean flag that indicates if this value has multiple values or not.
    /// </summary>
    bool HasMultipleValues { get; }
    /// <summary>
    /// Gets and sets the values associated with this asset value. HasMultipleValues property indicates if this property will be returning more than one value.
    /// </summary>
    string[] Values { get; set; }
}
