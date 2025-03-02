namespace Oblikovati.API;

public delegate void _DocPerformanceMonitorSink_OnDatabaseCloseEventHandler();

public delegate void _DocPerformanceMonitorSink_OnIdleEventHandler( NameValueMap Context);

public delegate void _DocPerformanceMonitorSink_OnIStorageCloseEventHandler();

public delegate void _DocPerformanceMonitorSink_OnIStorageOpenEventHandler( int OpenedWithFlags);

public delegate void _DocPerformanceMonitorSink_OnSegmentLoadEventHandler( string SegmentName);

public delegate void _DocPerformanceMonitorSink_OnViewUpdateEventHandler( object ViewObject, int BeforeOrAfter, NameValueMap Context);
