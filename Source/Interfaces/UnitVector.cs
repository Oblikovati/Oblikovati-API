namespace Oblikovati.API;

/// <summary>
/// The UnitVector object. For more information, see the Transient Geometry overview.
/// </summary>
public interface UnitVector
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
    /// Specifies the Z coordinate of the vector. If not supplied, the Z value will default to 1.
    /// </summary>
    double Z { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coords">Coords</param>
    [PreserveSig]
    void GetUnitVectorData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Coords);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coords">Coords</param>
    [PreserveSig]
    void PutUnitVectorData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Coords);
    /// <summary>
    /// Transform this vector by the specified matrix.
    /// </summary>
    /// <param name="Matrix">Input Matrix object that specifies the matrix to transform the vector by.</param>
    [PreserveSig]
    void TransformBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix Matrix);
    /// <summary>
    /// Determines the angle between this vector and the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::UnitVector, UnitVector> used for comparison.</param>
    /// <returns></returns>
    [PreserveSig]
    double AngleTo([In] [MarshalAs(UnmanagedType.Interface)] UnitVector Argument);
    /// <summary>
    /// Determine if this vector is parallel to the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::UnitVector, UnitVector> used for comparison.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance to be used when determining whether the UnitVectors are parallel.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsParallelTo([In] [MarshalAs(UnmanagedType.Interface)] UnitVector Argument, [In] double? Tolerance = default);
    /// <summary>
    /// Determine if this vector is perpendicular to the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::UnitVector, UnitVector> used for comparison.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance to be used when determining whether the vectors are perpendicular.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsPerpendicularTo([In] [MarshalAs(UnmanagedType.Interface)] UnitVector Argument, [In] double? Tolerance = default);
    /// <summary>
    /// Compare this unit vector for equality to the specified unit vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::UnitVector, UnitVector> used for comparison.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance to be used when determining whether the UnitVectors are equal.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsEqualTo([In] [MarshalAs(UnmanagedType.Interface)] UnitVector Argument, [In] double? Tolerance = default);
    /// <summary>
    /// Determine the dot product of this vector to the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::UnitVector, UnitVector> used for comparison.</param>
    /// <returns></returns>
    [PreserveSig]
    double DotProduct([In] [MarshalAs(UnmanagedType.Interface)] UnitVector Argument);
    /// <summary>
    /// Determine the cross product between this vector and the specified vector.
    /// </summary>
    /// <param name="Argument">Input <link Inventor::UnitVector, UnitVector> used for comparison.</param>
    /// <returns></returns>
    [PreserveSig]
    UnitVector CrossProduct([In] [MarshalAs(UnmanagedType.Interface)] UnitVector Argument);
    /// <summary>
    /// Get the vector equivalent of this unit vector.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Vector AsVector();
    /// <summary>
    /// Creates a copy of this UnitVector object.&nbsp;The result is entirely independent and can be edited without affecting the original UnitVector object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    UnitVector Copy();
}
