namespace Oblikovati.API;

/// <summary>
/// The LeaderNodesEnumerator object provides an enumeration of LeaderNode objects.
/// </summary>
public interface LeaderNodesEnumerator : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified LeaderNode object from the collection.
    /// </summary>
    LeaderNode this[object Index] { get; }
}
