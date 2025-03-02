namespace Oblikovati.API;

/// <summary>
/// The PointCloudPoint object represents a point within a point cloud.
/// </summary>
public interface PointCloudPoint
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the parent point cloud of this point.
    /// </summary>
    PointCloud Parent { get; }
    /// <summary>
    /// Read-only property that returns a Point object which provides the coordinates of this point.
    /// </summary>
    Point Geometry { get; }
}
