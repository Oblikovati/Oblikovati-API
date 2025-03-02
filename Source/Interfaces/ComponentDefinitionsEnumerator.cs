namespace Oblikovati.API;

/// <summary>
/// Provides access to a list of objects.
/// </summary>
public interface ComponentDefinitionsEnumerator : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Allows integer-indexed access to objects in the collection.
    /// </summary>
    ComponentDefinition Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
