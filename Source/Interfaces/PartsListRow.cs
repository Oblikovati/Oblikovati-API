namespace Oblikovati.API;

/// <summary>
/// The PartsListRow object represents a row in a parts list table.
/// </summary>
public interface PartsListRow : IEnumerable
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
    /// Property that gets the parent object from whom this object can logically be reached.
    /// </summary>
    PartsList Parent { get; }
    /// <summary>
    /// Returns the specified PartsListCells object from the collection. This is the default property of the PartsListCells collection object.
    /// </summary>
    PartsListCell this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns whether this row is a nested one. (i.e. it references an assembly.)
    /// </summary>
    bool Expandable { get; }
    /// <summary>
    /// Gets or sets whether this row is expanded if this row is a nested one i.e. it references an assembly.
    /// </summary>
    bool Expanded { get; set; }
    /// <summary>
    /// Gets and sets whether the row is visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns whether this row is a custom row.
    /// </summary>
    bool Custom { get; }
    /// <summary>
    /// Property that returns whether the item represented by this row in the parts list has been ballooned.
    /// </summary>
    bool Ballooned { get; }
    /// <summary>
    /// Property that returns an enumerator of DrawingBOMRow objects.
    /// </summary>
    ObjectsEnumerator ReferencedRows { get; }
    /// <summary>
    /// Gets and sets the height of the parts list row.
    /// </summary>
    double Height { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ReferencedFileDescriptors ReferencedFiles { get; }
    /// <summary>
    /// Method that removes this row from the parts list. This method works only for custom rows.
    /// </summary>
    [PreserveSig]
    void Remove();
    /// <summary>
    /// Method that repositions the row within the parts list.
    /// </summary>
    /// <param name="TargetIndex">Optional input Long that specifies the existing row next to which the row will be inserted. The valid range of values is 0 to the number of existing rows in the table. The position remains unchanged if the index of the row being moved is specified. A value of 0 will put the row at the end. If not specified, a default value of 0 is used, indicating that the row will be moved to the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the row should be inserted before or after the target index. If not specified, a default value of True is used indicating that the row will be inserted before the target index. This argument is ignored if the value of TargetIndex is 0.</param>
    [PreserveSig]
    void Reposition([In] int? TargetIndex = default, [In] bool? InsertBefore = true);
    /// <summary>
    /// Saves any overrides to the item values in the balloon to the model BOM.
    /// </summary>
    [PreserveSig]
    void SaveItemOverridesToBOM();
}
