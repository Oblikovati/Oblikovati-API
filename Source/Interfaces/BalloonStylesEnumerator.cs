namespace Oblikovati.API;

/// <summary>
/// The BalloonStylesEnumerator object provides access to the existing BalloonStyle objects.
/// </summary>
public interface BalloonStylesEnumerator : IEnumerable
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
    /// Returns the specified BalloonStyle object from the collection.
    /// </summary>
    BalloonStyle this[object Index] { get; }
}
