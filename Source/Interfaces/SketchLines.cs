namespace Oblikovati.API;

/// <summary>
/// The SketchLines object provides access to all of the objects in a sketch and provides methods to create additional sketch lines. See the article in the overviews section.
/// </summary>
public interface SketchLines : IEnumerable
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
    /// Returns the specified SketchLine object from the collection.
    /// </summary>
    SketchLine this[int Index] { get; }
    /// <summary>
    /// Method that creates a new sketch line based on the two input points. The new sketch line is returned.
    /// </summary>
    /// <param name="StartPoint">Input object that defines the start point of the line. This can be either a Point2d object defining an x-y point in space, or an existing SketchPoint object. If an existing sketch point is input, that point becomes the line's start point.</param>
    /// <param name="EndPoint">Input object that defines the end point of the line. This can be either a Point2d object defining an x-y point in space, or an existing SketchPoint object. If an existing sketch point is input, that point becomes the line's end point.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchLine AddByTwoPoints([In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint);
    /// <summary>
    /// Method that creates four lines to represent a rectangle where the diagonal corners of the rectangle are defined by the two input points and the rectangle is aligned with the sketch X and Y axes. The four new sketch lines are returned in an SketchEntitiesEnumerator object.
    /// </summary>
    /// <param name="CornerPointOne">Input object that defines a corner of the rectangle. This can be a SketchPoint or a Point2d object. If an existing sketch point is input, the lines become connected to that point and the point becomes the corner point of the rectangle.</param>
    /// <param name="CornerPointTwo">Input object that defines the diagonal corner of the rectangle. This can be a SketchPoint or a Point2d object. If an existing sketch point is input, the lines become connected to that point and the point becomes the corner point of the rectangle.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator AddAsTwoPointRectangle([In] [MarshalAs(UnmanagedType.IDispatch)] object CornerPointOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object CornerPointTwo);
    /// <summary>
    /// Method that creates four lines to represent a rectangle where the base of the rectangle is defined by two points and the height is defined by a third point. The input points for the base can be either Point2d objects defining an X-Y point in space, or an existing SketchPoint object.
    /// </summary>
    /// <param name="BasePointOne">Input object that defines the first base point of the rectangle. Either a SketchPoint or Point2d object can be used. If an existing sketch point is input, that lines become connected to the point.</param>
    /// <param name="BasePointTwo">Input object that defines the second base point of the rectangle. Either a SketchPoint or Point2d object can be used. If an existing sketch point is input, the lines become connected to the point.</param>
    /// <param name="HeightPoint">Input Point2d object that defines the height of the rectangle. The point can be anywhere in space and the height of the rectangle is computed by finding the shortest distance of this point to an infinite line defined by the two base points.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator AddAsThreePointRectangle([In] [MarshalAs(UnmanagedType.IDispatch)] object BasePointOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object BasePointTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point2d HeightPoint);
    /// <summary>
    /// Method that creates four lines to represent a rectangle where the center of the rectangle is defined by a point and the corner of the rectangle is defined by the second point and the rectangle is aligned with the sketch x and y axes.&nbsp;The input points can be either Point2d objects defining an x-y point in space, or an existing SketchPoint object.&nbsp;If an existing sketch point is input, the lines will become connected to that point.&nbsp;The created sketch lines are returned in a SketchEntitiesEnumerator object.&nbsp;This includes the four lines representing the rectangle and the two internal construction lines.
    /// </summary>
    /// <param name="CenterPoint">Input object that specifies the center of the rectangle. This can either be a SketchPoint or a Point2d object.</param>
    /// <param name="CornerPoint">Input object that specifies a corner of the rectangle. This can either be a SketchPoint or a Point2d object.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator AddAsTwoPointCenteredRectangle([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object CornerPoint);
    /// <summary>
    /// Method that creates four lines to represent a rectangle where the center of the rectangle is defined by a point, the length and orientation is defined by a second point, and the width defined by a third point.
    /// </summary>
    /// <param name="CenterPoint">Input object that specifies the center of the rectangle. This can either be a SketchPoint or a Point2d object.</param>
    /// <param name="EdgePoint">Input object that specifies a point on the edge of the rectangle that defines the orientation and length of the rectangle.</param>
    /// <param name="WidthPoint">Input Point2d that defines the width of the rectangle.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator AddAsThreePointCenteredRectangle([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EdgePoint, [In] [MarshalAs(UnmanagedType.Interface)] Point2d WidthPoint);
    /// <summary>
    /// Method that creates a polygon with up to 120 sides. The sketch lines representing the polygon are returned.
    /// </summary>
    /// <param name="NumberOfSides">Input Long that specifies the number of sides of the polygon. If a value lesser than 3 or greater than 120 is provided, the method returns an error.</param>
    /// <param name="CenterPoint">Input object that specifies the center of the polygon. This can either be a SketchPoint or a Point2d object.</param>
    /// <param name="CircumferencePoint">Input object that specifies a point on the circumference of the circle that inscribes or circumscribes the polygon. This can either be a SketchPoint or a Point2d object.</param>
    /// <param name="Inscribed">Input Boolean that specifies whether the specified CircumferencePoint is on a circle that inscribes or circumscribes the polygon.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator AddAsPolygon([In] int NumberOfSides, [In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object CircumferencePoint, [In] bool Inscribed);
}
