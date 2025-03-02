namespace Oblikovati.API;

/// <summary>
/// The Vector object. For more information, see the Transient Geometry overview.
/// </summary>
public interface Vector
{
    /// <summary>
    /// Specifies the X coordinate of the vector. If not supplied, the X value will default to 0.
    /// </summary>
    double X { get; set; }
    /// <summary>
    /// Specifies the Y coordinate of the vector. If not supplied, the Y value will default to 0.
    /// </summary>
    double Y { get; set; }
    /// <summary>
    /// Specifies the Z coordinate of the vector. If not supplied, the Z value will default to 0.
    /// </summary>
    double Z { get; set; }
    /// <summary>
    /// Get the length of this vector.
    /// </summary>
    double Length { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coords">Coords</param>
    [PreserveSig]
    void GetVectorData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Coords);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coords">Coords</param>
    [PreserveSig]
    void PutVectorData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Coords);
    /// <summary>
    /// Transform this vector by the specified matrix.
    /// </summary>
    /// <param name="Matrix">Input Matrix object that specifies the position and orientation of the occurrence.</param>
    [PreserveSig]
    void TransformBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix Matrix);
    /// <summary>
    /// Scale this vector by the specified scale factor.
    /// </summary>
    /// <param name="Scale">Input Double that specifies the scale.</param>
    [PreserveSig]
    void ScaleBy([In] double Scale);
    /// <summary>
    /// Add the specified vector to this vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::Vector, Vector> to add.</param>
    [PreserveSig]
    void AddVector([In] [MarshalAs(UnmanagedType.Interface)] Vector Argument);
    /// <summary>
    /// Subtract the specified vector from this vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::Vector, Vector> to subtract.</param>
    [PreserveSig]
    void SubtractVector([In] [MarshalAs(UnmanagedType.Interface)] Vector Argument);
    /// <summary>
    /// Determines the angle between this vector and the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::Vector, Vector> used for comparison.</param>
    /// <returns></returns>
    [PreserveSig]
    double AngleTo([In] [MarshalAs(UnmanagedType.Interface)] Vector Argument);
    /// <summary>
    /// Normalize this vector to result in a length equal to 1.0.
    /// </summary>
    [PreserveSig]
    void Normalize();
    /// <summary>
    /// Determine if this vector is parallel to the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::Vector, Vector> used for comparison.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance to be used when determining whether the vectors are parallel.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsParallelTo([In] [MarshalAs(UnmanagedType.Interface)] Vector Argument, [In] double? Tolerance = default);
    /// <summary>
    /// Determine if this vector is perpendicular to the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::Vector, Vector> used for comparison.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance to be used when determining whether the vectors are perpendicular.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsPerpendicularTo([In] [MarshalAs(UnmanagedType.Interface)] Vector Argument, [In] double? Tolerance = default);
    /// <summary>
    /// Compare this vector for equality to the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::Vector, Vector> used for comparison.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance to be used when determining whether the vectors are equal.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsEqualTo([In] [MarshalAs(UnmanagedType.Interface)] Vector Argument, [In] double? Tolerance = default);
    /// <summary>
    /// Determine the dot product of this vector to the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::Vector, Vector> used for comparison.</param>
    /// <returns></returns>
    [PreserveSig]
    double DotProduct([In] [MarshalAs(UnmanagedType.Interface)] Vector Argument);
    /// <summary>
    /// Determine the cross product between this vector and the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::Vector, Vector> used for comparison.</param>
    /// <returns></returns>
    [PreserveSig]
    Vector CrossProduct([In] [MarshalAs(UnmanagedType.Interface)] Vector Argument);
    /// <summary>
    /// Get the unit vector equivalent of this vector normalized.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    UnitVector AsUnitVector();
    /// <summary>
    /// Creates a copy of this Vector object.&nbsp;The result is entirely independent and can be edited without affecting the original Vector object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Vector Copy();
}
