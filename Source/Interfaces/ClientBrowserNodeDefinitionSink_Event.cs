namespace Oblikovati.API;

public interface ClientBrowserNodeDefinitionSink_Event
{
    event ClientBrowserNodeDefinitionSink_OnActivateEventHandler OnActivate;
    event ClientBrowserNodeDefinitionSink_OnGetDisplayObjectsEventHandler OnGetDisplayObjects;
    event ClientBrowserNodeDefinitionSink_OnLabelEditEventHandler OnLabelEdit;
}
