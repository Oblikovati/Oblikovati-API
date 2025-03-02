namespace Oblikovati.API;

public delegate void ButtonDefinitionSink_OnExecuteEventHandler( NameValueMap Context);

public delegate void ButtonDefinitionSink_OnHelpEventHandler( NameValueMap Context,out HandlingCodeEnum HandlingCode);
