namespace Oblikovati.API;

/// <summary>
/// The Centerlines collection object provides access to all the centerlines on a sheet.
/// </summary>
public interface Centerlines : IEnumerable
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
    /// Method that returns the specified Centerline object from the collection.
    /// </summary>
    Centerline Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new centerline. The centerline created with this method is kRegularCenterline type.
    /// </summary>
    /// <param name="CenterEntities">Input ObjectCollection object that contains the set of entities that define the points the centerline passes through. Valid objects for input are GeometryIntent objects that reference circular or elliptical drawing curves, GeometryIntent objects that reference the end or midpoint of linear drawing curves, and center marks. Providing two points will result in a linear centerline. Providing three points will result in a circular centerline. Providing more than three points will result in a linear or a circular centerline depending on whether all of the input points lie on a circle.</param>
    /// <param name="CentermarkStyle">Object that specifies the center mark style to use for the centerline. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Object that specifies the layer to use for the centerline. If not specified, the layer defined by the active standard is used.</param>
    /// <param name="Closed">Input Boolean that is only used in the case of a circular centerline. This indicates if it should be closed or not.</param>
    /// <returns></returns>
    [PreserveSig]
    Centerline Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection CenterEntities, [In] [MarshalAs(UnmanagedType.Struct)] object? CentermarkStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default, [In] bool? Closed = false);
    /// <summary>
    /// Method that creates a new bisector centerline. The centerline created with this method is kBisectorCenterline type.
    /// </summary>
    /// <param name="EntityOne">Input GeometryIntent that defines the first entity to bisect. This can be a line or a circular entity.</param>
    /// <param name="EntityTwo">Input GeometryIntent that defines the second entity to bisect. If the first entity was a line then this must also be a line. If the first entity was a circular entity then this must be a circular entity that is concentric to the first entity.</param>
    /// <param name="CentermarkStyle">Object that specifies the center mark style to use for the centerline. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Object that specifies the layer to use for the centerline. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    Centerline AddBisector([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? CentermarkStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates a center line that represents the work feature within the drawing view.
    /// </summary>
    /// <param name="WorkFeature">Specifies the work feature to create the center line for. This can be a WorkAxis or WorkPlane object. In the case of a WorkPlane object, the work plane must be oriented so it is perpendicular to the plane of the sheet, (only the edge of the work plane is visible within that view). If an work plane is provided that does not meet this criteria the method will fail.
    /// When working with an assembly the input WorkAxis or WorkPlane must always be with respect to the top-level. This means that work points or axes that exist within the parts or sub-assemblies must be represented by WorkAxisProxy or WorkPlaneProxy objects.</param>
    /// <param name="DrawingView">Specifies the drawing view to create the centerline within.</param>
    /// <param name="CentermarkStyle">Object that specifies the center mark style to use for the centerline. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Object that specifies the layer to use for the centerline. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    Centerline AddByWorkFeature([In] [MarshalAs(UnmanagedType.IDispatch)] object WorkFeature, [In] [MarshalAs(UnmanagedType.Interface)] DrawingView DrawingView, [In] [MarshalAs(UnmanagedType.Struct)] object? CentermarkStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates a new centerline pattern. The centerline created with this method is kCenteredPatternCenterline type.
    /// </summary>
    /// <param name="PatternCenter">Input GeometryIntent that defines the a circular or elliptical drawing curve that defines the center of the pattern.</param>
    /// <param name="CenterEntities">Input ObjectCollection object that contains the set of entities that define the points the centerline passes through. Valid objects for input are GeometryIntent objects that reference circular or elliptical drawing curves, and center marks.</param>
    /// <param name="CentermarkStyle">Object that specifies the center mark style to use for the centerline. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Object that specifies the layer to use for the centerline. If not specified, the layer defined by the active standard is used.</param>
    /// <param name="Closed">Input Boolean that indicates if the centerline should be closed or not.</param>
    /// <returns></returns>
    [PreserveSig]
    Centerline AddCenteredPattern([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent PatternCenter, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection CenterEntities, [In] [MarshalAs(UnmanagedType.Struct)] object? CentermarkStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default, [In] bool? Closed = false);
}
