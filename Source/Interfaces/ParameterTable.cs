namespace Oblikovati.API;

/// <summary>
/// The ParameterTable object represents the connection to a spreadsheet. From the ParameterTable object you can access the spreadsheet and the properties that define how the spreadsheet is read. In addition, the ParameterTable object provides access to the parameters that were created as a result of reading in the spreadsheet.
/// </summary>
public interface ParameterTable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent object of this ParameterTable. This property will return different types of objects depending on the document type the ParameterTable is contained in. If the ParameterTable is in a part document then the parent is a PartComponentDefinition object. If the ParameterTable is in an assembly document then the parent is an AssemblyComponentDefinition. If the document is a drawing document then the parent is a DraftDocument.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the TableParameters collection object.
    /// </summary>
    TableParameters TableParameters { get; }
    /// <summary>
    /// Property that specifies if the Excel document is linked or embedded to the Autodesk Inventor document.
    /// </summary>
    bool Linked { get; }
    /// <summary>
    /// Gets/Sets the File Name of this linked table. Fails if this table is embedded. Setting a new File Name may add new parameters, update existing ones, and may turn some to DriverLost.
    /// </summary>
    string FileName { get; set; }
    /// <summary>
    /// Property that returns the Excel WorkSheet object. Using the Excel Automation interface you can query and modify the contents of the sheet.
    /// </summary>
    object WorkSheet { get; }
    /// <summary>
    /// Gets the starting cell in the WorkSheet from which the table is derived.
    /// </summary>
    string StartCell { get; set; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets the description of the linked file.
    /// </summary>
    ReferencedOLEFileDescriptor ReferencedFileDescriptor { get; }
    /// <summary>
    /// Method that deletes the ParameterTable object.
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
    /// Exports the ParameterTable to an external file.
    /// </summary>
    /// <param name="FileName">Input string that specifies the file name to export the ParameterTable to.</param>
    /// <param name="FileFormat">Input FileFormatEnum that specifies the file format to save to.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for export.</param>
    [PreserveSig]
    void Export([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] FileFormatEnum FileFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
