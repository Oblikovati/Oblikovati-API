namespace Oblikovati.API;

/// <summary>
/// The CustomTables object contains the collection of objects for a given Sheet. See the Custom Tables overview for more information.
/// </summary>
public interface CustomTables : IEnumerable
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
    /// Returns the specified object in the collection.
    /// </summary>
    CustomTable Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Title">Title</param>
    /// <param name="PlacementPoint">PlacementPoint</param>
    /// <param name="NumberOfColumns">NumberOfColumns</param>
    /// <param name="NumberOfRows">NumberOfRows</param>
    /// <param name="ColumnTitles">ColumnTitles</param>
    /// <param name="Contents">Contents</param>
    /// <param name="ColumnWidths">ColumnWidths</param>
    /// <param name="RowHeights">RowHeights</param>
    /// <param name="MoreInfo">MoreInfo</param>
    [PreserveSig]
    CustomTable Add([In] [MarshalAs(UnmanagedType.BStr)] string Title, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] int NumberOfColumns, [In] int NumberOfRows, [Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] ColumnTitles, [In] [MarshalAs(UnmanagedType.Struct)] object? Contents = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ColumnWidths = default, [In] [MarshalAs(UnmanagedType.Struct)] object? RowHeights = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MoreInfo = default);
    /// <summary>
    /// Method that creates a TableFormat object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    TableFormat CreateTableFormat();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SheetMetalFileName">SheetMetalFileName</param>
    /// <param name="PlacementPoint">PlacementPoint</param>
    /// <param name="Title">Title</param>
    /// <param name="Columns">Columns</param>
    /// <param name="BendIDNumericFormat">BendIDNumericFormat</param>
    /// <param name="BendIDPrefix">BendIDPrefix</param>
    [PreserveSig]
    CustomTable AddBendTable([In] [MarshalAs(UnmanagedType.BStr)] string SheetMetalFileName, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] [MarshalAs(UnmanagedType.BStr)] string? Title = "", [In] [MarshalAs(UnmanagedType.Struct)] object? Columns = default, [In] bool? BendIDNumericFormat = true, [In] [MarshalAs(UnmanagedType.BStr)] string? BendIDPrefix = "");
    /// <summary>
    /// Method that creates a new bend table. The newly created CustomTable is returned.
    /// </summary>
    /// <param name="SheetMetalFileName">Input String that specifies the full file name of the sheet metal file to create the bend table from.  The input file name must be that of a sheet metal file with at least one flat pattern created in it, else an error will occur.</param>
    /// <param name="PlacementPoint">Input Point2d object that defines the placement point of the table on the sheet.</param>
    /// <param name="Options">Optional input NameValueMap that specifies more options to create the bend table.
    /// Valid options are:
    /// Name = “Title”. Value = String that specifies the title (or the header) of the table.
    /// Name = “Columns”. Value = Array of Strings that specifies the columns of the bend table.  The strings can be any or all of the following in any order: “BEND ID”, “BEND DIRECTION”, “BEND ANGLE”, “BEND RADIUS”，“BEND ALT RADIUS”  and “ BEND KFACTOR”.  If not specified, the default columns “BEND ID”, “BEND DIRECTION”, “BEND ANGLE” and “BEND RADIUS” are created.
    /// Name = “BendIDNumericFormat”. Value = Boolean that specifies whether the format of the Bend ID is alphabetic or numeric.  If not specified, a value of True is used indicating that numeric format will be used.
    /// Name = “BendIDPrefix”. Value = String that specifies a prefix for the Bend IDs.</param>
    /// <returns></returns>
    [PreserveSig]
    CustomTable AddBendTableWithOptions([In] [MarshalAs(UnmanagedType.BStr)] string SheetMetalFileName, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Method that creates a new configuration (iPart/iAssembly) table. The newly created CustomTable is returned.
    /// </summary>
    /// <param name="ConfigurationFileName">Input String that specifies the full file name of the configuration file to create the configuration table from. The file can be an iPart, an iAssembly, or a Presentation file which contains views of an iPart or an iAssembly.</param>
    /// <param name="PlacementPoint">Input Point2d object that defines the placement point of the table on the sheet.</param>
    /// <param name="Title">Optional input String that specifies the title (or the header) of the table.</param>
    /// <param name="Columns">Optional input array of Strings that specifies the columns of the configuration table. The strings specified must be the headings of the columns from the iPart or the iAssembly (obtained using iPartTableColumn.Heading or iAssemblyTableColumn.Heading properties). If not specified, only the 'Member' column is used to create the table.</param>
    /// <returns></returns>
    [PreserveSig]
    CustomTable AddConfigurationTable([In] [MarshalAs(UnmanagedType.BStr)] string ConfigurationFileName, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] [MarshalAs(UnmanagedType.BStr)] string? Title = "", [In] [MarshalAs(UnmanagedType.Struct)] object? Columns = default);
    /// <summary>
    /// Method that creates a new custom table based on an excel file. The newly created CustomTable is returned.
    /// </summary>
    /// <param name="ExcelFileName">Input String that specifies the full file name of the excel file.</param>
    /// <param name="PlacementPoint">Input Point2d object that defines the placement point of the table on the sheet.</param>
    /// <param name="Title">Optional input String that specifies the title (or the header) of the table.</param>
    /// <param name="StartCell">Optional input String that specifies the start cell of the data in the excel file. If not specified, the cell 'A2' is used as the start cell.</param>
    /// <param name="ColumnHeaderRow">Optional input Long that specifies the header row in the excel file. If not specified, the first row in the excel file is assumed to be the header row.</param>
    /// <returns></returns>
    [PreserveSig]
    CustomTable AddExcelTable([In] [MarshalAs(UnmanagedType.BStr)] string ExcelFileName, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] [MarshalAs(UnmanagedType.BStr)] string? Title = "", [In] [MarshalAs(UnmanagedType.BStr)] string? StartCell = "A2", [In] int? ColumnHeaderRow = default);
    /// <summary>
    /// Method that creates a new custom table based on a CSV (comma delimited) file. The newly created CustomTable is returned.
    /// </summary>
    /// <param name="CSVFileName">Input String that specifies the full file name of the CSV (comma delimited) file.</param>
    /// <param name="PlacementPoint">Input Point2d object that defines the placement point of the table on the sheet.</param>
    /// <param name="Title">Optional input String that specifies the title (or the header) of the table.</param>
    /// <param name="UseFirstRowForHeaders">Optional input Boolean that specifies whether to use the first row for column headers. If not specified, this argument defaults to True.</param>
    /// <returns></returns>
    [PreserveSig]
    CustomTable AddCSVTable([In] [MarshalAs(UnmanagedType.BStr)] string CSVFileName, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] [MarshalAs(UnmanagedType.BStr)] string? Title = "", [In] bool? UseFirstRowForHeaders = true);
}
