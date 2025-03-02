namespace Oblikovati.API;

public interface IRxEllipseFull2d
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint2d Center { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxVector2d MajorAxisVector { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double MinorMajorRatio { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxCurve2dEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenter">pCenter</param>
    /// <param name="pMajorAxis">pMajorAxis</param>
    /// <param name="pMinorMajorRatio">pMinorMajorRatio</param>
    void GetEllipseFullData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pCenter, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pMajorAxis, [Out] out double pMinorMajorRatio);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenter">pCenter</param>
    /// <param name="pMajorAxis">pMajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    void PutEllipseFullData([In] [MarshalAs(UnmanagedType.LPArray)] double[] pCenter, [In] [MarshalAs(UnmanagedType.LPArray)] double[] pMajorAxis, [In] double MinorMajorRatio);
}
