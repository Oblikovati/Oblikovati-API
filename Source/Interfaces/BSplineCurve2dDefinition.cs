namespace Oblikovati.API;

/// <summary>
/// The BSplineCurve2dDefinition object is a transient object. It is a convenient way to define a spline, perhaps to then create a BSplineCurve2D object. For more information, see the Transient Geometry overview.
/// </summary>
public interface BSplineCurve2dDefinition
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the FitMethod setting.
    /// </summary>
    SplineFitMethodEnum FitMethod { get; set; }
    /// <summary>
    /// Method that adds point and its corresponding weight and tangent information to the definition.
    /// </summary>
    /// <param name="Point">Input object that specifies the point.</param>
    /// <param name="Weight">Optional input double that specifies the weight for the input point. If not specified, a default value of 1 is used.</param>
    /// <param name="Tangent">Optional input UnitVector2d object that defines the tangent of the BSpline curve at this point.</param>
    [PreserveSig]
    void AddPoint([In] [MarshalAs(UnmanagedType.Interface)] Point2d Point, [In] double? Weight = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Tangent = default);
}
