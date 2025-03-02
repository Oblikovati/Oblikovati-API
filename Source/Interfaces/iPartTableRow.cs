namespace Oblikovati.API;

/// <summary>
/// The iPartTableRow object represents a row in the iPart factory table.
/// </summary>
public interface iPartTableRow : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified iPartTableCell object from the collection. This is the default property of the iPartTableRow object.
    /// </summary>
    iPartTableCell this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent iPartFactory object.
    /// </summary>
    iPartFactory Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string PartIdentifier { get; }
    /// <summary>
    /// Gets the filename corresponding to this row in the iPart table.
    /// </summary>
    string PartName { get; set; }
    /// <summary>
    /// Property that returns the index of this row within the iPart factory table.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Property that returns whether the name of the document corresponding to this member can be modified. This property also returns False if the corresponding cell in Excel contains a formula.
    /// </summary>
    bool PartNameModifiable { get; }
    /// <summary>
    /// Gets whether the member's filename is based on the member name or an explicitly set filename.
    /// </summary>
    bool IsPartNameBasedOnMemberName { get; }
    /// <summary>
    /// Property that returns the member name corresponding to this row in the iPart table.
    /// </summary>
    string MemberName { get; }
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
    /// <param name="NewMemberName">Optional input string that specifies the member name for the new row. If not specified, a member name is automatically generated.</param>
    /// <returns></returns>
    [PreserveSig]
    iPartTableRow Copy([In] [MarshalAs(UnmanagedType.BStr)] string? NewMemberName = "");
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
