namespace Oblikovati.API;

/// <summary>
/// The BendsEnumerator object represents all of the bends in a sheet metal part.
/// </summary>
public interface BendsEnumerator : IEnumerable
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
    /// Returns the specified Bend object from the collection.
    /// </summary>
    Bend this[object Index] { get; }
    /// <summary>
    /// Property that returns the number of Bend objects in the collection.
    /// </summary>
    int Count { get; }
}
