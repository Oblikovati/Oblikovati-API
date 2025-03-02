namespace Oblikovati.API;

/// <summary>
/// A 3x3 Matrix2d object. For more information, see the Transient Geometry article on the overviews section.
/// </summary>
public interface Matrix2d
{
    /// <summary>
    /// Property that returns the cell defined by row/col.
    /// </summary>
    double Cell { get; set; }
    /// <summary>
    /// Get the determinant of this matrix2d.
    /// </summary>
    double Determinant { get; }
    /// <summary>
    /// Get the translation portion of the matrix2d.
    /// </summary>
    Vector2d Translation { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cells">Cells</param>
    [PreserveSig]
    void GetMatrixData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Cells);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Cells">Cells</param>
    [PreserveSig]
    void PutMatrixData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Cells);
    /// <summary>
    /// Method to Invert this matrix2d.
    /// </summary>
    [PreserveSig]
    void Invert();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Origin">Origin</param>
    /// <param name="XAxis">XAxis</param>
    /// <param name="YAxis">YAxis</param>
    [PreserveSig]
    void GetCoordinateSystem([Out] [MarshalAs(UnmanagedType.Interface)] out Point2d Origin, [Out] [MarshalAs(UnmanagedType.Interface)] out Vector2d XAxis, [Out] [MarshalAs(UnmanagedType.Interface)] out Vector2d YAxis);
    /// <summary>
    /// Sets this matrix2d to be the matrix2d that maps from the standard coordinate system to the specified coordinate system.
    /// </summary>
    /// <param name="Origin">Origin point.</param>
    /// <param name="XAxis">Vector for X axis of coordinate system.</param>
    /// <param name="YAxis">Vector for Y axis of coordinate system.</param>
    [PreserveSig]
    void SetCoordinateSystem([In] [MarshalAs(UnmanagedType.Interface)] Point2d Origin, [In] [MarshalAs(UnmanagedType.Interface)] Vector2d XAxis, [In] [MarshalAs(UnmanagedType.Interface)] Vector2d YAxis);
    /// <summary>
    /// Sets this matrix2d to be the matrix2d that maps from the 'from' coordinate system to the 'to' coordinate system.
    /// </summary>
    /// <param name="FromOrigin">Origin point of 'from' coordinate system.</param>
    /// <param name="FromXAxis">Vector of X axis of 'from' coordinate system.</param>
    /// <param name="FromYAxis">Vector of Y axis of 'from' coordinate system.</param>
    /// <param name="ToOrigin">Origin point of "to" coordinate system.</param>
    /// <param name="ToXAxis">Vector of X axis of 'to' coordinate system.</param>
    /// <param name="ToYAxis">Vector of Y axis of 'to' coordinate system.</param>
    [PreserveSig]
    void SetToAlignCoordinateSystems([In] [MarshalAs(UnmanagedType.Interface)] Point2d FromOrigin, [In] [MarshalAs(UnmanagedType.Interface)] Vector2d FromXAxis, [In] [MarshalAs(UnmanagedType.Interface)] Vector2d FromYAxis, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ToOrigin, [In] [MarshalAs(UnmanagedType.Interface)] Vector2d ToXAxis, [In] [MarshalAs(UnmanagedType.Interface)] Vector2d ToYAxis);
    /// <summary>
    /// Sets this matrix2d to the identity matrix2d.
    /// </summary>
    [PreserveSig]
    void SetToIdentity();
    /// <summary>
    /// Sets this matrix2d to the matrix2d of rotation by the specified angle, through the specified origin.
    /// </summary>
    /// <param name="Angle">Angle of rotation for new matrix2d.</param>
    /// <param name="Center">Origin (center) of rotation.</param>
    [PreserveSig]
    void SetToRotation([In] double Angle, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Center);
    /// <summary>
    /// Sets to the matrix2d of rotation that would align the 'from' vector2d with the 'to' vector2d.
    /// </summary>
    /// <param name="From">Input Vector object to align from.</param>
    /// <param name="To">Input Vector object to align to.</param>
    [PreserveSig]
    void SetToRotateTo([In] [MarshalAs(UnmanagedType.Interface)] Vector2d From, [In] [MarshalAs(UnmanagedType.Interface)] Vector2d To);
    /// <summary>
    /// Sets the translation portion of the matrix2d.
    /// </summary>
    /// <param name="Translation">Vector of translation</param>
    /// <param name="ResetRotation">Optional. If True, the rotation portion of the matrix2d is reset to identity.</param>
    [PreserveSig]
    void SetTranslation([In] [MarshalAs(UnmanagedType.Interface)] Vector2d Translation, [In] bool? ResetRotation = false);
    /// <summary>
    /// Compares this matrix2d for equality with the specified matrix2d
    /// </summary>
    /// <param name="Matrix2d">Matrix2s to compare to.</param>
    /// <param name="Tolerance">Tolerance value for comparison.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsEqualTo([In] [MarshalAs(UnmanagedType.Interface)] Matrix2d Matrix2d, [In] double? Tolerance = default);
    /// <summary>
    /// Set this matrix2d to the result of this transformation followed by the specified transformation (a pre multiplication of this matrix2d by the specified matrix2d).
    /// </summary>
    /// <param name="Matrix2d">Matrix to use for pre-multiplication.</param>
    [PreserveSig]
    void TransformBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix2d Matrix2d);
    /// <summary>
    /// Pre multiply this matrix2d by the specified matrix2d, setting this matrix2d to the result.
    /// </summary>
    /// <param name="Matrix2d">Matrix2d to multiply by.</param>
    [PreserveSig]
    void PreMultiplyBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix2d Matrix2d);
    /// <summary>
    /// Post multiply this matrix2d by the specified matrix2d, setting this matrix2d to the result.
    /// </summary>
    /// <param name="Matrix2d">Matrix2d to multiply by.</param>
    [PreserveSig]
    void PostMultiplyBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix2d Matrix2d);
    /// <summary>
    /// Creates a copy of this Matrix2d object.&nbsp;The result is entirely independent and can be edited without affecting the original Matrix2d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Matrix2d Copy();
}
