namespace Oblikovati.API;

/// <summary>
/// This object represents a row in the revision table.
/// </summary>
public interface RevisionTableRow : IEnumerable
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
    /// Property that returns the parent RevisionTable.
    /// </summary>
    RevisionTable Parent { get; }
    /// <summary>
    /// Returns the specified Cell object from the collection.
    /// </summary>
    RevisionTableCell this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets/Sets the height of the RevisionTable row.
    /// </summary>
    double Height { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether this is the active row of the revision table. When set this property it can only be set from False to True to make current RevisionTableRow the active row.
    /// </summary>
    bool IsActiveRow { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the row is visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets whether this is a custom row.
    /// </summary>
    bool Custom { get; }
    /// <summary>
    /// Method that deletes the RevisionTableRow and any associated revision tags.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that repositions the row within the revision table.
    /// </summary>
    /// <param name="TargetIndex">Optional input Long that specifies the existing row next to which the row will be inserted.  The valid range of values is 0 to the number of existing rows in the table.  The position remains unchanged if the index of the row being moved is specified.  A value of 0 will put the row at the end.  If not specified, a default value of 0 is used, indicating that the row will be moved to the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the row should be inserted before or after the target index.  If not specified, a default value of True is used indicating that the row will be inserted before the target index.  This argument is ignored if the value of TargetIndex is 0.</param>
    [PreserveSig]
    void Reposition([In] int? TargetIndex = default, [In] bool? InsertBefore = true);
}
