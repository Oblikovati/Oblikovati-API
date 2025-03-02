namespace Oblikovati.API;

/// <summary>
/// Represents a work axis. See here for an overview.
/// </summary>
public interface WorkAxis
{
    /// <summary>
    /// Specifies whether the work axis is adaptive.
    /// </summary>
    bool Adaptive { get; set; }
    /// <summary>
    /// Property returning the parent <link Inventor::ComponentDefinition, ComponentDefinition> object.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Boolean property that returns whether the work axis is a construction work axis or not. A construction work axis is hidden from the user and is not displayed graphically or listed in the browser. Some properties and methods of the WorkAxis object will behave differently for a construction work axis. These are Adaptive, Name, and Visible.
    /// </summary>
    bool Construction { get; }
    /// <summary>
    /// Property that returns one of the work axis definition objects. Which definition object returned will depend on how the work axis is defined. The DefinitionType property can be used to determine the type of definition the Definition property will return.
    /// </summary>
    object Definition { get; }
    /// <summary>
    /// Property that returns the type of definition that is used to define the work axis. This can be kLineWorkAxis, kTwoPlanesWorkAxis, kTwoPointsWorkAxis, kRevolvedFaceWorkAxis, kNormalToSurfaceWorkAxis, kLineAndPlaneWorkAxis, kLineAndPointWorkAxis, kAnalyticEdgeWorkAxis, kFixedWorkAxis, or kAssemblyWorkAxis.
    /// </summary>
    WorkAxisDefinitionEnum DefinitionType { get; }
    /// <summary>
    /// Property that returns the collection of objects that have a direct dependency on the work axis.
    /// </summary>
    ObjectCollection Dependents { get; }
    /// <summary>
    /// Property that returns the collection of objects that the work axis is dependent on.
    /// </summary>
    ObjectCollection DrivenBy { get; }
    /// <summary>
    /// Gets/Sets the Boolean flag that specifies whether this work axis is grounded or not.
    /// </summary>
    bool Grounded { get; set; }
    /// <summary>
    /// Specifies the name of the work axis.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Property that returns a Line geometry. The Line object returned provides information about the position and direction of the work axis.
    /// </summary>
    Line Line { get; }
    /// <summary>
    /// Specifies the visibility of the work axis.
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
    /// Property indicating the object this entity is dependent on.
    /// </summary>
    WorkAxis ReferencedEntity { get; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Property that gets whether the work axis was created by a pattern. If so, edits and delete are not allowed.
    /// </summary>
    bool IsPatternElement { get; }
    /// <summary>
    /// Gets and sets whether the work axis is shared or not.
    /// </summary>
    bool Shared { get; set; }
    /// <summary>
    /// Gets whether the WorkAxis is consumed or not.
    /// </summary>
    bool Consumed { get; }
    /// <summary>
    /// Gets and sets whether the inputs to this feature should be nested under this feature in the browser.
    /// </summary>
    bool ConsumeInputs { get; set; }
    /// <summary>
    /// Property that indicates whether the work axis belongs to a 3d sketch.
    /// </summary>
    bool IsParentSketch { get; }
    /// <summary>
    /// Property that returns the parent ComponentDefinition object.
    /// </summary>
    Sketch3D ParentSketch { get; }
    /// <summary>
    /// Gets or sets whether this work axis should be resized automatically based on the component size.
    /// </summary>
    bool AutoResize { get; set; }
    /// <summary>
    /// Property that returns whether this object is owned by a feature. If True, the OwnedBy property returns the owning feature.
    /// </summary>
    bool IsOwnedByFeature { get; }
    /// <summary>
    /// Read-only property that returns the client feature that owns this object.&nbsp;This property returns Nothing if the IsOwnedByFeature property returns False.
    /// </summary>
    PartFeature OwnedBy { get; }
    /// <summary>
    /// Property that returns whether the work axis belongs to a coordinate system. If so, edits and delete are not allowed.
    /// </summary>
    bool IsCoordinateSystemElement { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the object is exported. Objects must be marked for export in order for them to be derived.
    /// </summary>
    bool Exported { get; set; }
    /// <summary>
    /// Method that deletes the work axis. Optionally the dependent objects will be deleted. This method will fail in the case where this object was created as a result of a derived part. The HasReferenceComponent property can be used to determine when this is the case.
    /// </summary>
    /// <param name="RetainDependents">Optional input Boolean that specifies whether any dependent objects should also be deleted. If True, no dependent objects will be deleted. This argument is ignored in the case of an assembly work plane.</param>
    [PreserveSig]
    void Delete([In] bool? RetainDependents = false);
    /// <summary>
    /// Method that redefines the work axis to be based on the input line. This method is not valid when the work axis exists in an Assembly component definition.
    /// </summary>
    /// <param name="Line">Input object that represents a line. This object can be a linear Edge, SketchLine, or SketchLine3D object.</param>
    [PreserveSig]
    void SetByLine([In] [MarshalAs(UnmanagedType.IDispatch)] object Line);
    /// <summary>
    /// Method that redefines the work axis to be at the intersection of the two input planes.
    /// </summary>
    /// <param name="Plane1">Input object that represents a plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    /// <param name="Plane2">Input object that represents a plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    [PreserveSig]
    void SetByTwoPlanes([In] [MarshalAs(UnmanagedType.IDispatch)] object Plane1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane2);
    /// <summary>
    /// Method that redefines the work axis to go between the two input points.
    /// </summary>
    /// <param name="Point1">Input object that represents a point. This object can be a WorkPoint, Vertex, SketchPoint, or SketchPoint3D object.</param>
    /// <param name="Point2">Input object that represents a point. This object can be a WorkPoint, Vertex, SketchPoint, or SketchPoint3D object.</param>
    [PreserveSig]
    void SetByTwoPoints([In] [MarshalAs(UnmanagedType.IDispatch)] object Point1, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point2);
    /// <summary>
    /// Method that redefines the work axis to be at the axis of the input revolved face.
    /// </summary>
    /// <param name="Face">Input Face whose geometry is a revolved surface. Valid surface types include cylinders, cones, and toroids.</param>
    [PreserveSig]
    void SetByRevolvedFace([In] [MarshalAs(UnmanagedType.Interface)] Face Face);
    /// <summary>
    /// Method that redefines the work axis so that it is along a line defined by projecting the input line onto the input plane along the plane normal.
    /// </summary>
    /// <param name="Line">Input object that represents a line. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.</param>
    /// <param name="Plane">Input object that represents a plane. This object can be a planar Face, WorkPlane, or Sketch object.</param>
    [PreserveSig]
    void SetByLineAndPlane([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] [MarshalAs(UnmanagedType.IDispatch)] object Plane);
    /// <summary>
    /// Method that redefines the work axis so it passes through the input point in the direction of the input vector.
    /// </summary>
    /// <param name="Point">Input Point object.</param>
    /// <param name="Axis">Input UnitVector object.</param>
    [PreserveSig]
    void SetFixed([In] [MarshalAs(UnmanagedType.Interface)] Point Point, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Axis);
    /// <summary>
    /// Method that redefines the work axis to be based on the input edge.
    /// </summary>
    /// <param name="Edge">Input Edge object that can be a circle, arc, or an ellipse.</param>
    [PreserveSig]
    void SetByAnalyticEdge([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge);
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
    /// Method that redefines the work axis so that it is parallel to a line and passes through the input point.
    /// </summary>
    /// <param name="Line">Input object that represents a line. This object can be a linear Edge, WorkAxis, SketchLine, or SketchLine3D object.</param>
    /// <param name="Point">Input object that represents a point. This object can be a Vertex, WorkPoint, SketchPoint, or SketchPoint3D object.</param>
    [PreserveSig]
    void SetByLineAndPoint([In] [MarshalAs(UnmanagedType.IDispatch)] object Line, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point);
    /// <summary>
    /// Method that redefines the work axis to pass through the input point and be normal to the input surface.
    /// </summary>
    /// <param name="Surface">Input object that represents a surface entity. This object can be a Face (planar or non-planar), a WorkPlane or a PlanarSketch object.</param>
    /// <param name="Point">Input object that represents a point. This object can be a WorkPoint, Vertex, SketchPoint, or SketchPoint3D object.</param>
    [PreserveSig]
    void SetByNormalToSurface([In] [MarshalAs(UnmanagedType.IDispatch)] object Surface, [In] [MarshalAs(UnmanagedType.IDispatch)] object Point);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point1">Point1</param>
    /// <param name="Point2">Point2</param>
    [PreserveSig]
    void GetSize([Out] [MarshalAs(UnmanagedType.Interface)] out Point Point1, [Out] [MarshalAs(UnmanagedType.Interface)] out Point Point2);
    /// <summary>
    /// Method that sets the current size of the displayed graphics for the work axis.
    /// </summary>
    /// <param name="Point1">Input Point object that defines the first end point of the work axis.</param>
    /// <param name="Point2">Input Point object that defines the other end point of the work axis.</param>
    [PreserveSig]
    void SetSize([In] [MarshalAs(UnmanagedType.Interface)] Point Point1, [In] [MarshalAs(UnmanagedType.Interface)] Point Point2);
}
