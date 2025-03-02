namespace Oblikovati.API;

/// <summary>
/// The SketchControlPointSplines3D object supports the creation of new control point splines and provides access to all the control point splines in a 3D sketch.
/// </summary>
public interface SketchControlPointSplines3D : IEnumerable
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
    /// Method that returns the specified SketchControlPointSpline3D object from the collection.
    /// </summary>
    SketchControlPointSpline3D Item { get; }
    /// <summary>
    /// Method that creates a control point spline based on the set of input points that define the vertices of the control polygon.&nbsp;A closed spline is created when the start and end points have the same coordinate.
    /// </summary>
    /// <param name="ControlPoints">A collection of the points that defines the position of the control points.  The inputs can be combination of Point and SketchPoint3D objects.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchControlPointSpline3D Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection ControlPoints);
}
