namespace Oblikovati.API;

/// <summary>
/// MeshVertexProxy Object.
/// </summary>
public interface MeshVertexProxy
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
    Point Geometry { get; }
    /// <summary>
    /// Read-only property that returns the MeshFeature this MeshVertex is located on.
    /// </summary>
    MeshFeature MeshFeature { get; }
    /// <summary>
    /// Read-only property that returns the MeshFeatureEntity this MeshVertex is located on.
    /// </summary>
    MeshFeatureEntity MeshFeatureEntity { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    MeshVertex NativeObject { get; }
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
