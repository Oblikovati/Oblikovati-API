namespace Oblikovati.API;

/// <summary>
/// The EllipticalCone object. The object created is a transient mathematical object and is not displayed graphically.
/// </summary>
public interface EllipticalCone
{
    /// <summary>
    /// Specifies the base of the elliptical cone.
    /// </summary>
    Point BasePoint { get; set; }
    /// <summary>
    /// Specifies the direction of the axis of the elliptical cone.
    /// </summary>
    UnitVector AxisVector { get; set; }
    /// <summary>
    /// Specifies the direction of the major axis of the elliptical cone.
    /// </summary>
    Vector MajorAxisVector { get; set; }
    /// <summary>
    /// Specifies the ratio of the minor and major axes of the elliptical cone.
    /// </summary>
    double MinorMajorRatio { get; set; }
    /// <summary>
    /// Specifies the taper angle of the elliptical cone. This is the angle measured from the axis to the side of the elliptical cone.
    /// </summary>
    double HalfAngle { get; set; }
    /// <summary>
    /// Specifies whether the taper of the elliptical cone is expanding outwards or inwards in the direction of the axis vector. If True and the HalfAngle is positive, then the elliptical cone is expanding outward along the axis vector.
    /// </summary>
    bool IsExpanding { get; set; }
    /// <summary>
    /// Gets the surface evaluator for this elliptical cone.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BasePoint">BasePoint</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    /// <param name="HalfAngle">HalfAngle</param>
    /// <param name="IsExpanding">IsExpanding</param>
    [PreserveSig]
    void GetEllipticalConeData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] BasePoint, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] AxisVector, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] MajorAxis, [Out] out double MinorMajorRatio, [Out] out double HalfAngle, [Out] out bool IsExpanding);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BasePoint">BasePoint</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    /// <param name="HalfAngle">HalfAngle</param>
    /// <param name="IsExpanding">IsExpanding</param>
    [PreserveSig]
    void PutEllipticalConeData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] BasePoint, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] AxisVector, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] MajorAxis, [In] double MinorMajorRatio, [In] double HalfAngle, [In] bool IsExpanding);
    /// <summary>
    /// Creates a copy of this EllipticalCone object.&nbsp;The result is entirely independent and can be edited without affecting the original EllipticalCone object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    EllipticalCone Copy();
}
