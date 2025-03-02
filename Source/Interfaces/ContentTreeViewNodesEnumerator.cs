namespace Oblikovati.API;

/// <summary>
/// The ContentFamiliesEnumerator is a collection object that provides access to a group of ContentFamily objects.
/// </summary>
public interface ContentTreeViewNodesEnumerator : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of ContentTreeViewNode objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified ContentTreeViewNode object from the collection.
    /// </summary>
    ContentTreeViewNode Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
