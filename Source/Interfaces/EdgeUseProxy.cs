namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface EdgeUseProxy
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
    /// Gets the that this EdgeUse references.
    /// </summary>
    Edge Edge { get; }
    /// <summary>
    /// Gets the that contains this EdgeUse.
    /// </summary>
    EdgeLoop EdgeLoop { get; }
    /// <summary>
    /// Get the Wire containing this EdgeUse. Returns Nothing if this EdgeUse does not belong to a Wire.
    /// </summary>
    Wire Wire { get; }
    /// <summary>
    /// In a solid, Face objects are connected to other Face objects by virtue of sharing at least one Edge. The shared Edge is the same object. objects, however ,are unique to a particular face. The Partner property returns the corresponding EdgeUse that belongs to the connected face.
    /// </summary>
    EdgeUse Partner { get; }
    /// <summary>
    /// Gets the next in the connected list of EdgeUses in the EdgeLoop.
    /// </summary>
    EdgeUse Next { get; }
    /// <summary>
    /// Gets the previous .
    /// </summary>
    EdgeUse Previous { get; }
    /// <summary>
    /// Gets whether this EdgeUse is opposed to or aligned with the orientation of the referenced Edge.
    /// </summary>
    bool IsOpposedToEdge { get; }
    /// <summary>
    /// Gets whether the parameterization of the geometry obtained from the Curve property is aligned or opposed to the topological sense of this EdgeUse.
    /// </summary>
    bool IsParamReversed { get; }
    /// <summary>
    /// Gets the type of the underlying curve geometry that this EdgeUse is defined by.
    /// </summary>
    Curve2dTypeEnum CurveType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Curve { get; }
    /// <summary>
    /// Property that returns the underlying geometry of the edge use.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Gets the form of the underlying geometry as a combination of one or more CurveGeometryFormEnum values.
    /// </summary>
    int GeometryForm { get; }
    /// <summary>
    /// Gets the Curve2dEvaluator for this edge use.
    /// </summary>
    Curve2dEvaluator Evaluator { get; }
    /// <summary>
    /// Property that obtains an ID key that can be used to bind back to the live object. This transient key is only valid as long as the document state has not changed. For more information, see the ReferenceKeys overview.
    /// </summary>
    int TransientKey { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    EdgeUse NativeObject { get; }
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
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
