namespace Oblikovati.API;

/// <summary>
/// The FlatBendResults collection object contains information about all the resulting bends in the flat pattern.
/// </summary>
public interface FlatBendResults : IEnumerable
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
    /// Returns the specified FlatBendResultobject from the collection.
    /// </summary>
    FlatBendResult Item { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
}
