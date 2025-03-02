namespace Oblikovati.API;

/// <summary>
/// The EllipticalArc2d object. The object created is a transient mathematical object and is not displayed graphically.
/// </summary>
public interface EllipticalArc2d
{
    /// <summary>
    /// Specifies the center point for the arc.
    /// </summary>
    Point2d Center { get; set; }
    /// <summary>
    /// Specifies the major axis for the ellipse.
    /// </summary>
    UnitVector2d MajorAxis { get; set; }
    /// <summary>
    /// Specifies the major radius for the ellipse.
    /// </summary>
    double MajorRadius { get; set; }
    /// <summary>
    /// Specifies the minor radius for the ellipse.
    /// </summary>
    double MinorRadius { get; set; }
    /// <summary>
    /// Specifies the start angle for the arc.
    /// </summary>
    double StartAngle { get; set; }
    /// <summary>
    /// Specifies the sweep angle from the start angle for the arc.
    /// </summary>
    double SweepAngle { get; set; }
    /// <summary>
    /// Gets the start point for the arc.
    /// </summary>
    Point2d StartPoint { get; }
    /// <summary>
    /// Gets the end point for the arc.
    /// </summary>
    Point2d EndPoint { get; }
    /// <summary>
    /// Gets the Curve2DEvaluator for the arc.
    /// </summary>
    Curve2dEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MajorRadius">MajorRadius</param>
    /// <param name="MinorRadius">MinorRadius</param>
    /// <param name="StartAngle">StartAngle</param>
    /// <param name="SweepAngle">SweepAngle</param>
    [PreserveSig]
    void GetEllipticalArcData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Center, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] MajorAxis, [Out] out double MajorRadius, [Out] out double MinorRadius, [Out] out double StartAngle, [Out] out double SweepAngle);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MajorRadius">MajorRadius</param>
    /// <param name="MinorRadius">MinorRadius</param>
    /// <param name="StartAngle">StartAngle</param>
    /// <param name="SweepAngle">SweepAngle</param>
    [PreserveSig]
    void PutEllipticalArcData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Center, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] MajorAxis, [In] double MajorRadius, [In] double MinorRadius, [In] double StartAngle, [In] double SweepAngle);
    /// <summary>
    /// Creates a copy of this EllipticalArc2d object.&nbsp;The result is entirely independent and can be edited without affecting the original EllipticalArc2d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    EllipticalArc2d Copy();
}
