namespace Oblikovati.API;

/// <summary>
/// The SheetMetalComponentDefinition object derives from the PartComponentDefinition object. It adds the sheet metal-specific behavior to the PartComponentDefinition.
/// </summary>
public interface SheetMetalComponentDefinition
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
    /// Property that returns all of the result SurfaceBody objects contained within this ComponentDefinition.
    /// </summary>
    SurfaceBodies SurfaceBodies { get; }
    /// <summary>
    /// Property that returns the collection object.
    /// </summary>
    ComponentOccurrences Occurrences { get; }
    /// <summary>
    /// Property that returns the containing Document object.
    /// </summary>
    object Document { get; }
    /// <summary>
    /// Gets the object that directly deals with I/O to and from a storage-medium, including Streams(IStream).
    /// </summary>
    DataIO DataIO { get; }
    /// <summary>
    /// Property that returns the ClientGraphicsCollection object.
    /// </summary>
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    /// <summary>
    /// Property that returns a string that can be used to determine if the document has been modified. This version string is changed every time the assembly is modified. By saving a previous version string, you can compare the current version string to see if the assembly has been modified.
    /// </summary>
    string ModelGeometryVersion { get; }
    /// <summary>
    /// Property that returns the AttributeSets collection object associated with this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets and sets how the component is used/viewed in a BOM.
    /// </summary>
    BOMStructureEnum BOMStructure { get; set; }
    /// <summary>
    /// Property that returns the BOMQuantity object.
    /// </summary>
    BOMQuantity BOMQuantity { get; }
    /// <summary>
    /// Property that returns a Box object which contains the opposing points of a rectangular box that is guaranteed to enclose this object.
    /// </summary>
    Box RangeBox { get; }
    /// <summary>
    /// Gets a bounding box that tightly encloses all the solid and surface bodies under the ComponentDefinition.
    /// </summary>
    Box PreciseRangeBox { get; }
    /// <summary>
    /// Read-only property that returns the oriented minimum range box for this object.
    /// </summary>
    OrientedBox OrientedMinimumRangeBox { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ComponentDefinitionReferences ImmediateReferencedDefinitions { get; }
    /// <summary>
    /// Property that returns the PartFeatures collection object.
    /// </summary>
    PartFeatures Features { get; }
    /// <summary>
    /// Property that gets whether the model is currently rolled back to a previous point in the feature history.
    /// </summary>
    bool RolledBackForEdit { get; }
    /// <summary>
    /// Property that returns the ReferenceComponents collection object.
    /// </summary>
    ReferenceComponents ReferenceComponents { get; }
    /// <summary>
    /// Gets the PlanarSketches collection object that encapsulates all of the planar sketches defined in this ComponentDefinition.
    /// </summary>
    PlanarSketches Sketches { get; }
    /// <summary>
    /// Property that returns the Sketches3D collection object that encapsulates all of the 3D sketches defined in this ComponentDefinition.
    /// </summary>
    Sketches3D Sketches3D { get; }
    /// <summary>
    /// Gets the Parameters collection object that encapsulates all of the parameters defined in this ComponentDefinition.
    /// </summary>
    Parameters Parameters { get; }
    /// <summary>
    /// Property that returns the WorkAxes collection object.
    /// </summary>
    WorkAxes WorkAxes { get; }
    /// <summary>
    /// Property that returns the WorkPlanes collection object.
    /// </summary>
    WorkPlanes WorkPlanes { get; }
    /// <summary>
    /// Property that returns the WorkPoints collection object.
    /// </summary>
    WorkPoints WorkPoints { get; }
    /// <summary>
    /// Property that returns the collection object that encapsulates all of the work surfaces defined in this PartComponentDefinition.
    /// </summary>
    WorkSurfaces WorkSurfaces { get; }
    /// <summary>
    /// Property that returns the PartEvents source object.
    /// </summary>
    PartEvents PartEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Material Material { get; set; }
    /// <summary>
    /// Mass properties for this ComponentDefinition.
    /// </summary>
    MassProperties MassProperties { get; }
    /// <summary>
    /// Gets/Sets the flag that decides whether the BRep's modifications through its history are saved explicitly in the next save or not (independent of CompactModelHistory setting).
    /// </summary>
    bool CompactModelHistoryOnNextSave { get; set; }
    /// <summary>
    /// Property that returns the iPartFactory object. This property will fail in the case where the part is not an iPart Factory. You can determine this by using the IsiPartFactory property.
    /// </summary>
    iPartFactory iPartFactory { get; }
    /// <summary>
    /// Property that returns the iPartMember object.
    /// </summary>
    iPartMember iPartMember { get; }
    /// <summary>
    /// Property that returns if the part is an iPart Factory or not. It returns True in the case where the part is a factory. If True, the factory can be obtained using the iPartFactory property.
    /// </summary>
    bool IsiPartFactory { get; }
    /// <summary>
    /// Property that returns the iPartMember object. This property will fail in the case where the part is not an iPart Member. You can determine this by using the IsiPartMember property.
    /// </summary>
    bool IsiPartMember { get; }
    /// <summary>
    /// Property that returns the iMateDefinitions collection object associated with this part.
    /// </summary>
    iMateDefinitions iMateDefinitions { get; }
    /// <summary>
    /// Property that returns the AnalysisManager object.
    /// </summary>
    AnalysisManager AnalysisManager { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool CompactModelHistory { get; set; }
    /// <summary>
    /// Property that returns the SketchBlockDefinitions collection object.
    /// </summary>
    SketchBlockDefinitions SketchBlockDefinitions { get; }
    /// <summary>
    /// Property that returns the UserCoordinateSystems collection object.
    /// </summary>
    UserCoordinateSystems UserCoordinateSystems { get; }
    /// <summary>
    /// Determines whether the part contains multiple solid bodies or not.
    /// </summary>
    bool HasMultipleSolidBodies { get; }
    /// <summary>
    /// Property that indicates if this part is a Content Center part or not. A value of True indicates it is a Content Center part.
    /// </summary>
    bool IsContentMember { get; }
    /// <summary>
    /// Read-only property that returns the RepresentationsManager object.
    /// </summary>
    RepresentationsManager RepresentationsManager { get; }
    /// <summary>
    /// Read-only property that returns the BIMComponent object associated with this component definition.
    /// </summary>
    BIMComponent BIMComponent { get; }
    /// <summary>
    /// Gets the objects that have appearance overrides in the active design view. The objects can include faces, features, work surfaces and surface bodies.
    /// </summary>
    ObjectsEnumerator AppearanceOverridesObjects { get; }
    /// <summary>
    /// Read-only property that returns the ModelAnnotations collection object.&nbsp;This object provides access to all of the model annotations in the part.
    /// </summary>
    ModelAnnotations ModelAnnotations { get; }
    /// <summary>
    /// Read-only property that returns the AnnotationPlanes collection object.&nbsp;This object provides access to all of the annotation planes in the part.
    /// </summary>
    AnnotationPlanes AnnotationPlanes { get; }
    /// <summary>
    /// Gets the PointClouds collection object that encapsulates all of the point clouds defined in this Component Definition.
    /// </summary>
    PointClouds PointClouds { get; }
    /// <summary>
    /// Read-only property that returns the MeshFeatureSets collection object.
    /// </summary>
    MeshFeatureSets MeshFeatureSets { get; }
    /// <summary>
    /// Returns the ModelToleranceFeatures collection object.&nbsp;This object provides access to all of the model annotations in the part.
    /// </summary>
    ModelToleranceFeatures ModelToleranceFeatures { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelDatumReferenceFrames ModelDatumReferenceFrames { get; }
    /// <summary>
    /// Read-only property that returns the ModelStates object.
    /// </summary>
    ModelStates ModelStates { get; }
    /// <summary>
    /// Read-only property that returns whether the document is a model state factory document or not.
    /// </summary>
    bool IsModelStateFactory { get; }
    /// <summary>
    /// Read-only property that returns whether the document is a model state member document or not.
    /// </summary>
    bool IsModelStateMember { get; }
    /// <summary>
    /// Read-only property that returns the model state factory document when IsModelStateMember returns True.
    /// </summary>
    _Document FactoryDocument { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelDatumFeaturesEnumerator ModelDatumFeatures { get; }
    /// <summary>
    /// Property that returns the SheetMetalStyles collection object.
    /// </summary>
    SheetMetalStyles SheetMetalStyles { get; }
    /// <summary>
    /// Property that returns the UnfoldMethods collection object.
    /// </summary>
    UnfoldMethods UnfoldMethods { get; }
    /// <summary>
    /// Property that returns the active SheetMetalStyle object.
    /// </summary>
    SheetMetalStyle ActiveSheetMetalStyle { get; }
    /// <summary>
    /// Property that returns whether the sheet metal body has been unfolded and a FlatPattern object exists.
    /// </summary>
    bool HasFlatPattern { get; }
    /// <summary>
    /// Property that returns the FlatPattern object. If the sheet metal part hasn't been unfolded, this property returns Nothing.
    /// </summary>
    FlatPattern FlatPattern { get; }
    /// <summary>
    /// Property that returns the parameter that controls the thickness of the part.
    /// </summary>
    Parameter Thickness { get; }
    /// <summary>
    /// Property that returns the parameter that controls the bend radius of the part.
    /// </summary>
    Parameter BendRadius { get; }
    /// <summary>
    /// Property that returns the parameter that controls the bend relief depth of the part.
    /// </summary>
    Parameter BendReliefDepth { get; }
    /// <summary>
    /// Property that returns the parameter that controls the bend relief width of the part.
    /// </summary>
    Parameter BendReliefWidth { get; }
    /// <summary>
    /// Property that returns the parameter that controls the corner relief size of the part.
    /// </summary>
    Parameter CornerReliefSize { get; }
    /// <summary>
    /// Property that returns the parameter that controls the Jacobi radius size of the part.
    /// </summary>
    Parameter JacobiRadiusSize { get; }
    /// <summary>
    /// Property that returns the parameter that controls the minimum remnant of the part.
    /// </summary>
    Parameter MinimumRemnant { get; }
    /// <summary>
    /// Property that returns the parameter that controls the transition radius of the part.
    /// </summary>
    Parameter TransitionRadius { get; }
    /// <summary>
    /// Read-write property that gets and sets the currently active unfold method for the document.
    /// </summary>
    UnfoldMethod UnfoldMethod { get; set; }
    /// <summary>
    /// Read-write property that specifies if the material is defined by the sheet metal style or it is explictly set.
    /// </summary>
    bool UseSheetMetalStyleMaterial { get; set; }
    /// <summary>
    /// Read-write property that specifies if the active thickness is defined by the sheet metal style or it is explictly set.
    /// </summary>
    bool UseSheetMetalStyleThickness { get; set; }
    /// <summary>
    /// Read-write property that specifies whether to use the unfold method specified by the sheet metal style or not.
    /// </summary>
    bool UseSheetMetalStyleUnfoldMethod { get; set; }
    /// <summary>
    /// Inventor::PartComponentDefinition::Bends
    /// </summary>
    BendsEnumerator Bends { get; }
    /// <summary>
    /// Inventor::PartComponentDefinition::GapSize
    /// </summary>
    Parameter GapSize { get; }
    /// <summary>
    /// Read-only property that returns the ASideFaceDefinitions collection object.
    /// </summary>
    ASideDefinitions ASideDefinitions { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ASideFaceStatusEnum ASideFaceStatus { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Face ASideFace { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point">Point</param>
    /// <param name="ObjectTypes">ObjectTypes</param>
    /// <param name="ProximityTolerance">ProximityTolerance</param>
    /// <param name="VisibleObjectsOnly">VisibleObjectsOnly</param>
    [PreserveSig]
    ObjectsEnumerator FindUsingPoint([In] [MarshalAs(UnmanagedType.Interface)] Point Point, [In] [MarshalAs(UnmanagedType.SafeArray)] ref SelectionFilterEnum[] ObjectTypes, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityTolerance = default, [In] bool? VisibleObjectsOnly = true);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _InvalidateSketchNodes();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="OriginPoint">OriginPoint</param>
    /// <param name="Direction">Direction</param>
    /// <param name="ObjectTypes">ObjectTypes</param>
    /// <param name="UseCylinder">UseCylinder</param>
    /// <param name="ProximityTolerance">ProximityTolerance</param>
    /// <param name="VisibleObjectsOnly">VisibleObjectsOnly</param>
    /// <param name="LocationPoints">LocationPoints</param>
    [PreserveSig]
    ObjectsEnumerator FindUsingVector([In] [MarshalAs(UnmanagedType.Interface)] Point OriginPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Direction, [In] [MarshalAs(UnmanagedType.SafeArray)] ref SelectionFilterEnum[] ObjectTypes, [In] bool? UseCylinder = true, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityTolerance = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="OriginPoint">OriginPoint</param>
    /// <param name="Direction">Direction</param>
    /// <param name="ObjectTypes">ObjectTypes</param>
    /// <param name="UseCylinder">UseCylinder</param>
    /// <param name="ProximityTolerance">ProximityTolerance</param>
    /// <param name="VisibleObjectsOnly">VisibleObjectsOnly</param>
    /// <param name="LocationPoints">LocationPoints</param>
    [PreserveSig]
    ObjectsEnumerator FindUsingVector([In] [MarshalAs(UnmanagedType.Interface)] Point OriginPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Direction, [In] [MarshalAs(UnmanagedType.SafeArray)] ref SelectionFilterEnum[] ObjectTypes, [In] bool UseCylinder, [In] [MarshalAs(UnmanagedType.Struct)] object ProximityTolerance, [In] bool VisibleObjectsOnly, [Out] [MarshalAs(UnmanagedType.Struct)] out object LocationPoints);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="UnusedGeometries">UnusedGeometries</param>
    [PreserveSig]
    void GetUnusedGeometries([Out] [MarshalAs(UnmanagedType.Interface)] out ObjectCollection UnusedGeometries);
    /// <summary>
    /// Method that purges unused sketches and work features.
    /// </summary>
    /// <param name="UnusedGeometries">Optional input ObjectCollection that including the sketches and work features to purge. The unused sketches and work features can be retrieved using GetUnusedGeometries method. If this is not provided then all unused sketches and work features will be purged.</param>
    [PreserveSig]
    void PurgeUnusedGeometries([In] [MarshalAs(UnmanagedType.Struct)] object? UnusedGeometries = default);
    /// <summary>
    /// Method that repositions the specifies object(s) to the new position within the collection of the object in the document.
    /// </summary>
    /// <param name="TargetObject">Input the Object that specifies the target object to move other objects next to. Valid object includes: PartFeature, ComponentOccurrence, Sketch, Sketch3D, WorkFeature.</param>
    /// <param name="Before">Input Boolean that indicates whether to position other object(s) before or after the target object.  A value of True indicates that the object(s) will be positioned before the target object.</param>
    /// <param name="StartObject">Input Object that specifies the object to be repositioned.  Valid object includes: PartFeature, ComponentOccurrence, Sketch, Sketch3D, WorkFeature.</param>
    /// <param name="EndObject">Optional input Object that specifies the object to be repositioned.  If specified, all the objects from the StartObject to the EndObject, both inclusive, will be repositioned to the specified position in the document.  If not specified, only the StartObject will be repositioned.  Valid object includes: PartFeature, ComponentOccurrence, Sketch, Sketch3D, WorkFeature.</param>
    [PreserveSig]
    void RepositionObject([In] [MarshalAs(UnmanagedType.IDispatch)] object TargetObject, [In] bool Before, [In] [MarshalAs(UnmanagedType.IDispatch)] object StartObject, [In] [MarshalAs(UnmanagedType.Struct)] object? EndObject = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void _AutoStitchAndPromote();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="RayStartPoint">RayStartPoint</param>
    /// <param name="RayDirection">RayDirection</param>
    /// <param name="Radius">Radius</param>
    /// <param name="FoundEntities">FoundEntities</param>
    /// <param name="LocationPoints">LocationPoints</param>
    /// <param name="FindFirstOnly">FindFirstOnly</param>
    [PreserveSig]
    void FindUsingRay([In] [MarshalAs(UnmanagedType.Interface)] Point RayStartPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector RayDirection, [In] double Radius, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectsEnumerator FoundEntities, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectsEnumerator LocationPoints, [In] bool? FindFirstOnly = false);
    /// <summary>
    /// Converts a part to an iPart factory.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    iPartFactory CreateFactory();
    /// <summary>
    /// Method that positions the end-of-part marker at the top or bottom of the browser.
    /// </summary>
    /// <param name="SetToTop">Input Boolean that specifies whether the end-of-part marker is to be moved to the top or the bottom of the browser. If True, the marker is moved to the top of the browser, just below the Origin folder. If False, it is moved to the bottom of the browser, just below the last item in the browser.</param>
    [PreserveSig]
    void SetEndOfPartToTopOrBottom([In] bool SetToTop);
    /// <summary>
    /// Method that deletes a collection of objects that belong to the part.
    /// </summary>
    /// <param name="Objects">Collection of objects to delete from the part. Valid objects are part features, work features, sketches and 3d sketches.</param>
    /// <param name="RetainConsumedSketches">Optional input Boolean indicating if consumed sketches within the feature should be deleted. If the feature being deleted is not a sketch based feature this argument is ignored.</param>
    /// <param name="RetainDepFeatsAndSketches">Optional input Boolean that specifies if dependent features and sketches should be deleted. If there are no such dependents this argument is ignored.</param>
    /// <param name="RetainDepWorkFeats">Optional input Boolean that specifies if dependent work features should be deleted. If there are no dependent work features this argument is ignored.</param>
    [PreserveSig]
    void DeleteObjects([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Objects, [In] bool? RetainConsumedSketches = false, [In] bool? RetainDepFeatsAndSketches = false, [In] bool? RetainDepWorkFeats = false);
    /// <summary>
    /// Method that suppresses the specified features.
    /// </summary>
    /// <param name="Features">Collection of features to suppress.</param>
    [PreserveSig]
    void SuppressFeatures([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Features);
    /// <summary>
    /// Method that unsuppresses the specified features.
    /// </summary>
    /// <param name="Features">Collection of features to unsuppress.</param>
    [PreserveSig]
    void UnsuppressFeatures([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Features);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="After">After</param>
    /// <param name="Before">Before</param>
    [PreserveSig]
    void GetEndOfPartPosition([Out] [MarshalAs(UnmanagedType.IDispatch)] out object After, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Before);
    /// <summary>
    /// Marks all the input objects as exported.
    /// </summary>
    /// <param name="Objects">Object collection to mark as exported.</param>
    [PreserveSig]
    void ExportObjects([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Objects);
    /// <summary>
    /// Clears the appearance overrides on the provided objects. The objects can include faces, features, work surfaces, surface bodies and occurrences.
    /// </summary>
    /// <param name="AppearanceOverrideObjects">Optional input ObjectCollection including the faces, features, work surfaces and bodies to clear their appearance overrides. If this argument is not provided, then it will clear all the appearance overrides in active design view.  If an object is provided that does not have an override, it is ignored.</param>
    [PreserveSig]
    void ClearAppearanceOverrides([In] [MarshalAs(UnmanagedType.Struct)] object? AppearanceOverrideObjects = default);
    /// <summary>
    /// Method that creates a GeometryIntent object.&nbsp;GeometryIntent objects are used as input when creating annotations in the model.&nbsp;They are used to identify geometry and optionally specific locations on that geometry.
    /// </summary>
    /// <param name="Geometry">Input object that specifies the geometry. Valid input objects are Vertex, WorkPoint, SketchPoint, SketchPoint3d, WorkAxis, SketchLine, SketchLine3d, SketchCircle, SketchCircle3d, Edge, or Face objects.</param>
    /// <param name="Intent">Optional input that specifies a specific position on the geometry. This can be a value from PointIntentEnum, an entity if the intent is the intersection of two geometries, a Point object that specifies a position on the geometry relative to model space, a double value indicating a position in the parametric space of the input curve, and a Point2d object that specifies a point in the parametric space of a surface.</param>
    /// <returns></returns>
    [PreserveSig]
    GeometryIntent CreateGeometryIntent([In] [MarshalAs(UnmanagedType.IDispatch)] object Geometry, [In] [MarshalAs(UnmanagedType.Struct)] object? Intent = default);
    /// <summary>
    /// Method that generates the flat pattern.
    /// </summary>
    [PreserveSig]
    void Unfold();
    /// <summary>
    /// Method that generates the flat pattern with the input face as the base face.
    /// </summary>
    /// <param name="BaseFace">Input Face object from the folded model to be used as the base face when generating the flat pattern.</param>
    [PreserveSig]
    void Unfold2([In] [MarshalAs(UnmanagedType.Interface)] Face BaseFace);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BaseFace">BaseFace</param>
    /// <param name="ReplaceGeometry">ReplaceGeometry</param>
    [PreserveSig]
    void UnfoldNoMerge([In] [MarshalAs(UnmanagedType.Interface)] Face BaseFace, [In] bool ReplaceGeometry);
    /// <summary>
    /// Method that gets the sheet metal style for a surface body.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SheetMetalStyle GetBodySheetMetalStyle([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Body);
    /// <summary>
    /// Method that sets the sheet metal style for a surface body.
    /// </summary>
    [PreserveSig]
    void SetBodySheetMetalStyle([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Body, [In] [MarshalAs(UnmanagedType.Interface)] SheetMetalStyle Value);
    /// <summary>
    /// Method that sets the sheet metal style for a surface body, can ignore computation errors.
    /// </summary>
    /// <param name="Body">Input SurfaceBody object that specifies the body to set its sheet metal style.</param>
    /// <param name="Value">Input SheetMetalStyle object that specifies the sheet metal style to set to the body.</param>
    /// <param name="AcceptErors">Optional  input Boolean value that indicates if accepts errors when set the sheet metal style to the body. If the AcceptErrors argument is set to True, errors are accepted and the process continues.</param>
    [PreserveSig]
    void SetBodySheetMetalStyle2([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Body, [In] [MarshalAs(UnmanagedType.Interface)] SheetMetalStyle Value, [In] bool AcceptErors);
}
