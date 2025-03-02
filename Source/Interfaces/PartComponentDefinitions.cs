namespace Oblikovati.API;

/// <summary>
/// The Part ComponentDefinitions object represents a collection of objects.
/// </summary>
public interface PartComponentDefinitions : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    PartComponentDefinition Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
