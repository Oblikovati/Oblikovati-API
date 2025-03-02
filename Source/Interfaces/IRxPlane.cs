namespace Oblikovati.API;

public interface IRxPlane
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint RootPoint { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxUnitVector Normal { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxSurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pRootPoint">pRootPoint</param>
    /// <param name="pNormal">pNormal</param>
    void GetPlaneData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pRootPoint, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pNormal);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pRootPoint">pRootPoint</param>
    /// <param name="pNormal">pNormal</param>
    void PutPlaneData([In] [MarshalAs(UnmanagedType.LPArray)] double[] pRootPoint, [In] [MarshalAs(UnmanagedType.LPArray)] double[] pNormal);
}
