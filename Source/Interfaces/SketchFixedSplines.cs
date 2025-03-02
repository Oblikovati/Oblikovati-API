namespace Oblikovati.API;

/// <summary>
/// SketchFixedSplines object provides access to all the objects in a sketch. See the article in the overviews section.
/// </summary>
public interface SketchFixedSplines : IEnumerable
{
    /// <summary>
    /// Method that returns the specified SketchFixedSpline object from the collection.
    /// </summary>
    SketchFixedSpline this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a fixed spline based on an input NURBS definition.
    /// </summary>
    /// <param name="SplineCurve">Input BSplineCurve2d geometry object that contains the definition of a curve from which to create a SketchFixedSpline.</param>
    /// <param name="StartPoint">Optional input SketchPoint object that contains the start point to fit the curve through. If this argument is not specified, a sketch point is created at the point defined by the start point of the input BSplineCurve2d and the resulting spline is constrained to it.</param>
    /// <param name="EndPoint">Optional input SketchPoint that contains the end point to fit the curve through. If this argument is not specified, a sketch point is created at the point defined by the end point of the input BSplineCurve2d and the resulting spline is constrained to it.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchFixedSpline Add([In] [MarshalAs(UnmanagedType.Interface)] BSplineCurve2d SplineCurve, [In] [MarshalAs(UnmanagedType.Struct)] object? StartPoint = default, [In] [MarshalAs(UnmanagedType.Struct)] object? EndPoint = default);
}
