namespace Oblikovati.API;

/// <summary>
/// The EllipticalCylinder object. The object created is a transient mathematical object and is not displayed graphically.
/// </summary>
public interface EllipticalCylinder
{
    /// <summary>
    /// Specifies the base of the elliptical cylinder.
    /// </summary>
    Point BasePoint { get; set; }
    /// <summary>
    /// Specifies the direction of the axis of the elliptical cylinder.
    /// </summary>
    UnitVector AxisVector { get; set; }
    /// <summary>
    /// Specifies the direction of the major axis of the elliptical cylinder.
    /// </summary>
    Vector MajorAxisVector { get; set; }
    /// <summary>
    /// Specifies the ratio of the minor and major axes of the elliptical cylinder.
    /// </summary>
    double MinorMajorRatio { get; set; }
    /// <summary>
    /// Gets the surface evaluator for this elliptical cylinder.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BasePoint">BasePoint</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    [PreserveSig]
    void GetEllipticalCylinderData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] BasePoint, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] AxisVector, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] MajorAxis, [Out] out double MinorMajorRatio);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BasePoint">BasePoint</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    [PreserveSig]
    void PutEllipticalCylinderData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] BasePoint, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] AxisVector, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] MajorAxis, [In] double MinorMajorRatio);
    /// <summary>
    /// Creates a copy of this EllipticalCylinder object.&nbsp;The result is entirely independent and can be edited without affecting the original EllipticalCylinder object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    EllipticalCylinder Copy();
}
