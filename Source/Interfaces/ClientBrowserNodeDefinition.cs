namespace Oblikovati.API;

/// <summary>
/// The ClientBrowserNodeDefinition object derives from the BrowserNodeDefinition and contains the definition for a client-created node in the browser.
/// </summary>
public interface ClientBrowserNodeDefinition : ClientBrowserNodeDefinitionObject, ClientBrowserNodeDefinitionSink_Event
{
}
