namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work plane that is parallel to an existing plane and offset a specified distance.
/// </summary>
public interface PlaneAndOffsetWorkPlaneDef
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
    /// Property that returns the plane of an offset work plane. This object can be a planar Face, WorkPlane, or Sketch object. The work plane will be parallel to this plane.
    /// </summary>
    object Plane { get; }
    /// <summary>
    /// Property that returns the parameter controlling the offset of the work plane. The offset of the plane can be read and modified by accessing the returned Parameter object.
    /// </summary>
    Parameter Offset { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Plane">Plane</param>
    /// <param name="Offset">Offset</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane, [Out] [MarshalAs(UnmanagedType.Interface)] out Parameter Offset);
}
