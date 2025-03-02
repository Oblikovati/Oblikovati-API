namespace Oblikovati.API;

/// <summary>
/// PresentationTasks collection object.
/// </summary>
public interface PresentationTasks
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the number of items in this collection.
    /// </summary>
    int Count { get; }
    /// <summary>
    /// Allows integer-indexed access to items in the collection.
    /// </summary>
    PresentationTask Item { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Return the specified PresentationTask object from the collection.
    /// </summary>
    PresentationTask ItemById { get; }
    /// <summary>
    /// Return the next un-used Id for a new PresentationTask.
    /// </summary>
    int NextId { get; }
}
