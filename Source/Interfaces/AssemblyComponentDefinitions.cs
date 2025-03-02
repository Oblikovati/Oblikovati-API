namespace Oblikovati.API;

/// <summary>
/// Provides access to the objects within the assembly document.
/// </summary>
public interface AssemblyComponentDefinitions : IEnumerable
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent of the object.
    /// </summary>
    _AssemblyDocument Parent { get; }
    /// <summary>
    /// Returns the specified object from the collection. Currently Autodesk Inventor supports a single component definition within a document, so this collection will always be a collection of one.
    /// </summary>
    AssemblyComponentDefinition Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that returns the number of items in this collection.
    /// </summary>
    int Count { get; }
}
