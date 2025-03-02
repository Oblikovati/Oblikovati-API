namespace Oblikovati.API;

/// <summary>
/// The EllipseFull object. The object created is a transient mathematical object and is not displayed graphically
/// </summary>
public interface EllipseFull
{
    /// <summary>
    /// Specifies the center of the ellipse.
    /// </summary>
    Point Center { get; set; }
    /// <summary>
    /// Specifies the axis of the ellipse. The axis extends out of the ellipse.
    /// </summary>
    UnitVector Normal { get; set; }
    /// <summary>
    /// Specifies the direction of the major axis of the ellipse.
    /// </summary>
    Vector MajorAxisVector { get; set; }
    /// <summary>
    /// Specifies the ratio of the minor and major axes of the ellipse.
    /// </summary>
    double MinorMajorRatio { get; set; }
    /// <summary>
    /// Gets the CurveEvaluator for this ellipse.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    [PreserveSig]
    void GetEllipseFullData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Center, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] AxisVector, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] MajorAxis, [Out] out double MinorMajorRatio);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    [PreserveSig]
    void PutEllipseFullData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Center, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] AxisVector, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] MajorAxis, [In] double MinorMajorRatio);
    /// <summary>
    /// Creates a copy of this EllipseFull object.&nbsp;The result is entirely independent and can be edited without affecting the original EllipseFull object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    EllipseFull Copy();
}
