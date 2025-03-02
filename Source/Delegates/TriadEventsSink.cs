namespace Oblikovati.API;

public delegate void TriadEventsSink_OnActivateEventHandler( NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnEndMoveEventHandler( TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, Matrix CoordinateSystem, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnEndSequence2EventHandler( bool Cancelled, Matrix CoordinateSystem, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnEndSequenceEventHandler( bool Cancelled, Matrix CoordinateSystem, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnMoveEventHandler( TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, Matrix CoordinateSystem, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnMoveTriadOnlyToggle2EventHandler( bool MoveTriadOnly, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnMoveTriadOnlyToggleEventHandler( bool MoveTriadOnly, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnSegmentSelectionChangeEventHandler( TriadSegmentEnum SelectedTriadSegment, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnStartMoveEventHandler( TriadSegmentEnum SelectedTriadSegment, ShiftStateEnum ShiftKeys, Matrix CoordinateSystem, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnStartSequenceEventHandler( Matrix CoordinateSystem, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnTerminate2EventHandler( bool Cancelled, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void TriadEventsSink_OnTerminateEventHandler( bool Cancelled, NameValueMap Context,out HandlingCodeEnum HandlingCode);
