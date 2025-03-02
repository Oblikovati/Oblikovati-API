namespace Oblikovati.API;

/// <summary>
/// PublicationTrail Object.
/// </summary>
public interface PublicationTrail
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the origin point of the publication trail.
    /// </summary>
    GeometryIntent Origin { get; }
    /// <summary>
    /// Read-only property that returns the PublicationComponent object this trail is associative with.
    /// </summary>
    PublicationComponent PublicationComponent { get; }
    /// <summary>
    /// Read-only property that returns the PublicationTrailSegments collection object.
    /// </summary>
    PublicationTrailSegments Segments { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Deleted { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes this object.
    /// </summary>
    [PreserveSig]
    void Delete();
}
