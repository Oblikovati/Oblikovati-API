namespace Oblikovati.API;

public interface ModelingEventsSink_Event
{
    event ModelingEventsSink_OnDeleteEventHandler OnDelete;
    event ModelingEventsSink_OnNewFeatureEventHandler OnNewFeature;
    event ModelingEventsSink_OnFeatureChangeEventHandler OnFeatureChange;
    event ModelingEventsSink_OnNewParameterEventHandler OnNewParameter;
    event ModelingEventsSink_OnParameterChangeEventHandler OnParameterChange;
    event ModelingEventsSink_OnClientFeatureDoubleClickEventHandler OnClientFeatureDoubleClick;
    event ModelingEventsSink_OnClientFeatureSolveEventHandler OnClientFeatureSolve;
    event ModelingEventsSink_OnGenerateMemberEventHandler OnGenerateMember;
    event ModelingEventsSink_OnPreGenerateMemberEventHandler OnPreGenerateMember;
    event ModelingEventsSink_OnModelAnnotationsSolveEventHandler OnModelAnnotationsSolve;
    event ModelingEventsSink_OnGeneralSurfaceProfileGDTSolveEventHandler OnGeneralSurfaceProfileGDTSolve;
    event ModelingEventsSink_OnModelAnnotationsScaleChangeEventHandler OnModelAnnotationsScaleChange;
    event ModelingEventsSink_OnGenerateModelStateMemberEventHandler OnGenerateModelStateMember;
}
