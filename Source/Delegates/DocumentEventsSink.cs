namespace Oblikovati.API;

public delegate void DocumentEventsSink_OnActivateEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void DocumentEventsSink_OnChangeEventHandler( CommandTypesEnum ReasonsForChange, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void DocumentEventsSink_OnChangeSelectSetEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void DocumentEventsSink_OnCloseEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void DocumentEventsSink_OnDeactivateEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void DocumentEventsSink_OnDeleteEventHandler( object Entity, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void DocumentEventsSink_OnSaveEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
