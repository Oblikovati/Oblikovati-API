namespace Oblikovati.API;

public interface MiniToolbarTextBoxSink_Event
{
    event MiniToolbarTextBoxSink_OnChangeEventHandler OnChange;
    event MiniToolbarTextBoxSink_OnEnterEventHandler OnEnter;
    event MiniToolbarTextBoxSink_OnExitEventHandler OnExit;
    event MiniToolbarTextBoxSink_OnItemHoverEndEventHandler OnItemHoverEnd;
    event MiniToolbarTextBoxSink_OnItemHoverStartEventHandler OnItemHoverStart;
    event MiniToolbarTextBoxSink_OnItemRemoveEventHandler OnItemRemove;
    event MiniToolbarTextBoxSink_OnSelectEventHandler OnSelect;
}
