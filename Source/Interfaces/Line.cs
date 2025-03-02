namespace Oblikovati.API;

/// <summary>
/// The Line object. The object created is a transient mathematical object and is not displayed graphically. For more information, see the Transient Geometry article in the overview section.
/// </summary>
public interface Line
{
    /// <summary>
    /// Specifies the root point of the line.
    /// </summary>
    Point RootPoint { get; set; }
    /// <summary>
    /// Specifies the direction of the line.
    /// </summary>
    UnitVector Direction { get; set; }
    /// <summary>
    /// Gets the CurveEvaluator for the line.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Property that gets whether this line is colinear to the specified line, within the specified tolerance.
    /// </summary>
    bool IsColinearTo { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RootPoint">RootPoint</param>
    /// <param name="Direction">Direction</param>
    [PreserveSig]
    void GetLineData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] RootPoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Direction);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RootPoint">RootPoint</param>
    /// <param name="Direction">Direction</param>
    [PreserveSig]
    void PutLineData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] RootPoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Direction);
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
    /// Creates a copy of this Line object.&nbsp;The result is entirely independent and can be edited without affecting the original Line object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Line Copy();
}
