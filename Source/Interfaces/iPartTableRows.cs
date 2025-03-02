namespace Oblikovati.API;

/// <summary>
/// TheiPartTableRows collection object provides access to all existing objects in the iPart factory table.
/// </summary>
public interface iPartTableRows : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified iPartTableRow object from the collection. This is the default property of the iPartTableRows collection object.
    /// </summary>
    iPartTableRow this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
