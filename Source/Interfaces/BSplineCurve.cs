namespace Oblikovati.API;

/// <summary>
/// The BSplineCurve object is a mathematical utility object that represents a NURBS curve. It is a transient object that is never shown graphically or saved in the Inventor document
/// </summary>
public interface BSplineCurve
{
    /// <summary>
    /// Property that returns the x, y, z position of a specified pole.
    /// </summary>
    Point PoleAtIndex { get; set; }
    /// <summary>
    /// Property that returns an evaluator object for the curve. The evaluator supports general curve evaluation functions.
    /// </summary>
    CurveEvaluator Evaluator { get; }
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
    void GetBSplineInfo([Out] out int Order, [Out] out int NumPoles, [Out] out int NumKnots, [Out] out bool IsRational, [Out] out bool IsPeriodic, [Out] out bool IsClosed, [Out] out bool IsPlanar, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] PlaneVector);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Poles">Poles</param>
    /// <param name="Knots">Knots</param>
    /// <param name="Weights">Weights</param>
    [PreserveSig]
    void GetBSplineData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Poles, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Knots, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Weights);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Order">Order</param>
    /// <param name="Poles">Poles</param>
    /// <param name="Knots">Knots</param>
    /// <param name="Weights">Weights</param>
    /// <param name="IsPeriodic">IsPeriodic</param>
    [PreserveSig]
    void PutBSplineInfoAndData([In] int Order, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Poles, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Knots, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Weights, [In] bool IsPeriodic);
    /// <summary>
    /// Creates a copy of this BSplineCurve object.&nbsp;The result is entirely independent and can be edited without affecting the original BSplineCurve object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    BSplineCurve Copy();
    /// <summary>
    /// Creates a new curve by extracting a portion of an existing curve.
    /// </summary>
    /// <param name="StartParam">Input Double that specifies the starting parameter of where the new curve is extracted.</param>
    /// <param name="EndParam">Input Double that specifies the ending parameter of where the new curve is extracted.</param>
    /// <returns></returns>
    [PreserveSig]
    BSplineCurve ExtractPartial([In] double StartParam, [In] double EndParam);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SplitParam">SplitParam</param>
    /// <param name="CurveOne">CurveOne</param>
    /// <param name="CurveTwo">CurveTwo</param>
    [PreserveSig]
    void Split([In] double SplitParam, [Out] [MarshalAs(UnmanagedType.Interface)] out BSplineCurve CurveOne, [Out] [MarshalAs(UnmanagedType.Interface)] out BSplineCurve CurveTwo);
}
