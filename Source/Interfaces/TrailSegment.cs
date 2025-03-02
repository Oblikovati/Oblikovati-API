namespace Oblikovati.API;

/// <summary>
/// The TrailSegment object represents a portion of a trail created by one particular tweak operation.
/// </summary>
public interface TrailSegment
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    Trail Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that indicates whether the trail segment is linear or circular. The property returns True if the segment is linear.
    /// </summary>
    bool Linear { get; }
    /// <summary>
    /// Property that returns the snapshot of the geometry of the trail segment. The object returned can either be a LineSegment or an Arc3d.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Property that returns whether the TrailSegment is visible.
    /// </summary>
    bool Visible { get; }
}
