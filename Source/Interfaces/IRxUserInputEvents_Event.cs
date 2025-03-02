namespace Oblikovati.API;

public interface IRxUserInputEvents_Event
{
    event IRxUserInputEvents_OnStartCommandEventHandler OnStartCommand;
    event IRxUserInputEvents_OnStopCommandEventHandler OnStopCommand;
}
