namespace Oblikovati.API;

/// <summary>
/// The HighlightSet object defines a set of objects and an associated color to display them with.
/// </summary>
public interface HighlightSet : IEnumerable
{
    /// <summary>
    /// Returns the specified object from the highlight set.
    /// </summary>
    object this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of objects in the highlight set.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Gets/Sets the color of the highlight set.
    /// </summary>
    Color Color { get; set; }
    /// <summary>
    /// Method that removes the specified object from the highlight set.
    /// </summary>
    /// <param name="Index">Input value that specifies the object to remove. This can be a Long, which specifies the index within the collection of the item to remove, or it can be the object you wish to remove. This method only removes the object from the highlight set. It does not delete it from the document.</param>
    [PreserveSig]
    void Remove([In] [MarshalAs(UnmanagedType.Struct)] object Index);
    /// <summary>
    /// Method that removes all objects from the highlight set.
    /// </summary>
    [PreserveSig]
    void Clear();
    /// <summary>
    /// Method that deletes the HighlightSet object.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that adds an entity to the highlight set.
    /// </summary>
    /// <param name="Entity">Input Autodesk Inventor object that is valid to be highlighted.</param>
    [PreserveSig]
    void AddItem([In] [MarshalAs(UnmanagedType.IDispatch)] object Entity);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void GetColor([Out] out int Red, [Out] out int Green, [Out] out int Blue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void SetColor([In] int Red, [In] int Green, [In] int Blue);
    /// <summary>
    /// Adds multiple entities to the highlight set.
    /// </summary>
    /// <param name="Entities">Input ObjectCollection that specifies the entities to highlight.</param>
    [PreserveSig]
    void AddMultipleItems([In] [MarshalAs(UnmanagedType.Interface)] ObjectCollection Entities);
}
