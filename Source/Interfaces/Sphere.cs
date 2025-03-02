namespace Oblikovati.API;

/// <summary>
/// The Sphere object. The object created is a transient mathematical object and is not displayed graphically.
/// </summary>
public interface Sphere
{
    /// <summary>
    /// Specifies the center of the sphere.
    /// </summary>
    Point CenterPoint { get; set; }
    /// <summary>
    /// Specifies the radius of the sphere.
    /// </summary>
    double Radius { get; set; }
    /// <summary>
    /// Gets the surface evaluator for this sphere.
    /// </summary>
    SurfaceEvaluator Evaluator { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CenterPoint">CenterPoint</param>
    /// <param name="Radius">Radius</param>
    [PreserveSig]
    void GetSphereData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] CenterPoint, [Out] out double Radius);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CenterPoint">CenterPoint</param>
    /// <param name="Radius">Radius</param>
    [PreserveSig]
    void PutSphereData([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] CenterPoint, [In] double Radius);
    /// <summary>
    /// Creates a copy of this Sphere object.&nbsp;The result is entirely independent and can be edited without affecting the original Sphere object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Sphere Copy();
}
