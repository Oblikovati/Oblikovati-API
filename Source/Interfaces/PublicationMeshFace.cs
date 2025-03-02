namespace Oblikovati.API;

/// <summary>
/// PublicationMeshFace Object.
/// </summary>
public interface PublicationMeshFace
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-only property that returns the surface evaluator for this MeshFace.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Read-only property that returns the transient Brep Face for the MeshFace.
    /// </summary>
    Face Face { get; }
    /// <summary>
    /// Read-only property that returns the underlying geometry of the MeshFace.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Read-only property that returns a SurfaceTypeEnum that specifies the surface type for this MeshFace.
    /// </summary>
    SurfaceTypeEnum SurfaceType { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns PublicationComponent object.
    /// </summary>
    PublicationComponent Component { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
