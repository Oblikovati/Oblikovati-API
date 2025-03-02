namespace Oblikovati.API;

public interface StyleEventsSink_Event
{
    event StyleEventsSink_OnDeleteEventHandler OnDelete;
    event StyleEventsSink_OnNewStyleEventHandler OnNewStyle;
    event StyleEventsSink_OnActivateStyleEventHandler OnActivateStyle;
    event StyleEventsSink_OnStyleChangeEventHandler OnStyleChange;
    event StyleEventsSink_OnMigrateStyleLibraryEventHandler OnMigrateStyleLibrary;
}
