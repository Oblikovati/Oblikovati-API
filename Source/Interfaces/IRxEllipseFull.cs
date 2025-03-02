namespace Oblikovati.API;

public interface IRxEllipseFull
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
    IRxVector MajorAxisVector { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double MinorMajorRatio { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCurveEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenter">pCenter</param>
    /// <param name="pNormal">pNormal</param>
    /// <param name="pMajorAxis">pMajorAxis</param>
    /// <param name="pMinorMajorRatio">pMinorMajorRatio</param>
    void GetEllipseFullData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pCenter, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pNormal, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pMajorAxis, [Out] out double pMinorMajorRatio);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenter">pCenter</param>
    /// <param name="pNormal">pNormal</param>
    /// <param name="pMajorAxis">pMajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    void PutEllipseFullData([In] [MarshalAs(UnmanagedType.LPArray)] double[,] pCenter, [In] [MarshalAs(UnmanagedType.LPArray)] double[,] pNormal, [In] [MarshalAs(UnmanagedType.LPArray)] double[,] pMajorAxis, [In] double MinorMajorRatio);
}
