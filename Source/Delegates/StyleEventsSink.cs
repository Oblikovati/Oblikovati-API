namespace Oblikovati.API;

public delegate void StyleEventsSink_OnActivateStyleEventHandler( _Document DocumentObject, object Style, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void StyleEventsSink_OnDeleteEventHandler( _Document DocumentObject, object Style, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void StyleEventsSink_OnMigrateStyleLibraryEventHandler( string LibraryPath, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void StyleEventsSink_OnNewStyleEventHandler( _Document DocumentObject, object Style, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void StyleEventsSink_OnStyleChangeEventHandler( _Document DocumentObject, object Style, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
