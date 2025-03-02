namespace Oblikovati.API;

/// <summary>
/// The HoleTables collection object represents all the hole tables on a sheet.
/// </summary>
public interface HoleTables : IEnumerable
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
    /// Returns the specified HoleTable object from the collection.
    /// </summary>
    HoleTable Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new hole table by including all holes in the input drawing view. Only those feature types specified in the input (or the default) hole table style will be included. The newly created HoleTable is returned.
    /// </summary>
    /// <param name="DrawingView">Input DrawingView object that specifies the drawing view for which the hole table is to be created.</param>
    /// <param name="PlacementPoint">Input Point2d object that specifies the position of the top left corner of the table on the sheet.</param>
    /// <param name="HoleTableStyle">Optional input HoleTableStyle object that specifies the hole table style to use for the table. If not specified, the default style specified by the standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the table. If not specified, the default layer specified by the standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleTable Add([In] [MarshalAs(UnmanagedType.Interface)] DrawingView DrawingView, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] [MarshalAs(UnmanagedType.Struct)] object? HoleTableStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates a new hole table by including only the specified holes. The newly created HoleTable is returned.
    /// </summary>
    /// <param name="Holes">Input ObjectCollection which specifies the holes to create the table with. The collection may contain DrawingCurve objects that represent hole features or circular extrude cuts, or Centermark objects (which include recovered punch centers). All the holes must belong to the same drawing view, else an error will occur.</param>
    /// <param name="PlacementPoint">Input Point2d object that specifies the position of the top left corner of the table on the sheet.</param>
    /// <param name="HoleTableStyle">Optional input HoleTableStyle object that specifies the hole table style to use for the table. If not specified, the default style specified by the standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the table. If not specified, the default layer specified by the standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleTable AddSelected([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Holes, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] [MarshalAs(UnmanagedType.Struct)] object? HoleTableStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates a new hole table by including only the holes that are of the specified type in the input drawing view. The newly created HoleTable is returned.
    /// </summary>
    /// <param name="DrawingView">Input DrawingView object that specifies the drawing view for which the hole table is to be created.</param>
    /// <param name="PlacementPoint">Input Point2d object that specifies the position of the top left corner of the table on the sheet.</param>
    /// <param name="IncludeDrilledHoleFeatures">Input Boolean that specifies whether to include drilled hole features.</param>
    /// <param name="IncludeCounterBoreHoleFeatures">Input Boolean that specifies whether to include counterbored hole features.</param>
    /// <param name="IncludeCounterSinkHoleFeatures">Input Boolean that specifies whether to include countersunk hole features.</param>
    /// <param name="IncludeThreadedHoleFeatures">Input Boolean that specifies whether to include threaded hole features.</param>
    /// <param name="IncludeCircularCuts">Input Boolean that specifies whether to include circular extruded cuts. Circular cuts are recognized only as drilled thru or drilled blind holes, and do not include mid-plane extrusions.</param>
    /// <param name="IncludeCentermarks">Input Boolean that specifies whether to include center marks. Center marks with visibility turned off are not included in the hole table.</param>
    /// <param name="IncludeRecoveredPunchCenters">Input Boolean that specifies whether to include recovered punch center marks. Punch center marks with visibility turned off are not included in the hole table.</param>
    /// <param name="HoleTableStyle">Optional input HoleTableStyle object that specifies the hole table style to use for the table. If not specified, the default style specified by the standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the table. If not specified, the default layer specified by the standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    HoleTable AddByFeatureType([In] [MarshalAs(UnmanagedType.Interface)] DrawingView DrawingView, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] bool IncludeDrilledHoleFeatures, [In] bool IncludeCounterBoreHoleFeatures, [In] bool IncludeCounterSinkHoleFeatures, [In] bool IncludeThreadedHoleFeatures, [In] bool IncludeCircularCuts, [In] bool IncludeCentermarks, [In] bool IncludeRecoveredPunchCenters, [In] [MarshalAs(UnmanagedType.Struct)] object? HoleTableStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
}
