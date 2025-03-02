namespace Oblikovati.API;

public interface CustomDataEventsSink_Event
{
    event CustomDataEventsSink_OnRequestCustomDataEventHandler OnRequestCustomData;
    event CustomDataEventsSink_OnExecuteCustomActionEventHandler OnExecuteCustomAction;
}
