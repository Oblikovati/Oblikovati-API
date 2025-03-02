namespace Oblikovati.API;

public interface ApplicationEventsSink_Event
{
    event ApplicationEventsSink_OnNewDocumentEventHandler OnNewDocument;
    event ApplicationEventsSink_OnInitializeDocumentEventHandler OnInitializeDocument;
    event ApplicationEventsSink_OnOpenDocumentEventHandler OnOpenDocument;
    event ApplicationEventsSink_OnSaveDocumentEventHandler OnSaveDocument;
    event ApplicationEventsSink_OnCloseDocumentEventHandler OnCloseDocument;
    event ApplicationEventsSink_OnTerminateDocumentEventHandler OnTerminateDocument;
    event ApplicationEventsSink_OnActivateDocumentEventHandler OnActivateDocument;
    event ApplicationEventsSink_OnDeactivateDocumentEventHandler OnDeactivateDocument;
    event ApplicationEventsSink_OnUndoOpenDocumentEventHandler OnUndoOpenDocument;
    event ApplicationEventsSink_OnNewViewEventHandler OnNewView;
    event ApplicationEventsSink_OnDisplayModeChangeEventHandler OnDisplayModeChange;
    event ApplicationEventsSink_OnCloseViewEventHandler OnCloseView;
    event ApplicationEventsSink_OnActivateViewEventHandler OnActivateView;
    event ApplicationEventsSink_OnDeactivateViewEventHandler OnDeactivateView;
    event ApplicationEventsSink_OnNewWebViewEventHandler OnNewWebView;
    event ApplicationEventsSink_OnCloseWebViewEventHandler OnCloseWebView;
    event ApplicationEventsSink_OnActivateWebViewEventHandler OnActivateWebView;
    event ApplicationEventsSink_OnDeactivateWebViewEventHandler OnDeactivateWebView;
    event ApplicationEventsSink_OnWebViewActEventHandler OnWebViewAct;
    event ApplicationEventsSink_OnQuitEventHandler OnQuit;
    event ApplicationEventsSink_OnNewEditObjectEventHandler OnNewEditObject;
    event ApplicationEventsSink_OnTranslateDocumentEventHandler OnTranslateDocument;
    event ApplicationEventsSink_OnActiveProjectChangedEventHandler OnActiveProjectChanged;
    event ApplicationEventsSink_OnProjectDeletedEventHandler OnProjectDeleted;
    event ApplicationEventsSink_OnProjectRenamedEventHandler OnProjectRenamed;
    event ApplicationEventsSink_OnProjectAddedEventHandler OnProjectAdded;
    event ApplicationEventsSink_OnDocumentChangeEventHandler OnDocumentChange;
    event ApplicationEventsSink_OnReadyEventHandler OnReady;
    event ApplicationEventsSink_OnMigrateDocumentEventHandler OnMigrateDocument;
    event ApplicationEventsSink_OnRestart32BitHostEventHandler OnRestart32BitHost;
    event ApplicationEventsSink_OnApplicationOptionChangeEventHandler OnApplicationOptionChange;
    event ApplicationEventsSink_OnMoveApplicationWindowEventHandler OnMoveApplicationWindow;
    event ApplicationEventsSink_OnResizeApplicationWindowEventHandler OnResizeApplicationWindow;
    event ApplicationEventsSink_OnMoveViewEventHandler OnMoveView;
    event ApplicationEventsSink_OnResizeViewEventHandler OnResizeView;
}
