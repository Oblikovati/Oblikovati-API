namespace Oblikovati.API;

public interface IRxCone
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
    double Radius { get; set; }
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
    /// <param name="pRadius">pRadius</param>
    /// <param name="pHalfAngle">pHalfAngle</param>
    /// <param name="pbIsExpanding">pbIsExpanding</param>
    void GetConeData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pBasePoint, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pAxisVector, [Out] out double pRadius, [Out] out double pHalfAngle, [Out] out sbyte pbIsExpanding);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pBasePoint">pBasePoint</param>
    /// <param name="pAxisVector">pAxisVector</param>
    /// <param name="Radius">Radius</param>
    /// <param name="HalfAngle">HalfAngle</param>
    /// <param name="bIsExpanding">bIsExpanding</param>
    void PutConeData([In] [MarshalAs(UnmanagedType.LPArray)] double[] pBasePoint, [In] [MarshalAs(UnmanagedType.LPArray)] double[] pAxisVector, [In] double Radius, [In] double HalfAngle, [In] sbyte bIsExpanding);
}
