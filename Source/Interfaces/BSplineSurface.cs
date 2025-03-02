namespace Oblikovati.API;

/// <summary>
/// The BSplineSurface object represent a surface curved according to BSpline poles, order, weights, and knots.
/// </summary>
public interface BSplineSurface
{
    /// <summary>
    /// Indicates the pole coordinate point at the specified UV indices into the spline's pole array.
    /// </summary>
    Point PoleAtIndex { get; set; }
    /// <summary>
    /// Gets the surface evaluator for this surface.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Order">Order</param>
    /// <param name="NumPoles">NumPoles</param>
    /// <param name="NumKnots">NumKnots</param>
    /// <param name="IsRational">IsRational</param>
    /// <param name="IsPeriodic">IsPeriodic</param>
    /// <param name="IsClosed">IsClosed</param>
    /// <param name="IsPlanar">IsPlanar</param>
    /// <param name="PlaneVector">PlaneVector</param>
    [PreserveSig]
    void GetBSplineInfo([Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] Order, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] NumPoles, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] NumKnots, [Out] out bool IsRational, [Out] [MarshalAs(UnmanagedType.SafeArray)] out bool[,] IsPeriodic, [Out] [MarshalAs(UnmanagedType.SafeArray)] out bool[,] IsClosed, [Out] out bool IsPlanar, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] PlaneVector);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Poles">Poles</param>
    /// <param name="KnotsU">KnotsU</param>
    /// <param name="KnotsV">KnotsV</param>
    /// <param name="Weights">Weights</param>
    [PreserveSig]
    void GetBSplineData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Poles, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] KnotsU, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] KnotsV, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Weights);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Order">Order</param>
    /// <param name="Poles">Poles</param>
    /// <param name="KnotsU">KnotsU</param>
    /// <param name="KnotsV">KnotsV</param>
    /// <param name="Weights">Weights</param>
    /// <param name="IsPeriodic">IsPeriodic</param>
    [PreserveSig]
    void PutBSplineInfoAndData([Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] Order, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Poles, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] KnotsU, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] KnotsV, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Weights, [Out] [MarshalAs(UnmanagedType.SafeArray)] out bool[,] IsPeriodic);
    /// <summary>
    /// Creates a copy of this BSplineSurface object.&nbsp;The result is entirely independent and can be edited without affecting the original BSplineSurface object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    BSplineSurface Copy();
}
