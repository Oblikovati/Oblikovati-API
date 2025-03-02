namespace Oblikovati.API;

public interface IRxDocumentEvents_Event
{
    event IRxDocumentEvents_OnSaveEventHandler OnSave;
    event IRxDocumentEvents_OnCloseEventHandler OnClose;
    event IRxDocumentEvents_OnActivateEventHandler OnActivate;
    event IRxDocumentEvents_OnDeactivateEventHandler OnDeactivate;
    event IRxDocumentEvents_OnNewViewEventHandler OnNewView;
    event IRxDocumentEvents_OnCloseViewEventHandler OnCloseView;
    event IRxDocumentEvents_OnActivateViewEventHandler OnActivateView;
    event IRxDocumentEvents_OnDeactivateViewEventHandler OnDeactivateView;
}
