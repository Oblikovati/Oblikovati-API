namespace Oblikovati.API;

public interface MiniToolbarValueEditorSink_Event
{
    event MiniToolbarValueEditorSink_OnChangeEventHandler OnChange;
    event MiniToolbarValueEditorSink_OnEnterEventHandler OnEnter;
    event MiniToolbarValueEditorSink_OnExitEventHandler OnExit;
}
