namespace Oblikovati.API;

public delegate void SearchBoxEventsSink_OnClearSearchEventHandler(out HandlingCodeEnum HandlingCode);

public delegate void SearchBoxEventsSink_OnEndSearchEventHandler( NameValueMap SearchResult,out HandlingCodeEnum HandlingCode);

public delegate void SearchBoxEventsSink_OnStartSearchEventHandler(out HandlingCodeEnum HandlingCode);

public delegate void SearchBoxEventsSink_OnStopSearchEventHandler( NameValueMap SearchResult,out HandlingCodeEnum HandlingCode);
