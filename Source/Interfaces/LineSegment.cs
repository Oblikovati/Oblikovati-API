namespace Oblikovati.API;

/// <summary>
/// The LineSegment object represents a line segment. The object created is a transient mathematical object and is not displayed graphically.
/// </summary>
public interface LineSegment
{
    /// <summary>
    /// Specifies the start point of the line segment.
    /// </summary>
    Point StartPoint { get; set; }
    /// <summary>
    /// Specifies the end point of the line segment.
    /// </summary>
    Point EndPoint { get; set; }
    /// <summary>
    /// Property that returns the midpoint of the line segment.
    /// </summary>
    Point MidPoint { get; }
    /// <summary>
    /// Property that returns the direction of the line segment.
    /// </summary>
    UnitVector Direction { get; }
    /// <summary>
    /// Property that returns the CurveEvaluator for this line segment.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StartPoint">StartPoint</param>
    /// <param name="EndPoint">EndPoint</param>
    [PreserveSig]
    void GetLineSegmentData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] StartPoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] EndPoint);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StartPoint">StartPoint</param>
    /// <param name="EndPoint">EndPoint</param>
    [PreserveSig]
    void PutLineSegmentData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] StartPoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] EndPoint);
    /// <summary>
    /// Method that returns the distance to the specified point.
    /// </summary>
    /// <param name="Point">Point object that specifies the point to which the distance is to be returned.</param>
    /// <returns></returns>
    [PreserveSig]
    double DistanceTo([In] [MarshalAs(UnmanagedType.Interface)] Point Point);
    /// <summary>
    /// Method that returns Point objects that represent the points at the intersection of the Line/LineSegment and the input curve. Returns Nothing if the curves overlap or are parallel.
    /// </summary>
    /// <param name="Curve">Input object. This can be a Line, LineSegment, Arc3d, EllipticalArc, Circle, EllipseFull, or a BSplineCurve.</param>
    /// <param name="Tolerance">Optional input Double that specifies the linear tolerance to use for intersection computation.  If not specified, the default internal tolerance is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator IntersectWithCurve([In] [MarshalAs(UnmanagedType.IDispatch)] object Curve, [In] double? Tolerance = default);
    /// <summary>
    /// Method that returns Point objects that represent the points at the intersection of the Line/LineSegment and the input surface. Returns Nothing if the Line/LineSegment lies on the surface or it is parallel to the surface.
    /// </summary>
    /// <param name="Surface">Input object. This can be a Plane, Cone, Cylinder, EllipticalCone, EllipticalCylinder, Sphere, Torus or a BSplineSurface.</param>
    /// <param name="Tolerance">Optional input Double that specifies the linear tolerance to use for intersection computation.  If not specified, the default internal tolerance is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator IntersectWithSurface([In] [MarshalAs(UnmanagedType.IDispatch)] object Surface, [In] double? Tolerance = default);
    /// <summary>
    /// Creates a copy of this LineSegment object. The result is entirely independent and can be edited without affecting the original LineSegment object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    LineSegment Copy();
}
