namespace Oblikovati.API;

/// <summary>
/// Generic collection of weakly-typed objects (IDispatch).
/// </summary>
public interface ObjectCollectionByVariant : IEnumerable
{
    /// <summary>
    /// Returns the specified object in the collection. The index can be numeric or the object name.
    /// </summary>
    object Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Adds an object to the generic collection.
    /// </summary>
    /// <param name="StringIndex">Input String that specifies the index key for the item.</param>
    /// <param name="Object">Input Object to add to the collection.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.BStr)] string StringIndex, [In] [MarshalAs(UnmanagedType.IDispatch)] object Object);
    /// <summary>
    /// Method that removes the specified object from the generic collection.
    /// </summary>
    /// <param name="Index">Input Variant value that specifies the index of the object to remove.</param>
    [PreserveSig]
    void Remove([In] [MarshalAs(UnmanagedType.Struct)] object Index);
}
