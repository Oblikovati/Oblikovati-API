namespace Oblikovati.API;

/// <summary>
/// The FilesEnumerator object provides access to all Inventor files.
/// </summary>
public interface FilesEnumerator : IEnumerable
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
    /// Returns the specified File object from the collection.
    /// </summary>
    File Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
}
