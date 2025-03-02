namespace Oblikovati.API;

/// <summary>
/// PointCloudPointProxy Object.
/// </summary>
public interface PointCloudPointProxy
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
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    PointCloudPoint NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
}
