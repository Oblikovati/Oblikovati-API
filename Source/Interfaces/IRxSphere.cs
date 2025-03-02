namespace Oblikovati.API;

public interface IRxSphere
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint CenterPoint { get; set; }
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
    /// <param name="pCenterPoint">pCenterPoint</param>
    /// <param name="pRadius">pRadius</param>
    void GetSphereData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pCenterPoint, [Out] out double pRadius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCenterPoint">pCenterPoint</param>
    /// <param name="Radius">Radius</param>
    void PutSphereData([In] [MarshalAs(UnmanagedType.LPArray)] double[,] pCenterPoint, [In] double Radius);
}
