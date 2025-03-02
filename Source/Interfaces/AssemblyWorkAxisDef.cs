namespace Oblikovati.API;

/// <summary>
/// The AssemblyWorkAxisDef object allows you to get and set the information that specifies a fixed work axis.
/// </summary>
public interface AssemblyWorkAxisDef
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    WorkAxis Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the collection of constraints that are acting on the work axis. This returns all of the constraints, including those returned by the DefinitionConstraints property.
    /// </summary>
    AssemblyConstraintsEnumerator Constraints { get; }
    /// <summary>
    /// Property that returns the origin point of the work axis.
    /// </summary>
    Point OriginPoint { get; }
    /// <summary>
    /// Property that returns the X-axis vector of the work axis.
    /// </summary>
    UnitVector Axis { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="OriginPoint">OriginPoint</param>
    /// <param name="Axis">Axis</param>
    [PreserveSig]
    void GetData([Out] [MarshalAs(UnmanagedType.Interface)] out Point OriginPoint, [Out] [MarshalAs(UnmanagedType.Interface)] out UnitVector Axis);
    /// <summary>
    /// Method that sets all of the data defining an assembly work axis.
    /// </summary>
    /// <param name="OriginPoint">Input object that defines the origin of the work axis.</param>
    /// <param name="Axis">Input object that defines the X-axis vector of the work axis.</param>
    [PreserveSig]
    void PutData([In] [MarshalAs(UnmanagedType.Interface)] Point OriginPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Axis);
}
