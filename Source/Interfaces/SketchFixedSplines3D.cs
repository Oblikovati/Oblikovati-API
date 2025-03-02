namespace Oblikovati.API;

/// <summary>
/// The SketchFixedSplines3D object provides access to all the objects in a 3D sketch. See the article in the overviews section.
/// </summary>
public interface SketchFixedSplines3D : IEnumerable
{
    /// <summary>
    /// Method that returns the specified SketchFixedSpline3D object from the collection.
    /// </summary>
    SketchFixedSpline3D this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a fixed spline based on an input NURBS definition.
    /// </summary>
    /// <param name="SplineCurve">Input BSplineCurve geometry object that contains the definition of a curve from which to create a SketchFixedSpline3D.</param>
    /// <param name="StartPoint">Optional input Object that contains the start point to fit the curve through. The point can be either an existing SketchPoint3D object, a SketchPoint object, a workpoint or vertex. If the input is not a SketchPoint3D object, a SketchPoint3D object is automatically created at the position of the input point. If the argument is not supplied, a SketchPoint3D object is automatically created at the position of the start point of the input BSplineCurve.</param>
    /// <param name="EndPoint">Optional input Object that contains the end point to fit the curve through. The point can be either an existing SketchPoint3D object, a SketchPoint object, a workpoint or vertex . If the input is not a SketchPoint3D object, a SketchPoint3D object is automatically created at the position of the input point. If the argument is not supplied, a SketchPoint3D object is automatically created at the position of the end point of the input BSplineCurve.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchFixedSpline3D Add([In] [MarshalAs(UnmanagedType.Interface)] BSplineCurve SplineCurve, [In] [MarshalAs(UnmanagedType.Struct)] object? StartPoint = default, [In] [MarshalAs(UnmanagedType.Struct)] object? EndPoint = default);
    /// <summary>
    /// Method that creates a fixed spline based on an input transient Edge object. This capability is useful because some edges are defined precisely using a procedural algorithm. Converting these to a NURBS curves results in an approximation of the procedural curve. The SketchFixedSpline3D object created with this method has the full accuracy of the procedural curve without any approximation.
    /// </summary>
    /// <param name="TransientEdge">Input Edge object. The edge must be a transient B\-Rep Edge or the method will fail.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchFixedSpline3D AddByEdge([In] [MarshalAs(UnmanagedType.Interface)] Edge TransientEdge);
}
