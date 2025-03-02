namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work axis along a line.
/// </summary>
public interface TwoPlanesWorkAxisDef
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
    /// Property that returns the plane of a two plane defined work axis. This object can be a planar Face, WorkPlane, or Sketch object. The work axis is at the intersection of the two planes.
    /// </summary>
    object Plane1 { get; }
    /// <summary>
    /// Property that returns the plane of a two plane defined work axis. This object can be a planar Face, WorkPlane, or Sketch object. The work axis is at the intersection of the two planes.
    /// </summary>
    object Plane2 { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Plane1">Plane1</param>
    /// <param name="Plane2">Plane2</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane1, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane2);
}
