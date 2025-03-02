namespace Oblikovati.API;

public interface NativeBrowserNodeDefinitionObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _Document Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Label { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string StateIconToolTipText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
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
    /// Missing documentation! Help us documenting it!
    /// </summary>
    BrowserNodeDisplayStateEnum DisplayState { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    BrowserNodeDisplayStateEnum AdditionalDisplayState { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string AdditionalStateIconToolTipText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp ExpandedIcon { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp Icon { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ClientNodeResource OverrideIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp StateIcon { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object NativeObject { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ClientNodeResource OverrideExpandedIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ClientNodeResource OverrideStateIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool LabelModified { get; }
}
