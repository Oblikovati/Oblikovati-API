namespace Oblikovati.API;

/// <summary>
/// The GeometricConstraints object provides access to all the geometric sketch constraints ( objects) in a sketch and provides methods to create additional geometric sketch constraints.
/// </summary>
public interface GeometricConstraints : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified geometric sketch constraint object from the collection.
    /// </summary>
    GeometricConstraint this[int Index] { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Method that creates a new coincident constraint between two entities. One of the input entities must be a sketch point. The other entity can be a point or any other type of sketch entity.
    /// </summary>
    /// <param name="EntityOne">Input sketch entity.</param>
    /// <param name="EntityTwo">Input sketch entity.</param>
    /// <returns></returns>
    [PreserveSig]
    CoincidentConstraint AddCoincident([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo);
    /// <summary>
    /// Method that creates a new collinear constraint between the two input sketch entities. Valid objects for input include lines, ellipses, and elliptical arcs. Either the major or minor axis of an ellipse is used, depending on the value of the EllipseMajorAxis input argument. When an ellipse is used, the specified axis of the ellipse will become collinear to the other entity. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Input sketch entity. Must be a line, ellipse, or elliptical arc.</param>
    /// <param name="EntityTwo">Input sketch entity. Must be a line, ellipse, or elliptical arc.</param>
    /// <param name="UseEllipseOneMajorAxis">Optional Boolean that specifies whether to use the major or minor axis for the ellipse supplied in the EntityOne argument. This argument only applies when the input entity is an ellipse or elliptical arc. Inputting True results in the constraint being applied to the major axis. This value is ignored when a line is supplied as the EntityOne argument.</param>
    /// <param name="UseEllipseTwoMajorAxis">Optional Boolean that specifies whether to use the major or minor axis for the ellipse supplied in the EntityTwo argument. This argument only applies when the input entity is an ellipse or elliptical arc. Inputting True results in the constraint being applied to the major axis. This value is ignored when a line is supplied as the EntityTwo argument.</param>
    /// <returns></returns>
    [PreserveSig]
    CollinearConstraint AddCollinear([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo, [In] bool? UseEllipseOneMajorAxis = true, [In] bool? UseEllipseTwoMajorAxis = true);
    /// <summary>
    /// Method that creates a new concentric constraint between the two input sketch entities. The two entities must be circles, arcs, ellipses, or elliptical arcs. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Input sketch entity. Must be a circle, arc, ellipse, or elliptical arc.</param>
    /// <param name="EntityTwo">Input sketch entity. Must be a circle, arc, ellipse, or elliptical arc.</param>
    /// <returns></returns>
    [PreserveSig]
    ConcentricConstraint AddConcentric([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo);
    /// <summary>
    /// Method that creates a new equal length constraint between the two input sketch lines. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="LineOne">Input SketchLine object.</param>
    /// <param name="LineTwo">Input SketchLine object.</param>
    /// <returns></returns>
    [PreserveSig]
    EqualLengthConstraint AddEqualLength([In] [MarshalAs(UnmanagedType.Interface)] SketchLine LineOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchLine LineTwo);
    /// <summary>
    /// Method that creates a new equal radius constraint between the two input sketch entities. Valid input entities are circles and arcs. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Input sketch entity. Must be a circle or arc.</param>
    /// <param name="EntityTwo">Input sketch entity. Must be a circle or arc.</param>
    /// <returns></returns>
    [PreserveSig]
    EqualRadiusConstraint AddEqualRadius([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo);
    /// <summary>
    /// Method that creates a new ground constraint on the input sketch entity. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="Entity">Input sketch entity.</param>
    /// <returns></returns>
    [PreserveSig]
    GroundConstraint AddGround([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity Entity);
    /// <summary>
    /// Method that creates a new horizontal constraint on the input sketch entity. Valid input objects are lines, ellipses, and elliptical arcs. Either the major or minor axis of an ellipse is used depending on the value of the EllipseMajorAxis input argument. When an ellipse is used, the specified axis of the ellipse will become horizontal. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="Entity">Input sketch entity. Must be a line, ellipse, or elliptical arc.</param>
    /// <param name="UseEllipseMajorAxis">Optional Boolean that specifies whether to use the major or minor axis for the ellipse. This argument only applies when the input entity is an ellipse or elliptical arc. Inputting True results in the constraint being applied to the major axis. This value is ignored when a line is supplied for the entity.</param>
    /// <returns></returns>
    [PreserveSig]
    HorizontalConstraint AddHorizontal([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity Entity, [In] bool? UseEllipseMajorAxis = true);
    /// <summary>
    /// Method that creates a new horizontal alignment constraint between two sketch points. This causes the two points to align along the same horizontal axis. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="PointOne">Input SketchPoint entity.</param>
    /// <param name="PointTwo">Input SketchPoint object.</param>
    /// <returns></returns>
    [PreserveSig]
    HorizontalAlignConstraint AddHorizontalAlign([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint PointOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchPoint PointTwo);
    /// <summary>
    /// Method that creates a new midpoint constraint between the point and line. This causes the input sketch point to be positioned at the midpoint of the input line. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="Point">Input SketchPoint entity.</param>
    /// <param name="Line">Input SketchLine object.</param>
    /// <returns></returns>
    [PreserveSig]
    MidpointConstraint AddMidpoint([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint Point, [In] [MarshalAs(UnmanagedType.Interface)] SketchLine Line);
    /// <summary>
    /// Method that creates a new parallel constraint between the two input sketch entities. Valid objects for input include lines and ellipses. Either the major or minor axis of an ellipse is used depending on the values of UseEllipseMajorAxis input arguments. When an ellipse is used, the specified axis of the ellipse will become parallel to the other entity. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Input sketch entity. Must be a line, ellipse, or elliptical arc.</param>
    /// <param name="EntityTwo">Input sketch entity. Must be a line, ellipse, or elliptical arc.</param>
    /// <param name="UseEllipseOneMajorAxis">Optional Boolean that specifies whether to use the major or minor axis for the ellipse supplied in the EntityOne argument. This argument only applies when the input entity is an ellipse or elliptical arc. Inputting True results in the constraint being applied to the major axis. This value is ignored when a line is supplied as the EntityOne argument.</param>
    /// <param name="UseEllipseTwoMajorAxis">Optional Boolean that specifies whether to use the major or minor axis for the ellipse supplied in the EntityTwo argument. This argument only applies when the input entity is an ellipse or elliptical arc. Inputting True results in the constraint being applied to the major axis. This value is ignored when a line is supplied as the EntityTwo argument.</param>
    /// <returns></returns>
    [PreserveSig]
    ParallelConstraint AddParallel([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo, [In] bool? UseEllipseOneMajorAxis = true, [In] bool? UseEllipseTwoMajorAxis = true);
    /// <summary>
    /// Method that creates a new perpendicular constraint between the two input sketch entities. Valid objects for input include lines and ellipses. Either the major or minor axis of an ellipse is used depending on the value of EllipseMajorAxis input argument. When an ellipse is used, the specified axis of the ellipse will become perpendicular to the other entity. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Input sketch entity. Must be a line, ellipse, or elliptical arc.</param>
    /// <param name="EntityTwo">Input sketch entity. Must be a line, ellipse, or elliptical arc.</param>
    /// <param name="UseEllipseOneMajorAxis">Optional Boolean that specifies whether to use the major or minor axis for the ellipse supplied in the EntityOne argument. This argument only applies when the input entity is an ellipse or elliptical arc. Inputting True results in the constraint being applied to the major axis. This value is ignored when a line is supplied as the EntityOne argument.</param>
    /// <param name="UseEllipseTwoMajorAxis">Optional Boolean that specifies whether to use the major or minor axis for the ellipse supplied in the EntityTwo argument. This argument only applies when the input entity is an ellipse or elliptical arc. Inputting True results in the constraint being applied to the major axis. This value is ignored when a line is supplied as the EntityTwo argument.</param>
    /// <returns></returns>
    [PreserveSig]
    PerpendicularConstraint AddPerpendicular([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo, [In] bool? UseEllipseOneMajorAxis = true, [In] bool? UseEllipseTwoMajorAxis = true);
    /// <summary>
    /// Method that creates a new symmetry constraint between the two input entities about the specified line. The two input entities must be of the same type. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Input entity that is to be symmetric. Must be the same type as EntityTwo.</param>
    /// <param name="EntityTwo">Input entity that is to be symmetric. Must be the same type as EntityOne.</param>
    /// <param name="SymmetryAxis">Input object that defines the axis of symmetry.</param>
    /// <returns></returns>
    [PreserveSig]
    SymmetryConstraint AddSymmetry([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo, [In] [MarshalAs(UnmanagedType.Interface)] SketchLine SymmetryAxis);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EntityOne">EntityOne</param>
    /// <param name="EntityTwo">EntityTwo</param>
    [PreserveSig]
    TangentSketchConstraint _AddTangent([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo);
    /// <summary>
    /// Method that creates a new tangent constraint. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Input sketch object.</param>
    /// <param name="EntityTwo">Input sketch object.</param>
    /// <param name="ProximityPoint">Optional input Point object that specifies where the tangency should be applied in the case where the input entities share two sketch points.</param>
    /// <returns></returns>
    [PreserveSig]
    TangentSketchConstraint AddTangent([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityPoint = default);
    /// <summary>
    /// Method that creates a new vertical constraint on the input sketch entity. Valid input objects are lines and ellipses. Either the major or minor axis of an ellipse is used depending on the value of the UseEllipseMajorAxis input argument. When an ellipse is used, the specified axis of the ellipse will become vertical. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="Entity">Input sketch entity. Must be a line, ellipse, or elliptical arc.</param>
    /// <param name="UseEllipseMajorAxis">Optional Boolean that specifies whether to use the major or minor axis for the ellipse. This argument only applies when the input entity is an ellipse or elliptical arc. Inputting True results in the constraint being applied to the major axis. This value is ignored when a line is supplied for the entity.</param>
    /// <returns></returns>
    [PreserveSig]
    VerticalConstraint AddVertical([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity Entity, [In] bool? UseEllipseMajorAxis = true);
    /// <summary>
    /// Method that creates a new vertical alignment constraint between two sketch points. This causes the two points to align along the same vertical axis. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="PointOne">Input SketchPoint entity.</param>
    /// <param name="PointTwo">Input SketchLine object.</param>
    /// <returns></returns>
    [PreserveSig]
    VerticalAlignConstraint AddVerticalAlign([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint PointOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchPoint PointTwo);
    /// <summary>
    /// Method that creates a new smooth (G2-continuous) constraint. This method will fail if the constraint overconstrains the sketch.
    /// </summary>
    /// <param name="EntityOne">Input sketch entity.</param>
    /// <param name="EntityTwo">Input sketch entity.</param>
    /// <param name="ProximityPoint">Optional input Point2d object that specifies which ends of the curves to make smooth in case there are multiple connections.</param>
    /// <returns></returns>
    [PreserveSig]
    SmoothConstraint AddSmooth([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchEntity EntityTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityPoint = default);
    /// <summary>
    /// Creates a new midpoint constraint between the point and arc.
    /// </summary>
    /// <param name="Point">Input SketchPoint entity.</param>
    /// <param name="Arc">Input SketchLine entity.</param>
    /// <returns></returns>
    [PreserveSig]
    MidpointConstraint AddMidPointToArc([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint Point, [In] [MarshalAs(UnmanagedType.Interface)] SketchArc Arc);
}
