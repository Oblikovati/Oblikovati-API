namespace Oblikovati.API;

/// <summary>
/// The ExtrudeFeatures collection object provides access to all of the ExtrudeFeature object in a part component definition and provides methods to create additional ExtrudeFeatures.
/// </summary>
public interface ExtrudeFeatures : IEnumerable
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
    /// Returns the specified object from the collection.
    /// </summary>
    ExtrudeFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="Distance">Distance</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="Operation">Operation</param>
    /// <param name="TaperAngle">TaperAngle</param>
    [PreserveSig]
    ExtrudeFeature AddByDistanceExtent([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Struct)] object Distance, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] PartFeatureOperationEnum Operation, [In] [MarshalAs(UnmanagedType.Struct)] object? TaperAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="ToFace">ToFace</param>
    /// <param name="ExtendToFace">ExtendToFace</param>
    /// <param name="Operation">Operation</param>
    /// <param name="TaperAngle">TaperAngle</param>
    [PreserveSig]
    ExtrudeFeature AddByToFaceExtent([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] PartFeatureOperationEnum Operation, [In] [MarshalAs(UnmanagedType.Struct)] object? TaperAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="ToEntity">ToEntity</param>
    /// <param name="Operation">Operation</param>
    /// <param name="ExtendToFace">ExtendToFace</param>
    /// <param name="TaperAngle">TaperAngle</param>
    [PreserveSig]
    ExtrudeFeature AddByToExtent([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToEntity, [In] PartFeatureOperationEnum Operation, [In] bool? ExtendToFace = false, [In] [MarshalAs(UnmanagedType.Struct)] object? TaperAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="FromFace">FromFace</param>
    /// <param name="ExtendFromFace">ExtendFromFace</param>
    /// <param name="ToFace">ToFace</param>
    /// <param name="ExtendToFace">ExtendToFace</param>
    /// <param name="Operation">Operation</param>
    /// <param name="TaperAngle">TaperAngle</param>
    [PreserveSig]
    ExtrudeFeature AddByFromToExtent([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.IDispatch)] object FromFace, [In] bool ExtendFromFace, [In] [MarshalAs(UnmanagedType.IDispatch)] object ToFace, [In] bool ExtendToFace, [In] PartFeatureOperationEnum Operation, [In] [MarshalAs(UnmanagedType.Struct)] object? TaperAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="Operation">Operation</param>
    /// <param name="TaperAngle">TaperAngle</param>
    [PreserveSig]
    ExtrudeFeature _AddByToNextExtent([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] PartFeatureOperationEnum Operation, [In] [MarshalAs(UnmanagedType.Struct)] object? TaperAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="Terminator">Terminator</param>
    /// <param name="Operation">Operation</param>
    /// <param name="TaperAngle">TaperAngle</param>
    [PreserveSig]
    ExtrudeFeature AddByToNextExtent([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody Terminator, [In] PartFeatureOperationEnum Operation, [In] [MarshalAs(UnmanagedType.Struct)] object? TaperAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="ExtentDirection">ExtentDirection</param>
    /// <param name="Operation">Operation</param>
    /// <param name="TaperAngle">TaperAngle</param>
    [PreserveSig]
    ExtrudeFeature AddByThroughAllExtent([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] PartFeatureExtentDirectionEnum ExtentDirection, [In] PartFeatureOperationEnum Operation, [In] [MarshalAs(UnmanagedType.Struct)] object? TaperAngle = default);
    /// <summary>
    /// Method that creates a new Extrude feature.
    /// </summary>
    /// <param name="Definition">Input ExtrudeDefinition object that defines the extrude feature you want to create.  An ExtrudeDefinition object can be created using the ExtrudeFeatures.CreateExtrudeDefinition method.  It can also be obtained from an existing ExtrudeFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    ExtrudeFeature Add([In] [MarshalAs(UnmanagedType.Interface)] ExtrudeDefinition Definition);
    /// <summary>
    /// Method that creates a new ExtrudeDefinition object.&nbsp;The object created does not represent an extrude feature but instead is a representation of the information that defines an extrude feature.&nbsp;You can use this object as input to the ExtrudeFeatures.Add method to create the actual feature.
    /// </summary>
    /// <param name="Profile">Input Profile object that specifies the sketch profile to use for the extrude feature.</param>
    /// <param name="Operation">Input that specifies the type of operation used to add the feature to the model.  Valid inputs are kNewBodyOperation, kJoinOperation, kCutOperation, kIntersectOperation and kSurfaceOperation.</param>
    /// <returns></returns>
    [PreserveSig]
    ExtrudeDefinition CreateExtrudeDefinition([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] PartFeatureOperationEnum Operation);
}
