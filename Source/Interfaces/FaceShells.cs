namespace Oblikovati.API;

/// <summary>
/// The FaceShells object represents a collection of objects. See the article in the overviews section.
/// </summary>
public interface FaceShells : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to objects in the collection.
    /// </summary>
    FaceShell this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
