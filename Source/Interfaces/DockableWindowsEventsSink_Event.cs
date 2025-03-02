namespace Oblikovati.API;

public interface DockableWindowsEventsSink_Event
{
    event DockableWindowsEventsSink_OnHelpEventHandler OnHelp;
    event DockableWindowsEventsSink_OnHideEventHandler OnHide;
    event DockableWindowsEventsSink_OnShowEventHandler OnShow;
}
