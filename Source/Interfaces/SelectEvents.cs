namespace Oblikovati.API;

/// <summary>
/// The SelectEvents object supports a set of events that are fired when the user is selecting geometry. These events are fired when the user is selecting items from various UI elements such as the graphics window or the browser.
/// </summary>
public interface SelectEvents : SelectEventsObject, SelectEventsSink_Event
{
}
