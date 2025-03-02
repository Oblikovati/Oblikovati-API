namespace Oblikovati.API;

/// <summary>
/// The PartsListRows collection object provides access to all existing objects in the parts list.
/// </summary>
public interface PartsListRows : IEnumerable
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
    /// Returns the specified PartsListRows object from the collection. This is the default property of the PartsListRows collection object.
    /// </summary>
    PartsListRow this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a custom PartsListRow. The newly created PartsListRow is returned.
    /// </summary>
    /// <param name="TargetIndex">Optional input Long that specifies the existing row next to which the new row will be inserted. The valid range of values is 0 to the number of existing rows in the table. A value of 0 will put the row at the end. If not specified, a default value of 0 is used, indicating that the row will be added at the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the row should be inserted before or after the target index. If not specified, a default value of True is used. This argument is ignored if the value of TargetIndex is 0.</param>
    /// <returns></returns>
    [PreserveSig]
    PartsListRow Add([In] int? TargetIndex = default, [In] bool? InsertBefore = true);
}
