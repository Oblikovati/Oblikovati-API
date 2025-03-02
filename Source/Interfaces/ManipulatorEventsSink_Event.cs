namespace Oblikovati.API;

public interface ManipulatorEventsSink_Event
{
    event ManipulatorEventsSink_OnManipulatorElementSelectionChangeEventHandler OnManipulatorElementSelectionChange;
    event ManipulatorEventsSink_OnStartDragEventHandler OnStartDrag;
    event ManipulatorEventsSink_OnEndDragEventHandler OnEndDrag;
    event ManipulatorEventsSink_OnDragEventHandler OnDrag;
}
