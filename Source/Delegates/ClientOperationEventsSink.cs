namespace Oblikovati.API;

public delegate void ClientOperationEventsSink_OnClientOperationEventHandler( string ClientId, string OperationName, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
