namespace Oblikovati.API;

/// <summary>
/// The Views collection object provides access to all of the graphic <link Inventor::View, View> objects associated with a particular document. It also provides functionality to create new views.
/// </summary>
public interface Views : IEnumerable
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
    /// <summary>
    /// Create a new view of the document.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    View Add();
}
