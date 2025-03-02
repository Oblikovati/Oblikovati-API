namespace Oblikovati.API;

public interface IRxCylinder
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
    IRxSurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pBasePoint">pBasePoint</param>
    /// <param name="pAxisVector">pAxisVector</param>
    /// <param name="pRadius">pRadius</param>
    void GetCylinderData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pBasePoint, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pAxisVector, [Out] out double pRadius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pBasePoint">pBasePoint</param>
    /// <param name="pAxisVector">pAxisVector</param>
    /// <param name="Radius">Radius</param>
    void PutCylinderData([In] [MarshalAs(UnmanagedType.LPArray)] double[,] pBasePoint, [In] [MarshalAs(UnmanagedType.LPArray)] double[,] pAxisVector, [In] double Radius);
}
