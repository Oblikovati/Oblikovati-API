namespace Oblikovati.API;

public interface IRxUnitVector
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
    void GetUnitVectorData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pCoords);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCoords">pCoords</param>
    void PutUnitVectorData([In] [MarshalAs(UnmanagedType.LPArray)] double[] pCoords);
}
