namespace Oblikovati.API;

public interface MiniToolbarComboBoxSink_Event
{
    event MiniToolbarComboBoxSink_OnPreMenuDisplayEventHandler OnPreMenuDisplay;
    event MiniToolbarComboBoxSink_OnItemHoverEndEventHandler OnItemHoverEnd;
    event MiniToolbarComboBoxSink_OnItemHoverStartEventHandler OnItemHoverStart;
    event MiniToolbarComboBoxSink_OnItemRemoveEventHandler OnItemRemove;
    event MiniToolbarComboBoxSink_OnSelectEventHandler OnSelect;
}
