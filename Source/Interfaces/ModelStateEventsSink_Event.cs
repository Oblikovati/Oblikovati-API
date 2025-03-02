namespace Oblikovati.API;

public interface ModelStateEventsSink_Event
{
    event ModelStateEventsSink_OnDeleteModelStateEventHandler OnDeleteModelState;
    event ModelStateEventsSink_OnNewModelStateEventHandler OnNewModelState;
    event ModelStateEventsSink_OnActivateModelStateEventHandler OnActivateModelState;
}
