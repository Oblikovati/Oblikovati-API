namespace Oblikovati.API;

public interface BrowserPaneSink_Event
{
    event BrowserPaneSink_OnActivateEventHandler OnActivate;
    event BrowserPaneSink_OnDeactivateEventHandler OnDeactivate;
    event BrowserPaneSink_OnHelpEventHandler OnHelp;
}
