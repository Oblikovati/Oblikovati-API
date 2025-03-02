namespace Oblikovati.API;

public delegate void IRxApplicationEvents_OnActivateDocumentEventHandler( _Document DocumentObject);

public delegate void IRxApplicationEvents_OnActivateViewEventHandler( View ViewObject);

public delegate void IRxApplicationEvents_OnCloseDocumentEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter);

public delegate void IRxApplicationEvents_OnCloseViewEventHandler( View ViewObject);

public delegate void IRxApplicationEvents_OnDeactivateDocumentEventHandler( _Document DocumentObject);

public delegate void IRxApplicationEvents_OnDeactivateViewEventHandler( View ViewObject);

public delegate void IRxApplicationEvents_OnNewDocumentEventHandler( _Document DocumentObject);

public delegate void IRxApplicationEvents_OnNewViewEventHandler( View ViewObject);

public delegate void IRxApplicationEvents_OnOpenDocumentEventHandler( _Document DocumentObject);

public delegate void IRxApplicationEvents_OnQuitEventHandler();

public delegate void IRxApplicationEvents_OnSaveDocumentEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter);
