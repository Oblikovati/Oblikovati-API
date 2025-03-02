namespace Oblikovati.API;

public interface ApplicationEventsSink
{
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="FullDocumentName">FullDocumentName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnInitializeDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="FullDocumentName">FullDocumentName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnOpenDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnSaveDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="FullDocumentName">FullDocumentName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnCloseDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="FullDocumentName">FullDocumentName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnTerminateDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.BStr)] string FullDocumentName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnActivateDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDeactivateDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnUndoOpenDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewView([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDisplayModeChange([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnCloseView([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnActivateView([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDeactivateView([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="WebViewObject">WebViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewWebView([In] [MarshalAs(UnmanagedType.Interface)] WebView WebViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="WebViewObject">WebViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnCloseWebView([In] [MarshalAs(UnmanagedType.Interface)] WebView WebViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="WebViewObject">WebViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnActivateWebView([In] [MarshalAs(UnmanagedType.Interface)] WebView WebViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="WebViewObject">WebViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDeactivateWebView([In] [MarshalAs(UnmanagedType.Interface)] WebView WebViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="WebViewObject">WebViewObject</param>
    /// <param name="ActionID">ActionID</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnWebViewAct([In] [MarshalAs(UnmanagedType.Interface)] WebView WebViewObject, [In] [MarshalAs(UnmanagedType.BStr)] string ActionID, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnQuit([In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="EditObject">EditObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnNewEditObject([In] [MarshalAs(UnmanagedType.IDispatch)] object EditObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="TranslatingIn">TranslatingIn</param>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="FullFileName">FullFileName</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnTranslateDocument([In] bool TranslatingIn, [In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] [MarshalAs(UnmanagedType.BStr)] string FullFileName, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ProjectObject">ProjectObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnActiveProjectChanged([In] [MarshalAs(UnmanagedType.Interface)] DesignProject ProjectObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ProjectObject">ProjectObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnProjectDeleted([In] [MarshalAs(UnmanagedType.Interface)] DesignProject ProjectObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ProjectObject">ProjectObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnProjectRenamed([In] [MarshalAs(UnmanagedType.Interface)] DesignProject ProjectObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ProjectObject">ProjectObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnProjectAdded([In] [MarshalAs(UnmanagedType.Interface)] DesignProject ProjectObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="ReasonsForChange">ReasonsForChange</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnDocumentChange([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter, [In] CommandTypesEnum ReasonsForChange, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnReady([In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="DocumentObject">DocumentObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnMigrateDocument([In] [MarshalAs(UnmanagedType.Interface)] _Document DocumentObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnRestart32BitHost([In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnApplicationOptionChange([In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ApplicationObject">ApplicationObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnMoveApplicationWindow([In] [MarshalAs(UnmanagedType.Interface)] Application ApplicationObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ApplicationObject">ApplicationObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnResizeApplicationWindow([In] [MarshalAs(UnmanagedType.Interface)] Application ApplicationObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnMoveView([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
    /// <summary>
    /// Missing documentation! Help us documenting it!
    /// </summary>
    /// <param name="ViewObject">ViewObject</param>
    /// <param name="BeforeOrAfter">BeforeOrAfter</param>
    /// <param name="Context">Context</param>
    /// <param name="HandlingCode">HandlingCode</param>
    [PreserveSig]
    void OnResizeView([In] [MarshalAs(UnmanagedType.Interface)] View ViewObject, [In] EventTimingEnum BeforeOrAfter, [In] [MarshalAs(UnmanagedType.Interface)] NameValueMap Context, [Out] out HandlingCodeEnum HandlingCode);
}
