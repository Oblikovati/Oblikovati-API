namespace Oblikovati.API;

/// <summary>
/// The IntegerAssetValue object represents an integer value.  The value is returned as a Long and a Long should be used when setting the value.  This object also provides any limits that the value must meet to be valid.
/// </summary>
public interface IntegerAssetValue
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
    /// Gets the boolean flag that indicates if this value has any limits it must be within to be valid. If True, use the GetLimits method to get the limit values.
    /// </summary>
    bool HasLimits { get; }
    /// <summary>
    /// Gets and sets this asset value.
    /// </summary>
    int Value { get; set; }
    /// <summary>
    /// Gets the boolean flag that indicates if this value has multiple values or not.
    /// </summary>
    bool HasMultipleValues { get; }
    /// <summary>
    /// Gets and sets the values associated with this asset value. HasMultipleValues property indicates if this property will be returning more than one value.
    /// </summary>
    int[,] Values { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="HasLowLimit">HasLowLimit</param>
    /// <param name="LowLimit">LowLimit</param>
    /// <param name="HasHighLimit">HasHighLimit</param>
    /// <param name="HighLimit">HighLimit</param>
    [PreserveSig]
    void GetLimits([Out] out bool HasLowLimit, [Out] out int LowLimit, [Out] out bool HasHighLimit, [Out] out int HighLimit);
}
