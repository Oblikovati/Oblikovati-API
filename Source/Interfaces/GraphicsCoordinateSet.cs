namespace Oblikovati.API;

/// <summary>
/// The GraphicsCoordinateSet object contains a list of coordinate values. This object can be referenced by any number of graphic primitives to use in defining their coordinates.
/// </summary>
public interface GraphicsCoordinateSet
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of objects in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property returning the unique id of this GraphicsDataSet.
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    Point Coordinate { get; set; }
    /// <summary>
    /// Method that removes a coordinate from the set.
    /// </summary>
    /// <param name="Index">Specifies the index you want to remove from the set. All coordinates above the Index will be shifted down. The coordinate set indices are one-based.</param>
    [PreserveSig]
    void Remove([In] int Index);
    /// <summary>
    /// Method that deletes the GraphicsDataSet.
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Method that adds a single coordinate to the set.
    /// </summary>
    /// <param name="Index">Specifies the index you want this coordinate to be within the set. All coordinates above the Index will be shifted up to make room for this index. Specifying any number greater than the current count of the set will cause the coordinate to become the last in the set. The coordinate set indices are one-based.</param>
    /// <param name="Coordinate">Input object that specifies the coordinate to add.</param>
    [PreserveSig]
    void Add([In] int Index, [In] [MarshalAs(UnmanagedType.Interface)] Point Coordinate);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coordinates">Coordinates</param>
    [PreserveSig]
    void GetCoordinates([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Coordinates);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Coordinates">Coordinates</param>
    [PreserveSig]
    void PutCoordinates([Out] [MarshalAs(UnmanagedType.SafeArray)] out double[,] Coordinates);
}
