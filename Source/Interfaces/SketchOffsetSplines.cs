namespace Oblikovati.API;

/// <summary>
/// The SketchOffsetSplines object provides access to all the objects in a sketch. See the article in the overviews section.
/// </summary>
public interface SketchOffsetSplines : IEnumerable
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
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified SketchOffsetSpline object from the collection.
    /// </summary>
    SketchOffsetSpline this[int Index] { get; }
}
