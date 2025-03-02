namespace Oblikovati.API;

public delegate void PartEventsSink_OnSurfaceBodyChangedEventHandler( NameValueMap Context, EventTimingEnum BeforeOrAfter,out HandlingCodeEnum HandlingCode);
