namespace Oblikovati.API;

/// <summary>
/// The PointCloudCrop object represents a crop within a point cloud.
/// </summary>
public interface PointCloudCrop
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the oriented box presents the bounding volume of the point cloud crop.
    /// </summary>
    OrientedBox BoundingBox { get; }
    /// <summary>
    /// Read-only property that returns whether the cloud points in the bounding box are kept or not in this crop.
    /// </summary>
    bool KeepInside { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PointCloud Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
