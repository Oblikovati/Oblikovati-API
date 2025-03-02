namespace Oblikovati.API;

/// <summary>
/// The Arc2d object is a mathematical representation of a 2d arc.
/// </summary>
public interface Arc2d
{
    /// <summary>
    /// Specifies the center point for this arc.
    /// </summary>
    Point2d Center { get; set; }
    /// <summary>
    /// Specifies the radius for this arc.
    /// </summary>
    double Radius { get; set; }
    /// <summary>
    /// Specifies the starting angle for this arc.
    /// </summary>
    double StartAngle { get; set; }
    /// <summary>
    /// Specifies the sweep angle from the start angle for this arc.
    /// </summary>
    double SweepAngle { get; set; }
    /// <summary>
    /// Property that gets the start point of the arc.
    /// </summary>
    Point2d StartPoint { get; }
    /// <summary>
    /// Property that returns the end point of the arc.
    /// </summary>
    Point2d EndPoint { get; }
    /// <summary>
    /// Property that returns the Curve2dEvaluator for this arc.
    /// </summary>
    Curve2dEvaluator Evaluator { get; }
    /// <summary>
    /// Read-only property that returns the mid point of the arc.
    /// </summary>
    Point2d MidPoint { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="Radius">Radius</param>
    /// <param name="StartAngle">StartAngle</param>
    /// <param name="SweepAngle">SweepAngle</param>
    [PreserveSig]
    void GetArcData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Center, [Out] out double Radius, [Out] out double StartAngle, [Out] out double SweepAngle);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="Radius">Radius</param>
    /// <param name="StartAngle">StartAngle</param>
    /// <param name="SweepAngle">SweepAngle</param>
    [PreserveSig]
    void PutArcData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Center, [In] double Radius, [In] double StartAngle, [In] double SweepAngle);
    /// <summary>
    /// Creates a copy of this Arc2d object.&nbsp;The result is entirely independent and can be edited without affecting the original Arc2d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Arc2d Copy();
}
