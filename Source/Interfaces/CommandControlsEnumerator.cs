namespace Oblikovati.API;

/// <summary>
/// The CommandControlsEnumerator object provides access to a list of CommandControl objects.
/// </summary>
public interface CommandControlsEnumerator : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Property that returns an item from the collection.  The index of the first item in the collection is 1.
    /// </summary>
    CommandControl Item { get; }
}
