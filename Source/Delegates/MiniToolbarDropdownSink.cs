namespace Oblikovati.API;

public delegate void MiniToolbarDropdownSink_OnItemHoverEndEventHandler( MiniToolbarListItem ListItem);

public delegate void MiniToolbarDropdownSink_OnItemHoverStartEventHandler( MiniToolbarListItem ListItem);

public delegate void MiniToolbarDropdownSink_OnItemRemoveEventHandler( MiniToolbarListItem ListItem);

public delegate void MiniToolbarDropdownSink_OnPreMenuDisplayEventHandler();

public delegate void MiniToolbarDropdownSink_OnSelectEventHandler( MiniToolbarListItem ListItem);
