namespace Oblikovati.API;

public interface IRxFileAccessEvents_Event
{
    event IRxFileAccessEvents_OnFileResolutionEventHandler OnFileResolution;
    event IRxFileAccessEvents_OnFileDirtyEventHandler OnFileDirty;
}
