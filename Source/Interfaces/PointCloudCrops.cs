namespace Oblikovati.API;

/// <summary>
/// PointCloudCrops Collection Object.
/// </summary>
public interface PointCloudCrops : IEnumerable
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    PointCloudCrop this[object Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that adds a crop to the point cloud and the result PointCloudCrop is returned.
    /// </summary>
    /// <param name="BoundingBox">Input OrientedBox object that defines the bounding volume. The TransientGeometry.CreateOrientedBox can be used to create an OrientedBox object.</param>
    /// <param name="KeepInside">Optional input Boolean that specifies whether keep the point cloud points in the BoundingBox.</param>
    /// <returns></returns>
    [PreserveSig]
    PointCloudCrop Add([In] [MarshalAs(UnmanagedType.Interface)] OrientedBox BoundingBox, [In] bool? KeepInside = true);
    /// <summary>
    /// Method that clears all the point cloud crops in this collection.
    /// </summary>
    [PreserveSig]
    void Clear();
}
