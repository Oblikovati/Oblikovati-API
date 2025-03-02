namespace Oblikovati.API;

/// <summary>
/// The AssemblyWorkPlaneDef object allows you to access the information specific to work planes in an assembly.
/// </summary>
public interface AssemblyWorkPlaneDef
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
    /// Property that returns the collection of constraints that are acting on the work plane. This returns all of the constraints, including those returned by the DefinitionConstraints property
    /// </summary>
    AssemblyConstraintsEnumerator Constraints { get; }
    /// <summary>
    /// Property that returns the origin point of the work plane.
    /// </summary>
    Point OriginPoint { get; }
    /// <summary>
    /// Property that returns the X-axis vector of the work plane.
    /// </summary>
    UnitVector XAxis { get; }
    /// <summary>
    /// Property that returns the Y-axis vector of the work plane.
    /// </summary>
    UnitVector YAxis { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="OriginPoint">OriginPoint</param>
    /// <param name="XAxis">XAxis</param>
    /// <param name="YAxis">YAxis</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.Interface)] out Point OriginPoint, [Out] [MarshalAs(UnmanagedType.Interface)] out UnitVector XAxis, [Out] [MarshalAs(UnmanagedType.Interface)] out UnitVector YAxis);
    /// <summary>
    /// Method that sets all of the data defining an assembly work plane.
    /// </summary>
    /// <param name="OriginPoint">Input object that defines the origin of the work plane.</param>
    /// <param name="XAxis">Input object that defines the X-axis vector of the work plane.</param>
    /// <param name="YAxis">Input object that defines the Y-axis vector of the work plane.</param>
    [PreserveSig]
    void PutData([In] [MarshalAs(UnmanagedType.Interface)] Point OriginPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector XAxis, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector YAxis);
}
