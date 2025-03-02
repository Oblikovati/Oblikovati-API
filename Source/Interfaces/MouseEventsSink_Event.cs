namespace Oblikovati.API;

public interface MouseEventsSink_Event
{
    event MouseEventsSink_OnMouseUpEventHandler OnMouseUp;
    event MouseEventsSink_OnMouseDownEventHandler OnMouseDown;
    event MouseEventsSink_OnMouseClickEventHandler OnMouseClick;
    event MouseEventsSink_OnMouseDoubleClickEventHandler OnMouseDoubleClick;
    event MouseEventsSink_OnMouseMoveEventHandler OnMouseMove;
    event MouseEventsSink_OnMouseLeaveEventHandler OnMouseLeave;
}
