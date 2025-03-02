namespace Oblikovati.API;

/// <summary>
/// The DrawingCurveSegment object represents a single segment of a drawing curve.
/// </summary>
public interface DrawingCurveSegment
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent drawing curve.
    /// </summary>
    DrawingCurve Parent { get; }
    /// <summary>
    /// Gets and sets the layer associated with this object.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Gets and sets whether this object is graphically visible.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns whether this segment represents the hidden portion of a line. This is only applicable for drawing views with hidden lines and always returns False otherwise.
    /// </summary>
    bool HiddenLine { get; }
    /// <summary>
    /// Property that returns the start point of the curve segment in sheet space. This property returns Nothing for circular segments.
    /// </summary>
    Point2d StartPoint { get; }
    /// <summary>
    /// Property that returns the end point of the curve segment in sheet space. This property returns Nothing for circular segments.
    /// </summary>
    Point2d EndPoint { get; }
    /// <summary>
    /// Read-only property that returns a 2d geometry object that represents this drawing curve segment in sheet space.&nbsp;The true drawing curve is 3d geometry and this is a flattened 2d version.&nbsp;As a result the geometry type can be different.&nbsp;For example a 3d circle can flatten to a 2d ellipse or a line if the circle is viewed completely on edge.&nbsp;There isn’t any expected correlation between the parameterization of this curve and the original 3d curve.
    /// </summary>
    object Geometry { get; }
    /// <summary>
    /// Read-only property that returns the type of the geometry object that will be returned by the Geometry property.
    /// </summary>
    Curve2dTypeEnum GeometryType { get; }
}
