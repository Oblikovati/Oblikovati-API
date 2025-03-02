namespace Oblikovati.API;

/// <summary>
/// This is an assembly-context proxy object derived from its native definition-context object.
/// </summary>
public interface PlanarSketchProxy
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the object through which this sketch's data content can be persisted.
    /// </summary>
    DataIO DataIO { get; }
    /// <summary>
    /// Gets and sets name of the sketch.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets and sets the visibility of the sketch.
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Property that returns the collection of all geometric constraints on the sketch.
    /// </summary>
    GeometricConstraints GeometricConstraints { get; }
    /// <summary>
    /// Gets the collection of all dimension constraints on the sketch.
    /// </summary>
    DimensionConstraints DimensionConstraints { get; }
    /// <summary>
    /// Property that returns the collection of all entities on the sketch, regardless of their type.
    /// </summary>
    SketchEntitiesEnumerator SketchEntities { get; }
    /// <summary>
    /// Property that returns the SketchArcs collection object.
    /// </summary>
    SketchArcs SketchArcs { get; }
    /// <summary>
    /// Property that returns the SketchLines collection object. This collection provides access to the existing lines in the sketch and provides functionality to create new lines.
    /// </summary>
    SketchLines SketchLines { get; }
    /// <summary>
    /// Property that returns the SketchPoints collection object.
    /// </summary>
    SketchPoints SketchPoints { get; }
    /// <summary>
    /// Property that returns the SketchSplines collection object.
    /// </summary>
    SketchSplines SketchSplines { get; }
    /// <summary>
    /// Property that returns the collection object. This collection provides access to the existing offset splines in the sketch.
    /// </summary>
    SketchOffsetSplines SketchOffsetSplines { get; }
    /// <summary>
    /// Property that returns the SketchEllipses collection object.
    /// </summary>
    SketchEllipses SketchEllipses { get; }
    /// <summary>
    /// Property that returns the SketchEllipticalArcs collection object.
    /// </summary>
    SketchEllipticalArcs SketchEllipticalArcs { get; }
    /// <summary>
    /// Property that returns the SketchArcs collection object.
    /// </summary>
    SketchCircles SketchCircles { get; }
    /// <summary>
    /// Gets the TextBoxes collection associated with this Sketch.
    /// </summary>
    TextBoxes TextBoxes { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Property that gets the collection object.
    /// </summary>
    SketchFixedSplines SketchFixedSplines { get; }
    /// <summary>
    /// Gets and sets the action types valid for this sketch.
    /// </summary>
    ActionTypeEnum DisabledActionTypes { get; set; }
    /// <summary>
    /// Property that returns an enum indicating the constraint status of the sketch entity, signifying whether it is fully constrained, over constrained, or under constrained.
    /// </summary>
    ConstraintStatusEnum ConstraintStatus { get; }
    /// <summary>
    /// Gets and Sets whether to defer the solving of the sketch or not.
    /// </summary>
    bool DeferUpdates { get; set; }
    /// <summary>
    /// Property that returns a collection of all images on the sketch.
    /// </summary>
    SketchImages SketchImages { get; }
    /// <summary>
    /// Gets and Sets the color for the sketch.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Gets and Sets the line type override for the sketch.
    /// </summary>
    LineTypeEnum LineType { get; set; }
    /// <summary>
    /// Gets and Sets the line weight override for the sketch.
    /// </summary>
    double LineWeight { get; set; }
    /// <summary>
    /// Read-only property that returns the SketchControlPointSplines collection object.&nbsp;This collection provides access to the existing control point splines in the sketch and provides functionality to create new control point splines.
    /// </summary>
    SketchControlPointSplines SketchControlPointSplines { get; }
    /// <summary>
    /// Read-only property that returns the SketchEquationCurves collection object.&nbsp;This collection provides access to the existing equation curves in the sketch and provides functionality to create new equation curves.
    /// </summary>
    SketchEquationCurves SketchEquationCurves { get; }
    /// <summary>
    /// Gets and sets whether the sketch is adaptive or not.
    /// </summary>
    bool Adaptive { get; set; }
    /// <summary>
    /// Gets and sets whether the profile is shared or not.
    /// </summary>
    bool Shared { get; set; }
    /// <summary>
    /// Gets and sets the planar object that defines the planar object the sketch is to be built on.
    /// </summary>
    object PlanarEntity { get; set; }
    /// <summary>
    /// Property that returns the geometry that describes the plane the sketch is based on.
    /// </summary>
    Plane PlanarEntityGeometry { get; }
    /// <summary>
    /// Gets and sets the object that defines the X or Y axis of the sketch plane.&nbsp;The AxisIsX property defines whether it is the X or Y axis, and the NaturalAxisDirection property defines the direction of the axis.
    /// </summary>
    object AxisEntity { get; set; }
    /// <summary>
    /// Property that gets the geometry that describes the axis entity.
    /// </summary>
    Line AxisEntityGeometry { get; }
    /// <summary>
    /// Gets and sets if the sketch plane X or Y axis is in the same direction as that defined by axis entity.&nbsp;True indicates the axis direction is in the same direction as the axis.
    /// </summary>
    bool NaturalAxisDirection { get; set; }
    /// <summary>
    /// Gets and sets if the axis entity defines the X or Y axis.&nbsp;True indicates the axis defines the X-axis.
    /// </summary>
    bool AxisIsX { get; set; }
    /// <summary>
    /// Gets and sets origin of the sketch. When set this property, the valid object can be a WorkPoint, Vertex or SketchPoint.
    /// </summary>
    object OriginPoint { get; set; }
    /// <summary>
    /// Property that gets the geometry that describes the origin point.
    /// </summary>
    Point OriginPointGeometry { get; }
    /// <summary>
    /// Property that returns the transformation from model space to the 2d sketch coordinate space.
    /// </summary>
    Matrix ModelToSketchTransform { get; }
    /// <summary>
    /// Property that returns the transformation from the 2D sketch coordinate space to model space.
    /// </summary>
    Matrix SketchToModelTransform { get; }
    /// <summary>
    /// Gets the dependent objects of the sketch.
    /// </summary>
    ObjectsEnumerator Dependents { get; }
    /// <summary>
    /// Property that returns the Profiles collection object.
    /// </summary>
    Profiles Profiles { get; }
    /// <summary>
    /// Property that returns the referenced sketch in the cases where this sketch was created as a result of a "derive" operation or copied over to the sheet metal flat pattern from the folded model.
    /// </summary>
    PlanarSketch ReferencedEntity { get; }
    /// <summary>
    /// Property that specifies if the object was created as the result of a derived part.
    /// </summary>
    bool HasReferenceComponent { get; }
    /// <summary>
    /// Property that returns the ReferenceComponent that resulted in the creation of this feature.
    /// </summary>
    ReferenceComponent ReferenceComponent { get; }
    /// <summary>
    /// Gets whether the sketch is consumed or not.
    /// </summary>
    bool Consumed { get; }
    /// <summary>
    /// Gets and sets whether the dimensions on the sketch are visible.
    /// </summary>
    bool DimensionsVisible { get; set; }
    /// <summary>
    /// Property that returns an enum indicating the current state of the object.
    /// </summary>
    HealthStatusEnum HealthStatus { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool VisibleBelowEndOfPart { get; set; }
    /// <summary>
    /// Property that returns whether this object is owned by a feature. This property should return True for sketches that are created as a result of an unfold or refold feature.
    /// </summary>
    bool IsOwnedByFeature { get; }
    /// <summary>
    /// Property that returns the PartFeature object. This property should return the UnfoldFeature or RefoldFeature object that created the sketch.
    /// </summary>
    PartFeature OwnedBy { get; }
    /// <summary>
    /// Property that returns the ProjectedCuts collection object. This collection provides access to the existing projected cut edges in the sketch and provides functionality to create new projected cut edges.
    /// </summary>
    ProjectedCuts ProjectedCuts { get; }
    /// <summary>
    /// Property that returns the SketchBlocks collection object. Only the first level sketch blocks in the sketch are returned. Use SketchBlock.ChildBlocks property recursively to get sketch blocks at all levels.
    /// </summary>
    SketchBlocks SketchBlocks { get; }
    /// <summary>
    /// Read-write property that gets and sets whether the object is exported. Objects must be marked for export in order for them to be derived.
    /// </summary>
    bool Exported { get; set; }
    /// <summary>
    /// Gets and sets whether a sheet metal folded model sketch should be copied over (transposed) to the flat pattern.
    /// </summary>
    bool CopyToFlatPattern { get; set; }
    /// <summary>
    /// Gets sketch checksum value.
    /// </summary>
    int CheckSumValue { get; }
    /// <summary>
    /// Gets the object in the context of the definition instead of the containing assembly.
    /// </summary>
    PlanarSketch NativeObject { get; }
    /// <summary>
    /// Property that returns the ComponentOccurrence that the native object is being referenced through. The returned occurrence is the containing occurrence.
    /// </summary>
    ComponentOccurrence ContainingOccurrence { get; }
    /// <summary>
    /// Method that causes the Sketch environment to be invoked with this sketch available for interactive edit.
    /// </summary>
    [PreserveSig]
    void Edit();
    /// <summary>
    /// Causes the Sketch environment to be closed and the user interface to return to the previous environment. This is equivalent to the Return command. This method is only valid in the case where this sketch is open for edit within the user interface.
    /// </summary>
    [PreserveSig]
    void ExitEdit();
    /// <summary>
    /// Method that deletes the sketch. This method is only valid for sketches that are not used by a feature.
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
    /// Method that moves a collection of sketch objects by a specified vector. If the Copy argument is set to True, the newly created objects are returned.
    /// </summary>
    /// <param name="SketchObjects">Input ObjectCollection that contains the sketch elements to move. The collection must contain at least one object and can be any SketchEntity, a TextBox or an Image.</param>
    /// <param name="Vector">Input Vector2d object that defines the delta distance to move the sketch elements.</param>
    /// <param name="Copy">Optional input Boolean that specifies whether to copy the sketch elements to the new location or to move them. If not specified, a default value of False is used indicating that the elements will be moved.</param>
    /// <param name="RemoveConstraints">Optional input Boolean that specifies whether to remove or retain some of the constraints that constrain the input sketch entities to other geometry. If not specified, a default value of False is used indicating that the constraints will be retained.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator MoveSketchObjects([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SketchObjects, [In] [MarshalAs(UnmanagedType.Interface)] Vector2d Vector, [In] bool? Copy = false, [In] bool? RemoveConstraints = false);
    /// <summary>
    /// Method that rotates a collection of sketch objects by a specified angle. If the Copy argument is set to True, the newly created objects are returned.
    /// </summary>
    /// <param name="SketchObjects">Input ObjectCollection that contains the sketch elements to rotate. The collection must contain at least one object and can be any SketchEntity, a TextBox or an Image.</param>
    /// <param name="CenterPoint">Input Point2d object that defines the center point to rotate the elements about.</param>
    /// <param name="Angle">Input Double that defines the angle to rotate the elements by in radians.</param>
    /// <param name="Copy">Optional input Boolean that specifies whether to copy the sketch elements to the new location or to rotate them. If not specified, a default value of False is used indicating that the elements will be rotated.</param>
    /// <param name="RemoveConstraints">Optional input Boolean that specifies whether to remove or retain some of the constraints that constrain the input sketch entities to other geometry. If not specified, a default value of False is used indicating that the constraints will be retained.</param>
    /// <returns></returns>
    [PreserveSig]
    ObjectsEnumerator RotateSketchObjects([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SketchObjects, [In] [MarshalAs(UnmanagedType.Interface)] Point2d CenterPoint, [In] double Angle, [In] bool? Copy = false, [In] bool? RemoveConstraints = false);
    /// <summary>
    /// Method that causes the sketch to solve.
    /// </summary>
    [PreserveSig]
    void Solve();
    /// <summary>
    /// Method that offsets a sketch entity or a group of connected sketch entities. In both cases, the base sketch entity is first offset by the specified distance and along the specified direction. The base sketch entity is determined as follows: 	*	If only one sketch entity needs to be offset, it will be treated as the base sketch entity. 	*	If a group of end-to-end connected entities need to be offset, the first entity in the group will be treated as the base sketch entity. If this method successfully offsets the specified input sketch entities, the newly created sketch entities are returned.
    /// </summary>
    /// <param name="SketchEntities">ObjectCollection that specifies either a single sketch entity or a set of sketch entities that need to be offset. The collection can contain any SketchEntity object except SketchPoint because sketch points cannot be offset. The first entity in the collection is always treated as the base sketch entity. The offset distance (OffsetDistance argument) and the offset direction (NaturalOffsetDirection argument) apply to this base sketch entity. If only one sketch entity needs to be offset, then it should be specified as the only item in the collection and the IncludeConnectedEntities argument should be specified as False. Since the entity specified in the collection is the first and only item in the collection, it will be treated as the base sketch entity. If a group of end-to-end connected sketch entities need to be offset, then they can be specified using one of the following options: 	*	Specifying an exact set of sketch entities to offset. The collection can be used to specify an exact set of sketch entities that need to be offset. The objects in the collection must represent entities that are end-to-end connected and the collection must contain the objects in the order that they are connected. The first entity specified in the collection will be treated as the base sketch entity. 	*	Specifying only the base sketch entity and automatically including connected entities. The base sketch entity should be specified as the only item in the collection. The IncludeConnectedEntities boolean argument should be specified as True to indicate that all entities that form a loop (open or closed) which contains the base sketch entity should be automatically included to be offset. Since only one of the above options to specify a group of connected entities can be used at the same time and not both, if the collection contains multiple entities, it implies that the collection is being used to explicitly specify an exact set of sketch entities to offset, in which case the IncludeConnectedEntities argument should be False. If True is specified, the method will fail and the sketch entities will not be offset.</param>
    /// <param name="OffsetDistance">Specifies the offset distance for the base sketch entity (the sketch entity specified by the first item in the SketchEntities collection). Since a group of connected entities that need to be offset will all be offset by the same distance, it implies that the distance value specified by this argument will be used not only for the base sketch entity but also for all the remaining connected sketch entities. Since the offset of the base sketch entity can lie on either side of the base entity, the offset distance in itself does not provide sufficient information regarding the final position for the offset of the base sketch entity. The NaturalOffsetDirection boolean argument can be used to specify one out of the two possible offset directions for the base sketch entity. Thus, the offset distance specified by this argument and the offset direction specified by the NaturalOffsetDirection boolean argument together determine the final position for the offset of the base sketch entity. Once the offset position for the base sketch entity is determined, the offset positions for any other additional connected sketch entities can be inferred.</param>
    /// <param name="NaturalOffsetDirection">Value that can be used to specify one out of the two possible offset directions. This argument applies to the base sketch entity (the sketch entity specified by the first item in the SketchEntities collection). The natural offset direction is along the natural normal direction at any point on the base sketch entity which in-turn is defined as the cross-product of the vector representing the tangent at that point and the vector representing the sketch normal. If True is specified, then the points on the offset of the base sketch entity will be positioned in the direction specified by the natural normal at the corresponding points on the original base sketch entity. If False is specified, then the offset of the base sketch entity will be positioned in the direction opposite to that of the natural normal. Thus, this argument determines on which side of the base sketch entity the offset of the base sketch entity will be placed. Since this argument specifies only the offset direction, the OffsetDistance argument has to be used to specify the offset distance along the offset direction specified by this argument. Thus, the offset direction specified by this argument and the offset distance specified by the OffsetDistance argument together determine the final position for the offset of the base sketch entity. Once the offset position for the base sketch entity is determined, the offset positions for any other additional connected sketch entities can be inferred.</param>
    /// <param name="IncludeConnectedEntities">Value that specifies whether all entities that form a loop containing the base sketch entity should also be offset. If True is specified, then all loop entities will be offset. But, if the sketch has multiple loops that contain the base sketch entity in which case it will not be possible to uniquely determine a single loop that needs to be offset, only the base sketch entity will be offset. If False is specified, then only the entities specified in the SketchEntities collection will be offset. If True is specified, the SketchEntities collection should contain only one item that corresponds to the base sketch entity, otherwise, if the SketchEntities collection contains multiple entities, then this method will fail and the sketch entities will not be offset. If False is specified, the SketchEntities collection can contain either a single item that corresponds to the base sketch entity or multiple items that correspond to a group of end-to-end connected entities. If the collection contains a single item that corresponds to the base sketch entity, then only this base sketch entity will be offset. On the other hand, if the collection contains multiple items, it implies that the collection is being used to specify an exact set of sketch entities to offset, hence, only those exact set of sketch entities will be offset. If no value is specified for this argument, then a default value of False will be assumed.</param>
    /// <param name="CreateOffsetConstraints">Value that specifies whether offset constraints between the original and offset entities should be automatically created. If True is specified, then offset constraints will be automatically created. If False is specified, then offset constraints will not be created. If no value is specified, then a default value of True will be assumed to indicate that the offset constraints will be automatically created.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator OffsetSketchEntitiesUsingDistance([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SketchEntities, [In] double OffsetDistance, [In] bool NaturalOffsetDirection, [In] bool? IncludeConnectedEntities = false, [In] bool? CreateOffsetConstraints = true);
    /// <summary>
    /// Method that offsets a sketch entity or a group of end-to-end connected sketch entities. In both cases, the offset is first applied to the base sketch entity such that the offset of the base sketch entity passes through the specified offset point on the sketch. The shortest distance of this offset point from the original base sketch entity determines the offset distance.
    /// </summary>
    /// <param name="SketchEntities">ObjectCollection that specifies either a single sketch entity or a set of sketch entities that need to be offset. The collection can contain any SketchEntity object except SketchPoint because sketch points cannot be offset. The first entity in the collection is always treated as the base sketch entity. The offset distance (OffsetDistance argument) and the offset direction (NaturalOffsetDirection argument) apply to this base sketch entity. If only one sketch entity needs to be offset, then it should be specified as the only item in the collection and the IncludeConnectedEntities argument should be specified as False. Since the entity specified in the collection is the first and only item in the collection, it will be treated as the base sketch entity. If a group of end\-to\-end connected sketch entities need to be offset, then they can be specified using one of the following options\: * Specifying an exact set of sketch entities to offset. The collection can be used to specify an exact set of sketch entities that need to be offset. The objects in the collection must represent entities that are end-to-end connected and the collection must contain the objects in the order that they are connected. The first entity specified in the collection will be treated as the base sketch entity. * Specifying only the base sketch entity and automatically including connected entities. The base sketch entity should be specified as the only item in the collection. The IncludeConnectedEntities boolean argument should be specified as True to indicate that all entities that form a loop (open or closed) which contains the base sketch entity should be automatically included to be offset.
    /// Since only one of the above options to specify a group of connected entities can be used at the same time and not both, if the collection contains multiple entities, it implies that the collection is being used to explicitly specify an exact set of sketch entities to offset, in which case the IncludeConnectedEntities argument should be False. If True is specified, the method will fail and the sketch entities will not be offset.</param>
    /// <param name="OffsetPoint">Defines a point on the sketch through which the offset of the base sketch entity (the sketch entity specified by the first item in the SketchEntities collection) should pass. The shortest distance of this point from the base sketch entity is used to determine the offset distance. This offset distance will also be used to offset any other additional connected sketch entities. The location of the point with respect to the base sketch entity determines the position of the offset base sketch entity (i.e. the location of the point determines on which side of the base sketch entity the offset of the base sketch entity will be positioned). Once the offset distance and position for the offset of the base sketch entity are determined, this information is used to determine the position for all other connected sketch entities that need to be offset. Thus, the offset point provides sufficient information to calculate the offset distance as well as the offset direction for all the sketch entities that need to be offset.</param>
    /// <param name="IncludeConnectedEntities">Value that specifies whether all entities that form a loop containing the base sketch entity should also be offset. If True is specified, then all loop entities will be offset. But, if the sketch has multiple loops that contain the base sketch entity in which case it will not be possible to uniquely determine a single loop that needs to be offset, only the base sketch entity will be offset. If False is specified, then only the entities specified in the SketchEntities collection will be offset. If True is specified, the SketchEntities collection should contain only one item that corresponds to the base sketch entity, otherwise, if the SketchEntities collection contains multiple entities, then this method will fail and the sketch entities will not be offset. If False is specified, the SketchEntities collection can contain either a single item that corresponds to the base sketch entity or multiple items that correspond to a group of end\-to\-end connected entities. If the collection contains a single item that corresponds to the base sketch entity, then only this base sketch entity will be offset. On the other hand, if the collection contains multiple items, it implies that the collection is being used to specify an exact set of sketch entities to offset, hence, only those exact set of sketch entities will be offset. If no value is specified for this argument, then a default value of False will be assumed.</param>
    /// <param name="CreateOffsetConstraints">Value that specifies whether offset constraints between the original and offset entities should be automatically created. If True is specified, then offset constraints will be automatically created. If False is specified, then offset constraints will not be created. If no value is specified, then a default value of True will be assumed to indicate that the offset constraints will be automatically created.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator OffsetSketchEntitiesUsingPoint([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SketchEntities, [In] [MarshalAs(UnmanagedType.Interface)] Point2d OffsetPoint, [In] bool? IncludeConnectedEntities = false, [In] bool? CreateOffsetConstraints = true);
    /// <summary>
    /// Method that creates a new sketch entity by projecting other entities onto the sketch plane. This method performs the same function as the Project Geometry or Project DWG Geometry command according to the Entity you specified.
    /// </summary>
    /// <param name="Entity">Input object to project onto the sketch plane. In a part context, valid input includes the various 2d sketch objects, the various 3d sketch objects, Edge, Vertex, WorkAxis, WorkPoints and DWGEntities. WorkPlanes that are perpendicular to the sketch are also valid. In an assembly context (where this method is called on a PlanarSketchProxy object) this method that projects an entity from one part into a sketch in another part. The valid input in this case includes the various 2d sketch proxy objects, the various 3d sketch proxy objects, EdgeProxy, VertexProxy, WorkAxisProxy, and WorkPointProxy objects. WorkPlaneProxy objects that are perpendicular to the sketch are also valid.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntity AddByProjectingEntity([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="LineTypeName">LineTypeName</param>
    /// <param name="LineTypeDescription">LineTypeDescription</param>
    [PreserveSig]
    void GetCustomLineType([Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeName, [Out] [MarshalAs(UnmanagedType.BStr)] out string LineTypeDescription);
    /// <summary>
    /// Method that sets a custom line type to the curve from the specified .lin file. The method automatically changes the value of LineType property to kCustomLineType.
    /// </summary>
    /// <param name="FullFileName">Input string that specifies the full file name of the *.lin file containing the custom line types.</param>
    /// <param name="LineTypeName">Input string that specifies the name of the line type.</param>
    /// <param name="ReplaceExisting">Input Boolean that specifies whether to replace the existing line type if a line type of the same name exists. If set to False, and a line type of the same name exists, this method returns an error.</param>
    [PreserveSig]
    void SetCustomLineType([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.BStr)] string LineTypeName, [In] bool ReplaceExisting);
    /// <summary>
    /// Method that copies all the contents of the sketch to the \input target sketch.
    /// </summary>
    /// <param name="TargetSketch">Sketch object that specifies the target sketch into which the contents of the sketch should be copied.</param>
    [PreserveSig]
    void CopyContentsTo([In] [MarshalAs(UnmanagedType.Interface)] Sketch TargetSketch);
    /// <summary>
    /// Method that creates a straight slot. The sketch entities represent the sketch slot are returned.
    /// </summary>
    /// <param name="StartPoint">Input Point2d or SketchPoint object that defines the starting center point of the straight slot.</param>
    /// <param name="EndPoint">Input Point2d or SketchPoint object that defines the ending center point of the straight slot.</param>
    /// <param name="Width">Input Double that specifies the width of the straight slot in centimeters.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator AddStraightSlotByCenterToCenter([In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint, [In] double Width);
    /// <summary>
    /// Method that creates a straight slot. The sketch entities represent the sketch slot are returned.
    /// </summary>
    /// <param name="StartPoint">Input Point2d or SketchPoint object that defines the overall start point. The overall start point is a midpoint of the first arc of the straight slot.</param>
    /// <param name="EndPoint">Input Point2d or SketchPoint object that defines the overall end point. The overall end point is a midpoint of the second arc of the straight slot.</param>
    /// <param name="Width">Input Double that specifies the width of the straight slot in centimeters.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator AddStraightSlotByOverall([In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint, [In] double Width);
    /// <summary>
    /// Method that creates a straight slot. The sketch entities represent the sketch slot are returned.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator AddStraightSlotBySlotCenter([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint, [In] double Width);
    /// <summary>
    /// Method that creates an arc slot. The sketch entities represent the sketch slot are returned.
    /// </summary>
    /// <param name="StartPoint">Input Point2d or SketchPoint object that defines the starting point of the slot’s center-line.</param>
    /// <param name="MidPoint">Input Point2d or SketchPoint object that defines a point along the slot’s center-line.</param>
    /// <param name="EndPoint">Input Point2d or SketchPoint object that defines the end point of the slot’s center-line.</param>
    /// <param name="Width">Input a Double that specifies the width of the arc slot in centimeters.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator AddArcSlotByThreePointArc([In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object MidPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object EndPoint, [In] double Width);
    /// <summary>
    /// Method that creates an arc slot. The sketch entities represent the sketch slot are returned.
    /// </summary>
    /// <param name="CenterPoint">Input Point2d or SketchPoint object that defines the center of the slot’s center-line.</param>
    /// <param name="StartPoint">Input Point2d or SketchPoint object that defines the start point of the  slot’s center-line.</param>
    /// <param name="SweepAngle">Input Double defines the sweep angle of the slot’s center-line in radians. The sweep angle is in a counter-clockwise direction from the start point.</param>
    /// <param name="Width">Input Double that specifies the width of the slot in centimeters.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntitiesEnumerator AddArcSlotByCenterPointArc([In] [MarshalAs(UnmanagedType.IDispatch)] object CenterPoint, [In] [MarshalAs(UnmanagedType.IDispatch)] object StartPoint, [In] double SweepAngle, [In] double Width);
    /// <summary>
    /// Method that copies sketch entities of the sketch to the input target sketch.
    /// </summary>
    /// <param name="SketchEntities">Input ObjectCollection object that specifies the sketch entities being copied.</param>
    /// <param name="TargetSketch">Input Sketch object that specifies the target sketch into which the contents of the sketch should be copied.</param>
    /// <param name="Position">Optional input Point2d that specifies the position on target sketch to place the copied sketch entities. If not specified the position of the sketch entities in source sketch will be used.</param>
    [PreserveSig]
    void CopyEntitiesTo([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SketchEntities, [In] [MarshalAs(UnmanagedType.Interface)] Sketch TargetSketch, [In] [MarshalAs(UnmanagedType.Struct)] object? Position = default);
    /// <summary>
    /// Method that creates new reference sketch geometry as the silhouette on the input face near the input proximity point.
    /// </summary>
    /// <param name="Face">Input Face that defines a silhouette edge that can be projected onto the sketch plane.</param>
    /// <param name="ProximityPoint">Input that identifies which one of possible multiple results to use. For example, if the input face is a cylinder there are two possible silhouette edges.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchEntity AddBySilhouette([In] [MarshalAs(UnmanagedType.Interface)] Face Face, [In] [MarshalAs(UnmanagedType.Interface)] Point ProximityPoint);
    /// <summary>
    /// Method that takes a 3D coordinate in model space, projects it onto the sketch plane along the normal of the plane and returns a Point2d object containing the resulting coordinate point in sketch space.
    /// </summary>
    /// <param name="ModelCoordinate">Input Point that specifies the point in model space to be transformed into sketch space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point2d ModelToSketchSpace([In] [MarshalAs(UnmanagedType.Interface)] Point ModelCoordinate);
    /// <summary>
    /// Method that takes a 2D coordinate in sketch space, and returns a Point3d containing the coordinates of the point in model space.
    /// </summary>
    /// <param name="SketchCoordinate">Input Point2d that specifies the 2d coordinate in sketch space.</param>
    /// <returns></returns>
    [PreserveSig]
    Point SketchToModelSpace([In] [MarshalAs(UnmanagedType.Interface)] Point2d SketchCoordinate);
    /// <summary>
    /// Method that repositions the end-of-part marker relative to the object this method is called from. The argument defines if the end-of-part marker will be positioned just before or just after the object. If the object is contained within another object and is not in the top level of the browser, the positioning of the marker will be relative to the top-level object the calling object is contained within. An example of this case is a sketch that has not been shared and has been consumed by a feature. Another example is a nested work feature.
    /// </summary>
    /// <param name="Before">Input Boolean that indicates if the end of part marker should be immediately before or after this work feature. A value of True indicates before and False indicates after.</param>
    [PreserveSig]
    void SetEndOfPart([In] bool Before);
    /// <summary>
    /// Method that updates all the profiles within the sketch.
    /// </summary>
    [PreserveSig]
    void UpdateProfiles();
    /// <summary>
    /// Method that breaks the link to the source sketch.
    /// </summary>
    [PreserveSig]
    void BreakLink();
}
