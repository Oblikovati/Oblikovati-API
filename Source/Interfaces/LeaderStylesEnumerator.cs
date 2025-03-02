namespace Oblikovati.API;

/// <summary>
/// The LeaderStylesEnumerator object provides access to the existing LeaderStyle objects.
/// </summary>
public interface LeaderStylesEnumerator : IEnumerable
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
    /// Returns the specified LeaderStyle object from the collection.
    /// </summary>
    LeaderStyle this[object Index] { get; }
}
