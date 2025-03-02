namespace Oblikovati.API;

public delegate void MeasureEventsSink_OnMeasureEventHandler( MeasureTypeEnum MeasureType, double MeasuredValue, NameValueMap Context);

public delegate void MeasureEventsSink_OnSelectParameterEventHandler( Parameter Parameter, NameValueMap Context);
