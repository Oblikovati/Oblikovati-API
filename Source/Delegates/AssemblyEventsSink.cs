namespace Oblikovati.API;

public delegate void AssemblyEventsSink_OnAssemblyChangedEventHandler( NameValueMap Context, EventTimingEnum BeforeOrAfter,out HandlingCodeEnum HandlingCode);

public delegate void AssemblyEventsSink_OnAssemblyChangeEventHandler( _AssemblyDocument DocumentObject, NameValueMap Context, EventTimingEnum BeforeOrAfter,out HandlingCodeEnum HandlingCode);

public delegate void AssemblyEventsSink_OnAssemblySolveEventHandler( _AssemblySolver Solver, EventTimingEnum BeforeOrAfter, NameValueMap Context);

public delegate void AssemblyEventsSink_OnDeleteEventHandler( _Document DocumentObject, object Entity, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void AssemblyEventsSink_OnLoadStateChangeEventHandler( _AssemblyDocument DocumentObject, DocumentLoadStateEnum NewLoadState, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void AssemblyEventsSink_OnNewConstraintEventHandler( _AssemblyDocument DocumentObject, object Constraint, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void AssemblyEventsSink_OnNewOccurrenceEventHandler( _AssemblyDocument DocumentObject, ComponentOccurrence Occurrence, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void AssemblyEventsSink_OnNewRelationshipEventHandler( _AssemblyDocument DocumentObject, object Relationship, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void AssemblyEventsSink_OnOccurrenceChangeEventHandler( _AssemblyDocument DocumentObject, ComponentOccurrence Occurrence, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
