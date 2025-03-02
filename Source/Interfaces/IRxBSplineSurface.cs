namespace Oblikovati.API;

public interface IRxBSplineSurface
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint PoleAtIndex { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxSurfaceEvaluator Evaluator { get; }
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
    void GetBSplineInfo([Out] [MarshalAs(UnmanagedType.LPArray)] out uint[,] pnOrder, [Out] [MarshalAs(UnmanagedType.LPArray)] out uint[,] pnNumPoles, [Out] [MarshalAs(UnmanagedType.LPArray)] out uint[,] pnNumKnots, [Out] out sbyte pbIsRational, [Out] [MarshalAs(UnmanagedType.LPArray)] out sbyte[,] pbIsPeriodic, [Out] [MarshalAs(UnmanagedType.LPArray)] out sbyte[,] pbIsClosed, [Out] out sbyte pbIsPlanar, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pPlaneVector);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="nPoles">nPoles</param>
    /// <param name="nKnotsU">nKnotsU</param>
    /// <param name="nKnotsV">nKnotsV</param>
    /// <param name="nWeights">nWeights</param>
    /// <param name="pPoles">pPoles</param>
    /// <param name="pKnotsU">pKnotsU</param>
    /// <param name="pKnotsV">pKnotsV</param>
    /// <param name="pWeights">pWeights</param>
    void GetBSplineData([In] uint nPoles, [In] uint nKnotsU, [In] uint nKnotsV, [In] uint nWeights, [Out] out double pPoles, [Out] out double pKnotsU, [Out] out double pKnotsV, [Out] out double pWeights);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pnOrder">pnOrder</param>
    /// <param name="nNumPolesUXV">nNumPolesUXV</param>
    /// <param name="nKnotsU">nKnotsU</param>
    /// <param name="nKnotsV">nKnotsV</param>
    /// <param name="nWeights">nWeights</param>
    /// <param name="pbIsPeriodic">pbIsPeriodic</param>
    /// <param name="pPoles">pPoles</param>
    /// <param name="pKnotsU">pKnotsU</param>
    /// <param name="pKnotsV">pKnotsV</param>
    /// <param name="pWeights">pWeights</param>
    void PutBSplineInfoAndData([In] [MarshalAs(UnmanagedType.LPArray)] uint[,] pnOrder, [In] uint nNumPolesUXV, [In] uint nKnotsU, [In] uint nKnotsV, [In] uint nWeights, [In] [MarshalAs(UnmanagedType.LPArray)] sbyte[,] pbIsPeriodic, [In] ref double pPoles, [In] ref double pKnotsU, [In] ref double pKnotsV, [Out] out double pWeights);
}
