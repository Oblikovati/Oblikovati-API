namespace Oblikovati.API;

public interface IRxApplicationEvents_Event
{
    event IRxApplicationEvents_OnNewDocumentEventHandler OnNewDocument;
    event IRxApplicationEvents_OnOpenDocumentEventHandler OnOpenDocument;
    event IRxApplicationEvents_OnSaveDocumentEventHandler OnSaveDocument;
    event IRxApplicationEvents_OnCloseDocumentEventHandler OnCloseDocument;
    event IRxApplicationEvents_OnActivateDocumentEventHandler OnActivateDocument;
    event IRxApplicationEvents_OnDeactivateDocumentEventHandler OnDeactivateDocument;
    event IRxApplicationEvents_OnNewViewEventHandler OnNewView;
    event IRxApplicationEvents_OnCloseViewEventHandler OnCloseView;
    event IRxApplicationEvents_OnActivateViewEventHandler OnActivateView;
    event IRxApplicationEvents_OnDeactivateViewEventHandler OnDeactivateView;
    event IRxApplicationEvents_OnQuitEventHandler OnQuit;
}
