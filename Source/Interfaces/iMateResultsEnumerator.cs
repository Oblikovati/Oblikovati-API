namespace Oblikovati.API;

/// <summary>
/// Object that represents an iMateResultsEnumerator. Presents a snapshot of the set of objects.
/// </summary>
public interface iMateResultsEnumerator : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    iMateResult this[int Index] { get; }
}
