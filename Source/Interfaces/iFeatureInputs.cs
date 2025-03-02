namespace Oblikovati.API;

/// <summary>
/// The iFeatureInputs collection object provides access to all of the / iFeatureParameterInput objects associated with a specific iFeatureDefinition object.
/// </summary>
public interface iFeatureInputs : IEnumerable
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
    /// Returns the specified object in the collection.
    /// </summary>
    iFeatureInput this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
