namespace Oblikovati.API;

/// <summary>
/// RuledSurfaceEdgeFacePairs collection object.
/// </summary>
public interface RuledSurfaceEdgeFacePairs : IEnumerable
{
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows VARIANT-indexed access to items in the collection. You can use names as indexes as well.
    /// </summary>
    RuledSurfaceEdgeFacePair this[int Index] { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Method that adds a new RuledSurfaceEdgeFacePair to the collection.
    /// </summary>
    /// <param name="Edge">Input Edge object.</param>
    /// <param name="Face">Input Face object.</param>
    /// <returns></returns>
    [PreserveSig]
    RuledSurfaceEdgeFacePair Add([In] [MarshalAs(UnmanagedType.Interface)] Edge Edge, [In] [MarshalAs(UnmanagedType.Interface)] Face Face);
}
