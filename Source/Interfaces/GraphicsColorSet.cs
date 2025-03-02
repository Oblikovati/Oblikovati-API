namespace Oblikovati.API;

/// <summary>
/// The GraphicsColorSet object contains a list of colors. This object can be referenced by any number of graphic primitives to use in defining triangle or vertex specific colors to use when rendering.
/// </summary>
public interface GraphicsColorSet
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
    /// Property that gets and sets the color at a given index in the set.
    /// </summary>
    Color Color { get; set; }
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Index">Index</param>
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void GetColor([In] int Index, [Out] out byte Red, [Out] out byte Green, [Out] out byte Blue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Index">Index</param>
    /// <param name="Red">Red</param>
    /// <param name="Green">Green</param>
    /// <param name="Blue">Blue</param>
    [PreserveSig]
    void PutColor([In] int Index, [In] byte Red, [In] byte Green, [In] byte Blue);
    /// <summary>
    /// Method that adds a new color to the set.
    /// </summary>
    /// <param name="Index">Input Long value that specifies the index of the object to return.</param>
    /// <param name="Red">Input value that specifies the red component of the color. This must be a value between 0 and 255.</param>
    /// <param name="Green">Input Byte that specifies the green component of the color. This value must be between 0 and 255.</param>
    /// <param name="Blue">The blue component of the color. A Byte value between 0 and 255.</param>
    [PreserveSig]
    void Add([In] int Index, [In] byte Red, [In] byte Green, [In] byte Blue);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Colors">Colors</param>
    [PreserveSig]
    void GetColors([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] Colors);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Colors">Colors</param>
    [PreserveSig]
    void PutColors([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] Colors);
}
