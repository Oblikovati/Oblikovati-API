namespace Oblikovati.API;

public delegate void SketchEventsSink_OnDeleteEventHandler( _Document DocumentObject, object Entity, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void SketchEventsSink_OnNewSketch3DEventHandler( _Document DocumentObject, Sketch3D Sketch3D, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void SketchEventsSink_OnNewSketchEventHandler( _Document DocumentObject, Sketch Sketch, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void SketchEventsSink_OnSketch3DChangeEventHandler( _Document DocumentObject, Sketch3D Sketch3D, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void SketchEventsSink_OnSketch3DSolveEventHandler( _Document DocumentObject, object Sketch, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void SketchEventsSink_OnSketchChangeEventHandler( _Document DocumentObject, Sketch Sketch, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);
