namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface SketchPoint3DProxy
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
    /// Gets and sets a Point geometry object. The object returned represents a 'snapshot' view of the current state of the sketch point.
    /// </summary>
    Point Geometry { get; set; }
    /// <summary>
    /// Property that returns the collection of objects that are connected to this point.
    /// </summary>
    SketchEntities3DEnumerator AttachedEntities { get; }
    /// <summary>
    /// Defines if the sketch point is being displayed as a hole center.
    /// </summary>
    bool HoleCenter { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    SketchPoint3D NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
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
    /// Method that connects this sketch point to the input point. Valid inputs are SketchPoint3D, SketchPoint, Vertex or WorkPoint. This method is the UI equivalent of 'Add Coincident Constraint'. The point being constrained is the sketch point on which this method is called and the input point is the constraining point. This method will fail if a coincident constraint exists between this sketch point and a vertex; i.e. this sketch point must be underconstrained.
    /// </summary>
    /// <param name="ConstrainingPoint">Input SketchPoint3D, Vertex or Workpoint to use as the constraining point.</param>
    [PreserveSig]
    void ConnectTo([In] [MarshalAs(UnmanagedType.IDispatch)] object ConstrainingPoint);
    /// <summary>
    /// Method that moves the sketch point a delta distance from its current location. Movement of a sketch point is limited by the constraints currently defined on the sketch. If a sketch is partially constrained it will perform the move within the range allowed by the constraints. Because of this, the result of a move may not always be exactly what was specified.
    /// </summary>
    /// <param name="Vector">Object that defines the delta distance to move the sketch point.</param>
    [PreserveSig]
    void MoveBy([In] [MarshalAs(UnmanagedType.Interface)] Vector Vector);
    /// <summary>
    /// Method that moves the sketch point to an explicit x-y-z location. Movement of a sketch point is limited by the constraints currently defined on the sketch. If a sketch is partially constrained it will perform the move within the range allowed by the constraints. Because of this, the result of a move may not always be exactly what was specified.
    /// </summary>
    /// <param name="Point">Object that defines the new position of the sketch point.</param>
    [PreserveSig]
    void MoveTo([In] [MarshalAs(UnmanagedType.Interface)] Point Point);
}
