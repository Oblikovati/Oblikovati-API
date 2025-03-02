namespace Oblikovati.API;

public interface FileAccessEventsSink_Event
{
    event FileAccessEventsSink_OnFileResolutionEventHandler OnFileResolution;
    event FileAccessEventsSink_OnFileDirtyEventHandler OnFileDirty;
}
