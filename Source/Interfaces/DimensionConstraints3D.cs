namespace Oblikovati.API;

/// <summary>
/// The DimensionConstraints3D object provides access to all the dimension sketch constraints in a 3D sketch and provides methods to create additional dimension sketch constraints.
/// </summary>
public interface DimensionConstraints3D : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified 3D sketch dimension constraint object from the collection.
    /// </summary>
    DimensionConstraint3D this[int Index] { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Method that gets the transient dimension plane used to place and position the dimension text when a dimension constraint is applied to the specified input entities.
    /// </summary>
    /// <param name="Entities">ObjectCollection that contains the entity objects that represents the entities for which the dimension plane has to be determined. The objects in this collection should normally contain the same objects that would be supplied as inputs to create a dimension constraint.</param>
    /// <returns></returns>
    [PreserveSig]
    Plane GetDimensionPlane([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Entities);
    /// <summary>
    /// Method that creates a new angular dimension constraint between two 3D sketch lines. This method will fail if the two input 3D sketch lines that need to be constrained are not co-planar. This method will also fail in the case where a driving dimension is specified and it will overconstrain the sketch.
    /// </summary>
    /// <param name="LineOne">Object that defines the first 3D sketch line being constrained.</param>
    /// <param name="LineTwo">Object that defines the second 3D sketch line being constrained.</param>
    /// <param name="TextPoint">Point object that defines the position of the dimension text. The dimension text will always be placed on a particular dimension plane the orientation of which will be automatically determined based on the input plane and sketch point to which the dimension is being applied. The dimension plane is a transient geometric plane which is only used to define the placement plane for the dimension text and does not have a graphical representation. If no input is specified for the position of the dimension text, a default position on the dimension plane will be calculated and used to place the dimension text. If a valid point for the dimension text is specified, then either of the following conditions will apply: 	*	If the specified point already lies on the dimension plane, then this point will be directly used to place the dimension text. 	*	If the specified point does not lie on the dimension plane, it will be projected onto the dimension plane. Therefore, the resultant placement position for the dimension text will be different from the specified one. The GetDimensionPlane method of the DimensionConstraints3D object can be used to get the dimension plane object which provides access to the dimension plane geometry.</param>
    /// <param name="Driven">Specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    TwoLineAngleDimConstraint3D AddTwoLineAngle([In] [MarshalAs(UnmanagedType.Interface)] SketchLine3D LineOne, [In] [MarshalAs(UnmanagedType.Interface)] SketchLine3D LineTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? TextPoint = default, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new linear dimension constraint between a 3D sketch point and a planar face or workplane. This method will fail if the input 3D sketch point lies on the input plane specified by the face or workplane. This method will also fail in the case where a driving dimension is specified and it will overconstrain the sketch.
    /// </summary>
    /// <param name="Point">Object that defines the 3D sketch point being constrained.</param>
    /// <param name="Plane">Planar Face or WorkPlane object that defines the distance to the 3D sketch point being constrained.</param>
    /// <param name="TextPoint">Point object that defines the position of the dimension text. The dimension text will always be placed on a particular dimension plane the orientation of which will be automatically determined based on the input plane and sketch point to which the dimension is being applied. The dimension plane is a transient geometric plane which is only used to define the placement plane for the dimension text and does not have a graphical representation. If no input is specified for the position of the dimension text, a default position on the dimension plane will be calculated and used to place the dimension text. If a valid point for the dimension text is specified, then either of the following conditions will apply: 	*	If the specified point already lies on the dimension plane, then this point will be directly used to place the dimension text. 	*	If the specified point does not lie on the dimension plane, it will be projected onto the dimension plane. Therefore, the resultant placement position for the dimension text will be different from the specified one. The GetDimensionPlane method of the DimensionConstraints3D object can be used to get the dimension plane object which provides access to the dimension plane geometry.</param>
    /// <param name="Driven">Specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    PointAndPlaneDistanceDimConstraint3D AddPointAndPlaneDistance([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint3D Point, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane, [In] [MarshalAs(UnmanagedType.Struct)] object? TextPoint = default, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new linear dimension constraint between a 3D sketch point and another 3D sketch point, vertex or workpoint. This method will fail in the case where a driving dimension is specified and it will overconstrain the sketch.
    /// </summary>
    /// <param name="PointOne">SketchPoint3D, Vertex or WorkPoint object that defines the first point being constrained.</param>
    /// <param name="PointTwo">SketchPoint3D, Vertex or WorkPoint object that defines the second point being constrained. At least one of the input points (PointOne or PointTwo) for the dimension constraint must be a SketchPoint3D object. If a 3D sketch point is specified for either PointOne or PointTwo and a vertex or workpoint is specified for the other point, then a 3D sketch point will be created at the specified vertex or workpoint and then the constraint will be applied between the two 3D sketch points.</param>
    /// <param name="TextPoint">Point object that defines the position of the dimension text. The dimension text will always be placed on a particular dimension plane the orientation of which will be automatically determined based on the input plane and sketch point to which the dimension is being applied. The dimension plane is a transient geometric plane which is only used to define the placement plane for the dimension text and does not have a graphical representation. If no input is specified for the position of the dimension text, a default position on the dimension plane will be calculated and used to place the dimension text. If a valid point for the dimension text is specified, then either of the following conditions will apply: 	*	If the specified point already lies on the dimension plane, then this point will be directly used to place the dimension text. 	*	If the specified point does not lie on the dimension plane, it will be projected onto the dimension plane. Therefore, the resultant placement position for the dimension text will be different from the specified one. The GetDimensionPlane method of the DimensionConstraints3D object can be used to get the dimension plane object which provides access to the dimension plane geometry.</param>
    /// <param name="Driven">Specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    TwoPointDistanceDimConstraint3D AddTwoPointDistance([In] [MarshalAs(UnmanagedType.IDispatch)] object PointOne, [In] [MarshalAs(UnmanagedType.IDispatch)] object PointTwo, [In] [MarshalAs(UnmanagedType.Struct)] object? TextPoint = default, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new linear dimension constraint that defines the length of a 3D sketch line. This method will fail in the case where a driving dimension is specified and it will overconstrain the sketch.
    /// </summary>
    /// <param name="Line">Object that defines the 3D sketch line being constrained.</param>
    /// <param name="TextPoint">Object that defines the position of the dimension text. The dimension text will always be placed on a particular dimension plane the orientation of which will be automatically determined using the input line that is being dimensioned. The dimension plane is a transient geometric plane which is only used to define the placement plane for the dimension text and does not have a graphical representation. If no input is specified for the position of the dimension text, a default position on the dimension plane will be calculated and used to place the dimension text. If a valid point for the dimension text is specified, then either of the following conditions will apply: 	*	If the specified point already lies on the dimension plane, then this point will be directly used to place the dimension text. 	*	If the specified point does not lie on the dimension plane, it will be projected onto the dimension plane. Therefore, the resultant placement position for the dimension text will be different from the specified one. The GetDimensionPlane method of the DimensionConstraints3D object can be used to get the dimension plane object which provides access to the dimension plane geometry.</param>
    /// <param name="Driven">Specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    LineLengthDimConstraint3D AddLineLength([In] [MarshalAs(UnmanagedType.Interface)] SketchLine3D Line, [In] [MarshalAs(UnmanagedType.Struct)] object? TextPoint = default, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new radius dimension constraint on the input circle or arc.
    /// </summary>
    /// <param name="Entity">Input SketchCircle3D or SketchArc3D object.</param>
    /// <param name="TextPoint">The dimension text can only be placed on the plane that contains the two input sketch lines to which the dimension is being applied. The orientation of this dimension plane will be automatically determined using the input sketch lines. The dimension plane is a transient geometric plane which is only used to define the placement plane for the dimension text and does not have a graphical representation. The position of the text point defines which of the four quadrants on the dimension plane the constraint is placed within.
    /// If no input is specified for the position of the dimension text, a default position on the dimension plane will be calculated and used to place the dimension text.
    /// If a valid point for the dimension text is specified, then either of the following conditions will apply: * If the specified point already lies on the dimension plane, then this point will be directly used to place the dimension text. * If the specified point does not lie on the dimension plane, it will be projected onto the dimension plane. Therefore, the resultant placement position for the dimension text will be different from the specified one. The GetDimensionPlane method of the DimensionConstraints3D object can be used to get the dimension plane object which provides access to the dimension plane geometry.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension. The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    RadiusDimConstraint3D AddRadius([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D Entity, [In] [MarshalAs(UnmanagedType.Struct)] object? TextPoint = default, [In] bool? Driven = false);
    /// <summary>
    /// Method that creates a new spline length dimension constraint that defines the length of a 3D sketch spline.
    /// </summary>
    /// <param name="SketchSpline">Input SketchSpline3D object that specifies a 3D sketch spline to add dimension constraint to. Currently only the SkechSpline3D is supported to add this dimension, other 3D sketch splines are not supported yet.</param>
    /// <param name="TextPoint">Optional input Point object that defines the position of the dimension text. If no input is specified for the position of the dimension text, a default position on the dimension plane will be calculated and used to place the dimension text. If a valid point for the dimension text is specified, then either of the following conditions will apply:
    /// If the specified point already lies on the dimension plane, then this point will be directly used to place the dimension text.
    /// If the specified point does not lie on the dimension plane, it will be projected onto the dimension plane. Therefore, the resultant placement position for the dimension text will be different from the specified one.</param>
    /// <param name="Driven">Optional input Boolean that specifies whether the dimension should be a driven or driving dimension.  The default value is False, which causes a driving dimension constraint to be created.</param>
    /// <returns></returns>
    [PreserveSig]
    SplineLengthDimConstraint3D AddSplineLength([In] [MarshalAs(UnmanagedType.Interface)] SketchEntity3D SketchSpline, [In] [MarshalAs(UnmanagedType.Struct)] object? TextPoint = default, [In] bool? Driven = false);
}
