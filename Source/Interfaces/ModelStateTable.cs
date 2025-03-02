namespace Oblikovati.API;

/// <summary>
/// The ModelStateTable object.
/// </summary>
public interface ModelStateTable
{
    /// <summary>
    /// Gets the constant that indicates the type of this object.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Gets the root Application object. Where the property is weakly-typed, it can be set to (QueryInterfaced for) 'Application' when running with Inventor whereas, 'ApprenticeServer' when running with the Apprentice Server.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Gets the Attribute Sets collection on this object.
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Gets the parent object from whom this object can logically be reached.
    /// </summary>
    ModelStates Parent { get; }
    /// <summary>
    /// Read-only property that returns the ModelStateTableRows collection object.
    /// </summary>
    ModelStateTableRows TableRows { get; }
    /// <summary>
    /// Read-only property that returns the ModelStateTableColumns collection object.
    /// </summary>
    ModelStateTableColumns TableColumns { get; }
}
