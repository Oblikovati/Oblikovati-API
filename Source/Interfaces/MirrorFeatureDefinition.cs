namespace Oblikovati.API;

/// <summary>
/// Part Rectangular Pattern Definition object.
/// </summary>
public interface MirrorFeatureDefinition
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-write property that gets and sets the collection of bodies affected by this feature.&nbsp;If this property is not set for multi-body parts, the default solid body is used as the affected body.&nbsp;This property applies only to features in a part. This is only ap.
    /// </summary>
    ObjectCollection AffectedBodies { get; set; }
    /// <summary>
    /// Read-write property that that indicates the method of solution for the pattern.
    /// </summary>
    PatternComputeTypeEnum ComputeType { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the type of operation used to add the feature to the model. This is only applied when MirrorOfBody is True. Valid values are kNewBodyOperation and kJoinOperation.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the parent features of the pattern.
    /// </summary>
    ObjectCollection ParentFeatures { get; set; }
    /// <summary>
    /// Read-only property that gets whether this mirror feature resulted from mirroring the SurfaceBody objects.
    /// </summary>
    bool MirrorOfBody { get; }
    /// <summary>
    /// Read-write property that gets and sets the mirror plane.&nbsp;This can be either a planar face or work plane.
    /// </summary>
    object MirrorPlaneEntity { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to remove the original portion after the mirror operation. This property only applies if&nbsp;MirrorOfBody is True.
    /// </summary>
    bool RemoveOriginal { get; set; }
    /// <summary>
    /// Method that creates a copy of this MirrorFeatureDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    MirrorFeatureDefinition Copy();
}
