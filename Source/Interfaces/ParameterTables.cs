namespace Oblikovati.API;

/// <summary>
/// Creates and provides access to the parameters that were created as a result of reading in a spreadsheet.
/// </summary>
public interface ParameterTables : IEnumerable
{
    /// <summary>
    /// Returns the specified ParameterTable object from the collection. This is the default property of the ParameterTables collection object.
    /// </summary>
    ParameterTable this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new ParameterTable object, given an existing Excel document as input. Returns the resulting ParameterTable object. The first sheet in the Excel document is used.
    /// </summary>
    /// <param name="ExcelDocument">Input String value that contains the full path to the Excel document.</param>
    /// <param name="StartCell">Input String value that specifies the beginning cell to begin importing from, for example "A1".</param>
    /// <param name="Link">Input Boolean value that specifies whether the Excel document is to be embedded or linked. True indicates it should be linked.</param>
    /// <returns></returns>
    [PreserveSig]
    ParameterTable AddExcelTable([In] [MarshalAs(UnmanagedType.BStr)] string ExcelDocument, [In] [MarshalAs(UnmanagedType.BStr)] string StartCell, [In] bool Link);
}
