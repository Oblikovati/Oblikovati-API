namespace Oblikovati.API;

public interface AssemblyEventsSink_Event
{
    event AssemblyEventsSink_OnAssemblyChangedEventHandler OnAssemblyChanged;
    event AssemblyEventsSink_OnAssemblySolveEventHandler OnAssemblySolve;
    event AssemblyEventsSink_OnAssemblyChangeEventHandler OnAssemblyChange;
    event AssemblyEventsSink_OnNewOccurrenceEventHandler OnNewOccurrence;
    event AssemblyEventsSink_OnOccurrenceChangeEventHandler OnOccurrenceChange;
    event AssemblyEventsSink_OnNewConstraintEventHandler OnNewConstraint;
    event AssemblyEventsSink_OnNewRelationshipEventHandler OnNewRelationship;
    event AssemblyEventsSink_OnDeleteEventHandler OnDelete;
    event AssemblyEventsSink_OnLoadStateChangeEventHandler OnLoadStateChange;
}
