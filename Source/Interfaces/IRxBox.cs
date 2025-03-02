namespace Oblikovati.API;

public interface IRxBox
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint MinPoint { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxPoint MaxPoint { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pMinPoint">pMinPoint</param>
    /// <param name="pMaxPoint">pMaxPoint</param>
    void GetBoxData([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pMinPoint, [Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pMaxPoint);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pMinPoint">pMinPoint</param>
    /// <param name="pMaxPoint">pMaxPoint</param>
    void PutBoxData([In] [MarshalAs(UnmanagedType.LPArray)] double[] pMinPoint, [In] [MarshalAs(UnmanagedType.LPArray)] double[] pMaxPoint);
}
