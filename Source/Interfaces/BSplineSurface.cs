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
    void GetBSplineInfo([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref int[] Order, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref int[] NumPoles, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref int[] NumKnots, [Out] out bool IsRational, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref bool[] IsPeriodic, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref bool[] IsClosed, [Out] out bool IsPlanar, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] PlaneVector);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Poles">Poles</param>
    /// <param name="KnotsU">KnotsU</param>
    /// <param name="KnotsV">KnotsV</param>
    /// <param name="Weights">Weights</param>
    [PreserveSig]
    void GetBSplineData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Poles, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] KnotsU, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] KnotsV, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Weights);
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
    void PutBSplineInfoAndData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref int[] Order, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Poles, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] KnotsU, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] KnotsV, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Weights, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref bool[] IsPeriodic);
    /// <summary>
    /// Creates a copy of this BSplineSurface object.&nbsp;The result is entirely independent and can be edited without affecting the original BSplineSurface object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    BSplineSurface Copy();
}
