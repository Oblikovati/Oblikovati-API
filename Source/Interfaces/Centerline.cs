namespace Oblikovati.API;

/// <summary>
/// The Centerline object represents a centerline on a sheet.
/// </summary>
public interface Centerline
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the parent Sheet object.
    /// </summary>
    Sheet Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the centerline is visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that gets the centerline type. This could return kRegularCenterline, kBisectorCenterline, kCenteredPatternCenterline or kWorkFeatureCenterline. If the property returns kWorkFeatureCenterline, the centerline is associated with a model work feature. The work feature can be obtained using the ModelWorkFeature property.
    /// </summary>
    CenterlineTypeEnum CenterlineType { get; }
    /// <summary>
    /// Property that returns the model work feature associated with this centerline. This property returns Nothing if the CenterlineType property is not kWorkFeatureCenterline.
    /// </summary>
    object ModelWorkFeature { get; }
    /// <summary>
    /// Property that returns whether the centerline is sick. Returns False if the centerline is sick.
    /// </summary>
    bool Attached { get; }
    /// <summary>
    /// Read-write property that gets and sets the start point of the centerline.
    /// </summary>
    Point2d StartPoint { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the end point of the centerline.
    /// </summary>
    Point2d EndPoint { get; set; }
    /// <summary>
    /// Property that returns the geometry that defines the shape of the centerline object.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Property that returns the type of the curve used to define the centerline. This property allows you to determine what type of object will be returned by the Geometry.
    /// </summary>
    CurveTypeEnum GeometryType { get; }
    /// <summary>
    /// Gets and sets the layer associated with this object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets and sets the style associated with this centerline.
    /// </summary>
    CentermarkStyle Style { get; set; }
    /// <summary>
    /// Property that returns the collection of objects that define the path of the centerline.
    /// </summary>
    ObjectsEnumerator FitPoints { get; }
    /// <summary>
    /// Property that returns the geometry the center that defines the center of the centerline pattern. This property is only valid for kCenteredPatternCenterline type centerlines and will return Nothing in all other cases.
    /// </summary>
    GeometryIntent PatternCenter { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that deletes the Centerline.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EntityOne">EntityOne</param>
    /// <param name="EntityTwo">EntityTwo</param>
    [PreserveSig]
    void GetBisectorEntities([Out] [MarshalAs(UnmanagedType.Interface)] out GeometryIntent EntityOne, [Out] [MarshalAs(UnmanagedType.Interface)] out GeometryIntent EntityTwo);
}
