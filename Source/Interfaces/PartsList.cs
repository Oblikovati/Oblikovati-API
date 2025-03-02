namespace Oblikovati.API;

/// <summary>
/// The PartsList object represents a parts list in a drawing sheet.
/// </summary>
public interface PartsList
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
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that gets the parent object from whom this object can logically be reached.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Gets the PartsListColumns collection object for this parts list table.
    /// </summary>
    PartsListColumns PartsListColumns { get; }
    /// <summary>
    /// Gets the PartsListRows collection object for this parts list table.
    /// </summary>
    PartsListRows PartsListRows { get; }
    /// <summary>
    /// Gets and sets the title of the parts list.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Gets and sets whether the title is shown or not.
    /// </summary>
    bool ShowTitle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    DrawingView ParentView { get; }
    /// <summary>
    /// Gets and sets the origin position of the table.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Gets whether the parts list wraps to the left.
    /// </summary>
    bool WrapLeft { get; set; }
    /// <summary>
    /// Gets and sets the line spacing of the rows.
    /// </summary>
    LineSpacingEnum RowLineSpacing { get; set; }
    /// <summary>
    /// Gets and sets the vertical direction of the table.
    /// </summary>
    TableDirectionEnum TableDirection { get; set; }
    /// <summary>
    /// Gets and sets the placement position of the table heading.
    /// </summary>
    HeadingPlacementEnum HeadingPlacement { get; set; }
    /// <summary>
    /// Property that returns the type of numbering for the parts list. Possible values are kFirstLevelComponents and kPartsOnly.
    /// </summary>
    PartsListLevelEnum Level { get; }
    /// <summary>
    /// Gets and sets the number of columns to wrap.
    /// </summary>
    int NumberOfSections { get; set; }
    /// <summary>
    /// Gets and sets whether to split the table equally.
    /// </summary>
    bool WrapAutomatically { get; set; }
    /// <summary>
    /// Property that returns the row gap. This value is obtained from the parts list style.
    /// </summary>
    double RowGap { get; }
    /// <summary>
    /// Gets and sets the layer used by the parts list.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Converted { get; set; }
    /// <summary>
    /// Property that gets the document referenced by this parts list.
    /// </summary>
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    /// <summary>
    /// Gets and sets the maximum number of rows per section.
    /// </summary>
    int MaximumRows { get; set; }
    /// <summary>
    /// Property that returns the numbering scheme used for a 'parts only' parts list. The property returns an error if this is not a 'parts only' parts list. Possible return values are kNumericNumbering, kLowercaseAlphaNumbering and kUppercaseAlphaNumbering.
    /// </summary>
    NumberingSchemeEnum NumberingScheme { get; }
    /// <summary>
    /// Gets and sets the names of the iPart/iAssembly members to include as columns in the parts list.
    /// </summary>
    string[,] MembersToInclude { get; set; }
    /// <summary>
    /// Gets and sets whether to hide rows of zero quantity.
    /// </summary>
    bool HideZeroQuantityRows { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the title of the parts list.
    /// </summary>
    TextStyle TitleTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the column titles (headers).
    /// </summary>
    TextStyle ColumnHeaderTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the contents of the parts list.
    /// </summary>
    TextStyle DataTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the absolute rotation angle of the parts list in radians.
    /// </summary>
    double Rotation { get; set; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Gets and sets the associated PartsListStyle object.
    /// </summary>
    PartsListStyle Style { get; set; }
    /// <summary>
    /// Read-only property that returns the filter settings for the parts list.
    /// </summary>
    PartsListFilterSettings FilterSettings { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferencedFileDescriptor ReferencedFile { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes this PartsList.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that saves the parts list to an external file.
    /// </summary>
    /// <param name="FileName">Input string that specifies the file name to export the parts list to.</param>
    /// <param name="FileFormat">Input that specifies the file format to save to.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for export. See Remarks for valid inputs.</param>
    [PreserveSig]
    void Export([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] PartsListFileFormatEnum FileFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Update();
    /// <summary>
    /// Method that renumbers all rows in the parts list.
    /// </summary>
    [PreserveSig]
    void Renumber();
    /// <summary>
    /// Method that changes the sort order of items in the parts list.
    /// </summary>
    /// <param name="PrimaryColumnTitle">Input string that specifies the primary column to use for the sorting. If the name of a non-existing column is provided, an error occurs.</param>
    /// <param name="PrimaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa. If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    /// <param name="SecondaryColumnTitle">Optional input string that specifies the secondary column to use for the sorting. If the name of a non-existing column or the primary column is provided, an error occurs.</param>
    /// <param name="SecondaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa. If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    /// <param name="TertiaryColumnTitle">Optional input string that specifies the tertiary column to use for the sorting. If the name of a non-existing column, the primary column or the secondary column is provided, an error occurs.</param>
    /// <param name="TertiaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa. If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    [PreserveSig]
    void Sort([In] [MarshalAs(UnmanagedType.BStr)] string PrimaryColumnTitle, [In] bool? PrimaryColumnAscending = true, [In] [MarshalAs(UnmanagedType.BStr)] string? SecondaryColumnTitle = "", [In] bool? SecondaryColumnAscending = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TertiaryColumnTitle = "", [In] bool? TertiaryColumnAscending = true);
    /// <summary>
    /// Saves any overrides to the item values in the balloon to the model BOM.
    /// </summary>
    [PreserveSig]
    void SaveItemOverridesToBOM();
    /// <summary>
    /// Method that copies the parts list to another sheet.
    /// </summary>
    /// <param name="TargetSheet">Input Sheet object that specifies the sheet to copy the parts list to.</param>
    /// <returns></returns>
    [PreserveSig]
    PartsList CopyTo([In] [MarshalAs(UnmanagedType.Interface)] Sheet TargetSheet);
    /// <summary>
    /// Changes the sort order of items in the parts list.
    /// </summary>
    [PreserveSig]
    void Sort2([In] [MarshalAs(UnmanagedType.BStr)] string PrimaryColumnTitle, [In] bool? PrimaryColumnAscending = true, [In] [MarshalAs(UnmanagedType.BStr)] string? SecondaryColumnTitle = "", [In] bool? SecondaryColumnAscending = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TertiaryColumnTitle = "", [In] bool? TertiaryColumnAscending = true, [In] bool? SortByString = true, [In] bool? AutoSortOnUpdate = false);
}
