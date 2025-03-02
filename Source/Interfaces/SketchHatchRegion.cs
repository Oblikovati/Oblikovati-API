namespace Oblikovati.API;

/// <summary>
/// SketchHatchRegion Object.
/// </summary>
public interface SketchHatchRegion
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
    DrawingSketch Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the rotation angle of the pattern in radians.
    /// </summary>
    double Angle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the color of the hatch pattern.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Read-write property that specifies if a duplicate hatch pattern should be created that is perpendicular to the hatch pattern assigned to the sketch hatch region.
    /// </summary>
    bool DoublePattern { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the layer associated with the hatch region object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Read-write property that specifies the line weight of the sketch hatch region object in centimeters. A value of 0 indicates the line weight is By Layer.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the DrawingHatchPattern of the sketch hatch region.
    /// </summary>
    DrawingHatchPattern Pattern { get; set; }
    /// <summary>
    /// Read-only property that returns the profile associated with the sketch hatch region.
    /// </summary>
    Profile Profile { get; }
    /// <summary>
    /// Read-write property that specifies the scale of the distance between lines.
    /// </summary>
    double Scale { get; set; }
    /// <summary>
    /// Read-write property that specifies the hatch pattern offset from original hatch pattern position.
    /// </summary>
    double Shift { get; set; }
    /// <summary>
    /// Method that deletes the SketchHatchRegion.
    /// </summary>
    [PreserveSig]
    void Delete();
}
