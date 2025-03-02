namespace Oblikovati.API;

/// <summary>
/// The mathematical Circle object, one of the transient geometry objects.
/// </summary>
public interface Circle
{
    /// <summary>
    /// The center Point of the circle.
    /// </summary>
    Point Center { get; set; }
    /// <summary>
    /// The normal of the circle.
    /// </summary>
    UnitVector Normal { get; set; }
    /// <summary>
    /// The radius of the circle.
    /// </summary>
    double Radius { get; set; }
    /// <summary>
    /// Gets the CurveEvaluator for this circle.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="Radius">Radius</param>
    [PreserveSig]
    void GetCircleData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Center, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] AxisVector, [Out] out double Radius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="AxisVector">AxisVector</param>
    /// <param name="Radius">Radius</param>
    [PreserveSig]
    void PutCircleData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Center, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] AxisVector, [In] double Radius);
    /// <summary>
    /// Creates a copy of this Circle object.&nbsp;The result is entirely independent and can be edited without affecting the original Circle object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Circle Copy();
}
