namespace Oblikovati.API;

/// <summary>
/// The ParametersEnumerator object allows enumeration through available parameters.
/// </summary>
public interface ParametersEnumerator : IEnumerable
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
    /// Returns the specified Parameter object from the collection. This is the default property of the ParametersEnumerator collection object.
    /// </summary>
    Parameter Item { get; }
}
