namespace Oblikovati.API;

public interface KeyboardEventsSink_Event
{
    event KeyboardEventsSink_OnKeyDownEventHandler OnKeyDown;
    event KeyboardEventsSink_OnKeyUpEventHandler OnKeyUp;
    event KeyboardEventsSink_OnKeyPressEventHandler OnKeyPress;
}
