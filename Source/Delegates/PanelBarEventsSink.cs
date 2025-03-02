namespace Oblikovati.API;

public delegate void PanelBarEventsSink_OnCommandBarSelectionEventHandler( CommandBar CommandBarObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
