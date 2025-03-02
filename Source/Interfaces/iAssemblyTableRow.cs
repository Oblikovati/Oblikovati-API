namespace Oblikovati.API;

/// <summary>
/// The iAssemblyTableRow object represents a row in the iAssembly factory table.
/// </summary>
public interface iAssemblyTableRow : IEnumerable
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
    /// Property that returns the parent iAssemblyFactory object.
    /// </summary>
    iAssemblyFactory Parent { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified iAssemblyTableCell object from the collection.
    /// </summary>
    iAssemblyTableCell Item { get; }
    /// <summary>
    /// Property that returns the index of this row within the iAssembly factory table.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Property that returns the member name corresponding to this row in the iAssembly table.
    /// </summary>
    string MemberName { get; }
    /// <summary>
    /// Gets and sets the document name corresponding to this row in the iAssembly table.
    /// </summary>
    string DocumentName { get; set; }
    /// <summary>
    /// Property that returns whether the name of the document corresponding to this member can be modified.
    /// </summary>
    bool DocumentNameModifiable { get; }
    /// <summary>
    /// Gets whether the member's filename is based on the member name or an explicitly set filename.
    /// </summary>
    bool IsDocumentNameBasedOnMemberName { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Method that deletes this row in the factory.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that creates a new row with all values equal to the original row.
    /// </summary>
    /// <param name="NewMemberName">Name of new row member.</param>
    /// <returns></returns>
    [PreserveSig]
    iAssemblyTableRow Copy([In] [MarshalAs(UnmanagedType.BStr)] string? NewMemberName = "");
    /// <summary>
    /// Method that returns whether the input object is excluded in this member.
    /// </summary>
    /// <param name="Object">Object to check for exclusion.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsExcluded([In] [MarshalAs(UnmanagedType.IDispatch)] object Object);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
