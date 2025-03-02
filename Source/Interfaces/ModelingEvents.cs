namespace Oblikovati.API;

/// <summary>
/// The ModelingEvents object provides notification of modeling events including new feature, feature delete, changed feature, client feature or new/changed parameters.
/// </summary>
public interface ModelingEvents : ModelingEventsObject, ModelingEventsSink_Event
{
}
