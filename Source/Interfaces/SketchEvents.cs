namespace Oblikovati.API;

/// <summary>
/// The SketchEvents object provides notification of sketch events including new, changed, solved or deleted sketches.
/// </summary>
public interface SketchEvents : SketchEventsObject, SketchEventsSink_Event
{
}
