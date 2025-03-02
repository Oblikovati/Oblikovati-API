namespace Oblikovati.API;

/// <summary>
/// The SketchFixedSpline3D object represents a fixed spline within a sketch. These splines are created using the geometry definition (BSplineCurve). See the article in the overviews section.
/// </summary>
public interface SketchFixedSpline3D
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
    /// Property that returns the that defines the position of the end of the spline.
    /// </summary>
    SketchPoint3D EndSketchPoint { get; }
    /// <summary>
    /// Property that returns the that defines the position of the start of the spline.
    /// </summary>
    SketchPoint3D StartSketchPoint { get; }
    /// <summary>
    /// Gets and sets a BSplineCurve3d geometry object.&nbsp;The object returned represents a 'snapshot' view of the current state of the sketch fixed spline.
    /// </summary>
    BSplineCurve Geometry { get; set; }
    /// <summary>
    /// Double property that returns the length of the entity in centimeters.
    /// </summary>
    double Length { get; }
    /// <summary>
    /// Boolean property that gets whether the curve is closed. A periodic curve is closed and curvature continuous at the closure.
    /// </summary>
    bool Closed { get; }
    /// <summary>
    /// Property that indicates if this SketchFixedSpline3D object is defined by a BSplineCurve or was created using an Edge as \input. Returns True if it was created using an Edge. Returns False if it was created using a BSplineCurve.
    /// </summary>
    bool IsDefinedByEdge { get; }
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
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that edits a fixed sketch spline based on an input NURBS definition. This method is only valid for SketchFixedSpline3D objects that were created using a BSplineCurve as input. This method will fail if the curve was created with an Edge.
    /// </summary>
    /// <param name="SplineCurve">Input BSplineCurve geometry object that contains the definition of a curve that will be used to redefine the spline.</param>
    /// <param name="StartPoint">Optional input Object that contains the start point to fit the curve through. The point can be either an existing SketchPoint3D object, a SketchPoint object, a workpoint or vertex. If the input is not a SketchPoint3D object, a SketchPoint3D object is automatically created at the position of the input point. If the argument is not supplied, a SketchPoint3D object is automatically created at the position of the start point of the input BSplineCurve.</param>
    /// <param name="EndPoint">Optional input Object that contains the end point to fit the curve through. The point can be either an existing SketchPoint3D object, a SketchPoint object, a workpoint or vertex. If the input is not a SketchPoint3D object, a SketchPoint3D object is automatically created at the position of the input point. If the argument is not supplied, a SketchPoint3D object is automatically created at the position of the end point of the input BSplineCurve.</param>
    [PreserveSig]
    void Edit([In] [MarshalAs(UnmanagedType.Interface)] BSplineCurve SplineCurve, [In] [MarshalAs(UnmanagedType.Struct)] object? StartPoint = default, [In] [MarshalAs(UnmanagedType.Struct)] object? EndPoint = default);
    /// <summary>
    /// Method that converts the fixed spline to a SketchSpline3D object. This method is currently only valid for SketchFixedSpline3D objects that were created using a BSplineCurve as input.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SketchSpline3D ConvertToSpline();
    /// <summary>
    /// Method that edits the geometry of a fixed sketch spline based on an input transient Edge.
    /// </summary>
    /// <param name="TransientEdge">Input transient Edge object.</param>
    [PreserveSig]
    void EditByEdge([In] [MarshalAs(UnmanagedType.Interface)] Edge TransientEdge);
}
