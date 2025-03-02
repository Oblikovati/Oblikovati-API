namespace Oblikovati.API;

/// <summary>
/// Part Sketch Driven Pattern Features Collection Object.
/// </summary>
public interface SketchDrivenPatternFeatures : IEnumerable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    SketchDrivenPatternFeature this[object Index] { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new sketch driven pattern feature.&nbsp;The new SketchDrivenPatternFeature object is returned.
    /// </summary>
    /// <param name="Definition">Input SketchDrivenPatternDefinition objet that defines the  SketchDrivenPatternFeature you want to create.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchDrivenPatternFeature Add([In] [MarshalAs(UnmanagedType.Interface)] SketchDrivenPatternDefinition Definition);
    /// <summary>
    /// Method that creates a new sketch driven pattern feature definition.
    /// </summary>
    /// <param name="ParentFeatures">Input ObjectCollection object that contains the features to be patterned.  The collection could contain the various part features, sheet metal features, work planes, work axes, work points, or a SurfaceBody. If a SurfaceBody is supplied, the only other objects that can be in the collection are work features and surface part features.</param>
    /// <param name="Sketch">Input PlanarSketch or Sketch3D object that contains the sketch points to locate the pattern occurrences.</param>
    /// <param name="BasePoint">Optional input object that indicates the position of base point.  This can be a SketchPoint, SketchPoint3D, WorkPoint, or GeometryIntent that indicates a point on geometry. If a GeometryIntent is provided, you can specify the mid-point of sketch line,  start/end/mid-point of a linear edge, the center of a circular/elliptical edge, planar face center, the start/mid/end point of the axis of a cylindrical/conical face, or the center of torus/spherical face.</param>
    /// <param name="ReferenceFaces">Optional input FaceCollection that specifies the reference faces.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchDrivenPatternDefinition CreateDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ParentFeatures, [In] [MarshalAs(UnmanagedType.IDispatch)] object Sketch, [In] [MarshalAs(UnmanagedType.Struct)] object? BasePoint = default, [In] [MarshalAs(UnmanagedType.Struct)] object? ReferenceFaces = default);
}
