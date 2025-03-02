namespace Oblikovati.API;

public delegate void ContentCenterEventsSink_OnRefreshStandardComponentsEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
