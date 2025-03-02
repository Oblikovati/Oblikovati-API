namespace Oblikovati.API;

/// <summary>
/// The Polyline3d object is a mathematical utility object that represents a set of connected line segments. It is a transient object that is never shown graphically or saved in the Inventor document.
/// </summary>
public interface Polyline3d
{
    /// <summary>
    /// Property that returns an evaluator object for the curve. The evaluator supports general curve evaluation functions.
    /// </summary>
    CurveEvaluator Evaluator { get; }
    /// <summary>
    /// Gets or sets the x, y, z position of a specified point.
    /// </summary>
    Point PointAtIndex { get; set; }
    /// <summary>
    /// Property that returns the number of points defining the polyline.
    /// </summary>
    int PointCount { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Points">Points</param>
    [PreserveSig]
    void GetPoints([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Points);
    /// <summary>
    /// Method that sets all of the coordinates of the polyline.
    /// </summary>
    /// <param name="Points">Input Variant that defines the coordinates of the polyline. Valid input for this argument is an ObjectCollection of Point objects or an array of Double values that contains the X, Y, Z values of each coordinate.</param>
    [PreserveSig]
    void PutPoints([In] [MarshalAs(UnmanagedType.Struct)] object Points);
    /// <summary>
    /// Creates a copy of this Polyline3d object.&nbsp;The result is entirely independent and can be edited without affecting the original Polyline3d object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Polyline3d Copy();
}
