﻿namespace Oblikovati.API;

public delegate void BrowserPanesSink_OnBrowserNodeActivateEventHandler( object BrowserNodeDefinition, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void BrowserPanesSink_OnBrowserNodeDeleteEntryEventHandler( object BrowserNodeDefinition, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void BrowserPanesSink_OnBrowserNodeGetDisplayObjectsEventHandler( object BrowserNodeDefinition,out ObjectCollection Objects, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void BrowserPanesSink_OnBrowserNodeLabelEditEventHandler( object BrowserNodeDefinition, string NewLabel, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void BrowserPanesSink_OnBrowserNodesReorderEventHandler( BrowserPane BrowserPane, BrowserNodesEnumerator DragNodes, BrowserNode TargetNode, InsertionLocationTypeEnum eInsertionLoactionType, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
