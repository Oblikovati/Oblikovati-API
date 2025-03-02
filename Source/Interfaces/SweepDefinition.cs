namespace Oblikovati.API;

/// <summary>
/// The SweepDefinition object is the base class that defines the variables for sweep features.
/// </summary>
public interface SweepDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent SweepFeature of the definition.
    /// </summary>
    SweepFeature Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the collection of bodies affected by this feature.&nbsp;If this property is not set for multi-body parts, the default solid body is used as the affected body.&nbsp;This property applies only to features in a part.
    /// </summary>
    ObjectCollection AffectedBodies { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the collection of occurrences that should participate in this feature.&nbsp;If this property is not set, all possible occurrences will participate.&nbsp;This property applies only to features in an assembly.
    /// </summary>
    ObjectCollection AffectedOccurrences { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the guide rail for the sweep which is the guide curve that controls the scaling and twist of the sweep profile. This property is applicable when the SweepType is kPathAndGuideRailSweepType.
    /// </summary>
    Path GuideRail { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the guide surface the normal of which controls the twist of the swept profile about the path. This property is applicable when the SweepType is kPathAndGuideSurfaceSweepType.
    /// </summary>
    object GuideSurface { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the type of operation used to add the feature to the model.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the entity that defines the path of the sweep.
    /// </summary>
    Path Path { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the profile object used to define the shape of the sweep.
    /// </summary>
    Profile Profile { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the orientation of sweep profile. This property is applicable when the SweepType is kPathSweepType and kPathAndSectionTwistSweepType.
    /// </summary>
    SweepProfileOrientationEnum ProfileOrientation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the scaling direction for sweep profile. This property is applicable when the SweepType is kPathAndGuideRailSweepType.
    /// </summary>
    SweepProfileScalingEnum ProfileScaling { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the sweep type. When set this value the properties in this SweepDefinition which are not supported with the sweep type will be reset.
    /// </summary>
    SweepTypeEnum SweepType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the taper angle of sweep. This property is applicable when the SweepType is kPathSweepType and kPathAndSectionTwistSweepType and when the ProfileOrientation is kNormalToPath.
    /// </summary>
    object TaperAngle { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the twist angle of sweep. This property is applicable when the SweepType is kPathSweepType and the ProfileOrientation is kNormalToPath.
    /// </summary>
    object TwistAngle { get; set; }
    /// <summary>
    /// Method that creates a copy of this SweepDefinition object.&nbsp;The new SweepDefinition object is independent of any feature.&nbsp;It can edited and used as input to edit an existing feature or to create a new Sweep feature.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    SweepDefinition Copy();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="SectionTwistPoints">SectionTwistPoints</param>
    /// <param name="SectionTwistVectors">SectionTwistVectors</param>
    [PreserveSig]
    void GetSectionTwists([Out] [MarshalAs(UnmanagedType.Interface)] out ObjectCollection SectionTwistPoints, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectCollection SectionTwistVectors);
    /// <summary>
    /// Method that sets the twisted sweep sections and the twist conditions at these sections. This method is applicable when the SweepType is kPathAndSectionTwistSweepType.
    /// </summary>
    /// <param name="SectionTwistPoints">Input ObjectCollection that contains the points along the sweep path at which the sweep twists need to be specified. The sweep path points define the positions of the sweep cross-sections at which the twists need to be specified. Since the sweep feature is created by sweeping a profile cross-section along a sweep path, the twist of the sweep can theoretically be controlled at all points along the sweep path. But for practical purposes, the creation of a twisted sweep feature will be limited to sweep features that are swept along a spline path and the twist can only be specified for cross-sections at fit points of the spline path. Since the sweep feature can only be twisted at fit points of the spline that defines the sweep path, the valid input points are only the fit points of the spline that defines the sweep path. If any of the specified input points are not fit points on the sweep path specified by the Path argument, then setting the twists for the sweep sections will fail. Therefore, the valid input objects can be either SketchPoint objects that correspond to any of the fit points of the sweep path if it is a 2D spline or SketchPoint3D objects that correspond to any of the fit points of the sweep path if it is a 3D spline. Since this argument together with the SectionTwistVectors argument defines the twist conditions at all cross-sections of the sweep at which the twist needs to be specified, valid collection objects need to be specified for both these arguments in order to define twist conditions for the sweep. Also, the following conditions need to be satisfied in order to correctly specify both these arguments:
    /// The number of items in the collection specified by this argument must be the same as the number of items in the collection specified by the SectionTwistVectors argument.
    /// The order of the sweep path points in the collection specified by this argument must correspond to the order of the twist unit-vectors in the collection specified by the SectionTwistVectors argument.
    /// Therefore, if a particular item number in the collection specified by this argument corresponds to a particular sweep path point at which the sweep section needs to be twisted, the same item number in the collection specified by the SectionTwistVectors argument should correspond to the twist vector for that sweep section. For example, for a twist condition that needs to be applied for the sweep cross-section at the first fit point of the sweep path, if the first item in the collection specified by this argument is the first fit point of the sweep path, then the first item in the collection specified by the SectionTwistVectors argument must be the twist vector for the cross-section at the first fit point of the sweep path. Setting the twists for the sweep sections will fail for the following cases:
    /// The object collections specified for this argument and the SectionTwistVectors arguments are both empty.
    /// Valid object collections are specified for both this argument and the SectionTwistVectors argument, but any of the sweep path points specified by this argument are not fit points on the sweep path specified by the Path argument.</param>
    /// <param name="SectionTwistVectors">Input ObjectCollection object that specifies the unit-vectors that define the twists for the sweep sections. The sweep twist vectors define the twists for the sweep cross-sections specified using the SectionTwistPoints argument. The twist vectors are unit-vectors specified in the model space coordinate system. Also, each vector should lie on the plane of the sweep cross-section for which it defines the twist, otherwise, setting the twists for the sweep sections will fail. Therefore, the valid input objects are UnitVector objects that specify the twist vector directions for the sweep sections. Since this argument together with the SectionTwistPoints argument defines the twist conditions at all cross-sections of the sweep at which the twist needs to be specified, valid collection objects need to be specified for both these arguments in order to define twist conditions for the sweep. Also, the following conditions need to be satisfied in order to correctly specify both these arguments:
    /// The number of items in the collection specified by this argument must be the same as the number of items in the collection specified by the SectionTwistPoints argument.
    /// The order of the sweep path points in the collection specified by the SectionTwistPoints argument must correspond to the order of the twist unit-vectors in the collection specified by this argument.
    /// Therefore, if a particular item number in the collection specified by the SectionTwistPoints argument corresponds to a particular sweep path point at which the sweep section needs to be twisted, the same item number in the collection specified by this argument should correspond to the twist vector for that sweep section. For example, for a twist condition that needs to be applied for the sweep cross-section at the first fit point of the sweep path, if the first item in the collection specified by the SectionTwistPoints argument is the first fit point of the sweep path, then the first item in the collection specified by this argument must be the twist vector for the cross-section at the first fit point of the sweep path. Setting the twists for the sweep sections will fail for the following cases: The object collections specified for this argument and the SectionTwistPoints arguments are both empty. Valid object collections are specified for both this argument and the SectionTwistPoints argument, but any of the twist unit-vectors specified by this argument does not lie on the respective sweep cross-section plane for which the unit-vector defines the twist.</param>
    [PreserveSig]
    void SetSectionTwists([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SectionTwistPoints, [In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection SectionTwistVectors);
}
