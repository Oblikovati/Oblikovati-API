namespace Oblikovati.API;

/// <summary>
/// The FeatureDimensions collection object contains all the dimensions that are associated with a feature. These do not include the dimensions within sketches used by the feature.
/// </summary>
public interface FeatureDimensions : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified FeatureDimension object from the collection.
    /// </summary>
    FeatureDimension this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that displays all the dimensions for the feature. This is the equivalent of the 'Show Dimensions' command in the user interface.
    /// </summary>
    [PreserveSig]
    void Show();
}
