namespace Oblikovati.API;

/// <summary>
/// The FaceFeatureDefinition object represents all of the information that defines a face feature.
/// </summary>
public interface FaceFeatureDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets and sets the extent direction which indicates which side of the sketch the projection of the face is in.
    /// </summary>
    PartFeatureExtentDirectionEnum Direction { get; set; }
    /// <summary>
    /// Get and sets the BendDefinition object that defines the bend information for this face feature.
    /// </summary>
    BendDefinition BendDefinition { get; set; }
    /// <summary>
    /// Gets and sets the Profile object that defines the shape of the face feature.
    /// </summary>
    Profile Profile { get; set; }
    /// <summary>
    /// Property that returns the parent FaceFeature object of this FaceFeatureDefinition object.
    /// </summary>
    FaceFeature Parent { get; }
    /// <summary>
    /// Gets and sets the type of operation used to add the feature to the model.&nbsp;Valid inputs are kNewBodyOperation, kJoinOperation.
    /// </summary>
    PartFeatureOperationEnum Operation { get; set; }
    /// <summary>
    /// Gets and sets the collection of bodies affected by this feature.&nbsp;If this property is not set for multi-body parts, the default solid body is used as the affected body.
    /// </summary>
    ObjectCollection AffectedBodies { get; set; }
    /// <summary>
    /// Read-write property that gets and sets whether to use the document active sheet metal style for the body the feature is in. Set this property is applicable only when the feature is the first feature in a solid body and this can only be set to True from False.
    /// </summary>
    bool UseDefaultSheetMetalRule { get; set; }
    /// <summary>
    /// Read-write property that gets and sets the sheet metal style for the body the feature is in. Set this property is applicable only when the feature is the first feature in a solid body. When set this property the default sheet metal rule will be overridden and.
    /// </summary>
    SheetMetalStyle SheetMetalRule { get; set; }
}
