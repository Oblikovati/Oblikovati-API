namespace Oblikovati.API;

/// <summary>
/// The BrowserNodeDefinition object contains the definition of a node in the browser.
/// </summary>
public interface BrowserNodeDefinition
{
    /// <summary>
    /// Returns the top-level parent application object.  When used the context of Inventor, an Application object is returned.  When used in the context of Apprentice, an ApprenticeServer object is returned.
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Property that returns the owning of this BrowserNodeDefinition object.
    /// </summary>
    _Document Parent { get; }
    /// <summary>
    /// Returns an ObjectTypeEnum indicating this object's type.
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Property that specifies if the node is a standard Autodesk Inventor node or not.
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Property that gets the label of the BrowserNode. This is the string that is displayed to the user. In the case of BuiltIns, this Label is really a reflection of the corresponding name held by the underlying data - for example, a Sketch or a WorkPlane object. In order to set the Label of a ClientBrowserNodeDefinition, see SetLabel on that object.
    /// </summary>
    string Label { get; }
    /// <summary>
    /// Gets and sets state icon tool tip text on a existing definition object.
    /// </summary>
    string StateIconToolTipText { get; set; }
    /// <summary>
    /// Gets and sets tool tip text on a existing definition object.
    /// </summary>
    string ToolTipText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Transient { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DebugInfo { get; }
    /// <summary>
    /// Gets and sets the display state of browsernodes that use this definition.
    /// </summary>
    BrowserNodeDisplayStateEnum DisplayState { get; set; }
    /// <summary>
    /// Gets and sets the additional display state of browsernodes that use this definition.
    /// </summary>
    BrowserNodeDisplayStateEnum AdditionalDisplayState { get; set; }
    /// <summary>
    /// Gets and sets additional state icon tool tip text on a existing definition object.
    /// </summary>
    string AdditionalStateIconToolTipText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
}
