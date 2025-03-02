namespace Oblikovati.API;

/// <summary>
/// The PartsListStyle object represents a parts list style in a drawing. The properties and methods listed below are in addition to those supported by the Style object.
/// </summary>
public interface PartsListStyle
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
    /// Gets and sets the text style used for the column titles (headers).
    /// </summary>
    TextStyle ColumnHeaderTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the contents of the table.
    /// </summary>
    TextStyle DataTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the heading gap in centimeters.
    /// </summary>
    double HeadingGap { get; set; }
    /// <summary>
    /// Gets and sets the location of the heading (title).
    /// </summary>
    HeadingPlacementEnum HeadingPlacement { get; set; }
    /// <summary>
    /// Gets and sets the row gap in centimeters.
    /// </summary>
    double RowGap { get; set; }
    /// <summary>
    /// Gets and sets the spacing between the rows.
    /// </summary>
    LineSpacingEnum RowLineSpacing { get; set; }
    /// <summary>
    /// Gets and sets the whether to show the title of the table.
    /// </summary>
    bool ShowTitle { get; set; }
    /// <summary>
    /// Gets and sets the direction of the table based on the Item numbers.
    /// </summary>
    TableDirectionEnum TableDirection { get; set; }
    /// <summary>
    /// Gets and sets the title of the PartListTable.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the title of the table.
    /// </summary>
    TextStyle TitleTextStyle { get; set; }
    /// <summary>
    /// Gets the parts list sort settings.
    /// </summary>
    PartsListSortSettings SortSettings { get; }
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
    /// Method that adds a column to the list of default columns in the style.
    /// </summary>
    /// <param name="PropertyType">Input PropertyTypeEnum that specifies the property type to associate with the column. Valid values are kFileProperty, kCustomProperty, kFilenamePartsListProperty, kItemPartsListProperty, kMassPartsListProperty, kMaterialPartsListProperty, kQuantityPartsListProperty, kBaseQuantityPartsListProperty, kBaseUnitPartsListProperty, kItemQuantityPartsListProperty and kUnitQuantityPartsListProperty.
    /// If kFileProperty is specified, the PropertySetId and PropertyIdentifier arguments are required. If kCustomProperty is specified, the PropertyIdentifier argument is required.</param>
    /// <param name="PropertySetId">Optional input String that specifies the internal name of the property set that contains the property. This is the FMTID associated with the property set. This argument is ignored if the input PropertyType is not kFileProperty.</param>
    /// <param name="PropertyIdentifier">Optional input Variant that identifies a property. This could either be a Long value that specifies the PropId of a property within the specified property set or the name of a property. Typically, a PropId should be specified when the \input PropertyType is kFileProperty and a name should be specified when the input PropertyType is kCustomProperty.</param>
    /// <param name="Title">Optional input String that specifies the column title. If not specified, the property name is used.</param>
    /// <param name="Width">Optional input Double that specifies the width of the column. If not specified, the default width value is used. A value of 0 indicates the default width value.</param>
    /// <param name="TitleHorizontalJustification">Optional input HorizontalTextAlignmentEnum that specifies the text justification for the column title.</param>
    /// <param name="ValueHorizontalJustification">Optional input HorizontalTextAlignmentEnum that specifies the text justification for the column values.</param>
    [PreserveSig]
    void AddColumn([In] PropertyTypeEnum PropertyType, [In] [MarshalAs(UnmanagedType.BStr)] string? PropertySetId = "", [In] [MarshalAs(UnmanagedType.Struct)] object? PropertyIdentifier = default, [In] [MarshalAs(UnmanagedType.BStr)] string? Title = "", [In] double? Width = default, [In] HorizontalTextAlignmentEnum? TitleHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter, [In] HorizontalTextAlignmentEnum? ValueHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter);
    /// <summary>
    /// Method that removes all columns from the style.
    /// </summary>
    [PreserveSig]
    void RemoveAllColumns();
}
