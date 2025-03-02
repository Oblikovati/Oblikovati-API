namespace Oblikovati.API;

/// <summary>
/// The Line2d object. A Line2d object is infinite. The object created is a transient mathematical object and is not displayed graphically.
/// </summary>
public interface Line2d
{
    /// <summary>
    /// Specifies the root point of the line.
    /// </summary>
    Point2d RootPoint { get; set; }
    /// <summary>
    /// Specifies the direction of the line.
    /// </summary>
    UnitVector2d Direction { get; set; }
    /// <summary>
    /// Gets the Curve2DEvaluator for the line.
    /// </summary>
    Curve2dEvaluator Evaluator { get; }
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
    /// Creates a copy of this Line2d object.&nbsp;The result is entirely independent and can be edited without affecting the original Line2d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Line2d Copy();
}
