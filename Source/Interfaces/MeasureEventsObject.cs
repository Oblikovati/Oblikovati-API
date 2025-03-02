namespace Oblikovati.API;

public interface MeasureEventsObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    InteractionEvents Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ShowDimensions();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="MeasureType">MeasureType</param>
    /// <param name="Options">Options</param>
    [PreserveSig]
    void Measure([In] MeasureTypeEnum MeasureType, [In] [MarshalAs(UnmanagedType.Struct)] object? Options = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ScreenPosition">ScreenPosition</param>
    /// <param name="Component">Component</param>
    /// <param name="DisplayAllParameters">DisplayAllParameters</param>
    /// <param name="HWND">HWND</param>
    [PreserveSig]
    void ListParameters([In] [MarshalAs(UnmanagedType.Struct)] object? ScreenPosition = default, [In] [MarshalAs(UnmanagedType.Struct)] object? Component = default, [In] bool? DisplayAllParameters = false, [In] int? HWND = default);
}
