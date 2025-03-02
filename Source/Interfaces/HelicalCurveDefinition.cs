namespace Oblikovati.API;

/// <summary>
/// HelicalCurveDefinition object.
/// </summary>
public interface HelicalCurveDefinition
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    HelicalCurve Parent { get; }
    /// <summary>
    /// Gets and sets the rotation of the helical curve.
    /// </summary>
    bool Clockwise { get; set; }
    /// <summary>
    /// Gets and sets the start point of the helical curve.
    /// </summary>
    Point CurveStart { get; set; }
    /// <summary>
    /// Gets and sets the axis end point of the helical curve.
    /// </summary>
    Point AxisEndPoint { get; set; }
    /// <summary>
    /// Gets and sets the shape definition type of the helical curve.
    /// </summary>
    HelicalShapeDefinitionTypeEnum ShapeDefinitionType { get; set; }
    /// <summary>
    /// Gets and sets the axis start point of the helical curve.
    /// </summary>
    Point AxisStartPoint { get; set; }
    /// <summary>
    /// Creates a copy of this HelicalCurveDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    HelicalCurveDefinition Copy();
}
