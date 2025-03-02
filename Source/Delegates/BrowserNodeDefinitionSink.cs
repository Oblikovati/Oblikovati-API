namespace Oblikovati.API;

public delegate void BrowserNodeDefinitionSink_OnLabelEditEventHandler( string NewLabel, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
