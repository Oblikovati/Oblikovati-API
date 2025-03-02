namespace Oblikovati.API;

/// <summary>
/// DrawingViewHatchArea Object.
/// </summary>
public interface DrawingViewHatchArea
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
    DrawingViewHatchRegion Parent { get; }
    /// <summary>
    /// Read-only property that returns the geometries that shape the profile of the drawing view hatch area.
    /// </summary>
    ObjectCollection BoundaryGeometries { get; }
    /// <summary>
    /// Read-only property that returns the range box of the DrawingViewHatchArea.
    /// </summary>
    Box2d RangeBox { get; }
}
