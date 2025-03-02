namespace Oblikovati.API;

/// <summary>
/// The DimensionStyle object represents a dimension style in a drawing.
/// </summary>
public interface DimensionStyle
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
    /// Gets and sets the character to use as a decimal marker for alternate dimensions.
    /// </summary>
    DecimalMarkerTypeEnum AlternateDecimalMarkerType { get; set; }
    /// <summary>
    /// Gets and sets whether to display units for alternate dimensions in the drawing.
    /// </summary>
    bool AlternateDisplayUnitType { get; set; }
    /// <summary>
    /// Gets and sets whether to display the leading zeroes for alternate dimensions in the drawing.
    /// </summary>
    bool AlternateLeadingZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets the precision for linear alternate dimensions in the drawing.
    /// </summary>
    LinearPrecisionEnum AlternateLinearPrecision { get; set; }
    /// <summary>
    /// Gets and sets the units of length measure used for alternate dimensions in the drawing.
    /// </summary>
    UnitsTypeEnum AlternateLinearUnits { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DimensionStyleFormatEnum AlternateStyleFormat { get; set; }
    /// <summary>
    /// Gets and sets whether to display the trailing zeroes for alternate dimensions in the drawing.
    /// </summary>
    bool AlternateTrailingZeroDisplay { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AlternateUnitsDisplay { get; set; }
    /// <summary>
    /// Gets and sets the precision for angular dimensions in the drawing.
    /// </summary>
    AngularPrecisionEnum AngularPrecision { get; set; }
    /// <summary>
    /// Gets and sets the character to use as a decimal marker for dimensions.
    /// </summary>
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    /// <summary>
    /// Gets and sets whether to display units for dimensions in the drawing.
    /// </summary>
    bool DisplayUnitType { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _InUse { get; }
    /// <summary>
    /// Gets and sets whether to display the leading zeroes for dimensions in the drawing.
    /// </summary>
    bool LeadingZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets the precision value for linear dimensions in the drawing.
    /// </summary>
    LinearPrecisionEnum LinearPrecision { get; set; }
    /// <summary>
    /// Gets and sets the units of length measure used for dimensions in the drawing.
    /// </summary>
    UnitsTypeEnum LinearUnits { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    StyleLocationEnum _StyleLocation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _Name { get; set; }
    /// <summary>
    /// Gets and sets the dimension prefix.
    /// </summary>
    string Prefix { get; set; }
    /// <summary>
    /// Gets and sets the location of prefix and suffix.
    /// </summary>
    PrefixAndSuffixOrderEnum PrefixAndSuffixOrder { get; set; }
    /// <summary>
    /// Gets and sets the dimension suffix.
    /// </summary>
    string Suffix { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the dimension style.
    /// </summary>
    TextStyle TextStyle { get; set; }
    /// <summary>
    /// Property that returns the Tolerance object. The Tolerance object contains methods and properties to query and modify tolerance types and values.
    /// </summary>
    Tolerance Tolerance { get; }
    /// <summary>
    /// Gets and sets the number of decimal places visible to the right of the decimal marker in tolerance text for alternate dimensions.
    /// </summary>
    int ToleranceAlternateUnitPrecision { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int _ToleranceAngularPrecision { get; set; }
    /// <summary>
    /// Gets and sets the size of the font used for tolerances.
    /// </summary>
    double ToleranceFontSize { get; set; }
    /// <summary>
    /// Gets and sets whether to display the leading zeroes for tolerances.
    /// </summary>
    bool ToleranceLeadingZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets the number of decimal places visible to the right of the decimal marker in tolerance text for linear dimensions.
    /// </summary>
    int ToleranceLinearPrecision { get; set; }
    /// <summary>
    /// Gets and sets the text style used for tolerance.
    /// </summary>
    TextStyle ToleranceTextStyle { get; set; }
    /// <summary>
    /// Gets and sets whether to display the trailing zeroes for tolerances.
    /// </summary>
    bool ToleranceTrailingZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether to display the trailing zeroes for dimensions in the drawing.
    /// </summary>
    bool TrailingZeroDisplay { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool _UpToDate { get; }
    /// <summary>
    /// Gets and sets the precision of the tolerance text for angular dimensions.
    /// </summary>
    AngularPrecisionEnum ToleranceAngularPrecision { get; set; }
    /// <summary>
    /// Property that gets and sets the leader style used for the dimension style.
    /// </summary>
    LeaderStyle LeaderStyle { get; set; }
    /// <summary>
    /// Gets and sets the display format for all non-angular dimensions.
    /// </summary>
    DisplayFormatEnum DisplayFormat { get; set; }
    /// <summary>
    /// Gets and sets the size of the stacked text relative to the default text size. The valid range of values is 0.25 to 1.25.
    /// </summary>
    double FractionalTextScale { get; set; }
    /// <summary>
    /// Gets and sets the alternate units display format for all non-angular dimensions.
    /// </summary>
    DisplayFormatEnum AlternateDisplayFormat { get; set; }
    /// <summary>
    /// Gets and sets the size of the stacked text relative to the default text size when using alternate units. The valid range of values is 0.25 to 1.25.
    /// </summary>
    double AlternateFractionalTextScale { get; set; }
    /// <summary>
    /// Gets and sets the height of the arrowhead relative to the associated line.
    /// </summary>
    double ArrowheadHeight { get; set; }
    /// <summary>
    /// Gets and sets the size of the arrowhead.
    /// </summary>
    double ArrowheadSize { get; set; }
    /// <summary>
    /// Gets and sets the arrowhead style to use.
    /// </summary>
    ArrowheadTypeEnum ArrowheadType { get; set; }
    /// <summary>
    /// Gets and sets the color for the style.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Gets and sets the distance the extension line is drawn past the dimension line.
    /// </summary>
    double Extension { get; set; }
    /// <summary>
    /// Gets and sets the distance between the dimension text and the dimension lines.
    /// </summary>
    double Gap { get; set; }
    /// <summary>
    /// Gets and sets the line type override for the style.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Gets and sets the line weight override for the style.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Gets and sets the distance from an edge or point to the endpoint of the extension line.
    /// </summary>
    double OriginOffset { get; set; }
    /// <summary>
    /// Gets and sets the distance from the referenced part edge to a parallel dimension line.
    /// </summary>
    double PartOffset { get; set; }
    /// <summary>
    /// Gets and sets whether to display break symbols for dimensions on a broken view.
    /// </summary>
    bool ShowBreakSymbol { get; set; }
    /// <summary>
    /// Gets and sets whether to display the dimension line when arrowheads are outside the dimension extension lines.
    /// </summary>
    bool ShowDimensionLine { get; set; }
    /// <summary>
    /// Gets and sets the distance between the parallel dimension lines.
    /// </summary>
    double Spacing { get; set; }
    /// <summary>
    /// Gets and sets the internal arrowhead styles to use for chain dimensions.
    /// </summary>
    ArrowheadTypeEnum ArrowheadTypeForChainDimensions { get; set; }
    /// <summary>
    /// Gets and sets whether to display the included zeroes for alternate dimensions in the drawing.
    /// </summary>
    bool AlternateIncludedZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether to display the included zeroes for dimensions in the drawing.
    /// </summary>
    bool IncludedZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether to display the included zeroes for tolerances in alternate units.
    /// </summary>
    bool ToleranceAlternateIncludedZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether to display the leading zeroes for tolerances in alternate units.
    /// </summary>
    bool ToleranceAlternateLeadingZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether to display the trailing zeroes for tolerances in alternate units.
    /// </summary>
    bool ToleranceAlternateTrailingZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether to display the included zeroes for tolerances.
    /// </summary>
    bool ToleranceIncludedZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets the arrowhead type for the origin member of ordinate dimension sets.
    /// </summary>
    ArrowheadTypeEnum OrdinateDimensionOriginArrowheadType { get; set; }
    /// <summary>
    /// Gets and sets whether to display angular dimension values as decimal degrees or degrees-minutes-seconds.
    /// </summary>
    bool AngularFormatIsDecimalDegrees { get; set; }
    /// <summary>
    /// Gets and sets whether to display the leading zeroes for angular dimensions in the drawing.
    /// </summary>
    bool AngularLeadingZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets whether to display the trailing zeroes for angular dimensions in the drawing.
    /// </summary>
    bool AngularTrailingZeroDisplay { get; set; }
    /// <summary>
    /// Gets and sets the orientation of the text in an aligned dimension.
    /// </summary>
    DimensionTextOrientationEnum AlignedDimensionTextOrientation { get; set; }
    /// <summary>
    /// Gets and sets inside or outside placement of arrows for Angular dimensions.
    /// </summary>
    bool AngularArrowsInside { get; set; }
    /// <summary>
    /// Gets and sets if the first extension line of an angular dimension is hidden.
    /// </summary>
    bool AngularHideExtensionLineOne { get; set; }
    /// <summary>
    /// Gets and sets if the second extension line of an angular dimension is hidden.
    /// </summary>
    bool AngularHideExtensionLineTwo { get; set; }
    /// <summary>
    /// Gets and sets the optional modifier that controls the controls the position of text in an angular dimension.
    /// </summary>
    DimensionTextModifierEnum AngularTextModifier { get; set; }
    /// <summary>
    /// Gets and sets the orientation of angular dimension text.
    /// </summary>
    DimensionTextOrientationEnum AngularTextOrientation { get; set; }
    /// <summary>
    /// Gets and sets whether the prefix and suffix are inside or outside the basic dimension box.
    /// </summary>
    bool BasicDimensionPrefixSuffixInside { get; set; }
    /// <summary>
    /// Gets and sets the arrangement of the alternate dimension display for bend notes.
    /// </summary>
    DimensionStyleFormatEnum BendNoteDualFormat { get; set; }
    /// <summary>
    /// Gets and sets the arrangement of the alternate dimension display for chamfer notes.
    /// </summary>
    DimensionStyleFormatEnum ChamferNoteDualFormat { get; set; }
    /// <summary>
    /// Gets and sets inside or outside placement of arrows for diameter dimensions.
    /// </summary>
    bool DiameterArrowsInside { get; set; }
    /// <summary>
    /// Gets and sets if single or dual diameter dimension lines should be displayed.
    /// </summary>
    bool DiameterDualDimensionLine { get; set; }
    /// <summary>
    /// Gets and sets the orientation of text in a diameter dimension when the text is external using a leader line.
    /// </summary>
    DimensionTextOrientationEnum DiameterExternalTextOrientation { get; set; }
    /// <summary>
    /// Gets and sets the orientation of text in a diameter dimension when the text is within a dimension line.
    /// </summary>
    DimensionTextOrientationEnum DiameterInternalTextOrientation { get; set; }
    /// <summary>
    /// Gets and sets if the leader line of a diameter dimension extends to the center or not.
    /// </summary>
    bool DiameterLeaderFromCenter { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the position of multiple lines of text relative to the landing line in a diameter dimension.&nbsp;Valid values are kFirstLineCenteredOnLandingLine, kAllAboveLandingLine, kAllAboveLandingLineWithUnderline, kFirstLineAboveLandingLine, and kJISAlignment.
    /// </summary>
    MultiLineDimensionTextEnum DiameterMultiLineTextOrientation { get; set; }
    /// <summary>
    /// Gets and sets if the diameter symbol should be shown in a diameter dimension.
    /// </summary>
    bool DiameterShowDiameterSymbol { get; set; }
    /// <summary>
    /// Gets and sets whether to use a quadrant or ignore the quadrant angular dimension text.
    /// </summary>
    bool AngularUseQuadrant { get; set; }
    /// <summary>
    /// Gets and sets whether the arc length dimension symbol is above the arc length dimension value or before it.
    /// </summary>
    bool ArcLengthDimensionSymbolAbove { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the arrangement of the alternate dimension display for dimensions.
    /// </summary>
    DimensionStyleFormatEnum DimensionDualFormat { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the position of multiple lines of text relative to the landing line in a linear dimension.&nbsp;Valid values are kAllAboveLandingLine and kFirstLineAboveLandingLine.
    /// </summary>
    MultiLineDimensionTextEnum LinearMultiLineTextOrientation { get; set; }
    /// <summary>
    /// Gets and sets the arrangement of the alternate dimension display for hole notes.
    /// </summary>
    DimensionStyleFormatEnum HoleNoteDualFormat { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the orientation of the text in a horizontal dimension.&nbsp;Valid values are kParallelDimensionText and kInlineHorizontalText.
    /// </summary>
    DimensionTextOrientationEnum HorizontalDimensionTextOrientation { get; set; }
    /// <summary>
    /// Gets and sets inside or outside placement of arrows for linear dimensions.
    /// </summary>
    bool LinearArrowsInside { get; set; }
    /// <summary>
    /// Gets and sets if the first extension line of a linear dimension is hidden.
    /// </summary>
    bool LinearHideExtensionLineOne { get; set; }
    /// <summary>
    /// Gets and sets if the second extension line of a linear dimension is hidden.
    /// </summary>
    bool LinearHideExtensionLineTwo { get; set; }
    /// <summary>
    /// Gets and sets the type of alignment to use for ordinate dimensions.
    /// </summary>
    OrdinateDimensionAlignmentEnum OrdinateAlignment { get; set; }
    /// <summary>
    /// Gets and sets if the origin indicator is to be hidden or not.
    /// </summary>
    bool OrdinateHideOriginIndicator { get; set; }
    /// <summary>
    /// Gets and sets if jogged leaders for ordinate dimensions is allowed or not.
    /// </summary>
    bool OrdinateJoggingAllowed { get; set; }
    /// <summary>
    /// Gets and sets if positive values should be shown in both directions or not for an ordinate dimension.
    /// </summary>
    bool OrdinatePositiveBothDirections { get; set; }
    /// <summary>
    /// Gets and sets if the direction arrow should be shown or not for ordinate dimensions.
    /// </summary>
    bool OrdinateShowDirection { get; set; }
    /// <summary>
    /// Gets and sets if the origin indicator is to be used or not.
    /// </summary>
    bool OrdinateUseOriginIndicator { get; set; }
    /// <summary>
    /// Gets and sets the arrangement of the alternate dimension display for punch notes.
    /// </summary>
    DimensionStyleFormatEnum PunchNoteDualFormat { get; set; }
    /// <summary>
    /// Gets and sets inside or outside placement of arrows for radial dimensions.
    /// </summary>
    bool RadialArrowsInside { get; set; }
    /// <summary>
    /// Gets and sets if the leader line of a radial dimension is jogged or not.
    /// </summary>
    bool RadialJoggedLeader { get; set; }
    /// <summary>
    /// Gets and sets if the leader line of a radial dimension extends from the center or not.
    /// </summary>
    bool RadialLeaderFromCenter { get; set; }
    /// <summary>
    /// Gets and sets the position of multiple lines of text relative to the landing line in a radial dimension.
    /// </summary>
    MultiLineDimensionTextEnum RadialMultiLineTextOrientation { get; set; }
    /// <summary>
    /// Gets and sets the orientation of text in a radial dimension.
    /// </summary>
    DimensionTextOrientationEnum RadialTextOrientation { get; set; }
    /// <summary>
    /// Gets and sets the vertical justification of dimension tolerance text.
    /// </summary>
    VerticalTextAlignmentEnum ToleranceJustification { get; set; }
    /// <summary>
    /// Gets and sets whether to show angles using fractional degrees or minutes and seconds.
    /// </summary>
    bool ToleranceShowMinuteSecond { get; set; }
    /// <summary>
    /// Gets and sets how to display zero tolerances.
    /// </summary>
    DimensionZeroToleranceDisplayEnum ToleranceZeroToleranceDisplay { get; set; }
    /// <summary>
    /// Gets and sets the orientation of the text in a vertical dimension.
    /// </summary>
    DimensionTextOrientationEnum VerticalDimensionTextOrientation { get; set; }
    /// <summary>
    /// Returns the hole and thread type list.
    /// </summary>
    string[] HoleThreadTypeList { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="HoleThreadType">HoleThreadType</param>
    /// <param name="OptionName">OptionName</param>
    /// <param name="Value">Value</param>
    [PreserveSig]
    void GetHoleThreadNoteOptionValue([In] [MarshalAs(UnmanagedType.BStr)] string HoleThreadType, [In] [MarshalAs(UnmanagedType.BStr)] string OptionName, [Out] [MarshalAs(UnmanagedType.Struct)] out object Value);
    /// <summary>
    /// Sets the option value for hole thread notes.
    /// </summary>
    /// <param name="HoleThreadType">Input String value that specifies a hole or thread type. The HoleThreadTypeList can return the hole and thread type list for this argument to use. The English-based hole or thread type can always be used as valid input for this argument(like “Thru” or “Thru Counterbore” etc.).</param>
    /// <param name="OptionName">Input String value that specifies an option name. Below are valid option names and value types:
    /// OptionName = RightHandedThread. Value = Boolean that indicates whether to display the RH for right handed thread or not.</param>
    /// <param name="OptionValue">Input value that specifies an option value. Refer to OptionName to find the value type to set for an option.</param>
    /// <param name="ApplyToAll">Optional input Boolean that specifies whether the value change should be applied to all the hole and thread types. If not provided this default to False.</param>
    [PreserveSig]
    void SetHoleThreadNoteOptionValue([In] [MarshalAs(UnmanagedType.BStr)] string HoleThreadType, [In] [MarshalAs(UnmanagedType.BStr)] string OptionName, [In] [MarshalAs(UnmanagedType.Struct)] object OptionValue, [In] [MarshalAs(UnmanagedType.Struct)] object? ApplyToAll = default);
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
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    [PreserveSig]
    DimensionStyle _Copy([In] [MarshalAs(UnmanagedType.BStr)] string Name);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    DimensionStyle _ConvertToLocal();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _SaveToGlobal();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _UpdateFromGlobal();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Method that sets a custom line type to the style from the specified .lin file. The method automatically changes the value of LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">Input string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists. If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
}
