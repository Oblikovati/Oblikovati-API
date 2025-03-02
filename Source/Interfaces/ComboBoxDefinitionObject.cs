namespace Oblikovati.API;

public interface ComboBoxDefinitionObject
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ObjectTypeEnum Type { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DisplayName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    Application Application { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandTypesEnum Classification { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    CommandManager Parent { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ControlDefinitionTypeEnum DefinitionType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DescriptionText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Enabled { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int Id { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ToolTipText { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ControlDefinitionEvents ControlDefinitionEvents { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ClientId { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string DefaultShortcut { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ShortcutTypeEnum DefaultShortcutType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsShortcutOverridden { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string OverrideShortcut { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ShortcutTypeEnum OverrideShortcutType { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp StandardIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    IPictureDisp LargeIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ProgressiveToolTip ProgressiveToolTip { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string IntroducedInVersion { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string LastUpdatedVersion { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int DropDownWidth { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int ListCount { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    int ListIndex { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string ListItem { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string Text { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string _ClassName { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void AutoAddToGUI();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Execute();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Synchronous">Synchronous</param>
    [PreserveSig]
    void Execute2([In] bool Synchronous);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Item">Item</param>
    /// <param name="Index">Index</param>
    [PreserveSig]
    void AddItem([In] [MarshalAs(UnmanagedType.BStr)] string Item, [In] int? Index = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Index">Index</param>
    [PreserveSig]
    void RemoveItem([In] int Index);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Clear();
}
