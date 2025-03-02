namespace Oblikovati.API;

/// <summary>
/// A ViewList object is a collection of <link Inventor::View, View> objects.
/// </summary>
public interface ViewList : IEnumerable
{
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified object in the collection.
    /// </summary>
    View Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that adds a View object to the collection.
    /// </summary>
    /// <param name="View">View object to add.</param>
    [PreserveSig]
    void Add([In] [MarshalAs(UnmanagedType.Interface)] View View);
    /// <summary>
    /// Method that removes a View object from the collection.
    /// </summary>
    /// <param name="View">View object to remove.</param>
    [PreserveSig]
    void Remove([In] [MarshalAs(UnmanagedType.Interface)] View View);
}
