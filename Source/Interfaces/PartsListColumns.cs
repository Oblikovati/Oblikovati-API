namespace Oblikovati.API;

/// <summary>
/// The PartsListColumns collection object provides access to all existing objects in the parts list.
/// </summary>
public interface PartsListColumns : IEnumerable
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
    /// Returns the specified PartsListColumn object from the collection. This is the default property of the PartsListColumns collection object.
    /// </summary>
    PartsListColumn Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new PartsListColumn based on a property. The newly created PartsListColumn is returned.
    /// </summary>
    /// <param name="PropertyType">Input PropertyTypeEnum that specifies the property type to associate with the column. Valid values are kFileProperty, kCustomProperty, kFilenamePartsListProperty, kItemPartsListProperty, kMassPartsListProperty, kMaterialPartsListProperty and kQuantityPartsListProperty. If kFileProperty is specified, the PropertySetId and PropertyIdentifier arguments are required. If kCustomProperty is specified, the PropertyIdentifier argument is required.</param>
    /// <param name="PropertySetId">Optional input String that specifies the internal name of the property set that contains the property. This is the FMTID associated with the property set. This argument is ignored if the input PropertyType is not kFileProperty.</param>
    /// <param name="PropertyIdentifier">Optional input Variant that identifies a property. This could either be a Long value that specifies the PropId of a property within the specified property set or the name of a property. Typically, a PropId should be specified when the input PropertyType is kFileProperty and a name should be specified when the input PropertyType is kCustomProperty.</param>
    /// <param name="TargetIndex">Optional input Long that specifies the existing column next to which the new column will be inserted. The valid range of values is 0 to the number of existing columns in the table. A value of 0 will put the row at the end. If not specified, a default value of 0 is used, indicating that the column will be added at the end.</param>
    /// <param name="InsertBefore">Optional input Boolean indicating if the column should be inserted before or after the target index. If not specified, a default value of True is used. This argument is ignored if the value of TargetIndex is 0.</param>
    /// <returns></returns>
    [PreserveSig]
    PartsListColumn Add([In] PropertyTypeEnum PropertyType, [In] [MarshalAs(UnmanagedType.BStr)] string? PropertySetId = "", [In] [MarshalAs(UnmanagedType.Struct)] object? PropertyIdentifier = default, [In] int? TargetIndex = default, [In] bool? InsertBefore = true);
}
