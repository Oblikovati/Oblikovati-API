namespace Oblikovati.API;

/// <summary>
/// The ViewsEnumerator object provides access to a list of <link Inventor::View, View> objects.
/// </summary>
public interface ViewsEnumerator : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    View Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
