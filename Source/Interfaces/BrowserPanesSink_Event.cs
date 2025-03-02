namespace Oblikovati.API;

public interface BrowserPanesSink_Event
{
    event BrowserPanesSink_OnBrowserNodeActivateEventHandler OnBrowserNodeActivate;
    event BrowserPanesSink_OnBrowserNodeGetDisplayObjectsEventHandler OnBrowserNodeGetDisplayObjects;
    event BrowserPanesSink_OnBrowserNodeLabelEditEventHandler OnBrowserNodeLabelEdit;
    event BrowserPanesSink_OnBrowserNodeDeleteEntryEventHandler OnBrowserNodeDeleteEntry;
    event BrowserPanesSink_OnBrowserNodesReorderEventHandler OnBrowserNodesReorder;
}
