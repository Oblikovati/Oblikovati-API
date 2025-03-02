namespace Oblikovati.API;

/// <summary>
/// MeshFaceProxy Object.
/// </summary>
public interface MeshFaceProxy
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
    /// Read-only property that returns the underlying geometry of the MeshFace.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Read-only property that returns a SurfaceTypeEnum that specifies the surface type for this MeshFace.
    /// </summary>
    SurfaceTypeEnum SurfaceType { get; }
    /// <summary>
    /// Read-only property that returns the surface evaluator for this MeshFace.This evaluator differs from the one that could be obtained from the surface geometry definition in that this evaluator accounts for the topological orientation.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Read-only property that returns the transient Brep Face for the MeshFace.
    /// </summary>
    Face Face { get; }
    /// <summary>
    /// Read-only property that returns the MeshFeature this MeshFace is located on.
    /// </summary>
    MeshFeature MeshFeature { get; }
    /// <summary>
    /// Read-only property that returns the MeshFeatureEntity this MeshFace is located on.
    /// </summary>
    MeshFeatureEntity MeshFeatureEntity { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    MeshFace NativeObject { get; }
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
