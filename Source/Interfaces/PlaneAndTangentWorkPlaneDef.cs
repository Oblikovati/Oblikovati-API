namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work plane that is parallel to a plane and tangent to a surface.
/// </summary>
public interface PlaneAndTangentWorkPlaneDef
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
    /// Property that returns the plane of a work plane that is parallel to a plane and tangent to a surface. This object can be a planar Face, WorkPlane, or Sketch object. The work plane will be parallel to this plane.
    /// </summary>
    object Plane { get; }
    /// <summary>
    /// Property that returns the tangent of the work plane. This face must either be a cylinder whose axis is parallel to the line, a cone that is positioned such that a valid tangent exists, or a sphere.
    /// </summary>
    Face Face { get; }
    /// <summary>
    /// Property that returns the proximity point. The proximity point defines which of the two possible solutions is chosen when computing the tangent plane. This point is used for the initial computation and the specific point is not stored. During a recompute of the model the plane will remain on the same side of the tangent surface regardless of its position relative to the originally specified point. The point returned by this property is as an arbitrary point along the tangent between the face and plane.
    /// </summary>
    Point ProximityPoint { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Plane">Plane</param>
    /// <param name="Face">Face</param>
    /// <param name="ProximityPoint">ProximityPoint</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane, [Out] [MarshalAs(UnmanagedType.Interface)] out Face Face, [Out] [MarshalAs(UnmanagedType.Interface)] out Point ProximityPoint);
}
