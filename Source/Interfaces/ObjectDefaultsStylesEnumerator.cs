namespace Oblikovati.API;

/// <summary>
/// The ObjectDefaultsStylesEnumerator object allows iteration through the collection.
/// </summary>
public interface ObjectDefaultsStylesEnumerator : IEnumerable
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
    /// Returns the specified object in the collection.
    /// </summary>
    ObjectDefaultsStyle Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
