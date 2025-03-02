namespace Oblikovati.API;

/// <summary>
/// The CustomTable object allows the creation of user-defined tables with the specified number of rows and columns, headings, content, and so on. See the Custom Tables overview for more information.
/// </summary>
public interface CustomTable
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
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the Columns collection object.
    /// </summary>
    Columns Columns { get; }
    /// <summary>
    /// Property that returns the Rows collection object.
    /// </summary>
    Rows Rows { get; }
    /// <summary>
    /// Specifies the position of the table.
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Specifies the title of the table.
    /// </summary>
    string Title { get; set; }
    /// <summary>
    /// Gets and sets the placement position of the table heading.
    /// </summary>
    HeadingPlacementEnum HeadingPlacement { get; set; }
    /// <summary>
    /// Gets and sets the table format.
    /// </summary>
    TableFormat OverrideFormat { get; set; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Gets and sets the layer used by the table.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Property that returns either a DocumentDescriptor object (for Inventor references) or a FileDescriptor object (for foreign file references). The property returns Nothing if no links have been specified for the table.
    /// </summary>
    object ReferencedDocumentDescriptor { get; }
    /// <summary>
    /// Gets and sets whether to show the title of the table.
    /// </summary>
    bool ShowTitle { get; set; }
    /// <summary>
    /// Property that returns the source type for this table.
    /// </summary>
    TableSourceTypeEnum TableSource { get; }
    /// <summary>
    /// Gets and sets the absolute rotation angle of the table in radians.
    /// </summary>
    double Rotation { get; set; }
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
    /// Property that returns the row gap.
    /// </summary>
    double RowGap { get; }
    /// <summary>
    /// Gets and sets the spacing between the rows.
    /// </summary>
    LineSpacingEnum RowLineSpacing { get; set; }
    /// <summary>
    /// Gets and sets whether to split the table equally.
    /// </summary>
    bool WrapAutomatically { get; set; }
    /// <summary>
    /// Gets and sets whether the sections of the table are moved to the left or right when the number of rows increase.
    /// </summary>
    bool WrapLeft { get; set; }
    /// <summary>
    /// Gets and sets the maximum number of rows per section.
    /// </summary>
    int MaximumRows { get; set; }
    /// <summary>
    /// Gets and sets the number of columns to wrap.
    /// </summary>
    int NumberOfSections { get; set; }
    /// <summary>
    /// Gets and sets the vertical direction of the table.
    /// </summary>
    TableDirectionEnum TableDirection { get; set; }
    /// <summary>
    /// Gets and sets whether the bend direction is reversed.
    /// </summary>
    bool BendDirectionReversed { get; set; }
    /// <summary>
    /// Gets and sets the style associated with this object.
    /// </summary>
    TableStyle Style { get; set; }
    /// <summary>
    /// Method that deletes the CustomTable.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that adds a link to the specified document. If a link to a foreign file type already exists, the link is replaced if the input is also a foreign file.
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the full file name of the file to add a link to.</param>
    [PreserveSig]
    void AddLink([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName);
    /// <summary>
    /// Method that renumbers all rows in the table. This method applies only to bend tables and returns an error for all other tables.
    /// </summary>
    [PreserveSig]
    void Renumber();
    /// <summary>
    /// Method that sorts the table.
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
    /// Method that saves the custom table to an external file.
    /// </summary>
    /// <param name="FileName">Input string that specifies the file name to export the table to.</param>
    /// <param name="FileFormat">Input FileFormatEnum that specifies the file format to save to.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for export. See Remarks for valid options:</param>
    [PreserveSig]
    void Export([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] FileFormatEnum FileFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Method that updates the custom table if it is out of date with respect to its linked files. The method returns a success and returns trivially if no update is required.
    /// </summary>
    [PreserveSig]
    void Update();
    /// <summary>
    /// Method that copies the table to another sheet, either within the same document or in another document.
    /// </summary>
    /// <param name="TargetSheet">Input Sheet object that specifies the sheet to copy the custom table to.</param>
    /// <returns></returns>
    [PreserveSig]
    CustomTable CopyTo([In] [MarshalAs(UnmanagedType.Interface)] Sheet TargetSheet);
    /// <summary>
    /// Method that adds bend tags to drawing view.
    /// </summary>
    /// <param name="DrawingView">Input DrawingView object that specifies the DrawingView to add bend tags to.</param>
    [PreserveSig]
    void AddBendTagsToView([In] [MarshalAs(UnmanagedType.Interface)] DrawingView DrawingView);
}
