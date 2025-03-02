namespace Oblikovati.API;

/// <summary>
/// DSLoad Object.
/// </summary>
public interface DSLoad
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
    /// Gets and sets the load definition object associated with this load.
    /// </summary>
    DSLoadDefinition Definition { get; set; }
    /// <summary>
    /// Gets the type of load this load object represents.
    /// </summary>
    DSLoadTypeEnum LoadType { get; }
    /// <summary>
    /// Gets and sets the name of this load as seen in the browser.
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Gets whether the load is suppressed or not.&nbsp;A value of True indicates the load is suppressed.
    /// </summary>
    bool IsSuppressed { get; set; }
}
