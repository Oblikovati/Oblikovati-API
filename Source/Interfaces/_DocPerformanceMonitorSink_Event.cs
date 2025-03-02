namespace Oblikovati.API;

public interface _DocPerformanceMonitorSink_Event
{
    event _DocPerformanceMonitorSink_OnSegmentLoadEventHandler OnSegmentLoad;
    event _DocPerformanceMonitorSink_OnDatabaseCloseEventHandler OnDatabaseClose;
    event _DocPerformanceMonitorSink_OnIStorageOpenEventHandler OnIStorageOpen;
    event _DocPerformanceMonitorSink_OnIStorageCloseEventHandler OnIStorageClose;
    event _DocPerformanceMonitorSink_OnViewUpdateEventHandler OnViewUpdate;
    event _DocPerformanceMonitorSink_OnIdleEventHandler OnIdle;
}
