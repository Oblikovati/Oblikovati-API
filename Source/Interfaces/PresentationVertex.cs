namespace Oblikovati.API;

/// <summary>
/// PresentationVertex Object.
/// </summary>
public interface PresentationVertex
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the PresentationEdge objects that are adjacent to this vertex.
    /// </summary>
    PresentationEdgesEnumerator Edges { get; }
    /// <summary>
    /// Read-only property that returns the PresentationFace objects that are adjacent to this vertex.
    /// </summary>
    PresentationFacesEnumerator Faces { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PresentationBody Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
