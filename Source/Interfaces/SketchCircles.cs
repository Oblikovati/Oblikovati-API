namespace Oblikovati.API;

/// <summary>
/// The SketchCircles object provides access to all the objects in a sketch and provides methods to create additional sketch circles. See the article in the overviews section.
/// </summary>
public interface SketchCircles : IEnumerable
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
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified SketchCircle object from the collection.
    /// </summary>
    SketchCircle this[int Index] { get; }
    /// <summary>
    /// Method that creates a new sketch circle at a specified location and radius.
    /// </summary>
    /// <param name="CenterPoint">Input object that defines the center point. This can be either a SketchPoint or Point2d object. In the case where a SketchPoint object is input, the circle will be attached to the point.</param>
    /// <param name="Radius">Input Double that defines the radius of the circle in centimeters.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchCircle AddByCenterRadius([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] double Radius);
    /// <summary>
    /// Method that creates a new sketch circle passing through the three input points. The three points are any three points along the perimeter of the desired circle.
    /// </summary>
    /// <param name="PointOne">Input that defines the first point along the circle.</param>
    /// <param name="PointTwo">Input that defines the second point along the circle.</param>
    /// <param name="PointThree">Input that defines the third point along the circle.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchCircle AddByThreePoints([In] [MarshalAs(UnmanagedType.Interface)] Point2d PointOne, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PointTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PointThree);
}
