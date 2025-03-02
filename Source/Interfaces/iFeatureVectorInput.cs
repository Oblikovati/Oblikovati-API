namespace Oblikovati.API;

/// <summary>
/// The iFeatureVectorInput object represents the vector input information of an iFeature.
/// </summary>
public interface iFeatureVectorInput
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
    /// Property that gets the prompt that is used for this input during the placement of the iFeature.
    /// </summary>
    string Prompt { get; }
    /// <summary>
    /// Property that gets the name associated with this input. When placing an iFeature using the API you can use the name to identify each input when assigning the desired values and entities.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Property that returns the type of geometry that are valid. The value returned is the sum of values specifying the valid entity types.
    /// </summary>
    iFeatureEntityInputTypeEnum EntityType { get; }
    /// <summary>
    /// Gets and sets the geometry matching the vector input.
    /// </summary>
    object LineInput { get; set; }
    /// <summary>
    /// Gets and sets whether the geometry selection needs to be flipped.
    /// </summary>
    bool FlipOption { get; set; }
}
