namespace Oblikovati.API;

/// <summary>
/// DrawingViewHatchRegion Object.
/// </summary>
public interface DrawingViewHatchRegion
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    DrawingView Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the rotation angle of the pattern in radians.
    /// </summary>
    double Angle { get; set; }
    /// <summary>
    /// Read-write property that specifies if use the hatch pattern corresponds to the mapping between materials and hatch patterns defined in the active drawing standard style.
    /// </summary>
    bool ByMaterial { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the color of the hatch pattern.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Read-write property that specifies if a duplicate hatch pattern should be created that is perpendicular to the original hatch pattern.
    /// </summary>
    bool DoublePattern { get; set; }
    /// <summary>
    /// Read-only property that returns the geometries that shape the profile of the drawing view hatch region.
    /// </summary>
    ObjectCollection BoundaryGeometries { get; }
    /// <summary>
    /// Read-only property that returns the DrawingViewHatchAreas collection object.
    /// </summary>
    DrawingViewHatchAreas HatchAreas { get; }
    /// <summary>
    /// Read-write property that gets and sets the layer associated with the drawing view hatch region object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Read-write property that specifies the line weight of the drawing view hatch region object in centimeters.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the DrawingHatchPattern of the drawing view hatch region.
    /// </summary>
    DrawingHatchPattern Pattern { get; set; }
    /// <summary>
    /// Read-only property that returns the range box of the DrawingViewHatchRegion.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Read-write property that specifies the scale of the distance between lines.
    /// </summary>
    double Scale { get; set; }
    /// <summary>
    /// Read-write property that specifies the hatch pattern offset from original hatch pattern position.
    /// </summary>
    double Shift { get; set; }
    /// <summary>
    /// Read-only property that returns the SurfaceBody or SurfaceBodyProxy that associated with the DrawingViewHatchRegion.
    /// </summary>
    object SurfaceBody { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the drawing view hatch region is visible or not.
    /// </summary>
    bool Visible { get; set; }
}
