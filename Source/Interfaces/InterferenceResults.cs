namespace Oblikovati.API;

/// <summary>
/// In an assembly, two or more components cannot occupy the same space at the same time. To detect such errors, you can analyze assemblies for interference.
/// </summary>
public interface InterferenceResults : IEnumerable
{
    /// <summary>
    /// Returns the specified InterferenceResult object from the collection.
    /// </summary>
    InterferenceResult this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
}
