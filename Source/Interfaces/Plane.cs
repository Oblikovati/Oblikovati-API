namespace Oblikovati.API;

/// <summary>
/// The Plane object. A plane object is infinite. The object created is a transient mathematical object and is not displayed graphically. For more information, see the Transient Geometry article in the overviews section.
/// </summary>
public interface Plane
{
    /// <summary>
    /// Gets the root point for this plane.
    /// </summary>
    Point RootPoint { get; set; }
    /// <summary>
    /// Property that indicates the vector for a specific normal in the set.
    /// </summary>
    UnitVector Normal { get; set; }
    /// <summary>
    /// Gets the surface evaluator for this plane.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Property that gets whether this Plane is coplanar with the specified Plane.
    /// </summary>
    bool IsCoplanarTo { get; }
    /// <summary>
    /// Property that gets whether this Plane is parallel to the specified Line or Plane.
    /// </summary>
    bool IsParallelTo { get; }
    /// <summary>
    /// Determine if this Plane is perpendicular to the specified Line or Plane.
    /// </summary>
    bool IsPerpendicularTo { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RootPoint">RootPoint</param>
    /// <param name="Normal">Normal</param>
    [PreserveSig]
    void GetPlaneData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] RootPoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Normal);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RootPoint">RootPoint</param>
    /// <param name="Normal">Normal</param>
    [PreserveSig]
    void PutPlaneData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] RootPoint, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Normal);
    /// <summary>
    /// Compute the intersection point of this Plane and the specified Line. If the Plane and the Line are parallel, this method will fail.
    /// </summary>
    /// <param name="Line">Input object that represents a line. This object can be a Line or LineSegment object.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance.</param>
    /// <returns></returns>
    [PreserveSig]
    Point IntersectWithLine([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] double? Tolerance = default);
    /// <summary>
    /// Compute the intersection line of this Plane and the specified Plane. If the two Planes are parallel, this method will fail.
    /// </summary>
    /// <param name="Plane">Input Plane object that represents a Plane.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance.</param>
    /// <returns></returns>
    [PreserveSig]
    Line IntersectWithPlane([In] [MarshalAs(UnmanagedType.Interface)] Plane Plane, [In] double? Tolerance = default);
    /// <summary>
    /// Determine the distance between this plane and the specified point.
    /// </summary>
    /// <param name="Point">Input object that specifies the point.</param>
    /// <returns></returns>
    [PreserveSig]
    double DistanceTo([In] [MarshalAs(UnmanagedType.Interface)] Point Point);
    /// <summary>
    /// Gets the intersection points of the Plane and the input curve. Note that 3D transient geometry should be supplied. Obtain 3D transient geometry from any sktech entities or 2D geometry before calling this method (for example, by calling the Geometry method of the entity).
    /// </summary>
    /// <param name="Curve">Input object that represents a Curve.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator IntersectWithCurve([In] [MarshalAs(UnmanagedType.IDispatch)] object Curve, [In] double? Tolerance = default);
    /// <summary>
    /// Gets the intersection curves and points between the plane and the input surface.
    /// </summary>
    /// <param name="Surface">Input object that specifies the surface to intersect with the plane. The input can be any of the transient surface objects (Plane, Cone, Cylinder, EllipticalCone, EllipticalCylinder, Sphere, Torus or a BSplineSurface.)</param>
    /// <param name="Tolerance">Optional input Double that specifies the linear tolerance to use for intersection computation.  If not specified, the default internal tolerance is used.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator IntersectWithSurface([In] [MarshalAs(UnmanagedType.IDispatch)] object Surface, [In] double? Tolerance = default);
    /// <summary>
    /// Creates a copy of this Plane object.&nbsp;The result is entirely independent and can be edited without affecting the original Plane object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Plane Copy();
}
