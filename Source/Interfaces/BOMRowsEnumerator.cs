namespace Oblikovati.API;

/// <summary>
/// The BOMRowsEnumerator object provides access to BOMRow objects.
/// </summary>
public interface BOMRowsEnumerator : IEnumerable
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
    /// Property that specifies the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns an item in the collection.
    /// </summary>
    BOMRow this[int Index] { get; }
}
