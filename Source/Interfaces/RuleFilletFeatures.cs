namespace Oblikovati.API;

/// <summary>
/// The RuleFilletFeatures collection object provides access to the RuleFilletFeature objects
/// </summary>
public interface RuleFilletFeatures : IEnumerable
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
    /// Returns the specified RuleFilletFeature object from the collection.
    /// </summary>
    RuleFilletFeature Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
