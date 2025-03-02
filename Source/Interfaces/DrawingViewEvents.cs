namespace Oblikovati.API;

/// <summary>
/// Call-back or 'outgoing' sink interface through which Inventor fires the DrawingView Events. See the article in the overviews section.
/// </summary>
public interface DrawingViewEvents : DrawingViewEventsObject, DrawingViewEventsSink_Event
{
}
