namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface SketchArc3DProxy
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object EndPoint { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object StartPoint { get; }
    /// <summary>
    /// Property that gets the that defines the position of the end of the arc.
    /// </summary>
    SketchPoint3D EndSketchPoint { get; }
    /// <summary>
    /// Property that gets the that defines the position of the start of the arc.
    /// </summary>
    SketchPoint3D StartSketchPoint { get; }
    /// <summary>
    /// Property that returns the center point of the arc.
    /// </summary>
    Point CenterPoint { get; }
    /// <summary>
    /// Gets and sets an Arc3d geometry object.&nbsp;The object returned represents a 'snapshot' view of the current state of the sketch arc.
    /// </summary>
    Arc3d Geometry { get; set; }
    /// <summary>
    /// Double property that returns the length of the entity in centimeters.
    /// </summary>
    double Length { get; }
    /// <summary>
    /// Specifies whether curvature information is displayed for the arc.
    /// </summary>
    bool CurvatureDisplay { get; set; }
    /// <summary>
    /// Gets the Radius of the arc.
    /// </summary>
    double Radius { get; }
    /// <summary>
    /// Gets the StartAngle of the arc.
    /// </summary>
    double StartAngle { get; }
    /// <summary>
    /// Gets the SweepAngle of the arc.
    /// </summary>
    double SweepAngle { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    SketchArc3D NativeObject { get; }
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
    void GetReferenceKey([In] [Out] [MarshalAs(UnmanagedType.SafeArray)] ref byte[] ReferenceKey, [In] int? KeyContext = default);
}
