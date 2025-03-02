namespace Oblikovati.API;

public interface IRxPoint
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double X { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double Y { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double Z { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCoords">pCoords</param>
    void GetPointData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pCoords);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCoords">pCoords</param>
    void PutPointData([In] [MarshalAs(UnmanagedType.LPArray)] double[,] pCoords);
}
