namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work plane that is parallel to an existing plane and passes through an existing point.
/// </summary>
public interface PlaneAndPointWorkPlaneDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent WorkPlane object.
    /// </summary>
    WorkPlane Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the plane of a plane and point defined work plane. This object can be a planar Face, WorkPlane, or Sketch object. The work plane is parallel to the plane.
    /// </summary>
    object Plane { get; }
    /// <summary>
    /// Property that returns the point of a plane and point defined work plane. The point can be a WorkPoint, Vertex, or SketchPoint object. The work plane passes through the point.
    /// </summary>
    object Point { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Plane">Plane</param>
    /// <param name="Point">Point</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point);
}
