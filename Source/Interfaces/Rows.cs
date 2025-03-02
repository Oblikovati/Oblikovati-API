namespace Oblikovati.API;

/// <summary>
/// The Rows collection object represents all the objects contained by this custom table. See the Custom Tables overview for more information.
/// </summary>
public interface Rows : IEnumerable
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
    /// Returns the specified Row object from the collection.
    /// </summary>
    Row Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new Row. The new created Row is returned.
    /// </summary>
    /// <param name="TargetIndex">Optional input Long that specifies the existing row next to which the new row will be inserted. The valid range of values is 0 to the number of existing rows in the table. A value of 0 will put the row at the end. If not specified, a default value of 0 is used, indicating that the row will be added at the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the row should be inserted before or after the target index. If not specified, a default value of True is used. This argument is ignored if the value of TargetIndex is 0.</param>
    /// <param name="Contents">Optional input array of Strings that specifies the contents of the new row. The number of strings should be equal to the number of columns in the table, else an error will occur.</param>
    /// <param name="Height">Optional input Double that specifies the height of the row. If not specified, a default value is used.</param>
    /// <returns></returns>
    [PreserveSig]
    Row Add([In] int? TargetIndex = default, [In] bool? InsertBefore = true, [In] [MarshalAs(UnmanagedType.Struct)] object? Contents = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Height = default);
}
