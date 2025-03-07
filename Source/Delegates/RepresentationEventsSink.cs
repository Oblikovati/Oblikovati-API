﻿namespace Oblikovati.API;

public delegate void RepresentationEventsSink_OnActivateDesignViewEventHandler( _Document DocumentObject, DesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void RepresentationEventsSink_OnActivateDesignViewRepresentationEventHandler( _AssemblyDocument DocumentObject, DesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void RepresentationEventsSink_OnActivateLevelOfDetailRepresentationEventHandler( _Document DocumentObject, LevelOfDetailRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void RepresentationEventsSink_OnActivatePositionalRepresentationEventHandler( _AssemblyDocument DocumentObject, PositionalRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void RepresentationEventsSink_OnDeleteEventHandler( _Document DocumentObject, object Entity, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void RepresentationEventsSink_OnNewDesignViewEventHandler( _Document DocumentObject, DesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void RepresentationEventsSink_OnNewDesignViewRepresentationEventHandler( _AssemblyDocument DocumentObject, DesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void RepresentationEventsSink_OnNewLevelOfDetailRepresentationEventHandler( _Document DocumentObject, LevelOfDetailRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void RepresentationEventsSink_OnNewPositionalRepresentationEventHandler( _AssemblyDocument DocumentObject, PositionalRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void RepresentationEventsSink_OnNewSectionViewEventHandler( _Document DocumentObject, DesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
