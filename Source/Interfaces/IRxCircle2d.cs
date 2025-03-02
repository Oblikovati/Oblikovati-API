namespace Oblikovati.API;

public interface IRxCircle2d
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint2d Center { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double Radius { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCurve2dEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenter">pCenter</param>
    /// <param name="pRadius">pRadius</param>
    void GetCircleData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pCenter, [Out] out double pRadius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenter">pCenter</param>
    /// <param name="Radius">Radius</param>
    void PutCircleData([In] [MarshalAs(UnmanagedType.LPArray)] double[,] pCenter, [In] double Radius);
}
