namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work plane that passes through a point and is tangent to a surface.
/// </summary>
public interface PointAndTangentWorkPlaneDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent WorkPlane object.
    /// </summary>
    WorkPlane Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the point of a work plane that passes through a point and is tangent to a surface. This object can be a Vertex, WorkPoint, SketchPoint, or SketchPoint3D object.
    /// </summary>
    object Point { get; }
    /// <summary>
    /// Property that returns the tangent face of the work plane. This face must either be a cylinder whose axis is parallel to the line, a cone that is positioned such that a valid tangent exists, a sphere or a bspline surface.
    /// </summary>
    Face Face { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point">Point</param>
    /// <param name="Face">Face</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Point, [Out] [MarshalAs(UnmanagedType.Interface)] out Face Face);
}
