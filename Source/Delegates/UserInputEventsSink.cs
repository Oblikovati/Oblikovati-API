namespace Oblikovati.API;

public delegate void UserInputEventsSink_OnActivateCommandEventHandler( string CommandName, NameValueMap Context);

public delegate void UserInputEventsSink_OnContextMenuEventHandler( SelectionDeviceEnum SelectionDevice, NameValueMap AdditionalInfo, CommandBar CommandBar);

public delegate void UserInputEventsSink_OnContextMenuOldEventHandler( SelectionDeviceEnum SelectionDevice, NameValueMap AdditionalInfo, CommandBar CommandBar);

public delegate void UserInputEventsSink_OnContextualMiniToolbarEventHandler( ObjectsEnumerator SelectedEntities, NameValueMap DisplayedCommands, NameValueMap AdditionalInfo);

public delegate void UserInputEventsSink_OnDeleteKeyUpEventHandler( ObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, View View, NameValueMap AdditionalInfo,out HandlingCodeEnum HandlingCode);

public delegate void UserInputEventsSink_OnDoubleClickEventHandler( ObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View, NameValueMap AdditionalInfo,out HandlingCodeEnum HandlingCode);

public delegate void UserInputEventsSink_OnDragEventHandler( DragStateEnum DragState, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View, NameValueMap AdditionalInfo,out HandlingCodeEnum HandlingCode);

public delegate void UserInputEventsSink_OnLinearMarkingMenuEventHandler( ObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, CommandControls LinearMenu, NameValueMap AdditionalInfo);

public delegate void UserInputEventsSink_OnMarkTutorialCommandEventHandler( string CommandID, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void UserInputEventsSink_OnPreSelectEventHandler(ref object PreSelectEntity,out bool DoHighlight,ref ObjectCollection MorePreSelectEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);

public delegate void UserInputEventsSink_OnRadialMarkingMenuEventHandler( ObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, RadialMarkingMenu RadialMenu, NameValueMap AdditionalInfo);

public delegate void UserInputEventsSink_OnSelectEventHandler( ObjectsEnumerator JustSelectedEntities,ref ObjectCollection MoreSelectedEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);

public delegate void UserInputEventsSink_OnStartCommandEventHandler( CommandIDEnum CommandID);

public delegate void UserInputEventsSink_OnStopCommandEventHandler( CommandIDEnum CommandID);

public delegate void UserInputEventsSink_OnStopPreSelectEventHandler( Point ModelPosition, Point2d ViewPosition, View View);

public delegate void UserInputEventsSink_OnTerminateCommandEventHandler( string CommandName, NameValueMap Context);

public delegate void UserInputEventsSink_OnUnSelectEventHandler( ObjectsEnumerator UnSelectedEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);
