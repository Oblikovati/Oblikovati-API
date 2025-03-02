namespace Oblikovati.API;

/// <summary>
/// The iPartTableColumns collection object provides access to all existing objects in the iPart factory table.
/// </summary>
public interface iPartTableColumns : IEnumerable
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
    /// Returns the specified iPartTableColumn object from the collection. This is the default property of the iPartTableColumns collection object.
    /// </summary>
    iPartTableColumn this[int Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
