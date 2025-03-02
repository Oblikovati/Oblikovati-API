namespace Oblikovati.API;

public interface BrowserPaneObject
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
    string Name { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool BuiltIn { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool TreeBrowser { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    string InternalName { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    object Control { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    BrowserNode TopNode { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Visible { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Default { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    bool Transient { get; set; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    SearchBox SearchBox { get; }
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Activate();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Deactivate();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Delete();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TargetNode">TargetNode</param>
    /// <param name="Before">Before</param>
    /// <param name="StartNode">StartNode</param>
    /// <param name="EndNode">EndNode</param>
    [PreserveSig]
    void Reorder([In] [MarshalAs(UnmanagedType.Interface)] BrowserNode TargetNode, [In] bool Before, [In] [MarshalAs(UnmanagedType.Interface)] BrowserNode StartNode, [In] [MarshalAs(UnmanagedType.Struct)] object? EndNode = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Refresh();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void Update();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="Name">Name</param>
    /// <param name="BrowserNodes">BrowserNodes</param>
    [PreserveSig]
    BrowserFolder AddBrowserFolder([In] [MarshalAs(UnmanagedType.BStr)] string? Name = "", [In] [MarshalAs(UnmanagedType.Struct)] object? BrowserNodes = default);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="NativeObject">NativeObject</param>
    [PreserveSig]
    BrowserNode GetBrowserNodeFromObject([In] [MarshalAs(UnmanagedType.IDispatch)] object NativeObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    [PreserveSig]
    void ClearPreSelect();
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DockingState">DockingState</param>
    /// <param name="DockToObject">DockToObject</param>
    [PreserveSig]
    void GetDockingState([Out] out DockingStateEnum DockingState, [Out] [MarshalAs(UnmanagedType.IDispatch)] out object DockToObject);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DockingState">DockingState</param>
    /// <param name="DockToObject">DockToObject</param>
    [PreserveSig]
    void SetDockingState([In] DockingStateEnum DockingState, [In] [MarshalAs(UnmanagedType.Struct)] object? DockToObject = default);
}
