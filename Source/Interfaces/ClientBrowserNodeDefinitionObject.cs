namespace Oblikovati.API;

public interface ClientBrowserNodeDefinitionObject
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
    int Id { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ClientNodeResource Icon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    AttributeSets AttributeSets { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ClientNodeResource ExpandedIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    ClientNodeResource StateIcon { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool IsReferenced { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Label">Label</param>
    [PreserveSig]
    void SetLabel([In] [MarshalAs(UnmanagedType.BStr)] string Label);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ReferenceKey">ReferenceKey</param>
    /// <param name="KeyContext">KeyContext</param>
    [PreserveSig]
    void GetReferenceKey([Out] [MarshalAs(UnmanagedType.SafeArray)] out byte[,] ReferenceKey, [In] int? KeyContext = default);
}
