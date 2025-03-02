namespace Oblikovati.API;

/// <summary>
/// The WeldBeads object provides access to all the existing <link Inventor::WeldBead, WeldBead> objects within a weldment.
/// </summary>
public interface WeldBeads : IEnumerable
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
    /// Returns the specified WeldBead object from the collection
    /// </summary>
    WeldBead Item { get; }
}
