namespace Oblikovati.API;

/// <summary>
/// The ContourRollFeatures collection object provides access to the ContourRollFeature objects.
/// </summary>
public interface ContourRollFeatures : IEnumerable
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
    /// Returns the specified ContourRollFeature object from the collection.
    /// </summary>
    ContourRollFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of ContourRollFeature objects in the collection.
    /// </summary>
    int Count { get; }
}
