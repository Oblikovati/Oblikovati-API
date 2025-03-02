namespace Oblikovati.API;

/// <summary>
/// The Vector2d object. For more information, see the Transient Geometry overview.
/// </summary>
public interface Vector2d
{
    /// <summary>
    /// Gets the X-component for this Vector2d.
    /// </summary>
    double X { get; set; }
    /// <summary>
    /// Gets the Y-component for this Vector2d.
    /// </summary>
    double Y { get; set; }
    /// <summary>
    /// Get the length of this vector2d.
    /// </summary>
    double Length { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coords">Coords</param>
    [PreserveSig]
    void GetVectorData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Coords);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coords">Coords</param>
    [PreserveSig]
    void PutVectorData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Coords);
    /// <summary>
    /// Transform this vector2d by the specified matrix.
    /// </summary>
    /// <param name="Value">Matrix2d for transform.</param>
    [PreserveSig]
    void TransformBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix2d Value);
    /// <summary>
    /// Scale this vector2d by the specified scale factor.
    /// </summary>
    /// <param name="Value">Scale factor to use.</param>
    [PreserveSig]
    void ScaleBy([In] double Value);
    /// <summary>
    /// Add the specified vector2d to this vector2d.
    /// </summary>
    /// <param name="Value">Vector2d to add.</param>
    [PreserveSig]
    void AddVector([In] [MarshalAs(UnmanagedType.Interface)] Vector2d Value);
    /// <summary>
    /// Subtract the specified vector2d from this vector2d.
    /// </summary>
    /// <param name="Value">Vector2d to subtract.</param>
    [PreserveSig]
    void SubtractVector([In] [MarshalAs(UnmanagedType.Interface)] Vector2d Value);
    /// <summary>
    /// Determines the angle between this vector2d and the specified vector2d.
    /// </summary>
    /// <param name="Vector">Vector to measure to.</param>
    /// <returns></returns>
    [PreserveSig]
    double AngleTo([In] [MarshalAs(UnmanagedType.Interface)] Vector2d Vector);
    /// <summary>
    /// Normalize this vector2d to result in a length equal to 1.0.
    /// </summary>
    [PreserveSig]
    void Normalize();
    /// <summary>
    /// Determine if this vector2d is parallel to the specified vector2d.
    /// </summary>
    /// <param name="Vector">Vector to use for parallel test.</param>
    /// <param name="Tolerance">Tolerance value for test.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsParallelTo([In] [MarshalAs(UnmanagedType.Interface)] Vector2d Vector, [In] double? Tolerance = default);
    /// <summary>
    /// Determine if this vector2d is perpendicular to the specified vector2d.
    /// </summary>
    /// <param name="Vector">Vector to use for perpendicular test.</param>
    /// <param name="Tolerance">Tolerance value for test.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsPerpendicularTo([In] [MarshalAs(UnmanagedType.Interface)] Vector2d Vector, [In] double? Tolerance = default);
    /// <summary>
    /// Compare this vector2d for equality to the specified vector2d.
    /// </summary>
    /// <param name="Vector">Vector to compare to.</param>
    /// <param name="Tolerance">Tolerance for comparison.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsEqualTo([In] [MarshalAs(UnmanagedType.Interface)] Vector2d Vector, [In] double? Tolerance = default);
    /// <summary>
    /// Determine the dot product of this vector2d to the specified vector2d.
    /// </summary>
    /// <param name="Vector">Vector with which to calculate the dot product.</param>
    /// <returns></returns>
    [PreserveSig]
    double DotProduct([In] [MarshalAs(UnmanagedType.Interface)] Vector2d Vector);
    /// <summary>
    /// Get the unit vector2d equivalent of this vector2d normalized.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    UnitVector2d AsUnitVector();
    /// <summary>
    /// Creates a copy of this Vector2d object.&nbsp;The result is entirely independent and can be edited without affecting the original Vector2d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Vector2d Copy();
}
