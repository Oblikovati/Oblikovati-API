namespace Oblikovati.API;

public delegate void CustomDataEventsSink_OnExecuteCustomActionEventHandler( NameValueMap Context, NameValueMap CustomData);

public delegate void CustomDataEventsSink_OnRequestCustomDataEventHandler( NameValueMap Context,out NameValueMap CustomData);
