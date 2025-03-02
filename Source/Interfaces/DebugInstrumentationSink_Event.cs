namespace Oblikovati.API;

public interface DebugInstrumentationSink_Event
{
    event DebugInstrumentationSink_ObjectCreatedEventHandler ObjectCreated;
    event DebugInstrumentationSink_ObjectDestroyedEventHandler ObjectDestroyed;
    event DebugInstrumentationSink_ObjectAddRefdEventHandler ObjectAddRefd;
    event DebugInstrumentationSink_ObjectReleasedEventHandler ObjectReleased;
    event DebugInstrumentationSink_ObjectQueryInterfacedEventHandler ObjectQueryInterfaced;
    event DebugInstrumentationSink_OnMemberInvokeEventHandler OnMemberInvoke;
}
