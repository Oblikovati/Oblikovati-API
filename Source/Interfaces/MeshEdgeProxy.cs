namespace Oblikovati.API;

/// <summary>
/// MeshEdgeProxy Object.
/// </summary>
public interface MeshEdgeProxy
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the underlying geometry of the MeshEdge.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Read-only property that returns a curve type of the curve that will be returned from the Geometry property.
    /// </summary>
    CurveTypeEnum GeometryType { get; }
    /// <summary>
    /// Read-only property that returns the curve evaluator for this MeshEdge. This evaluator differs from the one that could be obtained from the surface geometry definition in that this evaluator accounts for the topological orientation.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Read-only property that returns the transient Brep Edge for the MeshEdge.
    /// </summary>
    Edge Edge { get; }
    /// <summary>
    /// Read-only property that returns the MeshFeature this MeshEdge is located on.
    /// </summary>
    MeshFeature MeshFeature { get; }
    /// <summary>
    /// Read-only property that returns the MeshFeatureEntity this MeshEdge is located on.
    /// </summary>
    MeshFeatureEntity MeshFeatureEntity { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    MeshEdge NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
