namespace Oblikovati.API;

/// <summary>
/// The GraphicsImageSet defines images that can be used when displaying client graphics objects that support images. Currently this is limited to the GraphicsPoint object.
/// </summary>
public interface GraphicsImageSet
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
    /// Method that adds a new custom point to the set.
    /// </summary>
    /// <param name="Index">Input Long that specifies the position you want this image to have within the set. All images above the specified index will be shifted up to make room for this image. Specifying any number greater than the current count of the set will cause the new image to become the last in the set.</param>
    /// <param name="Image">Input picture to use for the image. This should be the size that you want the point to appear on the screen.</param>
    /// <param name="TransparentColor">Optional input Color object that defines the transparent color within the image. If this argument is not supplied and the image provided doesn't define a transparent color, then there won't be any transparency.</param>
    /// <param name="HotPointX">Optional input Integer that defines the x coordinate of the hot spot as defined in pixels of the image where 0,0 is the top-left corner of the image. The default value of -1 will result in the center of the image being used.</param>
    /// <param name="HotPointY">Optional input Integer that defines the x coordinate of the hot spot as defined in pixels of the image where 0,0 is the top-left corner of the image. The default value of -1 will result in the center of the image being used.</param>
    [PreserveSig]
    void Add([In] int Index, [In] [MarshalAs(UnmanagedType.Interface)] IPictureDisp Image, [In] [MarshalAs(UnmanagedType.Struct)] object? TransparentColor = default, [In] int? HotPointX = default, [In] int? HotPointY = default);
}
