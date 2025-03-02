namespace Oblikovati.API;

/// <summary>
/// The PointCloudScan object represents a scan within a point cloud.
/// </summary>
public interface PointCloudScan
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the display name of the point cloud scan.
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Read-only property that returns internal name of the point cloud scan.
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PointCloud Parent { get; }
    /// <summary>
    /// Read-only property that returns the point cloud scan full file name.
    /// </summary>
    string SourceFullFileName { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and set the visibility of the point cloud scan object.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-only property that returns a point indicating the origin of the PointCloudScan.
    /// </summary>
    Point Origin { get; }
}
