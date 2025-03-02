namespace Oblikovati.API;

public interface MiniToolbarSink_Event
{
    event MiniToolbarSink_OnApplyEventHandler OnApply;
    event MiniToolbarSink_OnCancelEventHandler OnCancel;
    event MiniToolbarSink_OnOKEventHandler OnOK;
    event MiniToolbarSink_OnStartMoveEventHandler OnStartMove;
    event MiniToolbarSink_OnMoveEventHandler OnMove;
    event MiniToolbarSink_OnEndMoveEventHandler OnEndMove;
    event MiniToolbarSink_OnHideEventHandler OnHide;
    event MiniToolbarSink_OnShowEventHandler OnShow;
}
