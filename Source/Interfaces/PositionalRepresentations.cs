namespace Oblikovati.API;

/// <summary>
/// The PositionalRepresentations collection object provides access to all the positional representations in the assembly and provides methods to create new ones.
/// </summary>
public interface PositionalRepresentations : IEnumerable
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
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified PositionalRepresentation object from the collection.
    /// </summary>
    PositionalRepresentation this[object Index] { get; }
    /// <summary>
    /// Property that returns the Excel spreadsheet that contains the positional representations data.
    /// </summary>
    object ExcelWorkSheet { get; }
    /// <summary>
    /// Method that creates a new PositionalRepresentation. The new created PositionalRepresentation is returned.
    /// </summary>
    /// <param name="Name">Optional input string that specifies the name of the positional representation to create. If not specified, Inventor assigns a name to the representation.</param>
    /// <returns></returns>
    [PreserveSig]
    PositionalRepresentation Add([In] [MarshalAs(UnmanagedType.BStr)] string? Name = "");
    /// <summary>
    /// Exports the PositionalRepresentations to an external file.
    /// </summary>
    /// <param name="FileName">Input string that specifies the file name to export the PositionalRepresentations to.</param>
    /// <param name="FileFormat">Input FileFormatEnum that specifies the file format to save to.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for export.</param>
    [PreserveSig]
    void Export([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] FileFormatEnum FileFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
