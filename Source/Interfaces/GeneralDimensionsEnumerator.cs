namespace Oblikovati.API;

/// <summary>
/// The GeneralDimensionsEnumerator object provides access to the existing objects.
/// </summary>
public interface GeneralDimensionsEnumerator : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified DrawingStandardStyle object from the collection.
    /// </summary>
    GeneralDimension Item { get; }
}
