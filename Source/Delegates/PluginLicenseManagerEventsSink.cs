﻿namespace Oblikovati.API;

public delegate void PluginLicenseManagerEventsSink_OnChangeLicenseEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void PluginLicenseManagerEventsSink_OnLoseLicenseEventHandler( EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
