namespace Oblikovati.API;

/// <summary>
/// The Torus object. The object created is a transient mathematical object and is not displayed graphically.
/// </summary>
public interface Torus
{
    /// <summary>
    /// Specifies the center of the torus.
    /// </summary>
    Point CenterPoint { get; set; }
    /// <summary>
    /// Specifies the direction of the axis of the torus.
    /// </summary>
    UnitVector AxisVector { get; set; }
    /// <summary>
    /// Specifies the major radius of the torus.
    /// </summary>
    double MajorRadius { get; set; }
    /// <summary>
    /// Specifies the minor radius of the torus.
    /// </summary>
    double MinorRadius { get; set; }
    /// <summary>
    /// Gets the surface evaluator for this torus.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CenterPoint">CenterPoint</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="MajorRadius">MajorRadius</param>
    /// <param name="MinorRadius">MinorRadius</param>
    [PreserveSig]
    void GetTorusData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] CenterPoint, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] AxisVector, [Out] out double MajorRadius, [Out] out double MinorRadius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CenterPoint">CenterPoint</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="MajorRadius">MajorRadius</param>
    /// <param name="MinorRadius">MinorRadius</param>
    [PreserveSig]
    void PutTorusData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] CenterPoint, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] AxisVector, [In] double MajorRadius, [In] double MinorRadius);
    /// <summary>
    /// Creates a copy of this Torus object.&nbsp;The result is entirely independent and can be edited without affecting the original Torus object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Torus Copy();
}
