namespace Oblikovati.API;

public delegate void IRxDocumentEvents_OnActivateEventHandler();

public delegate void IRxDocumentEvents_OnActivateViewEventHandler( View ViewObject);

public delegate void IRxDocumentEvents_OnCloseEventHandler( EventTimingEnum BeforeOrAfter);

public delegate void IRxDocumentEvents_OnCloseViewEventHandler( View ViewObject);

public delegate void IRxDocumentEvents_OnDeactivateEventHandler();

public delegate void IRxDocumentEvents_OnDeactivateViewEventHandler( View ViewObject);

public delegate void IRxDocumentEvents_OnNewViewEventHandler( View ViewObject);

public delegate void IRxDocumentEvents_OnSaveEventHandler( EventTimingEnum BeforeOrAfter);
