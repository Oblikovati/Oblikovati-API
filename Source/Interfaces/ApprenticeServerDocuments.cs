namespace Oblikovati.API;

/// <summary>
/// Provides access to a list of objects.
/// </summary>
public interface ApprenticeServerDocuments : IEnumerable
{
    /// <summary>
    /// Returns the specified ApprenticeServerDocument object from the collection. This is the default property of the ApprenticeServerDocuments object.
    /// </summary>
    ApprenticeServerDocument this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
