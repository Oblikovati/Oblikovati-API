namespace Oblikovati.API;

/// <summary>
/// This object returns all of the information gleaned by Autodesk Inventor's inferencing facility applied to a mouse position. This object is returned via the MouseEvents object.
/// </summary>
public interface PointInferenceEnumerator : IEnumerable
{
    /// <summary>
    /// Returns the specified PointInference object from the collection.
    /// </summary>
    PointInference this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of PointInference objects in the collection.
    /// </summary>
    int Count { get; }
}
