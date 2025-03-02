namespace Oblikovati.API;

public interface IRxBSplineCurve
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint PoleAtIndex { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCurveEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pnOrder">pnOrder</param>
    /// <param name="pnNumPoles">pnNumPoles</param>
    /// <param name="pnNumKnots">pnNumKnots</param>
    /// <param name="pbIsRational">pbIsRational</param>
    /// <param name="pbIsPeriodic">pbIsPeriodic</param>
    /// <param name="pbIsClosed">pbIsClosed</param>
    /// <param name="pbIsPlanar">pbIsPlanar</param>
    /// <param name="pPlaneVector">pPlaneVector</param>
    void GetBSplineInfo([Out] out uint pnOrder, [Out] out uint pnNumPoles, [Out] out uint pnNumKnots, [Out] out sbyte pbIsRational, [Out] out sbyte pbIsPeriodic, [Out] out sbyte pbIsClosed, [Out] out sbyte pbIsPlanar, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pPlaneVector);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nPoles">nPoles</param>
    /// <param name="nKnots">nKnots</param>
    /// <param name="nWeights">nWeights</param>
    /// <param name="pPoles">pPoles</param>
    /// <param name="pKnots">pKnots</param>
    /// <param name="pWeights">pWeights</param>
    void GetBSplineData([In] uint nPoles, [In] uint nKnots, [In] uint nWeights, [Out] out double pPoles, [Out] out double pKnots, [Out] out double pWeights);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nOrder">nOrder</param>
    /// <param name="nPoles">nPoles</param>
    /// <param name="nKnots">nKnots</param>
    /// <param name="nWeights">nWeights</param>
    /// <param name="bIsPeriodic">bIsPeriodic</param>
    /// <param name="pPoles">pPoles</param>
    /// <param name="pKnots">pKnots</param>
    /// <param name="pWeights">pWeights</param>
    void PutBSplineInfoAndData([In] uint nOrder, [In] uint nPoles, [In] uint nKnots, [In] uint nWeights, [In] sbyte bIsPeriodic, [In] ref double pPoles, [In] ref double pKnots, [Out] out double pWeights);
}
