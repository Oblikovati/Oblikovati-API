namespace Oblikovati.API;

/// <summary>
/// The SelectSet object acts as a container for all of the objects that are currently selected using the Select command. See the article in the overviews section.
/// </summary>
public interface SelectSet : IEnumerable
{
    /// <summary>
    /// Returns the specified object from the select set.
    /// </summary>
    object Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of objects in the select set.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that adds an entity to the select set.
    /// </summary>
    /// <param name="Entity">Input Autodesk Inventor object that is valid to be selected. This method will fail in the case where an unselectable object is provided. For example, you can't select a Document or Matrix object.</param>
    [PreserveSig]
    void Select([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity);
    /// <summary>
    /// Method that removes the specified object from the select set.
    /// </summary>
    /// <param name="Index">Input value that specifies the object to remove. This can be a Long which specifies the index within the collection of the item to remove, or it can be the object you wish to remove. This only removes the object from the select set. It does not delete it from the document.</param>
    [PreserveSig]
    void Remove([In] [MarshalAs(UnmanagedType.Struct)] object Index);
    /// <summary>
    /// Method that removes all objects from the select set.
    /// </summary>
    [PreserveSig]
    void Clear();
    /// <summary>
    /// Method that deletes all deletable objects in the select set. This is the equivalent of the Delete command. Not all objects that are selectable can be deleted. For example, you can select an edge, but it cannot be deleted. Any undeletable objects in the select set are ignored.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Adds multiple entities to the select set.
    /// </summary>
    /// <param name="Entities">Object collection of entities to add to the set.</param>
    [PreserveSig]
    void SelectMultiple([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Entities);
}
