namespace Oblikovati.API;

public delegate void MiniToolbarSink_OnApplyEventHandler();

public delegate void MiniToolbarSink_OnCancelEventHandler();

public delegate void MiniToolbarSink_OnEndMoveEventHandler( NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void MiniToolbarSink_OnHideEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void MiniToolbarSink_OnMoveEventHandler( NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void MiniToolbarSink_OnOKEventHandler();

public delegate void MiniToolbarSink_OnShowEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void MiniToolbarSink_OnStartMoveEventHandler( NameValueMap Context,out HandlingCodeEnum HandlingCode);
