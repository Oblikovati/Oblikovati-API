namespace Oblikovati.API;

/// <summary>
/// ModelDatumReferenceFrameDefinition Object.
/// </summary>
public interface ModelDatumReferenceFrameDefinition
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application _Application { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelDatumReferenceFrame Parent { get; }
    /// <summary>
    /// Gets and sets the Matrix object that defines the model datum reference frame coordinate system.
    /// </summary>
    Matrix CoordinateSystem { get; set; }
    /// <summary>
    /// Gets or sets the primary datum for the model datum reference frame.
    /// </summary>
    ModelToleranceFeature PrimaryDatum { get; set; }
    /// <summary>
    /// Gets or sets the secondary datum for the model datum reference frame.
    /// </summary>
    ModelToleranceFeature SecondaryDatum { get; set; }
    /// <summary>
    /// Gets or sets the tertiary datum for the model datum reference frame.
    /// </summary>
    ModelToleranceFeature TertiaryDatum { get; set; }
    /// <summary>
    /// Gets or sets the primary compound datum.
    /// </summary>
    ModelToleranceFeature PrimaryCompoundDatum { get; set; }
    /// <summary>
    /// Gets or sets the secondary compound datum.
    /// </summary>
    ModelToleranceFeature SecondaryCompoundDatum { get; set; }
    /// <summary>
    /// Gets or sets the tertiary compound datum.
    /// </summary>
    ModelToleranceFeature TertiaryCompoundDatum { get; set; }
    /// <summary>
    /// Gets or sets the primary material condition for the model datum reference frame.
    /// </summary>
    MaterialConditionEnum PrimaryMaterialCondition { get; set; }
    /// <summary>
    /// Gets or sets the secondary material condition for the model datum reference frame.
    /// </summary>
    MaterialConditionEnum SecondaryMaterialCondition { get; set; }
    /// <summary>
    /// Gets or sets the tertiary material condition for the model datum reference frame.
    /// </summary>
    MaterialConditionEnum TertiaryMaterialCondition { get; set; }
    /// <summary>
    /// Gets or sets the primary compound material condition for the model datum reference frame.
    /// </summary>
    MaterialConditionEnum PrimaryCompoundMaterialCondition { get; set; }
    /// <summary>
    /// Gets or sets the secondary compound material condition for the model datum reference frame.
    /// </summary>
    MaterialConditionEnum SecondaryCompoundMaterialCondition { get; set; }
    /// <summary>
    /// Gets or sets the tertiary compound material condition for the model datum reference frame.
    /// </summary>
    MaterialConditionEnum TertiaryCompoundMaterialCondition { get; set; }
    /// <summary>
    /// Creates a copy of this ModelDatumReferenceFrameDefinition object.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    ModelDatumReferenceFrameDefinition Copy();
}
