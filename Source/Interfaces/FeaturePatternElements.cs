namespace Oblikovati.API;

/// <summary>
/// Provides access to the instances ( objects) that result from the creation of a feature pattern.
/// </summary>
public interface FeaturePatternElements : IEnumerable
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
    /// Returns the specified object from the collection. This is the default property of the FeaturePatternElements collection object.
    /// </summary>
    FeaturePatternElement Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
