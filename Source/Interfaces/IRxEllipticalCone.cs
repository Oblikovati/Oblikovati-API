namespace Oblikovati.API;

public interface IRxEllipticalCone
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint BasePoint { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxUnitVector AxisVector { get; set; }
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
    double HalfAngle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    sbyte IsExpanding { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxSurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pBasePoint">pBasePoint</param>
    /// <param name="pAxisVector">pAxisVector</param>
    /// <param name="pMajorAxis">pMajorAxis</param>
    /// <param name="pMinorMajorRatio">pMinorMajorRatio</param>
    /// <param name="pHalfAngle">pHalfAngle</param>
    /// <param name="pbIsExpanding">pbIsExpanding</param>
    void GetEllipticalConeData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pBasePoint, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pAxisVector, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pMajorAxis, [Out] out double pMinorMajorRatio, [Out] out double pHalfAngle, [Out] out sbyte pbIsExpanding);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pBasePoint">pBasePoint</param>
    /// <param name="pAxisVector">pAxisVector</param>
    /// <param name="pMajorAxis">pMajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    /// <param name="HalfAngle">HalfAngle</param>
    /// <param name="bIsExpanding">bIsExpanding</param>
    void PutEllipticalConeData([In] [MarshalAs(UnmanagedType.LPArray)] double[] pBasePoint, [In] [MarshalAs(UnmanagedType.LPArray)] double[] pAxisVector, [In] [MarshalAs(UnmanagedType.LPArray)] double[] pMajorAxis, [In] double MinorMajorRatio, [In] double HalfAngle, [In] sbyte bIsExpanding);
}
