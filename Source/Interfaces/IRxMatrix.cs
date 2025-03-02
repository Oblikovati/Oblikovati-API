namespace Oblikovati.API;

public interface IRxMatrix
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    double Cell { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCells">pCells</param>
    void GetMatrixData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pCells);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pCells">pCells</param>
    void PutMatrixData([In] [MarshalAs(UnmanagedType.LPArray)] double[] pCells);
}
