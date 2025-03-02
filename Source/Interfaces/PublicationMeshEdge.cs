namespace Oblikovati.API;

/// <summary>
/// PublicationMeshEdge Object.
/// </summary>
public interface PublicationMeshEdge
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
    /// Read-only property that returns the curve evaluator for this MeshEdge.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Read-only property that returns the transient Brep Edge for the MeshEdge.
    /// </summary>
    Edge Edge { get; }
    /// <summary>
    /// Read-only property that returns the underlying geometry of the&nbsp;MeshEdge.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Read-only property that returns curve type of the curve that will be returned from the Geometry property.
    /// </summary>
    CurveTypeEnum GeometryType { get; }
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
