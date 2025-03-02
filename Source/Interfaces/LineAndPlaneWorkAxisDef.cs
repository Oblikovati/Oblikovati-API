namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work axis that is along a line defined by projecting a line onto a plane along the plane normal.
/// </summary>
public interface LineAndPlaneWorkAxisDef
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
    /// Property that returns the point of a work axis that is along a line defined by projecting a line onto a plane along the plane normal. This object can be a linear Edge, WorkAxis, or SketchLine object.
    /// </summary>
    object Line { get; }
    /// <summary>
    /// Property that indicates the plane of a work axis that is along a line defined by projecting a line onto a plane along the plane normal. This object can be a planar Face, WorkPlane, or Sketch object.
    /// </summary>
    object Plane { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Line">Line</param>
    /// <param name="Plane">Plane</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Line, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane);
}
