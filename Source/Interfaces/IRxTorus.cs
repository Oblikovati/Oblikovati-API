namespace Oblikovati.API;

public interface IRxTorus
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint CenterPoint { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxUnitVector AxisVector { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double MajorRadius { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double MinorRadius { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxSurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenterPoint">pCenterPoint</param>
    /// <param name="pAxisVector">pAxisVector</param>
    /// <param name="pMajorRadius">pMajorRadius</param>
    /// <param name="pMinorRadius">pMinorRadius</param>
    void GetTorusData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pCenterPoint, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pAxisVector, [Out] out double pMajorRadius, [Out] out double pMinorRadius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenterPoint">pCenterPoint</param>
    /// <param name="pAxisVector">pAxisVector</param>
    /// <param name="MajorRadius">MajorRadius</param>
    /// <param name="MinorRadius">MinorRadius</param>
    void PutTorusData([In] [MarshalAs(UnmanagedType.LPArray)] double[,] pCenterPoint, [In] [MarshalAs(UnmanagedType.LPArray)] double[,] pAxisVector, [In] double MajorRadius, [In] double MinorRadius);
}
