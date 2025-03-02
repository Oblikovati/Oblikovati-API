namespace Oblikovati.API;

/// <summary>
/// The BOMViews collection object provides access to the existing BOMView objects.
/// </summary>
public interface BOMViews : IEnumerable
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
    /// Returns the specified BOMView object from the collection.
    /// </summary>
    BOMView Item { get; }
}
