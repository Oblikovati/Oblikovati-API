namespace Oblikovati.API;

/// <summary>
/// The AssemblyEvents object provides notification of assembly events including change, delete and constraint.
/// </summary>
public interface AssemblyEvents : AssemblyEventsObject, AssemblyEventsSink_Event
{
}
