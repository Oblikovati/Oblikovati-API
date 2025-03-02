namespace Oblikovati.API;

/// <summary>
/// This object provides access to the individual objects in a collection of nodes; for example the nested children of a given .
/// </summary>
public interface BrowserNodesEnumerator : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection. Only the immediate children are counted.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified object from the collection.
    /// </summary>
    BrowserNode Item { get; }
    /// <summary>
    /// Returns the specified object from the collection.
    /// </summary>
    /// <param name="Id">Input long value that specifies the unique and custom identifier of a in this collection. The identifier was supplied at creation time of the ClientBrowserNode. If no such ClientBrowserNode is found in the collection, an error will occur.</param>
    /// <returns></returns>
    [PreserveSig]
    BrowserNode ItemById([In] int Id);
}
