namespace Oblikovati.API;

/// <summary>
/// This object represents the End of Part marker in the browser. When traversing through the browser hierarchy, this is one of the nodes that is encountered, indicating the position of the marker in the browser.
/// </summary>
public interface EndOfFeatures
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the parent object from whom this object can logically be reached.
    /// </summary>
    ComponentDefinition Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
}
