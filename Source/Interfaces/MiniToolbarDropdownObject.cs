namespace Oblikovati.API;

public interface MiniToolbarDropdownObject
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
    int Count { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsSplitButton { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MiniToolbarListItem this[object Index] { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Pressed { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    MiniToolbarListItem SelectedItem { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool ShowText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool HasMRUBehavior { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int SelectedIndex { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Text">Text</param>
    /// <param name="ToolTipText">ToolTipText</param>
    /// <param name="InternalName">InternalName</param>
    /// <param name="AllowDelete">AllowDelete</param>
    /// <param name="ShowCheckBox">ShowCheckBox</param>
    /// <param name="StandardIcon">StandardIcon</param>
    /// <param name="LargeIcon">LargeIcon</param>
    /// <param name="Index">Index</param>
    [PreserveSig]
    MiniToolbarListItem AddItem([In] [MarshalAs(UnmanagedType.BStr)] string Text, [In] [MarshalAs(UnmanagedType.BStr)] string ToolTipText, [In] [MarshalAs(UnmanagedType.BStr)] string? InternalName = "", [In] bool? AllowDelete = false, [In] bool? ShowCheckBox = false, [In] [MarshalAs(UnmanagedType.Struct)] object? StandardIcon = default, [In] [MarshalAs(UnmanagedType.Struct)] object? LargeIcon = default, [In] int? Index = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="InternalName">InternalName</param>
    /// <param name="Index">Index</param>
    [PreserveSig]
    MiniToolbarListItem AddSeparator([In] [MarshalAs(UnmanagedType.BStr)] string? InternalName = "", [In] int? Index = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Clear();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Index">Index</param>
    [PreserveSig]
    void RemoveItem([In] [MarshalAs(UnmanagedType.Struct)] object Index);
}
