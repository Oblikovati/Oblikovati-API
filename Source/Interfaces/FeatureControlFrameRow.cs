namespace Oblikovati.API;

/// <summary>
/// The FeatureControlFrameRow object represents a row within a feature control frame symbol.
/// </summary>
public interface FeatureControlFrameRow
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent FeatureControlFrame object.
    /// </summary>
    FeatureControlFrame Parent { get; }
    /// <summary>
    /// Gets and sets the geometric characteristic symbol for the row.
    /// </summary>
    GeometricCharacteristicEnum GeometricCharacteristic { get; set; }
    /// <summary>
    /// Gets and sets the tolerance associated with this geometric characteristic. The string can contain symbols specified using the StyleOverride tag. E.g. use 'm' to specify (M).
    /// </summary>
    string Tolerance { get; set; }
    /// <summary>
    /// Gets and sets the lower tolerance associated with this geometric characteristic. Applies to ANSI standard only. The string can contain symbols specified using the StyleOverride tag. E.g. use 'm' to specify (M).
    /// </summary>
    string LowerTolerance { get; set; }
    /// <summary>
    /// Gets and sets the first datum that affects the tolerance. Returns a null string if the datum is not specified. The string can contain symbols specified using the StyleOverride tag. E.g. use 'm' to specify (M).
    /// </summary>
    string DatumOne { get; set; }
    /// <summary>
    /// Gets and sets the second datum that affects the tolerance. Returns a null string if the datum is not specified. The string can contain symbols specified using the StyleOverride tag. E.g. use 'm' to specify (M).
    /// </summary>
    string DatumTwo { get; set; }
    /// <summary>
    /// Gets and sets the third datum that affects the tolerance. Returns a null string if the datum is not specified. The string can contain symbols specified using the StyleOverride tag. E.g. use 'm'to specify (M).
    /// </summary>
    string DatumThree { get; set; }
    /// <summary>
    /// Gets and sets the inline note. This is applicable only when the FeatureControlFrameStyle.EnableInlineNotes is set to True when the style is applied to this FeatureControlFrame object.
    /// </summary>
    string InlineNote { get; set; }
    /// <summary>
    /// Gets the AuxiliaryFeatureIndicators collection object.
    /// </summary>
    AuxiliaryFeatureIndicators AuxiliaryFeatureIndicators { get; }
    /// <summary>
    /// The row of the feature control frame.
    /// </summary>
    [PreserveSig]
    void Delete();
}
