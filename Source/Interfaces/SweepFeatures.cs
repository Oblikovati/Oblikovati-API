namespace Oblikovati.API;

/// <summary>
/// The SweepFeatures collection object provides access to all of the objects in a component definition and provides methods to create additional SweepFeature objects.
/// </summary>
public interface SweepFeatures : IEnumerable
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
    /// Method that returns the specified SweepFeature object from the collection.
    /// </summary>
    SweepFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SketchCurve">SketchCurve</param>
    [PreserveSig]
    Path CreatePath([In] [MarshalAs(UnmanagedType.IDispatch)] object SketchCurve);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="Path">Path</param>
    /// <param name="Operation">Operation</param>
    /// <param name="TaperAngle">TaperAngle</param>
    [PreserveSig]
    SweepFeature _Add([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Interface)] Path Path, [In] PartFeatureOperationEnum Operation, [In] [MarshalAs(UnmanagedType.Struct)] object? TaperAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="SweepPath">SweepPath</param>
    /// <param name="Operation">Operation</param>
    /// <param name="ProfileOrientation">ProfileOrientation</param>
    /// <param name="TaperAngle">TaperAngle</param>
    [PreserveSig]
    SweepFeature AddUsingPath([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Interface)] Path SweepPath, [In] PartFeatureOperationEnum Operation, [In] SweepProfileOrientationEnum? ProfileOrientation = SweepProfileOrientationEnum.kNormalToPath, [In] [MarshalAs(UnmanagedType.Struct)] object? TaperAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="SweepPath">SweepPath</param>
    /// <param name="GuideRail">GuideRail</param>
    /// <param name="Operation">Operation</param>
    /// <param name="ProfileScaling">ProfileScaling</param>
    [PreserveSig]
    SweepFeature AddUsingPathAndGuideRail([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Interface)] Path SweepPath, [In] [MarshalAs(UnmanagedType.Interface)] Path GuideRail, [In] PartFeatureOperationEnum Operation, [In] SweepProfileScalingEnum? ProfileScaling = SweepProfileScalingEnum.kXYProfileScaling);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="SweepPath">SweepPath</param>
    /// <param name="GuideSurface">GuideSurface</param>
    /// <param name="Operation">Operation</param>
    [PreserveSig]
    SweepFeature AddUsingPathAndGuideSurface([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Interface)] Path SweepPath, [In] [MarshalAs(UnmanagedType.IDispatch)] object GuideSurface, [In] PartFeatureOperationEnum Operation);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Profile">Profile</param>
    /// <param name="SweepPath">SweepPath</param>
    /// <param name="Operation">Operation</param>
    /// <param name="SectionTwistPoints">SectionTwistPoints</param>
    /// <param name="SectionTwistVectors">SectionTwistVectors</param>
    /// <param name="ProfileOrientation">ProfileOrientation</param>
    /// <param name="TaperAngle">TaperAngle</param>
    [PreserveSig]
    SweepFeature AddUsingPathAndSectionTwists([In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Interface)] Path SweepPath, [In] PartFeatureOperationEnum Operation, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SectionTwistPoints, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SectionTwistVectors, [In] SweepProfileOrientationEnum? ProfileOrientation = SweepProfileOrientationEnum.kNormalToPath, [In] [MarshalAs(UnmanagedType.Struct)] object? TaperAngle = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PathCurve">PathCurve</param>
    /// <param name="StartProfileOrientation">StartProfileOrientation</param>
    /// <param name="StartProfileNormal">StartProfileNormal</param>
    /// <param name="Params">Params</param>
    [PreserveSig]
    ObjectsEnumerator GetProfileOrientationAtParam([In] [MarshalAs(UnmanagedType.IDispatch)] object PathCurve, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector StartProfileOrientation, [In] [MarshalAs(UnmanagedType.Interface)] UnitVector StartProfileNormal, [In] [MarshalAs(UnmanagedType.SafeArray)] ref double[,] Params);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="PathCurves">PathCurves</param>
    /// <param name="TrueStartPoint">TrueStartPoint</param>
    [PreserveSig]
    object GetTruePath([In] [MarshalAs(UnmanagedType.IDispatch)] object PathCurves, [In] [MarshalAs(UnmanagedType.Interface)] Point TrueStartPoint);
    /// <summary>
    /// Method that creates the SweepDefinition object.
    /// </summary>
    /// <param name="SweepType">Input SweepTypeEnum indicates which sweep type you will use to create the sweep feature.</param>
    /// <param name="Profile">Input Profile object used to define the shape of the sweep.</param>
    /// <param name="Path">Input entity that defines the path of the sweep.  Use the CreatePath or CreateSpecifiedPath methods on the PartFeatures object to create a Path.  The path can be a combination of 2D and 3D sketch elements and can be open or closed.</param>
    /// <param name="Operation">Input constant that indicates the type of operation to perform.  Valid input is kJoinOperation, kCutOperation, kIntersectOperation, kSurfaceOperation or kNewBodyOperation.</param>
    /// <returns></returns>
    [PreserveSig]
    SweepDefinition CreateSweepDefinition([In] SweepTypeEnum SweepType, [In] [MarshalAs(UnmanagedType.Interface)] Profile Profile, [In] [MarshalAs(UnmanagedType.Interface)] Path Path, [In] PartFeatureOperationEnum Operation);
    /// <summary>
    /// Method that creates the SolidSweepDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SolidSweepDefinition CreateSolidSweepDefinition([In] [MarshalAs(UnmanagedType.Interface)] SurfaceBody ToolBody, [In] [MarshalAs(UnmanagedType.Interface)] Path Path, [In] PartFeatureOperationEnum Operation, [MarshalAs(UnmanagedType.Interface)] ObjectCollection AffectedBodies, [In] bool? KeepToolbody = false);
    /// <summary>
    /// Method that creates a new SweepFeature object.
    /// </summary>
    /// <param name="Definition">Input SweepDefinition object that defines the input for the sweep feature. An SweepDefinition object can be created using the SweepFeatures.CreateSweepDefinition method. It can also be obtained from an existing SweepFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    SweepFeature Add([In] [MarshalAs(UnmanagedType.Interface)] SweepDefinition Definition);
    /// <summary>
    /// Method that creates a new SweepFeature object based on a surfacebody.
    /// </summary>
    /// <param name="Definition">Input SolidSweepDefinition object that defines the input for the sweep feature. An SolidSweepDefinition object can be created using the SweepFeatures.CreateSolidSweepDefinition method. It can also be obtained from an existing SweepFeature object.</param>
    /// <returns></returns>
    [PreserveSig]
    SweepFeature AddSolidSweep([In] [MarshalAs(UnmanagedType.Interface)] SolidSweepDefinition Definition);
}
