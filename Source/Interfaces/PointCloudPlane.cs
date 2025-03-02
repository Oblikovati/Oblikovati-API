namespace Oblikovati.API;

/// <summary>
/// The PointCloudPlane object represents a plane that’s inferred by points within a point cloud.
/// </summary>
public interface PointCloudPlane
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    PointCloud Parent { get; }
    /// <summary>
    /// Read-only property that returns a Plane object which provides the location and orientation of the inferred plane.
    /// </summary>
    Plane Geometry { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Plane">Plane</param>
    /// <param name="LengthDirection">LengthDirection</param>
    /// <param name="Length">Length</param>
    /// <param name="Height">Height</param>
    [PreserveSig]
    void GetPlaneRectangle([Out] [MarshalAs(UnmanagedType.Interface)] out Plane Plane, [Out] [MarshalAs(UnmanagedType.Interface)] out UnitVector LengthDirection, [Out] out double Length, [Out] out double Height);
}
