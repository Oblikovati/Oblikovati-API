namespace Oblikovati.API;

public interface BrowserPanesSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BrowserNodeDefinition">BrowserNodeDefinition</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnBrowserNodeActivate([In] [MarshalAs(UnmanagedType.IDispatch)] object BrowserNodeDefinition, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BrowserNodeDefinition">BrowserNodeDefinition</param>
    /// <param name="Objects">Objects</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnBrowserNodeGetDisplayObjects([In] [MarshalAs(UnmanagedType.IDispatch)] object BrowserNodeDefinition, [Out] [MarshalAs(UnmanagedType.Interface)] out ObjectCollection Objects, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BrowserNodeDefinition">BrowserNodeDefinition</param>
    /// <param name="NewLabel">NewLabel</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnBrowserNodeLabelEdit([In] [MarshalAs(UnmanagedType.IDispatch)] object BrowserNodeDefinition, [In] [MarshalAs(UnmanagedType.BStr)] string NewLabel, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BrowserNodeDefinition">BrowserNodeDefinition</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnBrowserNodeDeleteEntry([In] [MarshalAs(UnmanagedType.IDispatch)] object BrowserNodeDefinition, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BrowserPane">BrowserPane</param>
    /// <param name="DragNodes">DragNodes</param>
    /// <param name="TargetNode">TargetNode</param>
    /// <param name="eInsertionLoactionType">eInsertionLoactionType</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnBrowserNodesReorder([In] [MarshalAs(UnmanagedType.Interface)] BrowserPane BrowserPane, [In] [MarshalAs(UnmanagedType.Interface)] BrowserNodesEnumerator DragNodes, [In] [MarshalAs(UnmanagedType.Interface)] BrowserNode TargetNode, [In] InsertionLocationTypeEnum eInsertionLoactionType, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}
