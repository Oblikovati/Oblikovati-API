namespace Oblikovati.API;

/// <summary>
/// The DerivedPartEntities collection object provides access to all of the objects associated with a specific DerivedPartDefinition object.
/// </summary>
public interface DerivedPartEntities : IEnumerable
{
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified DerivedPartEntity object from the collection.
    /// </summary>
    DerivedPartEntity this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
}
