namespace Oblikovati.API;

public delegate void BrowserPaneSink_OnActivateEventHandler();

public delegate void BrowserPaneSink_OnDeactivateEventHandler();

public delegate void BrowserPaneSink_OnHelpEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
