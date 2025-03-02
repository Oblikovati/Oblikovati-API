namespace Oblikovati.API;

/// <summary>
/// The iAssemblyFactory object provides access to the iAssembly table and provides methods to create iAssembly members.
/// </summary>
public interface iAssemblyFactory
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
    /// Property that returns the parent AssemblyComponentDefinition of the factory.
    /// </summary>
    AssemblyComponentDefinition Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the default row for this iAssemblyFactory.
    /// </summary>
    iAssemblyTableRow DefaultRow { get; set; }
    /// <summary>
    /// Property that returns the iAssemblyTableColumns collection object.
    /// </summary>
    iAssemblyTableColumns TableColumns { get; }
    /// <summary>
    /// Property that returns the iAssemblyTableRows collection object.
    /// </summary>
    iAssemblyTableRows TableRows { get; }
    /// <summary>
    /// Property that returns the excel spreadsheet that represents the iAssembly table.
    /// </summary>
    object ExcelWorkSheet { get; }
    /// <summary>
    /// Property that returns the directory location for the newly created iAssembly members.
    /// </summary>
    string MemberCacheDir { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the edits to a member should affect just the active member or all members within the factory.
    /// </summary>
    MemberEditScopeEnum MemberEditScope { get; set; }
    /// <summary>
    /// Property that gets the options for the factory.
    /// </summary>
    FactoryOptions FactoryOptions { get; }
    /// <summary>
    /// Read-write property that gets and sets the column to use as the file name column.
    /// </summary>
    iAssemblyTableColumn FileNameColumn { get; set; }
    /// <summary>
    /// Method that converts the iAssembly factory to a regular assembly. When an iAssembly factory is converted to a regular assembly, all of the iAssembly members created from the factory become sick.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that creates an iAssembly member using the parameter values in a row. The created iAssemblyMember is returned. If the member already exists, the member is updated and the iAssemblyMember object is returned.
    /// </summary>
    /// <param name="Row">Optional input Variant that specifies the row number within an iAssembly table. The row index is specified either by a Long (row index), a String (MemberName), or an iAssemblyTableRow object. If the argument is not specified, the default row of the factory will be used to create the iAssembly member.</param>
    [PreserveSig]
    void CreateMember([In] [MarshalAs(UnmanagedType.Struct)] object? Row = default);
    /// <summary>
    /// Method that exports the iAssemblyFactory to an external file.
    /// </summary>
    /// <param name="FileName">Input string that specifies the file name to export the iAssemblyFactory to.</param>
    /// <param name="FileFormat">Input FileFormatEnum that specifies the file format to save to.</param>
    /// <param name="Options">Optional input NameValueMap object that specifies additional options for export.</param>
    [PreserveSig]
    void Export([In] [MarshalAs(UnmanagedType.BStr)] string FileName, [In] FileFormatEnum FileFormat, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
