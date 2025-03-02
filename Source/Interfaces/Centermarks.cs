namespace Oblikovati.API;

/// <summary>
/// The Centermarks collection object provides access to all the center marks on a sheet and provides functionality to create new center marks.
/// </summary>
public interface Centermarks : IEnumerable
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
    /// Method that returns the specified Centermark object from the collection.
    /// </summary>
    Centermark this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a center mark relative to drawing geometry. This can result in a center mark at the origin of a punch center if the specified geometry is the edge of a punch and the AtPunchCenter argument is true.
    /// </summary>
    /// <param name="Intent">Specifies the entity to create the center mark relative to. This is typically a circular or elliptical drawing curve but can be any drawing curve when it's the edge of a punch feature and you're creating the center point at the origin of the punch. The GeometryIntent object can be created using the CreateGeometryIntent method on the Sheet object.</param>
    /// <param name="ExtensionLinesVisible">Optional input Boolean that specifies if the extension lines should be visible in the created center mark.</param>
    /// <param name="AtPunchCenter">Optional input Boolean that specifies if the input geometry is the edge of the punch feature the center mark should be created at the origin of the punch feature instead of the center of the input geometry.</param>
    /// <param name="CentermarkStyle">Object that specifies the center mark style to use for the center mark. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Object that specifies the layer to use for the center mark. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    Centermark Add([In] [MarshalAs(UnmanagedType.Interface)] GeometryIntent Intent, [In] bool? ExtensionLinesVisible = true, [In] bool? AtPunchCenter = true, [In] [MarshalAs(UnmanagedType.Struct)] object? CentermarkStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates a center mark that represents the work feature within the drawing view.
    /// </summary>
    /// <param name="WorkFeature">Specifies the work feature to create the center mark for. This can be a WorkPoint or WorkAxis object. In the case of a WorkAxis object, the work axis must be oriented so it is normal to the plane of the sheet. If an work axis is provided that does not meet this criteria the method will fail.</param>
    /// <param name="DrawingView">Specifies the drawing view to create the center mark within.
    /// When working with an assembly the input WorkPoint or WorkAxis must always be with respect to the top-level. This means that work points or axes that exist within the parts or sub-assemblies must be represented by WorkPointProxy or WorkAxisProxy objects.</param>
    /// <param name="CentermarkStyle">Object that specifies the center mark style to use for the center mark. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Object that specifies the layer to use for the center mark. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    Centermark AddByWorkFeature([In] [MarshalAs(UnmanagedType.IDispatch)] object WorkFeature, [In] [MarshalAs(UnmanagedType.Interface)] DrawingView DrawingView, [In] [MarshalAs(UnmanagedType.Struct)] object? CentermarkStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
    /// <summary>
    /// Method that creates a center mark at the center of gravity of the model in the input drawing view. This will fail in the case where the view does not contain any solid parts.
    /// </summary>
    /// <param name="DrawingView">Specifies the view to create the center mark for.</param>
    /// <param name="CentermarkStyle">Object that specifies the center mark style to use for the center mark. If not specified, the style defined by the active standard is used.</param>
    /// <param name="Layer">Object that specifies the layer to use for the center mark. If not specified, the layer defined by the active standard is used.</param>
    /// <returns></returns>
    [PreserveSig]
    Centermark AddByCenterOfGravity([In] [MarshalAs(UnmanagedType.Interface)] DrawingView DrawingView, [In] [MarshalAs(UnmanagedType.Struct)] object? CentermarkStyle = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Layer = default);
}
