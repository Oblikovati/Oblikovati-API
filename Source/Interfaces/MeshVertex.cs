namespace Oblikovati.API;

/// <summary>
/// MeshVertex Object.
/// </summary>
public interface MeshVertex
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
