namespace Oblikovati.API;

public interface ContentCenterDialogEventsSink_Event
{
    event ContentCenterDialogEventsSink_OnSelectEventHandler OnSelect;
    event ContentCenterDialogEventsSink_OnSelectionCommitEventHandler OnSelectionCommit;
    event ContentCenterDialogEventsSink_OnTerminateEventHandler OnTerminate;
}
