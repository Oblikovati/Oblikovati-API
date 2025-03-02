namespace Oblikovati.API;

public interface InteractionEventsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandManager Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    _Document TargetDocument { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SelectEvents SelectEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MouseEvents MouseEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    KeyboardEvents KeyboardEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    TriadEvents TriadEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ManipulatorEvents ManipulatorEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool SelectionActive { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool InteractionDisabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string StatusBarText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    InteractionGraphics InteractionGraphics { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool AllowCommandAliases { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MeasureEvents MeasureEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Start();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Stop();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CursorType">CursorType</param>
    /// <param name="Cursor">Cursor</param>
    /// <param name="CursorHotSpot">CursorHotSpot</param>
    [PreserveSig]
    void GetCursor([Out] out CursorTypeEnum CursorType, [Out] [MarshalAs(UnmanagedType.Struct)] out object Cursor, [Out] out CursorHotSpotEnum CursorHotSpot);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="CursorType">CursorType</param>
    /// <param name="Cursor">Cursor</param>
    /// <param name="CursorHotSpot">CursorHotSpot</param>
    [PreserveSig]
    void SetCursor([In] CursorTypeEnum CursorType, [In] [MarshalAs(UnmanagedType.Struct)] object? Cursor = default, [In] [MarshalAs(UnmanagedType.Struct)] object? CursorHotSpot = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    MiniToolbar CreateMiniToolbar();
}
