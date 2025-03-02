namespace Oblikovati.API;

/// <summary>
/// The LineSegment2d object. The object is a transient mathematical object and is not displayed graphically.
/// </summary>
public interface LineSegment2d
{
    /// <summary>
    /// Specifies the start point of the line segment.
    /// </summary>
    Point2d StartPoint { get; set; }
    /// <summary>
    /// Specifies the end point of the line segment.
    /// </summary>
    Point2d EndPoint { get; set; }
    /// <summary>
    /// Gets the mid point of the line segment.
    /// </summary>
    Point2d MidPoint { get; }
    /// <summary>
    /// Gets the direction of the line segment.
    /// </summary>
    UnitVector2d Direction { get; }
    /// <summary>
    /// Gets the Curve2dEvaluator for this line segment.
    /// </summary>
    Curve2dEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StartPoint">StartPoint</param>
    /// <param name="EndPoint">EndPoint</param>
    [PreserveSig]
    void GetLineSegmentData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] StartPoint, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] EndPoint);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="StartPoint">StartPoint</param>
    /// <param name="EndPoint">EndPoint</param>
    [PreserveSig]
    void PutLineSegmentData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] StartPoint, [In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] EndPoint);
    /// <summary>
    /// Method that returns the distance to the specified point.
    /// </summary>
    /// <param name="Point">Point2d object that specifies the point to which the distance is to be returned.</param>
    /// <returns></returns>
    [PreserveSig]
    double DistanceTo([In] [MarshalAs(UnmanagedType.Interface)] Point2d Point);
    /// <summary>
    /// Method that returns Point2d objects that represent the points at the intersection of the Line2d/LineSegment2d and the input curve. Returns Nothing if the curves overlap or are parallel.
    /// </summary>
    /// <param name="Curve">Input object. This can be a Line2d, LineSegment2d, Arc2d, EllipticalArc2d, Circle2d, EllipseFull2d, or a BSplineCurve2d.</param>
    /// <param name="Tolerance">Optional input Double that specifies the linear tolerance to use for intersection computation.  If not specified, the default internal tolerance is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator IntersectWithCurve([In] [MarshalAs(UnmanagedType.IDispatch)] object Curve, [In] double? Tolerance = default);
    /// <summary>
    /// Creates a copy of this LineSegment2d object.
    /// Creates a copy of this LineSegment2d object. The result is entirely independent and can be edited without affecting the original LineSegment2d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    LineSegment2d Copy();
}
