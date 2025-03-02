namespace Oblikovati.API;

/// <summary>
/// The SketchControlPointSplines object supports creating new control point splines and provides access to all the existing control point splines in a sketch.
/// </summary>
public interface SketchControlPointSplines : IEnumerable
{
    /// <summary>
    /// Read-only property returning kSketchControlPointSplinesObject indicating the type of object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified SketchControlPointSpline object from the collection.
    /// </summary>
    SketchControlPointSpline this[int Index] { get; }
    /// <summary>
    /// Method that creates a control point spline based on the set of input points that define the vertices of the control polygon.&nbsp;A closed spline is created when the start and end points have the same coordinate.
    /// </summary>
    /// <param name="ControlPoints">A collection of the points that defines the position of the control points.  The inputs can be combination of Point2d and SketchPoint objects.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchControlPointSpline Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ControlPoints);
}
