namespace Oblikovati.API;

/// <summary>
/// PublicationFaceShell object.
/// </summary>
public interface PublicationFaceShell
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PublicationBody Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns all the PublicationEdge objects contained within the publication faceshell.
    /// </summary>
    PublicationEdgesEnumerator Edges { get; }
    /// <summary>
    /// Read-only property that returns the PublicationFacesEnumerator collection.
    /// </summary>
    PublicationFacesEnumerator Faces { get; }
    /// <summary>
    /// Read-only property that returns the publication body for this publication faceshell.
    /// </summary>
    PublicationBody PublicationBody { get; }
    /// <summary>
    /// Read-only property that returns the volume of the publication faceshell in database units.
    /// </summary>
    double Volume { get; }
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
