namespace Oblikovati.API;

public interface InteractionEventsSink_Event
{
    event InteractionEventsSink_OnActivateEventHandler OnActivate;
    event InteractionEventsSink_OnTerminateEventHandler OnTerminate;
    event InteractionEventsSink_OnSuspendEventHandler OnSuspend;
    event InteractionEventsSink_OnResumeEventHandler OnResume;
    event InteractionEventsSink_OnHelpEventHandler OnHelp;
}
