namespace Oblikovati.API;

/// <summary>
/// The Columns collection object represents the collection of objects for this table.See the Custom Tables overview for more information.
/// </summary>
public interface Columns : IEnumerable
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
    /// Returns the specified Column object from the collection.
    /// </summary>
    Column this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new Column. The new created Column is returned.
    /// </summary>
    /// <param name="Title">Input String that specifies the title for the column.</param>
    /// <param name="TargetIndex">Optional input Long that specifies the existing column next to which the new column will be inserted. The valid range of values is 0 to the number of existing columns in the table. A value of 0 will put the row at the end. If not specified, a default value of 0 is used, indicating that the column will be added at the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the column should be inserted before or after the target index. If not specified, a default value of True is used. This argument is ignored if the value of TargetIndex is 0.</param>
    /// <param name="Width">Optional input Double that specifies the width of the column. If not specified, a default value is used.</param>
    /// <returns></returns>
    [PreserveSig]
    Column Add([In] [MarshalAs(UnmanagedType.BStr)] string Title, [In] int? TargetIndex = default, [In] bool? InsertBefore = true, [In] [MarshalAs(UnmanagedType.Struct)] object? Width = default);
}
