namespace Oblikovati.API;

/// <summary>
/// The KeyboardEvents object supports a set of events that can be received by the client when a key on the keyboard is pressed while the InteractionEvents object has been started AND the InteractionDisabled flag is set to False.
/// </summary>
public interface KeyboardEvents : KeyboardEventsObject, KeyboardEventsSink_Event
{
}
