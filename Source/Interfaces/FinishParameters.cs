namespace Oblikovati.API;

/// <summary>
/// FinishParameters Object.
/// </summary>
public interface FinishParameters : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    FinishParameter Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
}
