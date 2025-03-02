namespace Oblikovati.API;

public interface MiniToolbarButtonObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MiniToolbar Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AutoHide { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MiniToolbarControlTypeEnum ControlType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp LargeIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp StandardIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ToolTipText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Index { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Pressed { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
}
