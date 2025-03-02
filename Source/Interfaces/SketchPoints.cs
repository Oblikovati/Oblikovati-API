namespace Oblikovati.API;

/// <summary>
/// The SketchPoints object provides access to all the objects in a sketch and provides methods to create additional sketch points. See the article in the overviews section.
/// </summary>
public interface SketchPoints : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified SketchPoint object from the collection.
    /// </summary>
    SketchPoint this[int Index] { get; }
    /// <summary>
    /// Method that creates a new sketch point at the specified coordinate.
    /// </summary>
    /// <param name="Point">Input that defines the position of the sketch point.</param>
    /// <param name="HoleCenter">Optional input Boolean that specifies if the point is a hole center or not.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchPoint Add([In] [MarshalAs(UnmanagedType.Interface)] Point2d Point, [In] bool? HoleCenter = true);
}
