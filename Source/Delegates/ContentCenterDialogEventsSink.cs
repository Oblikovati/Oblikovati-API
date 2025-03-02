namespace Oblikovati.API;

public delegate void ContentCenterDialogEventsSink_OnSelectEventHandler( NameValueMap Context, NameValueMap Options,out string ResultXML);

public delegate void ContentCenterDialogEventsSink_OnSelectionCommitEventHandler( NameValueMap Context, NameValueMap Options,out string ResultXML);

public delegate void ContentCenterDialogEventsSink_OnTerminateEventHandler( bool Cancelled, NameValueMap Context);
