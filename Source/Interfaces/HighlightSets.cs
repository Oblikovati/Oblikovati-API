namespace Oblikovati.API;

/// <summary>
/// </summary>
public interface HighlightSets : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the specified HighlightSet from the collection.
    /// </summary>
    HighlightSet this[int Index] { get; }
    /// <summary>
    /// Property that returns the number of HighlightSet objects in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that creates a new HighlightSet object. A new HighlightSet will be empty and the color will be the current highlight color as defined by the color scheme.
    /// </summary>
    /// <returns></returns>
    [PreserveSig]
    HighlightSet Add();
}
