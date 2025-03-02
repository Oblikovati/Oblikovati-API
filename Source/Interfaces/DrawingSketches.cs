namespace Oblikovati.API;

/// <summary>
/// The DrawingSketches collection object provides access to the objects associated with the object the collection was obtained from.
/// </summary>
public interface DrawingSketches : IEnumerable
{
    /// <summary>
    /// Returns the specified DrawingSketch object from the collection.
    /// </summary>
    DrawingSketch this[object Index] { get; }
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
    /// Method that creates a new drawing sketch.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    DrawingSketch Add();
}
