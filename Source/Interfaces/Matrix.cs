namespace Oblikovati.API;

/// <summary>
/// A 4x4 Matrix object. For more information, see the Transient Geometry article in the overviews section.
/// </summary>
public interface Matrix
{
    /// <summary>
    /// Property that returns the cell defined by row/col.
    /// </summary>
    double Cell { get; set; }
    /// <summary>
    /// Get the determinant of this matrix.
    /// </summary>
    double Determinant { get; }
    /// <summary>
    /// Get the translation portion of the matrix.
    /// </summary>
    Vector Translation { get; }
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
    /// Invert this matrix.
    /// </summary>
    [PreserveSig]
    void Invert();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Origin">Origin</param>
    /// <param name="XAxis">XAxis</param>
    /// <param name="YAxis">YAxis</param>
    /// <param name="ZAxis">ZAxis</param>
    [PreserveSig]
    void GetCoordinateSystem([Out] [MarshalAs(UnmanagedType.Interface)] out Point Origin, [Out] [MarshalAs(UnmanagedType.Interface)] out Vector XAxis, [Out] [MarshalAs(UnmanagedType.Interface)] out Vector YAxis, [Out] [MarshalAs(UnmanagedType.Interface)] out Vector ZAxis);
    /// <summary>
    /// Sets this matrix to be the matrix that maps from the standard coordinate system to the specified coordinate system.
    /// </summary>
    /// <param name="Origin">Input Point object that defines the origin of the coordinate system.</param>
    /// <param name="XAxis">Input Vector object that defines the X-axis vector of the coordinate system.</param>
    /// <param name="YAxis">Input Vector object that defines the Y-axis vector of the coordinate system.</param>
    /// <param name="ZAxis">Input Vector object that defines the Z-axis vector of the coordinate system.</param>
    [PreserveSig]
    void SetCoordinateSystem([In] [MarshalAs(UnmanagedType.Interface)] Point Origin, [In] [MarshalAs(UnmanagedType.Interface)] Vector XAxis, [In] [MarshalAs(UnmanagedType.Interface)] Vector YAxis, [In] [MarshalAs(UnmanagedType.Interface)] Vector ZAxis);
    /// <summary>
    /// Sets this matrix to be the matrix that maps from the 'from' coordinate system to the 'to' coordinate system.
    /// </summary>
    /// <param name="FromOrigin">Input Point object that defines the origin to map the coordinate system from.</param>
    /// <param name="FromXAxis">Input Vector object that defines the X-axis to map the coordinate system from.</param>
    /// <param name="FromYAxis">Input Vector object that defines the Y-axis to map the coordinate system from.</param>
    /// <param name="FromZAxis">Input Vector object that defines the Z-axis to map the coordinate system from.</param>
    /// <param name="ToOrigin">Input Point object that defines the origin to map the coordinate system to.</param>
    /// <param name="ToXAxis">Input Vector object that defines the X-axis to map the coordinate system to.</param>
    /// <param name="ToYAxis">Input Vector object that defines the Y-axis to map the coordinate system to.</param>
    /// <param name="ToZAxis">Input Vector object that defines the Z-axis to map the coordinate system to.</param>
    [PreserveSig]
    void SetToAlignCoordinateSystems([In] [MarshalAs(UnmanagedType.Interface)] Point FromOrigin, [In] [MarshalAs(UnmanagedType.Interface)] Vector FromXAxis, [In] [MarshalAs(UnmanagedType.Interface)] Vector FromYAxis, [In] [MarshalAs(UnmanagedType.Interface)] Vector FromZAxis, [In] [MarshalAs(UnmanagedType.Interface)] Point ToOrigin, [In] [MarshalAs(UnmanagedType.Interface)] Vector ToXAxis, [In] [MarshalAs(UnmanagedType.Interface)] Vector ToYAxis, [In] [MarshalAs(UnmanagedType.Interface)] Vector ToZAxis);
    /// <summary>
    /// Sets this matrix to the identity matrix.
    /// </summary>
    [PreserveSig]
    void SetToIdentity();
    /// <summary>
    /// Sets this matrix to the matrix of rotation by the specified angle, through the specified origin, around the specified axis.
    /// </summary>
    /// <param name="Angle">Input Double that specifies the angle of rotation.</param>
    /// <param name="Axis">Input Vector object.</param>
    /// <param name="Center">Input Point object that specifies the origin.</param>
    [PreserveSig]
    void SetToRotation([In] double Angle, [In] [MarshalAs(UnmanagedType.Interface)] Vector Axis, [In] [MarshalAs(UnmanagedType.Interface)] Point Center);
    /// <summary>
    /// Sets to the matrix of rotation that would align the 'from' vector with the 'to' vector. The optional Axis argument may be used when the two vectors are parallel and in opposite directions to specify a specific solution, but is otherwise ignored.
    /// </summary>
    /// <param name="From">Input Vector object to align from.</param>
    /// <param name="To">Input Vector object to align to.</param>
    /// <param name="Axis">Input Vector object.</param>
    [PreserveSig]
    void SetToRotateTo([In] [MarshalAs(UnmanagedType.Interface)] Vector From, [In] [MarshalAs(UnmanagedType.Interface)] Vector To, [In] [MarshalAs(UnmanagedType.Interface)] Vector? Axis = default);
    /// <summary>
    /// Sets the translation portion of the matrix. If the optional ResetRotation flag is True, the rotation portion of the matrix is reset to identity.
    /// </summary>
    /// <param name="Translation">Input Vector that specifies the new translation portion of the matrix.</param>
    /// <param name="ResetRotation">Optional input Boolean that indicates whether to reset to rotation portion of the matrix to identity.</param>
    [PreserveSig]
    void SetTranslation([In] [MarshalAs(UnmanagedType.Interface)] Vector Translation, [In] bool? ResetRotation = false);
    /// <summary>
    /// Compares this matrix for equality with the specified matrix.
    /// </summary>
    /// <param name="Matrix">Input Matrix object that specifies matrix to compare.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance to be used when determining whether the matrices are equal.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsEqualTo([In] [MarshalAs(UnmanagedType.Interface)] Matrix Matrix, [In] double? Tolerance = default);
    /// <summary>
    /// Method that sets this matrix to the result of this transformation followed by the specified transformation (a pre-multiplication of this matrix by the specified matrix).
    /// </summary>
    /// <param name="Matrix">Input Matrix object that specifies the matrix to transform by.</param>
    [PreserveSig]
    void TransformBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix Matrix);
    /// <summary>
    /// Method that post-multiplies this matrix by the specified matrix, setting this matrix to the result.
    /// </summary>
    /// <param name="Matrix">Input Matrix object that specifies the matrix to pre-multiply by.</param>
    [PreserveSig]
    void PreMultiplyBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix Matrix);
    /// <summary>
    /// Method that post-multiplies this matrix by the specified matrix, setting this matrix to the result.
    /// </summary>
    /// <param name="Matrix">Input Matrix object that specifies the matrix to post-multiply by.</param>
    [PreserveSig]
    void PostMultiplyBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix Matrix);
    /// <summary>
    /// Creates a copy of this Matrix object.&nbsp;The result is entirely independent and can be edited without affecting the original Matrix object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Matrix Copy();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Matrix">Matrix</param>
    [PreserveSig]
    void MultiplyBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix Matrix);
}
