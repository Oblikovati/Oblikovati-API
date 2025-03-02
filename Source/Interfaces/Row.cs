namespace Oblikovati.API;

/// <summary>
/// The Row object represents a single row in this custom table. See the Custom Tables overview for more information.
/// </summary>
public interface Row : IEnumerable
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
    /// Property that returns the parent Table.
    /// </summary>
    CustomTable Parent { get; }
    /// <summary>
    /// Returns the specified Cell object from the collection.
    /// </summary>
    Cell this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Specifies the height of the row.
    /// </summary>
    double Height { get; set; }
    /// <summary>
    /// Gets and sets whether the row is visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Method that deletes this Row object.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that repositions the row within the table.
    /// </summary>
    /// <param name="TargetIndex">Optional input Long that specifies the existing row next to which the row will be inserted. The valid range of values is 0 to the number of existing rows in the table. The position remains unchanged if the index of the row being moved is specified. A value of 0 will put the row at the end. If not specified, a default value of 0 is used, indicating that the row will be moved to the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the row should be inserted before or after the target index. If not specified, a default value of True is used indicating that the row will be inserted before the target index. This argument is ignored if the value of TargetIndex is 0.</param>
    [PreserveSig]
    void Reposition([In] int? TargetIndex = default, [In] bool? InsertBefore = true);
}
