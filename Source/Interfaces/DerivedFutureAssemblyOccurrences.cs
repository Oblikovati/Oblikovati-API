namespace Oblikovati.API;

/// <summary>
/// The DerivedFutureAssemblyOccurrences collection object provides access to the DerivedFutureAssemblyOccurrence objects associated with a specific DerivedFutureAssemblyDefinition object.  The DerivedFutureAssemblyOccurrence objects contained within the collection represent the top-level occurrences within the assembly you obtained the collection from.
/// </summary>
public interface DerivedFutureAssemblyOccurrences : IEnumerable
{
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified DerivedFutureAssemblyOccurrence object from the collection.
    /// </summary>
    DerivedFutureAssemblyOccurrence Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
}
