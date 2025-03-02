namespace Oblikovati.API;

public interface ChangeProcessorSink_Event
{
    event ChangeProcessorSink_OnExecuteEventHandler OnExecute;
    event ChangeProcessorSink_OnReadFromScriptEventHandler OnReadFromScript;
    event ChangeProcessorSink_OnWriteToScriptEventHandler OnWriteToScript;
    event ChangeProcessorSink_OnTerminateEventHandler OnTerminate;
}
