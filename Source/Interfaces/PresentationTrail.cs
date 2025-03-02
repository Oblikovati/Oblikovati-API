namespace Oblikovati.API;

/// <summary>
/// PresentationTrail Object.
/// </summary>
public interface PresentationTrail
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the PresentationComponent object this trail is associative with.
    /// </summary>
    PresentationComponent PresentationComponent { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Read-only property that returns the PresentationTrailSegments collection object.
    /// </summary>
    PresentationTrailSegments Segments { get; }
    /// <summary>
    /// Read-only property that returns whether this presentation trail is marked as deleted. This property is only applicable for the default presentation trial, i.e. the IsDefaultTrail should return True.
    /// </summary>
    bool Deleted { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
