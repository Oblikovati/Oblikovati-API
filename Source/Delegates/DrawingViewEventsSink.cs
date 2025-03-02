namespace Oblikovati.API;

public delegate void DrawingViewEventsSink_OnViewUpdateEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context, CommandTypesEnum ReasonsForChange,out HandlingCodeEnum HandlingCode);
