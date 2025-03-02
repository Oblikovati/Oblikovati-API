namespace Oblikovati.API;

/// <summary>
/// The ChainDimensionSets collection object provides access to all of the chain dimension sets on the sheet.
/// </summary>
public interface ChainDimensionSets : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Method that returns the specified dimension set object from the collection.
    /// </summary>
    ChainDimensionSet Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that creates a chain dimension set using the specified geometries. Returns the newly created ChainDimensionSets object.
    /// </summary>
    /// <param name="GeometryIntents">Input ObjectCollection containing GeometryIntent objects. The GeometryIntent objects specify the geometries to use for the dimension set. A GeometryIntent object can be created using the Sheet.CreateGeometryIntent method.</param>
    /// <param name="PlacementPoint">Input Point2d object that specifies the placement point of the dimension set on the sheet.</param>
    /// <param name="DimensionType">Input DimensionTypeEnum that specifies the dimension type. Valid values kHorizontalDimensionType, kVerticalDimensionType and kAlignedDimensionType. The value kAlignedDimensionType can be specified only if the first geometry specified in the input GeometryIntents collection represents a line which is not parallel to the x or y axes of the sheet. If kAlignedDimensionType is specified, the placement point decides the orientation of the dimension set.</param>
    /// <param name="DimensionStyle">Optional input DimensionStyle object that specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ChainDimensionSet Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection GeometryIntents, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PlacementPoint, [In] DimensionTypeEnum DimensionType, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates a chain dimension set based on the specified base dimension and using specified additional geometry. Returns the newly created ChainDimensionSet object.
    /// </summary>
    /// <param name="GeometryIntents">Input ObjectCollection containing GeometryIntent objects. The GeometryIntent objects specify the geometries to use for the dimension set. A GeometryIntent object can be created using the Sheet.CreateGeometryIntent method.</param>
    /// <param name="DimensionStyle">Optional input DimensionStyle object that specifies the dimension style to use for the dimension. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Optional input Layer object that specifies the layer to use for the dimension. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ChainDimensionSet AddUsingBaseDimension([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Dimensions, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection GeometryIntents, [In] [MarshalAs(UnmanagedType.Struct)] object? DimensionStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
}
