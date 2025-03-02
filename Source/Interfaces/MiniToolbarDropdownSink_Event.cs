namespace Oblikovati.API;

public interface MiniToolbarDropdownSink_Event
{
    event MiniToolbarDropdownSink_OnPreMenuDisplayEventHandler OnPreMenuDisplay;
    event MiniToolbarDropdownSink_OnSelectEventHandler OnSelect;
    event MiniToolbarDropdownSink_OnItemRemoveEventHandler OnItemRemove;
    event MiniToolbarDropdownSink_OnItemHoverEndEventHandler OnItemHoverEnd;
    event MiniToolbarDropdownSink_OnItemHoverStartEventHandler OnItemHoverStart;
}
