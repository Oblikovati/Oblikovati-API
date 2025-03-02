namespace Oblikovati.API;

/// <summary>
/// The UnitVector2d object. For more information, see the Transient Geometry overview.
/// </summary>
public interface UnitVector2d
{
    /// <summary>
    /// Gets the X-component for this UnitVector2d.
    /// </summary>
    double X { get; set; }
    /// <summary>
    /// Gets the Y-component for this UnitVector2d.
    /// </summary>
    double Y { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coords">Coords</param>
    [PreserveSig]
    void GetUnitVectorData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Coords);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coords">Coords</param>
    [PreserveSig]
    void PutUnitVectorData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Coords);
    /// <summary>
    /// Transform this unit vector2d by the specified matrix.
    /// </summary>
    /// <param name="Value">Matrix2d for transform.</param>
    [PreserveSig]
    void TransformBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix2d Value);
    /// <summary>
    /// Determines the angle between this unit vector2d and the specified unit vector2d.
    /// </summary>
    /// <param name="Vector">2nd vector to measure to.</param>
    /// <returns></returns>
    [PreserveSig]
    double AngleTo([In] [MarshalAs(UnmanagedType.Interface)] UnitVector2d Vector);
    /// <summary>
    /// Determine if this unit vector2d is parallel to the specified unit vector2d.
    /// </summary>
    /// <param name="Vector">Vector with which to test parallel status.</param>
    /// <param name="Tolerance">Tolerance for test.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsParallelTo([In] [MarshalAs(UnmanagedType.Interface)] UnitVector2d Vector, [In] double? Tolerance = default);
    /// <summary>
    /// Determine if this unit vector2d is perpendicular to the specified unit vector2d.
    /// </summary>
    /// <param name="Vector">Vector with which to test perpendicular status.</param>
    /// <param name="Tolerance">Tolerance for test.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsPerpendicularTo([In] [MarshalAs(UnmanagedType.Interface)] UnitVector2d Vector, [In] double? Tolerance = default);
    /// <summary>
    /// Compare this unit vector2d for equality to the specified unit vector2d.
    /// </summary>
    /// <param name="Vector">Vector to compare to.</param>
    /// <param name="Tolerance">Tolerance for comparison.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsEqualTo([In] [MarshalAs(UnmanagedType.Interface)] UnitVector2d Vector, [In] double? Tolerance = default);
    /// <summary>
    /// Determine the dot product of this unit vector2d to the specified unit vector2d.
    /// </summary>
    /// <param name="Vector">2nd vector to use to calculate dot product.</param>
    /// <returns></returns>
    [PreserveSig]
    double DotProduct([In] [MarshalAs(UnmanagedType.Interface)] UnitVector2d Vector);
    /// <summary>
    /// Get the vector2d equivalent of this unit vector2d.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Vector2d AsVector();
    /// <summary>
    /// Creates a copy of this UnitVector2d object.&nbsp;The result is entirely independent and can be edited without affecting the original UnitVector2d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    UnitVector2d Copy();
}
