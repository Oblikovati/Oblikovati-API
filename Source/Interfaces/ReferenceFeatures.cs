namespace Oblikovati.API;

/// <summary>
/// The ReferenceFeatures collection object provides access to all of the existing objects in a part component definition.
/// </summary>
public interface ReferenceFeatures : IEnumerable
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
    /// Returns the specified ReferenceFeature object from the collection.
    /// </summary>
    ReferenceFeature this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
}
