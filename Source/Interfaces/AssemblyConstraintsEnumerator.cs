namespace Oblikovati.API;

/// <summary>
/// Provides access to the constraints acting directly on a particular occurrence.
/// </summary>
public interface AssemblyConstraintsEnumerator : IEnumerable
{
    /// <summary>
    /// Returns the specified AssemblyConstraint object from the collection. This is the default property of the AssemblyConstraintsEnumerator collection object.
    /// </summary>
    AssemblyConstraint Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
