namespace Oblikovati.API;

/// <summary>
/// Provides access to the objects associated with the ParameterTable object the collection was obtained from.
/// </summary>
public interface TableParameters : IEnumerable
{
    /// <summary>
    /// Returns the specified TableParameter object from the collection. This is the default property of the TableParameters collection object.
    /// </summary>
    TableParameter Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
