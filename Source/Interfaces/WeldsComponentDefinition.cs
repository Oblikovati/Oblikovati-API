namespace Oblikovati.API;

/// <summary>
/// The WeldsComponentDefinition object derives from the PartComponentDefinition object. It adds weld-specific behavior to the PartComponentDefinition.
/// </summary>
public interface WeldsComponentDefinition
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
}
