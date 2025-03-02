namespace Oblikovati.API;

/// <summary>
/// The OccurrencePatternElements collection object provides access to the instances ( objects) that result from the creation of a pattern.
/// </summary>
public interface OccurrencePatternElements : IEnumerable
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
    /// Property that returns the parent OccurrencePattern object.
    /// </summary>
    OccurrencePattern Parent { get; }
    /// <summary>
    /// Property that returns the number of items in the collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Method that returns the specified OccurrencePatternElement object from the collection. This is the default method of the OccurrencePatternElements collection object.
    /// </summary>
    OccurrencePatternElement Item { get; }
}
