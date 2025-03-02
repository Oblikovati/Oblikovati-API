namespace Oblikovati.API;

/// <summary>
/// The LoftDefinition object is used to define additional input required for creating loft features.
/// </summary>
public interface LoftDefinition
{
    /// <summary>
    /// Property that specifies the centerline for the loft. Valid objects includes Profile, Profile3D, EdgeLoop and EdgeCollection. When this LoftDefinition is associative with an existing LoftFeature or if it is copied from an LoftDefinition that is associative with a LoftFeature, then set this property you should follow below rules, otherwise an error would occur:
    /// If the LoftDefinition.LoftType returns kRegularLoft you can set this property directly.
    /// If the LoftDefinition.LoftType returns kLoftWithRails you need to clear the LoftDefinition.LoftRails before setting this property.
    /// If the LoftDefinition.LoftType returns kLoftWithAreaGraphSections you need to clear the LoftDefinition.LoftSectionDimensions if any before setting this property,
    /// </summary>
    object Centerline { get; set; }
    /// <summary>
    /// Property that specifies whether the loft needs to be closed or not.
    /// </summary>
    bool Closed { get; set; }
    /// <summary>
    /// Property that specifies the angle of the loft in relation to the sketch plane of the starting section.
    /// </summary>
    object FirstSectionAngle { get; set; }
    /// <summary>
    /// Property that specifies the condition of the loft at the starting section.
    /// </summary>
    LoftConditionEnum FirstSectionCondition { get; set; }
    /// <summary>
    /// Property that specifies the impact the starting section's condition has on the shape of the entire loft.
    /// </summary>
    object FirstSectionImpact { get; set; }
    /// <summary>
    /// Property that specifies whether the takeoff direction for the starting section should be reversed from its default direction.
    /// </summary>
    bool FirstSectionDirectionReversed { get; set; }
    /// <summary>
    /// Property that specifies the tangent plane for the starting section in the case that the section is a point.
    /// </summary>
    object FirstSectionTangentPlane { get; set; }
    /// <summary>
    /// Property that specifies the angle of the loft in relation to the sketch plane of the ending section.
    /// </summary>
    object LastSectionAngle { get; set; }
    /// <summary>
    /// Property that specifies the condition of the loft at the ending section.
    /// </summary>
    LoftConditionEnum LastSectionCondition { get; set; }
    /// <summary>
    /// Property that specifies the impact the ending section's condition has on the shape of the entire loft.
    /// </summary>
    object LastSectionImpact { get; set; }
    /// <summary>
    /// Property that specifies whether the takeoff direction for the ending section should be reversed from its default direction.
    /// </summary>
    bool LastSectionDirectionReversed { get; set; }
    /// <summary>
    /// Property that specifies the tangent plane for the ending section in the case that the section is a point.
    /// </summary>
    object LastSectionTangentPlane { get; set; }
    /// <summary>
    /// Read-only property that specifies the rails for the loft. If the LoftDefinition.LoftType is not kRegularLoft or kLoftWithRails then set this property will raise error, you should follow below rules to set this property:
    /// If the LoftDefinition.LoftType returns kRegularLoft you can set this property directly.
    /// If the LoftDefinition.LoftType returns kLoftWithCenterline you need to clear the LoftDefinition.Centerline before setting this property.
    /// If the LoftDefinition.LoftType returns kLoftWithAreaGraphSections you need to clear the LoftDefinition.LoftSectionDimensions if any and LoftDefinition.Centerline before setting this property,
    /// </summary>
    LoftRails LoftRails { get; }
    /// <summary>
    /// Read-only property that specifies the placed section dimensions for an area-graph type loft. Before adding new LoftSectionDimension into this collection the LoftDefinition.Centerline should be set first, otherwise an error would occur.
    /// </summary>
    LoftSectionDimensions LoftSectionDimensions { get; }
    /// <summary>
    /// Property that specifies the mapping to use between sections.
    /// </summary>
    MapPointCurves MapPointCurves { get; set; }
    /// <summary>
    /// Property that specifies if the tangent faces of the loft should be merged or not.
    /// </summary>
    bool MergeTangentFaces { get; set; }
    /// <summary>
    /// Property that specifies the type of operation used to add the feature to the model.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Property that specifies the sections used for a loft.
    /// </summary>
    ObjectCollection Sections { get; set; }
    /// <summary>
    /// Property that gets the type of loft feature.
    /// </summary>
    LoftTypeEnum LoftType { get; }
    /// <summary>
    /// Method that creates and returns a copy of this loft definition.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    LoftDefinition Copy();
}
