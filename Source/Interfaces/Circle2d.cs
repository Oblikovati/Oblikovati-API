namespace Oblikovati.API;

/// <summary>
/// The mathematical Circle2d object - one of the transient objects.
/// </summary>
public interface Circle2d
{
    /// <summary>
    /// The center of the 2D circle.
    /// </summary>
    Point2d Center { get; set; }
    /// <summary>
    /// The radius of the 2D circle.
    /// </summary>
    double Radius { get; set; }
    /// <summary>
    /// Gets the Curve2dEvaluator for this circle.
    /// </summary>
    Curve2dEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="Radius">Radius</param>
    [PreserveSig]
    void GetCircleData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Center, [Out] out double Radius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="Radius">Radius</param>
    [PreserveSig]
    void PutCircleData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Center, [In] double Radius);
    /// <summary>
    /// Creates a copy of this Circle2d object.&nbsp;The result is entirely independent and can be edited without affecting the original Circle2d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Circle2d Copy();
}
