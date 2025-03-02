namespace Oblikovati.API;

public interface IRxLine
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint RootPoint { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxUnitVector Direction { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCurveEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pRootPoint">pRootPoint</param>
    /// <param name="pDirection">pDirection</param>
    void GetLineData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pRootPoint, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pDirection);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pRootPoint">pRootPoint</param>
    /// <param name="pDirection">pDirection</param>
    void PutLineData([In] [MarshalAs(UnmanagedType.LPArray)] double[] pRootPoint, [In] [MarshalAs(UnmanagedType.LPArray)] double[] pDirection);
}
