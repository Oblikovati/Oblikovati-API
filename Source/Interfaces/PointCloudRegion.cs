namespace Oblikovati.API;

/// <summary>
/// The PointCloudRegion object represents a region within a point cloud.
/// </summary>
public interface PointCloudRegion
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns internal name of the point cloud region.
    /// </summary>
    Color Color { get; }
    /// <summary>
    /// Read-only property that returns the display name of the point cloud region.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Read-only property that returns internal name of the point cloud region.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PointCloud Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the visibility of the point cloud region object.
    /// </summary>
    bool Visible { get; set; }
}
