namespace Oblikovati.API;

/// <summary>
/// The Cone object. The object is a transient mathematical object and is not displayed graphically.
/// </summary>
public interface Cone
{
    /// <summary>
    /// Specifies the base of the cone.
    /// </summary>
    Point BasePoint { get; set; }
    /// <summary>
    /// Specifies the direction of the axis of the cone.
    /// </summary>
    UnitVector AxisVector { get; set; }
    /// <summary>
    /// Specifies the radius of the cone at the base point.
    /// </summary>
    double Radius { get; set; }
    /// <summary>
    /// Specifies the taper angle of the cone. This is the angle measured from the axis to the side of the cone.
    /// </summary>
    double HalfAngle { get; set; }
    /// <summary>
    /// Indicates whether the taper of the cone is expanding outwards or inwards in the direction of the axis vector. If True and the HalfAngle is positive, then the cone is expanding outward along the axis vector.
    /// </summary>
    bool IsExpanding { get; set; }
    /// <summary>
    /// Gets the surface evaluator for this cone.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BasePoint">BasePoint</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="Radius">Radius</param>
    /// <param name="HalfAngle">HalfAngle</param>
    /// <param name="IsExpanding">IsExpanding</param>
    [PreserveSig]
    void GetConeData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] BasePoint, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] AxisVector, [Out] out double Radius, [Out] out double HalfAngle, [Out] out bool IsExpanding);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BasePoint">BasePoint</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="Radius">Radius</param>
    /// <param name="HalfAngle">HalfAngle</param>
    /// <param name="IsExpanding">IsExpanding</param>
    [PreserveSig]
    void PutConeData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] BasePoint, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] AxisVector, [In] double Radius, [In] double HalfAngle, [In] bool IsExpanding);
    /// <summary>
    /// Creates a copy of this Cone object.&nbsp;The result is entirely independent and can be edited without affecting the original Cone object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Cone Copy();
}
