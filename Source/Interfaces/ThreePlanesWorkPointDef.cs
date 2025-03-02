namespace Oblikovati.API;

/// <summary>
/// Object that allows you to get and set the information that specifies a work point defined by the intersection of three planes.
/// </summary>
public interface ThreePlanesWorkPointDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent WorkPoint object.
    /// </summary>
    WorkPoint Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the first plane of a work point that is defined by the intersection of three planes. This object can be a planar Face, WorkPlane, or Sketch object.
    /// </summary>
    object Plane1 { get; }
    /// <summary>
    /// Property that returns the second plane of a work point that is defined by the intersection of three planes. This object can be a planar Face, WorkPlane, or Sketch object.
    /// </summary>
    object Plane2 { get; }
    /// <summary>
    /// Property that returns the third plane of a work point that is defined by the intersection of three planes. This object can be a planar Face, WorkPlane, or Sketch object.
    /// </summary>
    object Plane3 { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Plane1">Plane1</param>
    /// <param name="Plane2">Plane2</param>
    /// <param name="Plane3">Plane3</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane1, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane2, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Plane3);
}
