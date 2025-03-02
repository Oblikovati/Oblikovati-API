namespace Oblikovati.API;

public delegate void ChangeProcessorSink_OnExecuteEventHandler( _Document Document, NameValueMap Context,ref bool Succeeded);

public delegate void ChangeProcessorSink_OnReadFromScriptEventHandler( _Document Document, string Inputs, NameValueMap Context);

public delegate void ChangeProcessorSink_OnTerminateEventHandler();

public delegate void ChangeProcessorSink_OnWriteToScriptEventHandler( _Document Document, NameValueMap Context,out string ResultInputs);
