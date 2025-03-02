namespace Oblikovati.API;

/// <summary>
/// The EdgeCollection object provides access to all of the and EdgeCollection objects in a collection and provides methods to add Edge and EdgeCollection objects to the collection.
/// </summary>
public interface EdgeCollection : IEnumerable
{
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    object this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns how the edge collection was constructed. Valid returns are kAllConcave, kAllConvex, kTangentiallyConnected, and kUndefined. This property is set when the EdgeCollection object is originally created. When the ConcaveEdges property of the SurfaceBody object is used, it is set to kAllConcave. When the ConvexEdges property of the SurfaceBody object is used, it is set to kAllConvex. When the TangentiallyConnectedEdges property of the Edge object is used, it is set to kTangentiallyConnected. When it is created using the CreateEdgeCollection method of the TransientObjects it is set to kUndefined. If an EdgeCollection has a collection type other than kUndefined and the contents are changed by adding or removing items from the collection, the CollectionType will be reset to kUndefined.
    /// </summary>
    EdgeCollectionEnum CollectionType { get; }
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
