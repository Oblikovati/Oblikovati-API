namespace Oblikovati.API;

/// <summary>
/// Provides access to all of the objects owned by a particular PartComponentDefinition. See the article in the overviews section.
/// </summary>
public interface Sketches3D : IEnumerable
{
    /// <summary>
    /// Returns the specified Sketch3D object from the collection.
    /// </summary>
    Sketch3D this[object Index] { get; }
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
    /// Method that creates a new 3D sketch.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    Sketch3D Add();
}
