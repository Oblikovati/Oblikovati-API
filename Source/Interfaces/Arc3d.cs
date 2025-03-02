namespace Oblikovati.API;

/// <summary>
/// The Arc3d object is a mathematical representation of a 3d arc.
/// </summary>
public interface Arc3d
{
    /// <summary>
    /// Specifies the center point for this arc.
    /// </summary>
    Point Center { get; set; }
    /// <summary>
    /// Specifies the normal for this arc.
    /// </summary>
    UnitVector Normal { get; set; }
    /// <summary>
    /// Specifies the reference vector for this arc.
    /// </summary>
    UnitVector ReferenceVector { get; set; }
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
    Point StartPoint { get; }
    /// <summary>
    /// Property that returns the end point of the arc.
    /// </summary>
    Point EndPoint { get; }
    /// <summary>
    /// Property that gets the CurveEvaluator for this arc.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="RefVector">RefVector</param>
    /// <param name="Radius">Radius</param>
    /// <param name="StartAngle">StartAngle</param>
    /// <param name="SweepAngle">SweepAngle</param>
    [PreserveSig]
    void GetArcData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Center, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] AxisVector, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] RefVector, [Out] out double Radius, [Out] out double StartAngle, [Out] out double SweepAngle);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="RefVector">RefVector</param>
    /// <param name="Radius">Radius</param>
    /// <param name="StartAngle">StartAngle</param>
    /// <param name="SweepAngle">SweepAngle</param>
    [PreserveSig]
    void PutArcData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Center, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] AxisVector, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] RefVector, [In] double Radius, [In] double StartAngle, [In] double SweepAngle);
    /// <summary>
    /// Creates a copy of this Arc3d object.&nbsp;The result is entirely independent and can be edited without affecting the original Arc3d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Arc3d Copy();
}
