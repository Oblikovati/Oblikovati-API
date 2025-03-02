namespace Oblikovati.API;

public delegate void WebBrowserDialogEventsSink_OnCloseEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void WebBrowserDialogEventsSink_OnHelpEventHandler( NameValueMap Context,out HandlingCodeEnum HandlingCode);
