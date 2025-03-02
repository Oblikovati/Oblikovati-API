namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work axis that is normal to a plane and passes through a point.
/// </summary>
public interface PointAndPlaneWorkAxisDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent WorkAxis object.
    /// </summary>
    WorkAxis Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the point of a work axis that is normal to a plane and passes through a point. This object can be a WorkPoint, Vertex, or SketchPoint object.
    /// </summary>
    object Point { get; }
    /// <summary>
    /// Property that returns the plane of a work axis that is normal to a plane and passes through a point. This object can be a planar Face, WorkPlane, or Sketch object.
    /// </summary>
    object Plane { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point">Point</param>
    /// <param name="Plane">Plane</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane);
}
