namespace Oblikovati.API;

/// <summary>
/// The SketchConstraints3DEnumerator object provides access to a list of SketchConstraint objects in a specific 3D sketch. See the article in the overviews section.
/// </summary>
public interface SketchConstraints3DEnumerator : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified SketchConstraint object from the collection.
    /// </summary>
    object this[int Index] { get; }
}
