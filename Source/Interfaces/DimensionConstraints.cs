namespace Oblikovati.API;

/// <summary>
/// The DimensionConstraints object provides access to all the dimension sketch constraints ( objects) in a sketch and provides methods to create additional dimension sketch constraints.
/// </summary>
public interface DimensionConstraints : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified sketch dimension constraint object from the collection.
    /// </summary>
    DimensionConstraint Item { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Method that creates a new offset dimension constraint between two entities.
    /// </summary>
    /// <param name="Line">Input SketchLine object.</param>
    /// <param name="Entity">Input sketch entity. This must be either a or SketchPoint object. If creating a linear diameter dimension and Entity is a SketchLine, then Entity is used as the centerline. If Entity is a SketchPoint, then Line is used as the centerline.</param>
    /// <param name="TextPoint">Input object that defines the position of the dimension text.</param>
    /// <param name="LinearDiameter">Input Boolean that specifies whether the dimension should be a standard distance dimension or be displayed as a linear diameter dimension.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension. The default is False, which will create a driving dimension.</param>
    /// <returns></returns>
    [PreserveSig]
    OffsetDimConstraint AddOffset([In] [MarshalAs(UnmanagedType.Interface)] SketchLine Line, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity Entity, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextPoint, [In] bool LinearDiameter, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new linear dimension constraint between two points.
    /// </summary>
    /// <param name="PointOne">Input sketch point.</param>
    /// <param name="PointTwo">Input sketch point.</param>
    /// <param name="Orientation">Input constant that specifies if the dimension is horizontal, vertical, or aligned.</param>
    /// <param name="TextPoint">Input object that defines the position of the dimension text.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    TwoPointDistanceDimConstraint AddTwoPointDistance([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint PointOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchPoint PointTwo, [In] DimensionOrientationEnum Orientation, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextPoint, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new angular dimension constraint between two lines.
    /// </summary>
    /// <param name="LineOne">Input sketch line.</param>
    /// <param name="LineTwo">Input sketch line.</param>
    /// <param name="TextPoint">Input object that defines the position of the dimension text and which of the four possible quadrants to place the dimension within.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    TwoLineAngleDimConstraint AddTwoLineAngle([In] [MarshalAs(UnmanagedType.Interface)] SketchLine LineOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchLine LineTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextPoint, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new angular dimension constraint between three points.
    /// </summary>
    /// <param name="PointOne">Input sketch point.</param>
    /// <param name="PointTwo">Input sketch point. This point defines the vertex point of the angle.</param>
    /// <param name="PointThree">Input sketch point.</param>
    /// <param name="TextPoint">Input object that defines the position of the dimension text and which of the four possible quadrants to place the dimension within.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    ThreePointAngleDimConstraint AddThreePointAngle([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint PointOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchPoint PointTwo, [In] [MarshalAs(UnmanagedType.Interface)] SketchPoint PointThree, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextPoint, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new diameter dimension constraint on the input circle or arc.
    /// </summary>
    /// <param name="Entity">Input or SketchArc object.</param>
    /// <param name="TextPoint">Input object that defines the position of the dimension text.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    DiameterDimConstraint AddDiameter([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity Entity, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextPoint, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new radius dimension constraint on the input circle or arc.
    /// </summary>
    /// <param name="Entity">Input or SketchArc object.</param>
    /// <param name="TextPoint">Input object that defines the position of the dimension text.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    RadiusDimConstraint AddRadius([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity Entity, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextPoint, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new arc length dimension on the input arc.&nbsp;This method will fail in the case where a driving dimension is specified and it will overconstrain the sketch.
    /// </summary>
    /// <param name="Entity">Input SketchArc object.</param>
    /// <param name="TextPoint">Input Point2d object that defines the position of the dimension text.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension.  The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    ArcLengthDimConstraint AddArcLength([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity Entity, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextPoint, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new tangent distance dimension constraint between the two input entities. The input entities can consist of two circles or a line and a circle. Arcs can also be used in place of the circles.
    /// </summary>
    /// <param name="EntityOne">Input , SketchArc, or SketchLine object. Both EntityOne and EntityTwo cannot be sketch lines, at least one must be an arc or circle.</param>
    /// <param name="EntityTwo">Input , SketchArc, or SketchLine object. Both EntityOne and EntityTwo cannot be sketch lines, at least one must be an arc or circle.</param>
    /// <param name="ProximityPointOne">The supplied by this argument is used when EntityOne is a circle or arc. This point specifies which of the possible two tangent cases is used when creating the constraint. The closest tangent to the input point is used. If EntityOne is a line, this argument is ignored.</param>
    /// <param name="ProximityPointTwo">The supplied by this argument is used when EntityTwo is a circle or arc. This point specifies which of the possible two tangent cases is used when creating the constraint. The closest tangent to the input point is used. If EntityTwo is a line, this argument is ignored.</param>
    /// <param name="TextPoint">Input object that defines the position of the dimension text.</param>
    /// <param name="LinearDiameter">In the case when either EntityOne or EntityTwo is a line, it is valid to specify that this constraint be placed as a linear diameter type of dimension. If neither EntityOne nor EntityTwo is a line, this argument is ignored.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    TangentDistanceDimConstraint AddTangentDistance([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ProximityPointOne, [In] [MarshalAs(UnmanagedType.Interface)] Point2d ProximityPointTwo, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextPoint, [In] bool LinearDiameter, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new dimension constraint defining the major or minor radius of the ellipse. This method will fail in the case where a driving dimension is specified and it will overconstrain the sketch.
    /// </summary>
    /// <param name="Entity">Input SketchEllipse or SketchEllipticalArc object.</param>
    /// <param name="MajorRadius">Boolean that defines if the dimension is for the major or minor radius of the ellipse.</param>
    /// <param name="TextPoint">Input Point2d object that defines the position of the dimension text. This also defines which side of the ellipse the dimension is placed on if the PositiveSide argument is not specified.</param>
    /// <param name="PositiveSide">Optional input Boolean that specifies whether to dimension the positive or the negative side of the major/minor axis. If not specified, the position of the TextPoint defines which side the dimension is placed on.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    EllipseRadiusDimConstraint AddEllipseRadius([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity Entity, [In] bool MajorRadius, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextPoint, [In] [MarshalAs(UnmanagedType.Struct)] object? PositiveSide = default, [In] bool? Driven = false);
    /// <summary>
    /// Creates a new offsetSpline dimension constraint between offset spline and the original spline.
    /// </summary>
    /// <param name="Line">Input object.</param>
    /// <param name="TextPoint">Input object that defines the position of the dimension text.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension. The default is False, which will create a driving dimension.</param>
    /// <returns></returns>
    [PreserveSig]
    OffsetSplineDimConstraint AddOffsetSpline([In] [MarshalAs(UnmanagedType.Interface)] SketchOffsetSpline Line, [In] [MarshalAs(UnmanagedType.Interface)] Point2d TextPoint, [In] bool? Driven = false);
}
