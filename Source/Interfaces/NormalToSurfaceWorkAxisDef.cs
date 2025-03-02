namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work axis defined normal to a surface and through a point.
/// </summary>
public interface NormalToSurfaceWorkAxisDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent WorkAxis object.
    /// </summary>
    WorkAxis Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the point of a normal to surface defined work axis. The point can be a WorkPoint, Vertex, SketchPoint3D or SketchPoint object. The work axis passes through the point.
    /// </summary>
    object Point { get; }
    /// <summary>
    /// Property that returns the surface entity of a normal to surface defined work axis. This object can be a Face, WorkPlane, or PlanarSketch.
    /// </summary>
    object SurfaceEntity { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point">Point</param>
    /// <param name="SurfaceEntity">SurfaceEntity</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object SurfaceEntity);
}
