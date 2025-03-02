namespace Oblikovati.API;

public delegate void ClientBrowserNodeDefinitionSink_OnActivateEventHandler( NameValueMap Context);

public delegate void ClientBrowserNodeDefinitionSink_OnGetDisplayObjectsEventHandler(out ObjectCollection Objects, NameValueMap Context);

public delegate void ClientBrowserNodeDefinitionSink_OnLabelEditEventHandler( string NewLabel, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
