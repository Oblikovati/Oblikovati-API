namespace Oblikovati.API;

/// <summary>
/// The DSResults collection object  provides access to the results associated with a degree of freedom.
/// </summary>
public interface DSResults : IEnumerable
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
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified DSResult object from the collection
    /// </summary>
    DSResult this[int Index] { get; }
    /// <summary>
    /// Gets the specified DSResult object from the collection.
    /// </summary>
    DSResult ItemByResultType { get; }
}
