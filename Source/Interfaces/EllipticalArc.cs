namespace Oblikovati.API;

/// <summary>
/// The EllipticalArc object. The object created is a transient mathematical object and is not displayed graphically
/// </summary>
public interface EllipticalArc
{
    /// <summary>
    /// Specifies the center point for the arc.
    /// </summary>
    Point Center { get; set; }
    /// <summary>
    /// Specifies the major axis for the ellipse.
    /// </summary>
    UnitVector MajorAxis { get; set; }
    /// <summary>
    /// Specifies the minor axis for the ellipse.
    /// </summary>
    UnitVector MinorAxis { get; set; }
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
    Point StartPoint { get; }
    /// <summary>
    /// Gets the end point for the arc.
    /// </summary>
    Point EndPoint { get; }
    /// <summary>
    /// Gets the CurveEvaluator for the arc.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MinorAxis">MinorAxis</param>
    /// <param name="MajorRadius">MajorRadius</param>
    /// <param name="MinorRadius">MinorRadius</param>
    /// <param name="StartAngle">StartAngle</param>
    /// <param name="SweepAngle">SweepAngle</param>
    [PreserveSig]
    void GetEllipticalArcData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Center, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MajorAxis, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MinorAxis, [Out] out double MajorRadius, [Out] out double MinorRadius, [Out] out double StartAngle, [Out] out double SweepAngle);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MinorAxis">MinorAxis</param>
    /// <param name="MajorRadius">MajorRadius</param>
    /// <param name="MinorRadius">MinorRadius</param>
    /// <param name="StartAngle">StartAngle</param>
    /// <param name="SweepAngle">SweepAngle</param>
    [PreserveSig]
    void PutEllipticalArcData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Center, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MajorAxis, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MinorAxis, [In] double MajorRadius, [In] double MinorRadius, [In] double StartAngle, [In] double SweepAngle);
    /// <summary>
    /// Creates a copy of this EllipticalArc object.&nbsp;The result is entirely independent and can be edited without affecting the original EllipticalArc object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    EllipticalArc Copy();
}
