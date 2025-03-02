namespace Oblikovati.API;

/// <summary>
/// The LoftFeatures collection object provides access to existing loft features and supports the ability to create new loft features.
/// </summary>
public interface LoftFeatures : IEnumerable
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
    /// Returns the specified LoftFeature object from the collection.
    /// </summary>
    LoftFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new MapPointCurves object. You then use functionality provided by the resulting MapPointCurves object to define the specific point mapping.
    /// </summary>
    /// <param name="Sections">Input ObjectCollection that contains the sections for the loft. The sections provided for input must be the same sections that will be used as input for the LoftFeatures.Add method.</param>
    /// <returns></returns>
    [PreserveSig]
    MapPointCurves CreateMapCurves([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Sections);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Sections">Sections</param>
    /// <param name="Operation">Operation</param>
    /// <param name="StartSectionCondition">StartSectionCondition</param>
    /// <param name="StartSectionImpact">StartSectionImpact</param>
    /// <param name="StartSectionAngle">StartSectionAngle</param>
    /// <param name="EndSectionCondition">EndSectionCondition</param>
    /// <param name="EndSectionImpact">EndSectionImpact</param>
    /// <param name="EndSectionAngle">EndSectionAngle</param>
    /// <param name="Closed">Closed</param>
    /// <param name="Rails">Rails</param>
    /// <param name="MapPointCurves">MapPointCurves</param>
    [PreserveSig]
    LoftFeature _Add([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Sections, [In] PartFeatureOperationEnum Operation, [In] LoftConditionEnum? StartSectionCondition = LoftConditionEnum.kFreeLoftCondition, [In] [MarshalAs(UnmanagedType.Struct)] object? StartSectionImpact = default, [In] [MarshalAs(UnmanagedType.Struct)] object? StartSectionAngle = default, [In] LoftConditionEnum? EndSectionCondition = LoftConditionEnum.kFreeLoftCondition, [In] [MarshalAs(UnmanagedType.Struct)] object? EndSectionImpact = default, [In] [MarshalAs(UnmanagedType.Struct)] object? EndSectionAngle = default, [In] bool? Closed = false, [In] [MarshalAs(UnmanagedType.Struct)] object? Rails = default, [In] [MarshalAs(UnmanagedType.Struct)] object? MapPointCurves = default);
    /// <summary>
    /// Method that creates a new loft.
    /// </summary>
    /// <param name="Definition">Input LoftDefinition object that defines the input definition for the loft. The LoftDefinition object can be created using the CreateLoftDefinition method of the LoftFeatures object. The LoftDefinition object defines the following input data for creating the loft feature: the loft sections, the boundary conditions for the starting and ending sections, a centerline or rails with any applicable boundary conditions, the mapping between the sections, an option to indicate whether the loft should be closed or not and an option to indicate whether tangent faces should be merged or not.</param>
    /// <returns></returns>
    [PreserveSig]
    LoftFeature Add([In] [MarshalAs(UnmanagedType.Interface)] LoftDefinition Definition);
    /// <summary>
    /// Method that creates a LoftDefinition object that defines the input definition for a loft feature.
    /// </summary>
    /// <param name="Sections">Input ObjectCollection that contains the sections for the loft. Valid objects for sections are Profile, Profile3D, EdgeLoop, EdgeCollection, SketchPoint, SketchPoint3D, WorkPoint and Vertex objects. If a point (SketchPoint, SketchPoint3D, WorkPoint or Vertex object) is used, it must be either the first section or the last section and there must be at least one other intermediate section which is not a point. If an EdgeCollection object is used it may contain either a single edge or a set of tangentially connected edges. The order of the sections within the ObjectCollection defines the fit order of the loft through the sections. The sections must be either all open or all closed; you cannot mix open and closed sections.</param>
    /// <param name="Operation">Input constant that indicates the type of operation to perform. Valid input is kJoinOperation, kCutOperation, kIntersectOperation or kSurfaceOperation.</param>
    /// <returns></returns>
    [PreserveSig]
    LoftDefinition CreateLoftDefinition([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Sections, [In] PartFeatureOperationEnum Operation);
}
