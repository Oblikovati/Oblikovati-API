namespace Oblikovati.API;

/// <summary>
/// The Ribbons collection object provides access to all existing ribbons in Inventor.
/// </summary>
public interface Ribbons : IEnumerable
{
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Returns the specified Ribbon object from the collection.
    /// </summary>
    Ribbon Item { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
