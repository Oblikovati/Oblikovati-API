namespace Oblikovati.API;

/// <summary>
/// The SurfaceBodyMassProperties for the SurfaceBody object.
/// </summary>
public interface SurfaceBodyMassProperties
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    SurfaceBody Parent { get; }
    /// <summary>
    /// Read-only property that returns the area of the surface body in database units.
    /// </summary>
    double Area { get; }
    /// <summary>
    /// Read-only property that returns the center of mass.
    /// </summary>
    Point CenterOfMass { get; }
    /// <summary>
    /// Read-only property that returns the mass of the surface body in database units.
    /// </summary>
    double Mass { get; }
    /// <summary>
    /// Read-only property that returns the volume of the surface body in database units.
    /// </summary>
    double Volume { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="I1">I1</param>
    /// <param name="I2">I2</param>
    /// <param name="I3">I3</param>
    /// <param name="OverriddenMass">OverriddenMass</param>
    [PreserveSig]
    void PrincipalMomentsOfInertia([Out] out double I1, [Out] out double I2, [Out] out double I3, [In] [MarshalAs(UnmanagedType.Struct)] object? OverriddenMass = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Ixx">Ixx</param>
    /// <param name="Iyy">Iyy</param>
    /// <param name="Izz">Izz</param>
    /// <param name="Ixy">Ixy</param>
    /// <param name="Iyz">Iyz</param>
    /// <param name="Ixz">Ixz</param>
    /// <param name="OverriddenMass">OverriddenMass</param>
    [PreserveSig]
    void XYZMomentsOfInertia([Out] out double Ixx, [Out] out double Iyy, [Out] out double Izz, [Out] out double Ixy, [Out] out double Iyz, [Out] out double Ixz, [In] [MarshalAs(UnmanagedType.Struct)] object? OverriddenMass = default);
}
