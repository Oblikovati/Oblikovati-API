namespace Oblikovati.API;

/// <summary>
/// The SketchControlPointSpline3D object represents a control point spline within a 3D sketch.  These splines are created by defining the vertices of a control polygon of a NURBS curve.  The properties and methods listed below are in addition to those supported by the SketchEntity3D object.
/// </summary>
public interface SketchControlPointSpline3D
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
    /// Property that returns the parent sketch of the entity.
    /// </summary>
    Sketch3D Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns a collection of sketch constraints that are tied directly to this entity. This collection consists of geometric and bend constraints.
    /// </summary>
    SketchConstraints3DEnumerator Constraints3D { get; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Gets and sets whether this entity is a reference entity or not.
    /// </summary>
    bool Reference { get; set; }
    /// <summary>
    /// Property that returns the object this entity is dependent on. When sketch entities are created by projecting model edges or intersecting the model, the resulting entities are driven by the original model entities and cannot be modified. This property returns the model entity the sketch entity is dependent on. The Reference property indicates whether the sketch entity is driven by a model entity or not. If the sketch entity is not referencing a model entity, this property will return Nothing. This property can also return nothing even when the sketch entity is referencing a model entity in the case where the model entity has been consumed by some subsequent modeling operation.
    /// </summary>
    object ReferencedEntity { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Gets / sets the Sketch3D Construction Property.
    /// </summary>
    bool Construction { get; set; }
    /// <summary>
    /// Property indicating entity or entities that own this object.
    /// </summary>
    SketchEntities3DEnumerator OwnedBy { get; }
    /// <summary>
    /// Property that returns an enum indicating the constraint status of the sketch entity, signifying whether it is fully constrained, over constrained, or under constrained.
    /// </summary>
    ConstraintStatusEnum ConstraintStatus { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int AssociativeID { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    GeometryMoveableStatusEnum _GeometryMoveableStatus { get; }
    /// <summary>
    /// Read-only property that returns the SketchPoint3D at the specified index.&nbsp;The indices correspond to the control points in order from the start to the end of the spline.&nbsp;The ControlPointCount property returns the total number of control points for the spline.&nbsp;Deleting the returned sketch point will delete the control point from the spline.
    /// </summary>
    SketchPoint3D ControlPoint { get; }
    /// <summary>
    /// Read-only property that returns the number of control points defining the control point spline.
    /// </summary>
    int ControlPointCount { get; }
    /// <summary>
    /// Read-only property that returns the SketchLine3D object that represents a side of the control polygon.&nbsp;The indices correspond to the control polygon edges in order from the start to the end of the spline.
    /// </summary>
    SketchLine3D ControlPolygonSide { get; }
    /// <summary>
    /// Specifies whether curvature information is displayed for the spline.
    /// </summary>
    bool CurvatureDisplay { get; set; }
    /// <summary>
    /// Read-only property that returns the sketch point that defines the position of the end of the spline.
    /// </summary>
    SketchPoint3D EndSketchPoint { get; }
    /// <summary>
    /// Read-only property that gets a BSplineCurve2d geometry object.&nbsp;The object returned represents a 'snapshot' view of the current state of the spline.
    /// </summary>
    BSplineCurve Geometry { get; }
    /// <summary>
    /// Read-only property that returns whether the curve is closed.
    /// </summary>
    bool IsClosed { get; }
    /// <summary>
    /// Gets the length of the entity in centimeters.
    /// </summary>
    double Length { get; }
    /// <summary>
    /// Returns the sketch point that defines the position of the start of the spline.
    /// </summary>
    SketchPoint3D StartSketchPoint { get; }
    /// <summary>
    /// Method that deletes the sketch entity.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that inserts a new control point into the existing control point spline.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SketchSpline3D ConvertToSpline();
    /// <summary>
    /// Method that inserts a knot into the existing control point spline. The effect of this will be that the shape of the curve is maintained, but the control polygon will change shape and one additional point will be added.
    /// </summary>
    /// <param name="Position">The parametric position of where to insert the new knot.</param>
    /// <returns></returns>
    [PreserveSig]
    double InsertKnot([In] double Position);
}
