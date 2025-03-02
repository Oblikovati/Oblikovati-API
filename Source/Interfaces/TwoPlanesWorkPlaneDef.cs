namespace Oblikovati.API;

/// <summary>
/// The TwoPlanesWorkPlaneDef object that allows you to get and set the information that specifies a work a work plane defined by two planes.
/// </summary>
public interface TwoPlanesWorkPlaneDef
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
    /// Property that returns the first plane of the two-plane-defined work plane This object can be a planar Face or a WorkPlane object.
    /// </summary>
    object Plane1 { get; }
    /// <summary>
    /// Property that returns the second plane of the two plane defined work plane This object can be a planar Face or a WorkPlane object.
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
