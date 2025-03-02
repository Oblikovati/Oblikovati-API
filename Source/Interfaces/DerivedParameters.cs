namespace Oblikovati.API;

/// <summary>
/// Provides access to the derived parameters associated with the DerivedParameterTable object the collection was obtained from.
/// </summary>
public interface DerivedParameters : IEnumerable
{
    /// <summary>
    /// Method that returns the specified DerivedParameter object from the collection. This is the default method of the DerivedParameters collection object.
    /// </summary>
    DerivedParameter this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
