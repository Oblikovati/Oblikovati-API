namespace Oblikovati.API;

public interface IRxFacets : IRxFacetsOld
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="pdwNumTols">pdwNumTols</param>
    /// <param name="ppTols">ppTols</param>
    void GetExistingTolerances([In] [Out] ref uint pdwNumTols, [Out] out IntPtr ppTols);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalHeightTol">ChordalHeightTol</param>
    /// <param name="pdwNumVertices">pdwNumVertices</param>
    /// <param name="ppVertices">ppVertices</param>
    /// <param name="ppNormals">ppNormals</param>
    /// <param name="pdwNumFacets">pdwNumFacets</param>
    /// <param name="ppVertexIndices">ppVertexIndices</param>
    void GetExistingFacets([In] double ChordalHeightTol, [In] [Out] ref uint pdwNumVertices, [Out] out IntPtr ppVertices, [Out] out IntPtr ppNormals, [In] [Out] ref uint pdwNumFacets, [Out] out IntPtr ppVertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalHeightTol">ChordalHeightTol</param>
    /// <param name="pdwNumVertices">pdwNumVertices</param>
    /// <param name="ppVertices">ppVertices</param>
    /// <param name="ppNormals">ppNormals</param>
    /// <param name="pdwNumFacets">pdwNumFacets</param>
    /// <param name="ppVertexIndices">ppVertexIndices</param>
    /// <param name="ppTextureCoordinates">ppTextureCoordinates</param>
    void GetExistingFacetsAndTextureMap([In] double ChordalHeightTol, [In] [Out] ref uint pdwNumVertices, [Out] out IntPtr ppVertices, [Out] out IntPtr ppNormals, [In] [Out] ref uint pdwNumFacets, [Out] out IntPtr ppVertexIndices, [Out] out IntPtr ppTextureCoordinates);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalHeightTol">ChordalHeightTol</param>
    /// <param name="pdwNumVertices">pdwNumVertices</param>
    /// <param name="ppVertices">ppVertices</param>
    /// <param name="ppNormals">ppNormals</param>
    /// <param name="pdwNumFacets">pdwNumFacets</param>
    /// <param name="ppVertexIndices">ppVertexIndices</param>
    /// <param name="ppTextureCoordinates">ppTextureCoordinates</param>
    void CalculateFacetsAndTextureMap([In] double ChordalHeightTol, [In] [Out] ref uint pdwNumVertices, [Out] out IntPtr ppVertices, [Out] out IntPtr ppNormals, [In] [Out] ref uint pdwNumFacets, [Out] out IntPtr ppVertexIndices, [Out] out IntPtr ppTextureCoordinates);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalTolerance">ChordalTolerance</param>
    /// <param name="Options">Options</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    void CalculateFacetsWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [In] [Out] ref uint VertexCount, [In] [Out] ref uint FacetCount, [Out] out IntPtr VertexCoordinates, [Out] out IntPtr NormalVectors, [Out] out IntPtr VertexIndices, [Out] out IntPtr TextureCoordinates);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalTolerance">ChordalTolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="FaceCount">FaceCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    /// <param name="IndexCountPerFace">IndexCountPerFace</param>
    void GetExistingFacetsAndTextureMap2([In] double ChordalTolerance, [In] [Out] ref uint VertexCount, [In] [Out] ref uint FacetCount, [In] [Out] ref uint FaceCount, [Out] out IntPtr VertexCoordinates, [Out] out IntPtr NormalVectors, [Out] out IntPtr VertexIndices, [Out] out IntPtr TextureCoordinates, [Out] out IntPtr IndexCountPerFace);
}
