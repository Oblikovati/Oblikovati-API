namespace Oblikovati.API;

public interface IRxVertex
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumEdges Edges { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IRxEnumFaces Faces { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pPoint">pPoint</param>
    void GetPoint([Out] [MarshalAs(UnmanagedType.LPArray)] out double[] pPoint);
}
