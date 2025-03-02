namespace Oblikovati.API;

public interface MiniToolbarTextEditorSink_Event
{
    event MiniToolbarTextEditorSink_OnChangeEventHandler OnChange;
    event MiniToolbarTextEditorSink_OnEnterEventHandler OnEnter;
    event MiniToolbarTextEditorSink_OnExitEventHandler OnExit;
}
