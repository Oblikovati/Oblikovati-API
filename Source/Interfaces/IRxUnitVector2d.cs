namespace Oblikovati.API;

public interface IRxUnitVector2d
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
    /// <param name="ppCoords">ppCoords</param>
    void GetUnitVectorData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[,] ppCoords);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCoords">pCoords</param>
    void PutUnitVectorData([In] [MarshalAs(UnmanagedType.LPArray)] double[,] pCoords);
}
