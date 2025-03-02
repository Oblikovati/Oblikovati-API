namespace Oblikovati.API;

/// <summary>
/// The GeometryIntent object represents a geometry intent for use in various annotation and view creations.
/// </summary>
public interface GeometryIntent
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
    /// Property that returns the parent of this object.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Property that returns the geometry associated with the intent.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Property that returns the intent point on the input geometry. This can be a value from PointIntentEnum, a geometry if the intent is the intersection of two geometries, a Point2d object that specifies a sheet point on the geometry or a double value indicating the parameter on the input curve geometry.
    /// </summary>
    object Intent { get; }
    /// <summary>
    /// Property that returns intent type indicating the type of value that the Intent property will return. Possible return values are kPointEnumIntent (a PointIntentEnum will be returned), kPoint2dIntent (a Point2d object will be returned), kParameterIntent (a double value will be returned), kGeometryIntent (a DrawingCurve or a SketchEntity will be returned) or kNoPointIntent (the GeometryIntent is not a point and the Intent property will not return a meaningful value).
    /// </summary>
    IntentTypeEnum IntentType { get; }
    /// <summary>
    /// Property that returns the point on sheet represented by a point intent. This property returns Nothing if this is not a point intent.
    /// </summary>
    Point2d PointOnSheet { get; }
    /// <summary>
    /// Read-only property that returns a 3d point define by the geometry intent.&nbsp;This property returns nothing there is not a 3d point intent.
    /// </summary>
    Point Point { get; }
}
