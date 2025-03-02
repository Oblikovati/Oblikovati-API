namespace Oblikovati.API;

public delegate void ControlDefinitionEventsSink_OnCommandInputsEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out NameValueMap Inputs,out HandlingCodeEnum HandlingCode);
