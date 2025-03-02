namespace Oblikovati.API;

/// <summary>
/// PresentationEdge Object.
/// </summary>
public interface PresentationEdge
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the CurveEvaluator for this presentation edge.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Read-only property that returns the PresentationFace objects that are adjacent to this edge.
    /// </summary>
    PresentationFacesEnumerator Faces { get; }
    /// <summary>
    /// Read-only property that returns the underlying geometry of the edge (e.g. Arc2D, Circle, Cone etc.).
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Read-only property that returns the form of the underlying geometry as a combination of one or more CurveGeometryFormEnum values.
    /// </summary>
    int GeometryForm { get; }
    /// <summary>
    /// Read-only property that returns the curve type of the curve that will be returned from the Geometry property.
    /// </summary>
    CurveTypeEnum GeometryType { get; }
    /// <summary>
    /// Read-only property that gets whether the parameterization of the geometry obtained from the Geometry property is aligned or opposed to the topological sense of this edge.
    /// </summary>
    bool IsParamReversed { get; }
    /// <summary>
    /// Read-only property that returns a characteristic somewhere in the middle of the edge.
    /// </summary>
    Point PointOnEdge { get; }
    /// <summary>
    /// Read-only property that returns the PresentationVertex object referenced at the start of this presentation edge.
    /// </summary>
    PresentationVertex StartVertex { get; }
    /// <summary>
    /// Read-only property that returns the PresentationVertex object referenced at the end of this presentation edge.
    /// </summary>
    PresentationVertex StopVertex { get; }
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
