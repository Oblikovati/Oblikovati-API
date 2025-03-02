namespace Oblikovati.API;

public interface IRxVector2d
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
    /// <param name="pCoords">pCoords</param>
    void GetVectorData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] pCoords);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCoords">pCoords</param>
    void PutVectorData([In] [MarshalAs(UnmanagedType.LPArray)] double[,] pCoords);
}
