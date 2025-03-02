namespace Oblikovati.API;

/// <summary>
/// The SketchArcs object provides access to all the objects in a sketch and provides methods to create additional sketch arcs. See the article in the overviews section.
/// </summary>
public interface SketchArcs : IEnumerable
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
    /// Returns the specified SketchArcobject from the collection.
    /// </summary>
    SketchArc this[int Index] { get; }
    /// <summary>
    /// Method that creates a new sketch arc defined by a center point and two points defining the start and end. The input points can be a combination of existing sketch points or Point2d objects. In the case where a sketch points is input, the arc will be attached to the sketch point. The sweep direction of the arc from the start to end point is determined by the CounterClockwise argument. The radius of the arc is determined by the start point. If the input for the start point is a sketch point, the arc will be tied to the sketch point. The second point, whether it is a sketch point or coordinate point defines the sweep of the arc. In the case where a sketch point is input and it is on the arc, the arc will be tied to the sketch point.
    /// </summary>
    /// <param name="CenterPoint">Input object that defines the center point. This can be either a SketchPoint or Point2d object. In the case where a SketchPoint object is input, the center point of the arc will be attached to the sketch point.</param>
    /// <param name="StartPoint">Input object that defines the start point. This can be either a SketchPoint or Point2d object. In the case where a SketchPoint object is input, the start point of the arc will be attached to the sketch point.</param>
    /// <param name="EndPoint">Input object that defines the end point. This can be either a SketchPoint or Point2d object. In the case where a SketchPoint object is input and the point lies on the arc, the end point of the arc will be attached to the sketch point.</param>
    /// <param name="CounterClockwise">Optional input Boolean that defines whether the arc sweeps in a clockwise or counterclockwise direction between the start and end points. The default value is True which indicates a counterclockwise sweep direction.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchArc AddByCenterStartEndPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint, [In] bool? CounterClockwise = true);
    /// <summary>
    /// Method that creates a new sketch arc using the input point and angles.
    /// </summary>
    /// <param name="CenterPoint">Input object that defines the center point. This can be either a SketchPoint or Point2d object. In the case where a SketchPoint object is input, the center point of the arc will be attached to the sketch point.</param>
    /// <param name="Radius">Input Double that defines the radius of the arc in centimeters.</param>
    /// <param name="StartAngle">Input Double that defines the start angle in radians. The start angle is defined with respect to the sketch x-axis.</param>
    /// <param name="SweepAngle">Input Double that defines the sweep angle in radians. The sweep is in a counter-clockwise direction from the start.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchArc AddByCenterStartSweepAngle([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] double Radius, [In] double StartAngle, [In] double SweepAngle);
    /// <summary>
    /// Method that creates a new sketch arc that passes through the three input points.
    /// </summary>
    /// <param name="StartPoint">Input object that defines the start point. This can be either a SketchPoint or Point2d object. In the case where a SketchPoint object is input, that start point of the arc will be attached to the sketch point.</param>
    /// <param name="MidPoint">Input Point2d object that defines a point along the arc.</param>
    /// <param name="EndPoint">Input object that defines the end point. This can be either a SketchPoint or Point2d object. In the case where a SketchPoint object is input, that end point of the arc will be attached to the sketch point.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchArc AddByThreePoints([In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] [MarshalAs(UnmanagedType.Interface)] Point2d MidPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint);
    /// <summary>
    /// Method that creates a new sketch arc as a fillet between two sketch entities.
    /// </summary>
    /// <param name="EntityOne">Input sketch entity.</param>
    /// <param name="EntityTwo">Input sketch entity.</param>
    /// <param name="Radius">Input double that defines the radius of the arc in centimeters.</param>
    /// <param name="PointOnEntityOne">Input that defines the point on the first entity on which to start the SketchArc.</param>
    /// <param name="PointOnEntityTwo">Input that defines the point on the second entity on which to end the SketchArc.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchArc AddByFillet([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object Radius, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PointOnEntityOne, [In] [MarshalAs(UnmanagedType.Interface)] Point2d PointOnEntityTwo);
}
