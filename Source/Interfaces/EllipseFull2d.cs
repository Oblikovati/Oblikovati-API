namespace Oblikovati.API;

/// <summary>
/// The EllipseFull2d object. The object is a transient mathematical object and is not displayed graphically.
/// </summary>
public interface EllipseFull2d
{
    /// <summary>
    /// Specifies the center of the ellipse.
    /// </summary>
    Point2d Center { get; set; }
    /// <summary>
    /// Specifies the direction of the major axis of the ellipse.
    /// </summary>
    Vector2d MajorAxisVector { get; set; }
    /// <summary>
    /// Specifies the ratio of the minor and major axes of the ellipse.
    /// </summary>
    double MinorMajorRatio { get; set; }
    /// <summary>
    /// Gets the Curve2dEvaluator for this ellipse.
    /// </summary>
    Curve2dEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    [PreserveSig]
    void GetEllipseFullData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Center, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MajorAxis, [Out] out double MinorMajorRatio);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Center">Center</param>
    /// <param name="MajorAxis">MajorAxis</param>
    /// <param name="MinorMajorRatio">MinorMajorRatio</param>
    [PreserveSig]
    void PutEllipseFullData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Center, [Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] MajorAxis, [In] double MinorMajorRatio);
    /// <summary>
    /// Creates a copy of this EllipseFull2d object.&nbsp;The result is entirely independent and can be edited without affecting the original EllipseFull2d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    EllipseFull2d Copy();
}
