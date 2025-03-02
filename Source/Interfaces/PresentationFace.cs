namespace Oblikovati.API;

/// <summary>
/// PresentationFace Object.
/// </summary>
public interface PresentationFace
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns all the PresentationEdge objects contained within the presentation face.
    /// </summary>
    PresentationEdgesEnumerator Edges { get; }
    /// <summary>
    /// Read-only property that returns the SurfaceEvaluator for this presentation face.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Read-only property that returns the underlying geometry of the face.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Read-only property that returns the form of the underlying geometry as a combination of one or more CurveGeometryFormEnum values.
    /// </summary>
    int GeometryForm { get; }
    /// <summary>
    /// Read-only property that gets whether the parameterization of the geometry obtained from the Geometry property is aligned or opposed to the topological sense of this face.
    /// </summary>
    bool IsParamReversed { get; }
    /// <summary>
    /// Read-only property that returns a characteristic somewhere on the interior of the face.
    /// </summary>
    Point PointOnFace { get; }
    /// <summary>
    /// Read-only property that returns the presentation body that this face is associative with.
    /// </summary>
    PresentationBody PresentationBody { get; }
    /// <summary>
    /// Read-only property that returns all the PresentationVertex objects contained within the presentation face.
    /// </summary>
    PresentationVerticesEnumerator Vertices { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PresentationBody Parent { get; }
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
    void CalculateFacets([In] double Tolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices);
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
    void GetExistingFacets([In] double ToleranceIndex, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceCount">ToleranceCount</param>
    /// <param name="ExistingTolerances">ExistingTolerances</param>
    [PreserveSig]
    void GetExistingFacetTolerances([Out] out int ToleranceCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] ExistingTolerances);
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
    void CalculateFacetsAndTextureMap([In] double Tolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] TextureCoordinates);
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
    void CalculateFacetsWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors);
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
    void CalculateFacetsWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices, [Out] [MarshalAs(UnmanagedType.Struct)] out object TextureCoordinates);
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
    void GetExistingFacetsAndTextureMap([In] double ToleranceIndex, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] TextureCoordinates);
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
    void GetExistingFacetsAndTextureMap2([In] double ChordalTolerance, [Out] out int VertexCount, [Out] out int FacetCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] NormalVectors, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] TextureCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] IndexCountPerFace);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Tolerance">Tolerance</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="SegmentCount">SegmentCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="VertexIndices">VertexIndices</param>
    [PreserveSig]
    void CalculateStrokes([In] double Tolerance, [Out] out int VertexCount, [Out] out int SegmentCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] VertexIndices);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceIndex">ToleranceIndex</param>
    /// <param name="VertexCount">VertexCount</param>
    /// <param name="VertexCoordinates">VertexCoordinates</param>
    /// <param name="PolylineCount">PolylineCount</param>
    /// <param name="PolylineLengths">PolylineLengths</param>
    [PreserveSig]
    void GetExistingStrokes([In] double ToleranceIndex, [Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] out int PolylineCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] PolylineLengths);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ToleranceCount">ToleranceCount</param>
    /// <param name="ExistingTolerances">ExistingTolerances</param>
    [PreserveSig]
    void GetExistingStrokeTolerances([Out] out int ToleranceCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] ExistingTolerances);
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
    void CalculateStrokesWithOptions([In] double ChordalTolerance, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [Out] out int VertexCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[] VertexCoordinates, [Out] out int PolylineCount, [Out] [MarshalAs(UnmanagedType.SafeArray)] out int[] PolylineLengths);
}
