namespace Oblikovati.API;

/// <summary>
/// The iPartFactory object provides access to the iPart table and provides methods to create additional iPart members ( objects).
/// </summary>
public interface iPartFactory
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
    /// Property that returns the parent PartDocument of the factory.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that specifies whether this iPartFactory object represents a custom factory or a standard factory. This property is True in the case where it represents a custom factory.
    /// </summary>
    bool CustomFactory { get; }
    /// <summary>
    /// Gets and sets the default row for this iPart factory.
    /// </summary>
    iPartTableRow DefaultRow { get; set; }
    /// <summary>
    /// Property that returns the iPartTableColumns collection object.
    /// </summary>
    iPartTableColumns TableColumns { get; }
    /// <summary>
    /// Property that returns the iPartTableRows collection object.
    /// </summary>
    iPartTableRows TableRows { get; }
    /// <summary>
    /// Property that returns the Excel spreadsheet that represents the iPart table.
    /// </summary>
    object ExcelWorkSheet { get; }
    /// <summary>
    /// Property that returns the directory location for the newly created iPart members.
    /// </summary>
    string MemberCacheDir { get; }
    /// <summary>
    /// Gets and sets whether the edits to a member should affect just the active member or all members within the factory.
    /// </summary>
    MemberEditScopeEnum MemberEditScope { get; set; }
    /// <summary>
    /// Property that gets the options for the factory.
    /// </summary>
    FactoryOptions FactoryOptions { get; }
    /// <summary>
    /// Gets and sets the column to use as the display (render) style&nbsp;column.
    /// </summary>
    iPartTableColumn DisplayStyleColumn { get; set; }
    /// <summary>
    /// Gets and sets the column to use as the file name column.
    /// </summary>
    iPartTableColumn FileNameColumn { get; set; }
    /// <summary>
    /// Gets and sets the column to use as the material&nbsp;column.
    /// </summary>
    iPartTableColumn MaterialColumn { get; set; }
    /// <summary>
    /// Method that creates an iPart member using the parameter values in a row. The created iPartMember is returned.
    /// </summary>
    /// <param name="Row">Optional input Variant that specifies the row number within an iPart table. The row index is specified either by a Long (row index), a String (PartIdentifier), or an iPartTableRow object. If a RowIndex is not specified, the default row will be used to create the iPart member.</param>
    /// <returns></returns>
    [PreserveSig]
    iPartMember CreateMember([In] [MarshalAs(UnmanagedType.Struct)] object? Row = default);
    /// <summary>
    /// Method that creates an iPart member for a custom factory using the parameter values in a row. The created iPartMember is returned.
    /// </summary>
    /// <param name="FullFileName">Input String that specifies the full filename of the iPart member.</param>
    /// <param name="Row">Optional input Variant that specifies the row number within an iPart table. The row index is specified either by a Long (row index), a String (PartIdentifier), or an iPartTableRow object. If a RowIndex is not specified, default row will be used to create the iPart member.</param>
    /// <param name="CustomInput">Optional input safearray of Strings that specifies the input to use for the custom input. If the factory is a custom factory and this is not supplied the default values for custom values are used. The custom input strings are supplied in a column order. If the factory is not a custom factory this argument is ignored.</param>
    /// <returns></returns>
    [PreserveSig]
    iPartMember CreateCustomMember([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Struct)] object? Row = default, [In] [MarshalAs(UnmanagedType.Struct)] object? CustomInput = default);
    /// <summary>
    /// Method that converts an iPart factory to a regular part. When an iPart factory is converted to a regular part, all of the iPart members created from the factory become sick.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Exports the iPartFactory to an external file.
    /// </summary>
    /// <param name="FileName">Input string that specifies the file name to export the iPartFactory to.</param>
    /// <param name="FileFormat">Input FileFormatEnum that specifies the file format to save to.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for export.</param>
    [PreserveSig]
    void Export([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] FileFormatEnum FileFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
