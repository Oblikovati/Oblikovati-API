namespace Oblikovati.API;

public delegate void DocumentSubTypeHandlerEventsSink_OnChangeTypeEventHandler( bool ConvertToSubType, _Document Document, NameValueMap Context,out HandlingCodeEnum HandlingCode);
