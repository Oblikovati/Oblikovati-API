namespace Oblikovati.API;

/// <summary>
/// PresentationTask object.
/// </summary>
public interface PresentationTask
{
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Read-only property that gets the presentation task name.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Read-only property that returns the PresentationSequences collection object.
    /// </summary>
    PresentationSequences Sequences { get; }
}
