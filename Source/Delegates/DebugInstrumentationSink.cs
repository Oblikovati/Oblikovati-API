namespace Oblikovati.API;

public delegate void DebugInstrumentationSink_ObjectAddRefdEventHandler( int Cookie, int ToReferenceCount);

public delegate void DebugInstrumentationSink_ObjectCreatedEventHandler( int Cookie);

public delegate void DebugInstrumentationSink_ObjectDestroyedEventHandler( int Cookie);

public delegate void DebugInstrumentationSink_ObjectQueryInterfacedEventHandler( int Cookie, string InterfaceIID, bool Successful);

public delegate void DebugInstrumentationSink_ObjectReleasedEventHandler( int Cookie, int ToReferenceCount);

public delegate void DebugInstrumentationSink_OnMemberInvokeEventHandler( int Cookie, string MemberName, EventTimingEnum BeforeOrAfter, int Result);
