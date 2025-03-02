namespace Oblikovati.API;

/// <summary>
/// The Cylinder object. The object created is a transient mathematical object and is not displayed graphically
/// </summary>
public interface Cylinder
{
    /// <summary>
    /// Specifies the base of the cylinder.
    /// </summary>
    Point BasePoint { get; set; }
    /// <summary>
    /// Specifies the direction of the axis of the cylinder.
    /// </summary>
    UnitVector AxisVector { get; set; }
    /// <summary>
    /// Specifies the radius of the cylinder.
    /// </summary>
    double Radius { get; set; }
    /// <summary>
    /// Gets the surface evaluator for this cylinder.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BasePoint">BasePoint</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="Radius">Radius</param>
    [PreserveSig]
    void GetCylinderData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] BasePoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] AxisVector, [Out] out double Radius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BasePoint">BasePoint</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="Radius">Radius</param>
    [PreserveSig]
    void PutCylinderData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] BasePoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] AxisVector, [In] double Radius);
    /// <summary>
    /// Creates a copy of this Cylinder object.&nbsp;The result is entirely independent and can be edited without affecting the original Cylinder object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Cylinder Copy();
}
