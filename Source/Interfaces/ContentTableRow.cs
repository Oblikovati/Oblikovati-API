namespace Oblikovati.API;

/// <summary>
/// The ContentTableRow object represents the row of the table associated with a particular content center family.
/// </summary>
public interface ContentTableRow : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of ContentTableCell objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns the index of this row within the table.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Gets/sets the suppressed state of this row.
    /// </summary>
    bool IsSuppressed { get; set; }
    /// <summary>
    /// Returns the specified ContentTableCell object from the collection.
    /// </summary>
    ContentTableCell Item { get; }
    /// <summary>
    /// Property that returns the parent ContentFamily object.
    /// </summary>
    ContentFamily Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the internal name of the ContentTableRow. The internal name uniquely identifies this row with respect to other rows in the family and it cannot be changed so it will remain consistent.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Property that returns the identifier for this object. This can be used with the GetContentObject method of the ContentCenter object to obtain this object at a later time.
    /// </summary>
    string ContentIdentifier { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string MemberRevision { get; }
    /// <summary>
    /// Method that deletes this row from the table. Any changes to the table are not actually applied until the ContentFamily.Save method is called.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// This method returns value of cell specified by given index. Caller can specify particular custom parameters which will be used for expression evaluation.
    /// </summary>
    /// <param name="CellIndex">Input Variant value that specifies the ContentTableCell object within the collection to return. Valid index values are 1 to the value of Count, ContentTableColumn object or column internal name.</param>
    /// <param name="CustomInput">Optional input NameValueMap that specifies the input to use for the custom input. If the family is custom and this is not supplied, the default values for custom values are used. For each input value you use the NameValueMap to specify the Column ID as the name and the custom value as the new value . If the factory is not a custom factory this argument is ignored.</param>
    /// <returns></returns>
    [PreserveSig]
    string GetCellValue([In] [MarshalAs(UnmanagedType.Struct)] object CellIndex, [In] [MarshalAs(UnmanagedType.Struct)] object? CustomInput = default);
}
