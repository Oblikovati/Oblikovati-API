namespace Oblikovati.API;

/// <summary>
/// The FeatureControlFrameStyle object represents a feature control frame style in a drawing. The properties and methods listed below are in addition to those supported by the Style object.
/// </summary>
public interface FeatureControlFrameStyle
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DrawingStylesManager _Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets/Sets the name of the Style.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns the internal name of the style. The name is the internal English name of the standard style. This name will remain constant and is not affected by locale. This name is never displayed to the user. Note that this name is not guaranteed to be unique.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that indicates if this style is in use.
    /// </summary>
    bool InUse { get; }
    /// <summary>
    /// Property that returns the location of this style, i.e. local to the document, cached locally in the document, exists in the library. Styles that exist in the library cannot be edited.
    /// </summary>
    StyleLocationEnum StyleLocation { get; }
    /// <summary>
    /// Property that gets the up-to-date status of the style against the global repository.
    /// </summary>
    bool UpToDate { get; }
    /// <summary>
    /// Gets the type of the style.
    /// </summary>
    StyleTypeEnum StyleType { get; }
    /// <summary>
    /// Gets and sets comments associated with the style.
    /// </summary>
    string Comments { get; set; }
    /// <summary>
    /// Property returning the parent of this object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that gets and sets the geometric characteristics to be made available in the feature control frame creation and edit dialog. A combination of enum values can be provided.
    /// </summary>
    GeometricCharacteristicEnum AvailableGeometricCharacteristics { get; set; }
    /// <summary>
    /// Property that gets and sets the material removal modifiers to be made available in the feature control frame creation and edit dialog. A combination of enum values can be provided.
    /// </summary>
    MaterialRemovalModifierEnum AvailableModifiers { get; set; }
    /// <summary>
    /// Property that gets and sets whether to merge symbol cells when the data is the same.
    /// </summary>
    bool MergeSymbol { get; set; }
    /// <summary>
    /// Property that gets and sets whether to merge tolerance cells when the data is the same.
    /// </summary>
    bool MergeTolerance { get; set; }
    /// <summary>
    /// Property that gets and sets whether to merge datum cells when the data is the same.
    /// </summary>
    bool MergeDatum { get; set; }
    /// <summary>
    /// Property that gets and sets whether to add spaces to short cells so that pairs of cells align vertically.
    /// </summary>
    bool AlignCellsVertically { get; set; }
    /// <summary>
    /// Property that gets and sets whether to provide the ability to add a second tolerance in the feature control frame dialog.
    /// </summary>
    bool AllowTolerance2 { get; set; }
    /// <summary>
    /// Property that gets and sets the leader style used for a feature control frame symbol.
    /// </summary>
    LeaderStyle LeaderStyle { get; set; }
    /// <summary>
    /// Property that gets and sets the text style used to format the text in a feature control frame symbol.
    /// </summary>
    TextStyle TextStyle { get; set; }
    /// <summary>
    /// Property that gets and sets whether to define the symbol size by text height.
    /// </summary>
    bool ScaleToTextHeight { get; set; }
    /// <summary>
    /// Property that gets and sets the size of the feature control frame in linear units. This value is used only if the ScaleToTextHeight property is set to False.
    /// </summary>
    double Size { get; set; }
    /// <summary>
    /// Property that gets and sets the space before and after text in the tolerance and datum cells.
    /// </summary>
    double WhiteSpace { get; set; }
    /// <summary>
    /// Property that gets and sets the units of length measure.
    /// </summary>
    UnitsTypeEnum LinearUnits { get; set; }
    /// <summary>
    /// Property that gets and sets the character to use as a decimal marker for primary units. Valid values are kPeriodDecimalMarker and kCommaDecimalMarker.
    /// </summary>
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    /// <summary>
    /// Property that gets and sets whether to display units string for primary units.
    /// </summary>
    bool DisplayUnitType { get; set; }
    /// <summary>
    /// Property that gets and sets whether to display the leading zeroes for primary units.
    /// </summary>
    bool LeadingZeroDisplay { get; set; }
    /// <summary>
    /// Property that gets and sets whether to display the trailing zeroes for primary units.
    /// </summary>
    bool TrailingZeroDisplay { get; set; }
    /// <summary>
    /// Property that gets and sets whether to display alternate units.
    /// </summary>
    bool AlternateUnitsDisplay { get; set; }
    /// <summary>
    /// Property that gets and sets the arrangement of the alternate units display with respect to the primary units. The primary unit always precedes the alternate unit. This property is used only when the AlternateUnitsDisplay property is set to true.
    /// </summary>
    AlternateUnitsDisplayTypeEnum AlternateUnitsDisplayType { get; set; }
    /// <summary>
    /// Property that gets and sets the units of length measure used for alternate units. This property is used only when the AlternateUnitsDisplay property is set to true.
    /// </summary>
    UnitsTypeEnum AlternateLinearUnits { get; set; }
    /// <summary>
    /// Property that gets and sets the character to use as a decimal marker for alternate units. Valid values are kPeriodDecimalMarker and kCommaDecimalMarker. This property is used only when the AlternateUnitsDisplay property is set to true.
    /// </summary>
    DecimalMarkerTypeEnum AlternateDecimalMarkerType { get; set; }
    /// <summary>
    /// Property that gets and sets the arrangement of the alternate units display with respect to the primary units. The primary unit always precedes the alternate unit. This property is used only when the AlternateUnitsDisplay property is set to true.
    /// </summary>
    bool AlternateDisplayUnitType { get; set; }
    /// <summary>
    /// Property that gets and sets whether to display the leading zeroes for alternate units. This property is used only when the AlternateUnitsDisplay property is set to true.
    /// </summary>
    bool AlternateLeadingZeroDisplay { get; set; }
    /// <summary>
    /// Property that gets and sets whether to display the trailing zeroes for alternate units. This property is used only when the AlternateUnitsDisplay property is set to true.
    /// </summary>
    bool AlternateTrailingZeroDisplay { get; set; }
    /// <summary>
    /// Property that gets and sets the precision for linear alternate units. This property is used only when the AlternateUnitsDisplay property is set to true.
    /// </summary>
    LinearPrecisionEnum AlternateLinearPrecision { get; set; }
    /// <summary>
    /// Property that gets and sets whether the leader terminates on the corner of the frame or at the midpoint of a vertical leg of the frame.
    /// </summary>
    bool AttachLeaderToCorner { get; set; }
    /// <summary>
    /// Gets and sets whether the inline notes is enabled or not.
    /// </summary>
    bool EnableInlineNotes { get; set; }
    /// <summary>
    /// Gets and sets whether the auxiliary feature indicators is enabled or not.
    /// </summary>
    bool EnableAuxiliaryFeatureIndicators { get; set; }
    /// <summary>
    /// Method that deletes the Style/Layer/UnfoldMethod.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that saves this style to the global repository. If a style with the same name is found in the repository, that style is updated.
    /// </summary>
    [PreserveSig]
    void SaveToGlobal();
    /// <summary>
    /// Method that updates this style from the global repository.
    /// </summary>
    [PreserveSig]
    void UpdateFromGlobal();
    /// <summary>
    /// Method that creates a local cached copy of a global style and returns the local style.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Style ConvertToLocal();
    /// <summary>
    /// Method that creates a new local Style object. The newly created style is returned.
    /// </summary>
    /// <param name="Name">Input String that specifies the name for the new style. This name must be unique with respect to all other styles of a similar type in the document. That is, if a dimension style is being copied, the name must be unique with respect to all the other dimension styles. If it is not unique the method will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    Style Copy([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AvailaleAdditionalSymbols">AvailaleAdditionalSymbols</param>
    [PreserveSig]
    void GetAvailableAdditionalSymbols([Out] [MarshalAs(UnmanagedType.SafeArray)] out FeatureControlFrameAdditionalSymbolsEnum[,] AvailaleAdditionalSymbols);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AvailaleAdditionalSymbols">AvailaleAdditionalSymbols</param>
    [PreserveSig]
    void SetAvailableAdditionalSymbols([In] [MarshalAs(UnmanagedType.SafeArray)] ref FeatureControlFrameAdditionalSymbolsEnum[,] AvailaleAdditionalSymbols);
}
