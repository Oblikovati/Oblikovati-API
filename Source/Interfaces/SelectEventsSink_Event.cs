namespace Oblikovati.API;

public interface SelectEventsSink_Event
{
    event SelectEventsSink_OnPreSelectEventHandler OnPreSelect;
    event SelectEventsSink_OnPreSelectMouseMoveEventHandler OnPreSelectMouseMove;
    event SelectEventsSink_OnStopPreSelectEventHandler OnStopPreSelect;
    event SelectEventsSink_OnSelectEventHandler OnSelect;
    event SelectEventsSink_OnUnSelectEventHandler OnUnSelect;
}
