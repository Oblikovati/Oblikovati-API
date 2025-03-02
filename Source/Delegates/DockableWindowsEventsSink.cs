namespace Oblikovati.API;

public delegate void DockableWindowsEventsSink_OnHelpEventHandler( DockableWindow DockableWindow, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void DockableWindowsEventsSink_OnHideEventHandler( DockableWindow DockableWindow, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void DockableWindowsEventsSink_OnShowEventHandler( DockableWindow DockableWindow, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
