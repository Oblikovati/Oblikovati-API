namespace Oblikovati.API;

/// <summary>
/// The DerivedAssemblyOccurrences collection object provides access to the objects associated with a specific DerivedAssemblyDefinition object. The DerivedAssemblyOccurrence objects contained within the collection represent the top-level occurrences within the assembly you obtained the collection from.
/// </summary>
public interface DerivedAssemblyOccurrences : IEnumerable
{
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Returns the specified object from the collection.
    /// </summary>
    DerivedAssemblyOccurrence Item { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
}
