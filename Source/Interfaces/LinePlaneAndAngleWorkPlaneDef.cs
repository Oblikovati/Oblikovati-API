namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work plane that passes through a line and is a specified angle to a plane.
/// </summary>
public interface LinePlaneAndAngleWorkPlaneDef
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
    /// Property that returns the line of a line, plane and angle defined work plane. This object can be a linear Edge, WorkAxis, or SketchLine object. The work plane passes through the line.
    /// </summary>
    object Line { get; }
    /// <summary>
    /// Property that indicates the plane of a line, plane and angle defined work plane. This object can be a planar Face, WorkPlane, or Sketch object. The angle of the plane is measured with respect to this plane.
    /// </summary>
    object Plane { get; }
    /// <summary>
    /// Property that returns the parameter controlling the angle of a line, plane and angle defined work plane. The angle of the plane can be read and modified by accessing the returned Parameter object. The positive angle direction is computed by crossing the axis vector with the plane normal vector. Changes made will not be visible until the model is recomputed.
    /// </summary>
    Parameter Angle { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Line">Line</param>
    /// <param name="Plane">Plane</param>
    /// <param name="Angle">Angle</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Line, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane, [Out] [MarshalAs(UnmanagedType.Interface)] out Parameter Angle);
}
