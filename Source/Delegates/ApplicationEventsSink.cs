namespace Oblikovati.API;

public delegate void ApplicationEventsSink_OnActivateDocumentEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnActivateViewEventHandler( View ViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnActivateWebViewEventHandler( WebView WebViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnActiveProjectChangedEventHandler( DesignProject ProjectObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnApplicationOptionChangeEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnCloseDocumentEventHandler( _Document DocumentObject, string FullDocumentName, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnCloseViewEventHandler( View ViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnCloseWebViewEventHandler( WebView WebViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnDeactivateDocumentEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnDeactivateViewEventHandler( View ViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnDeactivateWebViewEventHandler( WebView WebViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnDisplayModeChangeEventHandler( View ViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnDocumentChangeEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter, CommandTypesEnum ReasonsForChange, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnInitializeDocumentEventHandler( _Document DocumentObject, string FullDocumentName, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnMigrateDocumentEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnMoveApplicationWindowEventHandler( Application ApplicationObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnMoveViewEventHandler( View ViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnNewDocumentEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnNewEditObjectEventHandler( object EditObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnNewViewEventHandler( View ViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnNewWebViewEventHandler( WebView WebViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnOpenDocumentEventHandler( _Document DocumentObject, string FullDocumentName, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnProjectAddedEventHandler( DesignProject ProjectObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnProjectDeletedEventHandler( DesignProject ProjectObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnProjectRenamedEventHandler( DesignProject ProjectObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnQuitEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnReadyEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnResizeApplicationWindowEventHandler( Application ApplicationObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnResizeViewEventHandler( View ViewObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnRestart32BitHostEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnSaveDocumentEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnTerminateDocumentEventHandler( _Document DocumentObject, string FullDocumentName, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnTranslateDocumentEventHandler( bool TranslatingIn, _Document DocumentObject, string FullFileName, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnUndoOpenDocumentEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ApplicationEventsSink_OnWebViewActEventHandler( WebView WebViewObject, string ActionID, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
