namespace Oblikovati.API;

/// <summary>
/// The ContentTableRows object is a collection that provides access to the rows of the table associated with a particular content center family.
/// </summary>
public interface ContentTableRows : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of ContentTableRow objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ContentTableRow object from the collection.
    /// </summary>
    ContentTableRow this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RowData">RowData</param>
    /// <param name="Position">Position</param>
    [PreserveSig]
    ContentTableRow Add([Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] RowData, [In] int? Position = default);
}
