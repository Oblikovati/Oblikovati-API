namespace Oblikovati.API;

/// <summary>
/// The FloatAssetValue object represents a floating point value.  The value is returned as a Double and a Double should be used when setting the value.  This object also provides any limits that the value must meet to be valid.
/// </summary>
public interface FloatAssetValue
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
    /// Read-only property that returns the associated texture, if one exists.&nbsp;The HasConnectedTexture property controls if there is an associated texture or not.&nbsp;If the library is writable you can edit the texture.&nbsp;If there isn’t a texture associated with this value, this property will return Nothing.
    /// </summary>
    AssetTexture ConnectedTexture { get; }
    /// <summary>
    /// Gets and sets the boolean flag that indicates if the float value has been overridden using a texture. Setting this property to False will remove the texture so that a float value is used. Setting this property to True will connect a texture to this float value.
    /// </summary>
    bool HasConnectedTexture { get; set; }
    /// <summary>
    /// Gets the boolean flag that indicates if this value has any limits it must be within to be valid. If True, use the GetLimits method to get the limit values.
    /// </summary>
    bool HasLimits { get; }
    /// <summary>
    /// Gets the boolean flag that indicates that this value represents a percentage value so the valid values must be in the range of 0.0 to 1.0 unless they’re further limited by additional limits which can be determined with the HasLimits property.
    /// </summary>
    bool IsPercentage { get; }
    /// <summary>
    /// Gets the units that this value is returned in. The String returned is a valid Inventor unit string that can be used with the methods on the UnitOfMeasure object.
    /// </summary>
    string Units { get; }
    /// <summary>
    /// Gets and sets this asset value. If this asset value has a texture associated with it, setting the value will remove the texture and assign the static value.
    /// </summary>
    double Value { get; set; }
    /// <summary>
    /// Gets the boolean flag that indicates if this value has multiple values or not.
    /// </summary>
    bool HasMultipleValues { get; }
    /// <summary>
    /// Gets and sets the values associated with this asset value. HasMultipleValues property indicates if this property will be returning more than one value.
    /// </summary>
    double[,] Values { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="HasLowLimit">HasLowLimit</param>
    /// <param name="LowLimit">LowLimit</param>
    /// <param name="HasHighLimit">HasHighLimit</param>
    /// <param name="HighLimit">HighLimit</param>
    [PreserveSig]
    void GetLimits([Out] out bool HasLowLimit, [Out] out double LowLimit, [Out] out bool HasHighLimit, [Out] out double HighLimit);
}
