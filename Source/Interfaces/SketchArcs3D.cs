namespace Oblikovati.API;

/// <summary>
/// The SketchArcs3D object provides access to all the sketch arcs ( objects, including bends) in a 3D sketch and provides methods to create additional bends. See the article in the overviews section.
/// </summary>
public interface SketchArcs3D : IEnumerable
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
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified SketchArc3D object from the collection.
    /// </summary>
    SketchArc3D Item { get; }
    /// <summary>
    /// Method that creates a new bend feature based on the two input lines.
    /// </summary>
    /// <param name="LineOne">Input 3D sketch line. Note that LineOne and LineTwo should be constrained end to end.</param>
    /// <param name="LineTwo">Input 3D sketch line. Note that LineOne and LineTwo should be constrained end to end.</param>
    /// <param name="BendRadius">Optional input variant that defines the radius of the bend. If not supplied the auto bend radius defined in the document options is used. This can be either a numeric value or a string. A parameter for this value will be created and the supplied string or value is assigned to the parameter. If a value is input, the units are centimeters. If a string is input, the units can be specified as part of the string or it will default to the current length units of the document.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchArc3D AddAsBend([In] [MarshalAs(UnmanagedType.Interface)] SketchLine3D LineOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchLine3D LineTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? BendRadius = default);
    /// <summary>
    /// Method that creates a new sketch arc defined by a center point and two points defining the start and end. Method that creates a new sketch arc defined by a center point and two points defining the start and end.
    /// </summary>
    /// <param name="CenterPoint">Input object that defines the center point. This can currently only be a Point object.</param>
    /// <param name="StartPoint">Input object that defines the start point. This can be either a SketchPoint3D or Point object. In the case where a SketchPoint3D object is input, the start point of the arc will be attached to the sketch point.</param>
    /// <param name="EndPoint">Input object that defines the end point. This can be either a SketchPoint3D or Point object. In the case where a SketchPoint3D object is input and the point lies on the arc, the end point of the arc will be attached to the sketch point.</param>
    /// <param name="Normal">Optional input UnitVector that defines the normal direction for the arc. This is only required when the start, center and end points are collinear (i.e. the arc is a semi-circle). In other cases, the normal need not be provided, but if it is, it needs to be consistent with the input points.</param>
    /// <param name="CounterClockwise">Optional input Boolean that defines whether the arc sweeps in a clockwise or counterclockwise direction between the start and end points. The default value is True which indicates a counterclockwise sweep direction.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchArc3D AddByCenterStartEndPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint, [In] [MarshalAs(UnmanagedType.Struct)] object? Normal = default, [In] bool? CounterClockwise = false);
    /// <summary>
    /// Method that creates a new sketch arc using the input point and angles.
    /// </summary>
    /// <param name="CenterPoint">Input object that defines the center point. This can currently only be a Point object.</param>
    /// <param name="Normal">Input UnitVector that defines the normal direction for the arc.</param>
    /// <param name="ReferenceVector">Input UnitVector that defines the reference vector. The ReferenceVector is the direction that is used to measure the start and the end angles of the arc. In other words, the ReferenceVector represents the zero angle and the start and end angles are measure with respect to this vector.</param>
    /// <param name="Radius">Input Double that defines the radius of the arc in centimeters.</param>
    /// <param name="StartAngle">Input Double that defines the start angle in radians. The start angle is defined with respect to the sketch x-axis.</param>
    /// <param name="SweepAngle">Input Double that defines the sweep angle in radians. The sweep is in a counter-clockwise direction from the start.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchArc3D AddByCenterStartSweepAngle([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Normal, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector ReferenceVector, [In] double Radius, [In] double StartAngle, [In] double SweepAngle);
    /// <summary>
    /// Method that creates a new sketch arc that passes through the three input points. All the points must lie on the same plane.
    /// </summary>
    /// <param name="StartPoint">Input object that defines the start point. This can be either a SketchPoint3D or Point object. In the case where a SketchPoint3D object is input, that start point of the arc will be attached to the sketch point.</param>
    /// <param name="MidPoint">Input Point object that defines a point along the arc.</param>
    /// <param name="EndPoint">Input object that defines the end point. This can be either a SketchPoint3D or Point object. In the case where a SketchPoint3D object is input, that end point of the arc will be attached to the sketch point.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchArc3D AddByThreePoints([In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object MidPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint);
}
