namespace Oblikovati.API;

/// <summary>
/// Generic collection of weakly-typed objects (IDispatch).
/// </summary>
public interface ObjectCollection : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
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
    /// <param name="Object">Input Object to add to the collection.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.IDispatch)] object Object);
    /// <summary>
    /// Method that removes the specified object from the generic collection.
    /// </summary>
    /// <param name="Index">Input Long value that specifies the index of the object to remove.</param>
    [PreserveSig]
    void Remove([In] int Index);
    /// <summary>
    /// Method that removes the specified object from the generic object collection.
    /// </summary>
    /// <param name="Object">Input Object to remove.</param>
    [PreserveSig]
    void RemoveByObject([In] [MarshalAs(UnmanagedType.IDispatch)] object Object);
    /// <summary>
    /// Removes all objects from the generic collection.
    /// </summary>
    [PreserveSig]
    void Clear();
}
