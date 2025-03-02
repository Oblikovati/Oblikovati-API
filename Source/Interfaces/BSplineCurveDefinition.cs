namespace Oblikovati.API;

/// <summary>
/// The BSplineCurveDefinition object is a transient object. It is a convenient way to define a spline, perhaps to then create a BSplineCurve object. For more information, see the Transient Geometry overview.
/// </summary>
public interface BSplineCurveDefinition
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
    /// Gets and sets the length for the curve.
    /// </summary>
    double Length { get; set; }
    /// <summary>
    /// Gets and sets whether the curve should have a fixed length.
    /// </summary>
    bool FixedLength { get; set; }
    /// <summary>
    /// Method that adds point and its corresponding weight and tangent information to the definition.
    /// </summary>
    /// <param name="Point">Input object that specifies the point.</param>
    /// <param name="Weight">Optional input double that specifies the weight for the input point. If not specified, a default value of 1 is used.</param>
    /// <param name="Tangent">Optional input UnitVector object that defines the tangent of the BSpline curve at this point.</param>
    [PreserveSig]
    void AddPoint([In] [MarshalAs(UnmanagedType.Interface)] Point Point, [In] double? Weight = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Tangent = default);
}
