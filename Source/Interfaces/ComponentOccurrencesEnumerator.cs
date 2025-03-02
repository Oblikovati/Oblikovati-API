namespace Oblikovati.API;

/// <summary>
/// Provides access to a list of objects.
/// </summary>
public interface ComponentOccurrencesEnumerator : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to objects in the collection.
    /// </summary>
    ComponentOccurrence Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
