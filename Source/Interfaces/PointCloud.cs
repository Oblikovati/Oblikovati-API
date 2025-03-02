namespace Oblikovati.API;

/// <summary>
/// The PointCloud object represents a single point cloud within Inventor.
/// </summary>
public interface PointCloud
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Read-only property that returns the name of the point cloud. This is the name that’s visible in the browser.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Read-write property that gets and sets the scale of the point cloud.
    /// </summary>
    double Scale { get; set; }
    /// <summary>
    /// Read-only property that returns the point cloud source full file name.
    /// </summary>
    string SourceFullFileName { get; }
    /// <summary>
    /// Read-write property that gets and sets the matrix that defines the translation, rotation of the point cloud in model space.
    /// </summary>
    Matrix Transform { get; set; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the visibility of this point cloud.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Read-only property that returns the total number of points in the point cloud taking no account of the crops.
    /// </summary>
    int TotalPointCount { get; }
    /// <summary>
    /// Read-only property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object in point cloud space.
    /// </summary>
    Box RangeBoxInPointCloudSpace { get; }
    /// <summary>
    /// Read-write property that gets and sets the density of the points displayed. The range of this property is from 1 to 10.
    /// </summary>
    int Density { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the maximum point count that can be displayed in current point cloud.
    /// </summary>
    int MaximumPointCount { get; set; }
    /// <summary>
    /// Read-only property that returns the total number of cloud points currently being displayed.&nbsp;This is the result of the density, MaximumPointCount and cropping.
    /// </summary>
    int DisplayedPointCount { get; }
    /// <summary>
    /// Read-only property that returns the point cloud regions collection object.
    /// </summary>
    PointCloudRegions Regions { get; }
    /// <summary>
    /// Read-only property that returns the point cloud scans collection object.
    /// </summary>
    PointCloudScans Scans { get; }
    /// <summary>
    /// Read-only property that returns the PointCloudCrops collection object.
    /// </summary>
    PointCloudCrops Crops { get; }
    /// <summary>
    /// Read-only property that returns the units ratio between the point cloud source units and the Inventor database length unit(centimeters).
    /// </summary>
    double UnitsFactor { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the point cloud.
    /// </summary>
    /// <param name="RetainDependents">Optional input Boolean that specifies whether to retain the dependents or not.</param>
    [PreserveSig]
    void Delete([In] bool? RetainDependents = false);
    /// <summary>
    /// Method that takes a 3d coordinate in point cloud space and returns a Point object containing the coordinate point in model space.
    /// </summary>
    /// <param name="PointCloudCoordinate">Input Point object of a point in the point cloud space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point PointCloudToModelSpace([In] [MarshalAs(UnmanagedType.Interface)] Point PointCloudCoordinate);
    /// <summary>
    /// Method that takes a 3d coordinate in model space and returns a Point object containing the coordinate point in point cloud space.
    /// </summary>
    /// <param name="ModelCoordinate">Input Point object of a point in the model space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point ModelToPointCloudSpace([In] [MarshalAs(UnmanagedType.Interface)] Point ModelCoordinate);
}
