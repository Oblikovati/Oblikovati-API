namespace Oblikovati.API;

/// <summary>
/// The DocumentDescriptorsEnumerator object provides information about native document references held.
/// </summary>
public interface DocumentDescriptorsEnumerator : IEnumerable
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
    /// Returns the specified DocumentDescriptor object from the collection.
    /// </summary>
    DocumentDescriptor this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
}
