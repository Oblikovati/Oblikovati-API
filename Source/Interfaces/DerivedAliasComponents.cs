namespace Oblikovati.API;

/// <summary>
/// The DerivedAliasComponents collection object provides access to all of the existing DerivedAliasComponent objects in a part and provides methods to create additional derived components.
/// </summary>
public interface DerivedAliasComponents : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified DerivedAliasComponent object from the collection.
    /// </summary>
    DerivedAliasComponent this[object Index] { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the ComponentDefinition object.
    /// </summary>
    ComponentDefinition Parent { get; }
}
