namespace Oblikovati.API;

/// <summary>
/// PresentationBody Object.
/// </summary>
public interface PresentationBody
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns all the PresentationEdge objects contained within the Presentation body.
    /// </summary>
    PresentationEdgesEnumerator Edges { get; }
    /// <summary>
    /// Read-only property that returns all the PresentationFace objects contained within the presentation body.
    /// </summary>
    PresentationFacesEnumerator Faces { get; }
    /// <summary>
    /// Read-only property that gets the presentation body name.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the range box that represents the bounds of the presentation body.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Read-only property that returns all the PresentationVertex objects contained within the presentation body.
    /// </summary>
    PresentationVerticesEnumerator Vertices { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PresentationComponent Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    [PreserveSig]
    void CalculateFacets([In] double Tolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceIndex">ToleranceIndex</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    [PreserveSig]
    void GetExistingFacets([In] double ToleranceIndex, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceCount">ToleranceCount</param>
    /// <param name="ExistingTolerances">ExistingTolerances</param>
    [PreserveSig]
    void GetExistingFacetTolerances([Out] out int ToleranceCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] ExistingTolerances);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    [PreserveSig]
    void CalculateFacetsAndTextureMap([In] double Tolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] TextureCoordinates);
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
    [PreserveSig]
    void CalculateFacetsWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors);
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
    [PreserveSig]
    void CalculateFacetsWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices, [Out] [MarshalAs(UnmanagedType.Struct)] out object TextureCoordinates);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceIndex">ToleranceIndex</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    [PreserveSig]
    void GetExistingFacetsAndTextureMap([In] double ToleranceIndex, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] TextureCoordinates);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalTolerance">ChordalTolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="FacetCount">FacetCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="NormalVectors">NormalVectors</param>
    /// <param name="VertexIndices">VertexIndices</param>
    /// <param name="TextureCoordinates">TextureCoordinates</param>
    /// <param name="IndexCountPerFace">IndexCountPerFace</param>
    [PreserveSig]
    void GetExistingFacetsAndTextureMap2([In] double ChordalTolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] TextureCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] IndexCountPerFace);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="SegmentCount">SegmentCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="VertexIndices">VertexIndices</param>
    [PreserveSig]
    void CalculateStrokes([In] double Tolerance, [Out] out int VertexCount, [Out] out int SegmentCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] VertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceIndex">ToleranceIndex</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="PolylineCount">PolylineCount</param>
    /// <param name="PolylineLengths">PolylineLengths</param>
    [PreserveSig]
    void GetExistingStrokes([In] double ToleranceIndex, [Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] out int PolylineCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] PolylineLengths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceCount">ToleranceCount</param>
    /// <param name="ExistingTolerances">ExistingTolerances</param>
    [PreserveSig]
    void GetExistingStrokeTolerances([Out] out int ToleranceCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] ExistingTolerances);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ChordalTolerance">ChordalTolerance</param>
    /// <param name="Options">Options</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="PolylineCount">PolylineCount</param>
    /// <param name="PolylineLengths">PolylineLengths</param>
    [PreserveSig]
    void CalculateStrokesWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] VertexCoordinates, [Out] out int PolylineCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[,] PolylineLengths);
}
