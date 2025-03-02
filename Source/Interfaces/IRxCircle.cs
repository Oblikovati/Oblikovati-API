namespace Oblikovati.API;

public interface IRxCircle
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint Center { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxUnitVector Normal { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double Radius { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCurveEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenter">pCenter</param>
    /// <param name="pNormal">pNormal</param>
    /// <param name="pRadius">pRadius</param>
    void GetCircleData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pCenter, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pNormal, [Out] out double pRadius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenter">pCenter</param>
    /// <param name="pNormal">pNormal</param>
    /// <param name="Radius">Radius</param>
    void PutCircleData([In] [MarshalAs(UnmanagedType.LPArray)] double[] pCenter, [In] [MarshalAs(UnmanagedType.LPArray)] double[] pNormal, [In] double Radius);
}
