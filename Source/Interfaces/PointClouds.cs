namespace Oblikovati.API;

/// <summary>
/// PointClouds Collection Object.
/// </summary>
public interface PointClouds : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    PointCloud Item { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new point cloud. The newly created PointCloud object is returned.
    /// </summary>
    /// <param name="PointCloudFilename">Input full filename of a point cloud file.</param>
    /// <param name="Transform">Optional input Matrix that defines the position and orientation of the point cloud in the model space.  The matrix must only define translation, rotation, and uniform scale.  If not provided an identity matrix is used which will result in the point cloud being aligned with model space and full scale.</param>
    /// <param name="Scale">Optional input Double that defines the scale of the point cloud. If not specified the default value of 1 will be used.</param>
    /// <param name="Options">Optional input NameValueMap that specifies additional options for add.</param>
    /// <returns></returns>
    [PreserveSig]
    PointCloud Add([In] [MarshalAs(UnmanagedType.BStr)] string PointCloudFilename, [In] [MarshalAs(UnmanagedType.Struct)] object? Transform = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Scale = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
}
