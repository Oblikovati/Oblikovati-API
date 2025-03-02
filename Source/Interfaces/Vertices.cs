namespace Oblikovati.API;

/// <summary>
/// The Vertices object represents a collection of <link Inventor::Vertex, Vertex> objects.
/// </summary>
public interface Vertices : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    Vertex Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
