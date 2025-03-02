namespace Oblikovati.API;

/// <summary>
/// The AssetsEnumerator collection object provides access to a set of assets.
/// </summary>
public interface AssetsEnumerator : IEnumerable
{
    /// <summary>
    /// Read-only property returning kAssetsEnumeratorObject indicating this object’s type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Read-only property that returns the specified Asset object from the collection.
    /// </summary>
    Asset Item { get; }
}
