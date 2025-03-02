namespace Oblikovati.API;

/// <summary>
/// The AssemblyComponentDefinition object provides access to all of the assembly information of an assembly.
/// </summary>
public interface AssemblyComponentDefinition : ComponentDefinition
{
    /// <summary>
    /// Property that returns the parent of the object.
    /// </summary>
    _AssemblyDocument Parent { get; }
    /// <summary>
    /// Property that returns the AssemblyConstraints collection object.
    /// </summary>
    AssemblyConstraints Constraints { get; }
    /// <summary>
    /// Property that returns the parameters collection.
    /// </summary>
    Parameters Parameters { get; }
    /// <summary>
    /// Property returning an AssemblyEvents collection object.
    /// </summary>
    AssemblyEvents AssemblyEvents { get; }
    /// <summary>
    /// Property that returns the MassProperties object. This supports performing mass properties calculations for the entire assembly.
    /// </summary>
    MassProperties MassProperties { get; }
    /// <summary>
    /// Method that returns the pattern element this occurrence represents.
    /// </summary>
    OccurrencePatterns OccurrencePatterns { get; }
    /// <summary>
    /// Property that returns the WorkAxes collection object that encapsulates all of the work axes defined in this ComponentDefinition.
    /// </summary>
    WorkAxes WorkAxes { get; }
    /// <summary>
    /// Property that returns the WorkPlanes collection object that encapsulates all of the work planes defined in this ComponentDefinition.
    /// </summary>
    WorkPlanes WorkPlanes { get; }
    /// <summary>
    /// Property that returns the WorkPoints collection object that encapsulates all of the work points defined in this ComponentDefinition.
    /// </summary>
    WorkPoints WorkPoints { get; }
    /// <summary>
    /// Property that returns the iMateDefinitions collection object associated with this assembly.
    /// </summary>
    iMateDefinitions iMateDefinitions { get; }
    /// <summary>
    /// Property that returns the iMateResults collection object associated with this assembly.
    /// </summary>
    iMateResults iMateResults { get; }
    /// <summary>
    /// Property that returns the that is currently in edit.
    /// </summary>
    ComponentOccurrence ActiveOccurrence { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Master { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ActivePositionalState { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool MasterActive { get; }
    /// <summary>
    /// Property that returns the BOM object.
    /// </summary>
    BOM BOM { get; }
    /// <summary>
    /// Gets the Features collection for this assembly (assembly features).
    /// </summary>
    Features Features { get; }
    /// <summary>
    /// Property that returns the RepresentationsManager object.
    /// </summary>
    RepresentationsManager RepresentationsManager { get; }
    /// <summary>
    /// Property that returns if the assembly is an iAssembly factory or not. It returns True in the case where the assembly is a factory. If True, the factory can be obtained using the iAssemblyFactory property.
    /// </summary>
    bool IsiAssemblyFactory { get; }
    /// <summary>
    /// Property that returns if the assembly is an iAssembly Member or not. It returns True in the case where the assembly is a member. If True, the member can be obtained using the iAssemblyMember property.
    /// </summary>
    bool IsiAssemblyMember { get; }
    /// <summary>
    /// Property that returns the iAssemblyFactory object. This property will return Nothing in the case where the assembly is not an iAssembly Factory. You can determine this by using the IsiAssemblyFactory property.
    /// </summary>
    iAssemblyFactory iAssemblyFactory { get; }
    /// <summary>
    /// Property that returns the iAssemblyMember object. This property will return Nothing in the case where the assembly is not an iAssembly Member. You can determine this by using the IsiAssemblyMember property.
    /// </summary>
    iAssemblyMember iAssemblyMember { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Material DefaultMaterial { get; set; }
    /// <summary>
    /// Gets the Sketches collection for this assembly component.
    /// </summary>
    PlanarSketches Sketches { get; }
    /// <summary>
    /// Property that returns the UserCoordinateSystems collection object.
    /// </summary>
    UserCoordinateSystems UserCoordinateSystems { get; }
    /// <summary>
    /// Read-only property that returns the BIMComponent object associated with this component definition.
    /// </summary>
    BIMComponent BIMComponent { get; }
    /// <summary>
    /// Read-only property that returns the SimulationManager object.&nbsp;This object provides access to the various simulation API’s.
    /// </summary>
    SimulationManager SimulationManager { get; }
    /// <summary>
    /// Property that returns the objects that have appearance overrides in the active design view. The objects returned in the collection can include occurrences.
    /// </summary>
    ObjectsEnumerator AppearanceOverridesObjects { get; }
    /// <summary>
    /// Gets and sets the default material associated with the assembly component. This is the material that is used for newly created virtual components.
    /// </summary>
    Asset DefaultVirtualComponentMaterial { get; set; }
    /// <summary>
    /// Read-only property that returns the AssemblyJoints collection object which provides access to the existing joints in the assembly and provides the capability to create new joints.
    /// </summary>
    AssemblyJoints Joints { get; }
    /// <summary>
    /// Read-only property that returns the ModelAnnotations collection object.
    /// </summary>
    ModelAnnotations ModelAnnotations { get; }
    /// <summary>
    /// Gets the PointClouds collection object that encapsulates all of the point clouds defined in this Component Definition.
    /// </summary>
    PointClouds PointClouds { get; }
    /// <summary>
    /// Read-only property that returns the ImportedComponents collection object.
    /// </summary>
    ImportedComponents ImportedComponents { get; }
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
    /// Read-only property that returns the RevitExports collection object.
    /// </summary>
    RevitExports RevitExports { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SubstituteUpdateModelGeometriesOnly { get; set; }
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
    /// Method that analyzes the interference between two components. The input ObjectCollections contain the component occurrences that are to be checked for interference. If only one set is provided then interference checking is performed between all occurrences provided in the set. If two sets are provided then the overlap between the components of the two collections are calculated.
    /// </summary>
    /// <param name="Set1">Input that contains ComponentOccurrenceobjects. If this set is provided without Set2, all occurrences in the set are checked for interference against all other occurrences in the set.</param>
    /// <param name="Set2">Optional input that contains ComponentOccurrence objects. When this set is provided the occurrences in Set1 are checked for interference against the occurrences in Set2.</param>
    /// <returns></returns>
    [PreserveSig]
    InterferenceResults AnalyzeInterference([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Set1, [In] [MarshalAs(UnmanagedType.Struct)] object? Set2 = default);
    /// <summary>
    /// Returns the specified object proxy scoped into this assembly, trimming any portion of the context from any assembly in which this assembly is a subassembly. In other words, for the given object proxy, this method makes a new object proxy which has this component definition as the context definition.
    /// </summary>
    /// <param name="ObjectProxy">An object representing an Object Proxy - known in earlier versions of Inventor as a Geom Proxy. Each Object Proxy has an associated ComponentOccurrence, which has a property called ContextDefinition. The value of this property is the top level ComponentDefinition.</param>
    /// <returns></returns>
    [PreserveSig]
    object AdjustProxyContext([In] [MarshalAs(UnmanagedType.IDispatch)] object ObjectProxy);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PositionalStates">PositionalStates</param>
    [PreserveSig]
    void GetPositionalStates([Out] [MarshalAs(UnmanagedType.SafeArray)] out string[,] PositionalStates);
    /// <summary>
    /// Method that converts an assembly to an iAssemblyFactory. The newly created iAssemblyFactory object will have an empty excel spreadsheet.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    iAssemblyFactory CreateFactory();
    /// <summary>
    /// Method that transforms a collection of occurrences.
    /// </summary>
    /// <param name="Occurrences">Input ObjectCollection that contains the ComponentOccurrence objects to be transformed. The collection can only contain top level occurrences from the document. An exception is the case of a flexible occurrence within the top level assembly, in which case, deeper level occurrences may be provided.</param>
    /// <param name="Transforms">Input ObjectCollection that contains Matrix objects defining the transform for the input occurrences. The collection must have the same number of objects as the number of input occurrences, else the method returns an error. The collection can also contain a single Matrix, in which case all occurrences are transformed similarly using the single Matrix.</param>
    /// <param name="IgnoreConstraints">Optional input Boolean which specifies whether to transform the occurrences without re-applying the current assembly constraints. An update of the Assembly will honor the constraints and ignore these transforms. If not specified, a default value of False is used (i.e. constraints are honored).</param>
    [PreserveSig]
    void TransformOccurrences([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Occurrences, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Transforms, [In] bool? IgnoreConstraints = false);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Options">Options</param>
    /// <param name="UniqueOccurrences">UniqueOccurrences</param>
    /// <param name="UniqueOccurrenceSettings">UniqueOccurrenceSettings</param>
    [PreserveSig]
    RigidBodyResults RigidBodyAnalysis([In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Options, [In] [MarshalAs(UnmanagedType.Struct)] object? UniqueOccurrences = default, [In] [MarshalAs(UnmanagedType.Struct)] object? UniqueOccurrenceSettings = default);
    /// <summary>
    /// Property that returns the SurfaceBodies collection. Surface bodies within the assembly is not currently supported by Oblikovati. The returned SurfaceBodies collection will be a collection of zero.
    /// </summary>
    /// <param name="Features">Input ObjectCollection that contains the list of features to suppress.</param>
    [PreserveSig]
    void SuppressFeatures([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Features);
    /// <summary>
    /// Method that unsuppresses previously suppressed features.
    /// </summary>
    /// <param name="Features">Input ObjectCollection that contains the list of features to unsuppress.</param>
    [PreserveSig]
    void UnsuppressFeatures([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Features);
    /// <summary>
    /// Sets the End of Part marker to the top or bottom of the browser.
    /// </summary>
    /// <param name="SetToTop">Input Boolean that specifies whether the "End of Features" node is to be moved to the top or the bottom of the modeling portion of the browser. If True, the marker is moved to the top of the browser, just below the Origin folder. If False, it is moved to the bottom of the browser modeling section of the browser.</param>
    [PreserveSig]
    void SetEndOfFeaturesToTopOrBottom([In] bool SetToTop);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="After">After</param>
    /// <param name="Before">Before</param>
    [PreserveSig]
    void GetEndOfFeaturesPosition([Out] [MarshalAs(UnmanagedType.IDispatch)] out object After, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object Before);
    /// <summary>
    /// Method that marks all the input objects as exported.
    /// </summary>
    /// <param name="Objects">Collection of objects to mark as exported.</param>
    [PreserveSig]
    void ExportObjects([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Objects);
    /// <summary>
    /// Method that creates an occurrence finder object that allows you to find all occurrences that are visible or hidden by a defined amount. By default, visible is defined by a portion of the part being visible from any view of the part. Optionally you can specify a camera to limit the viewing angle and the extents.
    /// </summary>
    /// <param name="Visible">Input Boolean that defines if visible or hidden objects should be found. If True then fully and partially visible occurrences will be returned. If False, completely and partially hidden occurrences will be returned.</param>
    /// <param name="PercentageVisible">Input Double that defines the percentage of the component that can be visible or hidden. A value of 1 (100%) indicates that all components that are visible at all, or that are completely hidden (depending on the Visible argument) will be returned. A value of 0 (0%) indicates that the most visible or hidden components will be returned.</param>
    /// <param name="Compact">Input Boolean that defines if all components that are found within an assembly will be consolidated so that their parent assembly is returned instead of each one of the child components. A value of True indicates that they will be consolidated.</param>
    /// <returns></returns>
    [PreserveSig]
    VisibleOccurrenceFinder CreateVisibleOccurrenceFinder([In] bool Visible, [In] double PercentageVisible, [In] bool Compact);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Objects">Objects</param>
    [PreserveSig]
    void DeleteObjects([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Objects);
    /// <summary>
    /// Clears the appearance overrides on the provided objects. The objects can include faces, features, work surfaces, surface bodies and occurrences.
    /// </summary>
    /// <param name="AppearanceOverrideObjects">Optional input ObjectCollection including occurrences to clear their appearance overrides. If this argument is not provided, then it will clear all the appearance overrides in active design view.  If an object is provided that does not have an override, it is ignored.</param>
    [PreserveSig]
    void ClearAppearanceOverrides([In] [MarshalAs(UnmanagedType.Struct)] object? AppearanceOverrideObjects = default);
    /// <summary>
    /// Method that creates a GeometryIntent object.&nbsp;GeometryIntent objects are used as input when creating assembly joints.&nbsp;They are used to identify geometry and specific locations on that geometry.
    /// </summary>
    /// <param name="Geometry">Input object that specifies the geometry.
    /// Valid input objects are proxies of SketchLine, SketchCircle, SketchArc, SketchEllipse, SketchEllipticalArc, Edge, or Face objects.</param>
    /// <param name="Intent">Optional input that specifies a specific position on the geometry. This can be a value from PointIntentEnum, a Point, or a GeometryIntent object that specifies a position on the geometry relative to model space, a double value indicating a position in the parametric space of the input curve.</param>
    /// <returns></returns>
    [PreserveSig]
    GeometryIntent CreateGeometryIntent([In] [MarshalAs(UnmanagedType.IDispatch)] object Geometry, [In] [MarshalAs(UnmanagedType.Struct)] object? Intent = default);
    /// <summary>
    /// Method that hides all of the assembly constraints, joints and iMate objects in the document.
    /// </summary>
    [PreserveSig]
    void HideAllRelationships();
    /// <summary>
    /// Method that process the property of a collection of occurrences.
    /// </summary>
    /// <param name="pOccurrences">Input ObjectCollection that contains the ComponentOccurrence objects to set the grounded on. The collection can contain top-level occurrences only, if occurrences within a subassembly are specified then they will be ignored.</param>
    /// <param name="PropertyName">Input String that indicates the property of the occurrences to set. Valid properties include: Grounded.</param>
    /// <param name="Value">Input value to set for the occurrences for their property. Valid values for the properties are as below:
    /// PropertyName = “Grounded”. Value = Boolean that indicates whether the occurrences are grounded or not. A value of True indicates that their grounded will be turned on. The Occurrences collection can contain top-level occurrences only, if occurrences within a subassembly are specified then they will be ignored.</param>
    [PreserveSig]
    void SetOccurrencesProperty([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection pOccurrences, [In] [MarshalAs(UnmanagedType.BStr)] string PropertyName, [In] [MarshalAs(UnmanagedType.Struct)] object Value);
}
