namespace Oblikovati.API;

/// <summary>
/// This object represent a revision table.
/// </summary>
public interface RevisionTable
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
    /// Property that returns the parent object of this RevisionTable.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets/Sets the title of the RevisionTable.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Gets/Sets the position of the RevisionTable on the sheet.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Property that returns the RevisionTableColumns collection object.
    /// </summary>
    RevisionTableColumns RevisionTableColumns { get; }
    /// <summary>
    /// Property that returns the RevisionTableRows collection object.
    /// </summary>
    RevisionTableRows RevisionTableRows { get; }
    /// <summary>
    /// Gets and sets the layer used by the revision table.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Gets and sets the style associated with this object.
    /// </summary>
    RevisionTableStyle Style { get; set; }
    /// <summary>
    /// Gets whether the scope of the revision table is the entire drawing or the parent sheet.
    /// </summary>
    bool IsSheetScope { get; }
    /// <summary>
    /// Gets and sets the text style used for the column titles (headers).
    /// </summary>
    TextStyle ColumnHeaderTextStyle { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the contents of the revision table.
    /// </summary>
    TextStyle DataTextStyle { get; set; }
    /// <summary>
    /// Gets the heading gap.
    /// </summary>
    double HeadingGap { get; }
    /// <summary>
    /// Gets and sets the location of the heading.
    /// </summary>
    HeadingPlacementEnum HeadingPlacement { get; set; }
    /// <summary>
    /// Gets and sets the maximum number of rows per section.
    /// </summary>
    int MaximumRows { get; set; }
    /// <summary>
    /// Gets and sets the number of columns to wrap.
    /// </summary>
    int NumberOfSections { get; set; }
    /// <summary>
    /// Gets and sets the absolute rotation angle of the revision table in radians.
    /// </summary>
    double Rotation { get; set; }
    /// <summary>
    /// Gets the row gap.
    /// </summary>
    double RowGap { get; }
    /// <summary>
    /// Gets and sets the spacing between the rows.
    /// </summary>
    LineSpacingEnum RowLineSpacing { get; set; }
    /// <summary>
    /// Gets and sets whether to show the title of the revision table.
    /// </summary>
    bool ShowTitle { get; set; }
    /// <summary>
    /// Gets and sets the direction of the table.
    /// </summary>
    TableDirectionEnum TableDirection { get; set; }
    /// <summary>
    /// Gets and sets the text style used for the title of the revision table.
    /// </summary>
    TextStyle TitleTextStyle { get; set; }
    /// <summary>
    /// Gets and sets whether to split the table equally.
    /// </summary>
    bool WrapAutomatically { get; set; }
    /// <summary>
    /// Gets and sets whether the sections of the revision table are moved to the left or right when the number of rows increase.
    /// </summary>
    bool WrapLeft { get; set; }
    /// <summary>
    /// Gets and sets whether any edits made to the revision number cell in the active row are written back to either the Revision Number iProperty or sheet revision property (depending on the revision table scope).
    /// </summary>
    bool UpdatePropertyToRevisionNumber { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the RevisionTable.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Saves the revision table to an external file.
    /// </summary>
    /// <param name="FileName">Input string that specifies the file name to export the revision table to.</param>
    /// <param name="FileFormat">Input FileFormatEnum that specifies the file format to save to.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for export. Valid inputs are listed in the table below. NameValue TypeValid for export formats
    /// TableNameStringkMicrosoftExcel
    /// ExportedColumnsString containing semicolon separated column titlesAll
    /// IncludeTitleBooleankMicrosoftExcel, kTextFileCommaDelimited, kTextFileTabDelimited, kUnicodeTextFileCommaDelimited, kUnicodeTextFileTabDelimited
    /// StartingCellStringkMicrosoftExcel
    /// TemplateStringkMicrosoftExcel
    /// AutoFitColumnWidthBooleankMicrosoftExcel</param>
    [PreserveSig]
    void Export([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] FileFormatEnum FileFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Changes the sort order of rows in the revision table.
    /// </summary>
    /// <param name="PrimaryColumnTitle">Input string that specifies the primary column to use for the sorting.  If the name of a non-existing column is provided, an error occurs.</param>
    /// <param name="PrimaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa.  If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    /// <param name="SecondaryColumnTitle">Optional input string that specifies the secondary column to use for the sorting.  If the name of a non-existing column or the primary column is provided, an error occurs.</param>
    /// <param name="SecondaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa.  If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    /// <param name="TertiaryColumnTitle">Optional input string that specifies the tertiary column to use for the sorting.  If the name of a non-existing column, the primary column or the secondary column is provided, an error occurs.</param>
    /// <param name="TertiaryColumnAscending">Optional input Boolean that specifies whether to sort from the lowest value to the highest or vice versa.  If not specified, a default value of True is used indicating that the sorting will be from the lowest value to the highest.</param>
    [PreserveSig]
    void Sort([In] [MarshalAs(UnmanagedType.BStr)] string PrimaryColumnTitle, [In] bool? PrimaryColumnAscending = true, [In] [MarshalAs(UnmanagedType.BStr)] string? SecondaryColumnTitle = "", [In] bool? SecondaryColumnAscending = true, [In] [MarshalAs(UnmanagedType.BStr)] string? TertiaryColumnTitle = "", [In] bool? TertiaryColumnAscending = true);
    /// <summary>
    /// Copies the revision table to another sheet, sheet scope revision tables may not be copied.
    /// </summary>
    /// <param name="TargetSheet">Input Sheet object that specifies the sheet to copy the revision table to.</param>
    /// <returns></returns>
    [PreserveSig]
    RevisionTable CopyTo([In] [MarshalAs(UnmanagedType.Interface)] Sheet TargetSheet);
}
