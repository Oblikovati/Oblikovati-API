namespace Oblikovati.API;

public interface UserInputEventsSink_Event
{
    event UserInputEventsSink_OnStartCommandEventHandler OnStartCommand;
    event UserInputEventsSink_OnActivateCommandEventHandler OnActivateCommand;
    event UserInputEventsSink_OnTerminateCommandEventHandler OnTerminateCommand;
    event UserInputEventsSink_OnStopCommandEventHandler OnStopCommand;
    event UserInputEventsSink_OnContextMenuOldEventHandler OnContextMenuOld;
    event UserInputEventsSink_OnDragEventHandler OnDrag;
    event UserInputEventsSink_OnContextMenuEventHandler OnContextMenu;
    event UserInputEventsSink_OnDoubleClickEventHandler OnDoubleClick;
    event UserInputEventsSink_OnDeleteKeyUpEventHandler OnDeleteKeyUp;
    event UserInputEventsSink_OnPreSelectEventHandler OnPreSelect;
    event UserInputEventsSink_OnStopPreSelectEventHandler OnStopPreSelect;
    event UserInputEventsSink_OnSelectEventHandler OnSelect;
    event UserInputEventsSink_OnUnSelectEventHandler OnUnSelect;
    event UserInputEventsSink_OnRadialMarkingMenuEventHandler OnRadialMarkingMenu;
    event UserInputEventsSink_OnLinearMarkingMenuEventHandler OnLinearMarkingMenu;
    event UserInputEventsSink_OnContextualMiniToolbarEventHandler OnContextualMiniToolbar;
    event UserInputEventsSink_OnMarkTutorialCommandEventHandler OnMarkTutorialCommand;
}
