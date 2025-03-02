namespace Oblikovati.API;

/// <summary>
/// The BrowserFoldersEnumerator object provides access to all browser folders directly under a browser node.
/// </summary>
public interface BrowserFoldersEnumerator : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified BrowserFolder object from the collection.
    /// </summary>
    BrowserFolder Item { get; }
}
