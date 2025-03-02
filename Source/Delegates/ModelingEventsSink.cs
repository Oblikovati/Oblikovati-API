namespace Oblikovati.API;

public delegate void ModelingEventsSink_OnClientFeatureDoubleClickEventHandler( _Document DocumentObject, ClientFeature Feature, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnClientFeatureSolveEventHandler( _Document DocumentObject, ClientFeature Feature, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnDeleteEventHandler( _Document DocumentObject, object Entity, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnFeatureChangeEventHandler( _Document DocumentObject, PartFeature Feature, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnGeneralSurfaceProfileGDTSolveEventHandler( _Document DocumentObject, ModelAnnotation Annotation, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnGenerateMemberEventHandler( _Document FactoryDocumentObject, string MemberName, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnGenerateModelStateMemberEventHandler( _Document FactoryDocumentObject, string MemberName, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnModelAnnotationsScaleChangeEventHandler( _Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnModelAnnotationsSolveEventHandler( _Document DocumentObject, ModelAnnotations Annotations, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnNewFeatureEventHandler( _Document DocumentObject, PartFeature Feature, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnNewParameterEventHandler( _Document DocumentObject, Parameter Parameter, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnParameterChangeEventHandler( _Document DocumentObject, Parameter Parameter, EventTimingEnum BeforeOrAfter, NameValueMap Context,out HandlingCodeEnum HandlingCode);

public delegate void ModelingEventsSink_OnPreGenerateMemberEventHandler( _Document FactoryDocumentObject, string MemberName, NameValueMap Context,out HandlingCodeEnum HandlingCode);
