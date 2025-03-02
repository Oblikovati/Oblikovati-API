namespace Oblikovati.API;

/// <summary>
/// DWGEntityLineSegment object.
/// </summary>
public interface DWGEntityLineSegment
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the parent DWGEntity.
    /// </summary>
    DWGEntity Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that returns the segment geometry.
    /// </summary>
    LineSegment Geometry { get; }
}
