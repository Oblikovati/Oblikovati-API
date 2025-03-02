namespace Oblikovati.API;

public interface DocumentEventsSink_Event
{
    event DocumentEventsSink_OnSaveEventHandler OnSave;
    event DocumentEventsSink_OnCloseEventHandler OnClose;
    event DocumentEventsSink_OnActivateEventHandler OnActivate;
    event DocumentEventsSink_OnDeactivateEventHandler OnDeactivate;
    event DocumentEventsSink_OnChangeSelectSetEventHandler OnChangeSelectSet;
    event DocumentEventsSink_OnChangeEventHandler OnChange;
    event DocumentEventsSink_OnDeleteEventHandler OnDelete;
}
