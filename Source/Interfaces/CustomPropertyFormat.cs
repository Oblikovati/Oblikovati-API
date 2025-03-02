namespace Oblikovati.API;

/// <summary>
/// The CustomPropertyFormat provides control over how the parameter value is formatted when it is exposed as a custom iProperty.
/// </summary>
public interface CustomPropertyFormat
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent Parameter object.
    /// </summary>
    Parameter Parent { get; }
    /// <summary>
    /// Gets/Sets whether the custom iProperty created for this parameter is a text (String) or number (Double) parameter.
    /// </summary>
    CustomPropertyTypeEnum PropertyType { get; set; }
    /// <summary>
    /// Gets/Sets the units to use when formatting the parameter value to be displayed as an iProperty.
    /// </summary>
    string Units { get; set; }
    /// <summary>
    /// Gets/Sets the precision to use when formatting the parameter value to be displayed as an iProperty.
    /// </summary>
    CustomPropertyPrecisionEnum Precision { get; set; }
    /// <summary>
    /// Gets/Sets if leading zeros should be shown in the formatted iProperty value.
    /// </summary>
    bool ShowLeadingZeros { get; set; }
    /// <summary>
    /// Gets/Sets if trailing zeros should be shown in the formatted iProperty value.
    /// </summary>
    bool ShowTrailingZeros { get; set; }
    /// <summary>
    /// Gets/Sets if the unit string should be shown in the formatted iProperty value.
    /// </summary>
    bool ShowUnitsString { get; set; }
}
