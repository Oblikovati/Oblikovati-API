namespace Oblikovati.API;

/// <summary>
/// Provides access to a list of objects. See the article in the overviews section.
/// </summary>
public interface TransactionsEnumerator : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    Transaction this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
