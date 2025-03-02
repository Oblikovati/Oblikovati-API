namespace Oblikovati.API;

/// <summary>
/// This collection object represents the column objects in a revision table.
/// </summary>
public interface RevisionTableColumns : IEnumerable
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
    RevisionTableColumn Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new revision table column based on a property.
    /// </summary>
    /// <param name="PropertyType">Input RevisionTablePropertyEnum that specifies the property type to associate with the column.  Valid values are kRevisionTableFileProperty, kRevisionTableCustomProperty, kRevisionTableDateProperty, kRevisionTableSheetProperty, kRevisionTableZoneProperty, kRevisionTableZoneSheetPropertyand kRevisionTableLtrProperty.  If kRevisionTableFileProperty is specified, the PropertySetId and PropertyIdentifier arguments are required.  If kRevisionTableCustomProperty is specified, the PropertyIdentifier argument is required.</param>
    /// <param name="PropertySetId">Optional input String that specifies the internal name of the property set that contains the property. This is the FMTID associated with the property set.  This argument is ignored if the input PropertyType is not kRevisionTableFileProperty.</param>
    /// <param name="PropertyIdentifier">Optional input Variant that identifies a property.  This could either be a Long value that specifies the PropId of a property within the specified property set or the name of a property.  Typically, a PropId should be specified when the input PropertyType is kRevisionTableFileProperty and a name should be specified when the input PropertyType is kRevisionTableCustomProperty.</param>
    /// <param name="TargetIndex">Optional input Long that specifies the existing column next to which the new column will be inserted.  The valid range of values is 0 to the number of existing columns in the table.  A value of 0 will put the row at the end.  If not specified, a default value of 0 is used, indicating that the column will be added at the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the column should be inserted before or after the target index.  If not specified, a default value of True is used.  This argument is ignored if the value of TargetIndex is 0.</param>
    /// <returns></returns>
    [PreserveSig]
    RevisionTableColumn Add([In] RevisionTablePropertyEnum PropertyType, [In] [MarshalAs(UnmanagedType.BStr)] string? PropertySetId = "", [In] [MarshalAs(UnmanagedType.Struct)] object? PropertyIdentifier = default, [In] int? TargetIndex = default, [In] bool? InsertBefore = true);
}
