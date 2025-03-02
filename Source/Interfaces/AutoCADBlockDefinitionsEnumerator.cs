namespace Oblikovati.API;

/// <summary>
/// The AutoCADBlockDefinitionsEnumerator object enumerates AutoCADBlockDefinition objects
/// </summary>
public interface AutoCADBlockDefinitionsEnumerator : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified AutoCADBlockDefinition object from the collection.
    /// </summary>
    AutoCADBlockDefinition Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
