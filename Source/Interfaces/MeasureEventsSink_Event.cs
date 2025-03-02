namespace Oblikovati.API;

public interface MeasureEventsSink_Event
{
    event MeasureEventsSink_OnSelectParameterEventHandler OnSelectParameter;
    event MeasureEventsSink_OnMeasureEventHandler OnMeasure;
}
