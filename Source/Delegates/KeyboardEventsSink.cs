namespace Oblikovati.API;

public delegate void KeyboardEventsSink_OnKeyDownEventHandler( int Key, ShiftStateEnum ShiftKeys);

public delegate void KeyboardEventsSink_OnKeyPressEventHandler( int KeyASCII);

public delegate void KeyboardEventsSink_OnKeyUpEventHandler( int Key, ShiftStateEnum ShiftKeys);
