namespace Oblikovati.API;

/// <summary>
/// The SketchEllipticalArcs3D object provides access to all the objects in a sketch.
/// </summary>
public interface SketchEllipticalArcs3D : IEnumerable
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
    /// Returns the specified SketchEllipticalArc3D object from the collection.
    /// </summary>
    SketchEllipticalArc3D Item { get; }
}
