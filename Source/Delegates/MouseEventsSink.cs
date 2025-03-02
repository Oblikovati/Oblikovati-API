namespace Oblikovati.API;

public delegate void MouseEventsSink_OnMouseClickEventHandler( MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View);

public delegate void MouseEventsSink_OnMouseDoubleClickEventHandler( MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View);

public delegate void MouseEventsSink_OnMouseDownEventHandler( MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View);

public delegate void MouseEventsSink_OnMouseLeaveEventHandler( MouseButtonEnum Button, ShiftStateEnum ShiftKeys, View View);

public delegate void MouseEventsSink_OnMouseMoveEventHandler( MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View);

public delegate void MouseEventsSink_OnMouseUpEventHandler( MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View);
