namespace Oblikovati.API;

/// <summary>
/// The HoleTableStyle object represents a hole table style in a drawing. The properties and methods listed below are in addition to those supported by the Style object.
/// </summary>
public interface HoleTableStyle
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
    /// Gets and sets the title of the HoleTable.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Gets and sets the location of the heading (title).
    /// </summary>
    HeadingPlacementEnum HeadingPlacement { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the title of the table.
    /// </summary>
    TextStyle TitleTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the column titles (headers).
    /// </summary>
    TextStyle ColumnHeaderTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the contents of the table.
    /// </summary>
    TextStyle DataTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the color of the inner lines of the table.
    /// </summary>
    Color InsideLineColor { get; set; }
    /// <summary>
    /// Gets and sets the line weight of the inner lines of the table.
    /// </summary>
    double InsideLineWeight { get; set; }
    /// <summary>
    /// Gets and sets the color of the outer lines of the table.
    /// </summary>
    Color OutsideLineColor { get; set; }
    /// <summary>
    /// Gets and sets the line weight of the outer lines of the table.
    /// </summary>
    double OutsideLineWeight { get; set; }
    /// <summary>
    /// Gets and sets whether to preserve the hole tags assigned when the table is created.
    /// </summary>
    bool PreserveTagging { get; set; }
    /// <summary>
    /// Gets and sets whether to generate a leader for any hole tag dragged away from the hole with which it is associated.
    /// </summary>
    bool UseLeaderForTags { get; set; }
    /// <summary>
    /// Gets and sets whether to group and tag holes by type.
    /// </summary>
    bool GroupHoleTypes { get; set; }
    /// <summary>
    /// Gets and sets whether to tags holes relative to their position on the selected view or by their relative size.
    /// </summary>
    bool ArrangeByPosition { get; set; }
    /// <summary>
    /// Gets and sets the row merge option for the hole table.
    /// </summary>
    RowMergeTypeEnum RowMergeType { get; set; }
    /// <summary>
    /// Gets and sets whether to re-index the hole tags and resort contents when a Match Custom Hole operation is done.
    /// </summary>
    bool ReformatOnCustomHoleMatch { get; set; }
    /// <summary>
    /// Gets and sets whether to replace the alphanumeric hole tags with sequential numbering of the holes in the hole table.
    /// </summary>
    bool SequentialNumbering { get; set; }
    /// <summary>
    /// Gets and sets whether to delete tags except for the first in a series of hole tags when the row merge type is kRollupRowMerge.
    /// </summary>
    bool DeleteTagsOnRollup { get; set; }
    /// <summary>
    /// Gets and sets whether to include a secondary numeric tag when the row merge type is kRollupRowMerge.
    /// </summary>
    bool SecondaryTagModifierOnRollup { get; set; }
    /// <summary>
    /// Gets and sets whether to include hole features. Applies only to view based hole tables.
    /// </summary>
    bool IncludeHoleFeatures { get; set; }
    /// <summary>
    /// Gets and sets whether to include extruded cuts.
    /// </summary>
    bool IncludeCircularCuts { get; set; }
    /// <summary>
    /// Gets and sets whether to include center marks.
    /// </summary>
    bool IncludeCentermarks { get; set; }
    /// <summary>
    /// Gets and sets whether to include recovered punch center marks.
    /// </summary>
    bool IncludeRecoveredPunchCenters { get; set; }
    /// <summary>
    /// Gets and sets whether to include drilled hole features.
    /// </summary>
    bool IncludeDrilledHoleFeatures { get; set; }
    /// <summary>
    /// Gets and sets whether to include counterbored hole features.
    /// </summary>
    bool IncludeCounterBoreHoleFeatures { get; set; }
    /// <summary>
    /// Gets and sets whether to include countersunk hole features.
    /// </summary>
    bool IncludeCounterSinkHoleFeatures { get; set; }
    /// <summary>
    /// Gets and sets whether to include threaded hole features.
    /// </summary>
    bool IncludeThreadedHoleFeatures { get; set; }
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
    /// Method that adds a column to the list of default columns in the style.
    /// </summary>
    /// <param name="PropertyType">Input HolePropertyEnum that specifies the property type to associate with the column. If kCustomHoleProperty is specified, the CustomPropertyName argument is required.</param>
    /// <param name="CustomPropertyName">Optional input String that specifies the name of the custom property to associate with the column. This argument must be specified if the PropertyType is specified to be kCustomHoleProperty, else the method returns an error.</param>
    /// <param name="Title">Optional input String that specifies the column title. If not specified, the property name is used.</param>
    /// <param name="Width">Optional input Double that specifies the width of the column. If not specified, the default width value is used. A value of 0 indicates the default width value.</param>
    /// <param name="TitleHorizontalJustification">Optional input HorizontalTextAlignmentEnum that specifies the text justification for the column title.</param>
    /// <param name="ValueHorizontalJustification">Optional input HorizontalTextAlignmentEnum that specifies the text justification for the column values.</param>
    [PreserveSig]
    void AddColumn([In] HolePropertyEnum PropertyType, [In] [MarshalAs(UnmanagedType.BStr)] string? CustomPropertyName = "", [In] [MarshalAs(UnmanagedType.BStr)] string? Title = "", [In] double? Width = default, [In] HorizontalTextAlignmentEnum? TitleHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter, [In] HorizontalTextAlignmentEnum? ValueHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter);
    /// <summary>
    /// Method that removes all columns from the style.
    /// </summary>
    [PreserveSig]
    void RemoveAllColumns();
}
