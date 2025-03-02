namespace Oblikovati.API;

public delegate void SelectEventsSink_OnPreSelectEventHandler(ref object PreSelectEntity,out bool DoHighlight,ref ObjectCollection MorePreSelectEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);

public delegate void SelectEventsSink_OnPreSelectMouseMoveEventHandler( object PreSelectEntity, Point ModelPosition, Point2d ViewPosition, View View);

public delegate void SelectEventsSink_OnSelectEventHandler( ObjectsEnumerator JustSelectedEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);

public delegate void SelectEventsSink_OnStopPreSelectEventHandler( Point ModelPosition, Point2d ViewPosition, View View);

public delegate void SelectEventsSink_OnUnSelectEventHandler( ObjectsEnumerator UnSelectedEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);
