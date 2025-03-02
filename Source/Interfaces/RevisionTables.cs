namespace Oblikovati.API;

/// <summary>
/// The RevisionTables collection object represents all the revision history tables on a sheet and provides methods to create additional tables.
/// </summary>
public interface RevisionTables : IEnumerable
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
    /// Returns the specified RevisionTable object from the collection.
    /// </summary>
    RevisionTable Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new RevisionTable. The new created RevisionTable is returned.
    /// </summary>
    /// <param name="PlacementPoint">Input Point2d object that specifies the placement point of the revision table on the sheet.</param>
    /// <returns></returns>
    [PreserveSig]
    RevisionTable Add([In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint);
    /// <summary>
    /// Creates a new RevisionTable object on the sheet.
    /// </summary>
    /// <param name="PlacementPoint">Input Point2d object that specifies the placement point of the revision table on the sheet.</param>
    /// <param name="IsSheetScope">Optional input Boolean that specifies the scope of the revision table - False indicates sheet scope and True indicates the entire drawing scope.</param>
    /// <param name="AutoIndex">Optional input Boolean that specifies whether to automatically index revision rows. If set to False, the revision cells remain blank.  This value is ignored if a revision table of the same scope (drawing or sheet) has already been created.</param>
    /// <param name="AlphaIndex">Optional input Boolean that specifies whether the automatic indexing should be alphanumeric or numeric. Numeric by default.  This value is ignored if AutoIndex is set to False or a revision table of the same scope (drawing or sheet) has already been created.</param>
    /// <param name="StartValue">Optional input String that specifies the initial revision letter or number.  This value is ignored if AutoIndex is set to False or a revision table of the same scope (drawing or sheet) has already been created.</param>
    /// <param name="RevisionTableStyle">Optional input RevisionTableStyle object that specifies the style to use for the table.  If not provided, the default style is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the revision table.  If not provided, the default layer is used.</param>
    /// <returns></returns>
    [PreserveSig]
    RevisionTable Add2([In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] bool? IsSheetScope = false, [In] bool? AutoIndex = true, [In] bool? AlphaIndex = false, [In] [MarshalAs(UnmanagedType.BStr)] string? StartValue = "", [In] [MarshalAs(UnmanagedType.Struct)] object? RevisionTableStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
}
