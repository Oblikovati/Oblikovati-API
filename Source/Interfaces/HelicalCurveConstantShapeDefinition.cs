namespace Oblikovati.API;

/// <summary>
/// HelicalCurveConstantShapeDefinition object.
/// </summary>
public interface HelicalCurveConstantShapeDefinition
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
    /// Gets and sets the helix start end type.
    /// </summary>
    HelixEndTypeEnum HelixStartEndType { get; set; }
    /// <summary>
    /// Gets and sets the helix end end type.
    /// </summary>
    HelixEndTypeEnum HelixEndEndType { get; set; }
    /// <summary>
    /// Gets and sets the helix start transition angle.
    /// </summary>
    object HelixStartTransitionAngle { get; set; }
    /// <summary>
    /// Gets and sets the helix end transition angle.
    /// </summary>
    object HelixEndTransitionAngle { get; set; }
    /// <summary>
    /// Gets and sets the helix start flat angle.
    /// </summary>
    object HelixStartFlatAngle { get; set; }
    /// <summary>
    /// Gets and sets the helix end flat angle.
    /// </summary>
    object HelixEndFlatAngle { get; set; }
    /// <summary>
    /// Gets and sets the diameter of the helical curve.
    /// </summary>
    object Diameter { get; set; }
    /// <summary>
    /// Gets and sets the pitch of the helical curve.
    /// </summary>
    object Pitch { get; set; }
    /// <summary>
    /// Gets and sets the revolution of the helical curve.
    /// </summary>
    object Revolution { get; set; }
    /// <summary>
    /// Gets and sets the height of the helical curve.
    /// </summary>
    object Height { get; set; }
    /// <summary>
    /// Gets and sets the taper angle of the helical curve.
    /// </summary>
    object Taper { get; set; }
    /// <summary>
    /// Creates a copy of this HelicalCurveDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    HelicalCurveDefinition Copy();
}
