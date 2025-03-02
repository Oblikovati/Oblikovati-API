namespace Oblikovati.API;

public interface IRxFacetsOld
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalHeightTol">ChordalHeightTol</param>
    /// <param name="pdwNumVertices">pdwNumVertices</param>
    /// <param name="ppVertices">ppVertices</param>
    /// <param name="ppNormals">ppNormals</param>
    /// <param name="pdwNumFacets">pdwNumFacets</param>
    /// <param name="ppVertexIndices">ppVertexIndices</param>
    void GetFacets([In] double ChordalHeightTol, [Out] out uint pdwNumVertices, [Out] out IntPtr ppVertices, [Out] out IntPtr ppNormals, [Out] out uint pdwNumFacets, [Out] out IntPtr ppVertexIndices);
}
