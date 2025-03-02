namespace Oblikovati.API;

/// <summary>
/// The Point2d object. The object created is a transient mathematical object and is not displayed graphically. Also, for more information see the Transient Geometry article in the overview section.
/// </summary>
public interface Point2d
{
    /// <summary>
    /// Specifies the X coordinate of the point. If not supplied, the X value will default to 0.
    /// </summary>
    double X { get; set; }
    /// <summary>
    /// Specifies the Y coordinate of the point. If not supplied, the Y value will default to 0.
    /// </summary>
    double Y { get; set; }
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
    /// Method that returns the distance between this point and the specified point.
    /// </summary>
    /// <param name="Point">Point2d object that specifies the point to which the distance is to be returned.</param>
    /// <returns></returns>
    [PreserveSig]
    double DistanceTo([In] [MarshalAs(UnmanagedType.Interface)] Point2d Point);
    /// <summary>
    /// Transform this point by the specified matrix.
    /// </summary>
    /// <param name="Matrix">Input Matrix2d object that specifies the matrix to transform by.</param>
    [PreserveSig]
    void TransformBy([In] [MarshalAs(UnmanagedType.Interface)] Matrix2d Matrix);
    /// <summary>
    /// Translate this point by the specified vector.
    /// </summary>
    /// <param name="Vector">Input Vector2d object that specifies the vector to translate by.</param>
    [PreserveSig]
    void TranslateBy([In] [MarshalAs(UnmanagedType.Interface)] Vector2d Vector);
    /// <summary>
    /// Gets the vector of translation between this point and the specified point.
    /// </summary>
    /// <param name="Point">Input Point2d object that specifies the point.</param>
    /// <returns></returns>
    [PreserveSig]
    Vector2d VectorTo([In] [MarshalAs(UnmanagedType.Interface)] Point2d Point);
    /// <summary>
    /// Compares this point for equality with the specified point.
    /// </summary>
    /// <param name="Point">Input Point2d object that specifies the coordinate to compare.</param>
    /// <param name="Tolerance">Optional input Double that specifies the tolerance to be used when determining whether the points are equal.  If not specified the internal tolerance used by Inventor is used.</param>
    /// <returns></returns>
    [PreserveSig]
    bool IsEqualTo([In] [MarshalAs(UnmanagedType.Interface)] Point2d Point, [In] double? Tolerance = default);
    /// <summary>
    /// Creates a copy of this Point2d object.&nbsp;The result is entirely independent and can be edited without affecting the original Point2d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Point2d Copy();
}
