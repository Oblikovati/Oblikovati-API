﻿namespace Oblikovati.API;

public delegate void PublicationEventsSink_OnModelingDataUpdateEventHandler( _PresentationDocument DocumentObject, Publication Publication, EventTimingEnum BeforeOrAfter,out HandlingCodeEnum HandlingCode);
