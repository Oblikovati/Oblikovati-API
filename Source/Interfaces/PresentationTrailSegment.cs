namespace Oblikovati.API;

/// <summary>
/// PresentationTrailSegment Object.
/// </summary>
public interface PresentationTrailSegment
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the tweak trail representative geometry.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the presentation&nbsp;trail segment is visible or not.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
