namespace Oblikovati.API;

public interface TriadEventsSink_Event
{
    event TriadEventsSink_OnActivateEventHandler OnActivate;
    event TriadEventsSink_OnEndMoveEventHandler OnEndMove;
    event TriadEventsSink_OnMoveEventHandler OnMove;
    event TriadEventsSink_OnEndSequenceEventHandler OnEndSequence;
    event TriadEventsSink_OnStartSequenceEventHandler OnStartSequence;
    event TriadEventsSink_OnMoveTriadOnlyToggleEventHandler OnMoveTriadOnlyToggle;
    event TriadEventsSink_OnStartMoveEventHandler OnStartMove;
    event TriadEventsSink_OnTerminateEventHandler OnTerminate;
    event TriadEventsSink_OnSegmentSelectionChangeEventHandler OnSegmentSelectionChange;
    event TriadEventsSink_OnEndSequence2EventHandler OnEndSequence2;
    event TriadEventsSink_OnTerminate2EventHandler OnTerminate2;
    event TriadEventsSink_OnMoveTriadOnlyToggle2EventHandler OnMoveTriadOnlyToggle2;
}
