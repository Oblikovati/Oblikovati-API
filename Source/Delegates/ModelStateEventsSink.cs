namespace Oblikovati.API;

public delegate void ModelStateEventsSink_OnActivateModelStateEventHandler( _Document DocumentObject, ModelState ModelState, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelStateEventsSink_OnDeleteModelStateEventHandler( _Document DocumentObject, object ModelState, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelStateEventsSink_OnNewModelStateEventHandler( _Document DocumentObject, ModelState ModelState, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
