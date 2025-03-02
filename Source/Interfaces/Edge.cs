namespace Oblikovati.API;

/// <summary>
/// The Edge object. See the Boundary Representation article in the overviews section.
/// </summary>
public interface Edge
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    SurfaceBody Parent { get; }
    /// <summary>
    /// Get the Wire containing this Edge. Returns Nothing if this Edge does not belong to a Wire.
    /// </summary>
    Wire Wire { get; }
    /// <summary>
    /// Gets the Vertex referenced at the start of this Edge.
    /// </summary>
    Vertex StartVertex { get; }
    /// <summary>
    /// Gets the Vertex referenced at the end of this Edge.
    /// </summary>
    Vertex StopVertex { get; }
    /// <summary>
    /// Gets the that reference this Edge.
    /// </summary>
    EdgeUses EdgeUses { get; }
    /// <summary>
    /// Property that returns the that this Edge is referenced from.
    /// </summary>
    Faces Faces { get; }
    /// <summary>
    /// Gets whether the parameterization of the geometry obtained from the Geometry property is aligned or opposed to the topological sense of this Edge.
    /// </summary>
    bool IsParamReversed { get; }
    /// <summary>
    /// Get the curve type of the curve that will be returned from the Geometry property.
    /// </summary>
    CurveTypeEnum GeometryType { get; }
    /// <summary>
    /// Property that returns the underlying geometry of the edge (e.g. Arc2D, Circle, Cone etc.)
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Gets the form of the underlying geometry as a combination of one or more CurveGeometryFormEnum values.
    /// </summary>
    int GeometryForm { get; }
    /// <summary>
    /// Gets the CurveEvaluator for this Edge.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns an that contains the input edge and all tangentially connected edges. The CollectionType of the output EdgeCollection is set to kTangentiallyConnected.
    /// </summary>
    EdgeCollection TangentiallyConnectedEdges { get; }
    /// <summary>
    /// Property that obtains an ID key that can be used to bind back to the live object. This transient key is only valid as long as the document state has not changed. For more information, see the ReferenceKeys overview.
    /// </summary>
    int TransientKey { get; }
    /// <summary>
    /// Property that returns a characteristic somewhere in the middle of the Edge.
    /// </summary>
    Point PointOnEdge { get; }
    /// <summary>
    /// Indicates if this Edge is using tolerant modeling to allow a non-exact model.
    /// </summary>
    bool IsTolerant { get; }
    /// <summary>
    /// Returns the tolerance being used for modeling calculations and this Edge.
    /// </summary>
    double Tolerance { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int AssociativeID { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CurveTypeEnum CurveType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Curve { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
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
    /// Method that gets the source edge that has been overridden by this edge. The method returns Nothing if this edge is not an override. An error is returned if this method is called on an edge in a part.
    /// </summary>
    /// <param name="GetLeafSource">Optional input Boolean that specifies whether to get the 'leaf' source edge in the case where there are multiple levels of override. If specified to be False, the method returns the next level override edge. If not specified, the argument defaults to True indicating that the leaf source will be returned.</param>
    /// <returns></returns>
    [PreserveSig]
    Edge GetSourceEdge([In] bool? GetLeafSource = true);
    /// <summary>
    /// Method that returns a point on the edge that is closest to the input point. A single point is returned even if multiple equidistant points are found. To get the u parameter of the returned point on the edge, use Edge.Evaluator.GetParamAtPoint method.
    /// </summary>
    /// <param name="InputPoint">Point object that specifies the point for which the closest point on the edge is to be located. If the input point lies on the Edge, the coordinates of the input point are returned.</param>
    /// <returns></returns>
    [PreserveSig]
    Point GetClosestPointTo([In] [MarshalAs(UnmanagedType.Interface)] Point InputPoint);
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
