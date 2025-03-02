namespace Oblikovati.API;

public delegate void InteractionEventsSink_OnActivateEventHandler();

public delegate void InteractionEventsSink_OnHelpEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void InteractionEventsSink_OnResumeEventHandler();

public delegate void InteractionEventsSink_OnSuspendEventHandler();

public delegate void InteractionEventsSink_OnTerminateEventHandler();
