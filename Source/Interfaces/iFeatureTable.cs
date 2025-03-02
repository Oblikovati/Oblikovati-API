namespace Oblikovati.API;

/// <summary>
/// The iFeatureTable object represents the table associated with a table driven iFeature. This object provides access to the contents of the table and provides information about the default and active rows.
/// </summary>
public interface iFeatureTable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property returning the parent object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets and sets the default row.
    /// </summary>
    iFeatureTableRow DefaultRow { get; set; }
    /// <summary>
    /// Property returning the collection of columns in the table.
    /// </summary>
    iFeatureTableColumns iFeatureTableColumns { get; }
    /// <summary>
    /// Property returning the collection of rows in the table.
    /// </summary>
    iFeatureTableRows iFeatureTableRows { get; }
    /// <summary>
    /// Property that returns the Excel WorkSheet object representing the iFeature table. After making changes to the Excel sheet, save and close the parent WorkBook object of the sheet in order for Inventor to absorb the changes.
    /// </summary>
    object ExcelWorkSheet { get; }
    /// <summary>
    /// Method that deletes the iFeatureTable. This converts a table driven iFeature into a standard iFeature.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Exports the iFeatureTable to an external file.
    /// </summary>
    /// <param name="FileName">Input string that specifies the file name to export the iFeatureTable to.</param>
    /// <param name="FileFormat">Input FileFormatEnum that specifies the file format to save to.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for export.</param>
    [PreserveSig]
    void Export([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] FileFormatEnum FileFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
