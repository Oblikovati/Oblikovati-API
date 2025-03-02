namespace Oblikovati.API;

public interface MiniToolbarObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Point2d Position { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowApply { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowCancel { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowOK { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EnableApply { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool EnableOK { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MiniToolbarControls Controls { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowOptionBox { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowHandle { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Height { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Width { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IgnorePinnedPosition { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int HWND { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
}
