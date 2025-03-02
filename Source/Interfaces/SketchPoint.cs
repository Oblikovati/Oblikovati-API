namespace Oblikovati.API;

/// <summary>
/// The SketchPoint object represents a point within a sketch. See the article in the overviews section.
/// </summary>
public interface SketchPoint
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
    Sketch Parent { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the object this entity is dependent on. When sketch entities are created by projecting model edges or intersecting the model, the resulting entities are driven by the original model entities and cannot be modified.
    /// </summary>
    object ReferencedEntity { get; }
    /// <summary>
    /// Property that returns a Box2D object which contains the lower-left and upper-right corners of a rectangle that is guaranteed to enclose this object.
    /// </summary>
    Box2d RangeBox { get; }
    /// <summary>
    /// Property that returns a collection of sketch constraints that are tied directly to this entity. This collection consists of both geometric and dimension constraints.
    /// </summary>
    SketchConstraintsEnumerator Constraints { get; }
    /// <summary>
    /// Gets and sets whether this entity is a reference entity or not. It is only valid to set this property to False.
    /// </summary>
    bool Reference { get; set; }
    /// <summary>
    /// Gets and sets whether the entity behaves as a construction entity or not.
    /// </summary>
    bool Construction { get; set; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Gets and sets whether specific user actions are blocked on this sketch geometry.
    /// </summary>
    ActionTypeEnum DisabledActionTypes { get; set; }
    /// <summary>
    /// Read-only property that returns the constraint status of the sketch.&nbsp;Possible return values are kFullyConstrainedConstraintStatus, kOverConstrainedConstraintStatus, kUnderConstrainedConstraintStatus, and kUnknownConstraintStatus.
    /// </summary>
    ConstraintStatusEnum ConstraintStatus { get; }
    /// <summary>
    /// Gets and sets the layer applied to this sketch entity.
    /// </summary>
    Layer Layer { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    GeometryMoveableStatusEnum _GeometryMoveableStatus { get; }
    /// <summary>
    /// Indicates entity or entities that own this object.
    /// </summary>
    SketchEntitiesEnumerator OwnedBy { get; }
    /// <summary>
    /// Gets and sets whether this entity is visible only when editing the sketch.
    /// </summary>
    bool SketchOnly { get; set; }
    /// <summary>
    /// Property that returns the sketch block that contains this object. This is the same SketchBlock returned as the last item in the SketchBlockPath property. This property returns Nothing if this object does not belong to a sketch block and lives directly under a sketch.
    /// </summary>
    SketchBlock ContainingSketchBlock { get; }
    /// <summary>
    /// Property that returns the path of sketch blocks at the leaf of which this sketch object is found. The enumerator returns a count of 0 if the object lives directly under a sketch.
    /// </summary>
    SketchBlocksEnumerator SketchBlockPath { get; }
    /// <summary>
    /// Property that returns a Point2d geometry object. The object returned represents a snapshot view of the current state of the sketch point.
    /// </summary>
    Point2d Geometry { get; }
    /// <summary>
    /// Property that returns the collection of objects that are connected to this point.
    /// </summary>
    SketchEntitiesEnumerator AttachedEntities { get; }
    /// <summary>
    /// Gets and sets whether the point behaves as a hole center or not.
    /// </summary>
    bool HoleCenter { get; set; }
    /// <summary>
    /// Gets and sets whether the point behaves as an insertion point or not.
    /// </summary>
    bool InsertionPoint { get; set; }
    /// <summary>
    /// Gets and sets whether the point behaves as a connection point or not.
    /// </summary>
    bool ConnectionPoint { get; set; }
    /// <summary>
    /// Read-only property that returns point geometry that represents this point in model space.
    /// </summary>
    Point Geometry3d { get; }
    /// <summary>
    /// Method that deletes the sketch entity. This method will fail in the case where this object was created as a result of a derived part. The HasReferenceComponent property can be used to determine when this is the case.
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
    /// Method that moves the sketch point to an explicit X-Y location. Movement of a sketch point is limited by the constraints currently defined on the sketch. If a sketch is partially constrained it will perform the move within the range allowed by the constraints. Because of this, the result of a move may not always be exactly what was specified.
    /// </summary>
    /// <param name="Point">Input object that defines the new position of the sketch point.</param>
    [PreserveSig]
    void MoveTo([In] [MarshalAs(UnmanagedType.Interface)] Point2d Point);
    /// <summary>
    /// Method that moves the sketch point a delta distance from its current location. Movement of a sketch point is limited by the constraints currently defined on the sketch. If a sketch is partially constrained it will perform the move within the range allowed by the constraints. Because of this, the result of a move may not always be exactly what was specified.
    /// </summary>
    /// <param name="Vector">Input Vector2d object that defines the delta distance to move the sketch point.</param>
    [PreserveSig]
    void MoveBy([In] [MarshalAs(UnmanagedType.Interface)] Vector2d Vector);
    /// <summary>
    /// Method that merges this sketch point with the input sketch point. Any objects dependent on this sketch point will change their dependency to the new sketch point.
    /// </summary>
    /// <param name="SketchPoint">Input SketchPoint object.</param>
    [PreserveSig]
    void Merge([In] [MarshalAs(UnmanagedType.Interface)] SketchPoint SketchPoint);
}
