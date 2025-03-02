namespace Oblikovati.API;

public interface IRxStrokesOld
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalHeightTol">ChordalHeightTol</param>
    /// <param name="pdwNumVertices">pdwNumVertices</param>
    /// <param name="ppVertices">ppVertices</param>
    /// <param name="pdwNumSegments">pdwNumSegments</param>
    /// <param name="ppVertexIndices">ppVertexIndices</param>
    void GetStrokes([In] double ChordalHeightTol, [In] [Out] ref uint pdwNumVertices, [Out] out IntPtr ppVertices, [In] [Out] ref uint pdwNumSegments, [Out] out IntPtr ppVertexIndices);
}
