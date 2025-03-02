namespace Oblikovati.API;

/// <summary>
/// The Point object. The object is a transient mathematical object and is not displayed graphically. For more information see the Transient Geometry article in the overviews section.
/// </summary>
public interface Point
{
    /// <summary>
    /// Read-write proerty that gets and sets the X coordinate value.
    /// </summary>
    double X { get; set; }
    /// <summary>
    /// Read-write proerty that gets and sets the Y coordinate value.
    /// </summary>
    double Y { get; set; }
    /// <summary>
    /// Read-write proerty that gets and sets the Z coordinate value.
    /// </summary>
    double Z { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coords">Coords</param>
    [PreserveSig]
    void GetPointData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Coords);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coords">Coords</param>
    [PreserveSig]
    void PutPointData([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref double[] Coords);
    /// <summary>
    /// Transform this point by the specified matrix.
    /// </summary>
    /// <param name="Matrix">Input Matrix object that specifies the matrix to transform by.</param>
    [PreserveSig]
    void TransformBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix Matrix);
    /// <summary>
    /// Translate this point by the specified vector.
    /// </summary>
    /// <param name="Vector">Input Vector object that specifies the vector to translate by.</param>
    [PreserveSig]
    void TranslateBy([In] [MarshalAs(UnmanagedType.Interface)] Vector Vector);
    /// <summary>
    /// Determine the distance between this point and the specified point.
    /// </summary>
    /// <param name="Point">Input object that specifies the point.</param>
    /// <returns></returns>
    [PreserveSig]
    double DistanceTo([In] [MarshalAs(UnmanagedType.Interface)] Point Point);
    /// <summary>
    /// Gets the vector of translation between this point and the specified point.
    /// </summary>
    /// <param name="Point">Input object that specifies the point.</param>
    /// <returns></returns>
    [PreserveSig]
    Vector VectorTo([In] [MarshalAs(UnmanagedType.Interface)] Point Point);
    /// <summary>
    /// Compares this point for equality with the specified point.
    /// </summary>
    /// <param name="Point">Input Point object that specifies the coordinate to compare.</param>
    /// <param name="Tolerance">Input Double that specifies the tolerance to be used when determining whether the points are equal.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsEqualTo([In] [MarshalAs(UnmanagedType.Interface)] Point Point, [In] double? Tolerance = default);
    /// <summary>
    /// Creates a copy of this Point object.&nbsp;The result is entirely independent and can be edited without affecting the original Point object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Point Copy();
}
