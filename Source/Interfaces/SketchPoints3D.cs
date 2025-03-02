namespace Oblikovati.API;

/// <summary>
/// The SketchPoints3D object provides access to all the objects in a sketch. See the article in the overviews section.
/// </summary>
public interface SketchPoints3D : IEnumerable
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
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified SketchPoint3D object from the collection.
    /// </summary>
    SketchPoint3D this[int Index] { get; }
    /// <summary>
    /// Method that creates a new 3D sketch point at the specified coordinate.
    /// </summary>
    /// <param name="Point">Input object that defines the position of the 3D sketch point.</param>
    /// <param name="HoleCenter">Optional input Boolean that specifies if the point is a hole center or not.</param>
    /// <returns></returns>
    [PreserveSig]
    SketchPoint3D Add([In] [MarshalAs(UnmanagedType.Interface)] Point Point, [In] bool? HoleCenter = true);
}
