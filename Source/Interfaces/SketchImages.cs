namespace Oblikovati.API;

/// <summary>
/// The SketchImages collection object provides access to all the images in a sketch.
/// </summary>
public interface SketchImages : IEnumerable
{
    /// <summary>
    /// Method that returns the specified Image object from the collection.
    /// </summary>
    SketchImage Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates an image based on an input picture file name.
    /// </summary>
    /// <param name="FullFileName">Specifies the full file name of a picture file that contains the image to be inserted.</param>
    /// <param name="Position">Object that specifies the position on the sketch to insert the image at.</param>
    /// <param name="Link">Boolean that specifies whether or not to link the input source file. The default value is True indicating the file will be linked.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchImage Add([In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] [MarshalAs(UnmanagedType.Interface)] Point2d Position, [In] bool? Link = true);
}
