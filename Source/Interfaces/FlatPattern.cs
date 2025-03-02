namespace Oblikovati.API;

/// <summary>
/// The FlatPattern object represents the unfolded model in a sheet metal document.
/// </summary>
public interface FlatPattern
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
    /// Property that returns the parent SheetMetalComponentDefinition object.
    /// </summary>
    SheetMetalComponentDefinition Parent { get; }
    /// <summary>
    /// Property that returns the corresponding SurfaceBody.
    /// </summary>
    SurfaceBody Body { get; }
    /// <summary>
    /// Property that returns the MassProperties object for the flat pattern.
    /// </summary>
    MassProperties MassProperties { get; }
    /// <summary>
    /// Property that returns top face of the flat pattern.
    /// </summary>
    Face TopFace { get; }
    /// <summary>
    /// Property that returns the bottom face of the flat pattern.
    /// </summary>
    Face BottomFace { get; }
    /// <summary>
    /// Property that returns the base face from the folded model that was used to create the flat pattern.
    /// </summary>
    Face BaseFace { get; }
    /// <summary>
    /// Gets and sets the punch representation to use for the flat pattern.
    /// </summary>
    PunchRepresentationTypeEnum PunchRepresentationType { get; set; }
    /// <summary>
    /// Property that returns the length of the flat pattern.
    /// </summary>
    double Length { get; }
    /// <summary>
    /// Property that returns the width of the flat pattern.
    /// </summary>
    double Width { get; }
    /// <summary>
    /// Property that returns the FlatBendResults collection object that contains information about all the bends in the flat pattern.
    /// </summary>
    FlatBendResults FlatBendResults { get; }
    /// <summary>
    /// Property that returns the FlatPunchResults collection object that contains information about all the punches in the flat pattern.
    /// </summary>
    FlatPunchResults FlatPunchResults { get; }
    /// <summary>
    /// Inventor::ComponentDefinition::GraphicsDataSetsCollection
    /// </summary>
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    /// <summary>
    /// Gets and sets which angle is reported in the flat pattern.
    /// </summary>
    BendAngleTypeEnum BendAngleReportType { get; set; }
    /// <summary>
    /// Property that returns the collection object that provides access to the features associated with the flat pattern.
    /// </summary>
    FlatPatternFeatures Features { get; }
    /// <summary>
    /// Property that returns the set of parameters for the flat pattern.
    /// </summary>
    Parameters Parameters { get; }
    /// <summary>
    /// Property that returns the PartEvents object associated with the flat pattern. This object will fire events for changes that occur to the flat pattern.
    /// </summary>
    PartEvents PartEvents { get; }
    /// <summary>
    /// Property that gets whether the flat pattern model is currently rolled back to a previous point in the feature history.
    /// </summary>
    bool RolledBackForEdit { get; }
    /// <summary>
    /// Inventor::PartComponentDefinition::Sketches
    /// </summary>
    PlanarSketches Sketches { get; }
    /// <summary>
    /// Inventor::PartComponentDefinition::Sketchs3D
    /// </summary>
    Sketches3D Sketches3D { get; }
    /// <summary>
    /// Property that returns that collection object that provides access to all of the existing work axis objects in the flat pattern and provides the functionality to create new work axis objects.
    /// </summary>
    WorkAxes WorkAxes { get; }
    /// <summary>
    /// Property that returns that collection object that provides access to all of the existing work plane objects in the flat pattern and provides the functionality to create new work plane objects.
    /// </summary>
    WorkPlanes WorkPlanes { get; }
    /// <summary>
    /// Property that returns that collection object that provides access to all of the existing work point objects in the flat pattern and provides the functionality to create new work point objects.
    /// </summary>
    WorkPoints WorkPoints { get; }
    /// <summary>
    /// Inventor::PartComponentDefinition::SketchBlockDefinitions
    /// </summary>
    SketchBlockDefinitions SketchBlockDefinitions { get; }
    /// <summary>
    /// Property that returns the UserCoordinateSystems collection object.
    /// </summary>
    UserCoordinateSystems UserCoordinateSystems { get; }
    /// <summary>
    /// Read-only property that returns the RepresentationsManager object.
    /// </summary>
    RepresentationsManager RepresentationsManager { get; }
    /// <summary>
    /// Read-only property that returns the ASideFaceDefinition from the folded model that was used to create the flat pattern.
    /// </summary>
    ASideDefinition ASideFace { get; }
    /// <summary>
    /// Read-only property that returns the ModelAnnotations collection object.&nbsp;This object provides access to all of the model annotations in the part.
    /// </summary>
    ModelAnnotations ModelAnnotations { get; }
    /// <summary>
    /// Read-only property that returns the AnnotationPlanes collection object.&nbsp;This object provides access to all of the annotation planes in the part.
    /// </summary>
    AnnotationPlanes AnnotationPlanes { get; }
    /// <summary>
    /// Gets the FlatPatternOrientations collection object.
    /// </summary>
    FlatPatternOrientations FlatPatternOrientations { get; }
    /// <summary>
    /// Gets and sets whether to ignore the punch tool features representation overrides in flat pattern.
    /// </summary>
    bool IgnorePunchToolFeaturesRepresentationOverrides { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AreFacesMerged { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Faces TopFaces { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Faces BottomFaces { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    FlatPatternPlates Plates { get; }
    /// <summary>
    /// Returns the ModelToleranceFeatures collection object.&nbsp;This object provides access to all of the model annotations in the part.
    /// </summary>
    ModelToleranceFeatures ModelToleranceFeatures { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ClientGraphicsCollection _ClientGraphicsCollection { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool UseOuterBendAngle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelDatumReferenceFrames ModelDatumReferenceFrames { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ModelDatumFeaturesEnumerator ModelDatumFeatures { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Point">Point</param>
    /// <param name="ObjectTypes">ObjectTypes</param>
    /// <param name="ProximityTolerance">ProximityTolerance</param>
    /// <param name="VisibleObjectsOnly">VisibleObjectsOnly</param>
    [PreserveSig]
    ObjectsEnumerator FindUsingPoint([In] [MarshalAs(UnmanagedType.Interface)] Point Point, [In] [MarshalAs(UnmanagedType.SafeArray)] ref SelectionFilterEnum[,] ObjectTypes, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityTolerance = default, [In] bool? VisibleObjectsOnly = true);
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
    ObjectsEnumerator FindUsingVector([In] [MarshalAs(UnmanagedType.Interface)] Point OriginPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Direction, [In] [MarshalAs(UnmanagedType.SafeArray)] ref SelectionFilterEnum[,] ObjectTypes, [In] bool? UseCylinder = true, [In] [MarshalAs(UnmanagedType.Struct)] object? ProximityTolerance = default);
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
    ObjectsEnumerator FindUsingVector([In] [MarshalAs(UnmanagedType.Interface)] Point OriginPoint, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector Direction, [In] [MarshalAs(UnmanagedType.SafeArray)] ref SelectionFilterEnum[,] ObjectTypes, [In] bool UseCylinder, [In] [MarshalAs(UnmanagedType.Struct)] object ProximityTolerance, [In] bool VisibleObjectsOnly, [Out] [MarshalAs(UnmanagedType.Struct)] out object LocationPoints);
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
    /// Method that deletes the FlatPattern.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that returns edges of the specified type from the flat pattern body.
    /// </summary>
    /// <param name="EdgeType">Input FlatPatternEdgeTypeEnum that specifies the type of edges to return from the flat pattern body.</param>
    /// <param name="TopFaceEdges">Optional input Boolean that specifies whether to return the edges from the top face or the bottom face of the unfolded model. If not specified, edges from the top face are returned.</param>
    /// <returns></returns>
    [PreserveSig]
    Edges GetEdgesOfType([In] FlatPatternEdgeTypeEnum EdgeType, [In] bool? TopFaceEdges = true);
    /// <summary>
    /// Method that returns the corresponding BRep entity (face, edge, etc.) in the flat pattern body given a BRep entity in the sheet metal body.
    /// </summary>
    /// <param name="SheetMetalEntity">Input BRep entity from the sheet metal body.</param>
    /// <returns></returns>
    [PreserveSig]
    object GetFlatPatternEntity([In] [MarshalAs(UnmanagedType.IDispatch)] object SheetMetalEntity);
    /// <summary>
    /// Returns the corresponding BRep entity (face, edge, etc.) in the sheet metal body given a BRep entity in the flat pattern body. If an entity is not found, the method returns Nothing. If multiple matches are found, an ObjectsEnumerator is returned.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    object GetSheetMetalEntity([In] [MarshalAs(UnmanagedType.IDispatch)] object FlatPatternEntity);
    /// <summary>
    /// Method that puts the FlatPattern in edit mode.
    /// </summary>
    [PreserveSig]
    void Edit();
    /// <summary>
    /// Method that causes the FlatPattern editing environment to be closed and the user interface to return to sheet metal editing environment.
    /// </summary>
    [PreserveSig]
    void ExitEdit();
    /// <summary>
    /// Method that deletes a collection of objects that belong to the flat pattern.
    /// </summary>
    /// <param name="Objects">Collection of objects to delete from the part. Valid objects are part features, work features, sketches and 3d sketches.</param>
    /// <param name="RetainConsumedSketches">Optional input Boolean indicating if consumed sketches within the feature should be deleted. If the feature being deleted is not a sketch based feature this argument is ignored.</param>
    /// <param name="RetainDepFeatsAndSketches">Optional input Boolean that specifies if dependent features and sketches should be deleted. If there are no such dependents this argument is ignored.</param>
    /// <param name="RetainDepWorkFeats">Optional input Boolean that specifies if dependent work features should be deleted. If there are no dependent work features this argument is ignored.</param>
    [PreserveSig]
    void DeleteObjects([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Objects, [In] bool? RetainConsumedSketches = false, [In] bool? RetainDepFeatsAndSketches = false, [In] bool? RetainDepWorkFeats = false);
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="After">After</param>
    /// <param name="Before">Before</param>
    [PreserveSig]
    void GetEndOfPartPosition([Out] [MarshalAs(UnmanagedType.IDispatch)] out object After, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Before);
    /// <summary>
    /// Oblikovati::PartComponentDefinition::SetEndOfPartToTopOrBottom
    /// </summary>
    /// <param name="SetToTop">Input Boolean that specifies whether the end-of-part marker is to be moved to the top or the bottom of the browser. If True, the marker is moved to the top of the browser, just below the Origin folder. If False, it is moved to the bottom of the browser, just below the last item in the browser.</param>
    [PreserveSig]
    void SetEndOfPartToTopOrBottom([In] bool SetToTop);
    /// <summary>
    /// Method that suppresses the specified features. This is limited to the features created in the flat pattern.
    /// </summary>
    /// <param name="Features">Input ObjectCollection of flat pattern features to suppress.</param>
    [PreserveSig]
    void SuppressFeatures([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Features);
    /// <summary>
    /// Method that unsuppresses the specified features. This is limited to the features created in the flat pattern.
    /// </summary>
    /// <param name="Features">Input ObjectCollection of flat pattern features to unsuppress.</param>
    [PreserveSig]
    void UnsuppressFeatures([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Features);
    /// <summary>
    /// Method that creates a GeometryIntent object.&nbsp;GeometryIntent objects are used as input when creating annotations in the model.&nbsp;They are used to identify geometry and optionally specific locations on that geometry.
    /// </summary>
    /// <param name="Geometry">Input object that specifies the geometry. Valid input objects are Vertex, WorkPoint, SketchPoint, SketchPoint3d, WorkAxis, SketchLine, SketchLine3d, SketchCircle, SketchCircle3d, Edge, or Face objects.</param>
    /// <param name="Intent">Optional input that specifies a specific position on the geometry. This can be a value from PointIntentEnum, an entity if the intent is the intersection of two geometries, a Point object that specifies a position on the geometry relative to model space, a double value indicating a position in the parametric space of the input curve, and a Point2d object that specifies a point in the parametric space of a surface.</param>
    /// <returns></returns>
    [PreserveSig]
    GeometryIntent CreateGeometryIntent([In] [MarshalAs(UnmanagedType.IDispatch)] object Geometry, [In] [MarshalAs(UnmanagedType.Struct)] object? Intent = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Face">Face</param>
    [PreserveSig]
    FlatPatternFaceTypeEnum GetFlatPatternFaceType([In] [MarshalAs(UnmanagedType.Interface)] Face Face);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Face">Face</param>
    [PreserveSig]
    FlatPatternPlate GetContainingPlateOfFace([In] [MarshalAs(UnmanagedType.Interface)] Face Face);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void FlipBaseFace();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AlignmentType">AlignmentType</param>
    /// <param name="AlignedTo">AlignedTo</param>
    /// <param name="AlignmentDirectionReversed">AlignmentDirectionReversed</param>
    [PreserveSig]
    void GetAlignment([Out] out AlignmentTypeEnum AlignmentType, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object AlignedTo, [Out] out bool AlignmentDirectionReversed);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="AlignmentType">AlignmentType</param>
    /// <param name="AlignedTo">AlignedTo</param>
    /// <param name="AlignmentDirectionReversed">AlignmentDirectionReversed</param>
    [PreserveSig]
    void SetAlignment([In] AlignmentTypeEnum AlignmentType, [In] [MarshalAs(UnmanagedType.IDispatch)] object AlignedTo, [In] bool? AlignmentDirectionReversed = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Create">Create</param>
    [PreserveSig]
    View GetView([In] bool? Create = true);
}
