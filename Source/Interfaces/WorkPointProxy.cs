namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface WorkPointProxy
{
    /// <summary>
    /// Specifies whether the work point is adaptive.
    /// </summary>
    bool Adaptive { get; set; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property returning the parent <link Inventor::ComponentDefinition, ComponentDefinition> object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Boolean property that returns whether the work point is a construction work point or not. A construction work point is hidden from the user and is not displayed graphically or listed in the browser. Some properties and methods of the WorkPoint object will behave differently for a construction work point. These are Adaptive, Name, and Visible.
    /// </summary>
    bool Construction { get; }
    /// <summary>
    /// Property that returns one of the work point definition objects. Which definition object returned will depend on how the work point is defined. The DefinitionType property can be used to determine the type of definition the Definition property will return.
    /// </summary>
    object Definition { get; }
    /// <summary>
    /// Property that returns the type of definition that is used to define the work axis. This can be kThreePlanesWorkPoint, kTwoLinesWorkPoint, kCurveAndEntityWorkPoint, kPointWorkPoint, kMidPointWorkPoint, kNonLinearEdgeWorkPoint, kCentroidWorkPoint, kFixedWorkPoint, kTorusCenterPointWorkPoint and kAssemblyWorkPoint.
    /// </summary>
    WorkPointDefinitionEnum DefinitionType { get; }
    /// <summary>
    /// Property that returns the collection of objects that have a direct dependency on the work point.
    /// </summary>
    ObjectCollection Dependents { get; }
    /// <summary>
    /// Property that returns the collection of objects that the work point is dependent on.
    /// </summary>
    ObjectCollection DrivenBy { get; }
    /// <summary>
    /// Gets/Sets the Boolean flag that specifies whether this work point is grounded or not.
    /// </summary>
    bool Grounded { get; set; }
    /// <summary>
    /// Specifies the name of the work point.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns a Point geometry object. The Point object returned provides information about the position of the work point.
    /// </summary>
    Point Point { get; }
    /// <summary>
    /// Specifies the visibility of the work point.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that returns the referenced WorkPoint in the case where this work point was created using a referenced component. An example of this is when a work point is selected as part of a derived part. The HasReferenceComponent property indicates if this work point is based on a referenced component or not. This property returns Nothing in the case where it is not based on a referenced component.
    /// </summary>
    WorkPoint ReferencedEntity { get; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Property that gets whether the work point was created by a pattern. If so, edits and delete are not allowed.
    /// </summary>
    bool IsPatternElement { get; }
    /// <summary>
    /// Gets and sets whether the work point is shared or not.
    /// </summary>
    bool Shared { get; set; }
    /// <summary>
    /// Gets whether the WorkPoint is consumed or not.
    /// </summary>
    bool Consumed { get; }
    /// <summary>
    /// Gets and sets whether the inputs to this feature should be nested under this feature in the browser.
    /// </summary>
    bool ConsumeInputs { get; set; }
    /// <summary>
    /// Property that returns whether this object is owned by a feature. If True, the OwnedBy property returns the owning feature.
    /// </summary>
    bool IsOwnedByFeature { get; }
    /// <summary>
    /// Read-only property that returns the client feature that owns this object.&nbsp;This property returns Nothing if the IsOwnedByFeature property returns False.
    /// </summary>
    PartFeature OwnedBy { get; }
    /// <summary>
    /// Property that indicates whether the work point belongs to a 3d sketch.
    /// </summary>
    bool IsParentSketch { get; }
    /// <summary>
    /// Property that returns the parent ComponentDefinition object.
    /// </summary>
    Sketch3D ParentSketch { get; }
    /// <summary>
    /// Property that returns whether the work point belongs to a coordinate system. If so, edits and delete are not allowed.
    /// </summary>
    bool IsCoordinateSystemElement { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the object is exported. Objects must be marked for export in order for them to be derived.
    /// </summary>
    bool Exported { get; set; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    WorkPoint NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that deletes the work point. Optionally the dependent objects will be deleted. This method will fail in the case where this object was created as a result of a derived part. The HasReferenceComponent property can be used to determine when this is the case.
    /// </summary>
    /// <param name="RetainDependents">Optional input Boolean that specifies whether any dependent objects should also be deleted. If True, no dependent objects will be deleted.</param>
    [PreserveSig]
    void Delete([In] bool? RetainDependents = false);
    /// <summary>
    /// Method that redefines the work point to be at the intersection of the three input planes.
    /// </summary>
    /// <param name="Plane1">Input object that represents a plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Plane2">Input object that represents a plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Plane3">Input object that represents a plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    [PreserveSig]
    void SetByThreePlanes([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane2, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane3);
    /// <summary>
    /// Method that redefines the work point to be at the intersection of the two input lines.
    /// </summary>
    /// <param name="Line1">Input object that represents a line. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.</param>
    /// <param name="Line2">Input object that represents a line. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.</param>
    [PreserveSig]
    void SetByTwoLines([In] [MarshalAs(UnmanagedType.IDispatch)] object Line1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Line2);
    /// <summary>
    /// Method that redefines a work point to be at the intersection of the input curve and an entity.
    /// </summary>
    /// <param name="Curve">Input object that represents a curve. This object can be an edge or a 2d or 3d sketch entity.</param>
    /// <param name="Entity">Input object that will be intersected with the curve. This object can be a face or a work plane. There is a current limitation that this must be a planar face or work plane when anything but a line is input as the curve. Any face can be used when the curve is a line.</param>
    /// <param name="ProximityPoint">Optional input Point object that indicates multiple solutions to use. For example, a circle can intersect a plane twice, or a spline can intersect multiple times. If this argument is supplied, the result closest to the input point will be used. If this argument is not supplied and multiple solutions are possible, one solution will be arbitrarily chosen.</param>
    [PreserveSig]
    void SetByCurveAndEntity([In] [MarshalAs(UnmanagedType.IDispatch)] object Curve, [In] [MarshalAs(UnmanagedType.IDispatch)] object Entity, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityPoint = default);
    /// <summary>
    /// Method that redefines the work point to be at the input point.
    /// </summary>
    /// <param name="Point">Input object that represents a point. This object can be a Vertex, SketchPoint, or SketchPoint3D object.</param>
    [PreserveSig]
    void SetByPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object Point);
    /// <summary>
    /// Method that redefines the work point to be at the midpoint of the input edge.
    /// </summary>
    /// <param name="Edge">Input Edge object. Any open edge is valid as input. Inputting a closed edge, (i.e. circle), will cause and error to occur.</param>
    [PreserveSig]
    void SetByMidPoint([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge);
    /// <summary>
    /// Method that redefines the work point to be at the position specified by the input point.
    /// </summary>
    /// <param name="Point">Input Point object.</param>
    [PreserveSig]
    void SetFixed([In] [MarshalAs(UnmanagedType.Interface)] Point Point);
    /// <summary>
    /// Method that redefines the work point to be at the center of the torus specified by the input face.
    /// </summary>
    /// <param name="Face">Input Face object whose geometry is a torus surface. An error occurs if the geometry of the input face is not a torus surface.</param>
    [PreserveSig]
    void SetByTorusCenterPoint([In] [MarshalAs(UnmanagedType.Interface)] Face Face);
    /// <summary>
    /// Redefines the work point to be at the center of the Sphere specified by the input face.
    /// </summary>
    /// <param name="Face">Input Face object whose geometry is a spherical surface.  An error occurs if the geometry of the input face is not a spherical surface</param>
    [PreserveSig]
    void SetBySphereCenterPoint([In] [MarshalAs(UnmanagedType.Interface)] Face Face);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
    /// <summary>
    /// Method that repositions the end-of-part marker relative to the object this method is called from. The argument defines if the end-of-part marker will be positioned just before or just after the object. If the object is contained within another object and is not in the top level of the browser, the positioning of the marker will be relative to the top-level object the calling object is contained within. An example of this case is a sketch that has not been shared and has been consumed by a feature. Another example is a nested work feature.
    /// </summary>
    /// <param name="Before">Input Boolean that indicates if the end of part marker should be immediately before or after this work feature. A value of True indicates before and False indicates after.</param>
    [PreserveSig]
    void SetEndOfPart([In] bool Before);
    /// <summary>
    /// Method that redefines a work point to be located at the centroid of the input entities.
    /// </summary>
    /// <param name="Entities">Input object that specifies the entities. This can be an Edge, an EdgeLoop object or an EdgeCollection containing one or more edges. If an EdgeCollection is input, the collection must contain connected edges. If isolated edges appear in the collection, the method will fail.</param>
    [PreserveSig]
    void SetAtCentroid([In] [MarshalAs(UnmanagedType.IDispatch)] object Entities);
}
