namespace Oblikovati.API;

/// <summary>
/// PublicationTweak object.
/// </summary>
public interface PublicationTweak
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
    /// Read-write property that gets and sets the PublicationTweakDefinition object associated with this publication tweak object.
    /// </summary>
    PublicationTweakDefinition Definition { get; set; }
    /// <summary>
    /// Read-only property that returns the PublicationTrailSegmentsEnumerator collection object.
    /// </summary>
    PublicationTrailSegmentsEnumerator TrailSegments { get; }
    /// <summary>
    /// Read-only property that returns the PublicationTweakPaths collection object.
    /// </summary>
    PublicationTweakPaths Paths { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Deletes the publication tweak.
    /// </summary>
    [PreserveSig]
    void Delete();
}
