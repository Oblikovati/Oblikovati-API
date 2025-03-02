namespace Oblikovati.API;

/// <summary>
/// The DistanceFromFaceExtent object provides access to the information that defines the extent for a feature that's extent is determined by extruding from a Face with offset. This is derived from the PartFeatureExtent object.
/// </summary>
public interface DistanceFromFaceExtent
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
    /// Property that returns the parent PartFeature of the definition.
    /// </summary>
    PartFeature Parent { get; }
    /// <summary>
    /// Read-write property that gets and sets the distance direction of the feature. Valid input is kPositiveExtentDirection, kNegativeExtentDirection, or kSymmetricExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.
    /// </summary>
    PartFeatureExtentDirectionEnum Direction { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the alternate solution direction of the feature. Valid input is kPositiveExtentDirection or kNegativeExtentDirection. kPositiveExtentDirection defines the offset direction to be in the same direction as the normal of the sketch plane.
    /// </summary>
    PartFeatureExtentDirectionEnum AlternateSolutionDirection { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether the feature starts from the nearest valid face when there are multiple options for valid starting faces.
    /// </summary>
    bool MinimumSolution { get; set; }
    /// <summary>
    /// Read-only property that returns the parameter controlling the distance extent of the feature.
    /// </summary>
    object Distance { get; }
    /// <summary>
    /// Read-only property that returns the parameter controlling the distance extent of the feature in the other direction. This returns Nothing if the IsTwoDirectional returns False.
    /// </summary>
    object DistanceTwo { get; }
    /// <summary>
    /// Read-write property that gets and sets the distance from face, this can be a Face or WorkPlane object. This is applicable when the Direction is not set to kSymmetricExtentDirection.
    /// </summary>
    bool IsTwoDirectional { get; set; }
    /// <summary>
    /// Property that gets and sets whether the 'from face' should be extended to contain the extents of the feature. This property is not valid for every surface type.
    /// </summary>
    bool ExtendFromFace { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the distance from face, this can be a Face or WorkPlane object.
    /// </summary>
    object FromFace { get; set; }
}
